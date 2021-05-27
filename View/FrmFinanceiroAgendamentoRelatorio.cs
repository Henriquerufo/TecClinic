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
    public partial class FrmFinanceiroAgendamentoRelatorio : Form
    {
        public FrmFinanceiroAgendamentoRelatorio(ModelFinanceiro modelFinanceiro)
        {
            InitializeComponent();
            dtpDe.Text = modelFinanceiro.dtpDe;
            dtpAte.Text = modelFinanceiro.dtpAte;
            txtTotalAgendamento.Text = modelFinanceiro.TotalAgendamento;
            txtDinheiro.Text = modelFinanceiro.Dinheiro.ToString();
            txtCartao.Text = modelFinanceiro.Cartao.ToString();
            txtTicket.Text = modelFinanceiro.Ticket.ToString();
            txtTotal.Text = modelFinanceiro.Valor.ToString();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
