using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DBConnection
{
    public interface IDBConnection
    {
        string ConnectionString { get; set; }
        bool AddUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(string login);
        User GetUser(string login);
        List<User> GetAllUsers();
    }
}
