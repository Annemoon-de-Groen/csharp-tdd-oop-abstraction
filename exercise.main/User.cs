using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class User
    {
        private string _email;
        private string _password;
        private bool _isEnabled;

        public bool IsEnabled { get { return _isEnabled; } }

        public User(string email, string password)
        {
            if (!ValidPassword(password))
            {
                Console.WriteLine("Invalid password");
                return;
            }
            if (!ValidEmail(email))
            {
                Console.WriteLine("Invalid email");
                return;
            }
            _email = email;
            _password = password;
        }

        private bool ValidPassword(string password)
        {
            return password.Length > 8;
        }
        private bool ValidEmail(string email)
        {
            return email.Contains('@');
        }


        public bool EnableAccount(string user)
        {
            //Check whether user has the right credentials
            if (user == "hasPermission")
                _isEnabled = true;
            return _isEnabled;
        }

    }
}
