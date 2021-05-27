using Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Controller
{
    public class ControllerLogin
    {
        ControllerConfiguracaoSQL controllerConfiguracaoSQL = new ControllerConfiguracaoSQL();
        public int VerificarLoginsContratados()
        {
            ControllerConfiguracaoSQLCentral controllerConfiguracaoSQLCentral = new ControllerConfiguracaoSQLCentral();
            try
            {
                string instrucao = string.Format(@"select loginsContratados from tbCadastro Where idTecSistemas = '" + Properties.SettingsSQLCentral.Default.IDTecSistemas + "'");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQLCentral.Conectar());
                SqlDataReader sqlDataReader = command.ExecuteReader();
                sqlDataReader.Read();
                int total = (int)sqlDataReader["loginsContratados"];
                return total;
            }
            catch
            {
                throw;
            }
            finally
            {
                controllerConfiguracaoSQLCentral.Fechar();
            }
        }
        public DataTable CarregarTodos(string Procurar)
        {
            try
            {
                string instrucao = string.Format("SELECT TOP (1000) * FROM tbLogin WHERE ID LIKE '%" + Procurar + "%'");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
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
        public DataTable Carregar(string nivel, string ID)
        {
            try
            {
                string instrucao = string.Format("SELECT TOP (1000) * FROM tbLogin WHERE Nivel = '" + nivel + "' and ID LIKE '%" + ID + "%'");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
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
        public int VerificarLoginsOnline()
        {
            try
            {
                string instrucao = string.Format(@"SELECT COUNT(Codigo) FROM tbLogin WHERE Status = 'Conectado'");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataReader sqlDataReader = command.ExecuteReader();
                sqlDataReader.Read();
                return Convert.ToInt32(sqlDataReader[""].ToString());
            }
            catch (Exception)
            {

                throw;
            }
        }
        public ModelLogin VerificarLogin(ModelLogin modelLogin)
        {
            try
            {
                string instrucao = string.Format(@"SELECT Nivel, Status FROM tbLogin WHERE ID = @ID AND Senha = @Senha");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@ID", modelLogin.ID);
                command.Parameters.AddWithValue("Senha", modelLogin.Senha);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Read();
                    modelLogin.Nivel = sqlDataReader["Nivel"].ToString();
                    modelLogin.Status = sqlDataReader["Status"].ToString();
                    return modelLogin;
                }
                return null;
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
        public bool InserirLog(ModelLogin modelLogin)
        {
            try
            {
                string instrucao = string.Format(@"INSERT INTO tbLogLogin (idTecSistemas, Nome, Nivel, UltimoLog, Status) VALUES (@idTecSistemas, @Nome, @Nivel, @UltimoLog, @Status)");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@idTecSistemas", Properties.SettingsSQLCentral.Default.IDTecSistemas);
                command.Parameters.AddWithValue("@Nome", modelLogin.ID);
                command.Parameters.AddWithValue("@Nivel", modelLogin.Nivel);
                command.Parameters.AddWithValue("@UltimoLog", modelLogin.UltimoLog);
                command.Parameters.AddWithValue("@Status", modelLogin.Status);
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
        public bool AlterarStatus(ModelLogin modelLogin)
        {
            try
            {
                string instrucao = string.Format(@"UPDATE tbLogin SET Status = @Status WHERE ID = @ID");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@ID", modelLogin.ID);
                command.Parameters.AddWithValue("@Status", modelLogin.Status);
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
        public DataTable CarregarLogs(ModelLogin modelLogin, string id)
        {
            try
            {
                string instrucao = string.Format(@"SELECT TOP(1000) * FROM tbLogLogin WHERE Nome = '" + id + "' AND idTecSistemas = '" + modelLogin.IDTecSistemas + "'");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar()); ;
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
        public DataTable CarregarLogPorCodigo(string idTecSistemas, string id, string codigo)
        {
            try
            {
                string instrucao = string.Format(@"SELECT TOP (1000) * FROM tbLogLogin WHERE idTecSistemas = '" + idTecSistemas + "' AND Nome = '" + id + "' AND Codigo = '" + codigo + "'");
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
        public DataTable CarregarLogPorNome(string idTecSistemas, string id, string ultimoLog)
        {
            try
            {
                string instrucao = string.Format(@"SELECT TOP (1000) * FROM tbLogLogin WHERE idTecSistemas = '" + idTecSistemas + "' AND Nome = '" + id + "' AND UltimoLog LIKE '%" + ultimoLog + "%'");
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
        public bool Cadastrar(ModelLogin modelLogin)
        {
            try
            {
                string instrucao = string.Format("INSERT INTO tbLogin (ID, Senha, Nivel, IDTecSistemas, Status) VALUES (@ID, @Senha, @Nivel, @IDTecSistemas, 'Desconectado'); SELECT SCOPE_IDENTITY();");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@ID", modelLogin.ID);
                command.Parameters.AddWithValue("@Senha", modelLogin.Senha);
                command.Parameters.AddWithValue("@Nivel", modelLogin.Nivel);
                command.Parameters.AddWithValue("@IDTecSistemas", Properties.SettingsSQLCentral.Default.IDTecSistemas);
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
        public bool Editar(ModelLogin modelLogin)
        {
            try
            {
                string instrucao = string.Format("UPDATE tbLogin SET ID = @ID, Senha = @Senha, Nivel = @Nivel, IDTecSistemas = @IDTecSistemas WHERE Codigo = @Codigo; SELECT @Codigo;");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Codigo", modelLogin.Codigo);
                command.Parameters.AddWithValue("@ID", modelLogin.ID);
                command.Parameters.AddWithValue("@Senha", modelLogin.Senha);
                command.Parameters.AddWithValue("@Nivel", modelLogin.Nivel);
                command.Parameters.AddWithValue("@IDTecSistemas", Properties.SettingsSQLCentral.Default.IDTecSistemas);
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
        public bool Deletar(ModelLogin modelLogin)
        {
            try
            {
                string instrucao = string.Format("DELETE FROM tbLogin WHERE Codigo = @Codigo");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Codigo", modelLogin.Codigo);
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
