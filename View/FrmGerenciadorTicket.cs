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
    public partial class FrmGerenciadorTicket : Form
    {
        ControllerTicket controllerTicket = new ControllerTicket();
        public FrmGerenciadorTicket()
        {
            InitializeComponent();
            cbxFiltro.SelectedIndex = 0;
        }
        void Carregar()
        {
            try
            {
                if (cbxFiltro.Text == "CODIGO")
                {
                    if (rbEmAberto.Checked)
                    {
                        dgvTicket.DataSource = controllerTicket.CarregarTicketEmAbertoPorCodigo(txtProcurar.Text, dtpDe.Value.ToString(), dtpAte.Value.ToString());
                    }
                    else if (rbFinalizado.Checked)
                    {
                        dgvTicket.DataSource = controllerTicket.CarregarTicketFinalizadoPorCodigo(txtProcurar.Text, dtpDe.Value.ToString(), dtpAte.Value.ToString());
                    }
                }
                else if (cbxFiltro.Text == "VENDEDOR")
                {
                    if (rbEmAberto.Checked)
                    {
                        dgvTicket.DataSource = controllerTicket.CarregarTicketEmAbertoPorVendedor(txtProcurar.Text, dtpDe.Value.ToString(), dtpAte.Value.ToString());
                    }
                    else if (rbFinalizado.Checked)
                    {
                        dgvTicket.DataSource = controllerTicket.CarregarTicketFinalizadoPorVendedor(txtProcurar.Text, dtpDe.Value.ToString(), dtpAte.Value.ToString());
                    }
                }
                lblExibidosTotal.Text = "Exibidos total: " + dgvTicket.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Carregar();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
