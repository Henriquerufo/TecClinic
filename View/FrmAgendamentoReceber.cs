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
    public partial class FrmAgendamentoReceber : Form
    {
        ControllerAgendamentos controllerAgendamentos = new ControllerAgendamentos();
        ModelAgendamentos modelAgendamentos = new ModelAgendamentos();
        int codigo;
        decimal valorServico;
        decimal valorTotalPago;
        decimal valorRestante;
        public FrmAgendamentoReceber(ModelAgendamentos modelAgendamentos)
        {
            InitializeComponent();
            ControllerTema controllerTema = new ControllerTema();
            if (controllerTema.CarregarEnderecoImagem() != null)
            {
                pictureBox1.BackgroundImage = Image.FromFile(controllerTema.CarregarEnderecoImagem());
            }
            if (!string.IsNullOrWhiteSpace(modelAgendamentos.Nome))
            {
                codigo = modelAgendamentos.Codigo;
                valorServico = modelAgendamentos.Valor;
                txtNome.Text = modelAgendamentos.Nome;
                txtEndereco.Text = modelAgendamentos.Endereco;
                txtTelefone.Text = modelAgendamentos.Telefone;
                txtDn.Text = modelAgendamentos.Dn;
                txtNomeServico.Text = modelAgendamentos.Servico;
                txtClinico.Text = modelAgendamentos.Clinico;
                txtValorServico.Text = modelAgendamentos.Valor.ToString();
                txtDinheiroPagamento.Text = modelAgendamentos.Dinheiro.ToString();
                txtCartaoPagamento.Text = modelAgendamentos.Cartao.ToString();
                txtTicketPagamento.Text = modelAgendamentos.Ticket.ToString();
                valorRestante = valorServico - (modelAgendamentos.Dinheiro + modelAgendamentos.Cartao + modelAgendamentos.Ticket);
                txtValorRestante.Text = valorRestante.ToString();
            }
        }
        private void btnReceber_Click(object sender, EventArgs e)
        {
            FrmAgendamentoReceberOpcaoPagamento frmAgendamentoFinalizar = new FrmAgendamentoReceberOpcaoPagamento();
            frmAgendamentoFinalizar.ShowDialog();
            if (!string.IsNullOrWhiteSpace(frmAgendamentoFinalizar.RetornoOpcaoPagamento))
            {
                if (frmAgendamentoFinalizar.RetornoOpcaoPagamento == "DINHEIRO")
                {
                    FrmAgendamentoReceberDinheiro frmAgendamentoFinalizarDinheiro = new FrmAgendamentoReceberDinheiro(valorRestante);
                    frmAgendamentoFinalizarDinheiro.ShowDialog();
                    if (!string.IsNullOrWhiteSpace(frmAgendamentoFinalizarDinheiro.Retorno))
                    {
                        modelAgendamentos.Dinheiro += frmAgendamentoFinalizarDinheiro.Dinheiro;
                        valorTotalPago += frmAgendamentoFinalizarDinheiro.Dinheiro;
                    }
                }
                else if (frmAgendamentoFinalizar.RetornoOpcaoPagamento == "CARTAO")
                {
                    FrmAgendamentoReceberCartao frmAgendamentoFinalizarCartao = new FrmAgendamentoReceberCartao(valorRestante);
                    frmAgendamentoFinalizarCartao.ShowDialog();
                    if (!string.IsNullOrWhiteSpace(frmAgendamentoFinalizarCartao.Retorno))
                    {
                        modelAgendamentos.Cartao += Convert.ToDecimal(frmAgendamentoFinalizarCartao.Retorno);
                        valorTotalPago += Convert.ToDecimal(frmAgendamentoFinalizarCartao.Retorno);
                    }
                }
                else if (frmAgendamentoFinalizar.RetornoOpcaoPagamento == "TICKET")
                {
                    FrmAgendamentoReceberTicket frmAgendamentoReceberTicket = new FrmAgendamentoReceberTicket();
                    frmAgendamentoReceberTicket.ShowDialog();
                    if (!string.IsNullOrWhiteSpace(frmAgendamentoReceberTicket.Retorno))
                    {
                        modelAgendamentos.Ticket += frmAgendamentoReceberTicket.RetornoTicket;
                        valorTotalPago += frmAgendamentoReceberTicket.RetornoTicket;
                        
                    }
                }
                if (valorTotalPago >= valorServico)
                {
                    modelAgendamentos.Codigo = codigo;
                    modelAgendamentos.OpcaoPagamento = frmAgendamentoFinalizar.RetornoOpcaoPagamento;
                    modelAgendamentos.StatusPagamento = "Recebido";
                    modelAgendamentos.DataRecebimento = DateTime.Now.ToString();
                    modelAgendamentos.RecebidoPor = Properties.SettingsLogado.Default.Nome;
                    if (controllerAgendamentos.ReceberValorAgendamento(modelAgendamentos))
                    {
                        MessageBox.Show("Recebimento realizado com sucesso!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    valorRestante = valorServico - valorTotalPago;
                    txtValorRestante.Text = valorRestante.ToString();
                    txtDinheiroPagamento.Text = modelAgendamentos.Dinheiro.ToString();
                    txtCartaoPagamento.Text = modelAgendamentos.Cartao.ToString();
                    txtTicketPagamento.Text = modelAgendamentos.Ticket.ToString();
                }
            }
        }

        private void FrmAgendamentoReceber_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (valorTotalPago < valorServico)
            {
                var result = MessageBox.Show("Deseja cancelar o recebimento?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
