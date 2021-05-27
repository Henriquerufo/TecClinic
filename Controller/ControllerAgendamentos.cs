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
    public class ControllerAgendamentos
    {
		ControllerConfiguracaoSQL controllerConfiguracaoSQL = new ControllerConfiguracaoSQL();
		public DataTable CarregarPorCodigo(string codigo, string statusAgendamento, string statusPagamento, string dataDe, string dataAte)
		{
			try
			{
				string instrucao = string.Format("SELECT TOP (1000) Codigo, Nome, Endereco, Telefone, Dn, CadastradoPor, DataAgendamento, HoraAgendamento, StatusAgendamento, Servico, Clinico, Valor, StatusPagamento FROM tbAgendamento WHERE Codigo = '" + codigo + "' AND StatusAgendamento = '" + statusAgendamento + "' AND StatusPagamento = '" + statusPagamento + "' AND DataAgendamento BETWEEN '" + dataDe + "' AND '" + dataAte + "'");
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
		public DataTable CarregarPorNome(string nome, string statusAgendamento, string statusPagamento, string dataDe, string dataAte)
		{
			try
			{
				string instrucao = string.Format("SELECT TOP (1000) Codigo, Nome, Endereco, Telefone, Dn, CadastradoPor, DataAgendamento, HoraAgendamento, StatusAgendamento, Servico, Clinico, Valor, StatusPagamento FROM tbAgendamento WHERE Nome LIKE '%" + nome + "%' AND StatusAgendamento = '" + statusAgendamento + "' AND StatusPagamento = '" + statusPagamento + "' AND DataAgendamento BETWEEN '" + dataDe + "' AND '" + dataAte + "'");
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
		public List<string> CarregarHorariosCadastrados(string clinico)
		{
			try
			{
				string instrucao = string.Format("SELECT Hora FROM tbHorario WHERE Clinico = '" + clinico + "'");
				SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
				SqlDataReader sqlDataReader = command.ExecuteReader();
				List<string> HorariosCadastrados = new List<string>();
				if (sqlDataReader.HasRows)
				{
					while (sqlDataReader.Read())
					{
						HorariosCadastrados.Add(sqlDataReader["Hora"].ToString());
					}
				}
				return HorariosCadastrados;
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
		public bool CarregarHorariosOcupados(string data, string hora, string clinico)
		{
			try
			{
				string instrucao = string.Format("SELECT * FROM tbAgendamento WHERE DataAgendamento = '" + data + "' AND HoraAgendamento LIKE '%" + hora + "%' AND Clinico = '" + clinico + "'");
				SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
				SqlDataReader sqlDataReader = command.ExecuteReader();
				if (sqlDataReader.HasRows)
				{
					return false;
				}
				return true;
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
		public bool VerificarClienteCadastrado(ModelAgendamentos modelAgendamentos)
		{
			try
			{
				string instrucao = string.Format("SELECT Nome FROM tbCliente WHERE Nome = @Nome");
				SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
				command.Parameters.AddWithValue("@Nome", modelAgendamentos.Nome);
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
		public bool ReceberValorAgendamento(ModelAgendamentos modelAgendamentos)
		{
			try
			{
				string instrucao = string.Format("UPDATE tbAgendamento SET StatusPagamento = @StatusPagamento, RecebidoPor = @RecebidoPor, DataRecebimento = @DataRecebimento, OpcaoPagamento = @OpcaoPagamento, Dinheiro = @Dinheiro, Cartao = @Cartao, Ticket = @Ticket WHERE Codigo = @Codigo");
				SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
				command.Parameters.AddWithValue("@Codigo", modelAgendamentos.Codigo);
				command.Parameters.AddWithValue("@StatusPagamento", modelAgendamentos.StatusPagamento);
				command.Parameters.AddWithValue("@RecebidoPor", modelAgendamentos.RecebidoPor);
				command.Parameters.AddWithValue("@DataRecebimento", modelAgendamentos.DataRecebimento);
				command.Parameters.AddWithValue("@OpcaoPagamento", modelAgendamentos.OpcaoPagamento);
				command.Parameters.AddWithValue("@Dinheiro", modelAgendamentos.Dinheiro);
				command.Parameters.AddWithValue("@Cartao", modelAgendamentos.Cartao);
				command.Parameters.AddWithValue("@Ticket", modelAgendamentos.Ticket);
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
		public bool FinalizarAgendamento(ModelAgendamentos modelAgendamentos)
		{
			try
			{
				string instrucao = string.Format("UPDATE tbAgendamento SET StatusAgendamento = @StatusAgendamento, ObsConsulta = @ObsConsulta WHERE Codigo = @Codigo");
				SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
				command.Parameters.AddWithValue("@Codigo", modelAgendamentos.Codigo);
				command.Parameters.AddWithValue("@StatusAgendamento", modelAgendamentos.StatusAgendamento);
				command.Parameters.AddWithValue("@ObsConsulta", modelAgendamentos.ObsConsulta);
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
        public bool Cadastrar(ModelAgendamentos modelAgendamentos)
        {
			try
			{
				string instrucao = string.Format("INSERT INTO tbAgendamento (Nome, Endereco, Telefone, Dn, CadastradoPor, DataAgendamento, HoraAgendamento, StatusAgendamento, StatusPagamento, Servico, Clinico, Valor, Dinheiro, Cartao, Ticket) VALUES (@Nome, @Endereco, @Telefone, @Dn, @CadastradoPor, @DataAgendamento, @HoraAgendamento, @StatusAgendamento, @StatusPagamento, @Servico, @Clinico, @Valor, @Dinheiro, @Cartao, @Ticket)");
				SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
				command.Parameters.AddWithValue("Nome", modelAgendamentos.Nome);
				command.Parameters.AddWithValue("Endereco", modelAgendamentos.Endereco);
				command.Parameters.AddWithValue("Telefone", modelAgendamentos.Telefone);
				command.Parameters.AddWithValue("Dn", modelAgendamentos.Dn);
				command.Parameters.AddWithValue("CadastradoPor", modelAgendamentos.CadastradoPor);
				command.Parameters.AddWithValue("DataAgendamento", modelAgendamentos.DataAgendamento);
				command.Parameters.AddWithValue("HoraAgendamento", modelAgendamentos.HoraAgendamento);
				command.Parameters.AddWithValue("StatusAgendamento", modelAgendamentos.StatusAgendamento);
				command.Parameters.AddWithValue("StatusPagamento", modelAgendamentos.StatusPagamento);
				command.Parameters.AddWithValue("@Servico", modelAgendamentos.Servico);
				command.Parameters.AddWithValue("@Clinico", modelAgendamentos.Clinico);
				command.Parameters.AddWithValue("@Valor", modelAgendamentos.Valor);
				command.Parameters.AddWithValue("@Dinheiro", modelAgendamentos.Dinheiro);
				command.Parameters.AddWithValue("@Cartao", modelAgendamentos.Cartao);
				command.Parameters.AddWithValue("@Ticket", modelAgendamentos.Ticket);
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
		public bool Editar(ModelAgendamentos modelAgendamentos)
		{
			try
			{
				string instrucao = string.Format("UPDATE tbAgendamento SET DataAgendamento = @DataAgendamento, HoraAgendamento = @HoraAgendamento, Servico = @Servico, Clinico = @Clinico, Valor = @Valor WHERE Codigo = @Codigo");
				SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
				command.Parameters.AddWithValue("Codigo", modelAgendamentos.Codigo);
				command.Parameters.AddWithValue("DataAgendamento", modelAgendamentos.DataAgendamento);
				command.Parameters.AddWithValue("HoraAgendamento", modelAgendamentos.HoraAgendamento);
				command.Parameters.AddWithValue("@Servico", modelAgendamentos.Servico);
				command.Parameters.AddWithValue("@Clinico", modelAgendamentos.Clinico);
				command.Parameters.AddWithValue("@Valor", modelAgendamentos.Valor);
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
		public bool Deletar(ModelAgendamentos modelAgendamentos)
		{
			try
			{
				string instrucao = string.Format("DELETE FROM tbAgendamento WHERE Codigo = @Codigo");
				SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
				command.Parameters.AddWithValue("Codigo", modelAgendamentos.Codigo);
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
    }
}
