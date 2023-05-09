using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bursa.Backend.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime Dateofbirth { get; set; }
        public string Email { get; set; }
        public double Balance { get; set; }

        protected User(string username, string password, DateTime dateofbirth, string email, double balance = 0)
        {
            Username = username;
            Password = password;
            Dateofbirth = dateofbirth;
            Email = email;
            Balance = balance;
        }


    }
}
