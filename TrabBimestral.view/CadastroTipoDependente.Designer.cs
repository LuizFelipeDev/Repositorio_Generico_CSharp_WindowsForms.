namespace TrabBimestral.View
{
    partial class FrmCadastroTipoDependente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroTipoDependente));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dgTipoDependente = new System.Windows.Forms.DataGridView();
            this.TipoDependenteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAlterarGrid = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnExcluirGrid = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipoDependente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgTipoDependente)).BeginInit();
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
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Adicionar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(117, 51);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(88, 46);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // dgTipoDependente
            // 
            this.dgTipoDependente.AllowUserToAddRows = false;
            this.dgTipoDependente.AllowUserToDeleteRows = false;
            this.dgTipoDependente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTipoDependente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTipoDependente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoDependenteID,
            this.Tipo,
            this.btnAlterarGrid,
            this.btnExcluirGrid});
            this.dgTipoDependente.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgTipoDependente.Location = new System.Drawing.Point(0, 126);
            this.dgTipoDependente.Name = "dgTipoDependente";
            this.dgTipoDependente.ReadOnly = true;
            this.dgTipoDependente.RowHeadersVisible = false;
            this.dgTipoDependente.Size = new System.Drawing.Size(217, 165);
            this.dgTipoDependente.TabIndex = 2;
            this.dgTipoDependente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTipoDependente_CellClick);
            // 
            // TipoDependenteID
            // 
            this.TipoDependenteID.HeaderText = "TipoDependenteID";
            this.TipoDependenteID.Name = "TipoDependenteID";
            this.TipoDependenteID.ReadOnly = true;
            this.TipoDependenteID.Visible = false;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo Dependente";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo Dependente";
            // 
            // txtTipoDependente
            // 
            this.txtTipoDependente.Location = new System.Drawing.Point(7, 25);
            this.txtTipoDependente.Name = "txtTipoDependente";
            this.txtTipoDependente.Size = new System.Drawing.Size(198, 20);
            this.txtTipoDependente.TabIndex = 4;
            // 
            // FrmCadastroTipoDependente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 291);
            this.Controls.Add(this.txtTipoDependente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgTipoDependente);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroTipoDependente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Tipo de Dependente";
            this.Load += new System.EventHandler(this.CadastroTipoDependente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTipoDependente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridView dgTipoDependente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTipoDependente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDependenteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewButtonColumn btnAlterarGrid;
        private System.Windows.Forms.DataGridViewButtonColumn btnExcluirGrid;
    }
}