using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.DBConnection;
using System.Data.Common;

namespace ClassLibrary.Validators
{
    public class UserValidator : IUserValidator
    {
        public DBConnection.DBConnection Connection {  get; set; }
        public IUserRepository Repository {  get; set; }

        public UserValidator(DBConnection.DBConnection connection, IUserRepository userRepository)
        {
            Connection = connection;
            Repository = userRepository;
        }
        public bool ValidateLogin(string login)
        {
            bool result = true;
            if ((login.Length < 3) || (login.Length > 50))
            { result = false; }
            if (Repository.CheckIfLoginExists(login))
            { result = false; }
            return result;
        }

        public bool ValidatePassword(string password)
        {
            bool result = true;
            if ((password.Length < 6) || (password.Length > 100))
            {  result = false; }
            return result;
        }
        public bool ValidateName(string name)
        {
            bool result = true;

            return result;
        }
        public bool ValidateEmail(string email)
        {
            bool result = true;

            return result;
        }
        public bool ValidatePhone(string phone)
        {
            bool result = true;

            return result;
        }
        public bool ValidateAll(User user)
        {
            bool result = true;

            return result;
        }
    }
}
