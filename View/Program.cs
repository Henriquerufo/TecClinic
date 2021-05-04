using Controller;
using Model;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace View
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ControllerConfiguracaoSQLCentral controllerConfiguracaoSQLCentral = new ControllerConfiguracaoSQLCentral();
            ModelConfiguracaoSQLCentral modelConfiguracaoSQLCentral = controllerConfiguracaoSQLCentral.Carregar();
            ControllerConfiguracaoSQL controllerConfiguracaoSQL = new ControllerConfiguracaoSQL();
            ModelConfiguracaoSQL modelConfiguracaoSQL = new ModelConfiguracaoSQL();
            string instrucao = string.Format(@"SELECT * FROM tbCadastro WHERE idTecSistemas = '" + modelConfiguracaoSQLCentral.IDTecSistemas + "' AND senhaTecSistemas = '" + modelConfiguracaoSQLCentral.SenhaTecSistemas + "' AND status = '1' AND dataVencimento > CURRENT_TIMESTAMP");
            SqlCommand command;
            try
            {
                command = new SqlCommand(instrucao, controllerConfiguracaoSQLCentral.Conectar());
            }
            catch (Exception ex)
            {
                var result = MessageBox.Show(ex.Message + "\n\nVerificar conexão?", "Erro!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    FrmConfiguracaoSQL frmConfiguracaoSQL = new FrmConfiguracaoSQL();
                    frmConfiguracaoSQL.ShowDialog();
                }
                return;
            }
            SqlDataReader sqlDataReader = command.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                string conexaoBanco = string.Format(@"SELECT servidorBD, nomeBD, idBD, senhaBD FROM tbCadastro WHERE idTecSistemas = '" + modelConfiguracaoSQLCentral.IDTecSistemas + "'");
                SqlCommand command1 = new SqlCommand(conexaoBanco, controllerConfiguracaoSQLCentral.Conectar());
                SqlDataReader sqlDataReader1 = command1.ExecuteReader();
                sqlDataReader1.Read();
                modelConfiguracaoSQL.ServidorBD = sqlDataReader1["servidorBD"].ToString();
                modelConfiguracaoSQL.NomeBD = sqlDataReader1["nomeBD"].ToString();
                modelConfiguracaoSQL.IDBD = sqlDataReader1["idBD"].ToString();
                modelConfiguracaoSQL.SenhaBD = sqlDataReader1["senhaBD"].ToString();

                controllerConfiguracaoSQL.SalvarConexao(modelConfiguracaoSQL);
                ModelLogin modelLogin = new ModelLogin();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmLogin(modelLogin));
            }
            else
            {
                MessageBox.Show("O sistema está desativado ou vencido, entre em contato com o desenvolvedor.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
