using DAL.Context;
using DAL.Enums;
using DAL.Interfaces;
using DAL.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace DAL.DAO
{
    public class UserDao : IUserDao
    {
        private MySqlConnection mySqlCon;
        public UserDao()
        {
            mySqlCon = Db.GetConnection();
        }
        public IEnumerable<User> GetAll()
        {
            List<User> user = new List<User>();
            using (MySqlConnection con = mySqlCon)
            {
                con.Open();
                MySqlDataReader reader = new MySqlCommand("SELECT*FROM user", con).ExecuteReader();
                if (reader.HasRows)
                    while (reader.Read())
                    {
                        user.Add(new User
                        {
                            Id = new Guid(reader.GetValue(0).ToString()),
                            Username = reader.GetValue(1).ToString(),
                            Email = reader.GetValue(2).ToString(),
                            UserType = (UserType)Convert.ToInt32(reader.GetValue(4))
                        });
                    }
                return user;
            }
        }

        public User GetById(Guid id)
        {
            using (MySqlConnection con = mySqlCon)
            {
                con.Open();
                MySqlDataReader reader = new MySqlCommand("SELECT*FROM user", con).ExecuteReader();
                if (!reader.HasRows)
                    return null;

                reader.Read();
                return new User
                {
                    Id = new Guid(reader.GetValue(0).ToString()),
                    Username = reader.GetValue(1).ToString(),
                    Email = reader.GetValue(2).ToString(),
                    UserType = (UserType)Convert.ToInt32(reader.GetValue(4))
                };
            }
        }

        public User GetByEmail(string email)
        {
            using (MySqlConnection con = mySqlCon)
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT*FROM user WHERE email = @email", con);
                cmd.Parameters.AddWithValue("@email", email);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (!reader.HasRows)
                    return null;

                reader.Read();
                return new User
                {
                    Id = new Guid(reader.GetValue(0).ToString()),
                    Username = reader.GetValue(1).ToString(),
                    Email = reader.GetValue(2).ToString(),
                    UserType = (UserType)Convert.ToInt32(reader.GetValue(4))
                };
            }
        }

        public User Add(User model)
        {
            using (MySqlConnection con = mySqlCon)
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO user VALUES (@id, @username, @email, @password, @userType)");
                    cmd.Parameters.AddWithValue("@id", model.Id);
                    cmd.Parameters.AddWithValue("@username", model.Username);
                    cmd.Parameters.AddWithValue("@email", model.Email);
                    cmd.Parameters.AddWithValue("@password", model.Password);
                    cmd.Parameters.AddWithValue("@userType", model.UserType);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                    return model;
                }
                catch (MySqlException e)
                {
                    throw e.InnerException;
                }
            }
        }

        public User Update(User model)
        {
            throw new NotImplementedException();
        }

        public User Remove(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
