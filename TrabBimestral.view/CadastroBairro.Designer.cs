namespace TrabBimestral.View
{
    partial class FrmCadastroBairro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroBairro));
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgBairro = new System.Windows.Forms.DataGridView();
            this.BairroID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAlterarGrid = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnExcluirGrid = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtNomeBairro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgBairro)).BeginInit();
            this.SuspendLayout();
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
            // dgBairro
            // 
            this.dgBairro.AllowUserToAddRows = false;
            this.dgBairro.AllowUserToDeleteRows = false;
            this.dgBairro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBairro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBairro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BairroID,
            this.Nome,
            this.btnAlterarGrid,
            this.btnExcluirGrid});
            this.dgBairro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgBairro.Location = new System.Drawing.Point(0, 126);
            this.dgBairro.Name = "dgBairro";
            this.dgBairro.ReadOnly = true;
            this.dgBairro.RowHeadersVisible = false;
            this.dgBairro.Size = new System.Drawing.Size(217, 165);
            this.dgBairro.TabIndex = 3;
            this.dgBairro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBairro_CellClick);
            // 
            // BairroID
            // 
            this.BairroID.HeaderText = "BairroID";
            this.BairroID.Name = "BairroID";
            this.BairroID.ReadOnly = true;
            this.BairroID.Visible = false;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome Bairro";
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
            // txtNomeBairro
            // 
            this.txtNomeBairro.Location = new System.Drawing.Point(7, 25);
            this.txtNomeBairro.Name = "txtNomeBairro";
            this.txtNomeBairro.Size = new System.Drawing.Size(198, 20);
            this.txtNomeBairro.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome do Bairro";
            // 
            // FrmCadastroBairro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 291);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeBairro);
            this.Controls.Add(this.dgBairro);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnAlterar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroBairro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Bairro";
            this.Load += new System.EventHandler(this.CadastroBairro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBairro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgBairro;
        private System.Windows.Forms.TextBox txtNomeBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn BairroID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewButtonColumn btnAlterarGrid;
        private System.Windows.Forms.DataGridViewButtonColumn btnExcluirGrid;
        private System.Windows.Forms.Label label1;
    }
}