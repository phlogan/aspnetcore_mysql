using BL.Models;
using DAL.Context;
using DAL.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace DAL.DAO
{
    public class UserDao : IUserDao
    {
        private MySqlConnection mySqlCon;
        private BaseDao baseDao;
        public UserDao()
        {
            mySqlCon = Db.GetConnection();
            baseDao = new BaseDao();
        }
        public IEnumerable<User> GetAll()
        {
            List<User> user = new List<User>();
            using (MySqlConnection con = mySqlCon)
            {
                con.Open();
                MySqlDataReader reader = baseDao.GetAll("user", con);
                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        user.Add(new User
                        {
                            Id = (Guid)reader.GetValue(0),
                            Username = reader.GetValue(1).ToString(),
                            Email = reader.GetValue(2).ToString(),
                            Password = reader.GetValue(3).ToString()
                        });
                    }
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
