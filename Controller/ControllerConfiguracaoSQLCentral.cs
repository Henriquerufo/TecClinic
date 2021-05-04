using Model;
using System;
using System.Data.SqlClient;
using System.Net;

namespace Controller
{
    public class ControllerConfiguracaoSQLCentral
    {
        ModelConfiguracaoSQLCentral modelConfiguracaoSQLCentral = new ModelConfiguracaoSQLCentral();
        string parametrosSQL = string.Format(@"Data Source={0}; Initial Catalog={1}; User ID={2}; Password={3};",
            Properties.SettingsSQLCentral.Default.ServidorBD,
            Properties.SettingsSQLCentral.Default.NomeBD,
            Properties.SettingsSQLCentral.Default.IDBD,
            Properties.SettingsSQLCentral.Default.SenhaBD);
        SqlConnection conexao = null;
        public bool VerificarInternet()
        {
            try
            {
                using (var client = new WebClient())
                {
                    WebProxy wp = new WebProxy();
                    client.Proxy = wp;
                    using (var stream = client.OpenRead("http://www.google.com"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
        public SqlConnection Conectar()
        {
            try
            {
                conexao = new SqlConnection(parametrosSQL);
                conexao.Open();
                return conexao;
            }
            catch
            {
                throw;
            }
        }
        public SqlConnection Fechar()
        {
            conexao.Close();
            conexao.Dispose();
            return conexao;
        }
        public bool Conectar(ModelConfiguracaoSQLCentral modelConfiguracaoSQLCentral)
        {
            try
            {
                Properties.SettingsSQLCentral.Default.ServidorBD = modelConfiguracaoSQLCentral.ServidorBD;
                Properties.SettingsSQLCentral.Default.NomeBD = modelConfiguracaoSQLCentral.NomeBD;
                Properties.SettingsSQLCentral.Default.IDBD = modelConfiguracaoSQLCentral.IDBD;
                Properties.SettingsSQLCentral.Default.SenhaBD = modelConfiguracaoSQLCentral.SenhaBD;
                Properties.SettingsSQLCentral.Default.IDTecSistemas = modelConfiguracaoSQLCentral.IDTecSistemas;
                Properties.SettingsSQLCentral.Default.SenhaTecSistemas = modelConfiguracaoSQLCentral.SenhaTecSistemas;
                Properties.SettingsSQLCentral.Default.Save();

                return true;
            }
            catch
            {

                throw new Exception();
            }
        }
        public ModelConfiguracaoSQLCentral Carregar()
        {

            modelConfiguracaoSQLCentral.ServidorBD = Properties.SettingsSQLCentral.Default.ServidorBD;
            modelConfiguracaoSQLCentral.NomeBD = Properties.SettingsSQLCentral.Default.NomeBD;
            modelConfiguracaoSQLCentral.IDBD = Properties.SettingsSQLCentral.Default.IDBD;
            modelConfiguracaoSQLCentral.SenhaBD = Properties.SettingsSQLCentral.Default.SenhaBD;
            modelConfiguracaoSQLCentral.IDTecSistemas = Properties.SettingsSQLCentral.Default.IDTecSistemas;
            modelConfiguracaoSQLCentral.SenhaTecSistemas = Properties.SettingsSQLCentral.Default.SenhaTecSistemas;

            return modelConfiguracaoSQLCentral;
        }
    }
}
