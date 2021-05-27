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
    public partial class FrmGerenciadorServicos : Form
    {
        ControllerServicos controllerServicos = new ControllerServicos();
        ModelServicos modelServicos = new ModelServicos();
        bool retornarAgendamento;
        public String RetornarNomeServico
        {
            get
            {
                if (dgvServicos.Rows.Count > 0 && retornarAgendamento)
                {
                    return dgvServicos.CurrentRow.Cells["Nome"].Value.ToString();
                }
                return null;
            }
        }
        public String RetornarNomeClinico
        {
            get
            {
                if (dgvServicos.Rows.Count > 0 && retornarAgendamento)
                {
                    return dgvServicos.CurrentRow.Cells["Clinico"].Value.ToString();
                }
                return null;
            }
        }
        public Decimal RetornarValorServico
        {
            get
            {
                if (dgvServicos.Rows.Count > 0 && retornarAgendamento)
                {
                    return Convert.ToDecimal(dgvServicos.CurrentRow.Cells["Valor"].Value.ToString());
                }
                return 0;
            }
        }
        public FrmGerenciadorServicos(bool Retornar)
        {
            InitializeComponent();
            cbxFiltro.SelectedIndex = 0;
            if (Retornar)
            {
                retornarAgendamento = Retornar;
                btnCadastrar.Visible = false;
                btnEditar.Visible = false;
                btnDeletar.Visible = false;
                btnConsultar.Visible = false;
                Text = "Selecionar Serviço";
            }
        }
        void Carregar()
        {
            try
            {
                if (cbxFiltro.Text == "CODIGO")
                {
                    dgvServicos.DataSource = controllerServicos.CarregarPorCodigo(txtProcurar.Text, Properties.SettingsLogado.Default.Nome);
                }
                else if (cbxFiltro.Text == "TIPO")
                {
                    dgvServicos.DataSource = controllerServicos.CarregarPorTipo(txtProcurar.Text, Properties.SettingsLogado.Default.Nome);
                }
                else if (cbxFiltro.Text == "NOME")
                {
                    dgvServicos.DataSource = controllerServicos.CarregarPorNome(txtProcurar.Text, Properties.SettingsLogado.Default.Nome);
                }
                if (retornarAgendamento && cbxFiltro.Text == "CODIGO")
                {
                    dgvServicos.DataSource = controllerServicos.CarregarTodosPorCodigo(txtProcurar.Text);
                }
                else if (retornarAgendamento && cbxFiltro.Text == "TIPO")
                {
                    dgvServicos.DataSource = controllerServicos.CarregarTodosPorTipo(txtProcurar.Text);
                }
                else if (retornarAgendamento && cbxFiltro.Text == "NOME")
                {
                    dgvServicos.DataSource = controllerServicos.CarregarTodosPorNome(txtProcurar.Text);
                }
                lblExibidosTotal.Text = "Exibidos total: " + dgvServicos.Rows.Count;
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvServicos.Rows.Count > 0)
                {
                    modelServicos.acao = btnConsultar.Text;
                    modelServicos.Codigo = Convert.ToInt32(dgvServicos.CurrentRow.Cells["Codigo"].Value.ToString());
                    modelServicos.Nome = dgvServicos.CurrentRow.Cells["Nome"].Value.ToString();
                    modelServicos.Tipo = dgvServicos.CurrentRow.Cells["Tipo"].Value.ToString();
                    modelServicos.Valor = Convert.ToDecimal(dgvServicos.CurrentRow.Cells["Valor"].Value.ToString());
                    modelServicos.Descricao = dgvServicos.CurrentRow.Cells["Descricao"].Value.ToString();
                    FrmCadastroServico frmCadastroServico = new FrmCadastroServico(modelServicos);
                    frmCadastroServico.ShowDialog();
                }
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
                if (dgvServicos.Rows.Count > 0)
                {
                    modelServicos.acao = btnEditar.Text;
                    modelServicos.Codigo = Convert.ToInt32(dgvServicos.CurrentRow.Cells["Codigo"].Value.ToString());
                    modelServicos.Nome = dgvServicos.CurrentRow.Cells["Nome"].Value.ToString();
                    modelServicos.Tipo = dgvServicos.CurrentRow.Cells["Tipo"].Value.ToString();
                    modelServicos.Valor = Convert.ToDecimal(dgvServicos.CurrentRow.Cells["Valor"].Value.ToString());
                    modelServicos.Descricao = dgvServicos.CurrentRow.Cells["Descricao"].Value.ToString();
                    FrmCadastroServico frmCadastroServico = new FrmCadastroServico(modelServicos);
                    frmCadastroServico.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                modelServicos.acao = btnCadastrar.Text;
                FrmCadastroServico frmCadastroServico = new FrmCadastroServico(modelServicos);
                frmCadastroServico.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvServicos.Rows.Count > 0)
                {
                    modelServicos.Codigo = Convert.ToInt32(dgvServicos.CurrentRow.Cells["Codigo"].Value.ToString());
                    modelServicos.Nome = dgvServicos.CurrentRow.Cells["Nome"].Value.ToString();
                    var result = MessageBox.Show("O serviço: " + modelServicos.Nome + " será excluido", "Alerta!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        controllerServicos.Deletar(modelServicos);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvServicos_DoubleClick(object sender, EventArgs e)
        {
            if (dgvServicos.Rows.Count > 0 && retornarAgendamento)
            {
                this.Close();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
