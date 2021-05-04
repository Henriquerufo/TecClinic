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
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarListaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.testeToolStripMenuItem});
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
            this.cadastrarNovoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.cadastrarNovoToolStripMenuItem.Text = "Logins";
            // 
            // cadastrarNovoToolStripMenuItem1
            // 
            this.cadastrarNovoToolStripMenuItem1.Name = "cadastrarNovoToolStripMenuItem1";
            this.cadastrarNovoToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.cadastrarNovoToolStripMenuItem1.Text = "Cadastrar Novo";
            this.cadastrarNovoToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarNovoToolStripMenuItem1_Click);
            // 
            // consultarListaToolStripMenuItem
            // 
            this.consultarListaToolStripMenuItem.Name = "consultarListaToolStripMenuItem";
            this.consultarListaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.consultarListaToolStripMenuItem.Text = "Consultar Lista";
            this.consultarListaToolStripMenuItem.Click += new System.EventHandler(this.consultarListaToolStripMenuItem_Click);
            // 
            // gerenciarTemaToolStripMenuItem
            // 
            this.gerenciarTemaToolStripMenuItem.Name = "gerenciarTemaToolStripMenuItem";
            this.gerenciarTemaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.gerenciarTemaToolStripMenuItem.Text = "Gerenciar Tema";
            this.gerenciarTemaToolStripMenuItem.Click += new System.EventHandler(this.gerenciarTemaToolStripMenuItem_Click);
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovoToolStripMenuItem2,
            this.consultarListaToolStripMenuItem1});
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.testeToolStripMenuItem.Text = "Clientes";
            // 
            // cadastrarNovoToolStripMenuItem2
            // 
            this.cadastrarNovoToolStripMenuItem2.Name = "cadastrarNovoToolStripMenuItem2";
            this.cadastrarNovoToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.cadastrarNovoToolStripMenuItem2.Text = "Cadastrar Novo";
            this.cadastrarNovoToolStripMenuItem2.Click += new System.EventHandler(this.cadastrarNovoToolStripMenuItem2_Click);
            // 
            // consultarListaToolStripMenuItem1
            // 
            this.consultarListaToolStripMenuItem1.Name = "consultarListaToolStripMenuItem1";
            this.consultarListaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.consultarListaToolStripMenuItem1.Text = "Consultar Lista";
            this.consultarListaToolStripMenuItem1.Click += new System.EventHandler(this.consultarListaToolStripMenuItem1_Click);
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
            this.Text = "Tec Sistemas";
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
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem consultarListaToolStripMenuItem1;
    }
}