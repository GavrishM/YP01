using ClassLibrary.DBConnection;
using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Validators
{
    public interface IUserValidator
    {
        DBConnection.DBConnection Connection { get; set; }
        IUserRepository Repository { get; set; }
        string ValidateLogin(string login);
        string ValidatePassword(string password);
        string ValidateName(string name);
        bool ValidateEmail(string email);
        bool ValidatePhone(string phone);
        bool ValidateAll(User user);
    }
}
