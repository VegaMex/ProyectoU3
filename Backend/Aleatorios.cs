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
            listas.inicializarAlfa();
        }


        public string[] datos()
        {
            string[] data = new string[5];//entre 1950 y 2060

            string nombre = "";
            string nTemp = "";
            string ape1 = ""; ;
            string ape2 = "";
            string fecha = "";
            //string inicialNombre = "";
            string rfc;

            int year, month, day;
            int postal, telefono;

            string yearS, monthS, dayS;

            year = random.Next(1950, 2061);
            month = random.Next(1, 13);

            if (month == 4 || month == 6 || month == 9 || month == 11)//4 6 9 11
            {
                day = random.Next(1, 31);
                if (day < 10)
                {
                    dayS = "0" + day;
                }
                else
                {
                    dayS = "" + day;
                }
            }else if (month == 2)
            {
                day = random.Next(1, 29);
                if (day < 10)
                {
                    dayS = "0" + day;
                }
                else
                {
                    dayS = "" + day;
                }
            }
            else
            {
                day = random.Next(1, 32);
                if (day < 10)
                {
                    dayS = "0" + day;
                }
                else
                {
                    dayS = "" + day;
                }
            }

            if (month < 10)
            {
                monthS = "0" + month;
            }
            else
            {
                monthS = "" + month;
            }

            yearS = year.ToString();

            fecha = yearS + "-" + monthS + "-" + dayS;

            int numeroNombres = random.Next(1, 4);
            int sexo = random.Next(0, 2);

            if (sexo == 0)//Mujer
            {
                for (int j = 0; j < numeroNombres; j++)
                {
                    if (nTemp == "")
                    {
                        nTemp = listas.nombresM.ElementAt(random.Next(999));
                    }
                    else
                    {
                        nTemp += " " + listas.nombresM.ElementAt(random.Next(999));
                    }
                }
                nombre = nTemp;
                ape1 = listas.apellidos.ElementAt(random.Next(999));
                ape2 = listas.apellidos.ElementAt(random.Next(999));
                nombre += " " + ape1 + " " + ape2;
            }
            else//Hombre
            {
                for (int j = 0; j < numeroNombres; j++)
                {
                    if (nTemp == "")
                    {
                        nTemp = listas.nombresH.ElementAt(random.Next(999));
                    }
                    else
                    {
                        nTemp += " " + listas.nombresH.ElementAt(random.Next(999));
                    }
                }
                nombre = nTemp;
                ape1 = listas.apellidos.ElementAt(random.Next(999));
                ape2 = listas.apellidos.ElementAt(random.Next(999));
                nombre += " " + ape1 + " " + ape2;
            }

            postal = random.Next(10000, 99999);

            telefono = random.Next(1000000, 9999999);

            int a = random.Next(37);
            int b = random.Next(37);
            int c = random.Next(37);

            rfc = ape1.Substring(0, 2).ToUpper() + ape2.Substring(0, 1) + nombre.Substring(0, 1)
                + yearS.Substring(2, 2) + monthS + dayS + listas.alfa.ElementAt(random.Next(a))
                + listas.alfa.ElementAt(random.Next(b)) + listas.alfa.ElementAt(random.Next(c));

            data[0] = nombre;

            data[1] = rfc;

            data[2] = postal + "";

            data[3] = "445" + telefono + "";

            data[4] = fecha;

            return data;
        }
    }
}
