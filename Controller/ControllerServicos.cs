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
    public class ControllerServicos
    {
        ControllerConfiguracaoSQL controllerConfiguracaoSQL = new ControllerConfiguracaoSQL();
        public DataTable CarregarPorCodigo(string codigo, string clinico)
        {
            try
            {
                string instrucao = string.Format("SELECT TOP (1000) * FROM tbServicos WHERE Codigo = '" + codigo + "' AND Clinico = '" + clinico + "'");
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
                string instrucao = string.Format("SELECT TOP (1000) * FROM tbServicos WHERE Nome LIKE '%" + nome + "%' AND Clinico = '" + clinico + "'");
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
        public DataTable CarregarPorTipo(string tipo, string clinico)
        {
            try
            {
                string instrucao = string.Format("SELECT TOP (1000) * FROM tbServicos WHERE Tipo LIKE '%" + tipo + "%' AND Clinico = '" + clinico + "'");
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
        public DataTable CarregarTodosPorCodigo(string codigo)
        {
            try
            {
                string instrucao = string.Format("SELECT TOP (1000) * FROM tbServicos WHERE Codigo = '" + codigo + "'");
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
        public DataTable CarregarTodosPorNome(string nome)
        {
            try
            {
                string instrucao = string.Format("SELECT TOP (1000) * FROM tbServicos WHERE Nome LIKE '%" + nome + "%'");
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
        public DataTable CarregarTodosPorTipo(string tipo)
        {
            try
            {
                string instrucao = string.Format("SELECT TOP (1000) * FROM tbServicos WHERE Tipo LIKE '%" + tipo + "%'");
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
        public bool VerificarServicoCadastrado(ModelServicos modelServicos)
        {
            try
            {
                string instrucao = string.Format("SELECT * FROM tbServicos WHERE Nome = @Nome");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Nome", modelServicos.Nome);
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
        public bool Cadastrar(ModelServicos modelServicos)
        {
            try
            {
                string instrucao = string.Format("INSERT INTO tbServicos (Nome, Tipo, Valor, Descricao, Clinico) VALUES (@Nome, @Tipo, @Valor, @Descricao, @Clinico)");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Nome", modelServicos.Nome);
                command.Parameters.AddWithValue("@Tipo", modelServicos.Tipo);
                command.Parameters.AddWithValue("@Valor", modelServicos.Valor);
                command.Parameters.AddWithValue("@Descricao", modelServicos.Descricao);
                command.Parameters.AddWithValue("@Clinico", modelServicos.Clinico);
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
        public bool Editar(ModelServicos modelServicos)
        {
            try
            {
                string instrucao = string.Format("UPDATE tbServicos SET Nome = @Nome, Tipo = @Tipo, Valor = @Valor, Descricao = @Descricao, Clinico = @Clinico WHERE Codigo = @Codigo");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Codigo", modelServicos.Codigo);
                command.Parameters.AddWithValue("@Nome", modelServicos.Nome);
                command.Parameters.AddWithValue("@Tipo", modelServicos.Tipo);
                command.Parameters.AddWithValue("@Valor", modelServicos.Valor);
                command.Parameters.AddWithValue("@Descricao", modelServicos.Descricao);
                command.Parameters.AddWithValue("@Clinico", modelServicos.Clinico);
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
        public bool Deletar(ModelServicos modelServicos)
        {
            try
            {
                string instrucao = string.Format("DELETE FROM tbServicos WHERE Codigo = @Codigo");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Codigo", modelServicos.Codigo);
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
