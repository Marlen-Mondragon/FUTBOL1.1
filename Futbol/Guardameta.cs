using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbol
{
    class Guardameta:Futbolista
    {
        private int estatura;
        private Image foto;

        public int Estatura { get => estatura; set => estatura = value; }
        public Image Foto { get => foto; set => foto = value; }

        public void atajarBalones()
        {
            Console.WriteLine("Atajar el Balon");
        }
        public void mostarDatosGuardameta()
        {
            Console.WriteLine(estatura);
            Console.WriteLine(foto);
        }
    }
}
