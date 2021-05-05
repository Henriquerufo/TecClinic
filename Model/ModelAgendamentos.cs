using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

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
        public string Status { get; set; }
    }
}
