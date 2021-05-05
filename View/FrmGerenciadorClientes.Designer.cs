namespace View
{
    partial class FrmGerenciadorClientes
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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExibidosTotal = new System.Windows.Forms.Label();
            this.cbxFiltro = new System.Windows.Forms.ComboBox();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvCadastrados = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filhos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueixaPrincipalObjetivoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HistoriaMolestia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TratamentosAnteriores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TratamentosAnterioresQuais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrauSatisfacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AntecedentesAlergicos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAntecedentesAlergicos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDiagnosticoDePsoriaseOuHanseniase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionamentoIntestinalRegular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFuncionamentoIntestinalRegular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PraticaAtividadeFisica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPraticaAtividadeFisica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TemHabitoDeSeExporAoSol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTemHabitoDeSeExporAoSol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FazAlgumTratamentoMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFazAlgumTratamentoMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsaAlgumTipoDeMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUsaAlgumTipoDeMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EGestanteOuEstaAmamentando = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEGestanteOuEstaAmamentando = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CicloMenstrualRegular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCicloMenstrualRegular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PortadorDeMarcaPasso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPortadorDeMarcaPasso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TemAlgumProblemaCardiovascular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTemAlgumProblemaCardiovascular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PresencaDeProteseMetalica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPresencaDeProteseMetalica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PortadorDeEpilepsia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPortadorDeEpilepsia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TemDiabetesOuHipertesao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTemDiabetesOuHipertesao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngereBastanteAgua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIngereBastanteAgua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCancer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trombose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTrombose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastrados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(689, 25);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 29);
            this.btnPesquisar.TabIndex = 43;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(682, 441);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 33);
            this.panel1.TabIndex = 53;
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(689, 441);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(100, 33);
            this.btnFechar.TabIndex = 49;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(173, 9);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisar.TabIndex = 52;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Filtro";
            // 
            // lblExibidosTotal
            // 
            this.lblExibidosTotal.AutoSize = true;
            this.lblExibidosTotal.Location = new System.Drawing.Point(9, 438);
            this.lblExibidosTotal.Name = "lblExibidosTotal";
            this.lblExibidosTotal.Size = new System.Drawing.Size(81, 13);
            this.lblExibidosTotal.TabIndex = 50;
            this.lblExibidosTotal.Text = "Exibidos total: 0";
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltro.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFiltro.FormattingEnabled = true;
            this.cbxFiltro.Items.AddRange(new object[] {
            "CODIGO",
            "NOME"});
            this.cbxFiltro.Location = new System.Drawing.Point(12, 25);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(158, 31);
            this.cbxFiltro.TabIndex = 41;
            // 
            // txtProcurar
            // 
            this.txtProcurar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcurar.Location = new System.Drawing.Point(176, 25);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(506, 29);
            this.txtProcurar.TabIndex = 42;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(258, 441);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 33);
            this.btnConsultar.TabIndex = 45;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(364, 441);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 33);
            this.btnCadastrar.TabIndex = 46;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(576, 441);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(100, 33);
            this.btnDeletar.TabIndex = 48;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(470, 441);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 33);
            this.btnEditar.TabIndex = 47;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvCadastrados
            // 
            this.dgvCadastrados.AllowUserToAddRows = false;
            this.dgvCadastrados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCadastrados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCadastrados.BackgroundColor = System.Drawing.Color.White;
            this.dgvCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastrados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Endereco,
            this.Bairro,
            this.Cidade,
            this.Cep,
            this.Email,
            this.Telefone,
            this.Dn,
            this.Idade,
            this.Sexo,
            this.EstadoCivil,
            this.Filhos,
            this.Profissao,
            this.QueixaPrincipalObjetivoCliente,
            this.HistoriaMolestia,
            this.TratamentosAnteriores,
            this.TratamentosAnterioresQuais,
            this.GrauSatisfacao,
            this.AntecedentesAlergicos,
            this.txtAntecedentesAlergicos,
            this.txtDiagnosticoDePsoriaseOuHanseniase,
            this.FuncionamentoIntestinalRegular,
            this.txtFuncionamentoIntestinalRegular,
            this.PraticaAtividadeFisica,
            this.txtPraticaAtividadeFisica,
            this.TemHabitoDeSeExporAoSol,
            this.txtTemHabitoDeSeExporAoSol,
            this.FazAlgumTratamentoMedico,
            this.txtFazAlgumTratamentoMedico,
            this.UsaAlgumTipoDeMedicamento,
            this.txtUsaAlgumTipoDeMedicamento,
            this.EGestanteOuEstaAmamentando,
            this.txtEGestanteOuEstaAmamentando,
            this.CicloMenstrualRegular,
            this.txtCicloMenstrualRegular,
            this.PortadorDeMarcaPasso,
            this.txtPortadorDeMarcaPasso,
            this.TemAlgumProblemaCardiovascular,
            this.txtTemAlgumProblemaCardiovascular,
            this.PresencaDeProteseMetalica,
            this.txtPresencaDeProteseMetalica,
            this.PortadorDeEpilepsia,
            this.txtPortadorDeEpilepsia,
            this.TemDiabetesOuHipertesao,
            this.txtTemDiabetesOuHipertesao,
            this.IngereBastanteAgua,
            this.txtIngereBastanteAgua,
            this.Cancer,
            this.txtCancer,
            this.Trombose,
            this.txtTrombose});
            this.dgvCadastrados.Location = new System.Drawing.Point(12, 65);
            this.dgvCadastrados.Name = "dgvCadastrados";
            this.dgvCadastrados.ReadOnly = true;
            this.dgvCadastrados.RowHeadersVisible = false;
            this.dgvCadastrados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCadastrados.Size = new System.Drawing.Size(777, 370);
            this.dgvCadastrados.TabIndex = 44;
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
            // Bairro
            // 
            this.Bairro.DataPropertyName = "Bairro";
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            // 
            // Cidade
            // 
            this.Cidade.DataPropertyName = "Cidade";
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            // 
            // Cep
            // 
            this.Cep.DataPropertyName = "Cep";
            this.Cep.HeaderText = "Cep";
            this.Cep.Name = "Cep";
            this.Cep.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
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
            this.Dn.Visible = false;
            // 
            // Idade
            // 
            this.Idade.DataPropertyName = "Idade";
            this.Idade.HeaderText = "Idade";
            this.Idade.Name = "Idade";
            this.Idade.ReadOnly = true;
            this.Idade.Visible = false;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Visible = false;
            // 
            // EstadoCivil
            // 
            this.EstadoCivil.DataPropertyName = "EstadoCivil";
            this.EstadoCivil.HeaderText = "Estado Civil";
            this.EstadoCivil.Name = "EstadoCivil";
            this.EstadoCivil.ReadOnly = true;
            this.EstadoCivil.Visible = false;
            // 
            // Filhos
            // 
            this.Filhos.DataPropertyName = "Filhos";
            this.Filhos.HeaderText = "Filhos";
            this.Filhos.Name = "Filhos";
            this.Filhos.ReadOnly = true;
            this.Filhos.Visible = false;
            // 
            // Profissao
            // 
            this.Profissao.DataPropertyName = "Profissao";
            this.Profissao.HeaderText = "Profissão";
            this.Profissao.Name = "Profissao";
            this.Profissao.ReadOnly = true;
            this.Profissao.Visible = false;
            // 
            // QueixaPrincipalObjetivoCliente
            // 
            this.QueixaPrincipalObjetivoCliente.DataPropertyName = "QueixaPrincipalObjetivoCliente";
            this.QueixaPrincipalObjetivoCliente.HeaderText = "Queixa Principal e Objetivo do Cliente";
            this.QueixaPrincipalObjetivoCliente.Name = "QueixaPrincipalObjetivoCliente";
            this.QueixaPrincipalObjetivoCliente.ReadOnly = true;
            this.QueixaPrincipalObjetivoCliente.Visible = false;
            // 
            // HistoriaMolestia
            // 
            this.HistoriaMolestia.DataPropertyName = "HistoriaMolestia";
            this.HistoriaMolestia.HeaderText = "História da Moléstia";
            this.HistoriaMolestia.Name = "HistoriaMolestia";
            this.HistoriaMolestia.ReadOnly = true;
            this.HistoriaMolestia.Visible = false;
            // 
            // TratamentosAnteriores
            // 
            this.TratamentosAnteriores.DataPropertyName = "TratamentosAnteriores";
            this.TratamentosAnteriores.HeaderText = "Tratamentos Anteriores";
            this.TratamentosAnteriores.Name = "TratamentosAnteriores";
            this.TratamentosAnteriores.ReadOnly = true;
            this.TratamentosAnteriores.Visible = false;
            // 
            // TratamentosAnterioresQuais
            // 
            this.TratamentosAnterioresQuais.DataPropertyName = "TratamentosAnterioresQuais";
            this.TratamentosAnterioresQuais.HeaderText = "TratamentosAnterioresQuais";
            this.TratamentosAnterioresQuais.Name = "TratamentosAnterioresQuais";
            this.TratamentosAnterioresQuais.ReadOnly = true;
            this.TratamentosAnterioresQuais.Visible = false;
            // 
            // GrauSatisfacao
            // 
            this.GrauSatisfacao.DataPropertyName = "GrauSatisfacao";
            this.GrauSatisfacao.HeaderText = "GrauSatisfacao";
            this.GrauSatisfacao.Name = "GrauSatisfacao";
            this.GrauSatisfacao.ReadOnly = true;
            this.GrauSatisfacao.Visible = false;
            // 
            // AntecedentesAlergicos
            // 
            this.AntecedentesAlergicos.DataPropertyName = "AntecedentesAlergicos";
            this.AntecedentesAlergicos.HeaderText = "AntecedentesAlergicos";
            this.AntecedentesAlergicos.Name = "AntecedentesAlergicos";
            this.AntecedentesAlergicos.ReadOnly = true;
            this.AntecedentesAlergicos.Visible = false;
            // 
            // txtAntecedentesAlergicos
            // 
            this.txtAntecedentesAlergicos.DataPropertyName = "txtAntecedentesAlergicos";
            this.txtAntecedentesAlergicos.HeaderText = "txtAntecedentesAlergicos";
            this.txtAntecedentesAlergicos.Name = "txtAntecedentesAlergicos";
            this.txtAntecedentesAlergicos.ReadOnly = true;
            this.txtAntecedentesAlergicos.Visible = false;
            // 
            // txtDiagnosticoDePsoriaseOuHanseniase
            // 
            this.txtDiagnosticoDePsoriaseOuHanseniase.DataPropertyName = "txtDiagnosticoDePsoriaseOuHanseniase";
            this.txtDiagnosticoDePsoriaseOuHanseniase.HeaderText = "txtDiagnosticoDePsoriaseOuHanseniase";
            this.txtDiagnosticoDePsoriaseOuHanseniase.Name = "txtDiagnosticoDePsoriaseOuHanseniase";
            this.txtDiagnosticoDePsoriaseOuHanseniase.ReadOnly = true;
            this.txtDiagnosticoDePsoriaseOuHanseniase.Visible = false;
            // 
            // FuncionamentoIntestinalRegular
            // 
            this.FuncionamentoIntestinalRegular.DataPropertyName = "FuncionamentoIntestinalRegular";
            this.FuncionamentoIntestinalRegular.HeaderText = "FuncionamentoIntestinalRegular";
            this.FuncionamentoIntestinalRegular.Name = "FuncionamentoIntestinalRegular";
            this.FuncionamentoIntestinalRegular.ReadOnly = true;
            this.FuncionamentoIntestinalRegular.Visible = false;
            // 
            // txtFuncionamentoIntestinalRegular
            // 
            this.txtFuncionamentoIntestinalRegular.DataPropertyName = "txtFuncionamentoIntestinalRegular";
            this.txtFuncionamentoIntestinalRegular.HeaderText = "txtFuncionamentoIntestinalRegular";
            this.txtFuncionamentoIntestinalRegular.Name = "txtFuncionamentoIntestinalRegular";
            this.txtFuncionamentoIntestinalRegular.ReadOnly = true;
            this.txtFuncionamentoIntestinalRegular.Visible = false;
            // 
            // PraticaAtividadeFisica
            // 
            this.PraticaAtividadeFisica.DataPropertyName = "PraticaAtividadeFisica";
            this.PraticaAtividadeFisica.HeaderText = "PraticaAtividadeFisica";
            this.PraticaAtividadeFisica.Name = "PraticaAtividadeFisica";
            this.PraticaAtividadeFisica.ReadOnly = true;
            this.PraticaAtividadeFisica.Visible = false;
            // 
            // txtPraticaAtividadeFisica
            // 
            this.txtPraticaAtividadeFisica.DataPropertyName = "txtPraticaAtividadeFisica";
            this.txtPraticaAtividadeFisica.HeaderText = "txtPraticaAtividadeFisica";
            this.txtPraticaAtividadeFisica.Name = "txtPraticaAtividadeFisica";
            this.txtPraticaAtividadeFisica.ReadOnly = true;
            this.txtPraticaAtividadeFisica.Visible = false;
            // 
            // TemHabitoDeSeExporAoSol
            // 
            this.TemHabitoDeSeExporAoSol.DataPropertyName = "TemHabitoDeSeExporAoSol";
            this.TemHabitoDeSeExporAoSol.HeaderText = "TemHabitoDeSeExporAoSol";
            this.TemHabitoDeSeExporAoSol.Name = "TemHabitoDeSeExporAoSol";
            this.TemHabitoDeSeExporAoSol.ReadOnly = true;
            this.TemHabitoDeSeExporAoSol.Visible = false;
            // 
            // txtTemHabitoDeSeExporAoSol
            // 
            this.txtTemHabitoDeSeExporAoSol.DataPropertyName = "txtTemHabitoDeSeExporAoSol";
            this.txtTemHabitoDeSeExporAoSol.HeaderText = "txtTemHabitoDeSeExporAoSol";
            this.txtTemHabitoDeSeExporAoSol.Name = "txtTemHabitoDeSeExporAoSol";
            this.txtTemHabitoDeSeExporAoSol.ReadOnly = true;
            this.txtTemHabitoDeSeExporAoSol.Visible = false;
            // 
            // FazAlgumTratamentoMedico
            // 
            this.FazAlgumTratamentoMedico.DataPropertyName = "FazAlgumTratamentoMedico";
            this.FazAlgumTratamentoMedico.HeaderText = "FazAlgumTratamentoMedico";
            this.FazAlgumTratamentoMedico.Name = "FazAlgumTratamentoMedico";
            this.FazAlgumTratamentoMedico.ReadOnly = true;
            this.FazAlgumTratamentoMedico.Visible = false;
            // 
            // txtFazAlgumTratamentoMedico
            // 
            this.txtFazAlgumTratamentoMedico.DataPropertyName = "txtFazAlgumTratamentoMedico";
            this.txtFazAlgumTratamentoMedico.HeaderText = "txtFazAlgumTratamentoMedico";
            this.txtFazAlgumTratamentoMedico.Name = "txtFazAlgumTratamentoMedico";
            this.txtFazAlgumTratamentoMedico.ReadOnly = true;
            this.txtFazAlgumTratamentoMedico.Visible = false;
            // 
            // UsaAlgumTipoDeMedicamento
            // 
            this.UsaAlgumTipoDeMedicamento.DataPropertyName = "UsaAlgumTipoDeMedicamento";
            this.UsaAlgumTipoDeMedicamento.HeaderText = "UsaAlgumTipoDeMedicamento";
            this.UsaAlgumTipoDeMedicamento.Name = "UsaAlgumTipoDeMedicamento";
            this.UsaAlgumTipoDeMedicamento.ReadOnly = true;
            this.UsaAlgumTipoDeMedicamento.Visible = false;
            // 
            // txtUsaAlgumTipoDeMedicamento
            // 
            this.txtUsaAlgumTipoDeMedicamento.DataPropertyName = "txtUsaAlgumTipoDeMedicamento";
            this.txtUsaAlgumTipoDeMedicamento.HeaderText = "txtUsaAlgumTipoDeMedicamento";
            this.txtUsaAlgumTipoDeMedicamento.Name = "txtUsaAlgumTipoDeMedicamento";
            this.txtUsaAlgumTipoDeMedicamento.ReadOnly = true;
            this.txtUsaAlgumTipoDeMedicamento.Visible = false;
            // 
            // EGestanteOuEstaAmamentando
            // 
            this.EGestanteOuEstaAmamentando.DataPropertyName = "EGestanteOuEstaAmamentando";
            this.EGestanteOuEstaAmamentando.HeaderText = "EGestanteOuEstaAmamentando";
            this.EGestanteOuEstaAmamentando.Name = "EGestanteOuEstaAmamentando";
            this.EGestanteOuEstaAmamentando.ReadOnly = true;
            this.EGestanteOuEstaAmamentando.Visible = false;
            // 
            // txtEGestanteOuEstaAmamentando
            // 
            this.txtEGestanteOuEstaAmamentando.DataPropertyName = "txtEGestanteOuEstaAmamentando";
            this.txtEGestanteOuEstaAmamentando.HeaderText = "txtEGestanteOuEstaAmamentando";
            this.txtEGestanteOuEstaAmamentando.Name = "txtEGestanteOuEstaAmamentando";
            this.txtEGestanteOuEstaAmamentando.ReadOnly = true;
            this.txtEGestanteOuEstaAmamentando.Visible = false;
            // 
            // CicloMenstrualRegular
            // 
            this.CicloMenstrualRegular.DataPropertyName = "CicloMenstrualRegular";
            this.CicloMenstrualRegular.HeaderText = "CicloMenstrualRegular";
            this.CicloMenstrualRegular.Name = "CicloMenstrualRegular";
            this.CicloMenstrualRegular.ReadOnly = true;
            this.CicloMenstrualRegular.Visible = false;
            // 
            // txtCicloMenstrualRegular
            // 
            this.txtCicloMenstrualRegular.DataPropertyName = "txtCicloMenstrualRegular";
            this.txtCicloMenstrualRegular.HeaderText = "txtCicloMenstrualRegular";
            this.txtCicloMenstrualRegular.Name = "txtCicloMenstrualRegular";
            this.txtCicloMenstrualRegular.ReadOnly = true;
            this.txtCicloMenstrualRegular.Visible = false;
            // 
            // PortadorDeMarcaPasso
            // 
            this.PortadorDeMarcaPasso.DataPropertyName = "PortadorDeMarcaPasso";
            this.PortadorDeMarcaPasso.HeaderText = "PortadorDeMarcaPasso";
            this.PortadorDeMarcaPasso.Name = "PortadorDeMarcaPasso";
            this.PortadorDeMarcaPasso.ReadOnly = true;
            this.PortadorDeMarcaPasso.Visible = false;
            // 
            // txtPortadorDeMarcaPasso
            // 
            this.txtPortadorDeMarcaPasso.DataPropertyName = "txtPortadorDeMarcaPasso";
            this.txtPortadorDeMarcaPasso.HeaderText = "txtPortadorDeMarcaPasso";
            this.txtPortadorDeMarcaPasso.Name = "txtPortadorDeMarcaPasso";
            this.txtPortadorDeMarcaPasso.ReadOnly = true;
            this.txtPortadorDeMarcaPasso.Visible = false;
            // 
            // TemAlgumProblemaCardiovascular
            // 
            this.TemAlgumProblemaCardiovascular.DataPropertyName = "TemAlgumProblemaCardiovascular";
            this.TemAlgumProblemaCardiovascular.HeaderText = "TemAlgumProblemaCardiovascular";
            this.TemAlgumProblemaCardiovascular.Name = "TemAlgumProblemaCardiovascular";
            this.TemAlgumProblemaCardiovascular.ReadOnly = true;
            this.TemAlgumProblemaCardiovascular.Visible = false;
            // 
            // txtTemAlgumProblemaCardiovascular
            // 
            this.txtTemAlgumProblemaCardiovascular.DataPropertyName = "txtTemAlgumProblemaCardiovascular";
            this.txtTemAlgumProblemaCardiovascular.HeaderText = "txtTemAlgumProblemaCardiovascular";
            this.txtTemAlgumProblemaCardiovascular.Name = "txtTemAlgumProblemaCardiovascular";
            this.txtTemAlgumProblemaCardiovascular.ReadOnly = true;
            this.txtTemAlgumProblemaCardiovascular.Visible = false;
            // 
            // PresencaDeProteseMetalica
            // 
            this.PresencaDeProteseMetalica.DataPropertyName = "PresencaDeProteseMetalica";
            this.PresencaDeProteseMetalica.HeaderText = "PresencaDeProteseMetalica";
            this.PresencaDeProteseMetalica.Name = "PresencaDeProteseMetalica";
            this.PresencaDeProteseMetalica.ReadOnly = true;
            this.PresencaDeProteseMetalica.Visible = false;
            // 
            // txtPresencaDeProteseMetalica
            // 
            this.txtPresencaDeProteseMetalica.DataPropertyName = "txtPresencaDeProteseMetalica";
            this.txtPresencaDeProteseMetalica.HeaderText = "txtPresencaDeProteseMetalica";
            this.txtPresencaDeProteseMetalica.Name = "txtPresencaDeProteseMetalica";
            this.txtPresencaDeProteseMetalica.ReadOnly = true;
            this.txtPresencaDeProteseMetalica.Visible = false;
            // 
            // PortadorDeEpilepsia
            // 
            this.PortadorDeEpilepsia.DataPropertyName = "PortadorDeEpilepsia";
            this.PortadorDeEpilepsia.HeaderText = "PortadorDeEpilepsia";
            this.PortadorDeEpilepsia.Name = "PortadorDeEpilepsia";
            this.PortadorDeEpilepsia.ReadOnly = true;
            this.PortadorDeEpilepsia.Visible = false;
            // 
            // txtPortadorDeEpilepsia
            // 
            this.txtPortadorDeEpilepsia.DataPropertyName = "txtPortadorDeEpilepsia";
            this.txtPortadorDeEpilepsia.HeaderText = "txtPortadorDeEpilepsia";
            this.txtPortadorDeEpilepsia.Name = "txtPortadorDeEpilepsia";
            this.txtPortadorDeEpilepsia.ReadOnly = true;
            this.txtPortadorDeEpilepsia.Visible = false;
            // 
            // TemDiabetesOuHipertesao
            // 
            this.TemDiabetesOuHipertesao.DataPropertyName = "TemDiabetesOuHipertesao";
            this.TemDiabetesOuHipertesao.HeaderText = "TemDiabetesOuHipertesao";
            this.TemDiabetesOuHipertesao.Name = "TemDiabetesOuHipertesao";
            this.TemDiabetesOuHipertesao.ReadOnly = true;
            this.TemDiabetesOuHipertesao.Visible = false;
            // 
            // txtTemDiabetesOuHipertesao
            // 
            this.txtTemDiabetesOuHipertesao.DataPropertyName = "txtTemDiabetesOuHipertesao";
            this.txtTemDiabetesOuHipertesao.HeaderText = "txtTemDiabetesOuHipertesao";
            this.txtTemDiabetesOuHipertesao.Name = "txtTemDiabetesOuHipertesao";
            this.txtTemDiabetesOuHipertesao.ReadOnly = true;
            this.txtTemDiabetesOuHipertesao.Visible = false;
            // 
            // IngereBastanteAgua
            // 
            this.IngereBastanteAgua.DataPropertyName = "IngereBastanteAgua";
            this.IngereBastanteAgua.HeaderText = "IngereBastanteAgua";
            this.IngereBastanteAgua.Name = "IngereBastanteAgua";
            this.IngereBastanteAgua.ReadOnly = true;
            this.IngereBastanteAgua.Visible = false;
            // 
            // txtIngereBastanteAgua
            // 
            this.txtIngereBastanteAgua.DataPropertyName = "txtIngereBastanteAgua";
            this.txtIngereBastanteAgua.HeaderText = "txtIngereBastanteAgua";
            this.txtIngereBastanteAgua.Name = "txtIngereBastanteAgua";
            this.txtIngereBastanteAgua.ReadOnly = true;
            this.txtIngereBastanteAgua.Visible = false;
            // 
            // Cancer
            // 
            this.Cancer.DataPropertyName = "Cancer";
            this.Cancer.HeaderText = "Cancer";
            this.Cancer.Name = "Cancer";
            this.Cancer.ReadOnly = true;
            this.Cancer.Visible = false;
            // 
            // txtCancer
            // 
            this.txtCancer.DataPropertyName = "txtCancer";
            this.txtCancer.HeaderText = "txtCancer";
            this.txtCancer.Name = "txtCancer";
            this.txtCancer.ReadOnly = true;
            this.txtCancer.Visible = false;
            // 
            // Trombose
            // 
            this.Trombose.DataPropertyName = "Trombose";
            this.Trombose.HeaderText = "Trombose";
            this.Trombose.Name = "Trombose";
            this.Trombose.ReadOnly = true;
            this.Trombose.Visible = false;
            // 
            // txtTrombose
            // 
            this.txtTrombose.DataPropertyName = "txtTrombose";
            this.txtTrombose.HeaderText = "txtTrombose";
            this.txtTrombose.Name = "txtTrombose";
            this.txtTrombose.ReadOnly = true;
            this.txtTrombose.Visible = false;
            // 
            // FrmGerenciadorClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 486);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblExibidosTotal);
            this.Controls.Add(this.cbxFiltro);
            this.Controls.Add(this.txtProcurar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvCadastrados);
            this.Name = "FrmGerenciadorClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGerenciadorClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastrados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExibidosTotal;
        private System.Windows.Forms.ComboBox cbxFiltro;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvCadastrados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filhos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueixaPrincipalObjetivoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoriaMolestia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TratamentosAnteriores;
        private System.Windows.Forms.DataGridViewTextBoxColumn TratamentosAnterioresQuais;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrauSatisfacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn AntecedentesAlergicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAntecedentesAlergicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDiagnosticoDePsoriaseOuHanseniase;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuncionamentoIntestinalRegular;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFuncionamentoIntestinalRegular;
        private System.Windows.Forms.DataGridViewTextBoxColumn PraticaAtividadeFisica;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPraticaAtividadeFisica;
        private System.Windows.Forms.DataGridViewTextBoxColumn TemHabitoDeSeExporAoSol;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTemHabitoDeSeExporAoSol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FazAlgumTratamentoMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFazAlgumTratamentoMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsaAlgumTipoDeMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtUsaAlgumTipoDeMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn EGestanteOuEstaAmamentando;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEGestanteOuEstaAmamentando;
        private System.Windows.Forms.DataGridViewTextBoxColumn CicloMenstrualRegular;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCicloMenstrualRegular;
        private System.Windows.Forms.DataGridViewTextBoxColumn PortadorDeMarcaPasso;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPortadorDeMarcaPasso;
        private System.Windows.Forms.DataGridViewTextBoxColumn TemAlgumProblemaCardiovascular;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTemAlgumProblemaCardiovascular;
        private System.Windows.Forms.DataGridViewTextBoxColumn PresencaDeProteseMetalica;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPresencaDeProteseMetalica;
        private System.Windows.Forms.DataGridViewTextBoxColumn PortadorDeEpilepsia;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPortadorDeEpilepsia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TemDiabetesOuHipertesao;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTemDiabetesOuHipertesao;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngereBastanteAgua;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIngereBastanteAgua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cancer;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCancer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trombose;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTrombose;
    }
}