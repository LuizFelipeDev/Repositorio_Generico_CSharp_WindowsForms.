namespace TrabBimestral.View
{
    partial class FrmCadastroTipoLogradouro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroTipoLogradouro));
            this.dgTipoLogradouro = new System.Windows.Forms.DataGridView();
            this.LogradouroID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAlterarGrid = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnExcluirGrid = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgTipoLogradouro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTipoLogradouro
            // 
            this.dgTipoLogradouro.AllowUserToAddRows = false;
            this.dgTipoLogradouro.AllowUserToDeleteRows = false;
            this.dgTipoLogradouro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTipoLogradouro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTipoLogradouro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LogradouroID,
            this.Descricao,
            this.BtnAlterarGrid,
            this.BtnExcluirGrid});
            this.dgTipoLogradouro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgTipoLogradouro.Location = new System.Drawing.Point(0, 126);
            this.dgTipoLogradouro.Name = "dgTipoLogradouro";
            this.dgTipoLogradouro.ReadOnly = true;
            this.dgTipoLogradouro.RowHeadersVisible = false;
            this.dgTipoLogradouro.Size = new System.Drawing.Size(217, 165);
            this.dgTipoLogradouro.TabIndex = 0;
            this.dgTipoLogradouro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTipoLogradouro_CellClick);
            // 
            // LogradouroID
            // 
            this.LogradouroID.DataPropertyName = "LogradouroID";
            this.LogradouroID.HeaderText = "LogradouroID";
            this.LogradouroID.Name = "LogradouroID";
            this.LogradouroID.ReadOnly = true;
            this.LogradouroID.Visible = false;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.FillWeight = 162.4352F;
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // BtnAlterarGrid
            // 
            this.BtnAlterarGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BtnAlterarGrid.FillWeight = 68.52792F;
            this.BtnAlterarGrid.HeaderText = "Alterar";
            this.BtnAlterarGrid.Name = "BtnAlterarGrid";
            this.BtnAlterarGrid.ReadOnly = true;
            this.BtnAlterarGrid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.BtnAlterarGrid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BtnAlterarGrid.Width = 45;
            // 
            // BtnExcluirGrid
            // 
            this.BtnExcluirGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BtnExcluirGrid.FillWeight = 69.0369F;
            this.BtnExcluirGrid.HeaderText = "Excluir";
            this.BtnExcluirGrid.Name = "BtnExcluirGrid";
            this.BtnExcluirGrid.ReadOnly = true;
            this.BtnExcluirGrid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.BtnExcluirGrid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BtnExcluirGrid.Width = 45;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(7, 51);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(104, 46);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Adicionar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(7, 25);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(198, 20);
            this.txtDescricao.TabIndex = 2;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(117, 51);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(88, 46);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo Logradouro";
            // 
            // FrmCadastroTipoLogradouro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 291);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dgTipoLogradouro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroTipoLogradouro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Tipo de Logradouro";
            this.Load += new System.EventHandler(this.CadastroTipoLogradouro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTipoLogradouro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTipoLogradouro;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogradouroID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewButtonColumn BtnAlterarGrid;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExcluirGrid;
        private System.Windows.Forms.Label label1;
    }
}