using Bursa.Backend.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bursa.Backend
{
    public abstract class UserManager
    {
        public static BindingList<User> users;
        static UserManager()
        {
            users = FileUtils.LoadUsersFromFile();
        }

        public static BindingList<User> GetUsers()
        {
            return users;
        }

        public static void AddUser(User newuser)
        {
            users.Add(newuser);
        }
        public static void DeleteUser(User newuser)
        {
            users.Remove(newuser);
            User.UserID--;

        }

        public static void SaveUsers(object sender, FormClosingEventArgs e)
        {
            FileUtils.SaveUsersToFile(users);
        }



    }
 
}
