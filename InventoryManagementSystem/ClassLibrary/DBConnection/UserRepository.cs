using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.DBClasses;
using System.Security.Cryptography;

namespace ClassLibrary.DBConnection
{
    public class UserRepository : IUserRepository
    {

        public bool CheckIfLoginExists(string login)
        {
            bool result = false;



            return result;
        }
        public bool CheckPassword(string login, string password)
        {
            bool result = false;
            string codedPassword = "";


            return result;
        }
        public bool AddUser(User user)
        {
            bool result = false;
            string codedPassword = "";


            return result;
        }
        public User GetUser(string login)
        {
            User result = new User();

            return result;
        }
        public List<User> GetAllUsers()
        {
            List<User> result = new List<User>();



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