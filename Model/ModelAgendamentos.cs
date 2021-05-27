using System.Collections.Generic;


namespace Model
{
    public class ModelAgendamentos
    {
        public int Codigo { get; set; }
        public string acao { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Dn { get; set; }
        public string CadastradoPor { get; set; }
        public string DataAgendamento { get; set; }
        public string HoraAgendamento { get; set; }
        public string StatusAgendamento { get; set; }
        public string Servico { get; set; }
        public string Clinico { get; set; }
        public decimal Valor { get; set; }
        public List<string> HorariosCadastrados { get; set; }
        public string RecebidoPor { get; set; }
        public string DataRecebimento { get; set; }
        public string OpcaoPagamento { get; set; }
        public decimal Dinheiro { get; set; }
        public decimal Cartao { get; set; }
        public decimal Ticket { get; set; }
        public string StatusPagamento { get; set; }
        public string ObsConsulta { get; set; }
    }
}
