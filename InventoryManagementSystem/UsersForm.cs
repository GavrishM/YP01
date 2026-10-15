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
using ClassLibrary.Validators;

namespace InventoryManagementSystem
{
    public partial class UsersForm : Form
    {
        private List<User> users_;
        private List<string> usersLogins_ = new List<string>();
        private string saveButtonContext_ = ""; //Контекст кнопки SaveButton
        public UsersForm(List<User> users)
        {
            users_ = users;
            foreach(User user in users_)
            { usersLogins_.Add(user.Login); }
            InitializeComponent();
            UsersListBox.DataSource = usersLogins_;
        }

        private void UsersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(User user in users_)
            {
                if(user.Login == usersLogins_[UsersListBox.SelectedIndex])
                {
                    LoginTextBox.Text = user.Login;
                    PasswordTextBox.Text = user.Password;
                    NameTextBox.Text = user.Name;
                    EmailTextBox.Text = user.Email;
                    PhoneTextBox.Text = user.Phone;
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            saveButtonContext_ = "Create";
            LoginTextBox.Enabled = true;
            LoginTextBox.Text = "";
            PasswordTextBox.Enabled = true;
            PasswordTextBox.Text = "";
            NameTextBox.Enabled = true;
            NameTextBox.Text = "";
            EmailTextBox.Enabled = true;
            EmailTextBox.Text = "";
            PhoneTextBox.Enabled = true;
            PhoneTextBox.Text = "";
            CancelButton.Enabled = true;
            SaveButton.Enabled = true;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            saveButtonContext_ = "Update";
            LoginTextBox.Enabled = true;
            PasswordTextBox.Enabled = true;
            NameTextBox.Enabled = true;
            EmailTextBox.Enabled = true;
            PhoneTextBox.Enabled = true;
            CancelButton.Enabled = true;
            SaveButton.Enabled = true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            LoginTextBox.Enabled = false;
            PasswordTextBox.Enabled = false;
            NameTextBox.Enabled = false;
            EmailTextBox.Enabled = false;
            PhoneTextBox.Enabled = false;
            CancelButton.Enabled = false;
            SaveButton.Enabled = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            bool[] validationResults = new bool[6];
            if (saveButtonContext_ == "Create")
            {

            }
            if (saveButtonContext_ == "Update")
            {

            }
            LoginTextBox.Enabled = false;
            PasswordTextBox.Enabled = false;
            NameTextBox.Enabled = false;
            EmailTextBox.Enabled = false;
            PhoneTextBox.Enabled = false;
            CancelButton.Enabled = false;
            SaveButton.Enabled = false;
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
