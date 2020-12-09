namespace TrabBimestral.View
{
    partial class FrmCadastroCidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroCidade));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtNomeCidade = new System.Windows.Forms.TextBox();
            this.dgCidade = new System.Windows.Forms.DataGridView();
            this.CidadeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAlterarGrid = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnExcluirGrid = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCidade)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome da Cidade";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(117, 51);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(88, 46);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtNomeCidade
            // 
            this.txtNomeCidade.Location = new System.Drawing.Point(7, 25);
            this.txtNomeCidade.Name = "txtNomeCidade";
            this.txtNomeCidade.Size = new System.Drawing.Size(198, 20);
            this.txtNomeCidade.TabIndex = 0;
            // 
            // dgCidade
            // 
            this.dgCidade.AllowUserToAddRows = false;
            this.dgCidade.AllowUserToDeleteRows = false;
            this.dgCidade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCidade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CidadeID,
            this.Nome,
            this.btnAlterarGrid,
            this.btnExcluirGrid});
            this.dgCidade.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgCidade.Location = new System.Drawing.Point(0, 126);
            this.dgCidade.Name = "dgCidade";
            this.dgCidade.ReadOnly = true;
            this.dgCidade.RowHeadersVisible = false;
            this.dgCidade.Size = new System.Drawing.Size(217, 165);
            this.dgCidade.TabIndex = 3;
            this.dgCidade.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCidade_CellClick);
            // 
            // CidadeID
            // 
            this.CidadeID.HeaderText = "CidadeID";
            this.CidadeID.Name = "CidadeID";
            this.CidadeID.ReadOnly = true;
            this.CidadeID.Visible = false;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome Cidade";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
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
            // FrmCadastroCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 291);
            this.Controls.Add(this.dgCidade);
            this.Controls.Add(this.txtNomeCidade);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroCidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Cidade";
            this.Load += new System.EventHandler(this.CadastroCidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtNomeCidade;
        private System.Windows.Forms.DataGridView dgCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn CidadeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewButtonColumn btnAlterarGrid;
        private System.Windows.Forms.DataGridViewButtonColumn btnExcluirGrid;
    }
}