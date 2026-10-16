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
        public string ValidateLogin(string login)
        {
            string result = "true";
            if ((login == null) || (login == ""))
            { result = "empty login"; }
            if ((login.Length < 3) || (login.Length > 50))
            { result = "incorect login length"; }
            if (Repository.CheckIfLoginExists(login))
            { result = "login exists"; }
            return result;
        }

        public string ValidatePassword(string password)
        {
            string result = "true";

            return result;
        }
        public string ValidateName(string name)
        {
            string result = "true";

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
