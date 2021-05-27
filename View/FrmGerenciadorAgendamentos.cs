using Controller;
using Model;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class FrmGerenciadorAgendamentos : Form
    {
        ControllerAgendamentos controllerAgendamentos = new ControllerAgendamentos();
        ModelAgendamentos modelAgendamentos = new ModelAgendamentos();
        bool SelecionarCliente;
        public String RetornarNomeCliente
        {
            get
            {
                if (dgvAgendamentos.Rows.Count > 0 && SelecionarCliente)
                {
                    return dgvAgendamentos.CurrentRow.Cells["Nome"].Value.ToString();
                }
                return null;
            }
        }
        public String RetornarEnderecoCliente
        {
            get
            {
                if (dgvAgendamentos.Rows.Count > 0 && SelecionarCliente)
                {
                    return dgvAgendamentos.CurrentRow.Cells["Endereco"].Value.ToString();
                }
                return null;
            }
        }
        public String RetornarTelefoneCliente
        {
            get
            {
                if (dgvAgendamentos.Rows.Count > 0 && SelecionarCliente)
                {
                    return dgvAgendamentos.CurrentRow.Cells["Telefone"].Value.ToString();
                }
                return null;
            }
        }
        public FrmGerenciadorAgendamentos(bool selecionarCliente)
        {
            InitializeComponent();
            cbxFiltro.SelectedIndex = 0;
            if (selecionarCliente)
            {
                SelecionarCliente = selecionarCliente;
            }
        }
        void Carregar()
        {
            try
            {
                if (cbxFiltro.Text == "CODIGO")
                {
                    if (rbEmAberto.Checked && rbEmAbertoPagamento.Checked)
                    {
                        dgvAgendamentos.DataSource = controllerAgendamentos.CarregarPorCodigo(txtProcurar.Text, rbEmAberto.Text, rbEmAbertoPagamento.Text, dtpDe.Value.ToString(), dtpAte.Value.ToString());
                    }
                    else if (rbFinalizado.Checked && rbRecebido.Checked)
                    {
                        dgvAgendamentos.DataSource = controllerAgendamentos.CarregarPorCodigo(txtProcurar.Text, rbFinalizado.Text, rbRecebido.Text, dtpDe.Value.ToString(), dtpAte.Value.ToString());
                    }
                    else if (rbEmAberto.Checked && rbRecebido.Checked)
                    {
                        dgvAgendamentos.DataSource = controllerAgendamentos.CarregarPorCodigo(txtProcurar.Text, rbEmAberto.Text, rbRecebido.Text, dtpDe.Value.ToString(), dtpAte.Value.ToString());
                    }
                    else if (rbFinalizado.Checked && rbEmAbertoPagamento.Checked)
                    {
                        dgvAgendamentos.DataSource = controllerAgendamentos.CarregarPorCodigo(txtProcurar.Text, rbFinalizado.Text, rbEmAbertoPagamento.Text, dtpDe.Value.ToString(), dtpAte.Value.ToString());
                    }
                }
                else if (cbxFiltro.Text == "NOME")
                {
                    if (rbEmAberto.Checked && rbEmAbertoPagamento.Checked)
                    {
                        dgvAgendamentos.DataSource = controllerAgendamentos.CarregarPorNome(txtProcurar.Text, rbEmAberto.Text, rbEmAbertoPagamento.Text, dtpDe.Value.ToString(), dtpAte.Value.ToString());
                    }
                    else if (rbFinalizado.Checked && rbRecebido.Checked)
                    {
                        dgvAgendamentos.DataSource = controllerAgendamentos.CarregarPorNome(txtProcurar.Text, rbFinalizado.Text, rbRecebido.Text, dtpDe.Value.ToString(), dtpAte.Value.ToString());
                    }
                    else if (rbEmAberto.Checked && rbRecebido.Checked)
                    {
                        dgvAgendamentos.DataSource = controllerAgendamentos.CarregarPorNome(txtProcurar.Text, rbEmAberto.Text, rbRecebido.Text, dtpDe.Value.ToString(), dtpAte.Value.ToString());
                    }
                    else if (rbFinalizado.Checked && rbEmAbertoPagamento.Checked)
                    {
                        dgvAgendamentos.DataSource = controllerAgendamentos.CarregarPorNome(txtProcurar.Text, rbFinalizado.Text, rbEmAbertoPagamento.Text, dtpDe.Value.ToString(), dtpAte.Value.ToString());
                    }
                }
                lblExibidosTotal.Text = "Exibidos total: " + dgvAgendamentos.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            modelAgendamentos.acao = btnNovo.Text;
            FrmCadastroAgendamento frmCadastroAgendamento = new FrmCadastroAgendamento(modelAgendamentos);
            frmCadastroAgendamento.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Carregar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAgendamentos.Rows.Count > 0 && dgvAgendamentos.CurrentRow.Cells["StatusAgendamento"].Value.ToString() == rbEmAberto.Text)
                {
                    modelAgendamentos.acao = btnConsultar.Text;
                    modelAgendamentos.Codigo = Convert.ToInt32(dgvAgendamentos.CurrentRow.Cells["Codigo"].Value.ToString());
                    modelAgendamentos.Nome = dgvAgendamentos.CurrentRow.Cells["Nome"].Value.ToString();
                    modelAgendamentos.Endereco = dgvAgendamentos.CurrentRow.Cells["Endereco"].Value.ToString();
                    modelAgendamentos.Telefone = dgvAgendamentos.CurrentRow.Cells["Telefone"].Value.ToString();
                    modelAgendamentos.Dn = dgvAgendamentos.CurrentRow.Cells["Dn"].Value.ToString();
                    modelAgendamentos.CadastradoPor = dgvAgendamentos.CurrentRow.Cells["CadastradoPor"].Value.ToString();
                    modelAgendamentos.DataAgendamento = dgvAgendamentos.CurrentRow.Cells["DataAgendamento"].Value.ToString();
                    modelAgendamentos.HoraAgendamento = dgvAgendamentos.CurrentRow.Cells["HoraAgendamento"].Value.ToString();
                    modelAgendamentos.StatusAgendamento = dgvAgendamentos.CurrentRow.Cells["StatusAgendamento"].Value.ToString();
                    modelAgendamentos.Servico = dgvAgendamentos.CurrentRow.Cells["Servico"].Value.ToString();
                    modelAgendamentos.Clinico = dgvAgendamentos.CurrentRow.Cells["Clinico"].Value.ToString();
                    modelAgendamentos.Valor = Convert.ToDecimal(dgvAgendamentos.CurrentRow.Cells["Valor"].Value.ToString());
                    FrmCadastroAgendamento frmCadastroAgendamento = new FrmCadastroAgendamento(modelAgendamentos);
                    frmCadastroAgendamento.ShowDialog();
                    Carregar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAgendamentos.Rows.Count > 0 && dgvAgendamentos.CurrentRow.Cells["StatusAgendamento"].Value.ToString() == rbEmAberto.Text)
                {
                    modelAgendamentos.acao = btnSalvar.Text;
                    modelAgendamentos.Codigo = Convert.ToInt32(dgvAgendamentos.CurrentRow.Cells["Codigo"].Value.ToString());
                    modelAgendamentos.Nome = dgvAgendamentos.CurrentRow.Cells["Nome"].Value.ToString();
                    modelAgendamentos.Endereco = dgvAgendamentos.CurrentRow.Cells["Endereco"].Value.ToString();
                    modelAgendamentos.Telefone = dgvAgendamentos.CurrentRow.Cells["Telefone"].Value.ToString();
                    modelAgendamentos.Dn = dgvAgendamentos.CurrentRow.Cells["Dn"].Value.ToString();
                    modelAgendamentos.CadastradoPor = dgvAgendamentos.CurrentRow.Cells["CadastradoPor"].Value.ToString();
                    modelAgendamentos.DataAgendamento = dgvAgendamentos.CurrentRow.Cells["DataAgendamento"].Value.ToString();
                    modelAgendamentos.HoraAgendamento = dgvAgendamentos.CurrentRow.Cells["HoraAgendamento"].Value.ToString();
                    modelAgendamentos.StatusAgendamento = dgvAgendamentos.CurrentRow.Cells["StatusAgendamento"].Value.ToString();
                    modelAgendamentos.Clinico = dgvAgendamentos.CurrentRow.Cells["Clinico"].Value.ToString();
                    modelAgendamentos.Servico = dgvAgendamentos.CurrentRow.Cells["Servico"].Value.ToString();
                    modelAgendamentos.Valor = Convert.ToDecimal(dgvAgendamentos.CurrentRow.Cells["Valor"].Value.ToString());
                    FrmCadastroAgendamento frmCadastroAgendamento = new FrmCadastroAgendamento(modelAgendamentos);
                    frmCadastroAgendamento.ShowDialog();
                    Carregar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReceber_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAgendamentos.Rows.Count > 0 && dgvAgendamentos.CurrentRow.Cells["StatusPagamento"].Value.ToString() == rbEmAbertoPagamento.Text)
                {
                    modelAgendamentos.Codigo = Convert.ToInt32(dgvAgendamentos.CurrentRow.Cells["Codigo"].Value.ToString());
                    modelAgendamentos.Nome = dgvAgendamentos.CurrentRow.Cells["Nome"].Value.ToString();
                    modelAgendamentos.Endereco = dgvAgendamentos.CurrentRow.Cells["Endereco"].Value.ToString();
                    modelAgendamentos.Telefone = dgvAgendamentos.CurrentRow.Cells["Telefone"].Value.ToString();
                    modelAgendamentos.Dn = dgvAgendamentos.CurrentRow.Cells["Dn"].Value.ToString();
                    modelAgendamentos.Servico = dgvAgendamentos.CurrentRow.Cells["Servico"].Value.ToString();
                    modelAgendamentos.Valor = Convert.ToDecimal(dgvAgendamentos.CurrentRow.Cells["Valor"].Value.ToString());
                    modelAgendamentos.Clinico = dgvAgendamentos.CurrentRow.Cells["Clinico"].Value.ToString();
                    //modelAgendamentos.Dinheiro = Convert.ToDecimal(dgvAgendamentos.CurrentRow.Cells["Dinheiro"].Value.ToString());
                    //modelAgendamentos.Cartao = Convert.ToDecimal(dgvAgendamentos.CurrentRow.Cells["Cartao"].Value.ToString());
                    //modelAgendamentos.Ticket = Convert.ToDecimal(dgvAgendamentos.CurrentRow.Cells["Ticket"].Value.ToString());
                    FrmAgendamentoReceber frmAgendamentoReceber = new FrmAgendamentoReceber(modelAgendamentos);
                    frmAgendamentoReceber.ShowDialog();
                    Carregar();
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

        private void dgvAgendamentos_DoubleClick(object sender, EventArgs e)
        {
            if (dgvAgendamentos.Rows.Count > 0 && SelecionarCliente)
            {
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAgendamentos.Rows.Count > 0 && dgvAgendamentos.CurrentRow.Cells["StatusPagamento"].Value.ToString() == rbEmAbertoPagamento.Text && dgvAgendamentos.CurrentRow.Cells["StatusAgendamento"].Value.ToString() == rbEmAberto.Text)
                {
                    modelAgendamentos.Codigo = Convert.ToInt32(dgvAgendamentos.CurrentRow.Cells["Codigo"].Value.ToString());
                    modelAgendamentos.Nome = dgvAgendamentos.CurrentRow.Cells["Nome"].Value.ToString();
                    modelAgendamentos.DataAgendamento = dgvAgendamentos.CurrentRow.Cells["DataAgendamento"].Value.ToString();
                    modelAgendamentos.HoraAgendamento = dgvAgendamentos.CurrentRow.Cells["HoraAgendamento"].Value.ToString();
                    var result = MessageBox.Show("Deseja cancelar o agendamento:\nData: " + modelAgendamentos.DataAgendamento.Replace("00:00:00","") + "\nHorário: " + modelAgendamentos.HoraAgendamento + "\nCliente: " + modelAgendamentos.Nome + "?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        controllerAgendamentos.Deletar(modelAgendamentos);
                        Carregar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
