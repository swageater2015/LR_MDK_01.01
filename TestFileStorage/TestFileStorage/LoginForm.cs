using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFileStorage
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            List<User> users = new List<User>();
            FileUsersStorage UserInfo = new FileUsersStorage();
            users = UserInfo.Load();

            foreach (User element in users)
            {
                if (LoginComboBox.Text == element.GetLogin() && PasswordTextBox.Text == element.GetPassword())
                {
                    MessageBox.Show("Логин и пароль введены верно");
                    return;
                }
            }
            MessageBox.Show("Логин или пароль введены неверно");
            
        }
    }
}
