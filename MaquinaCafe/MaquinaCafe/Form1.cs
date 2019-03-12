using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinaCafe
{
    public partial class frmMaquinaCafe : Form
    {

        MaquinaCafe maquina1 = new MaquinaCafe();

        public frmMaquinaCafe()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            maquina1.IniciarMaquina(2.00);
            CarregarDadosPainelMaquina();
            txtPainel.Text = "Máquina Iniciada...";
        }

        protected void CarregarDadosPainelMaquina()
        {
            txtValorCafe.Text = maquina1.ValorCafe.ToString("C");
            txtQtdeVendida.Text = maquina1.QtdeCafesVendeidos.ToString();
            txtValorInserido.Text = maquina1.ValorInserido.ToString("C");
        }

        protected void LimpaDadosPainelMaquina()
        {
            txtPainel.Text = "";
            txtValorCafe.Text = "";
            txtQtdeVendida.Text = "";
            txtValorInserido.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maquina1.InserirMoeda(double.Parse(txtvalor.Text));
            CarregarDadosPainelMaquina();
            txtPainel.Text = "Valor Inserido...";
        }
    }
}
