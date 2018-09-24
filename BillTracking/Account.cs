using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillTracking
{
    public class Account
    {
        private string username;
        private string pin;
        private string email;

        public Account(string username, string pin, string email)
        {
            this.username = username;
            this.pin = pin;
            this.email = email;
        }

        public string Username { get => username; set => username = value; }
        public string Pin { get => pin; set => pin = value; }
        public string Email { get => email; set => email = value; }
    }
}
