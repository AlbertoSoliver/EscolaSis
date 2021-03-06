﻿namespace EscolaSis.Forms.Responsavel
{
    partial class ResponsavelCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResponsavelCadastro));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbxListaResponsavel = new System.Windows.Forms.ListBox();
            this.responsavelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.txbPesquisarTutor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.responsavelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGravar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovoAluno = new System.Windows.Forms.ToolStripButton();
            this.btnExcluirResposavel = new System.Windows.Forms.ToolStripButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbCEP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbBairro = new System.Windows.Forms.TextBox();
            this.lblbairro = new System.Windows.Forms.Label();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbtFemin = new System.Windows.Forms.RadioButton();
            this.rbtMasc = new System.Windows.Forms.RadioButton();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbNumRG = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbDataNascim = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNomeTutor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCodigoCadastro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgvAlunosDoTutor = new System.Windows.Forms.DataGridView();
            this.alunoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relacaoAlunoDescrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsavelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txbNomeRespAluno = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunosDoTutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbxListaResponsavel);
            this.panel1.Controls.Add(this.txbPesquisarTutor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(242, 518);
            this.panel1.TabIndex = 0;
            // 
            // lbxListaResponsavel
            // 
            this.lbxListaResponsavel.DataSource = this.responsavelBindingSource2;
            this.lbxListaResponsavel.DisplayMember = "Nome";
            this.lbxListaResponsavel.FormattingEnabled = true;
            this.lbxListaResponsavel.Location = new System.Drawing.Point(15, 52);
            this.lbxListaResponsavel.Name = "lbxListaResponsavel";
            this.lbxListaResponsavel.Size = new System.Drawing.Size(214, 446);
            this.lbxListaResponsavel.TabIndex = 2;
            this.lbxListaResponsavel.ValueMember = "TutorID";
            this.lbxListaResponsavel.SelectedIndexChanged += new System.EventHandler(this.lbxListaResponsavel_SelectedIndexChanged);
            // 
            // responsavelBindingSource2
            // 
            this.responsavelBindingSource2.DataSource = typeof(EscolaSis.Model.Responsavel);
            // 
            // txbPesquisarTutor
            // 
            this.txbPesquisarTutor.Location = new System.Drawing.Point(15, 26);
            this.txbPesquisarTutor.Name = "txbPesquisarTutor";
            this.txbPesquisarTutor.Size = new System.Drawing.Size(214, 20);
            this.txbPesquisarTutor.TabIndex = 1;
            this.txbPesquisarTutor.TextChanged += new System.EventHandler(this.txbPesquisarTutor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Pessoa";
            // 
            // responsavelBindingSource
            // 
            this.responsavelBindingSource.DataSource = typeof(EscolaSis.Model.Responsavel);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(242, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(642, 518);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 18);
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(622, 498);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGravar);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(614, 472);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pessoa Responsável";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.Location = new System.Drawing.Point(562, 423);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(46, 43);
            this.btnGravar.TabIndex = 40;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovoAluno,
            this.btnExcluirResposavel});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(608, 39);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNovoAluno
            // 
            this.btnNovoAluno.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovoAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoAluno.Image")));
            this.btnNovoAluno.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNovoAluno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovoAluno.Name = "btnNovoAluno";
            this.btnNovoAluno.Size = new System.Drawing.Size(36, 36);
            this.btnNovoAluno.Text = "Novo Aluno";
            this.btnNovoAluno.Click += new System.EventHandler(this.btnNovoAluno_Click_1);
            // 
            // btnExcluirResposavel
            // 
            this.btnExcluirResposavel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluirResposavel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirResposavel.Image")));
            this.btnExcluirResposavel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExcluirResposavel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluirResposavel.Name = "btnExcluirResposavel";
            this.btnExcluirResposavel.Size = new System.Drawing.Size(28, 36);
            this.btnExcluirResposavel.Text = "Excluir Responsável";
            this.btnExcluirResposavel.Click += new System.EventHandler(this.btnExcluirResposavel_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txbTelefone);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txbCEP);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txbCidade);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txbBairro);
            this.groupBox4.Controls.Add(this.lblbairro);
            this.groupBox4.Controls.Add(this.txbEndereco);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(6, 271);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(601, 138);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(436, 92);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(137, 20);
            this.txbTelefone.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(433, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Telefone";
            // 
            // txbCEP
            // 
            this.txbCEP.Location = new System.Drawing.Point(261, 92);
            this.txbCEP.Name = "txbCEP";
            this.txbCEP.Size = new System.Drawing.Size(137, 20);
            this.txbCEP.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(258, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "CEP";
            // 
            // txbCidade
            // 
            this.txbCidade.Location = new System.Drawing.Point(25, 92);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(220, 20);
            this.txbCidade.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cidade";
            // 
            // txbBairro
            // 
            this.txbBairro.Location = new System.Drawing.Point(436, 44);
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.Size = new System.Drawing.Size(137, 20);
            this.txbBairro.TabIndex = 7;
            // 
            // lblbairro
            // 
            this.lblbairro.AutoSize = true;
            this.lblbairro.Location = new System.Drawing.Point(433, 28);
            this.lblbairro.Name = "lblbairro";
            this.lblbairro.Size = new System.Drawing.Size(34, 13);
            this.lblbairro.TabIndex = 6;
            this.lblbairro.Text = "Bairro";
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(25, 44);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(373, 20);
            this.txbEndereco.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Endereço";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.txbCPF);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txbNumRG);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(6, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(601, 93);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbtFemin);
            this.groupBox5.Controls.Add(this.rbtMasc);
            this.groupBox5.Location = new System.Drawing.Point(358, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(215, 59);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Genero";
            // 
            // rbtFemin
            // 
            this.rbtFemin.AutoSize = true;
            this.rbtFemin.Location = new System.Drawing.Point(124, 24);
            this.rbtFemin.Name = "rbtFemin";
            this.rbtFemin.Size = new System.Drawing.Size(67, 17);
            this.rbtFemin.TabIndex = 12;
            this.rbtFemin.TabStop = true;
            this.rbtFemin.Text = "Feminino";
            this.rbtFemin.UseVisualStyleBackColor = true;
            // 
            // rbtMasc
            // 
            this.rbtMasc.AutoSize = true;
            this.rbtMasc.Location = new System.Drawing.Point(25, 24);
            this.rbtMasc.Name = "rbtMasc";
            this.rbtMasc.Size = new System.Drawing.Size(73, 17);
            this.rbtMasc.TabIndex = 11;
            this.rbtMasc.TabStop = true;
            this.rbtMasc.Text = "Masculino";
            this.rbtMasc.UseVisualStyleBackColor = true;
            // 
            // txbCPF
            // 
            this.txbCPF.Location = new System.Drawing.Point(195, 42);
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(137, 20);
            this.txbCPF.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Número do CPF";
            // 
            // txbNumRG
            // 
            this.txbNumRG.Location = new System.Drawing.Point(25, 42);
            this.txbNumRG.Name = "txbNumRG";
            this.txbNumRG.Size = new System.Drawing.Size(137, 20);
            this.txbNumRG.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Número do RG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbDataNascim);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbNomeTutor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbCodigoCadastro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txbDataNascim
            // 
            this.txbDataNascim.CustomFormat = "";
            this.txbDataNascim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txbDataNascim.Location = new System.Drawing.Point(461, 84);
            this.txbDataNascim.Name = "txbDataNascim";
            this.txbDataNascim.Size = new System.Drawing.Size(112, 20);
            this.txbDataNascim.TabIndex = 6;
            this.txbDataNascim.Value = new System.DateTime(2019, 2, 6, 0, 0, 0, 0);
            this.txbDataNascim.ValueChanged += new System.EventHandler(this.txbDataNascim_ValueChanged);
            this.txbDataNascim.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbDataNascim_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data de Nascimento";
            // 
            // txbNomeTutor
            // 
            this.txbNomeTutor.Location = new System.Drawing.Point(25, 84);
            this.txbNomeTutor.Name = "txbNomeTutor";
            this.txbNomeTutor.Size = new System.Drawing.Size(410, 20);
            this.txbNomeTutor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome do Responsável";
            // 
            // txbCodigoCadastro
            // 
            this.txbCodigoCadastro.Enabled = false;
            this.txbCodigoCadastro.Location = new System.Drawing.Point(25, 37);
            this.txbCodigoCadastro.Name = "txbCodigoCadastro";
            this.txbCodigoCadastro.Size = new System.Drawing.Size(100, 20);
            this.txbCodigoCadastro.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código de Cadastro";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(614, 472);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alunos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dgvAlunosDoTutor);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Location = new System.Drawing.Point(20, 89);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(573, 365);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            // 
            // dgvAlunosDoTutor
            // 
            this.dgvAlunosDoTutor.AllowUserToAddRows = false;
            this.dgvAlunosDoTutor.AllowUserToDeleteRows = false;
            this.dgvAlunosDoTutor.AllowUserToResizeRows = false;
            this.dgvAlunosDoTutor.AutoGenerateColumns = false;
            this.dgvAlunosDoTutor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlunosDoTutor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlunosDoTutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunosDoTutor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alunoIDDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.relacaoAlunoDescrDataGridViewTextBoxColumn});
            this.dgvAlunosDoTutor.DataSource = this.responsavelBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlunosDoTutor.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAlunosDoTutor.Location = new System.Drawing.Point(16, 38);
            this.dgvAlunosDoTutor.MultiSelect = false;
            this.dgvAlunosDoTutor.Name = "dgvAlunosDoTutor";
            this.dgvAlunosDoTutor.ReadOnly = true;
            this.dgvAlunosDoTutor.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.dgvAlunosDoTutor.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAlunosDoTutor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlunosDoTutor.Size = new System.Drawing.Size(538, 307);
            this.dgvAlunosDoTutor.TabIndex = 43;
            // 
            // alunoIDDataGridViewTextBoxColumn
            // 
            this.alunoIDDataGridViewTextBoxColumn.DataPropertyName = "AlunoID";
            this.alunoIDDataGridViewTextBoxColumn.HeaderText = "AlunoID";
            this.alunoIDDataGridViewTextBoxColumn.Name = "alunoIDDataGridViewTextBoxColumn";
            this.alunoIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.alunoIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 318;
            // 
            // relacaoAlunoDescrDataGridViewTextBoxColumn
            // 
            this.relacaoAlunoDescrDataGridViewTextBoxColumn.DataPropertyName = "RelacaoAlunoDescr";
            this.relacaoAlunoDescrDataGridViewTextBoxColumn.HeaderText = "Parentesco";
            this.relacaoAlunoDescrDataGridViewTextBoxColumn.Name = "relacaoAlunoDescrDataGridViewTextBoxColumn";
            this.relacaoAlunoDescrDataGridViewTextBoxColumn.ReadOnly = true;
            this.relacaoAlunoDescrDataGridViewTextBoxColumn.Width = 200;
            // 
            // responsavelBindingSource1
            // 
            this.responsavelBindingSource1.DataSource = typeof(EscolaSis.Model.Responsavel);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Lista dos Alunos";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txbNomeRespAluno);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Location = new System.Drawing.Point(20, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(577, 77);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            // 
            // txbNomeRespAluno
            // 
            this.txbNomeRespAluno.Enabled = false;
            this.txbNomeRespAluno.Location = new System.Drawing.Point(16, 39);
            this.txbNomeRespAluno.Name = "txbNomeRespAluno";
            this.txbNomeRespAluno.Size = new System.Drawing.Size(538, 20);
            this.txbNomeRespAluno.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Pessoa Responsável";
            // 
            // ResponsavelCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 518);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResponsavelCadastro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Responsável";
            this.Load += new System.EventHandler(this.FormAlunosCadastro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunosDoTutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbxListaResponsavel;
        private System.Windows.Forms.TextBox txbPesquisarTutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNovoAluno;
        private System.Windows.Forms.ToolStripButton btnExcluirResposavel;
        private System.Windows.Forms.DateTimePicker txbDataNascim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbNomeTutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCodigoCadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbtFemin;
        private System.Windows.Forms.RadioButton rbtMasc;
        private System.Windows.Forms.TextBox txbCPF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbNumRG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbBairro;
        private System.Windows.Forms.Label lblbairro;
        private System.Windows.Forms.TextBox txbCEP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbCidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txbNomeRespAluno;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvAlunosDoTutor;
        private System.Windows.Forms.BindingSource responsavelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn alunoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn relacaoAlunoDescrDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource responsavelBindingSource1;
        private System.Windows.Forms.BindingSource responsavelBindingSource2;
    }
}