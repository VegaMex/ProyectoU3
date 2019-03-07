using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Listas
    {



        public List<string> nombresH = new List<string>();
        public List<string> nombresM = new List<string>();
        public List<string> apellidos = new List<string>();

        public void inicializarNombresH()
        {
            nombresH = File.ReadAllLines("").ToList();
        }

        public void inicializarNombresM()
        {

        }
    }
}
