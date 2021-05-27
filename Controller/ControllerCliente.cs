using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class ControllerCliente
    {
        ControllerConfiguracaoSQL controllerConfiguracaoSQL = new ControllerConfiguracaoSQL();
        public DataTable CarregarClientePorCodigo(string codigo)
        {
            try
            {
                string instrucao = string.Format("SELECT TOP (1000) * FROM tbCliente WHERE Codigo = '" + codigo + "'");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch
            {
                throw;
            }
            finally
            {
                controllerConfiguracaoSQL.Fechar();
            }
        }
        public DataTable CarregarClientePorNome(string nome)
        {
            try
            {
                string instrucao = string.Format("SELECT TOP (1000) * FROM tbCliente WHERE Nome LIKE '%" + nome + "%'");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch
            {
                throw;
            }
            finally
            {
                controllerConfiguracaoSQL.Fechar();
            }
        }
        public DataTable CarregarHistoricoCliente(string nome,string StatusAgendamento, string dataDe, string dataAte)
        {
            try
            {
                string instrucao = string.Format("SELECT TOP (1000) Codigo, DataAgendamento, HoraAgendamento, Servico, StatusAgendamento, ObsConsulta FROM tbAgendamento WHERE Nome = '" + nome + "' AND StatusAgendamento = '" + StatusAgendamento + "' AND DataAgendamento BETWEEN '" + dataDe + "' AND '" + dataAte + "'");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
                
            }
            catch
            {
                throw;
            }
            finally
            {
                controllerConfiguracaoSQL.Fechar();
            }
        }
        public bool VerificarClienteCadastrado(ModelCliente modelCliente)
        {
            try
            {
                string instrucao = string.Format("SELECT * FROM tbCliente WHERE Nome = @Nome");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Nome", modelCliente.Nome);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                throw;
            }
            finally
            {
                controllerConfiguracaoSQL.Fechar();
            }
        }
        public bool Cadastrar(ModelCliente modelCliente)
        {
            try
            {
                string instrucao = string.Format("INSERT INTO tbCliente (Nome, Endereco, Bairro, Cidade, Cep, Email, Telefone, Dn, Idade, Sexo, EstadoCivil, Filhos, Profissao, QueixaPrincipalObjetivoCliente, HistoriaMolestia, TratamentosAnteriores, TratamentosAnterioresQuais, GrauSatisfacao, DataCadastro, AntecedentesAlergicos, txtAntecedentesAlergicos, txtDiagnosticoDePsoriaseOuHanseniase, FuncionamentoIntestinalRegular, txtFuncionamentoIntestinalRegular, PraticaAtividadeFisica, txtPraticaAtividadeFisica, TemHabitoDeSeExporAoSol, txtTemHabitoDeSeExporAoSol, FazAlgumTratamentoMedico, txtFazAlgumTratamentoMedico, UsaAlgumTipoDeMedicamento, txtUsaAlgumTipoDeMedicamento, EGestanteOuEstaAmamentando, txtEGestanteOuEstaAmamentando, CicloMenstrualRegular, txtCicloMenstrualRegular, PortadorDeMarcaPasso, txtPortadorDeMarcaPasso, TemAlgumProblemaCardiovascular, txtTemAlgumProblemaCardiovascular, PresencaDeProteseMetalica, txtPresencaDeProteseMetalica, PortadorDeEpilepsia, txtPortadorDeEpilepsia, TemDiabetesOuHipertesao, txtTemDiabetesOuHipertesao, IngereBastanteAgua, txtIngereBastanteAgua, Cancer, txtCancer, Trombose, txtTrombose) VALUES (@Nome, @Endereco, @Bairro, @Cidade, @Cep, @Email, @Telefone, @Dn, @Idade, @Sexo, @EstadoCivil, @Filhos, @Profissao, @QueixaPrincipalObjetivoCliente, @HistoriaMolestia, @TratamentosAnteriores, @TratamentosAnterioresQuais, @GrauSatisfacao, @DataCadastro, @AntecedentesAlergicos, @txtAntecedentesAlergicos, @txtDiagnosticoDePsoriaseOuHanseniase, @FuncionamentoIntestinalRegular, @txtFuncionamentoIntestinalRegular, @PraticaAtividadeFisica, @txtPraticaAtividadeFisica, @TemHabitoDeSeExporAoSol, @txtTemHabitoDeSeExporAoSol, @FazAlgumTratamentoMedico, @txtFazAlgumTratamentoMedico, @UsaAlgumTipoDeMedicamento, @txtUsaAlgumTipoDeMedicamento, @EGestanteOuEstaAmamentando, @txtEGestanteOuEstaAmamentando, @CicloMenstrualRegular, @txtCicloMenstrualRegular, @PortadorDeMarcaPasso, @txtPortadorDeMarcaPasso, @TemAlgumProblemaCardiovascular, @txtTemAlgumProblemaCardiovascular, @PresencaDeProteseMetalica, @txtPresencaDeProteseMetalica, @PortadorDeEpilepsia, @txtPortadorDeEpilepsia, @TemDiabetesOuHipertesao, @txtTemDiabetesOuHipertesao, @IngereBastanteAgua, @txtIngereBastanteAgua, @Cancer, @txtCancer, @Trombose, @txtTrombose)");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Nome", modelCliente.Nome);
                command.Parameters.AddWithValue("@Endereco", modelCliente.Endereco);
                command.Parameters.AddWithValue("@Bairro", modelCliente.Bairro);
                command.Parameters.AddWithValue("@Cidade", modelCliente.Cidade);
                command.Parameters.AddWithValue("@Cep", modelCliente.CEP);
                command.Parameters.AddWithValue("@Email", modelCliente.Email);
                command.Parameters.AddWithValue("@Telefone", modelCliente.Telefone);
                command.Parameters.AddWithValue("@Dn", modelCliente.Dn);
                command.Parameters.AddWithValue("@Idade", modelCliente.idade);
                command.Parameters.AddWithValue("@Sexo", modelCliente.Sexo);
                command.Parameters.AddWithValue("@EstadoCivil", modelCliente.EstadoCivil);
                command.Parameters.AddWithValue("@Filhos", modelCliente.Filhos);
                command.Parameters.AddWithValue("@Profissao", modelCliente.Profissao);
                command.Parameters.AddWithValue("@QueixaPrincipalObjetivoCliente", modelCliente.QueixaPrincipalObjetivoCliente);
                command.Parameters.AddWithValue("@HistoriaMolestia", modelCliente.HistoriaMolestia);
                command.Parameters.AddWithValue("@TratamentosAnteriores", modelCliente.TratamentosAnteriores);
                command.Parameters.AddWithValue("@TratamentosAnterioresQuais", modelCliente.TratamentosAnterioresQuais);
                command.Parameters.AddWithValue("@GrauSatisfacao", modelCliente.GrauSatisfacao);
                command.Parameters.AddWithValue("@DataCadastro", modelCliente.DataCadastro);
                command.Parameters.AddWithValue("@AntecedentesAlergicos", modelCliente.AntecedentesAlergicos);
                command.Parameters.AddWithValue("@txtAntecedentesAlergicos", modelCliente.txtAntecedentesAlergicos);
                command.Parameters.AddWithValue("@txtDiagnosticoDePsoriaseOuHanseniase", modelCliente.txtDiagnosticoDePsoriaseOuHanseniase);
                command.Parameters.AddWithValue("@FuncionamentoIntestinalRegular", modelCliente.FuncionamentoIntestinalRegular);
                command.Parameters.AddWithValue("@txtFuncionamentoIntestinalRegular", modelCliente.txtFuncionamentoIntestinalRegular);
                command.Parameters.AddWithValue("@PraticaAtividadeFisica", modelCliente.PraticaAtividadeFisica);
                command.Parameters.AddWithValue("@txtPraticaAtividadeFisica", modelCliente.txtPraticaAtividadeFisica);
                command.Parameters.AddWithValue("@TemHabitoDeSeExporAoSol", modelCliente.TemHabitoDeSeExporAoSol);
                command.Parameters.AddWithValue("@txtTemHabitoDeSeExporAoSol", modelCliente.txtTemHabitoDeSeExporAoSol);
                command.Parameters.AddWithValue("@FazAlgumTratamentoMedico", modelCliente.FazAlgumTratamentoMedico);
                command.Parameters.AddWithValue("@txtFazAlgumTratamentoMedico", modelCliente.txtFazAlgumTratamentoMedico);
                command.Parameters.AddWithValue("@UsaAlgumTipoDeMedicamento", modelCliente.UsaAlgumTipoDeMedicamento);
                command.Parameters.AddWithValue("@txtUsaAlgumTipoDeMedicamento", modelCliente.txtUsaAlgumTipoDeMedicamento);
                command.Parameters.AddWithValue("@EGestanteOuEstaAmamentando", modelCliente.EGestanteOuEstaAmamentando);
                command.Parameters.AddWithValue("@txtEGestanteOuEstaAmamentando", modelCliente.txtEGestanteOuEstaAmamentando);
                command.Parameters.AddWithValue("@CicloMenstrualRegular", modelCliente.CicloMenstrualRegular);
                command.Parameters.AddWithValue("@txtCicloMenstrualRegular", modelCliente.txtCicloMenstrualRegular);
                command.Parameters.AddWithValue("@PortadorDeMarcaPasso", modelCliente.PortadorDeMarcaPasso);
                command.Parameters.AddWithValue("@txtPortadorDeMarcaPasso", modelCliente.txtPortadorDeMarcaPasso);
                command.Parameters.AddWithValue("@TemAlgumProblemaCardiovascular", modelCliente.TemAlgumProblemaCardiovascular);
                command.Parameters.AddWithValue("@txtTemAlgumProblemaCardiovascular", modelCliente.txtTemAlgumProblemaCardiovascular);
                command.Parameters.AddWithValue("@PresencaDeProteseMetalica", modelCliente.PresencaDeProteseMetalica);
                command.Parameters.AddWithValue("@txtPresencaDeProteseMetalica", modelCliente.txtPresencaDeProteseMetalica);
                command.Parameters.AddWithValue("@PortadorDeEpilepsia", modelCliente.PortadorDeEpilepsia);
                command.Parameters.AddWithValue("@txtPortadorDeEpilepsia", modelCliente.txtPortadorDeEpilepsia);
                command.Parameters.AddWithValue("@TemDiabetesOuHipertesao", modelCliente.TemDiabetesOuHipertesao);
                command.Parameters.AddWithValue("@txtTemDiabetesOuHipertesao", modelCliente.txtTemDiabetesOuHipertesao);
                command.Parameters.AddWithValue("@IngereBastanteAgua", modelCliente.IngereBastanteAgua);
                command.Parameters.AddWithValue("@txtIngereBastanteAgua", modelCliente.txtIngereBastanteAgua);
                command.Parameters.AddWithValue("@Cancer", modelCliente.Cancer);
                command.Parameters.AddWithValue("@txtCancer", modelCliente.txtCancer);
                command.Parameters.AddWithValue("@Trombose", modelCliente.Trombose);
                command.Parameters.AddWithValue("@txtTrombose", modelCliente.txtTrombose);
                return Convert.ToBoolean(command.ExecuteNonQuery());
            }
            catch
            {
                throw;
            }
            finally
            {
                controllerConfiguracaoSQL.Fechar();
            }
        }
        public bool Editar(ModelCliente modelCliente)
        {
            try
            {
                string instrucao = string.Format("UPDATE tbCliente SET Endereco = @Endereco, Bairro = @Bairro, Cidade = @Cidade, Cep = @Cep, Email = @Email, Telefone = @Telefone, Dn = @Dn, Idade = @Idade, Sexo = @Sexo, EstadoCivil = @EstadoCivil, Filhos = @Filhos, Profissao = @Profissao, QueixaPrincipalObjetivoCliente = @QueixaPrincipalObjetivoCliente, HistoriaMolestia = @HistoriaMolestia, TratamentosAnteriores = @TratamentosAnteriores, TratamentosAnterioresQuais = @TratamentosAnterioresQuais, GrauSatisfacao = @GrauSatisfacao, AntecedentesAlergicos = @AntecedentesAlergicos, txtAntecedentesAlergicos = @txtAntecedentesAlergicos, txtDiagnosticoDePsoriaseOuHanseniase = @txtDiagnosticoDePsoriaseOuHanseniase, FuncionamentoIntestinalRegular = @FuncionamentoIntestinalRegular, txtFuncionamentoIntestinalRegular = @txtFuncionamentoIntestinalRegular, PraticaAtividadeFisica = @PraticaAtividadeFisica, txtPraticaAtividadeFisica = @txtPraticaAtividadeFisica, TemHabitoDeSeExporAoSol = @TemHabitoDeSeExporAoSol, txtTemHabitoDeSeExporAoSol = @txtTemHabitoDeSeExporAoSol, FazAlgumTratamentoMedico = @FazAlgumTratamentoMedico, txtFazAlgumTratamentoMedico = @txtFazAlgumTratamentoMedico, UsaAlgumTipoDeMedicamento = @UsaAlgumTipoDeMedicamento, txtUsaAlgumTipoDeMedicamento = @txtUsaAlgumTipoDeMedicamento, EGestanteOuEstaAmamentando = @EGestanteOuEstaAmamentando, txtEGestanteOuEstaAmamentando = @txtEGestanteOuEstaAmamentando, CicloMenstrualRegular = @CicloMenstrualRegular, txtCicloMenstrualRegular = @txtCicloMenstrualRegular, PortadorDeMarcaPasso = @PortadorDeMarcaPasso, txtPortadorDeMarcaPasso = @txtPortadorDeMarcaPasso, TemAlgumProblemaCardiovascular = @TemAlgumProblemaCardiovascular, txtTemAlgumProblemaCardiovascular = @txtTemAlgumProblemaCardiovascular, PresencaDeProteseMetalica = @PresencaDeProteseMetalica, txtPresencaDeProteseMetalica = @txtPresencaDeProteseMetalica, PortadorDeEpilepsia = @PortadorDeEpilepsia, txtPortadorDeEpilepsia = @txtPortadorDeEpilepsia, TemDiabetesOuHipertesao = @TemDiabetesOuHipertesao, txtTemDiabetesOuHipertesao = @txtTemDiabetesOuHipertesao, IngereBastanteAgua = @IngereBastanteAgua, txtIngereBastanteAgua = @txtIngereBastanteAgua, Cancer = @Cancer, txtCancer = @txtCancer, Trombose = @Trombose, txtTrombose = @txtTrombose WHERE Codigo = @Codigo");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Codigo", modelCliente.Codigo);
                command.Parameters.AddWithValue("@Endereco", modelCliente.Endereco);
                command.Parameters.AddWithValue("@Bairro", modelCliente.Bairro);
                command.Parameters.AddWithValue("@Cidade", modelCliente.Cidade);
                command.Parameters.AddWithValue("@Cep", modelCliente.CEP);
                command.Parameters.AddWithValue("@Email", modelCliente.Email);
                command.Parameters.AddWithValue("@Telefone", modelCliente.Telefone);
                command.Parameters.AddWithValue("@Dn", modelCliente.Dn);
                command.Parameters.AddWithValue("@Idade", modelCliente.idade);
                command.Parameters.AddWithValue("@Sexo", modelCliente.Sexo);
                command.Parameters.AddWithValue("@EstadoCivil", modelCliente.EstadoCivil);
                command.Parameters.AddWithValue("@Filhos", modelCliente.Filhos);
                command.Parameters.AddWithValue("@Profissao", modelCliente.Profissao);
                command.Parameters.AddWithValue("@QueixaPrincipalObjetivoCliente", modelCliente.QueixaPrincipalObjetivoCliente);
                command.Parameters.AddWithValue("@HistoriaMolestia", modelCliente.HistoriaMolestia);
                command.Parameters.AddWithValue("@TratamentosAnteriores", modelCliente.TratamentosAnteriores);
                command.Parameters.AddWithValue("@TratamentosAnterioresQuais", modelCliente.TratamentosAnterioresQuais);
                command.Parameters.AddWithValue("@GrauSatisfacao", modelCliente.GrauSatisfacao);
                command.Parameters.AddWithValue("@AntecedentesAlergicos", modelCliente.AntecedentesAlergicos);
                command.Parameters.AddWithValue("@txtAntecedentesAlergicos", modelCliente.txtAntecedentesAlergicos);
                command.Parameters.AddWithValue("@txtDiagnosticoDePsoriaseOuHanseniase", modelCliente.txtDiagnosticoDePsoriaseOuHanseniase);
                command.Parameters.AddWithValue("@FuncionamentoIntestinalRegular", modelCliente.FuncionamentoIntestinalRegular);
                command.Parameters.AddWithValue("@txtFuncionamentoIntestinalRegular", modelCliente.txtFuncionamentoIntestinalRegular);
                command.Parameters.AddWithValue("@PraticaAtividadeFisica", modelCliente.PraticaAtividadeFisica);
                command.Parameters.AddWithValue("@txtPraticaAtividadeFisica", modelCliente.txtPraticaAtividadeFisica);
                command.Parameters.AddWithValue("@TemHabitoDeSeExporAoSol", modelCliente.TemHabitoDeSeExporAoSol);
                command.Parameters.AddWithValue("@txtTemHabitoDeSeExporAoSol", modelCliente.txtTemHabitoDeSeExporAoSol);
                command.Parameters.AddWithValue("@FazAlgumTratamentoMedico", modelCliente.FazAlgumTratamentoMedico);
                command.Parameters.AddWithValue("@txtFazAlgumTratamentoMedico", modelCliente.txtFazAlgumTratamentoMedico);
                command.Parameters.AddWithValue("@UsaAlgumTipoDeMedicamento", modelCliente.UsaAlgumTipoDeMedicamento);
                command.Parameters.AddWithValue("@txtUsaAlgumTipoDeMedicamento", modelCliente.txtUsaAlgumTipoDeMedicamento);
                command.Parameters.AddWithValue("@EGestanteOuEstaAmamentando", modelCliente.EGestanteOuEstaAmamentando);
                command.Parameters.AddWithValue("@txtEGestanteOuEstaAmamentando", modelCliente.txtEGestanteOuEstaAmamentando);
                command.Parameters.AddWithValue("@CicloMenstrualRegular", modelCliente.CicloMenstrualRegular);
                command.Parameters.AddWithValue("@txtCicloMenstrualRegular", modelCliente.txtCicloMenstrualRegular);
                command.Parameters.AddWithValue("@PortadorDeMarcaPasso", modelCliente.PortadorDeMarcaPasso);
                command.Parameters.AddWithValue("@txtPortadorDeMarcaPasso", modelCliente.txtPortadorDeMarcaPasso);
                command.Parameters.AddWithValue("@TemAlgumProblemaCardiovascular", modelCliente.TemAlgumProblemaCardiovascular);
                command.Parameters.AddWithValue("@txtTemAlgumProblemaCardiovascular", modelCliente.txtTemAlgumProblemaCardiovascular);
                command.Parameters.AddWithValue("@PresencaDeProteseMetalica", modelCliente.PresencaDeProteseMetalica);
                command.Parameters.AddWithValue("@txtPresencaDeProteseMetalica", modelCliente.txtPresencaDeProteseMetalica);
                command.Parameters.AddWithValue("@PortadorDeEpilepsia", modelCliente.PortadorDeEpilepsia);
                command.Parameters.AddWithValue("@txtPortadorDeEpilepsia", modelCliente.txtPortadorDeEpilepsia);
                command.Parameters.AddWithValue("@TemDiabetesOuHipertesao", modelCliente.TemDiabetesOuHipertesao);
                command.Parameters.AddWithValue("@txtTemDiabetesOuHipertesao", modelCliente.txtTemDiabetesOuHipertesao);
                command.Parameters.AddWithValue("@IngereBastanteAgua", modelCliente.IngereBastanteAgua);
                command.Parameters.AddWithValue("@txtIngereBastanteAgua", modelCliente.txtIngereBastanteAgua);
                command.Parameters.AddWithValue("@Cancer", modelCliente.Cancer);
                command.Parameters.AddWithValue("@txtCancer", modelCliente.txtCancer);
                command.Parameters.AddWithValue("@Trombose", modelCliente.Trombose);
                command.Parameters.AddWithValue("@txtTrombose", modelCliente.txtTrombose);
                return Convert.ToBoolean(command.ExecuteNonQuery());
            }
            catch
            {
                throw;
            }
            finally
            {
                controllerConfiguracaoSQL.Fechar();
            }
        }
        public bool Deletar(ModelCliente modelCliente)
        {
            try
            {
                string instrucao = string.Format("DELETE FROM tbCliente WHERE Codigo = @Codigo");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Codigo", modelCliente.Codigo);
                return Convert.ToBoolean(command.ExecuteNonQuery());
            }
            catch
            {
                throw;
            }
            finally
            {
                controllerConfiguracaoSQL.Fechar();
            }
        }
        public DataTable CarregarAniversariantes(string Dn)
        {
            try
            {
                string instrucao = string.Format("SELECT TOP (1000) Nome, Endereco, Telefone, Dn, Idade FROM tbCliente WHERE Dn LIKE '%" + Dn + "%'");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch
            {
                throw;
            }
            finally
            {
                controllerConfiguracaoSQL.Fechar();
            }
        }
    }
}
