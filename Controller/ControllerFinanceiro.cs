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
    public class ControllerFinanceiro
    {
        ControllerConfiguracaoSQL controllerConfiguracaoSQL = new ControllerConfiguracaoSQL();
        public DataTable CarregarPorCodigo(string codigo, string status, string dataDe, string dataAte)
        {
			try
			{
				string instrucao = string.Format("SELECT TOP (1000) * FROM tbAgendamento WHERE Codigo = '" + codigo + "' AND StatusPagamento = '" + status + "' AND DataRecebimento BETWEEN '" + dataDe + "' AND '" + dataAte + "'");
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
		public DataTable CarregarPorNome(string nome, string status, string dataDe, string dataAte)
		{
			try
			{
				string instrucao = string.Format("SELECT TOP (1000) * FROM tbAgendamento WHERE Nome LIKE '%" + nome + "%' AND StatusPagamento = '" + status + "' AND DataRecebimento BETWEEN '" + dataDe + "' AND '" + dataAte + "'");
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
