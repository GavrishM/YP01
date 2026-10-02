using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DBConnection
{
    public interface IUserRepository
    {
        bool CheckIfLoginExists(string login);
        bool AddUser(User user);
    }
}
