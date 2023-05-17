using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bursa.Backend.Models
{
    [Serializable]
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Dateofbirth { get; set; }
        public string Email { get; set; }
        public double TotalBalance { get; set; }

        public User(string username, string password, DateTime dateofbirth, string email, double balance = 0)
        {
            Username = username;
            Password = password;
            Dateofbirth = dateofbirth.ToShortDateString();
            Email = email;
            TotalBalance = balance;

        }


    }
}
