using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Models;
using System.Security.Cryptography;

namespace ClassLibrary.DBConnection
{
    public class UserRepository : IUserRepository
    {
        public DBConnection Connection {  get; set; }
        public List<User> Users { get; set; }
        public UserRepository(DBConnection connection)
        {
            Connection = connection;
            GetAllUsers();
        }
        public bool CheckIfLoginExists(string login)
        {
            User user = new User();
            user = GetUser(login);
            if (user.Login!=login)
            { return false; }
            return true;
        }
        public bool CheckPassword(string login, string password)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] dataBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashBytes = sha256.ComputeHash(dataBytes);

            // Преобразуем байтовый массив в строку для вывода
            string hashString = BitConverter.ToString(hashBytes).Replace("-", "");
            string codedPassword = hashString;
            if (CheckIfLoginExists(login))
            {
                User user = GetUser(login);
                if (codedPassword == user.Password)
                { return true; }
            }
            return false;
        }
        public bool AddUser(User user)
        {
            if (CheckIfLoginExists(user.Login))
            { return false; }
            SHA256 sha256 = SHA256.Create();
            byte[] dataBytes = Encoding.UTF8.GetBytes(user.Password);
            byte[] hashBytes = sha256.ComputeHash(dataBytes);

            // Преобразуем байтовый массив в строку для вывода
            string hashString = BitConverter.ToString(hashBytes).Replace("-", "");
            user.Password = hashString;
            if (Connection.AddUser(user))
            { Users.Add(user); return true; }
            return false;
        }
        public bool UpdateUser(User user)
        {
            if (CheckIfLoginExists(user.Login) == false)
            { return false; }
            SHA256 sha256 = SHA256.Create();
            byte[] dataBytes = Encoding.UTF8.GetBytes(user.Password);
            byte[] hashBytes = sha256.ComputeHash(dataBytes);

            // Преобразуем байтовый массив в строку для вывода
            string hashString = BitConverter.ToString(hashBytes).Replace("-", "");
            user.Password = hashString;
            if (Connection.UpdateUser(user))
            {
                for(int i = 0; i < Users.Count; i++)
                {
                    if (user.Login == Users[i].Login)
                    { Users[i] = user; }
                }
                return true;
            }
            return false;
        }
        public User GetUser(string login)
        {
            User result = new User();
            foreach(User u in Users)
            {
                if (u.Login == login)
                { result = u; break; }
            }
            return result;
        }
        public List<User> GetAllUsers()
        {
            List<User> result = new List<User>();


            Users = result;
            return result;
        }
    }
}
/*
    string data = "Пример данных";
    SHA256 sha256 = SHA256.Create();
    byte dataBytes = Encoding.UTF8.GetBytes(data);
    byte hashBytes = sha256.ComputeHash(dataBytes); 

    // Преобразуем байтовый массив в строку для вывода
    string hashString = BitConverter.ToString(hashBytes).Replace("-", "");
    Console.WriteLine(hashString);
*/