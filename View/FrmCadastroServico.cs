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
            ControllerTema controllerTema = new ControllerTema();
            if (controllerTema.CarregarEnderecoImagem() != null)
            {
                pictureBox1.BackgroundImage = Image.FromFile(controllerTema.CarregarEnderecoImagem());
            }
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
            Text = "Tec Clinic: " + modelServicos.acao + " Serviço";
        }
        bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Insera um serviço valido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTipo.Text))
            {
                MessageBox.Show("Insera o tipo de serviço valido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTipo.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtValor.Text))
            {
                MessageBox.Show("Insera um valor valido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValor.Focus();
                return false;
            }
            return true;
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (acao == "Cadastrar" && btnCadastrar.Text == "Cadastrar" && ValidarCampos())
                {
                    modelServicos.Nome = txtNome.Text;
                    modelServicos.Tipo = txtTipo.Text;
                    modelServicos.Valor = Convert.ToDecimal(txtValor.Text);
                    modelServicos.Descricao = rtbDescricao.Text;
                    modelServicos.Clinico = Properties.SettingsLogado.Default.Nome;
                    if (!controllerServicos.VerificarServicoCadastrado(modelServicos) && controllerServicos.Cadastrar(modelServicos))
                    {
                        MessageBox.Show("Cadastrado com sucesso!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Serviço já cadastrado!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (acao == "Editar" && btnCadastrar.Text == "Editar")
                {
                    btnCadastrar.Text = "Salvar";
                    btnCancelar.Text = "Cancelar";
                    pnlServico.Enabled = true;
                }
                else if (acao == "Editar" && btnCadastrar.Text == "Salvar" && ValidarCampos())
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
