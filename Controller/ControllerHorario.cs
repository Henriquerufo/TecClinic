using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ControllerHorario
    {
		ControllerConfiguracaoSQL controllerConfiguracaoSQL = new ControllerConfiguracaoSQL();
        public DataTable CarregarPorCodigo(string codigo, string clinico)
        {
			try
			{
				string instrucao = string.Format("SELECT TOP (1000) * FROM tbHorario WHERE Codigo = '" + codigo + "' AND Clinico = '" + clinico + "'");
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
		public DataTable CarregarPorNome(string nome, string clinico)
		{
			try
			{
				string instrucao = string.Format("SELECT TOP (1000) * FROM tbHorario WHERE Clinico LIKE '%" + nome + "%' AND Clinico = '" + clinico + "'");
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
		public bool VerificarHorarioCadastrado(ModelHorario modelHorario)
		{
			try
			{
				string instrucao = string.Format("SELECT * FROM tbHorario WHERE Hora = @Hora AND Clinico = @Clinico");
				SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
				command.Parameters.AddWithValue("@Hora", modelHorario.Hora);
				command.Parameters.AddWithValue("@Clinico", modelHorario.Clinico);
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
		public bool Cadastrar(ModelHorario modelHorario)
		{
			try
			{
				string instrucao = string.Format("INSERT INTO tbHorario (Hora, Clinico) VALUES (@Hora, @Clinico)");
				SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
				command.Parameters.AddWithValue("Hora", modelHorario.Hora);
				command.Parameters.AddWithValue("Clinico", modelHorario.Clinico);
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
		public bool Editar(ModelHorario modelHorario)
		{
			try
			{
				string instrucao = string.Format("UPDATE tbHorario SET Hora = @Hora, Clinico = @Clinico WHERE Codigo = @Codigo");
				SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
				command.Parameters.AddWithValue("Codigo", modelHorario.Codigo);
				command.Parameters.AddWithValue("@Hora", modelHorario.Hora);
				command.Parameters.AddWithValue("Clinico", modelHorario.Clinico);
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
