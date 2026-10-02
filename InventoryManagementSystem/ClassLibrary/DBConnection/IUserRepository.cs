using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.DBClasses;

namespace ClassLibrary.DBConnection
{
    public interface IUserRepository
    {
        bool CheckIfLoginExists(string login);
        bool CheckPassword(string login, string password);
        bool AddUser(User user);
        User GetUser(string login);
        List<User> GetAllUsers();
        
    }
}
