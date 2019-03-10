using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Aleatorios
    {

        Random random = new Random();
        Listas listas = new Listas();

        public void init()
        {
            listas.inicializarNombresH();
            listas.inicializarNombresM();
            listas.inicializarApellidos();
        }


        public string[] datos()
        {
            string[] data = new string[3];

            string nombre = "";
            string nTemp = "";

            int numeroNombres = random.Next(1, 4);
            int sexo = random.Next(2);


            if (sexo == 0)//Mujer
            {
                for (int j = 0; j < numeroNombres; j++)
                {
                    nTemp += " " + listas.nombresM.ElementAt(random.Next(999));
                }
                nombre = nTemp;
                nombre += " " + listas.apellidos.ElementAt(random.Next(999));
                nombre += " " + listas.apellidos.ElementAt(random.Next(999));
            }
            else//Hombre
            {
                for (int j = 0; j < numeroNombres; j++)
                {
                    nTemp += " " + listas.nombresH.ElementAt(random.Next(999));
                }
                nombre = nTemp;
                nombre += " " + listas.apellidos.ElementAt(random.Next(999));
                nombre += " " + listas.apellidos.ElementAt(random.Next(999));
            }

            data[0] = nombre;

            return data;
        }
    }
}
