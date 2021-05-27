namespace View
{
    partial class FrmGerenciadorAgendamentos
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpAte = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpDe = new System.Windows.Forms.DateTimePicker();
            this.rbEmAberto = new System.Windows.Forms.RadioButton();
            this.rbFinalizado = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cbxFiltro = new System.Windows.Forms.ComboBox();
            this.lblExibidosTotal = new System.Windows.Forms.Label();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.dgvAgendamentos = new System.Windows.Forms.DataGridView();
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
            this.Clinico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecebidoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataRecebimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpcaoPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dinheiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cartao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReceber = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbEmAbertoPagamento = new System.Windows.Forms.RadioButton();
            this.rbRecebido = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamentos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(738, 525);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(100, 33);
            this.btnFechar.TabIndex = 100;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "Até:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "De:";
            // 
            // dtpAte
            // 
            this.dtpAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAte.Location = new System.Drawing.Point(40, 56);
            this.dtpAte.Name = "dtpAte";
            this.dtpAte.Size = new System.Drawing.Size(82, 20);
            this.dtpAte.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpAte);
            this.groupBox2.Controls.Add(this.dtpDe);
            this.groupBox2.Location = new System.Drawing.Point(603, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 82);
            this.groupBox2.TabIndex = 99;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // dtpDe
            // 
            this.dtpDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDe.Location = new System.Drawing.Point(40, 30);
            this.dtpDe.Name = "dtpDe";
            this.dtpDe.Size = new System.Drawing.Size(82, 20);
            this.dtpDe.TabIndex = 0;
            // 
            // rbEmAberto
            // 
            this.rbEmAberto.AutoSize = true;
            this.rbEmAberto.Checked = true;
            this.rbEmAberto.Location = new System.Drawing.Point(6, 56);
            this.rbEmAberto.Name = "rbEmAberto";
            this.rbEmAberto.Size = new System.Drawing.Size(74, 17);
            this.rbEmAberto.TabIndex = 1;
            this.rbEmAberto.TabStop = true;
            this.rbEmAberto.Text = "Em Aberto";
            this.rbEmAberto.UseVisualStyleBackColor = true;
            // 
            // rbFinalizado
            // 
            this.rbFinalizado.AutoSize = true;
            this.rbFinalizado.Location = new System.Drawing.Point(6, 33);
            this.rbFinalizado.Name = "rbFinalizado";
            this.rbFinalizado.Size = new System.Drawing.Size(72, 17);
            this.rbFinalizado.TabIndex = 0;
            this.rbFinalizado.Text = "Finalizado";
            this.rbFinalizado.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEmAberto);
            this.groupBox1.Controls.Add(this.rbFinalizado);
            this.groupBox1.Location = new System.Drawing.Point(413, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(89, 82);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status do Agendamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 97;
            this.label1.Text = "Filtro";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(738, 58);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 29);
            this.btnPesquisar.TabIndex = 93;
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
            this.cbxFiltro.Location = new System.Drawing.Point(12, 20);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(156, 31);
            this.cbxFiltro.TabIndex = 91;
            // 
            // lblExibidosTotal
            // 
            this.lblExibidosTotal.AutoSize = true;
            this.lblExibidosTotal.Location = new System.Drawing.Point(11, 522);
            this.lblExibidosTotal.Name = "lblExibidosTotal";
            this.lblExibidosTotal.Size = new System.Drawing.Size(81, 13);
            this.lblExibidosTotal.TabIndex = 96;
            this.lblExibidosTotal.Text = "Exibidos total: 0";
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(171, 5);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisar.TabIndex = 95;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // txtProcurar
            // 
            this.txtProcurar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcurar.Location = new System.Drawing.Point(174, 21);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(232, 29);
            this.txtProcurar.TabIndex = 92;
            // 
            // dgvAgendamentos
            // 
            this.dgvAgendamentos.AllowUserToAddRows = false;
            this.dgvAgendamentos.AllowUserToDeleteRows = false;
            this.dgvAgendamentos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAgendamentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAgendamentos.BackgroundColor = System.Drawing.Color.White;
            this.dgvAgendamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgendamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.Clinico,
            this.Valor,
            this.StatusPagamento,
            this.RecebidoPor,
            this.DataRecebimento,
            this.OpcaoPagamento,
            this.Dinheiro,
            this.Cartao,
            this.Ticket});
            this.dgvAgendamentos.Location = new System.Drawing.Point(12, 95);
            this.dgvAgendamentos.MultiSelect = false;
            this.dgvAgendamentos.Name = "dgvAgendamentos";
            this.dgvAgendamentos.ReadOnly = true;
            this.dgvAgendamentos.RowHeadersVisible = false;
            this.dgvAgendamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgendamentos.Size = new System.Drawing.Size(826, 424);
            this.dgvAgendamentos.TabIndex = 94;
            this.dgvAgendamentos.DoubleClick += new System.EventHandler(this.dgvAgendamentos_DoubleClick);
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
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // Dn
            // 
            this.Dn.DataPropertyName = "Dn";
            this.Dn.HeaderText = "Data de Nascimento";
            this.Dn.Name = "Dn";
            this.Dn.ReadOnly = true;
            // 
            // CadastradoPor
            // 
            this.CadastradoPor.DataPropertyName = "CadastradoPor";
            this.CadastradoPor.HeaderText = "Cadastrado Por";
            this.CadastradoPor.Name = "CadastradoPor";
            this.CadastradoPor.ReadOnly = true;
            // 
            // DataAgendamento
            // 
            this.DataAgendamento.DataPropertyName = "DataAgendamento";
            this.DataAgendamento.HeaderText = "Dia do Agendamento";
            this.DataAgendamento.Name = "DataAgendamento";
            this.DataAgendamento.ReadOnly = true;
            // 
            // HoraAgendamento
            // 
            this.HoraAgendamento.DataPropertyName = "HoraAgendamento";
            this.HoraAgendamento.HeaderText = "Horário do Agendamento";
            this.HoraAgendamento.Name = "HoraAgendamento";
            this.HoraAgendamento.ReadOnly = true;
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
            // Clinico
            // 
            this.Clinico.DataPropertyName = "Clinico";
            this.Clinico.HeaderText = "Clínico";
            this.Clinico.Name = "Clinico";
            this.Clinico.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // StatusPagamento
            // 
            this.StatusPagamento.DataPropertyName = "StatusPagamento";
            this.StatusPagamento.HeaderText = "Status do Pagamento";
            this.StatusPagamento.Name = "StatusPagamento";
            this.StatusPagamento.ReadOnly = true;
            // 
            // RecebidoPor
            // 
            this.RecebidoPor.DataPropertyName = "RecebidoPor";
            this.RecebidoPor.HeaderText = "Recebido Por";
            this.RecebidoPor.Name = "RecebidoPor";
            this.RecebidoPor.ReadOnly = true;
            this.RecebidoPor.Visible = false;
            // 
            // DataRecebimento
            // 
            this.DataRecebimento.DataPropertyName = "DataRecebimento";
            this.DataRecebimento.HeaderText = "DataRecebimento";
            this.DataRecebimento.Name = "DataRecebimento";
            this.DataRecebimento.ReadOnly = true;
            this.DataRecebimento.Visible = false;
            // 
            // OpcaoPagamento
            // 
            this.OpcaoPagamento.DataPropertyName = "OpcaoPagamento";
            this.OpcaoPagamento.HeaderText = "OpcaoPagamento";
            this.OpcaoPagamento.Name = "OpcaoPagamento";
            this.OpcaoPagamento.ReadOnly = true;
            this.OpcaoPagamento.Visible = false;
            // 
            // Dinheiro
            // 
            this.Dinheiro.DataPropertyName = "Dinheiro";
            this.Dinheiro.HeaderText = "Dinheiro";
            this.Dinheiro.Name = "Dinheiro";
            this.Dinheiro.ReadOnly = true;
            this.Dinheiro.Visible = false;
            // 
            // Cartao
            // 
            this.Cartao.DataPropertyName = "Cartao";
            this.Cartao.HeaderText = "Cartao";
            this.Cartao.Name = "Cartao";
            this.Cartao.ReadOnly = true;
            this.Cartao.Visible = false;
            // 
            // Ticket
            // 
            this.Ticket.DataPropertyName = "Ticket";
            this.Ticket.HeaderText = "Ticket";
            this.Ticket.Name = "Ticket";
            this.Ticket.ReadOnly = true;
            this.Ticket.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(731, 525);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 33);
            this.panel1.TabIndex = 105;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(300, 525);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 33);
            this.btnConsultar.TabIndex = 101;
            this.btnConsultar.Text = "Finalizar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(413, 525);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 33);
            this.btnNovo.TabIndex = 102;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(625, 525);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 33);
            this.btnCancelar.TabIndex = 104;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(519, 525);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 33);
            this.btnSalvar.TabIndex = 103;
            this.btnSalvar.Text = "Editar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(406, 525);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 33);
            this.panel2.TabIndex = 106;
            // 
            // btnReceber
            // 
            this.btnReceber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceber.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceber.Location = new System.Drawing.Point(194, 525);
            this.btnReceber.Name = "btnReceber";
            this.btnReceber.Size = new System.Drawing.Size(100, 33);
            this.btnReceber.TabIndex = 107;
            this.btnReceber.Text = "Receber";
            this.btnReceber.UseVisualStyleBackColor = true;
            this.btnReceber.Click += new System.EventHandler(this.btnReceber_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbEmAbertoPagamento);
            this.groupBox3.Controls.Add(this.rbRecebido);
            this.groupBox3.Location = new System.Drawing.Point(508, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(89, 82);
            this.groupBox3.TabIndex = 108;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status do Pagamento";
            // 
            // rbEmAbertoPagamento
            // 
            this.rbEmAbertoPagamento.AutoSize = true;
            this.rbEmAbertoPagamento.Checked = true;
            this.rbEmAbertoPagamento.Location = new System.Drawing.Point(6, 56);
            this.rbEmAbertoPagamento.Name = "rbEmAbertoPagamento";
            this.rbEmAbertoPagamento.Size = new System.Drawing.Size(74, 17);
            this.rbEmAbertoPagamento.TabIndex = 1;
            this.rbEmAbertoPagamento.TabStop = true;
            this.rbEmAbertoPagamento.Text = "Em Aberto";
            this.rbEmAbertoPagamento.UseVisualStyleBackColor = true;
            // 
            // rbRecebido
            // 
            this.rbRecebido.AutoSize = true;
            this.rbRecebido.Location = new System.Drawing.Point(6, 33);
            this.rbRecebido.Name = "rbRecebido";
            this.rbRecebido.Size = new System.Drawing.Size(71, 17);
            this.rbRecebido.TabIndex = 0;
            this.rbRecebido.Text = "Recebido";
            this.rbRecebido.UseVisualStyleBackColor = true;
            // 
            // FrmGerenciadorAgendamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 565);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnReceber);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.cbxFiltro);
            this.Controls.Add(this.lblExibidosTotal);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.txtProcurar);
            this.Controls.Add(this.dgvAgendamentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmGerenciadorAgendamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tec Clinic: Gerenciador de Agendamentos";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamentos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpAte;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpDe;
        private System.Windows.Forms.RadioButton rbEmAberto;
        private System.Windows.Forms.RadioButton rbFinalizado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ComboBox cbxFiltro;
        private System.Windows.Forms.Label lblExibidosTotal;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.DataGridView dgvAgendamentos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReceber;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbEmAbertoPagamento;
        private System.Windows.Forms.RadioButton rbRecebido;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Clinico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecebidoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataRecebimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpcaoPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dinheiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cartao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket;
    }
}