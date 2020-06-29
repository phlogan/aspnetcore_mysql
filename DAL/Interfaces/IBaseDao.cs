using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Tls;
using System;
using System.Data;
namespace DAL.Interfaces
{
    public interface IBaseDao
    {
        /// <summary>
        /// Busca todos os dados do banco de dados na tabela em questão
        /// </summary>
        /// <param name="table">Nome da tabela</param>
        /// <param name="con">Objeto de conexão</param>
        /// <returns>Retorna os valores da query</returns>
        MySqlDataReader GetAll(string table, MySqlConnection con);

        /// <summary>
        /// Busca um registro específica de uma tabela de acordo com o ID
        /// </summary>
        /// <param name="table">Nome da tabela</param>
        /// <param name="id">Id do registro</param>
        /// <param name="con">Objeto de conexão</param>
        /// <returns></returns>
        MySqlDataReader GetById(string table, Guid id, MySqlConnection con);
    }
}
