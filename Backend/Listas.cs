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
        public List<string> alfa = new List<string>();

        public void inicializarNombresH()
        {
            nombresH.Clear();
            nombresH = File.ReadAllLines("NombresHombre.txt").ToList();
        }

        public void inicializarNombresM()
        {
            nombresM.Clear();
            nombresM = File.ReadAllLines("NombresMujer.txt").ToList();
        }

        public void inicializarApellidos()
        {
            apellidos.Clear();
            apellidos = File.ReadLines("Apellidos.txt").ToList();
        }

        public void inicializarAlfa()
        {
            alfa.Clear();
            alfa = File.ReadLines("Alfa.txt").ToList();
        }
    }
}
