namespace TrabBimestral.View
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoLogradouroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDependenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.bairroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesDependentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.clientesDependentesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 50);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoLogradouroToolStripMenuItem,
            this.cidadeToolStripMenuItem,
            this.tipoDependenteToolStripMenuItem,
            this.btnCliente,
            this.bairroToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.cadastroToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(72, 46);
            this.cadastroToolStripMenuItem.Text = "&Cadastros";
            // 
            // tipoLogradouroToolStripMenuItem
            // 
            this.tipoLogradouroToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tipoLogradouroToolStripMenuItem.Name = "tipoLogradouroToolStripMenuItem";
            this.tipoLogradouroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tipoLogradouroToolStripMenuItem.Text = "Tipos Logradouro";
            this.tipoLogradouroToolStripMenuItem.Click += new System.EventHandler(this.tipoLogradouroToolStripMenuItem_Click);
            // 
            // cidadeToolStripMenuItem
            // 
            this.cidadeToolStripMenuItem.Name = "cidadeToolStripMenuItem";
            this.cidadeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cidadeToolStripMenuItem.Text = "Cidades";
            this.cidadeToolStripMenuItem.Click += new System.EventHandler(this.cidadeToolStripMenuItem_Click);
            // 
            // tipoDependenteToolStripMenuItem
            // 
            this.tipoDependenteToolStripMenuItem.Name = "tipoDependenteToolStripMenuItem";
            this.tipoDependenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tipoDependenteToolStripMenuItem.Text = "Tipos Dependente";
            this.tipoDependenteToolStripMenuItem.Click += new System.EventHandler(this.tipoDependenteToolStripMenuItem_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(180, 22);
            this.btnCliente.Text = "Clientes";
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // bairroToolStripMenuItem
            // 
            this.bairroToolStripMenuItem.Name = "bairroToolStripMenuItem";
            this.bairroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bairroToolStripMenuItem.Text = "Bairros";
            this.bairroToolStripMenuItem.Click += new System.EventHandler(this.bairroToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // clientesDependentesToolStripMenuItem
            // 
            this.clientesDependentesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.clientesDependentesToolStripMenuItem.Name = "clientesDependentesToolStripMenuItem";
            this.clientesDependentesToolStripMenuItem.Size = new System.Drawing.Size(149, 46);
            this.clientesDependentesToolStripMenuItem.Text = "&Clientes / Dependentes";
            this.clientesDependentesToolStripMenuItem.Click += new System.EventHandler(this.clientesDependentesToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoLogradouroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bairroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDependenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem btnCliente;
        private System.Windows.Forms.ToolStripMenuItem clientesDependentesToolStripMenuItem;
    }
}