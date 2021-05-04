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
    public partial class FrmGerenciadorClientes : Form
    {
        ControllerCliente controllerCliente = new ControllerCliente();
        ModelCliente modelCliente = new ModelCliente();
        public FrmGerenciadorClientes()
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
                    dgvCadastrados.DataSource = controllerCliente.CarregarClientePorCodigo(txtProcurar.Text);
                }
                if (cbxFiltro.Text == "NOME")
                {
                    dgvCadastrados.DataSource = controllerCliente.CarregarClientePorNome(txtProcurar.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void CarregarModel()
        {
            modelCliente.Codigo = Convert.ToInt32(dgvCadastrados.CurrentRow.Cells["Codigo"].Value.ToString());
            modelCliente.Nome = dgvCadastrados.CurrentRow.Cells["Nome"].Value.ToString();
            modelCliente.Endereco = dgvCadastrados.CurrentRow.Cells["Endereco"].Value.ToString();
            modelCliente.Bairro = dgvCadastrados.CurrentRow.Cells["Bairro"].Value.ToString();
            modelCliente.Cidade = dgvCadastrados.CurrentRow.Cells["Cidade"].Value.ToString();
            modelCliente.CEP = dgvCadastrados.CurrentRow.Cells["Cep"].Value.ToString();
            modelCliente.Email = dgvCadastrados.CurrentRow.Cells["Email"].Value.ToString();
            modelCliente.Telefone = dgvCadastrados.CurrentRow.Cells["Telefone"].Value.ToString();
            modelCliente.Dn = dgvCadastrados.CurrentRow.Cells["Dn"].Value.ToString();
            modelCliente.idade = Convert.ToInt32(dgvCadastrados.CurrentRow.Cells["Idade"].Value.ToString());
            modelCliente.Sexo = dgvCadastrados.CurrentRow.Cells["Sexo"].Value.ToString();
            modelCliente.EstadoCivil = dgvCadastrados.CurrentRow.Cells["EstadoCivil"].Value.ToString();
            modelCliente.Filhos = dgvCadastrados.CurrentRow.Cells["Filhos"].Value.ToString();
            modelCliente.Profissao = dgvCadastrados.CurrentRow.Cells["Profissao"].Value.ToString();
            modelCliente.QueixaPrincipalObjetivoCliente = dgvCadastrados.CurrentRow.Cells["QueixaPrincipalObjetivoCliente"].Value.ToString();
            modelCliente.HistoriaMolestia = dgvCadastrados.CurrentRow.Cells["HistoriaMolestia"].Value.ToString();
            modelCliente.TratamentosAnteriores = dgvCadastrados.CurrentRow.Cells["TratamentosAnteriores"].Value.ToString();
            modelCliente.TratamentosAnterioresQuais = dgvCadastrados.CurrentRow.Cells["TratamentosAnterioresQuais"].Value.ToString();
            modelCliente.GrauSatisfacao = dgvCadastrados.CurrentRow.Cells["GrauSatisfacao"].Value.ToString();
            modelCliente.AntecedentesAlergicos = dgvCadastrados.CurrentRow.Cells["AntecedentesAlergicos"].Value.ToString();
            modelCliente.txtAntecedentesAlergicos = dgvCadastrados.CurrentRow.Cells["txtAntecedentesAlergicos"].Value.ToString();
            modelCliente.txtDiagnosticoDePsoriaseOuHanseniase = dgvCadastrados.CurrentRow.Cells["txtDiagnosticoDePsoriaseOuHanseniase"].Value.ToString();
            modelCliente.FuncionamentoIntestinalRegular = dgvCadastrados.CurrentRow.Cells["FuncionamentoIntestinalRegular"].Value.ToString();
            modelCliente.txtFuncionamentoIntestinalRegular = dgvCadastrados.CurrentRow.Cells["txtFuncionamentoIntestinalRegular"].Value.ToString();
            modelCliente.PraticaAtividadeFisica = dgvCadastrados.CurrentRow.Cells["PraticaAtividadeFisica"].Value.ToString();
            modelCliente.txtPraticaAtividadeFisica = dgvCadastrados.CurrentRow.Cells["txtPraticaAtividadeFisica"].Value.ToString();
            modelCliente.TemHabitoDeSeExporAoSol = dgvCadastrados.CurrentRow.Cells["TemHabitoDeSeExporAoSol"].Value.ToString();
            modelCliente.txtTemHabitoDeSeExporAoSol = dgvCadastrados.CurrentRow.Cells["txtTemHabitoDeSeExporAoSol"].Value.ToString();
            modelCliente.FazAlgumTratamentoMedico = dgvCadastrados.CurrentRow.Cells["FazAlgumTratamentoMedico"].Value.ToString();
            modelCliente.txtFazAlgumTratamentoMedico = dgvCadastrados.CurrentRow.Cells["txtFazAlgumTratamentoMedico"].Value.ToString();
            modelCliente.UsaAlgumTipoDeMedicamento = dgvCadastrados.CurrentRow.Cells["UsaAlgumTipoDeMedicamento"].Value.ToString();
            modelCliente.txtUsaAlgumTipoDeMedicamento = dgvCadastrados.CurrentRow.Cells["txtUsaAlgumTipoDeMedicamento"].Value.ToString();
            modelCliente.EGestanteOuEstaAmamentando = dgvCadastrados.CurrentRow.Cells["EGestanteOuEstaAmamentando"].Value.ToString();
            modelCliente.txtEGestanteOuEstaAmamentando = dgvCadastrados.CurrentRow.Cells["txtEGestanteOuEstaAmamentando"].Value.ToString();
            modelCliente.CicloMenstrualRegular = dgvCadastrados.CurrentRow.Cells["CicloMenstrualRegular"].Value.ToString();
            modelCliente.txtCicloMenstrualRegular = dgvCadastrados.CurrentRow.Cells["txtCicloMenstrualRegular"].Value.ToString();
            modelCliente.PortadorDeMarcaPasso = dgvCadastrados.CurrentRow.Cells["PortadorDeMarcaPasso"].Value.ToString();
            modelCliente.txtPortadorDeMarcaPasso = dgvCadastrados.CurrentRow.Cells["txtPortadorDeMarcaPasso"].Value.ToString();
            modelCliente.TemAlgumProblemaCardiovascular = dgvCadastrados.CurrentRow.Cells["TemAlgumProblemaCardiovascular"].Value.ToString();
            modelCliente.txtTemAlgumProblemaCardiovascular = dgvCadastrados.CurrentRow.Cells["txtTemAlgumProblemaCardiovascular"].Value.ToString();
            modelCliente.PresencaDeProteseMetalica = dgvCadastrados.CurrentRow.Cells["PresencaDeProteseMetalica"].Value.ToString();
            modelCliente.txtPresencaDeProteseMetalica = dgvCadastrados.CurrentRow.Cells["txtPresencaDeProteseMetalica"].Value.ToString();
            modelCliente.PortadorDeEpilepsia = dgvCadastrados.CurrentRow.Cells["PortadorDeEpilepsia"].Value.ToString();
            modelCliente.txtPortadorDeEpilepsia = dgvCadastrados.CurrentRow.Cells["txtPortadorDeEpilepsia"].Value.ToString();
            modelCliente.TemDiabetesOuHipertesao = dgvCadastrados.CurrentRow.Cells["TemDiabetesOuHipertesao"].Value.ToString();
            modelCliente.txtTemDiabetesOuHipertesao = dgvCadastrados.CurrentRow.Cells["txtTemDiabetesOuHipertesao"].Value.ToString();
            modelCliente.IngereBastanteAgua = dgvCadastrados.CurrentRow.Cells["IngereBastanteAgua"].Value.ToString();
            modelCliente.txtIngereBastanteAgua = dgvCadastrados.CurrentRow.Cells["txtIngereBastanteAgua"].Value.ToString();
            modelCliente.Cancer = dgvCadastrados.CurrentRow.Cells["Cancer"].Value.ToString();
            modelCliente.txtCancer = dgvCadastrados.CurrentRow.Cells["txtCancer"].Value.ToString();
            modelCliente.Trombose = dgvCadastrados.CurrentRow.Cells["Trombose"].Value.ToString();
            modelCliente.txtTrombose = dgvCadastrados.CurrentRow.Cells["txtTrombose"].Value.ToString();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Carregar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                modelCliente.acao = btnCadastrar.Text;
                FrmCadastroCliente frmCadastroCliente = new FrmCadastroCliente(modelCliente);
                frmCadastroCliente.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCadastrados.Rows.Count > 0)
            {
                try
                {
                    modelCliente.acao = btnEditar.Text;
                    CarregarModel();
                    FrmCadastroCliente frmCadastroCliente = new FrmCadastroCliente(modelCliente);
                    frmCadastroCliente.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dgvCadastrados.Rows.Count > 0)
            {
                try
                {
                    modelCliente.acao = btnConsultar.Text;
                    CarregarModel();
                    FrmCadastroCliente frmCadastroCliente = new FrmCadastroCliente(modelCliente);
                    frmCadastroCliente.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                modelCliente.Codigo = Convert.ToInt32(dgvCadastrados.CurrentRow.Cells["Codigo"].Value.ToString());
                controllerCliente.Deletar(modelCliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
