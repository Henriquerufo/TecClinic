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
    public class ControllerTicket
    {
        ControllerConfiguracaoSQL controllerConfiguracaoSQL = new ControllerConfiguracaoSQL();
        public DataTable CarregarTicketEmAbertoPorCodigo(string codigoItem, string dataDe, string dataAte)
        {
            try
            {
                string instrucao = string.Format(@"SELECT TOP (1000) * FROM tbTicket WHERE Status = 'Em Aberto' AND Codigo = '" + codigoItem + "' AND Data BETWEEN '" + dataDe + "' AND '" + dataAte + "'");
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
        public DataTable CarregarTicketEmAbertoPorVendedor(string geradoPor, string dataDe, string dataAte)
        {
            try
            {
                string instrucao = string.Format(@"SELECT TOP (1000) * FROM tbTicket WHERE Status = 'Em Aberto' AND GeradoPor LIKE '%" + geradoPor + "%' AND Data BETWEEN '" + dataDe + "' AND '" + dataAte + "'");
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
        public DataTable CarregarTicketFinalizadoPorCodigo(string codigoItem, string dataDe, string dataAte)
        {
            try
            {
                string instrucao = string.Format(@"SELECT TOP (1000) * FROM tbTicket WHERE Status = 'Finalizado' AND Codigo = '" + codigoItem + "' AND Data BETWEEN '" + dataDe + "' AND '" + dataAte + "'");
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
        public DataTable CarregarTicketFinalizadoPorVendedor(string geradoPor, string dataDe, string dataAte)
        {
            try
            {
                string instrucao = string.Format(@"SELECT TOP (1000) * FROM tbTicket WHERE Status = 'Finalizado' AND GeradoPor LIKE '%" + geradoPor + "%' AND Data BETWEEN '" + dataDe + "' AND '" + dataAte + "'");
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
        public int GerarTicket(ModelTicket modelTicket)
        {
            try
            {
                string instrucao = string.Format(@"INSERT INTO tbTicket (GeradoPor, Data, Valor, Status) VALUES (@GeradoPor, @Data, @Valor, @Status); SELECT @@IDENTITY;");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@GeradoPor", modelTicket.GeradoPor);
                command.Parameters.AddWithValue("@Data", modelTicket.Data);
                command.Parameters.AddWithValue("@Valor", modelTicket.Valor);
                command.Parameters.AddWithValue("@Status", modelTicket.Status);
                return Convert.ToInt32(command.ExecuteScalar());
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
        public decimal VerificarTicket(ModelTicket modelTicket)
        {
            try
            {
                string instrucao = string.Format(@"SELECT * FROM tbTicket WHERE Codigo = @Codigo AND Status = 'Em Aberto'");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Codigo", modelTicket.Codigo);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Read();
                    return Convert.ToDecimal(sqlDataReader["Valor"].ToString());
                }
                return 0;
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
        public bool valorTicketPago(ModelTicket modelTicket)
        {
            try
            {
                string instrucao = string.Format(@"UPDATE tbTicket SET Valor = Valor - @Valor WHERE Codigo = @Codigo");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Codigo", modelTicket.Codigo);
                command.Parameters.AddWithValue("@Valor", modelTicket.ValorPago);
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
        public bool VerificarTicketZerado(ModelTicket modelTicket)
        {
            try
            {
                string instrucao = string.Format(@"SELECT * FROM tbTicket WHERE Codigo = @Codigo AND Valor = '0.00'");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Codigo", modelTicket.Codigo);
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
        public bool TicketAlterarStatus(ModelTicket modelTicketa)
        {
            try
            {
                string instrucao = string.Format(@"UPDATE tbTicket SET Status = 'Finalizado' WHERE Codigo = @Codigo");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Codigo", modelTicketa.Codigo);
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
