namespace TrabBimestral.View
{
    partial class FrmCadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroCliente));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLogradouro = new System.Windows.Forms.ComboBox();
            this.tipoLogradouroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bimestralTrabDataSet = new TrabBimestral.view.BimestralTrabDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.dgCliente = new System.Windows.Forms.DataGridView();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.cidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bimestralTrabDataSet1 = new TrabBimestral.view.BimestralTrabDataSet1();
            this.cbBairro = new System.Windows.Forms.ComboBox();
            this.bairroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bimestralTrabDataSet2 = new TrabBimestral.view.BimestralTrabDataSet2();
            this.tipo_LogradouroTableAdapter = new TrabBimestral.view.BimestralTrabDataSetTableAdapters.Tipo_LogradouroTableAdapter();
            this.cidadeTableAdapter = new TrabBimestral.view.BimestralTrabDataSet1TableAdapters.CidadeTableAdapter();
            this.bairroTableAdapter = new TrabBimestral.view.BimestralTrabDataSet2TableAdapters.BairroTableAdapter();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.tipoDependenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bimestralTrabDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bimestralTrabDataSet3 = new TrabBimestral.view.BimestralTrabDataSet3();
            this.tipoDependenteTableAdapter = new TrabBimestral.view.BimestralTrabDataSet3TableAdapters.TipoDependenteTableAdapter();
            this.tipoDependenteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ClienteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoLogradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAlterarGrid = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnExcluirGrid = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tipoLogradouroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimestralTrabDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimestralTrabDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bairroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimestralTrabDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDependenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimestralTrabDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimestralTrabDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDependenteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 25);
            this.txtNome.MaxLength = 25;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(194, 20);
            this.txtNome.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(475, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 73);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Adicionar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nome";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(209, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "RG";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(296, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "CPF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(384, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Telefone";
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(12, 64);
            this.txtUF.MaxLength = 2;
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(32, 20);
            this.txtUF.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "UF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(158, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bairro";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(262, 65);
            this.txtLogradouro.MaxLength = 20;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(100, 20);
            this.txtLogradouro.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Logradouro";
            // 
            // cbLogradouro
            // 
            this.cbLogradouro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbLogradouro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbLogradouro.DataSource = this.tipoLogradouroBindingSource;
            this.cbLogradouro.DisplayMember = "Descricao";
            this.cbLogradouro.FormattingEnabled = true;
            this.cbLogradouro.Location = new System.Drawing.Point(368, 64);
            this.cbLogradouro.Name = "cbLogradouro";
            this.cbLogradouro.Size = new System.Drawing.Size(100, 21);
            this.cbLogradouro.TabIndex = 4;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tipo Logradouro";
            // 
            // dgCliente
            // 
            this.dgCliente.AllowUserToAddRows = false;
            this.dgCliente.AllowUserToDeleteRows = false;
            this.dgCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClienteID,
            this.Nome,
            this.TipoLogradouro,
            this.Logradouro,
            this.Bairro,
            this.Cidade,
            this.UF,
            this.Telefone,
            this.CPF,
            this.RG,
            this.BtnAlterarGrid,
            this.BtnExcluirGrid});
            this.dgCliente.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgCliente.Location = new System.Drawing.Point(0, 103);
            this.dgCliente.Name = "dgCliente";
            this.dgCliente.ReadOnly = true;
            this.dgCliente.RowHeadersVisible = false;
            this.dgCliente.Size = new System.Drawing.Size(878, 205);
            this.dgCliente.TabIndex = 21;
            this.dgCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCliente_CellClick);
            // 
            // cbCidade
            // 
            this.cbCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCidade.DataSource = this.cidadeBindingSource;
            this.cbCidade.DisplayMember = "Nome";
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Location = new System.Drawing.Point(50, 64);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(100, 21);
            this.cbCidade.TabIndex = 2;
            this.cbCidade.ValueMember = "CidadeID";
            this.cbCidade.SelectedIndexChanged += new System.EventHandler(this.cbCidade_SelectedIndexChanged);
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
            // cbBairro
            // 
            this.cbBairro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbBairro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBairro.DataSource = this.bairroBindingSource;
            this.cbBairro.DisplayMember = "Nome";
            this.cbBairro.FormattingEnabled = true;
            this.cbBairro.Location = new System.Drawing.Point(156, 64);
            this.cbBairro.Name = "cbBairro";
            this.cbBairro.Size = new System.Drawing.Size(100, 21);
            this.cbBairro.TabIndex = 8;
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
            // tipo_LogradouroTableAdapter
            // 
            this.tipo_LogradouroTableAdapter.ClearBeforeFill = true;
            // 
            // cidadeTableAdapter
            // 
            this.cidadeTableAdapter.ClearBeforeFill = true;
            // 
            // bairroTableAdapter
            // 
            this.bairroTableAdapter.ClearBeforeFill = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(556, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 73);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(387, 25);
            this.txtTelefone.Mask = "(00)00099-9999";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(81, 20);
            this.txtTelefone.TabIndex = 22;
            this.txtTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTelefone_MaskInputRejected);
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(212, 25);
            this.txtRG.Mask = "00.000.000-00";
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(81, 20);
            this.txtRG.TabIndex = 23;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(299, 25);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(82, 20);
            this.txtCPF.TabIndex = 24;
            // 
            // tipoDependenteBindingSource
            // 
            this.tipoDependenteBindingSource.DataMember = "TipoDependente";
            this.tipoDependenteBindingSource.DataSource = this.bimestralTrabDataSet3BindingSource;
            // 
            // bimestralTrabDataSet3BindingSource
            // 
            this.bimestralTrabDataSet3BindingSource.DataSource = this.bimestralTrabDataSet3;
            this.bimestralTrabDataSet3BindingSource.Position = 0;
            // 
            // bimestralTrabDataSet3
            // 
            this.bimestralTrabDataSet3.DataSetName = "BimestralTrabDataSet3";
            this.bimestralTrabDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoDependenteTableAdapter
            // 
            this.tipoDependenteTableAdapter.ClearBeforeFill = true;
            // 
            // tipoDependenteBindingSource1
            // 
            this.tipoDependenteBindingSource1.DataMember = "TipoDependente";
            this.tipoDependenteBindingSource1.DataSource = this.bimestralTrabDataSet3BindingSource;
            // 
            // ClienteID
            // 
            this.ClienteID.DataPropertyName = "ClienteID";
            this.ClienteID.HeaderText = "CodigoCliente";
            this.ClienteID.Name = "ClienteID";
            this.ClienteID.ReadOnly = true;
            this.ClienteID.Visible = false;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.FillWeight = 84.87673F;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // TipoLogradouro
            // 
            this.TipoLogradouro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TipoLogradouro.DataPropertyName = "TipoLogradouro";
            this.TipoLogradouro.FillWeight = 84.87673F;
            this.TipoLogradouro.HeaderText = "Tipo Logradouro";
            this.TipoLogradouro.Name = "TipoLogradouro";
            this.TipoLogradouro.ReadOnly = true;
            this.TipoLogradouro.Width = 80;
            // 
            // Logradouro
            // 
            this.Logradouro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Logradouro.DataPropertyName = "Logradouro";
            this.Logradouro.FillWeight = 84.87673F;
            this.Logradouro.HeaderText = "Logradouro";
            this.Logradouro.Name = "Logradouro";
            this.Logradouro.ReadOnly = true;
            this.Logradouro.Width = 70;
            // 
            // Bairro
            // 
            this.Bairro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Bairro.DataPropertyName = "Bairro";
            this.Bairro.FillWeight = 84.87673F;
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            this.Bairro.Width = 80;
            // 
            // Cidade
            // 
            this.Cidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cidade.DataPropertyName = "Cidade";
            this.Cidade.FillWeight = 84.87673F;
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            this.Cidade.Width = 80;
            // 
            // UF
            // 
            this.UF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UF.DataPropertyName = "UF";
            this.UF.FillWeight = 84.87673F;
            this.UF.HeaderText = "UF";
            this.UF.Name = "UF";
            this.UF.ReadOnly = true;
            this.UF.Width = 30;
            // 
            // Telefone
            // 
            this.Telefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Telefone.FillWeight = 84.87673F;
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Width = 90;
            // 
            // CPF
            // 
            this.CPF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CPF.FillWeight = 84.87673F;
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            this.CPF.Width = 90;
            // 
            // RG
            // 
            this.RG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RG.DataPropertyName = "RG";
            this.RG.FillWeight = 84.87673F;
            this.RG.HeaderText = "RG";
            this.RG.Name = "RG";
            this.RG.ReadOnly = true;
            this.RG.Width = 85;
            // 
            // BtnAlterarGrid
            // 
            this.BtnAlterarGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BtnAlterarGrid.FillWeight = 56.92163F;
            this.BtnAlterarGrid.HeaderText = "Alterar";
            this.BtnAlterarGrid.Name = "BtnAlterarGrid";
            this.BtnAlterarGrid.ReadOnly = true;
            this.BtnAlterarGrid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.BtnAlterarGrid.Width = 45;
            // 
            // BtnExcluirGrid
            // 
            this.BtnExcluirGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BtnExcluirGrid.FillWeight = 279.1878F;
            this.BtnExcluirGrid.HeaderText = "Excluir";
            this.BtnExcluirGrid.Name = "BtnExcluirGrid";
            this.BtnExcluirGrid.ReadOnly = true;
            this.BtnExcluirGrid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.BtnExcluirGrid.Width = 45;
            // 
            // FrmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 308);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dgCliente);
            this.Controls.Add(this.cbBairro);
            this.Controls.Add(this.cbCidade);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLogradouro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Cliente";
            this.Load += new System.EventHandler(this.FrmCadastroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipoLogradouroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimestralTrabDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimestralTrabDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bairroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimestralTrabDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDependenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimestralTrabDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimestralTrabDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDependenteBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLogradouro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgCliente;
        private System.Windows.Forms.ComboBox cbBairro;
        private System.Windows.Forms.ComboBox cbCidade;
        private view.BimestralTrabDataSet bimestralTrabDataSet;
        private System.Windows.Forms.BindingSource tipoLogradouroBindingSource;
        private view.BimestralTrabDataSetTableAdapters.Tipo_LogradouroTableAdapter tipo_LogradouroTableAdapter;
        private view.BimestralTrabDataSet1 bimestralTrabDataSet1;
        private System.Windows.Forms.BindingSource cidadeBindingSource;
        private view.BimestralTrabDataSet1TableAdapters.CidadeTableAdapter cidadeTableAdapter;
        private view.BimestralTrabDataSet2 bimestralTrabDataSet2;
        private System.Windows.Forms.BindingSource bairroBindingSource;
        private view.BimestralTrabDataSet2TableAdapters.BairroTableAdapter bairroTableAdapter;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtRG;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.BindingSource bimestralTrabDataSet3BindingSource;
        private view.BimestralTrabDataSet3 bimestralTrabDataSet3;
        private System.Windows.Forms.BindingSource tipoDependenteBindingSource;
        private view.BimestralTrabDataSet3TableAdapters.TipoDependenteTableAdapter tipoDependenteTableAdapter;
        private System.Windows.Forms.BindingSource tipoDependenteBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoLogradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Logradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn UF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.DataGridViewButtonColumn BtnAlterarGrid;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExcluirGrid;
    }
}