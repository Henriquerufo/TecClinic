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
using Controller;

namespace View
{
    public partial class FrmFinanceiroAgendamentoConsulta : Form
    {
        public FrmFinanceiroAgendamentoConsulta(ModelFinanceiro modelFinanceiro)
        {
            InitializeComponent();
            ControllerTema controllerTema = new ControllerTema();
            if (controllerTema.CarregarEnderecoImagem() != null)
            {
                pictureBox1.BackgroundImage = Image.FromFile(controllerTema.CarregarEnderecoImagem());
            }
            if (!string.IsNullOrWhiteSpace(modelFinanceiro.Nome))
            {
                txtNomeCliente.Text = modelFinanceiro.Nome;
                txtEnderecoCliente.Text = modelFinanceiro.Endereco;
                txtTelefoneCliente.Text = modelFinanceiro.Telefone;
                txtDnCliente.Text = modelFinanceiro.Dn.Replace(" 00:00:00", ""); ;
                txtCadastradoPorAgendamento.Text = modelFinanceiro.CadastradoPor;
                txtDataAgendamento.Text = modelFinanceiro.DataAgendamento.Replace(" 00:00:00", ""); ;
                txtHoraAgendamento.Text = modelFinanceiro.HoraAgendamento;
                txtNomeServico.Text = modelFinanceiro.Servico;
                txtValorServico.Text = modelFinanceiro.Valor.ToString();
                txtRecebidoPorPagamento.Text = modelFinanceiro.RecebidoPor;
                txtDataRecebimentoPagamento.Text = modelFinanceiro.DataRecebimento.Replace(" 00:00:00", "");
                txtOpcaoSelecionadaPagamento.Text = modelFinanceiro.OpcaoPagamento;
                txtDinheiroPagamento.Text = modelFinanceiro.Dinheiro.ToString();
                txtCartaoPagamento.Text = modelFinanceiro.Cartao.ToString();
                txtTicketPagamento.Text = modelFinanceiro.Ticket.ToString();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
