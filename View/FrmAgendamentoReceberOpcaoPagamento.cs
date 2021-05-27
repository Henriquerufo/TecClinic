using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmAgendamentoReceberOpcaoPagamento : Form
    {
        string opcaoSelecionada;
        public String RetornoOpcaoPagamento
        {
            get
            {
                return opcaoSelecionada;
            }
        }
        public FrmAgendamentoReceberOpcaoPagamento()
        {
            InitializeComponent();
            dgvOpcaoPagamento.Rows.Clear();
            dgvOpcaoPagamento.Rows.Insert(0, "DINHEIRO");
            dgvOpcaoPagamento.Rows.Insert(1, "CARTAO");
            dgvOpcaoPagamento.Rows.Insert(2, "TICKET");
        }
        void Selecionar()
        {
            if (dgvOpcaoPagamento.CurrentRow.Cells["opcaoPagamento"].Value.ToString() == "CHEQUE")
            {
                dgvOpcaoPagamento.Rows.Clear();
                dgvOpcaoPagamento.Rows.Insert(0, "CHEQUE A VISTA");
                dgvOpcaoPagamento.Rows.Insert(1, "CHEQUE 0 A 29 DIAS");
                dgvOpcaoPagamento.Rows.Insert(2, "CHEQUE 35 DIAS");
                dgvOpcaoPagamento.Rows.Insert(3, "CHEQUE 45 DIAS");
            }
            else
            {
                opcaoSelecionada = dgvOpcaoPagamento.CurrentRow.Cells["opcaoPagamento"].Value.ToString();
                this.Close();
            }
        }

        private void dgvOpcaoPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Selecionar();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dgvOpcaoPagamento_DoubleClick(object sender, EventArgs e)
        {
            Selecionar();
        }
    }
}
