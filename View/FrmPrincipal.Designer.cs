namespace View
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.lblStatusLogin = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarTemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarListaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aniversariantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovoToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarListaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.horárioDeAtendimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovoToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarListaToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasFinalizadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarListaToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarListaToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblDataHora);
            this.panel1.Controls.Add(this.lblStatusLogin);
            this.panel1.Location = new System.Drawing.Point(0, 473);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 19);
            this.panel1.TabIndex = 1;
            // 
            // lblDataHora
            // 
            this.lblDataHora.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDataHora.Location = new System.Drawing.Point(494, 1);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(110, 15);
            this.lblDataHora.TabIndex = 1;
            this.lblDataHora.Text = "00/00/0000 00:00:00";
            // 
            // lblStatusLogin
            // 
            this.lblStatusLogin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStatusLogin.AutoSize = true;
            this.lblStatusLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatusLogin.Location = new System.Drawing.Point(3, 1);
            this.lblStatusLogin.Name = "lblStatusLogin";
            this.lblStatusLogin.Size = new System.Drawing.Size(51, 15);
            this.lblStatusLogin.TabIndex = 0;
            this.lblStatusLogin.Text = "Nivel: ID";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administradorToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.serviçosToolStripMenuItem,
            this.agendamentoToolStripMenuItem,
            this.ticketToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(607, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovoToolStripMenuItem,
            this.gerenciarTemaToolStripMenuItem});
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.administradorToolStripMenuItem.Text = "Administrador";
            // 
            // cadastrarNovoToolStripMenuItem
            // 
            this.cadastrarNovoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovoToolStripMenuItem1,
            this.consultarListaToolStripMenuItem});
            this.cadastrarNovoToolStripMenuItem.Name = "cadastrarNovoToolStripMenuItem";
            this.cadastrarNovoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarNovoToolStripMenuItem.Text = "Logins";
            // 
            // cadastrarNovoToolStripMenuItem1
            // 
            this.cadastrarNovoToolStripMenuItem1.Image = global::View.Properties.Resources.WhatsApp_Image_2021_04_01_at_00_19_42;
            this.cadastrarNovoToolStripMenuItem1.Name = "cadastrarNovoToolStripMenuItem1";
            this.cadastrarNovoToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.cadastrarNovoToolStripMenuItem1.Text = "Cadastrar Novo";
            this.cadastrarNovoToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarNovoToolStripMenuItem1_Click);
            // 
            // consultarListaToolStripMenuItem
            // 
            this.consultarListaToolStripMenuItem.Image = global::View.Properties.Resources.WhatsApp_Image_2021_04_01_at_00_17_48;
            this.consultarListaToolStripMenuItem.Name = "consultarListaToolStripMenuItem";
            this.consultarListaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.consultarListaToolStripMenuItem.Text = "Consultar Lista";
            this.consultarListaToolStripMenuItem.Click += new System.EventHandler(this.consultarListaToolStripMenuItem_Click);
            // 
            // gerenciarTemaToolStripMenuItem
            // 
            this.gerenciarTemaToolStripMenuItem.Name = "gerenciarTemaToolStripMenuItem";
            this.gerenciarTemaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gerenciarTemaToolStripMenuItem.Text = "Gerenciar Tema";
            this.gerenciarTemaToolStripMenuItem.Visible = false;
            this.gerenciarTemaToolStripMenuItem.Click += new System.EventHandler(this.gerenciarTemaToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovoToolStripMenuItem2,
            this.consultarListaToolStripMenuItem1,
            this.aniversariantesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // cadastrarNovoToolStripMenuItem2
            // 
            this.cadastrarNovoToolStripMenuItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cadastrarNovoToolStripMenuItem2.Image = global::View.Properties.Resources.WhatsApp_Image_2021_04_01_at_00_19_42;
            this.cadastrarNovoToolStripMenuItem2.Name = "cadastrarNovoToolStripMenuItem2";
            this.cadastrarNovoToolStripMenuItem2.Size = new System.Drawing.Size(156, 22);
            this.cadastrarNovoToolStripMenuItem2.Text = "Cadastrar Novo";
            this.cadastrarNovoToolStripMenuItem2.Click += new System.EventHandler(this.cadastrarNovoToolStripMenuItem2_Click);
            // 
            // consultarListaToolStripMenuItem1
            // 
            this.consultarListaToolStripMenuItem1.Image = global::View.Properties.Resources.WhatsApp_Image_2021_04_01_at_00_17_48;
            this.consultarListaToolStripMenuItem1.Name = "consultarListaToolStripMenuItem1";
            this.consultarListaToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.consultarListaToolStripMenuItem1.Text = "Consultar Lista";
            this.consultarListaToolStripMenuItem1.Click += new System.EventHandler(this.consultarListaToolStripMenuItem1_Click);
            // 
            // aniversariantesToolStripMenuItem
            // 
            this.aniversariantesToolStripMenuItem.Image = global::View.Properties.Resources.birthday_cake;
            this.aniversariantesToolStripMenuItem.Name = "aniversariantesToolStripMenuItem";
            this.aniversariantesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.aniversariantesToolStripMenuItem.Text = "Aniversariantes";
            this.aniversariantesToolStripMenuItem.Click += new System.EventHandler(this.aniversariantesToolStripMenuItem_Click);
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviçosToolStripMenuItem1,
            this.horárioDeAtendimentoToolStripMenuItem,
            this.financeiroToolStripMenuItem});
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.serviçosToolStripMenuItem.Text = "Gerenciamento";
            // 
            // serviçosToolStripMenuItem1
            // 
            this.serviçosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovoToolStripMenuItem3,
            this.consultarListaToolStripMenuItem2});
            this.serviçosToolStripMenuItem1.Image = global::View.Properties.Resources.historia_clinica;
            this.serviçosToolStripMenuItem1.Name = "serviçosToolStripMenuItem1";
            this.serviçosToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.serviçosToolStripMenuItem1.Text = "Serviços";
            // 
            // cadastrarNovoToolStripMenuItem3
            // 
            this.cadastrarNovoToolStripMenuItem3.Image = global::View.Properties.Resources.WhatsApp_Image_2021_04_01_at_00_19_42;
            this.cadastrarNovoToolStripMenuItem3.Name = "cadastrarNovoToolStripMenuItem3";
            this.cadastrarNovoToolStripMenuItem3.Size = new System.Drawing.Size(156, 22);
            this.cadastrarNovoToolStripMenuItem3.Text = "Cadastrar Novo";
            this.cadastrarNovoToolStripMenuItem3.Click += new System.EventHandler(this.cadastrarNovoToolStripMenuItem3_Click);
            // 
            // consultarListaToolStripMenuItem2
            // 
            this.consultarListaToolStripMenuItem2.Image = global::View.Properties.Resources.WhatsApp_Image_2021_04_01_at_00_17_48;
            this.consultarListaToolStripMenuItem2.Name = "consultarListaToolStripMenuItem2";
            this.consultarListaToolStripMenuItem2.Size = new System.Drawing.Size(156, 22);
            this.consultarListaToolStripMenuItem2.Text = "Consultar Lista";
            this.consultarListaToolStripMenuItem2.Click += new System.EventHandler(this.consultarListaToolStripMenuItem2_Click_1);
            // 
            // horárioDeAtendimentoToolStripMenuItem
            // 
            this.horárioDeAtendimentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovoToolStripMenuItem4,
            this.consultarListaToolStripMenuItem4});
            this.horárioDeAtendimentoToolStripMenuItem.Image = global::View.Properties.Resources.timing;
            this.horárioDeAtendimentoToolStripMenuItem.Name = "horárioDeAtendimentoToolStripMenuItem";
            this.horárioDeAtendimentoToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.horárioDeAtendimentoToolStripMenuItem.Text = "Horário de Atendimento";
            // 
            // cadastrarNovoToolStripMenuItem4
            // 
            this.cadastrarNovoToolStripMenuItem4.Image = global::View.Properties.Resources.WhatsApp_Image_2021_04_01_at_00_19_42;
            this.cadastrarNovoToolStripMenuItem4.Name = "cadastrarNovoToolStripMenuItem4";
            this.cadastrarNovoToolStripMenuItem4.Size = new System.Drawing.Size(156, 22);
            this.cadastrarNovoToolStripMenuItem4.Text = "Cadastrar Novo";
            this.cadastrarNovoToolStripMenuItem4.Click += new System.EventHandler(this.cadastrarNovoToolStripMenuItem4_Click);
            // 
            // consultarListaToolStripMenuItem4
            // 
            this.consultarListaToolStripMenuItem4.Image = global::View.Properties.Resources.WhatsApp_Image_2021_04_01_at_00_17_48;
            this.consultarListaToolStripMenuItem4.Name = "consultarListaToolStripMenuItem4";
            this.consultarListaToolStripMenuItem4.Size = new System.Drawing.Size(156, 22);
            this.consultarListaToolStripMenuItem4.Text = "Consultar Lista";
            this.consultarListaToolStripMenuItem4.Click += new System.EventHandler(this.consultarListaToolStripMenuItem4_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasFinalizadasToolStripMenuItem});
            this.financeiroToolStripMenuItem.Image = global::View.Properties.Resources.prancheta;
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // consultasFinalizadasToolStripMenuItem
            // 
            this.consultasFinalizadasToolStripMenuItem.Image = global::View.Properties.Resources.WhatsApp_Image_2021_04_01_at_00_17_48;
            this.consultasFinalizadasToolStripMenuItem.Name = "consultasFinalizadasToolStripMenuItem";
            this.consultasFinalizadasToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.consultasFinalizadasToolStripMenuItem.Text = "Consultas Finalizadas";
            this.consultasFinalizadasToolStripMenuItem.Click += new System.EventHandler(this.consultasFinalizadasToolStripMenuItem_Click);
            // 
            // agendamentoToolStripMenuItem
            // 
            this.agendamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.consultarListaToolStripMenuItem3});
            this.agendamentoToolStripMenuItem.Name = "agendamentoToolStripMenuItem";
            this.agendamentoToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.agendamentoToolStripMenuItem.Text = "Agendamento";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Image = global::View.Properties.Resources.WhatsApp_Image_2021_04_01_at_00_19_42;
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // consultarListaToolStripMenuItem3
            // 
            this.consultarListaToolStripMenuItem3.Image = global::View.Properties.Resources.WhatsApp_Image_2021_04_01_at_00_17_48;
            this.consultarListaToolStripMenuItem3.Name = "consultarListaToolStripMenuItem3";
            this.consultarListaToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.consultarListaToolStripMenuItem3.Text = "Consultar Lista";
            this.consultarListaToolStripMenuItem3.Click += new System.EventHandler(this.consultarListaToolStripMenuItem3_Click);
            // 
            // ticketToolStripMenuItem
            // 
            this.ticketToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarListaToolStripMenuItem5});
            this.ticketToolStripMenuItem.Name = "ticketToolStripMenuItem";
            this.ticketToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ticketToolStripMenuItem.Text = "Ticket";
            // 
            // consultarListaToolStripMenuItem5
            // 
            this.consultarListaToolStripMenuItem5.Image = global::View.Properties.Resources.WhatsApp_Image_2021_04_01_at_00_17_48;
            this.consultarListaToolStripMenuItem5.Name = "consultarListaToolStripMenuItem5";
            this.consultarListaToolStripMenuItem5.Size = new System.Drawing.Size(152, 22);
            this.consultarListaToolStripMenuItem5.Text = "Consultar Lista";
            this.consultarListaToolStripMenuItem5.Click += new System.EventHandler(this.consultarListaToolStripMenuItem5_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(607, 493);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(623, 532);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tec Clinic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStatusLogin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarTemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem consultarListaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarListaToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem horárioDeAtendimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarListaToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasFinalizadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarListaToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem aniversariantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem consultarListaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoToolStripMenuItem4;
    }
}