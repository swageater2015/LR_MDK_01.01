using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFileStorage
{
    public class FileUsersStorage : IUsersInterface
    {
        public List<User> Load()
        {
            List<User> result = new List<User>();
            string path = "C:\\Lemehov's repository\\TestFileStorage\\Logins&Passwords.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] UserInfo = line.Split('-');
                    User user = new User(UserInfo[0], UserInfo[1]);
                    result.Add(user);
                }
                
            }
            return result;
        }
    }
}
