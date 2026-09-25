using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }

        public User (int id,
                     string login,
                     string password,
                     string role)
        {
            Id = id;
            Login = login;
            Password = password;
            Role = role;
        }
        public User(int id,
                    string login,
                    string password,
                    string name,
                    string email,
                    string phone,
                    string role)
        {
            Id = id;
            Login = login;
            Password = password;
            Name = name;
            Email = email;
            Phone = phone;
            Role = role;
        }
    }
}
