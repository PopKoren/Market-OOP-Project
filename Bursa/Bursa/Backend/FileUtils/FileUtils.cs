using Bursa.Backend.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Bursa.Backend
{
    public class FileUtils
    { 
        public static void SaveUsersToFile(BindingList<User> Users)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileInfo fi = new System.IO.FileInfo("users.bin");
            using (var binaryFile = fi.Create())
            {
                binaryFormatter.Serialize(binaryFile, Users);
                binaryFile.Flush();
            }
        }

        public static BindingList<User> LoadUsersFromFile()
        {
            BindingList<User> Users;
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileInfo fi = new System.IO.FileInfo("users.bin");
                using (var binaryFile = fi.OpenRead())
                {
                    Users = (BindingList<User>)binaryFormatter.Deserialize(binaryFile);
                }
            }
            catch (Exception)
            {
                Users = new BindingList<User>();
            }
            return Users;
        }
    }
}
