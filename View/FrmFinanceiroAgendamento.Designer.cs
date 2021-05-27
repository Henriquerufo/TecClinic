namespace View
{
    partial class FrmFinanceiroAgendamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpAte = new System.Windows.Forms.DateTimePicker();
            this.dtpDe = new System.Windows.Forms.DateTimePicker();
            this.btnFechar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cbxFiltro = new System.Windows.Forms.ComboBox();
            this.lblExibidosTotal = new System.Windows.Forms.Label();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.dgvFinanceiro = new System.Windows.Forms.DataGridView();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CadastradoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAgendamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraAgendamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusAgendamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecebidoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataRecebimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpcaoPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dinheiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cartao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clinico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObsConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinanceiro)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "Até:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "De:";
            // 
            // dtpAte
            // 
            this.dtpAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAte.Location = new System.Drawing.Point(156, 18);
            this.dtpAte.Name = "dtpAte";
            this.dtpAte.Size = new System.Drawing.Size(82, 20);
            this.dtpAte.TabIndex = 1;
            // 
            // dtpDe
            // 
            this.dtpDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDe.Location = new System.Drawing.Point(36, 18);
            this.dtpDe.Name = "dtpDe";
            this.dtpDe.Size = new System.Drawing.Size(82, 20);
            this.dtpDe.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(839, 525);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(100, 33);
            this.btnFechar.TabIndex = 115;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpAte);
            this.groupBox2.Controls.Add(this.dtpDe);
            this.groupBox2.Location = new System.Drawing.Point(586, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 44);
            this.groupBox2.TabIndex = 114;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 112;
            this.label1.Text = "Filtro";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(839, 28);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 29);
            this.btnPesquisar.TabIndex = 108;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltro.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFiltro.FormattingEnabled = true;
            this.cbxFiltro.Items.AddRange(new object[] {
            "CODIGO",
            "NOME"});
            this.cbxFiltro.Location = new System.Drawing.Point(16, 24);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(159, 31);
            this.cbxFiltro.TabIndex = 106;
            // 
            // lblExibidosTotal
            // 
            this.lblExibidosTotal.AutoSize = true;
            this.lblExibidosTotal.Location = new System.Drawing.Point(13, 522);
            this.lblExibidosTotal.Name = "lblExibidosTotal";
            this.lblExibidosTotal.Size = new System.Drawing.Size(81, 13);
            this.lblExibidosTotal.TabIndex = 111;
            this.lblExibidosTotal.Text = "Exibidos total: 0";
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(178, 10);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisar.TabIndex = 110;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // txtProcurar
            // 
            this.txtProcurar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcurar.Location = new System.Drawing.Point(181, 27);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(399, 29);
            this.txtProcurar.TabIndex = 107;
            // 
            // dgvFinanceiro
            // 
            this.dgvFinanceiro.AllowUserToAddRows = false;
            this.dgvFinanceiro.AllowUserToDeleteRows = false;
            this.dgvFinanceiro.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvFinanceiro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFinanceiro.BackgroundColor = System.Drawing.Color.White;
            this.dgvFinanceiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinanceiro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Endereco,
            this.Telefone,
            this.Dn,
            this.CadastradoPor,
            this.DataAgendamento,
            this.HoraAgendamento,
            this.StatusAgendamento,
            this.Servico,
            this.RecebidoPor,
            this.DataRecebimento,
            this.Valor,
            this.OpcaoPagamento,
            this.Dinheiro,
            this.Cartao,
            this.Ticket,
            this.StatusPagamento,
            this.Clinico,
            this.ObsConsulta});
            this.dgvFinanceiro.Location = new System.Drawing.Point(16, 64);
            this.dgvFinanceiro.MultiSelect = false;
            this.dgvFinanceiro.Name = "dgvFinanceiro";
            this.dgvFinanceiro.ReadOnly = true;
            this.dgvFinanceiro.RowHeadersVisible = false;
            this.dgvFinanceiro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFinanceiro.Size = new System.Drawing.Size(923, 455);
            this.dgvFinanceiro.TabIndex = 109;
            this.dgvFinanceiro.DoubleClick += new System.EventHandler(this.dgvFinanceiro_DoubleClick);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorio.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.Location = new System.Drawing.Point(726, 525);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(100, 33);
            this.btnRelatorio.TabIndex = 116;
            this.btnRelatorio.Text = "Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(832, 525);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 33);
            this.panel1.TabIndex = 117;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Endereco
            // 
            this.Endereco.DataPropertyName = "Endereco";
            this.Endereco.HeaderText = "Endereço";
            this.Endereco.Name = "Endereco";
            this.Endereco.ReadOnly = true;
            this.Endereco.Visible = false;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Visible = false;
            // 
            // Dn
            // 
            this.Dn.DataPropertyName = "Dn";
            this.Dn.HeaderText = "Data de Nascimento";
            this.Dn.Name = "Dn";
            this.Dn.ReadOnly = true;
            this.Dn.Visible = false;
            // 
            // CadastradoPor
            // 
            this.CadastradoPor.DataPropertyName = "CadastradoPor";
            this.CadastradoPor.HeaderText = "Cadastrado Por";
            this.CadastradoPor.Name = "CadastradoPor";
            this.CadastradoPor.ReadOnly = true;
            this.CadastradoPor.Visible = false;
            // 
            // DataAgendamento
            // 
            this.DataAgendamento.DataPropertyName = "DataAgendamento";
            this.DataAgendamento.HeaderText = "Dia do Agendamento";
            this.DataAgendamento.Name = "DataAgendamento";
            this.DataAgendamento.ReadOnly = true;
            this.DataAgendamento.Visible = false;
            // 
            // HoraAgendamento
            // 
            this.HoraAgendamento.DataPropertyName = "HoraAgendamento";
            this.HoraAgendamento.HeaderText = "Horário do Agendamento";
            this.HoraAgendamento.Name = "HoraAgendamento";
            this.HoraAgendamento.ReadOnly = true;
            this.HoraAgendamento.Visible = false;
            // 
            // StatusAgendamento
            // 
            this.StatusAgendamento.DataPropertyName = "StatusAgendamento";
            this.StatusAgendamento.HeaderText = "Status do Agendamento";
            this.StatusAgendamento.Name = "StatusAgendamento";
            this.StatusAgendamento.ReadOnly = true;
            // 
            // Servico
            // 
            this.Servico.DataPropertyName = "Servico";
            this.Servico.HeaderText = "Serviço";
            this.Servico.Name = "Servico";
            this.Servico.ReadOnly = true;
            // 
            // RecebidoPor
            // 
            this.RecebidoPor.DataPropertyName = "RecebidoPor";
            this.RecebidoPor.HeaderText = "Recebido Por";
            this.RecebidoPor.Name = "RecebidoPor";
            this.RecebidoPor.ReadOnly = true;
            // 
            // DataRecebimento
            // 
            this.DataRecebimento.DataPropertyName = "DataRecebimento";
            this.DataRecebimento.HeaderText = "Data do Recebimento";
            this.DataRecebimento.Name = "DataRecebimento";
            this.DataRecebimento.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // OpcaoPagamento
            // 
            this.OpcaoPagamento.DataPropertyName = "OpcaoPagamento";
            this.OpcaoPagamento.HeaderText = "Opção de Pagamento";
            this.OpcaoPagamento.Name = "OpcaoPagamento";
            this.OpcaoPagamento.ReadOnly = true;
            // 
            // Dinheiro
            // 
            this.Dinheiro.DataPropertyName = "Dinheiro";
            this.Dinheiro.HeaderText = "Dinheiro";
            this.Dinheiro.Name = "Dinheiro";
            this.Dinheiro.ReadOnly = true;
            // 
            // Cartao
            // 
            this.Cartao.DataPropertyName = "Cartao";
            this.Cartao.HeaderText = "Cartão";
            this.Cartao.Name = "Cartao";
            this.Cartao.ReadOnly = true;
            // 
            // Ticket
            // 
            this.Ticket.DataPropertyName = "Ticket";
            this.Ticket.HeaderText = "Ticket";
            this.Ticket.Name = "Ticket";
            this.Ticket.ReadOnly = true;
            // 
            // StatusPagamento
            // 
            this.StatusPagamento.DataPropertyName = "StatusPagamento";
            this.StatusPagamento.HeaderText = "Status do Pagamento";
            this.StatusPagamento.Name = "StatusPagamento";
            this.StatusPagamento.ReadOnly = true;
            // 
            // Clinico
            // 
            this.Clinico.DataPropertyName = "Clinico";
            this.Clinico.HeaderText = "Clínico";
            this.Clinico.Name = "Clinico";
            this.Clinico.ReadOnly = true;
            this.Clinico.Visible = false;
            // 
            // ObsConsulta
            // 
            this.ObsConsulta.DataPropertyName = "ObsConsulta";
            this.ObsConsulta.HeaderText = "Observações da Consulta";
            this.ObsConsulta.Name = "ObsConsulta";
            this.ObsConsulta.ReadOnly = true;
            this.ObsConsulta.Visible = false;
            // 
            // FrmFinanceiroAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 569);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.cbxFiltro);
            this.Controls.Add(this.lblExibidosTotal);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.txtProcurar);
            this.Controls.Add(this.dgvFinanceiro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmFinanceiroAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tec Clinic: Gerenciador de Financeiro";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinanceiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpAte;
        private System.Windows.Forms.DateTimePicker dtpDe;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ComboBox cbxFiltro;
        private System.Windows.Forms.Label lblExibidosTotal;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.DataGridView dgvFinanceiro;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CadastradoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAgendamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraAgendamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusAgendamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servico;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecebidoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataRecebimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpcaoPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dinheiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cartao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clinico;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObsConsulta;
    }
}