using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend.daos;
using Backend.util;
using Backend;
using MySql.Data.MySqlClient;

namespace Frontend
{
    public partial class Ventana : Form
    {
        public Ventana()
        {
            InitializeComponent();
        }

        Random random = new Random();
        Listas listas = new Listas();
        Aleatorios ale = new Aleatorios();
        contratosDAOS dao = new contratosDAOS();

        string nombre;
        string nTemp;
        string control;
        int numeroNombres;
        int contador = 0;

        public string GetConnectionString()
        {
            String servidor = "localhost";
            String puerto = "3306";
            String usuario = "root";
            String password = "root";
            String database = "U3b";
            return String.Format("Server={0};Database={4};Uid={2};Pwd={3};", servidor, puerto, usuario, password, database);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {


            ale.init();

            MySqlConnection sqlConn = new MySqlConnection();

            sqlConn.ConnectionString = GetConnectionString();

            int reg = 0;

            //Console.WriteLine("Ya se pusieron.");

            for (int i = 0; i < 500; i++)
            {

                String SQL = "INSERT INTO Contratos (nombre_de_empleado, rfc, codigo_postal, telefono, fechaContratacion) VALUES";

                String aux = "";

                for (int u = 0; u < 10000; u++)
                {
                    string[] dat = ale.datos();

                    if (u == 9999)
                    {
                        aux = "('" + dat[0] + "', " + "'" + dat[1] + "', " + "'" + dat[2] + "', " + "'" + dat[3] + "', " + "'" + dat[4] + "');";
                        SQL += aux;
                    }
                    else
                    {
                        aux = "('" + dat[0] + "', " + "'" + dat[1] + "', " + "'" + dat[2] + "', " + "'" + dat[3] + "', " + "'" + dat[4] + "'),";
                        SQL += aux;
                    }

                }

                //Console.WriteLine(SQL);

                sqlConn.Open();

                MySqlCommand sqlCom = new MySqlCommand();
                sqlCom.CommandText = SQL;
                sqlCom.Connection = sqlConn;
                sqlCom.ExecuteNonQuery();

                sqlConn.Close();

                reg += 10000;

                Console.WriteLine((i + 1) +". Se han insertado: " + reg + " registros.");

                //Se insertaron 330x10000
            }


            //Console.WriteLine("Se han ingresado: " + (i + 1) + ", tier: " + tier);


            //ale.init();

            //MySqlConnection sqlConn = new MySqlConnection();

            //sqlConn.ConnectionString = GetConnectionString();

            //for (int tier = 0; tier < 100; tier++)
            //{
            //    sqlConn.Open();

            //    for (int i = 0; i < 6000; i++)
            //    {
            //        string[] dat = ale.datos();

            //        //dao.insert(dat[0], dat[1], dat[2], dat[3], dat[4]);


            //        String SQL = "INSERT INTO Contratos (nombre_de_empleado, rfc, codigo_postal, telefono, fechaContratacion)" +
            //        "VALUES (@nombre_de_empleado, @rfc, @codigo_postal, @telefono, @fechaContratacion);";

            //        MySqlCommand sqlCom = new MySqlCommand();
            //        sqlCom.CommandText = SQL;
            //        sqlCom.Parameters.AddWithValue("@nombre_de_empleado", dat[0]);
            //        sqlCom.Parameters.AddWithValue("@rfc", dat[1]);
            //        sqlCom.Parameters.AddWithValue("@codigo_postal", dat[2]);
            //        sqlCom.Parameters.AddWithValue("@telefono", dat[3]);
            //        sqlCom.Parameters.AddWithValue("@fechaContratacion", dat[4]);

            //        sqlCom.Connection = sqlConn;
            //        sqlCom.ExecuteNonQuery();


            //        Console.WriteLine("Se han ingresado: " + (i + 1) + ", tier: " + tier);
            //        //Console.WriteLine(dat[0]);
            //        //Console.WriteLine(dat[1]);
            //        //Console.WriteLine(dat[2]);
            //        //Console.WriteLine(dat[3]);
            //        //Console.WriteLine(dat[4]);
            //        //Console.ReadLine();

            //        //contador++;

            //        //if (contador % 6000 == 0)
            //        //{
            //        //    MessageBox.Show("Va en el: " + i);
            //        //}

            //    }

            //    sqlConn.Close();
            //}










        }

        private void Ventana_Load(object sender, EventArgs e)
        {
            listas.inicializarNombresH();
            listas.inicializarNombresM();
            listas.inicializarApellidos();
        }
    }
}
