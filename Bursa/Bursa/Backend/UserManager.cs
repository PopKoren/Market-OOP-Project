using Bursa.Backend.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bursa.Backend
{
    public class UserManager
    {
        private static BindingList<User> users = new BindingList<User>();

        public static BindingList<User> GetUsers()
        {
            return users;
        }

        public static void AddUser(User newuser)
        {
            users.Add(newuser);
        }




    }
 
}
