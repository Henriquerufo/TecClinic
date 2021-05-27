namespace Model
{
    public class ModelFinanceiro
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
        public string Status { get; set; }
        public string Servico { get; set; }
        public decimal Valor { get; set; }
        public string  RecebidoPor { get; set; }
        public string DataRecebimento { get; set; }
        public string OpcaoPagamento { get; set; }
        public decimal Dinheiro { get; set; }
        public decimal Cartao { get; set; }
        public decimal Ticket { get; set; }
        public string dtpDe { get; set; }
        public string dtpAte { get; set; }
        public decimal ValorTotal { get; set; }
        public string TotalAgendamento { get; set; }
    }
}
