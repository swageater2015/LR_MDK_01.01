using Npgsql;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBTestWinForm
{
    public class PgUsersLoader
    {
        BindingList<User> loader = new BindingList<User>();
         private const string connectSetting = "Host=192.168.1.48;Username=st50-10;Password=5010;Database=MDK01.01_Kuvaldaev";
        public BindingList<User> Load() 
        {
            try
            {               
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "SELECT login, password, age, name, last_name From myusers";
                var cmd = new NpgsqlCommand(sql, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User user = new User
                    {
                        Login = reader.GetString(0),
                        Password = reader.GetString(1),
                        Age = reader.GetInt32(2),
                        Name = reader.GetString(3),
                        LastName = reader.GetString(4)
                    };
                    loader.Add(user);
                }
                return loader;
            }
            catch(NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return null;
            }
        }         
        public bool DeleteSelectedUser(string Login)
        {
            try
            {
                bool deleteResult = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "DELETE FROM myusers Where login = @login";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", Login);              
                    int execute = cmd.ExecuteNonQuery();
                    if (execute > 0)
                    {
                        deleteResult = true;
                        for (int index = 0; index < loader.Count; index++)
                        {
                            if (loader[index].Login == Login)
                            {
                                loader.RemoveAt(index);
                                index--;
                            }
                        }
                    }
                    return deleteResult;                              
            }
            catch(NpgsqlException exception) 
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return false;
            }
        }
        public bool ClearAllUsers() 
        {
            try
            {
                bool result = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "DELETE FROM myusers";
                var cmd = new NpgsqlCommand(sql, con);
               
                    int execute = cmd.ExecuteNonQuery();
                    if (execute > 0)
                    {
                        result = true;
                        loader.Clear();
                    }
                    return result;                
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return false;
            }
        }
        public bool AddUser(User user) 
        {
            try 
            {
                bool addResult = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "INSERT INTO myusers(login, password, name, age) VALUES(@login, @password, @name ,@age)";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", user.Login);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@age", user.Age);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    addResult = true;
                    loader.Add(user);
                }
                return addResult;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return false;
            }
        }
        public bool EditUser(User user)
        {
            try
            {
                bool result = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "UPDATE users SET password = @password, name = @name, age = @age, last_name = @last_name WHERE login = @login";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", user.Login);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@age", user.Age);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    result = true;
                    loader.Add(user);
                }
                return result;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return false;
            }
        }
    }
}
