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
        int codigo;
        string acao;
        public FrmCadastroAgendamento(ModelAgendamentos modelAgendamentos)
        {
            InitializeComponent();
            if (modelAgendamentos.acao == "Editar")
            {
                btnCancelar.Text = "Fechar";
                btnSalvar.Text = "Editar";
                pnlAgendamento.Enabled = false;
                acao = modelAgendamentos.acao;
                codigo = modelAgendamentos.Codigo;
                txtNome.Text = modelAgendamentos.Nome;
                txtEndereco.Text = modelAgendamentos.Endereco;
                txtTelefone.Text = modelAgendamentos.Telefone;
                txtDn.Text = modelAgendamentos.Dn;
                dtpDataAgendamento.Text = modelAgendamentos.DataAgendamento;
                dtpHoraAgendamento.Text = modelAgendamentos.HoraAgendamento;
            }
            else if (modelAgendamentos.acao == "Consultar")
            {
                btnCancelar.Text = "Fechar";
                btnSalvar.Visible = false;
                pnlAgendamento.Enabled = false;
                acao = modelAgendamentos.acao;
                codigo = modelAgendamentos.Codigo;
                txtNome.Text = modelAgendamentos.Nome;
                txtEndereco.Text = modelAgendamentos.Endereco;
                txtTelefone.Text = modelAgendamentos.Telefone;
                txtDn.Text = modelAgendamentos.Dn;
                dtpDataAgendamento.Text = modelAgendamentos.DataAgendamento;
                dtpHoraAgendamento.Text = modelAgendamentos.HoraAgendamento;
            }
            else if (modelAgendamentos.acao == "Cadastrar")
            {
                acao = modelAgendamentos.acao;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (acao == "Cadastrar" && btnSalvar.Text == "Registrar")
            {
                modelAgendamentos.Nome = txtNome.Text;
                modelAgendamentos.Endereco = txtEndereco.Text;
                modelAgendamentos.Telefone = txtTelefone.Text;
                modelAgendamentos.Dn = txtDn.Text;
                modelAgendamentos.CadastradoPor = Properties.SettingsLogado.Default.Nome;
                modelAgendamentos.DataAgendamento = dtpDataAgendamento.Text;
                modelAgendamentos.HoraAgendamento = dtpHoraAgendamento.Text;
                controllerAgendamentos.Cadastrar(modelAgendamentos);
            }
            else if (acao == "Cadastrar" && btnSalvar.Text == "Editar")
            {
                btnSalvar.Text = "Salvar";
                btnCancelar.Text = "Cancelar";
                pnlAgendamento.Enabled = true;
                
            }
            else if (acao == "Cadastrar" && btnSalvar.Text == "Salvar")
            {
                modelAgendamentos.Nome = txtNome.Text;
                modelAgendamentos.Endereco = txtEndereco.Text;
                modelAgendamentos.Telefone = txtTelefone.Text;
                modelAgendamentos.Dn = txtDn.Text;
                modelAgendamentos.CadastradoPor = Properties.SettingsLogado.Default.Nome;
                modelAgendamentos.DataAgendamento = dtpDataAgendamento.Text;
                modelAgendamentos.HoraAgendamento = dtpHoraAgendamento.Text;
            }
        }
    }
}
