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
    public partial class FrmCadastroCliente : Form
    {
        ModelCliente modelCliente = new ModelCliente();
        ControllerCliente controllerCliente = new ControllerCliente();
        int codigo;
        string acao;
        void CamposCrud()
        {
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
        
        public FrmCadastroCliente(ModelCliente modelCliente)
        {
            InitializeComponent();
            void CarregarCampos()
            {
                acao = modelCliente.acao;
                pnlInformacoesDoCliente.Enabled = false;
                pnlHabitosHistoricoClinicoDaCliente.Enabled = false;
                btnCancelar.Text = "Fechar";
                txtNome.ReadOnly = true;
                txtData.ReadOnly = true;
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
                btnCadastrar.Visible = false;
                CarregarCampos();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (acao == "Cadastrar")
            {
                modelCliente.Nome = txtNome.Text;
                CamposCrud();
                controllerCliente.Cadastrar(modelCliente);
            }
            else if (acao == "Editar" && btnCadastrar.Text == "Editar")
            {
                pnlInformacoesDoCliente.Enabled = true;
                pnlHabitosHistoricoClinicoDaCliente.Enabled = true;
                btnCadastrar.Text = "Salvar";
                btnCancelar.Text = "Cancelar";
            }
            else if (acao == "Editar" && btnCadastrar.Text == "Salvar")
            {
                modelCliente.Codigo = codigo;
                CamposCrud();
                controllerCliente.Editar(modelCliente);
            }
        }
    }
}
