using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmFinanceiroAgendamento : Form
    {
        ControllerFinanceiro controllerFinanceiro = new ControllerFinanceiro();
        ModelFinanceiro modelFinanceiro = new ModelFinanceiro();
        public FrmFinanceiroAgendamento()
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
                    dgvFinanceiro.DataSource = controllerFinanceiro.CarregarPorCodigo(txtProcurar.Text, "Recebido", dtpDe.Value.ToString(), dtpAte.Value.ToString());
                }
                else if (cbxFiltro.Text == "NOME")
                {
                    dgvFinanceiro.DataSource = controllerFinanceiro.CarregarPorNome(txtProcurar.Text, "Recebido", dtpDe.Value.ToString(), dtpAte.Value.ToString());
                }
                lblExibidosTotal.Text = "Exibidos total: " + dgvFinanceiro.Rows.Count;
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

        private void dgvFinanceiro_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvFinanceiro.Rows.Count > 0)
                {
                    modelFinanceiro.Nome = dgvFinanceiro.CurrentRow.Cells["Nome"].Value.ToString();
                    modelFinanceiro.Endereco = dgvFinanceiro.CurrentRow.Cells["Endereco"].Value.ToString();
                    modelFinanceiro.Telefone = dgvFinanceiro.CurrentRow.Cells["Telefone"].Value.ToString();
                    modelFinanceiro.Dn = dgvFinanceiro.CurrentRow.Cells["Dn"].Value.ToString();
                    modelFinanceiro.CadastradoPor = dgvFinanceiro.CurrentRow.Cells["CadastradoPor"].Value.ToString();
                    modelFinanceiro.DataAgendamento = dgvFinanceiro.CurrentRow.Cells["DataAgendamento"].Value.ToString();
                    modelFinanceiro.HoraAgendamento = dgvFinanceiro.CurrentRow.Cells["HoraAgendamento"].Value.ToString();
                    modelFinanceiro.Status = dgvFinanceiro.CurrentRow.Cells["StatusAgendamento"].Value.ToString();
                    modelFinanceiro.Servico = dgvFinanceiro.CurrentRow.Cells["Servico"].Value.ToString();
                    modelFinanceiro.Valor = Convert.ToDecimal(dgvFinanceiro.CurrentRow.Cells["Valor"].Value.ToString());
                    modelFinanceiro.RecebidoPor = dgvFinanceiro.CurrentRow.Cells["RecebidoPor"].Value.ToString();
                    modelFinanceiro.DataRecebimento = dgvFinanceiro.CurrentRow.Cells["DataRecebimento"].Value.ToString();
                    modelFinanceiro.OpcaoPagamento = dgvFinanceiro.CurrentRow.Cells["OpcaoPagamento"].Value.ToString();
                    modelFinanceiro.Dinheiro = Convert.ToDecimal(dgvFinanceiro.CurrentRow.Cells["Dinheiro"].Value.ToString());
                    modelFinanceiro.Cartao = Convert.ToDecimal(dgvFinanceiro.CurrentRow.Cells["Cartao"].Value.ToString());
                    modelFinanceiro.Ticket = Convert.ToDecimal(dgvFinanceiro.CurrentRow.Cells["Ticket"].Value.ToString());
                    FrmFinanceiroAgendamentoConsulta frmFinanceiroAgendamentoConsulta = new FrmFinanceiroAgendamentoConsulta(modelFinanceiro);
                    frmFinanceiroAgendamentoConsulta.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            modelFinanceiro.Dinheiro = 0;
            modelFinanceiro.Cartao = 0;
            modelFinanceiro.Ticket = 0;
            modelFinanceiro.Valor = 0;
            if (dgvFinanceiro.Rows.Count > 0)
            {
                modelFinanceiro.dtpDe = dtpDe.Text;
                modelFinanceiro.dtpAte = dtpAte.Text;
                modelFinanceiro.TotalAgendamento = dgvFinanceiro.Rows.Count.ToString();
                foreach (DataGridViewRow row in dgvFinanceiro.Rows)
                {
                    modelFinanceiro.Dinheiro += Convert.ToDecimal(row.Cells["Dinheiro"].Value.ToString());
                    modelFinanceiro.Cartao += Convert.ToDecimal(row.Cells["Cartao"].Value.ToString());
                    modelFinanceiro.Ticket += Convert.ToDecimal(row.Cells["Ticket"].Value.ToString());
                    modelFinanceiro.Valor += Convert.ToDecimal(row.Cells["Valor"].Value.ToString());
                }
                FrmFinanceiroAgendamentoRelatorio frmFinanceiroAgendamentoRelatorio = new FrmFinanceiroAgendamentoRelatorio(modelFinanceiro);
                frmFinanceiroAgendamentoRelatorio.ShowDialog();
            }
        }
    }
}
