using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFileStorage
{
    
    public class User
    {
        string login_;
        string password_;
        public User(string login, string password)
        {
            login_ = login;
            password_ = password;
        }
        public string GetLogin()
        {
            return login_;
        }
        public string GetPassword()
        {
            return password_;
        }
    }
    
}
