namespace View
{
    partial class FrmCadastroAgendamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNovo = new System.Windows.Forms.Label();
            this.grbServico = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClinico = new System.Windows.Forms.TextBox();
            this.txtValorServico = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProcurarServico = new System.Windows.Forms.Button();
            this.txtNomeServico = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gpbAgendar = new System.Windows.Forms.GroupBox();
            this.btnProcurarHorario = new System.Windows.Forms.Button();
            this.dgvHorario = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDataAgendamento = new System.Windows.Forms.DateTimePicker();
            this.grbInformacoesDoCliente = new System.Windows.Forms.GroupBox();
            this.txtProcurarCliente = new System.Windows.Forms.Button();
            this.txtDn = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbObs = new System.Windows.Forms.GroupBox();
            this.txtObs = new System.Windows.Forms.RichTextBox();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCampoObrigatorio = new System.Windows.Forms.Label();
            this.grbServico.SuspendLayout();
            this.gpbAgendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).BeginInit();
            this.grbInformacoesDoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbObs.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 25);
            this.label6.TabIndex = 89;
            this.label6.Text = "Agendamento";
            // 
            // lblNovo
            // 
            this.lblNovo.AutoSize = true;
            this.lblNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovo.Location = new System.Drawing.Point(12, 9);
            this.lblNovo.Name = "lblNovo";
            this.lblNovo.Size = new System.Drawing.Size(83, 33);
            this.lblNovo.TabIndex = 88;
            this.lblNovo.Text = "Novo";
            // 
            // grbServico
            // 
            this.grbServico.Controls.Add(this.label5);
            this.grbServico.Controls.Add(this.txtClinico);
            this.grbServico.Controls.Add(this.txtValorServico);
            this.grbServico.Controls.Add(this.label8);
            this.grbServico.Controls.Add(this.txtProcurarServico);
            this.grbServico.Controls.Add(this.txtNomeServico);
            this.grbServico.Controls.Add(this.label7);
            this.grbServico.Location = new System.Drawing.Point(14, 238);
            this.grbServico.Name = "grbServico";
            this.grbServico.Size = new System.Drawing.Size(364, 79);
            this.grbServico.TabIndex = 83;
            this.grbServico.TabStop = false;
            this.grbServico.Text = "Serviço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 95;
            this.label5.Text = "Clínico:*";
            // 
            // txtClinico
            // 
            this.txtClinico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClinico.Location = new System.Drawing.Point(63, 50);
            this.txtClinico.Name = "txtClinico";
            this.txtClinico.ReadOnly = true;
            this.txtClinico.Size = new System.Drawing.Size(140, 22);
            this.txtClinico.TabIndex = 94;
            // 
            // txtValorServico
            // 
            this.txtValorServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorServico.Location = new System.Drawing.Point(258, 50);
            this.txtValorServico.Name = "txtValorServico";
            this.txtValorServico.ReadOnly = true;
            this.txtValorServico.Size = new System.Drawing.Size(100, 22);
            this.txtValorServico.TabIndex = 93;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(209, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 92;
            this.label8.Text = "Valor:*";
            // 
            // txtProcurarServico
            // 
            this.txtProcurarServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcurarServico.Location = new System.Drawing.Point(289, 20);
            this.txtProcurarServico.Name = "txtProcurarServico";
            this.txtProcurarServico.Size = new System.Drawing.Size(69, 24);
            this.txtProcurarServico.TabIndex = 84;
            this.txtProcurarServico.Text = "Procurar";
            this.txtProcurarServico.UseVisualStyleBackColor = true;
            this.txtProcurarServico.Click += new System.EventHandler(this.txtProcurarServico_Click);
            // 
            // txtNomeServico
            // 
            this.txtNomeServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeServico.Location = new System.Drawing.Point(60, 22);
            this.txtNomeServico.Name = "txtNomeServico";
            this.txtNomeServico.ReadOnly = true;
            this.txtNomeServico.Size = new System.Drawing.Size(223, 22);
            this.txtNomeServico.TabIndex = 85;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 84;
            this.label7.Text = "Nome:*";
            // 
            // gpbAgendar
            // 
            this.gpbAgendar.Controls.Add(this.btnProcurarHorario);
            this.gpbAgendar.Controls.Add(this.dgvHorario);
            this.gpbAgendar.Controls.Add(this.label4);
            this.gpbAgendar.Controls.Add(this.dtpDataAgendamento);
            this.gpbAgendar.Location = new System.Drawing.Point(12, 326);
            this.gpbAgendar.Name = "gpbAgendar";
            this.gpbAgendar.Size = new System.Drawing.Size(369, 172);
            this.gpbAgendar.TabIndex = 81;
            this.gpbAgendar.TabStop = false;
            this.gpbAgendar.Text = "Agendar";
            // 
            // btnProcurarHorario
            // 
            this.btnProcurarHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurarHorario.Location = new System.Drawing.Point(289, 17);
            this.btnProcurarHorario.Name = "btnProcurarHorario";
            this.btnProcurarHorario.Size = new System.Drawing.Size(69, 24);
            this.btnProcurarHorario.TabIndex = 94;
            this.btnProcurarHorario.Text = "Procurar";
            this.btnProcurarHorario.UseVisualStyleBackColor = true;
            this.btnProcurarHorario.Click += new System.EventHandler(this.btnProcurarHorario_Click);
            // 
            // dgvHorario
            // 
            this.dgvHorario.AllowUserToAddRows = false;
            this.dgvHorario.AllowUserToDeleteRows = false;
            this.dgvHorario.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvHorario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHorario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHorario.BackgroundColor = System.Drawing.Color.White;
            this.dgvHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hora});
            this.dgvHorario.Location = new System.Drawing.Point(9, 47);
            this.dgvHorario.Name = "dgvHorario";
            this.dgvHorario.ReadOnly = true;
            this.dgvHorario.RowHeadersVisible = false;
            this.dgvHorario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHorario.Size = new System.Drawing.Size(349, 119);
            this.dgvHorario.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 80;
            this.label4.Text = "Dia:*";
            // 
            // dtpDataAgendamento
            // 
            this.dtpDataAgendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataAgendamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAgendamento.Location = new System.Drawing.Point(177, 17);
            this.dtpDataAgendamento.Name = "dtpDataAgendamento";
            this.dtpDataAgendamento.Size = new System.Drawing.Size(106, 22);
            this.dtpDataAgendamento.TabIndex = 50;
            // 
            // grbInformacoesDoCliente
            // 
            this.grbInformacoesDoCliente.Controls.Add(this.txtProcurarCliente);
            this.grbInformacoesDoCliente.Controls.Add(this.txtDn);
            this.grbInformacoesDoCliente.Controls.Add(this.label10);
            this.grbInformacoesDoCliente.Controls.Add(this.txtTelefone);
            this.grbInformacoesDoCliente.Controls.Add(this.label3);
            this.grbInformacoesDoCliente.Controls.Add(this.txtEndereco);
            this.grbInformacoesDoCliente.Controls.Add(this.label2);
            this.grbInformacoesDoCliente.Controls.Add(this.txtNome);
            this.grbInformacoesDoCliente.Controls.Add(this.label1);
            this.grbInformacoesDoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInformacoesDoCliente.Location = new System.Drawing.Point(14, 118);
            this.grbInformacoesDoCliente.Name = "grbInformacoesDoCliente";
            this.grbInformacoesDoCliente.Size = new System.Drawing.Size(364, 114);
            this.grbInformacoesDoCliente.TabIndex = 84;
            this.grbInformacoesDoCliente.TabStop = false;
            this.grbInformacoesDoCliente.Text = "Informações do Cliente";
            // 
            // txtProcurarCliente
            // 
            this.txtProcurarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcurarCliente.Location = new System.Drawing.Point(292, 24);
            this.txtProcurarCliente.Name = "txtProcurarCliente";
            this.txtProcurarCliente.Size = new System.Drawing.Size(69, 24);
            this.txtProcurarCliente.TabIndex = 91;
            this.txtProcurarCliente.Text = "Procurar";
            this.txtProcurarCliente.UseVisualStyleBackColor = true;
            this.txtProcurarCliente.Click += new System.EventHandler(this.txtProcurarCliente_Click);
            // 
            // txtDn
            // 
            this.txtDn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDn.Location = new System.Drawing.Point(256, 81);
            this.txtDn.Name = "txtDn";
            this.txtDn.Size = new System.Drawing.Size(105, 22);
            this.txtDn.TabIndex = 90;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(219, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 16);
            this.label10.TabIndex = 89;
            this.label10.Text = "DN:*";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(77, 83);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(136, 22);
            this.txtTelefone.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 87;
            this.label3.Text = "Telefone:*";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(82, 53);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(279, 22);
            this.txtEndereco.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 85;
            this.label2.Text = "Endereço:*";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(60, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(226, 22);
            this.txtNome.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 83;
            this.label1.Text = "Nome:*";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(281, 504);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 33);
            this.btnCancelar.TabIndex = 93;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(175, 504);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 33);
            this.btnSalvar.TabIndex = 92;
            this.btnSalvar.Text = "Registrar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::View.Properties.Resources.SuaLogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(266, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 110);
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // gpbObs
            // 
            this.gpbObs.Controls.Add(this.txtObs);
            this.gpbObs.Location = new System.Drawing.Point(12, 320);
            this.gpbObs.Name = "gpbObs";
            this.gpbObs.Size = new System.Drawing.Size(369, 172);
            this.gpbObs.TabIndex = 94;
            this.gpbObs.TabStop = false;
            this.gpbObs.Text = "Observações da Consulta";
            this.gpbObs.Visible = false;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(9, 17);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(355, 149);
            this.txtObs.TabIndex = 0;
            this.txtObs.Text = "";
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Horários Disponíveis*";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // lblCampoObrigatorio
            // 
            this.lblCampoObrigatorio.AutoSize = true;
            this.lblCampoObrigatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampoObrigatorio.Location = new System.Drawing.Point(20, 87);
            this.lblCampoObrigatorio.Name = "lblCampoObrigatorio";
            this.lblCampoObrigatorio.Size = new System.Drawing.Size(177, 16);
            this.lblCampoObrigatorio.TabIndex = 95;
            this.lblCampoObrigatorio.Text = "* = Campos Obrigatórios";
            // 
            // FrmCadastroAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 549);
            this.Controls.Add(this.lblCampoObrigatorio);
            this.Controls.Add(this.grbServico);
            this.Controls.Add(this.gpbAgendar);
            this.Controls.Add(this.gpbObs);
            this.Controls.Add(this.grbInformacoesDoCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNovo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmCadastroAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tec Clinic: Novo Agendamento";
            this.grbServico.ResumeLayout(false);
            this.grbServico.PerformLayout();
            this.gpbAgendar.ResumeLayout(false);
            this.gpbAgendar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).EndInit();
            this.grbInformacoesDoCliente.ResumeLayout(false);
            this.grbInformacoesDoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbObs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNovo;
        private System.Windows.Forms.DateTimePicker dtpDataAgendamento;
        private System.Windows.Forms.GroupBox gpbAgendar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox grbServico;
        private System.Windows.Forms.Button txtProcurarServico;
        private System.Windows.Forms.TextBox txtNomeServico;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grbInformacoesDoCliente;
        private System.Windows.Forms.Button txtProcurarCliente;
        private System.Windows.Forms.DateTimePicker txtDn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorServico;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvHorario;
        private System.Windows.Forms.Button btnProcurarHorario;
        private System.Windows.Forms.GroupBox gpbObs;
        private System.Windows.Forms.RichTextBox txtObs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClinico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.Label lblCampoObrigatorio;
    }
}