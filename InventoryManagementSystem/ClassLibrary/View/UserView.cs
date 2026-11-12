using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.View
{
    public class UserView
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public UserView() { }
        public UserView(User user)
        {
            Login = user.Login;
            Name = user.Name;
            Email = user.Email;
            Phone = user.Phone;
        }
    }
}
