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
        bool _status;

        public MaquinaCafe()
        {
            ValorCafe = 0.00;
            QtdeCafesVendeidos = 0;
            ValorInserido = 0.00;
            Status = false;
        }

        public MaquinaCafe(double ValorCafe, int QtdeCafesVendeidos, double ValorInserido, bool status)
        {
            _ValorCafe = ValorCafe;
            _QtdeCafesVendeidos = QtdeCafesVendeidos;
            _ValorInserido = ValorInserido;
            _status = status;
        }

        public double ValorCafe { get => _ValorCafe; set => _ValorCafe = value; }
        public int QtdeCafesVendeidos { get => _QtdeCafesVendeidos; set => _QtdeCafesVendeidos = value; }
        public double ValorInserido { get => _ValorInserido; set => _ValorInserido = value; }
        public bool Status { get => _status; set => _status = value; }

        public void IniciarMaquina(double valorCafe)
        {
            ValorCafe = valorCafe;
            QtdeCafesVendeidos = 0;
            ValorInserido = 0.00;
            Status = true;
        }

        public void DesligarMaquina()
        {
            ValorCafe = 0.00;
            QtdeCafesVendeidos = 0;
            ValorInserido = 0.00;
            Status = false;
        }

    
        public bool InserirMoeda(double valorInserido)
        {
            if (EhMoeda(valorInserido))
            {
                ValorInserido += valorInserido;
                return true;            
            }
            else
            {
                return false;
            }
            
        }

        public bool ComprarCafe()
        {
            if (ValorInserido >= ValorCafe)
            {
                ValorInserido -= ValorCafe;
                QtdeCafesVendeidos++;
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool RetirarTroco()
        {
            if (ValorInserido > 0)
            {
                ValorInserido = 0;
                return true;
            }
            else
            {
                return false;
            }
        }

        public double TotalArrecadado()
        {
            return (ValorCafe * QtdeCafesVendeidos);

        }
             

        public bool EhMoeda(double valorInserido)
        {
            return ((valorInserido == 0.05) || (valorInserido == 0.10) || (valorInserido == 0.25) ||
                    (valorInserido == 0.50) || (valorInserido == 1));
        }

    }
}
