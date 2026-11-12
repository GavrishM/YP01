using ClassLibrary.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ClassLibrary.DBConnection
{
    public class DBConnection : IDBConnection
    {
        public string ConnectionString {  get; set; }
        public DBConnection()
        {
            string filePath = "Config.txt";

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string[] connectionLine = new string[2];
                    connectionLine[0] = "DBConnection";
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        connectionLine = line.Split('=');
                        if (connectionLine[0] == "DBConnection")
                        { ConnectionString = connectionLine[1]; }
                    }
                }
            }
            catch (IOException e)
            {
                string errorFilePath = "Errors.txt";
                using (StreamWriter writer = new StreamWriter(errorFilePath, true))
                {
                    writer.WriteLine("Не удалось получить строку соединение с БД");
                    writer.WriteLine(e);
                }
            }
        }
        public bool AddUser(User user)
        {
            try
            {
                var con = new NpgsqlConnection(ConnectionString);
                con.Open();
                var sql = @"INSERT INTO users (login, password, name, email, phone) VALUES (@login, @password, @name, @email, @phone)";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", user.Name);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@phone", user.Phone);
                int changedRows = cmd.ExecuteNonQuery();
                if (changedRows < 1)
                {
                    return false;
                }
                return true;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
        }
        public bool UpdateUser(User user)
        {
            try
            {
                var con = new NpgsqlConnection(ConnectionString);
                con.Open();
                var sql = @"UPDATE users SET login = @login, password = @password, name = @name, email = @email, phone = @phone WHERE login = @login";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", user.Login);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@phone", user.Phone);
                int changedRows = cmd.ExecuteNonQuery();

                if (changedRows < 1)
                {
                    return false;
                }
                return true;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool DeleteUser(string login)
        {
            try
            {
                var con = new NpgsqlConnection(ConnectionString);
                con.Open();
                var sql = @"DELETE FROM users WHERE login = @login";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", login);
                int changedRows = cmd.ExecuteNonQuery();

                if (changedRows < 1)
                {
                    return false;
                }
                return true;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public User GetUser(string login)
        {
            User result = new User();
            try
            {
                var con = new NpgsqlConnection(ConnectionString);
                con.Open();
                var sql = @"SELECT login, password, name, email, phone FROM users WHERE login = @login";
                var cmd = new NpgsqlCommand(sql, con);
                var reader = cmd.ExecuteReader();
                cmd.Parameters.AddWithValue("@login", login);
                int changedRows = cmd.ExecuteNonQuery();
                User user = new User
                {
                    Login = reader.GetString(0),
                    Password = reader.GetString(1),
                    Name = reader.GetString(2),
                    Email = reader.GetString(3),
                    Phone = reader.GetString(4)
                };
                return user;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


            return result;
        }
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            try
            {
                var con = new NpgsqlConnection(ConnectionString);

                con.Open();
                var sql = "SELECT login, password, name, email, phone FROM users";
                var cmd = new NpgsqlCommand(sql, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    users.Add(new User
                    {
                        Login = reader.GetString(0),
                        Password = reader.GetString(1),
                        Name = reader.GetString(2),
                        Email = reader.GetString(3),
                        Phone = reader.GetString(4)
                    });
                }
                con.Close();

                return users;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            return users;
        }
    }
}
