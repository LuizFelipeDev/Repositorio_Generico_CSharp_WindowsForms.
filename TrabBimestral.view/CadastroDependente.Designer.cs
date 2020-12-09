namespace TrabBimestral.View
{
    partial class FrmCadastroDependente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroDependente));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeDependente = new System.Windows.Forms.TextBox();
            this.cbTipoDependente = new System.Windows.Forms.ComboBox();
            this.tipoDependenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bimestralTrabDataSet4 = new TrabBimestral.view.BimestralTrabDataSet4();
            this.dgDependente = new System.Windows.Forms.DataGridView();
            this.DependenteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDependente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAlterarGrid = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnExcluirGrid = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tipoDependenteTableAdapter = new TrabBimestral.view.BimestralTrabDataSet4TableAdapters.TipoDependenteTableAdapter();
            this.bimestralTrabDataSet6 = new TrabBimestral.view.BimestralTrabDataSet6();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.cbBairro = new System.Windows.Forms.ComboBox();
            this.bairroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bimestralTrabDataSet2 = new TrabBimestral.view.BimestralTrabDataSet2();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.cidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bimestralTrabDataSet1 = new TrabBimestral.view.BimestralTrabDataSet1();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbLogradouro = new System.Windows.Forms.ComboBox();
            this.tipoLogradouroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bimestralTrabDataSet = new TrabBimestral.view.BimestralTrabDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteDataSet = new TrabBimestral.view.ClienteDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bimestralTrabDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bimestralTrabDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cidadeTableAdapter = new TrabBimestral.view.BimestralTrabDataSet1TableAdapters.CidadeTableAdapter();
            this.tipo_LogradouroTableAdapter = new TrabBimestral.view.BimestralTrabDataSetTableAdapters.Tipo_LogradouroTableAdapter();
            this.bairroTableAdapter = new TrabBimestral.view.BimestralTrabDataSet2TableAdapters.BairroTableAdapter();
            this.clienteTableAdapter = new TrabBimestral.view.ClienteDataSetTableAdapters.ClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDependenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimestralTrabDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDependente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimestralTrabDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bairroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimestralTrabDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimestralTrabDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoLogradouroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimestralTrabDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bimestralTrabDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimestralTrabDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(621, 24);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 131);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome Dependente";
            // 
            // txtNomeDependente
            // 
            this.txtNomeDependente.Location = new System.Drawing.Point(6, 44);
            this.txtNomeDependente.Name = "txtNomeDependente";
            this.txtNomeDependente.Size = new System.Drawing.Size(198, 20);
            this.txtNomeDependente.TabIndex = 0;
            // 
            // cbTipoDependente
            // 
            this.cbTipoDependente.DataSource = this.tipoDependenteBindingSource;
            this.cbTipoDependente.DisplayMember = "Tipo";
            this.cbTipoDependente.FormattingEnabled = true;
            this.cbTipoDependente.Location = new System.Drawing.Point(210, 43);
            this.cbTipoDependente.Name = "cbTipoDependente";
            this.cbTipoDependente.Size = new System.Drawing.Size(109, 21);
            this.cbTipoDependente.TabIndex = 1;
            this.cbTipoDependente.ValueMember = "TipoDependenteID";
            // 
            // tipoDependenteBindingSource
            // 
            this.tipoDependenteBindingSource.DataMember = "TipoDependente";
            this.tipoDependenteBindingSource.DataSource = this.bimestralTrabDataSet4;
            // 
            // bimestralTrabDataSet4
            // 
            this.bimestralTrabDataSet4.DataSetName = "BimestralTrabDataSet4";
            this.bimestralTrabDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgDependente
            // 
            this.dgDependente.AllowUserToAddRows = false;
            this.dgDependente.AllowUserToDeleteRows = false;
            this.dgDependente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDependente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDependente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DependenteID,
            this.Nome,
            this.TipoDependente,
            this.btnAlterarGrid,
            this.btnExcluirGrid});
            this.dgDependente.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgDependente.Location = new System.Drawing.Point(0, 300);
            this.dgDependente.Name = "dgDependente";
            this.dgDependente.ReadOnly = true;
            this.dgDependente.RowHeadersVisible = false;
            this.dgDependente.Size = new System.Drawing.Size(811, 221);
            this.dgDependente.TabIndex = 5;
            this.dgDependente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDependente_CellClick);
            // 
            // DependenteID
            // 
            this.DependenteID.HeaderText = "DependenteID";
            this.DependenteID.Name = "DependenteID";
            this.DependenteID.ReadOnly = true;
            this.DependenteID.Visible = false;
            // 
            // Nome
            // 
            this.Nome.FillWeight = 56.07477F;
            this.Nome.HeaderText = "Nome Dependente";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // TipoDependente
            // 
            this.TipoDependente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TipoDependente.FillWeight = 143.9252F;
            this.TipoDependente.HeaderText = "Tipo Dependente";
            this.TipoDependente.Name = "TipoDependente";
            this.TipoDependente.ReadOnly = true;
            this.TipoDependente.Width = 150;
            // 
            // btnAlterarGrid
            // 
            this.btnAlterarGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.btnAlterarGrid.HeaderText = "Alterar";
            this.btnAlterarGrid.Name = "btnAlterarGrid";
            this.btnAlterarGrid.ReadOnly = true;
            this.btnAlterarGrid.Width = 45;
            // 
            // btnExcluirGrid
            // 
            this.btnExcluirGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.btnExcluirGrid.HeaderText = "Excluir";
            this.btnExcluirGrid.Name = "btnExcluirGrid";
            this.btnExcluirGrid.ReadOnly = true;
            this.btnExcluirGrid.Width = 45;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlterar.BackgroundImage")));
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(172, 70);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(147, 40);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Salvar Alteração";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo Dependente";
            // 
            // tipoDependenteTableAdapter
            // 
            this.tipoDependenteTableAdapter.ClearBeforeFill = true;
            // 
            // bimestralTrabDataSet6
            // 
            this.bimestralTrabDataSet6.DataSetName = "BimestralTrabDataSet6";
            this.bimestralTrabDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(419, 89);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(87, 20);
            this.txtCPF.TabIndex = 3;
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(329, 89);
            this.txtRG.Mask = "00.000.000-00";
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(84, 20);
            this.txtRG.TabIndex = 2;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(512, 89);
            this.txtTelefone.Mask = "(00)00099-9999";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 4;
            // 
            // cbBairro
            // 
            this.cbBairro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbBairro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBairro.DataSource = this.bairroBindingSource;
            this.cbBairro.DisplayMember = "Nome";
            this.cbBairro.FormattingEnabled = true;
            this.cbBairro.Location = new System.Drawing.Point(189, 135);
            this.cbBairro.Name = "cbBairro";
            this.cbBairro.Size = new System.Drawing.Size(100, 21);
            this.cbBairro.TabIndex = 7;
            this.cbBairro.ValueMember = "BairroID";
            // 
            // bairroBindingSource
            // 
            this.bairroBindingSource.DataMember = "Bairro";
            this.bairroBindingSource.DataSource = this.bimestralTrabDataSet2;
            // 
            // bimestralTrabDataSet2
            // 
            this.bimestralTrabDataSet2.DataSetName = "BimestralTrabDataSet2";
            this.bimestralTrabDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbCidade
            // 
            this.cbCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCidade.DataSource = this.cidadeBindingSource;
            this.cbCidade.DisplayMember = "Nome";
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Location = new System.Drawing.Point(52, 135);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(131, 21);
            this.cbCidade.TabIndex = 6;
            this.cbCidade.ValueMember = "CidadeID";
            // 
            // cidadeBindingSource
            // 
            this.cidadeBindingSource.DataMember = "Cidade";
            this.cidadeBindingSource.DataSource = this.bimestralTrabDataSet1;
            // 
            // bimestralTrabDataSet1
            // 
            this.bimestralTrabDataSet1.DataSetName = "BimestralTrabDataSet1";
            this.bimestralTrabDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 89);
            this.txtNome.MaxLength = 25;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(311, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(292, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Tipo Logradouro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Nome";
            // 
            // cbLogradouro
            // 
            this.cbLogradouro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbLogradouro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbLogradouro.DataSource = this.tipoLogradouroBindingSource;
            this.cbLogradouro.DisplayMember = "Descricao";
            this.cbLogradouro.FormattingEnabled = true;
            this.cbLogradouro.Location = new System.Drawing.Point(295, 135);
            this.cbLogradouro.Name = "cbLogradouro";
            this.cbLogradouro.Size = new System.Drawing.Size(108, 21);
            this.cbLogradouro.TabIndex = 8;
            this.cbLogradouro.ValueMember = "LogradouroID";
            // 
            // tipoLogradouroBindingSource
            // 
            this.tipoLogradouroBindingSource.DataMember = "Tipo_Logradouro";
            this.tipoLogradouroBindingSource.DataSource = this.bimestralTrabDataSet;
            // 
            // bimestralTrabDataSet
            // 
            this.bimestralTrabDataSet.DataSetName = "BimestralTrabDataSet";
            this.bimestralTrabDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(409, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Logradouro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(326, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "RG";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(409, 135);
            this.txtLogradouro.MaxLength = 20;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(206, 20);
            this.txtLogradouro.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(186, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Bairro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(416, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "CPF";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(49, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Cidade";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "UF";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(509, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Telefone";
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(12, 136);
            this.txtUF.MaxLength = 2;
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(34, 20);
            this.txtUF.TabIndex = 5;
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncluir.BackgroundImage")));
            this.btnIncluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.Location = new System.Drawing.Point(6, 70);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(148, 40);
            this.btnIncluir.TabIndex = 2;
            this.btnIncluir.Text = "Add Dependente";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.Location = new System.Drawing.Point(702, 94);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 61);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDownGrid;
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnNovo);
            this.groupBox1.Controls.Add(this.cmbCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtUF);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtRG);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbBairro);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbCidade);
            this.groupBox1.Controls.Add(this.txtLogradouro);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbLogradouro);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente (MESTRE)";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(702, 24);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 64);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // cmbCliente
            // 
            this.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCliente.DataSource = this.clienteBindingSource;
            this.cmbCliente.DisplayMember = "Nome";
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(12, 40);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(311, 21);
            this.cmbCliente.TabIndex = 0;
            this.cmbCliente.ValueMember = "ClienteID";
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged_1);
            this.cmbCliente.TextUpdate += new System.EventHandler(this.cmbCliente_TextUpdate_1);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.clienteDataSet;
            // 
            // clienteDataSet
            // 
            this.clienteDataSet.DataSetName = "ClienteDataSet";
            this.clienteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNomeDependente);
            this.groupBox2.Controls.Add(this.btnIncluir);
            this.groupBox2.Controls.Add(this.btnAlterar);
            this.groupBox2.Controls.Add(this.cbTipoDependente);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 120);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dependentes (DETALHES)";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // bimestralTrabDataSet2BindingSource
            // 
            this.bimestralTrabDataSet2BindingSource.DataSource = this.bimestralTrabDataSet2;
            this.bimestralTrabDataSet2BindingSource.Position = 0;
            // 
            // bimestralTrabDataSet1BindingSource
            // 
            this.bimestralTrabDataSet1BindingSource.DataSource = this.bimestralTrabDataSet1;
            this.bimestralTrabDataSet1BindingSource.Position = 0;
            // 
            // cidadeTableAdapter
            // 
            this.cidadeTableAdapter.ClearBeforeFill = true;
            // 
            // tipo_LogradouroTableAdapter
            // 
            this.tipo_LogradouroTableAdapter.ClearBeforeFill = true;
            // 
            // bairroTableAdapter
            // 
            this.bairroTableAdapter.ClearBeforeFill = true;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCadastroDependente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(811, 521);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgDependente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroDependente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Cliente / Dependente";
            this.Load += new System.EventHandler(this.CadastroDependente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipoDependenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimestralTrabDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDependente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimestralTrabDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bairroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimestralTrabDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimestralTrabDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoLogradouroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimestralTrabDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bimestralTrabDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimestralTrabDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeDependente;
        private System.Windows.Forms.ComboBox cbTipoDependente;
        private System.Windows.Forms.DataGridView dgDependente;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label3;
        private view.BimestralTrabDataSet4 bimestralTrabDataSet4;
        private System.Windows.Forms.BindingSource tipoDependenteBindingSource;
        private view.BimestralTrabDataSet4TableAdapters.TipoDependenteTableAdapter tipoDependenteTableAdapter;
        private view.BimestralTrabDataSet6 bimestralTrabDataSet6;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox txtRG;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.ComboBox cbBairro;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbLogradouro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource bimestralTrabDataSet1BindingSource;
        private view.BimestralTrabDataSet1 bimestralTrabDataSet1;
        private view.BimestralTrabDataSet2 bimestralTrabDataSet2;
        private System.Windows.Forms.BindingSource bimestralTrabDataSet2BindingSource;
        private System.Windows.Forms.BindingSource cidadeBindingSource;
        private view.BimestralTrabDataSet1TableAdapters.CidadeTableAdapter cidadeTableAdapter;
        private view.BimestralTrabDataSet bimestralTrabDataSet;
        private System.Windows.Forms.BindingSource tipoLogradouroBindingSource;
        private view.BimestralTrabDataSetTableAdapters.Tipo_LogradouroTableAdapter tipo_LogradouroTableAdapter;
        private System.Windows.Forms.BindingSource bairroBindingSource;
        private view.BimestralTrabDataSet2TableAdapters.BairroTableAdapter bairroTableAdapter;
        private System.Windows.Forms.ComboBox cmbCliente;
        private view.ClienteDataSet clienteDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private view.ClienteDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn DependenteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDependente;
        private System.Windows.Forms.DataGridViewButtonColumn btnAlterarGrid;
        private System.Windows.Forms.DataGridViewButtonColumn btnExcluirGrid;
    }
}