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
    public partial class FrmCadastroServico : Form
    {
        ControllerServicos controllerServicos = new ControllerServicos();
        ModelServicos modelServicos = new ModelServicos();
        int codigo;
        string acao;
        public FrmCadastroServico(ModelServicos modelServicos)
        {
            InitializeComponent();
            if (modelServicos.acao == "Editar")
            {
                codigo = modelServicos.Codigo;
                acao = modelServicos.acao;
                pnlServico.Enabled = false;
                btnCadastrar.Text = "Editar";
                btnCancelar.Text = "Fechar";
                txtNome.Text = modelServicos.Nome;
                txtTipo.Text = modelServicos.Tipo;
                txtValor.Text = modelServicos.Valor.ToString();
                rtbDescricao.Text = modelServicos.Descricao;
            }
            else if (modelServicos.acao == "Consultar")
            {
                codigo = modelServicos.Codigo;
                acao = modelServicos.acao;
                pnlServico.Enabled = false;
                btnCadastrar.Visible = false;
                btnCancelar.Text = "Fechar";
                txtNome.Text = modelServicos.Nome;
                txtTipo.Text = modelServicos.Tipo;
                txtValor.Text = modelServicos.Valor.ToString();
                rtbDescricao.Text = modelServicos.Descricao;
            }
            else if (modelServicos.acao == "Cadastrar")
            {
                acao = modelServicos.acao;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (acao == "Cadastrar" && btnCadastrar.Text == "Cadastrar")
            {
                modelServicos.Nome = txtNome.Text;
                modelServicos.Tipo = txtTipo.Text;
                modelServicos.Valor = Convert.ToDecimal(txtValor.Text);
                modelServicos.Descricao = rtbDescricao.Text;
                if (controllerServicos.Cadastrar(modelServicos))
                {
                    MessageBox.Show("Cadastrado com sucesso!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else if (acao == "Editar" && btnCadastrar.Text == "Editar")
            {
                btnCadastrar.Text = "Salvar";
                btnCancelar.Text = "Cancelar";
                pnlServico.Enabled = true;
            }
            else if (acao == "Editar" && btnCadastrar.Text == "Salvar")
            {
                modelServicos.Codigo = codigo;
                modelServicos.Nome = txtNome.Text;
                modelServicos.Tipo = txtTipo.Text;
                modelServicos.Valor = Convert.ToDecimal(txtValor.Text);
                modelServicos.Descricao = rtbDescricao.Text;
                if (controllerServicos.Editar(modelServicos))
                {
                    MessageBox.Show("Editado com sucesso!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
