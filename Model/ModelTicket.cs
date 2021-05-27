namespace Model
{
    public class ModelTicket
    {
        public int Codigo { get; set; }
        public string GeradoPor { get; set; }
        public string Vendedor { get; set; }
        public string Data { get; set; }
        public decimal Valor { get; set; }
        public string Status { get; set; }
        public decimal ValorPago { get; set; }
    }
}
