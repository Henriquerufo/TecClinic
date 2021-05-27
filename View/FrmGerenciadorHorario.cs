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
    public partial class FrmGerenciadorHorario : Form
    {
        ControllerHorario controllerHorario = new ControllerHorario();
        ModelHorario modelHorario = new ModelHorario();
        public FrmGerenciadorHorario()
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
                    dgvHorario.DataSource = controllerHorario.CarregarPorCodigo(txtProcurar.Text, Properties.SettingsLogado.Default.Nome);
                }
                else if (cbxFiltro.Text == "NOME")
                {
                    dgvHorario.DataSource = controllerHorario.CarregarPorNome(txtProcurar.Text, Properties.SettingsLogado.Default.Nome);
                }
                lblExibidosTotal.Text = "Exibidos total: " + dgvHorario.Rows.Count;
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                modelHorario.acao = btnCadastrar.Text;
                FrmCadastroHorario frmCadastroHorario = new FrmCadastroHorario(modelHorario);
                frmCadastroHorario.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvHorario.Rows.Count > 0)
                {
                    modelHorario.acao = btnEditar.Text;
                    modelHorario.Codigo = Convert.ToInt32(dgvHorario.CurrentRow.Cells["Codigo"].Value.ToString());
                    modelHorario.Clinico = dgvHorario.CurrentRow.Cells["Clinico"].Value.ToString();
                    modelHorario.Hora = dgvHorario.CurrentRow.Cells["Hora"].Value.ToString();
                    FrmCadastroHorario frmCadastroHorario = new FrmCadastroHorario(modelHorario);
                    frmCadastroHorario.ShowDialog();
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvHorario.Rows.Count > 0)
                {
                    modelHorario.acao = btnConsultar.Text;
                    modelHorario.Codigo = Convert.ToInt32(dgvHorario.CurrentRow.Cells["Codigo"].Value.ToString());
                    modelHorario.Clinico = dgvHorario.CurrentRow.Cells["Clinico"].Value.ToString();
                    modelHorario.Hora = dgvHorario.CurrentRow.Cells["Hora"].Value.ToString();
                    FrmCadastroHorario frmCadastroHorario = new FrmCadastroHorario(modelHorario);
                    frmCadastroHorario.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
