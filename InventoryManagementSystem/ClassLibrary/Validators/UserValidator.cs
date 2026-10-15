using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Validators
{
    public class UserValidator : IUserValidator
    {
        public bool ValidateLogin(string login)
        {
            bool result = true;

            return result;
        }

        public bool ValidatePassword(string password)
        {
            bool result = true;

            return result;
        }
        public bool ValidateName(string fullName)
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
