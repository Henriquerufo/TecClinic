using Controller;
using Model;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace View
{
    public partial class FrmPrincipal : Form
    {
        ControllerTema controllerTema = new ControllerTema();
        ModelLogin modelLogin = new ModelLogin();
        void CarregarTema()
        {
            if (controllerTema.CarregarEnderecoImagemFundo() != null)
            {
                BackgroundImage = Image.FromFile(controllerTema.CarregarEnderecoImagemFundo());
                BackColor = Color.FromArgb(controllerTema.CarregarColorR(), controllerTema.CarregarColorG(), controllerTema.CarregarColorB());
            }
        }
        public FrmPrincipal(ModelLogin modelLogin)
        {
            InitializeComponent();
            CarregarTema();
            lblStatusLogin.Text = modelLogin.Nivel + ": " + modelLogin.ID;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = DateTime.Now.ToString();
        }

        private void gerenciarTemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGerenciadorTema frmGerenciadorTema = new FrmGerenciadorTema();
            frmGerenciadorTema.ShowDialog();
            if (frmGerenciadorTema.RetornoTema)
            {
                this.Close();
            }
        }

        private void cadastrarNovoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            modelLogin.Consultar = false;
            modelLogin.Codigo = null;
            FrmCadastroLogin frmCadastroLogin = new FrmCadastroLogin(modelLogin);
            frmCadastroLogin.Show();
        }

        private void consultarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGerenciadorLogins frmGerenciadorLogins = new FrmGerenciadorLogins();
            frmGerenciadorLogins.Show();
        }
        private void cadastrarNovoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente frmCadastroCliente = new FrmCadastroCliente(null);
            frmCadastroCliente.Show();
        }

        private void consultarListaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmGerenciadorClientes frmGerenciadorClientes = new FrmGerenciadorClientes();
            frmGerenciadorClientes.Show();
        }
    }
}
