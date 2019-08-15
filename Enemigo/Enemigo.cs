using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enemigo
{
    class Enemigo
    {
        //Comentarios
        public int PosicionX { get; set; }
        public int PosicionY { get; set; }

        private int _valorPuntos;
        public int ValorPuntos
        {
            get
            {
                return _valorPuntos;
            }
            set
            {
                 if(value >= 100)
                {
                    _valorPuntos = value;
                } else
                {
                    throw new Exception("El valor tiene que ser mayor a 100");
                }
            }
        }

        public void mover()
        {

        }
        public void disparar()
        {

        }
        public void explotar()
        {

        }
    }
}
