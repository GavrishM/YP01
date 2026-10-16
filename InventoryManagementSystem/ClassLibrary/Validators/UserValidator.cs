using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.DBConnection;
using System.Data.Common;

namespace ClassLibrary.Validators
{
    public class UserValidator : IUserValidator
    {
        public DBConnection.DBConnection Connection {  get; set; }
        public IUserRepository Repository {  get; set; }

        public UserValidator(DBConnection.DBConnection connection, IUserRepository userRepository)
        {
            Connection = connection;
            Repository = userRepository;
        }
        public bool ValidateLogin(string login)
        {
            if ((login.Length < 3) || (login.Length > 50))
            { return false; }
            if (Repository.CheckIfLoginExists(login))
            { return false; }
            return true;
        }

        public bool ValidatePassword(string password)
        {
            if ((password.Length < 6) || (password.Length > 100))
            {  return false; }
            return true;
        }
        public bool ValidateName(string name)
        {
            string alphabet = "ёйцукенгшщзхъфывапролджэячсмитьбюЁЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ"
                            + " qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
            if ((name.Length < 1))
            {  return false; }
            foreach (char c in name)
            {
                if (alphabet.Contains(c) != true)
                {  return false; }
            }
            return true;
        }
        public bool ValidateEmail(string email) //имя@домен.зона
        {
            string alphabet = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM0123456789";
            string[] splited = alphabet.Split('@');

            if (splited.Length != 2)
            { return false; }

            foreach(char c in splited[0])
            {
                if (alphabet.Contains(c) != true)
                { return false; }
            }

            splited = splited[1].Split('.');

            if (splited.Length != 2)
            { return false; }

            foreach (char c in splited[0])
            {
                if (alphabet.Contains(c) != true)
                { return false; }
            }
            foreach (char c in splited[1])
            {
                if (alphabet.Contains(c) != true)
                { return false; }
            }

            return true;
        }
        public bool ValidatePhone(string phone) //+7 (XXX) XXX-XX-XX
        {
            string alphabet = "0123456789";
            string[] splited = phone.Split(' ');

            if (splited.Length != 3)
            { return false; }

            if (splited[0] != "+7")
            { return false; }

            if (splited[1].Length != 5)
            { return false; }
            if ((splited[1][0] != '(') || (splited[1][4] != ')'))
            {  return false; }

            string temp = (splited[1][1] + splited[1][2] + splited[1][3]).ToString();
            foreach(char c in temp)
            {
                if (alphabet.Contains(c) != true)
                { return false; }
            }

            splited = splited[2].Split('-');

            if (splited.Length != 3)
            { return false; }

            if (splited[0].Length != 3)
            { return false; }
            foreach (char c in splited[0])
            {
                if (alphabet.Contains(c) != true)
                { return false; }
            }

            if (splited[1].Length != 2)
            { return false; }
            foreach (char c in splited[1])
            {
                if (alphabet.Contains(c) != true)
                { return false; }
            }

            if (splited[2].Length != 2)
            { return false; }
            foreach (char c in splited[2])
            {
                if (alphabet.Contains(c) != true)
                { return false; }
            }

            return true;
        }
        public bool ValidateAll(User user)
        {
            bool result = true;

            return result;
        }
    }
}
