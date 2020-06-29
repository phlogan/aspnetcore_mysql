﻿using DAL.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DAO
{
    public class BaseDao : IBaseDao
    {
        public MySqlDataReader GetAll(string table, MySqlConnection con)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT*FROM @table;";
            cmd.Parameters.AddWithValue("@table", table);
            return cmd.ExecuteReader();
        }

        public MySqlDataReader GetById(string table, Guid id, MySqlConnection con)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT*FROM @table WHERE `id` = @id;";
            cmd.Parameters.AddWithValue("@table", table);
            cmd.Parameters.AddWithValue("@table", id);
            return cmd.ExecuteReader();
        }
    }
}