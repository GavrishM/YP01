using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary.Models;

namespace InventoryManagementSystem
{
    public partial class MainForm: Form
    {
        private List<User> users_;
        public MainForm()
        {
            users_ = new List<User>();
            InitializeComponent();
            users_.Add(new User("Login1", "Password1"));
            users_.Add(new User("Login2", "Password2"));
        }

        private void UsersToolStripButton_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm(users_);
            usersForm.Show();
        }
    }
}
