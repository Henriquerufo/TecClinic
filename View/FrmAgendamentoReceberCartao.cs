using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace View
{
    public partial class FrmAgendamentoReceberCartao : Form
    {
        decimal valorTotal;
        public String Retorno
        {
            get
            {
                return txtCartaoDebito.Text;
            }
        }
        public FrmAgendamentoReceberCartao(decimal ValorTotal)
        {
            InitializeComponent();
            ControllerTema controllerTema = new ControllerTema();
            if (controllerTema.CarregarEnderecoImagem() != null)
            {
                pictureBox1.BackgroundImage = Image.FromFile(controllerTema.CarregarEnderecoImagem());
            }
            valorTotal = ValorTotal;
        }

        private void txtCartaoDebito_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (valorTotal >= Convert.ToDecimal(txtCartaoDebito.Text))
                {
                    this.Close();
                }
                else if (valorTotal < Convert.ToDecimal(txtCartaoDebito.Text))
                {
                    MessageBox.Show("Valor invalido");
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                txtCartaoDebito.Text = null;
                this.Close();
            }
        }
    }
}
