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
            if (modelLogin.Nivel == "Secretária")
            {
                administradorToolStripMenuItem.Visible = false;
                clientesToolStripMenuItem.Visible = false;
                serviçosToolStripMenuItem.Visible = false;
                ticketToolStripMenuItem.Visible = false;
            }
            else if (modelLogin.Nivel == "Clínico")
            {
                administradorToolStripMenuItem.Visible = false;
                financeiroToolStripMenuItem.Visible = false;
            }
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
            ModelCliente modelCliente = new ModelCliente();
            modelCliente.acao = "Cadastrar";
            FrmCadastroCliente frmCadastroCliente = new FrmCadastroCliente(modelCliente);
            frmCadastroCliente.ShowDialog();
        }

        private void consultarListaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmGerenciadorClientes frmGerenciadorClientes = new FrmGerenciadorClientes(false);
            frmGerenciadorClientes.Show();
        }

        private void consultarListaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmGerenciadorAgendamentos frmGerenciadorAgendamentos = new FrmGerenciadorAgendamentos(false);
            frmGerenciadorAgendamentos.Show();
        }

        private void consultarListaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmGerenciadorHorario frmGerenciadorHorario = new FrmGerenciadorHorario();
            frmGerenciadorHorario.Show();
        }

        private void consultasFinalizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFinanceiroAgendamento frmFinanceiroAgendamento = new FrmFinanceiroAgendamento();
            frmFinanceiroAgendamento.Show();
        }

        private void consultarListaToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FrmGerenciadorTicket frmGerenciadorTicket = new FrmGerenciadorTicket();
            frmGerenciadorTicket.Show();
        }

        private void aniversariantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarAniversario frmConsultarAniversario = new FrmConsultarAniversario();
            frmConsultarAniversario.Show();
        }

        private void consultarListaToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            FrmGerenciadorServicos frmGerenciadorServicos = new FrmGerenciadorServicos(false);
            frmGerenciadorServicos.Show();
        }

        private void cadastrarNovoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ModelHorario modelHorario = new ModelHorario();
            modelHorario.acao = "Cadastrar";
            FrmCadastroHorario frmCadastroHorario = new FrmCadastroHorario(modelHorario);
            frmCadastroHorario.ShowDialog();
        }

        private void cadastrarNovoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ModelServicos modelServicos = new ModelServicos();
            modelServicos.acao = "Cadastrar";
            FrmCadastroServico frmCadastroServico = new FrmCadastroServico(modelServicos);
            frmCadastroServico.ShowDialog();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModelAgendamentos modelAgendamentos = new ModelAgendamentos();
            modelAgendamentos.acao = "Novo";
            FrmCadastroAgendamento frmCadastroAgendamento = new FrmCadastroAgendamento(modelAgendamentos);
            frmCadastroAgendamento.ShowDialog();
        }
    }
}
