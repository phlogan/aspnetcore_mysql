using BL.Models;
using DAL.Context;
using DAL.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

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
                            Password = reader.GetValue(3).ToString()
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
                    Password = reader.GetValue(3).ToString()
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
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO user VALUES (@id, @username, @email, @password");
                    cmd.Parameters.AddWithValue("@id", model.Id);
                    cmd.Parameters.AddWithValue("@username", model.Username);
                    cmd.Parameters.AddWithValue("@email", model.Email);
                    cmd.Parameters.AddWithValue("@password", model.Password);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                    return model;
                }
                catch(MySqlException e)
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
