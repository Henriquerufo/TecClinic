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
using System.Drawing.Printing;

namespace View
{
    public partial class FrmCadastroCliente : Form
    {
        ModelCliente modelCliente = new ModelCliente();
        ControllerCliente controllerCliente = new ControllerCliente();
        private Font printFont;
        int codigo;
        string acao;
        void CamposCrud()
        {
            modelCliente.Nome = txtNome.Text;
            modelCliente.Endereco = txtEndereco.Text;
            modelCliente.Bairro = txtBairro.Text;
            modelCliente.Cidade = txtCidade.Text;
            modelCliente.CEP = txtCep.Text;
            modelCliente.Email = txtEmail.Text;
            modelCliente.Telefone = txtTelefone.Text;
            modelCliente.Dn = txtDn.Text;
            modelCliente.idade = Convert.ToInt32(txtIdade.Text);
            modelCliente.Sexo = cbxSexo.Text;
            modelCliente.EstadoCivil = txtEstadoCivil.Text;
            modelCliente.Filhos = txtFilhos.Text;
            modelCliente.Profissao = txtProfissao.Text;
            modelCliente.QueixaPrincipalObjetivoCliente = rtbQueixaPrincipalObjetivoCliente.Text;
            modelCliente.HistoriaMolestia = rtbHistoriaMolestia.Text;
            if (rbSimTratamentosAnteriores.Checked)
            {
                modelCliente.TratamentosAnteriores = rbSimTratamentosAnteriores.Text;
            }
            else if (rbNaoTratamentosAnteriores.Checked)
            {
                modelCliente.TratamentosAnteriores = rbNaoTratamentosAnteriores.Text;
            }
            modelCliente.TratamentosAnterioresQuais = rtbTratamentoAnteriorQuais.Text;
            modelCliente.GrauSatisfacao = txtGrauSatisfacao.Text;
            modelCliente.DataCadastro = txtData.Text;
            if (rbSimAntecedentesAlergicos.Checked)
            {
                modelCliente.AntecedentesAlergicos = rbSimAntecedentesAlergicos.Text;
            }
            else if (rbNaoAntecedentesAlergicos.Checked)
            {
                modelCliente.AntecedentesAlergicos = rbNaoAntecedentesAlergicos.Text;
            }
            modelCliente.txtAntecedentesAlergicos = txtAntecedentesAlergicos.Text;
            modelCliente.txtDiagnosticoDePsoriaseOuHanseniase = txtDiagnosticoDePsoriaseOuHanseniase.Text;
            if (rbSimFuncionamentoIntestinalRegular.Checked)
            {
                modelCliente.FuncionamentoIntestinalRegular = rbSimFuncionamentoIntestinalRegular.Text;
            }
            else if (rbNaoFuncionamentoIntestinalRegular.Checked)
            {
                modelCliente.FuncionamentoIntestinalRegular = rbNaoFuncionamentoIntestinalRegular.Text;
            }
            modelCliente.txtFuncionamentoIntestinalRegular = txtFuncionamentoIntestinalRegular.Text;
            if (rbSimPraticaAtividadeFisica.Checked)
            {
                modelCliente.PraticaAtividadeFisica = rbSimPraticaAtividadeFisica.Text;
            }
            else if (rbNaoPraticaAtividadeFisica.Checked)
            {
                modelCliente.PraticaAtividadeFisica = rbNaoPraticaAtividadeFisica.Text;
            }
            modelCliente.txtPraticaAtividadeFisica = txtPraticaAtividadeFisica.Text;
            if (rbSimTemHabitoDeSeExporAoSol.Checked)
            {
                modelCliente.TemHabitoDeSeExporAoSol = rbSimTemHabitoDeSeExporAoSol.Text;
            }
            else if (rbNaoTemHabitoDeSeExporAoSol.Checked)
            {
                modelCliente.TemHabitoDeSeExporAoSol = rbNaoTemHabitoDeSeExporAoSol.Text;
            }
            modelCliente.txtTemHabitoDeSeExporAoSol = txtTemHabitoDeSeExporAoSol.Text;
            if (rbSimFazAlgumTratamentoMedico.Checked)
            {
                modelCliente.FazAlgumTratamentoMedico = rbSimFazAlgumTratamentoMedico.Text;
            }
            else if (rbNaoFazAlgumTratamentoMedico.Checked)
            {
                modelCliente.FazAlgumTratamentoMedico = rbNaoFazAlgumTratamentoMedico.Text;
            }
            modelCliente.txtFazAlgumTratamentoMedico = txtFazAlgumTratamentoMedico.Text;
            if (rbSimUsaAlgumTipoDeMedicamento.Checked)
            {
                modelCliente.UsaAlgumTipoDeMedicamento = rbSimUsaAlgumTipoDeMedicamento.Text;
            }
            else if (rbNaoUsaAlgumTipoDeMedicamento.Checked)
            {
                modelCliente.UsaAlgumTipoDeMedicamento = rbNaoUsaAlgumTipoDeMedicamento.Text;
            }
            modelCliente.txtUsaAlgumTipoDeMedicamento = txtUsaAlgumTipoDeMedicamento.Text;
            if (rbSimEGestanteOuEstaAmamentando.Checked)
            {
                modelCliente.EGestanteOuEstaAmamentando = rbSimEGestanteOuEstaAmamentando.Text;
            }
            else if (rbNaoEGestanteOuEstaAmamentando.Checked)
            {
                modelCliente.EGestanteOuEstaAmamentando = rbNaoEGestanteOuEstaAmamentando.Text;
            }
            modelCliente.txtEGestanteOuEstaAmamentando = txtEGestanteOuEstaAmamentando.Text;
            if (rbSimCicloMenstrualRegular.Checked)
            {
                modelCliente.CicloMenstrualRegular = rbSimCicloMenstrualRegular.Text;
            }
            else if (rbNaoCicloMenstrualRegular.Checked)
            {
                modelCliente.CicloMenstrualRegular = rbNaoCicloMenstrualRegular.Text;
            }
            modelCliente.txtCicloMenstrualRegular = txtCicloMenstrualRegular.Text;
            if (rbSimPortadorMarcaPasso.Checked)
            {
                modelCliente.PortadorDeMarcaPasso = rbSimPortadorMarcaPasso.Text;
            }
            else if (rbNaoPortadorMarcaPasso.Checked)
            {
                modelCliente.PortadorDeMarcaPasso = rbNaoPortadorMarcaPasso.Text;
            }
            modelCliente.txtPortadorDeMarcaPasso = txtPortadorDeMarcaPasso.Text;
            if (rbSimTemAlgumProblemaCardiovascular.Checked)
            {
                modelCliente.TemAlgumProblemaCardiovascular = rbSimTemAlgumProblemaCardiovascular.Text;
            }
            else if (rbNaoTemAlgumProblemaCardiovascular.Checked)
            {
                modelCliente.TemAlgumProblemaCardiovascular = rbNaoTemAlgumProblemaCardiovascular.Text;
            }
            modelCliente.txtTemAlgumProblemaCardiovascular = txtTemAlgumProblemaCardiovascular.Text;
            if (rbSimPresencaDeProteseMetalica.Checked)
            {
                modelCliente.PresencaDeProteseMetalica = rbSimPresencaDeProteseMetalica.Text;
            }
            else if (rbNaoPresencaDeProteseMetalica.Checked)
            {
                modelCliente.PresencaDeProteseMetalica = rbNaoPresencaDeProteseMetalica.Text;
            }
            modelCliente.txtPresencaDeProteseMetalica = txtPresencaDeProteseMetalica.Text;
            if (rbSimPortadorDeEpolepsia.Checked)
            {
                modelCliente.PortadorDeEpilepsia = rbSimPortadorDeEpolepsia.Text;
            }
            else if (rbNaoPortadorDeEpolepsia.Checked)
            {
                modelCliente.PortadorDeEpilepsia = rbNaoPortadorDeEpolepsia.Text;
            }
            modelCliente.txtPortadorDeEpilepsia = txtPortadorDeEpolepsia.Text;
            if (rbSimTemDiabetesOuHipertensao.Checked)
            {
                modelCliente.TemDiabetesOuHipertesao = rbSimTemDiabetesOuHipertensao.Text;
            }
            else if (rbNaoTemDiabetesOuHipertensao.Checked)
            {
                modelCliente.TemDiabetesOuHipertesao = rbNaoTemDiabetesOuHipertensao.Text;
            }
            modelCliente.txtTemDiabetesOuHipertesao = txtTemDiabetesOuHipertensao.Text;
            if (rbSimIngereBastanteAgua.Checked)
            {
                modelCliente.IngereBastanteAgua = rbSimIngereBastanteAgua.Text;
            }
            else if (rbNaoIngereBastanteAgua.Checked)
            {
                modelCliente.IngereBastanteAgua = rbNaoIngereBastanteAgua.Text;
            }
            modelCliente.txtIngereBastanteAgua = txtIngereBastanteAgua.Text;
            if (rbSimCancer.Checked)
            {
                modelCliente.Cancer = rbSimCancer.Text;
            }
            else if (rbNaoCancer.Checked)
            {
                modelCliente.Cancer = rbNaoCancer.Text;
            }
            modelCliente.txtCancer = txtCancer.Text;
            if (rbSimTrombose.Checked)
            {
                modelCliente.Trombose = rbSimTrombose.Text;
            }
            else if (rbNaoTrombose.Checked)
            {
                modelCliente.Trombose = rbNaoTrombose.Text;
            }
            modelCliente.txtTrombose = txtTrombose.Text;
        }
        void CarregarHistoricoCliente()
        {
            try
            {
                if (rbEmAberto.Checked)
                {
                    dgvHistoricoCliente.DataSource = controllerCliente.CarregarHistoricoCliente(txtNome.Text, rbEmAberto.Text, dtpDe.Text, dtpAte.Text);
                }
                else if (rbFinalizado.Checked)
                {
                    dgvHistoricoCliente.DataSource = controllerCliente.CarregarHistoricoCliente(txtNome.Text, rbFinalizado.Text, dtpDe.Text, dtpAte.Text);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Insera um nome valido!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                MessageBox.Show("Insera um endereço valido!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEndereco.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtBairro.Text))
            {
                MessageBox.Show("Insera um bairro valido!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBairro.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCidade.Text))
            {
                MessageBox.Show("Insera um cidade valido!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCidade.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCep.Text))
            {
                MessageBox.Show("Insera um CEP valido!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCep.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTelefone.Text))
            {
                MessageBox.Show("Insera um telefone valido!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTelefone.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtProfissao.Text))
            {
                MessageBox.Show("Insera um profissão valido!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProfissao.Focus();
                return false;
            }
            return true;
        }
        public FrmCadastroCliente(ModelCliente modelCliente)
        {
            InitializeComponent();
            cbxSexo.SelectedIndex = 0;
            txtEstadoCivil.SelectedIndex = 0;
            void CarregarCampos()
            {
                Text = "Tec Clinic: " + modelCliente.acao + " Ficha de Anamnese";
                acao = modelCliente.acao;
                pnlInformacoesDoCliente.Enabled = false;
                pnlHabitosHistoricoClinicoDaCliente.Enabled = false;
                btnCancelar.Text = "Fechar";
                txtNome.ReadOnly = true;
                codigo = modelCliente.Codigo;
                txtNome.Text = modelCliente.Nome;
                txtEndereco.Text = modelCliente.Endereco;
                txtBairro.Text = modelCliente.Bairro;
                txtCidade.Text = modelCliente.Cidade;
                txtCep.Text = modelCliente.CEP;
                txtEmail.Text = modelCliente.Email;
                txtTelefone.Text = modelCliente.Telefone;
                txtDn.Text = modelCliente.Dn;
                txtIdade.Text = modelCliente.idade.ToString();
                cbxSexo.Text = modelCliente.Sexo;
                txtEstadoCivil.Text = modelCliente.EstadoCivil;
                txtFilhos.Text = modelCliente.Filhos;
                txtProfissao.Text = modelCliente.Profissao;
                rtbQueixaPrincipalObjetivoCliente.Text = modelCliente.QueixaPrincipalObjetivoCliente;
                rtbHistoriaMolestia.Text = modelCliente.HistoriaMolestia;
                if (modelCliente.TratamentosAnteriores == rbSimTratamentosAnteriores.Text)
                {
                    rbSimTratamentosAnteriores.Checked = true;
                }
                else if (modelCliente.TratamentosAnteriores == rbNaoTratamentosAnteriores.Text)
                {
                    rbNaoTratamentosAnteriores.Checked = true;
                }
                rtbTratamentoAnteriorQuais.Text = modelCliente.TratamentosAnterioresQuais;
                txtGrauSatisfacao.Text = modelCliente.GrauSatisfacao;
                txtData.Text = modelCliente.DataCadastro;
                if (modelCliente.AntecedentesAlergicos == rbSimAntecedentesAlergicos.Text)
                {
                    rbSimAntecedentesAlergicos.Checked = true;
                }
                else if (modelCliente.AntecedentesAlergicos == rbNaoAntecedentesAlergicos.Text)
                {
                    rbNaoAntecedentesAlergicos.Checked = true;
                }
                txtAntecedentesAlergicos.Text = modelCliente.txtAntecedentesAlergicos;
                txtDiagnosticoDePsoriaseOuHanseniase.Text = modelCliente.txtDiagnosticoDePsoriaseOuHanseniase;
                if (modelCliente.FuncionamentoIntestinalRegular == rbSimFuncionamentoIntestinalRegular.Text)
                {
                    rbSimFuncionamentoIntestinalRegular.Checked = true;
                }
                else if (modelCliente.FuncionamentoIntestinalRegular == rbNaoFuncionamentoIntestinalRegular.Text)
                {
                    rbNaoFuncionamentoIntestinalRegular.Checked = true;
                }
                txtFuncionamentoIntestinalRegular.Text = modelCliente.txtFuncionamentoIntestinalRegular;
                if (modelCliente.PraticaAtividadeFisica == rbSimPraticaAtividadeFisica.Text)
                {
                    rbSimPraticaAtividadeFisica.Checked = true;
                }
                else if (modelCliente.PraticaAtividadeFisica == rbNaoPraticaAtividadeFisica.Text)
                {
                    rbNaoPraticaAtividadeFisica.Checked = true;
                }
                txtPraticaAtividadeFisica.Text = modelCliente.txtPraticaAtividadeFisica;
                if (modelCliente.TemHabitoDeSeExporAoSol == rbSimTemHabitoDeSeExporAoSol.Text)
                {
                    rbSimTemHabitoDeSeExporAoSol.Checked = true;
                }
                else if (modelCliente.TemHabitoDeSeExporAoSol == rbNaoTemHabitoDeSeExporAoSol.Text)
                {
                    rbNaoTemHabitoDeSeExporAoSol.Checked = true;
                }
                txtTemHabitoDeSeExporAoSol.Text = modelCliente.txtTemHabitoDeSeExporAoSol;
                if (modelCliente.FazAlgumTratamentoMedico == rbSimFazAlgumTratamentoMedico.Text)
                {
                    rbSimFazAlgumTratamentoMedico.Checked = true;
                }
                else if (modelCliente.FazAlgumTratamentoMedico == rbNaoFazAlgumTratamentoMedico.Text)
                {
                    rbNaoFazAlgumTratamentoMedico.Checked = true;
                }
                txtFazAlgumTratamentoMedico.Text = modelCliente.txtFazAlgumTratamentoMedico;
                if (modelCliente.UsaAlgumTipoDeMedicamento == rbSimUsaAlgumTipoDeMedicamento.Text)
                {
                    rbSimUsaAlgumTipoDeMedicamento.Checked = true;
                }
                else if (modelCliente.UsaAlgumTipoDeMedicamento == rbNaoUsaAlgumTipoDeMedicamento.Text)
                {
                    rbNaoUsaAlgumTipoDeMedicamento.Checked = true;
                }
                txtUsaAlgumTipoDeMedicamento.Text = modelCliente.txtUsaAlgumTipoDeMedicamento;
                if (modelCliente.EGestanteOuEstaAmamentando == rbSimEGestanteOuEstaAmamentando.Text)
                {
                    rbSimEGestanteOuEstaAmamentando.Checked = true;
                }
                else if (modelCliente.EGestanteOuEstaAmamentando == rbNaoEGestanteOuEstaAmamentando.Text)
                {
                    rbNaoEGestanteOuEstaAmamentando.Checked = true;
                }
                txtEGestanteOuEstaAmamentando.Text = modelCliente.txtEGestanteOuEstaAmamentando;
                if (modelCliente.CicloMenstrualRegular == rbSimCicloMenstrualRegular.Text)
                {
                    rbSimCicloMenstrualRegular.Checked = true;
                }
                else if (modelCliente.CicloMenstrualRegular == rbNaoCicloMenstrualRegular.Text)
                {
                    rbNaoCicloMenstrualRegular.Checked = true;
                }
                txtCicloMenstrualRegular.Text = modelCliente.txtCicloMenstrualRegular;
                if (modelCliente.PortadorDeMarcaPasso == rbSimPortadorMarcaPasso.Text)
                {
                    rbSimPortadorMarcaPasso.Checked = true;
                }
                else if (modelCliente.PortadorDeMarcaPasso == rbNaoPortadorMarcaPasso.Text)
                {
                    rbNaoPortadorMarcaPasso.Checked = true;
                }
                txtPortadorDeMarcaPasso.Text = modelCliente.txtPortadorDeMarcaPasso;
                if (modelCliente.TemAlgumProblemaCardiovascular == rbSimTemAlgumProblemaCardiovascular.Text)
                {
                    rbSimTemAlgumProblemaCardiovascular.Checked = true;
                }
                else if (modelCliente.TemAlgumProblemaCardiovascular == rbNaoTemAlgumProblemaCardiovascular.Text)
                {
                    rbNaoTemAlgumProblemaCardiovascular.Checked = true;
                }
                txtTemAlgumProblemaCardiovascular.Text = modelCliente.txtTemAlgumProblemaCardiovascular;
                if (modelCliente.PresencaDeProteseMetalica == rbSimPresencaDeProteseMetalica.Text)
                {
                    rbSimPresencaDeProteseMetalica.Checked = true;
                }
                else if (modelCliente.PresencaDeProteseMetalica == rbNaoPresencaDeProteseMetalica.Text)
                {
                    rbNaoPresencaDeProteseMetalica.Checked = true;
                }
                txtPresencaDeProteseMetalica.Text = modelCliente.txtPresencaDeProteseMetalica;
                if (modelCliente.PortadorDeEpilepsia == rbSimPortadorDeEpolepsia.Text)
                {
                    rbSimPortadorDeEpolepsia.Checked = true;
                }
                else if (modelCliente.PortadorDeEpilepsia == rbNaoPortadorDeEpolepsia.Text)
                {
                    rbNaoPortadorDeEpolepsia.Checked = true;
                }
                txtPortadorDeEpolepsia.Text = modelCliente.txtPortadorDeEpilepsia;
                if (modelCliente.TemDiabetesOuHipertesao == rbSimTemDiabetesOuHipertensao.Text)
                {
                    rbSimTemDiabetesOuHipertensao.Checked = true;
                }
                else if (modelCliente.TemDiabetesOuHipertesao == rbNaoTemDiabetesOuHipertensao.Text)
                {
                    rbNaoTemDiabetesOuHipertensao.Checked = true;
                }
                txtTemDiabetesOuHipertensao.Text = modelCliente.txtTemDiabetesOuHipertesao;
                if (modelCliente.IngereBastanteAgua == rbSimIngereBastanteAgua.Text)
                {
                    rbSimIngereBastanteAgua.Checked = true;
                }
                else if (modelCliente.IngereBastanteAgua == rbNaoIngereBastanteAgua.Text)
                {
                    rbNaoIngereBastanteAgua.Checked = true;
                }
                txtIngereBastanteAgua.Text = modelCliente.txtIngereBastanteAgua;
                if (modelCliente.Cancer == rbSimCancer.Text)
                {
                    rbSimCancer.Checked = true;
                }
                else if (modelCliente.Cancer == rbNaoCancer.Text)
                {
                    rbNaoCancer.Checked = true;
                }
                txtCancer.Text = modelCliente.txtCancer;
                if (modelCliente.Trombose == rbSimTrombose.Text)
                {
                    rbSimTrombose.Checked = true;
                }
                else if (modelCliente.Trombose == rbNaoTrombose.Text)
                {
                    rbNaoTrombose.Checked = true;
                }
                txtTrombose.Text = modelCliente.txtTrombose;
            }
            if (modelCliente.acao == "Editar")
            {
                btnCadastrar.Text = "Editar";
                CarregarCampos();
            }
            else if (modelCliente.acao == "Consultar")
            {
                lblCampoObrigatorio.Visible = false;
                btnCadastrar.Text = "Imprimir";
                CarregarCampos();
            }
            else if (modelCliente.acao == "Cadastrar")
            {
                acao = modelCliente.acao;
                txtData.Value = DateTime.Now;
            }
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (acao == "Cadastrar" && btnCadastrar.Text == "Cadastrar" && ValidarCampos())
                {
                    modelCliente.Nome = txtNome.Text;
                    CamposCrud();
                    if (!controllerCliente.VerificarClienteCadastrado(modelCliente) && controllerCliente.Cadastrar(modelCliente))
                    {
                        MessageBox.Show("Cadastrado com sucesso!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        printFont = new Font("Arial", 9);
                        PrintDocument pd = new PrintDocument();
                        printDialog1.Document = pd;
                        var result = printDialog1.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            pd.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                            pd.Print();
                        }
                        this.Close();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nome já cadastrado!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (acao == "Editar" && btnCadastrar.Text == "Editar")
                {
                    pnlInformacoesDoCliente.Enabled = true;
                    pnlHabitosHistoricoClinicoDaCliente.Enabled = true;
                    btnCadastrar.Text = "Salvar";
                    btnCancelar.Text = "Cancelar";
                }
                else if (acao == "Editar" && btnCadastrar.Text == "Salvar" && ValidarCampos())
                {
                    modelCliente.Codigo = codigo;
                    CamposCrud();
                    if (controllerCliente.Editar(modelCliente))
                    {
                        MessageBox.Show("Editado com sucesso!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        printFont = new Font("Arial", 9);
                        PrintDocument pd = new PrintDocument();
                        printDialog1.Document = pd;
                        var result = printDialog1.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            pd.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                            pd.Print();
                        }
                        this.Close();
                    }
                }
                else if (acao == "Consultar" && btnCadastrar.Text == "Imprimir")
                {
                    CamposCrud();
                    try
                    {
                        printFont = new Font("Arial", 9);
                        PrintDocument pd = new PrintDocument();
                        printDialog1.Document = pd;
                        var result = printDialog1.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            pd.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                            pd.Print();
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarHistoricoCliente();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProcurarCliente_Click(object sender, EventArgs e)
        {
            FrmGerenciadorAgendamentos frmGerenciadorAgendamentos = new FrmGerenciadorAgendamentos(true);
            frmGerenciadorAgendamentos.ShowDialog();
            txtNome.Text = frmGerenciadorAgendamentos.RetornarNomeCliente;
            txtEndereco.Text = frmGerenciadorAgendamentos.RetornarEnderecoCliente;
            txtTelefone.Text = frmGerenciadorAgendamentos.RetornarTelefoneCliente;
        }
        Pen pen = new Pen(Color.Black);
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float y = 0;
            float count = 0;

            ev.Graphics.DrawString("FICHA DE ANAMNESE", printFont, Brushes.Black, 340, 10, new StringFormat());
            ev.Graphics.DrawLine(pen, ev.MarginBounds.Left, 30, ev.MarginBounds.Right, 30);
            ev.Graphics.DrawLine(pen, ev.MarginBounds.Left, 30, ev.MarginBounds.Left, ev.MarginBounds.Top + 911);
            ev.Graphics.DrawLine(pen, ev.MarginBounds.Right, 30, ev.MarginBounds.Right, ev.MarginBounds.Top + 911);
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Nome: " + modelCliente.Nome, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Endereço: " + modelCliente.Endereco, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Bairro: " + modelCliente.Bairro, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Cidade: " + modelCliente.Cidade, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            ev.Graphics.DrawString("CEP: " + modelCliente.CEP, printFont, Brushes.Black, ev.MarginBounds.Left + 450, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("E-mail: " + modelCliente.Email, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Telefone: " + modelCliente.Telefone, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            ev.Graphics.DrawString("Data de Nascimento: " + modelCliente.Dn, printFont, Brushes.Black, ev.MarginBounds.Left + 200, y, new StringFormat());
            ev.Graphics.DrawString("Idade: " + modelCliente.idade.ToString(), printFont, Brushes.Black, ev.MarginBounds.Left + 450, y, new StringFormat());
            ev.Graphics.DrawString("Sexo: " + modelCliente.Sexo, printFont, Brushes.Black, ev.MarginBounds.Left + 550, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Filhos: " + modelCliente.Filhos, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            ev.Graphics.DrawString("Estado Civil: " + modelCliente.EstadoCivil, printFont, Brushes.Black, ev.MarginBounds.Left +200, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Profissão: " + modelCliente.Profissao, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Queixa principal e objetivo do cliente: ", printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString(rtbQueixaPrincipalObjetivoCliente.Text, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("História da moléstia: ", printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString(rtbHistoriaMolestia.Text, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Tratamentos anteriores: " + modelCliente.TratamentosAnteriores, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Quais: " + modelCliente.TratamentosAnterioresQuais, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Grau de satisfação: " + modelCliente.GrauSatisfacao, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Antecedentes alérgicos: " + modelCliente.AntecedentesAlergicos, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Quais:" + modelCliente.txtAntecedentesAlergicos, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Diagnóstico de Psoriase ou Hanseníase: " + modelCliente.txtDiagnosticoDePsoriaseOuHanseniase, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Funcionamento Intestinal Regular: " + modelCliente.FuncionamentoIntestinalRegular, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString(modelCliente.txtFuncionamentoIntestinalRegular, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Pratica Atividade Física: " + modelCliente.PraticaAtividadeFisica, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString(modelCliente.txtPraticaAtividadeFisica, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Tem Hábito de se Expor ao Sol: " + modelCliente.TemHabitoDeSeExporAoSol, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString(modelCliente.txtTemHabitoDeSeExporAoSol, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Faz Algum Tratamento Médico: " + modelCliente.FazAlgumTratamentoMedico, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString(modelCliente.txtFazAlgumTratamentoMedico, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Usa Algum Tipo de Medicamento: " + modelCliente.UsaAlgumTipoDeMedicamento, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString(modelCliente.txtUsaAlgumTipoDeMedicamento, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("É Gestante ou Está Amamentando: " + modelCliente.EGestanteOuEstaAmamentando, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString(modelCliente.txtEGestanteOuEstaAmamentando, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Ciclo Menstrual Regular: " + modelCliente.CicloMenstrualRegular, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString(modelCliente.txtCicloMenstrualRegular, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Portador de Marca-Passo: " + modelCliente.PortadorDeMarcaPasso, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString(modelCliente.txtPortadorDeMarcaPasso, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Tem Algum Problema Cardiovascular: " + modelCliente.TemAlgumProblemaCardiovascular, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString(modelCliente.txtTemAlgumProblemaCardiovascular, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Presença de Prótese Metálica: " + modelCliente.PresencaDeProteseMetalica, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString(modelCliente.txtPresencaDeProteseMetalica, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Portador de Epolepsia: " + modelCliente.PortadorDeEpilepsia, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString(modelCliente.txtPortadorDeEpilepsia, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Tem Diabetes ou Hipertensão: " + modelCliente.TemDiabetesOuHipertesao, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString(modelCliente.txtTemDiabetesOuHipertesao, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Ingere Bastante Água: " + modelCliente.IngereBastanteAgua, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString(modelCliente.txtIngereBastanteAgua, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Câncer: " + modelCliente.Cancer, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString(modelCliente.txtCancer, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Trombose: " + modelCliente.Trombose, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString(modelCliente.txtTrombose, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawLine(pen, ev.MarginBounds.Left, y, ev.MarginBounds.Right, y);
            ev.Graphics.DrawLine(pen, ev.MarginBounds.Left + 50, ev.MarginBounds.Bottom + 5, ev.MarginBounds.Right - 50, ev.MarginBounds.Bottom + 5);
            ev.Graphics.DrawString(modelCliente.Nome, printFont, Brushes.Black, ev.MarginBounds.Left + 50, ev.MarginBounds.Bottom + 5, new StringFormat());
            ev.Graphics.DrawString("Assinatura", printFont, Brushes.Black, ev.MarginBounds.Left + 50, ev.MarginBounds.Bottom + 20, new StringFormat());
        }
    }
}
