using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafe
{
    class MaquinaCafe
    {

         double _ValorCafe;
         int _QtdeCafesVendeidos;
         double _ValorInserido;

        public MaquinaCafe(double ValorCafe, int QtdeCafesVendeidos, double ValorInserido)
        {
            this.ValorCafe = ValorCafe;
            this.QtdeCafesVendeidos = QtdeCafesVendeidos;
            this.ValorInserido = ValorInserido;
        }

        public MaquinaCafe(double ValorCafe)
        {
            this.ValorCafe = ValorCafe;
            this.QtdeCafesVendeidos = 0;
            this.ValorInserido = 0.00;
        }

        public double ValorCafe { get => _ValorCafe; set => _ValorCafe = value; }
        public int QtdeCafesVendeidos { get => _QtdeCafesVendeidos; set => _QtdeCafesVendeidos = value; }
        public double ValorInserido { get => _ValorInserido; set => _ValorInserido = value; }


    }
}
