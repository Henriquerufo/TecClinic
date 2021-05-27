using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controller;

namespace View
{
    public partial class FrmCadastroAgendamento : Form
    {
        ControllerAgendamentos controllerAgendamentos = new ControllerAgendamentos();
        ModelAgendamentos modelAgendamentos = new ModelAgendamentos();
        ControllerTema controllerTema = new ControllerTema();
        int codigo;
        string acao;
        decimal valorServico;
        decimal valorTotalPago;
        bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Inserá um nome valido!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                MessageBox.Show("Inserá um endereço valido!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEndereco.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTelefone.Text))
            {
                MessageBox.Show("Inserá um telefone valido!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTelefone.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNomeServico.Text))
            {
                MessageBox.Show("Inserá um serviço!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProcurarServico.Focus();
                return false;
            }
            if (dgvHorario.SelectedRows.Count < 0)
            {
                MessageBox.Show("Inserá um horário valido!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnProcurarHorario.Focus();
                return false;
            }
            return true;
        }
        public FrmCadastroAgendamento(ModelAgendamentos modelAgendamentos)
        {
            InitializeComponent();
            
            if (controllerTema.CarregarEnderecoImagem() != null)
            {
                pictureBox1.BackgroundImage = Image.FromFile(controllerTema.CarregarEnderecoImagem());
            }
            if (modelAgendamentos.acao == "Editar")
            {
                lblNovo.Text = modelAgendamentos.acao;
                btnCancelar.Text = "Fechar";
                btnSalvar.Text = "Editar";
                grbInformacoesDoCliente.Enabled = false;
                grbServico.Enabled = false;
                gpbAgendar.Enabled = false;
                acao = modelAgendamentos.acao;
                codigo = modelAgendamentos.Codigo;
                txtNome.Text = modelAgendamentos.Nome;
                txtEndereco.Text = modelAgendamentos.Endereco;
                txtTelefone.Text = modelAgendamentos.Telefone;
                txtDn.Text = modelAgendamentos.Dn;
                dtpDataAgendamento.Text = modelAgendamentos.DataAgendamento;
                txtNomeServico.Text = modelAgendamentos.Servico;
                txtClinico.Text = modelAgendamentos.Clinico;
                txtValorServico.Text = modelAgendamentos.Valor.ToString();
            }
            else if (modelAgendamentos.acao == "Finalizar")
            {
                lblCampoObrigatorio.Visible = false;
                gpbObs.Visible = true;
                btnSalvar.Text = "Finalizar C.";
                valorServico = modelAgendamentos.Valor;
                gpbAgendar.Visible = false;
                lblNovo.Text = modelAgendamentos.acao;
                btnCancelar.Text = "Fechar";
                grbInformacoesDoCliente.Enabled = false;
                grbServico.Enabled = false;
                acao = modelAgendamentos.acao;
                codigo = modelAgendamentos.Codigo;
                txtNome.Text = modelAgendamentos.Nome;
                txtEndereco.Text = modelAgendamentos.Endereco;
                txtTelefone.Text = modelAgendamentos.Telefone;
                txtDn.Text = modelAgendamentos.Dn;
                dtpDataAgendamento.Text = modelAgendamentos.DataAgendamento;
                txtNomeServico.Text = modelAgendamentos.Servico;
                txtClinico.Text = modelAgendamentos.Clinico;
                txtValorServico.Text = modelAgendamentos.Valor.ToString();
            }
            else if (modelAgendamentos.acao == "Novo")
            {
                lblNovo.Text = modelAgendamentos.acao;
                acao = modelAgendamentos.acao;
            }
            Text = "Tec Clinic: " + modelAgendamentos.acao + " Agendamento";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (acao == "Novo" && btnSalvar.Text == "Registrar" && ValidarCampos())
                {
                    modelAgendamentos.Nome = txtNome.Text;
                    modelAgendamentos.Endereco = txtEndereco.Text;
                    modelAgendamentos.Telefone = txtTelefone.Text;
                    modelAgendamentos.Dn = txtDn.Text;
                    modelAgendamentos.CadastradoPor = Properties.SettingsLogado.Default.Nome;
                    modelAgendamentos.DataAgendamento = dtpDataAgendamento.Text;
                    if (dgvHorario.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow row in dgvHorario.SelectedRows)
                        {
                            modelAgendamentos.HoraAgendamento += row.Cells["Hora"].Value.ToString() + " ";
                        }
                    }
                    modelAgendamentos.StatusAgendamento = "Em Aberto";
                    modelAgendamentos.StatusPagamento = "Em Aberto";
                    modelAgendamentos.Servico = txtNomeServico.Text;
                    modelAgendamentos.Clinico = txtClinico.Text;
                    modelAgendamentos.Valor = Convert.ToDecimal(txtValorServico.Text);
                    if (controllerAgendamentos.Cadastrar(modelAgendamentos))
                    {
                        MessageBox.Show("Registrado com sucesso!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else if (acao == "Editar" && btnSalvar.Text == "Editar")
                {
                    btnSalvar.Text = "Salvar";
                    btnCancelar.Text = "Cancelar";
                    gpbAgendar.Enabled = true;

                }
                else if (acao == "Editar" && btnSalvar.Text == "Salvar" && ValidarCampos())
                {
                    modelAgendamentos.Codigo = codigo;
                    modelAgendamentos.Nome = txtNome.Text;
                    modelAgendamentos.Endereco = txtEndereco.Text;
                    modelAgendamentos.Telefone = txtTelefone.Text;
                    modelAgendamentos.Dn = txtDn.Text;
                    modelAgendamentos.CadastradoPor = Properties.SettingsLogado.Default.Nome;
                    modelAgendamentos.DataAgendamento = dtpDataAgendamento.Text;
                    if (dgvHorario.Rows.Count > 0)
                    {
                        modelAgendamentos.HoraAgendamento = dgvHorario.CurrentRow.Cells["Hora"].Value.ToString();
                    }
                    modelAgendamentos.StatusAgendamento = "Em Aberto";
                    modelAgendamentos.Servico = txtNomeServico.Text;
                    modelAgendamentos.Clinico = txtClinico.Text;
                    modelAgendamentos.Valor = Convert.ToDecimal(txtValorServico.Text);
                    if (controllerAgendamentos.Editar(modelAgendamentos))
                    {
                        MessageBox.Show("Editado com sucesso!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else if (acao == "Finalizar" && btnSalvar.Text == "Finalizar C.")
                {
                    modelAgendamentos.Codigo = codigo;
                    modelAgendamentos.Nome = txtNome.Text;
                    modelAgendamentos.StatusAgendamento = "Finalizado";
                    modelAgendamentos.ObsConsulta = txtObs.Text;
                    if (controllerAgendamentos.VerificarClienteCadastrado(modelAgendamentos))
                    {
                        if (controllerAgendamentos.FinalizarAgendamento(modelAgendamentos))
                        {
                            MessageBox.Show("Finalizado com sucesso!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cliente sem Ficha de Anamnese registrada!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtProcurarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                FrmGerenciadorClientes frmGerenciadorClientes = new FrmGerenciadorClientes(true);
                frmGerenciadorClientes.ShowDialog();
                txtNome.Text = frmGerenciadorClientes.RetornarNomeCliente;
                txtEndereco.Text = frmGerenciadorClientes.RetornarEnderecoCliente;
                txtTelefone.Text = frmGerenciadorClientes.RetornarTelefoneCliente;
                txtDn.Text = frmGerenciadorClientes.RetornarDnCliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtProcurarServico_Click(object sender, EventArgs e)
        {
            try
            {
                FrmGerenciadorServicos frmGerenciadorServicos = new FrmGerenciadorServicos(true);
                frmGerenciadorServicos.ShowDialog();
                txtNomeServico.Text = frmGerenciadorServicos.RetornarNomeServico;
                txtClinico.Text = frmGerenciadorServicos.RetornarNomeClinico;
                txtValorServico.Text = frmGerenciadorServicos.RetornarValorServico.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProcurarHorario_Click(object sender, EventArgs e)
        {
            try
            {
                dgvHorario.Rows.Clear();
                List<string> HorariosCadastrados = new List<string>();
                HorariosCadastrados = controllerAgendamentos.CarregarHorariosCadastrados(txtClinico.Text);
                foreach (string horariosCadastrados in HorariosCadastrados)
                {
                    if (controllerAgendamentos.CarregarHorariosOcupados(dtpDataAgendamento.Text, horariosCadastrados, txtClinico.Text))
                    {
                        dgvHorario.Rows.Insert(0, horariosCadastrados);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
