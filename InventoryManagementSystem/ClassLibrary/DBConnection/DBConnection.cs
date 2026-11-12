using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Models;

namespace ClassLibrary.DBConnection
{
    public class DBConnection
    {
        private readonly string connectionString_;
        public string GetConnectionString()
        {
            return connectionString_;
        }
        public DBConnection()
        {
            string filePath = "Config.txt";

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string[] connectionLine = new string[2];
                    connectionLine[0] = "DBConnection";
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        connectionLine = line.Split('=');
                        if (connectionLine[0] == "DBConnection")
                        { connectionString_ = connectionLine[1]; }
                    }
                }
            }
            catch (IOException e)
            {
                string errorFilePath = "Errors.txt";
                using (StreamWriter writer = new StreamWriter(errorFilePath, true))
                {
                    writer.WriteLine("Не удалось получить строку соединение с БД");
                    writer.WriteLine(e);
                }
            }
        }
        public bool AddUser(IUser user)
        {
            bool result = false;



            return result;
        }
        public bool UpdateUser(IUser user)
        {
            bool result = false;



            return result;
        }
        public User GetUser(string login)
        {
            User result = new User();



            return result;
        }
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();


            return users;
        }
    }
}
