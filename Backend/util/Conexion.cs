using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Backend.util
{
    public class Conexion
    {

        /// <summary>
        /// Conexión a la base de Datos.
        /// </summary>
        /// <returns>Cadena de conexión a la base de datos.</returns>
        public string GetConnectionString()
        {
            String servidor = "localhost";
            String puerto = "3306";
            String usuario = "root";
            String password = "root";
            String database = "U3b";
            return String.Format("Server={0};Database={4};Uid={2};Pwd={3};", servidor, puerto, usuario, password, database);
        }

        /// <summary>
        /// Se encarga de ejecutar un comando SQL.
        /// </summary>
        /// <param name="sqlCom">Comando SQL para ejecutar Insert, Delete y Update.</param>
        public void EjecutaSQLComando(MySqlCommand sqlCom)
        {
            MySqlConnection sqlConn = new MySqlConnection();
            try
            {
                sqlConn.ConnectionString = GetConnectionString();
                sqlConn.Open();
                sqlCom.Connection = sqlConn;
                sqlCom.ExecuteNonQuery();
            }
            finally
            {
                sqlConn.Close();
            }
        }

        /// <summary>
        /// Ejecuta un comando SQL y retorna un parámetro.
        /// </summary>
        /// <param name="sComandoSql">Comando SQL.</param>
        /// <returns></returns>
        public string EjecutaSQLScalar(string sComandoSql)
        {
            string regreso = "";
            MySqlConnection sqlConn = new MySqlConnection();
            MySqlCommand sqlCom = new MySqlCommand();
            try
            {
                sqlConn.ConnectionString = GetConnectionString();
                sqlConn.Open();
                sqlCom.Connection = sqlConn;
                sqlCom.CommandText = sComandoSql;
                regreso = sqlCom.ExecuteScalar().ToString();
            }
            finally
            {
                sqlConn.Close();
            }
            return regreso;
        }
        /// <summary>
        /// Esta método sirve para llenar GridsView y combos.
        /// Regresa un DataSet.
        /// </summary>
        /// <param name="mysql">Comando SQL</param>
        /// <returns>DataSet útil para llenar controles de datos.</returns>
        public DataSet LLenaComboGrid(string mysql)
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlConnection cnn = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                cnn.ConnectionString = GetConnectionString();
                cnn.Open();
                cmd.CommandText = mysql;
                da.SelectCommand = cmd;
                da.SelectCommand.Connection = cnn;
                da.Fill(ds);
            }
            finally
            {
                cnn.Close();
            }
            return ds;
        }

    }
}
