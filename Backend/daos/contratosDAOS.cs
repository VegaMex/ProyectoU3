using System;
using MySql.Data.MySqlClient;
using Backend.util;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.daos
{
    public class contratosDAOS
    {
        public void insert(string nombre_de_empleado, string rfc, string codigo_postal, string telefono, string fechaContratacion)
        {



            Conexion con = new Conexion();

            String SQL = "INSERT INTO Contratos (nombre_de_empleado, rfc, codigo_postal, telefono, fechaContratacion)" +
                "VALUES (@nombre_de_empleado, @rfc, @codigo_postal, @telefono, @fechaContratacion);";

            MySqlCommand sqlCom = new MySqlCommand();
            sqlCom.CommandText = SQL;
            sqlCom.Parameters.AddWithValue("@nombre_de_empleado", nombre_de_empleado);
            sqlCom.Parameters.AddWithValue("@rfc", rfc);
            sqlCom.Parameters.AddWithValue("@codigo_postal", codigo_postal);
            sqlCom.Parameters.AddWithValue("@telefono", telefono);
            sqlCom.Parameters.AddWithValue("@fechaContratacion", fechaContratacion);
            con.EjecutaSQLComando(sqlCom);

        }
    }
}
