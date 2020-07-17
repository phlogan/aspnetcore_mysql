using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.IO;

namespace DAL.Context
{
    public static class Db
    {
        /// <summary>
        /// Método para realizar a conexão com o banco de dados (MYSQL)
        /// </summary>
        /// <returns>Retorna uma conexão de acordo com as variáveis do appsettings.json</returns>
        public static MySqlConnection GetConnection()
        {
            var configurationBuilder = new ConfigurationBuilder().AddJsonFile(
                Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"),
                false);
            var build = configurationBuilder.Build();
            //var sql = new MySqlConnection(build.GetSection("ConnectionString").GetSection("DefaultConnection").Value);
            var sql = new MySqlConnection("server=localhost;port=3308;database=crudcore;user=root;password=''");

            return sql;
        }
    }
}