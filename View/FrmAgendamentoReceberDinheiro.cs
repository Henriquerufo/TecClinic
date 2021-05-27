using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmAgendamentoReceberDinheiro : Form
    {
        decimal valorTotal;
        decimal dinheiro;
        decimal troco;
        ControllerTicket controllerTicket = new ControllerTicket();
        ModelTicket modelTicket = new ModelTicket();
        public String Retorno
        {
            get
            {
                return txtTroco.Text;
            }
        }
        public Decimal Dinheiro
        {
            get
            {
                return dinheiro;
            }
        }
        public FrmAgendamentoReceberDinheiro(decimal ValorTotal)
        {
            InitializeComponent();
            ControllerTema controllerTema = new ControllerTema();
            if (controllerTema.CarregarEnderecoImagem() != null)
            {
                pictureBox1.BackgroundImage = Image.FromFile(controllerTema.CarregarEnderecoImagem());
            }
            valorTotal = ValorTotal;
        }

        private void txtDinheiro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dinheiro = Convert.ToDecimal(txtDinheiro.Text);
                troco = dinheiro - valorTotal;
                if (dinheiro > valorTotal)
                {
                    dinheiro = valorTotal;
                    txtTroco.Text = troco.ToString("C");
                    var result = MessageBox.Show("Gerar ticket no valor de " + troco.ToString("C") + " ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        modelTicket.GeradoPor = Properties.SettingsLogado.Default.Nome;
                        modelTicket.Data = DateTime.Now.ToString();
                        modelTicket.Valor = troco;
                        modelTicket.Status = "Em Aberto";
                        MessageBox.Show("Ticket gerado com sucesso!\nCodigo: " + controllerTicket.GerarTicket(modelTicket).ToString(), "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Close();
                }
                else if (dinheiro == valorTotal)
                {
                    dinheiro = valorTotal;
                    txtTroco.Text = troco.ToString("C");
                    this.Close();
                }
                else if (dinheiro < valorTotal)
                {
                    txtTroco.Text = troco.ToString("C");
                    this.Close();
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
