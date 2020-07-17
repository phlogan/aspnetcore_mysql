using BL.Models;
using DAL.Context;
using DAL.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public User GetById()
        {
            throw new NotImplementedException();
        }

        public User Add()
        {
            throw new NotImplementedException();
        }

        public User Remove()
        {
            throw new NotImplementedException();
        }

        public User Update()
        {
            throw new NotImplementedException();
        }
    }
}
