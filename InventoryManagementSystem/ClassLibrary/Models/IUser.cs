using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public interface IUser
    {
        string Login { get; set; }
        string Password { get; set; }
        string Name { get; set; }
        string Email { get; set; }
        string Phone { get; set; }
    }
}
