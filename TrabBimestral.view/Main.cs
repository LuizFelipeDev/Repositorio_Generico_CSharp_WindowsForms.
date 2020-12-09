using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabBimestral.View
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente frmCliente = new FrmCadastroCliente();
            frmCliente.ShowDialog();
        }

        private void tipoLogradouroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroTipoLogradouro frmCadastroTipoLogradouro = new FrmCadastroTipoLogradouro();
            frmCadastroTipoLogradouro.ShowDialog();
        }

        private void bairroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroBairro frmCadastroBairro = new FrmCadastroBairro();
            frmCadastroBairro.ShowDialog();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroCidade frmCadastroCidade = new FrmCadastroCidade();
            frmCadastroCidade.ShowDialog();
        }

        private void tipoDependenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroTipoDependente frmCadastroTipoDependente = new FrmCadastroTipoDependente();
            frmCadastroTipoDependente.ShowDialog();
        }      

        private void clientesDependentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroDependente frmCadastroDependente = new FrmCadastroDependente();
            frmCadastroDependente.ShowDialog();
        }
    }
}
