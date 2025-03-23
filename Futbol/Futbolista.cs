using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Futbol
{
    class Futbolista : Persona
    {
        private int numero;
        private string posicion;

       
        public string Posicion { get => posicion; set => posicion = value; }
        public int Numero { get => numero; set => numero = value; }

        public void correr()
        {
            Console.WriteLine("el futbolista esta corriendo");
        }
        public void patearBalon()
        {
            Console.WriteLine("El futbolista patea el balon");
        }
        public void mostarDatosFutbolista()
        {
            Console.WriteLine(Numero);
            Console.WriteLine(posicion);
        }
    }
}
