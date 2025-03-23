using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbol
{
    class EquipoFutbol
    {
        private string nombreEquipo;
        private Guardameta guardameta;
        private int puntos;
        private Image escudo;

        public string NombreEquipo { get => nombreEquipo; set => nombreEquipo = value; }
        public int Puntos { get => puntos; set => puntos = value; }
        public Image Escudo { get => escudo; set => escudo = value; }
        internal Guardameta Guardameta { get => guardameta; set => guardameta = value; }
        public void competir()
        {
            Console.WriteLine("Atla VS Four");
        }
        public void mostarDatosEquipo()
        {
            Console.WriteLine(nombreEquipo);
            Console.WriteLine(guardameta);
            Console.WriteLine(puntos);
            Console.WriteLine(escudo);
        }
    }
}
