using Controller;
using Model;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class FrmLogin : Form
    {
        ControllerLogin controllerLogin = new ControllerLogin();
        ModelLogin modelLogin = new ModelLogin();
        ModelLogin modelLoginAutenticacao = new ModelLogin();
        public String Retorno
        {
            get
            {
                return modelLoginAutenticacao.Nivel;
            }
        }
        public FrmLogin(ModelLogin modelLogin)
        {
            InitializeComponent();
            if (!string.IsNullOrWhiteSpace(modelLogin.Nivel))
            {
                btnLogar.Text = "OK";
            }
        }
        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (btnLogar.Text == "Logar")
            {
                modelLogin.ID = txtID.Text;
                Properties.SettingsLogado.Default.Nome = modelLogin.ID;
                modelLogin.Senha = txtSenha.Text;
                modelLogin.UltimoLog = DateTime.Now.ToString();
                lblInvalido.Visible = false;
                if (controllerLogin.VerificarLogin(modelLogin) != null && controllerLogin.VerificarLoginsContratados() > controllerLogin.VerificarLoginsOnline())
                {
                    this.Hide();
                    modelLogin.Status = "Conectado";
                    controllerLogin.InserirLog(modelLogin);
                    controllerLogin.AlterarStatus(modelLogin);
                    FrmPrincipal frmPrincipal = new FrmPrincipal(modelLogin);
                    frmPrincipal.ShowDialog();
                }
                else
                {
                    txtID.Focus();
                    lblInvalido.Visible = true;
                    return;
                }
                modelLogin.Status = "Desconectado";
                modelLogin.UltimoLog = DateTime.Now.ToString();
                controllerLogin.InserirLog(modelLogin);
                controllerLogin.AlterarStatus(modelLogin);
                Application.Exit();
            }
            else if (btnLogar.Text == "OK")
            {

                modelLoginAutenticacao.ID = txtID.Text;
                modelLoginAutenticacao.Senha = txtSenha.Text;
                modelLoginAutenticacao = controllerLogin.VerificarLogin(modelLoginAutenticacao);
                this.Close();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                this.Hide();
                FrmConfiguracaoSQL frmConfiguracaoSQL = new FrmConfiguracaoSQL();
                frmConfiguracaoSQL.ShowDialog();
                Application.Exit();
            }
        }
    }
}
