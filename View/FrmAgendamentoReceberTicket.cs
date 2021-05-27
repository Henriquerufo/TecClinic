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
using Model;

namespace View
{
    public partial class FrmAgendamentoReceberTicket : Form
    {
        ControllerTicket controllerTicket = new ControllerTicket();
        ModelTicket modelTicket = new ModelTicket();
        public String Retorno
        {
            get
            {
                return txtTicketCodigo.Text;
            }
        }
        public Decimal RetornoTicket
        {
            get
            {
                return modelTicket.ValorPago;
            }
        }
        public FrmAgendamentoReceberTicket()
        {
            InitializeComponent();
            ControllerTema controllerTema = new ControllerTema();
            if (controllerTema.CarregarEnderecoImagem() != null)
            {
                pictureBox1.BackgroundImage = Image.FromFile(controllerTema.CarregarEnderecoImagem());
            }
        }

        private void txtTicketDinheiro_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    modelTicket.Codigo = Convert.ToInt32(txtTicketCodigo.Text);
                    if (controllerTicket.VerificarTicket(modelTicket) >= Convert.ToDecimal(txtTicketDinheiro.Text))
                    {
                        modelTicket.ValorPago = Convert.ToDecimal(txtTicketDinheiro.Text);
                        controllerTicket.valorTicketPago(modelTicket);
                        if (controllerTicket.VerificarTicketZerado(modelTicket))
                        {
                            controllerTicket.TicketAlterarStatus(modelTicket);
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Valor Invalido", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
