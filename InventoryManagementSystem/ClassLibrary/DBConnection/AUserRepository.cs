using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DBConnection
{
    public class TUserRepository : IUserRepository
    {
        public DBConnection Connection { get; set; }
        public List<User> Users { get; set; }
        public TUserRepository(/*DBConnection connection*/)
        {
            //Connection = connection;
            Users.Add( new User("login1", "password1", "name1", "email1", "phone1") );
            Users.Add( new User("login2", "password2", "name2", "email2", "phone2") );
            Users.Add( new User("login3", "password3", "name3", "email3", "phone3") );
            Users.Add( new User("login4", "password4", "name4", "email4", "phone4") );
            Users.Add( new User("login5", "password5", "name5", "email5", "phone5") );
            Users.Add( new User("login6", "password6", "name6", "email6", "phone6") );
            Users.Add( new User("login7", "password7", "name7", "email7", "phone7") );

        }
        public bool CheckIfLoginExists(string login)
        {
            User user = new User();
            user = GetUser(login);
            if (user.Login != login)
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
            SHA256 sha256 = SHA256.Create();
            byte[] dataBytes = Encoding.UTF8.GetBytes(user.Password);
            byte[] hashBytes = sha256.ComputeHash(dataBytes);

            // Преобразуем байтовый массив в строку для вывода
            string hashString = BitConverter.ToString(hashBytes).Replace("-", "");
            user.Password = hashString;


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
            result = Users;
            return result;
        }
    }
}
