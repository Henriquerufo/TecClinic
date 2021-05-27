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
    public partial class FrmCadastroHorario : Form
    {
        ControllerHorario controllerHorario = new ControllerHorario();
        ModelHorario modelHorario = new ModelHorario();
        int codigo;
        string acao;
        public FrmCadastroHorario(ModelHorario modelHorario)
        {
            InitializeComponent();
            ControllerTema controllerTema = new ControllerTema();
            if (controllerTema.CarregarEnderecoImagem() != null)
            {
                pictureBox1.BackgroundImage = Image.FromFile(controllerTema.CarregarEnderecoImagem());
            }
            if (modelHorario.acao == "Editar")
            {
                acao = modelHorario.acao;
                codigo = modelHorario.Codigo;
                pnlCadastroHorario.Enabled = false;
                btnCancelar.Text = "Fechar";
                btnCadastrar.Text = "Editar";
                lblNovo.Text = acao;
                dtpHora.Text = modelHorario.Hora;
            }
            else if (modelHorario.acao == "Consultar")
            {
                acao = modelHorario.acao;
                codigo = modelHorario.Codigo;
                pnlCadastroHorario.Enabled = false;
                btnCancelar.Text = "Fechar";
                btnCadastrar.Visible = false;
                lblNovo.Text = acao;
                dtpHora.Text = modelHorario.Hora;
            }
            else if (modelHorario.acao == "Cadastrar")
            {
                acao = modelHorario.acao;
            }
            Text = "Tec Clinic: " + modelHorario.acao + " Horário";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (acao == "Cadastrar")
                {
                    modelHorario.Clinico = Properties.SettingsLogado.Default.Nome;
                    modelHorario.Hora = dtpHora.Text;
                    if (!controllerHorario.VerificarHorarioCadastrado(modelHorario) && controllerHorario.Cadastrar(modelHorario))
                    {
                        MessageBox.Show("Cadastrado com sucesso!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Horário já cadastrado!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (acao == "Editar" && btnCadastrar.Text == "Editar")
                {
                    pnlCadastroHorario.Enabled = true;
                    btnCadastrar.Text = "Salvar";
                    btnCancelar.Text = "Cancelar";
                }
                else if (acao == "Editar" && btnCadastrar.Text == "Salvar")
                {
                    modelHorario.Codigo = codigo;
                    modelHorario.Clinico = Properties.SettingsLogado.Default.Nome;
                    modelHorario.Hora = dtpHora.Text;
                    if (controllerHorario.Editar(modelHorario))
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
