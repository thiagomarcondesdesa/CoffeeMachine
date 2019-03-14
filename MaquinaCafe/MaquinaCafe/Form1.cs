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
            txtPainel.Text = "Máquina desligada...";
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!maquina1.Status)
            {
                maquina1.IniciarMaquina(2.00);
                CarregarDadosPainelMaquina();
                txtPainel.Text = "Máquina Iniciada...";
            }
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
            txtvalor.Text = "";
        }

       

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            if (maquina1.ValorInserido > 0)
            {
                txtPainel.Text = "Solicite o seu troco...";
            }
            else
            {
                if (maquina1.Status)
                {
                    rtbRelatorio.Text += "Quantidade de café(s) vendido(s).....:" + maquina1.QtdeCafesVendeidos.ToString() + "\n";
                    rtbRelatorio.Text += "Valor Total dos café(s) vendido(s)...:" + maquina1.TotalArrecadado().ToString("C") + "\n";
                    maquina1.DesligarMaquina();
                    CarregarDadosPainelMaquina();
                    txtPainel.Text = "Máquina desligada...";

                }
            }
        }

        private void btnInserirMoeda_Click(object sender, EventArgs e)
        {
            if (!maquina1.Status)
            {
                txtPainel.Text = "Máquina desligada...";
            }
            else
            {
                if (txtvalor.Text != "")
                {
                    if (maquina1.InserirMoeda(double.Parse(txtvalor.Text)))
                    {
                        CarregarDadosPainelMaquina();
                        txtPainel.Text = "Valor Inserido...";
                        txtvalor.Text = "";
                    }
                    else
                    {
                        txtPainel.Text = "Insira uma moeda...";
                    }
                }
                else
                {
                    txtPainel.Text = "Valor Incorreto...";
                }
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (maquina1.ComprarCafe())
            {
                CarregarDadosPainelMaquina();
                txtPainel.Text = "Retire o café...";
            }
            else
            {
                txtPainel.Text = "O Valor do café é "+maquina1.ValorCafe.ToString("C")+"...";
            }
        }

        private void btnTroco_Click(object sender, EventArgs e)
        {
            if (maquina1.RetirarTroco())
            {
                CarregarDadosPainelMaquina();
                txtPainel.Text = "Retire o seu troco...";
            }
            else
            {
                txtPainel.Text = "Não existe troco...";
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
