using BL.Models;
using DAL.Context;
using DAL.Interfaces;
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
        public bool IsLogged()
        {
            throw new System.NotImplementedException();
        }

        public bool Login(User model)
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
                        return true;
                    
                    return false;
                }
                catch (MySqlException e)
                {
                    throw e;
                }
            }
        }

        public bool Logoff()
        {
            throw new System.NotImplementedException();
        }
    }
}
