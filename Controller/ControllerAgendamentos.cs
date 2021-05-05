using System;
using System.Collections.Generic;
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
        public bool Cadastrar(ModelAgendamentos modelAgendamentos)
        {
			try
			{
				string instrucao = string.Format("INSERT INTO tbAgendamento (Nome, Endereco, Telefone, Dn, CadastradoPor, DataAgendamento, HoraAgendamento, Status) VALUES (@Nome, @Endereco, @Telefone, @Dn, @CadastradoPor, @DataAgendamento, @HoraAgendamento, @Status)");
				SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
				command.Parameters.AddWithValue("Nome", modelAgendamentos.Nome);
				command.Parameters.AddWithValue("Endereco", modelAgendamentos.Endereco);
				command.Parameters.AddWithValue("Telefone", modelAgendamentos.Telefone);
				command.Parameters.AddWithValue("Dn", modelAgendamentos.Dn);
				command.Parameters.AddWithValue("CadastradoPor", modelAgendamentos.CadastradoPor);
				command.Parameters.AddWithValue("DataAgendamento", modelAgendamentos.DataAgendamento);
				command.Parameters.AddWithValue("HoraAgendamento", modelAgendamentos.HoraAgendamento);
				command.Parameters.AddWithValue("Status", modelAgendamentos.Status);
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
