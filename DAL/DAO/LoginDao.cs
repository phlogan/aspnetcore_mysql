using DAL.Context;
using DAL.Enums;
using DAL.Interfaces;
using DAL.Models;
using MySql.Data.MySqlClient;
using System;

namespace DAL.DAO
{
    public class LoginDao : ILoginDao
    {
        private MySqlConnection mySqlCon;
        public LoginDao()
        {
            mySqlCon = Db.GetConnection();
        }

        public User Login(User model)
        {
            using (MySqlConnection con = mySqlCon)
            {
                try
                {
                    con.Open();
                    //TODO: APLICAR CRIPTOGRAFIA
                    var cmd = new MySqlCommand("SELECT*FROM user WHERE email = @email AND password = @password", con);
                    cmd.Parameters.AddWithValue("@email", model.Email);
                    cmd.Parameters.AddWithValue("@password", model.Password);
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        return new User
                        {
                            Id = new Guid(reader.GetValue(0).ToString()),
                            Username = reader.GetValue(1).ToString(),
                            Email = reader.GetValue(2).ToString(),
                            UserType = (UserType)Convert.ToInt32(reader.GetValue(4))
                        };
                    }
                    
                    return null;
                }
                catch (MySqlException e)
                {
                    throw e.InnerException;
                }
            }
        }

        public bool IsLogged()
        {
            throw new System.NotImplementedException();
        }

        public bool Logoff()
        {
            throw new System.NotImplementedException();
        }
    }
}
