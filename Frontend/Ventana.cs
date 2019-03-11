using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend;

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
        string nombre;
        string nTemp;
        string control;
        int numeroNombres;
        int sexo;

        private void btnIniciar_Click(object sender, EventArgs e)
        {



            //for (int i = 0; i < 5000; i++)
            //{
            //    nombre = "";
            //    nTemp = "";
            //    control = "";

            //    numeroNombres = random.Next(1, 4);
            //    sexo = random.Next(2);

            //    control = "(numeronombres = " + numeroNombres + ")";

            //    if (sexo == 0)//Mujer
            //    {
            //        for (int j = 0; j < numeroNombres; j++)
            //        {
            //            nTemp += " " + listas.nombresM.ElementAt(random.Next(999));
            //        }
            //        nombre = nTemp;
            //        nombre += " " + listas.apellidos.ElementAt(random.Next(999));
            //        nombre += " " + listas.apellidos.ElementAt(random.Next(999));
            //    }
            //    else//Hombre
            //    {
            //        for (int j = 0; j < numeroNombres; j++)
            //        {
            //            nTemp += " " + listas.nombresH.ElementAt(random.Next(999));
            //        }
            //        nombre = nTemp;
            //        nombre += " " + listas.apellidos.ElementAt(random.Next(999));
            //        nombre += " " + listas.apellidos.ElementAt(random.Next(999));
            //    }

            //    Console.WriteLine(nombre);
            //    Console.ReadLine();
            //}


            ale.init();

            this.progreso.Value = 0;

            for (int i = 0; i < 10000; i++)
            {
                string[] dat = ale.datos();

                Console.WriteLine(dat[0]);
                Console.WriteLine(dat[1]);
                Console.WriteLine(dat[2]);
                Console.ReadLine();

                //this.progreso.Increment((int)(0.01 * 100.0f));
            }

        }

        private void Ventana_Load(object sender, EventArgs e)
        {
            listas.inicializarNombresH();
            listas.inicializarNombresM();
            listas.inicializarApellidos();
        }
    }
}
