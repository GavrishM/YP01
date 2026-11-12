using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Models;

namespace ClassLibrary.DBConnection
{
    public interface IUserRepository
    {
        DBConnection Connection { get; set; }
        List<User> Users { get; set; }
        bool CheckIfLoginExists(string login);
        bool CheckPassword(string login, string password);
        bool AddUser(User user);
        bool UpdateUser(User user);
        User GetUser(string login);
        List<User> GetAllUsers();
        
    }
}
