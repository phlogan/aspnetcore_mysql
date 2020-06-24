using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPMYSQL.Models
{
    public class DataContext
    {
        public string ConnectionString { get; set; }
        public DataContext(string connectionString)
        {
            ConnectionString = connectionString;
        }
        /// <summary>
        /// Método para realizar a conexão com o banco de dados (MYSQL)
        /// </summary>
        /// <returns>Retorna uma conexão de acordo com as variáveis do appsettings.json</returns>
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}