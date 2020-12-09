using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabBimestral.Model;
using TrabBimestral.View.Controller;

namespace TrabBimestral.View
{
    public partial class FrmCadastroBairro : Form
    {
        CCadBairro _ControlBairro;
        int idBairro;
        public FrmCadastroBairro()
        {
            InitializeComponent();
            _ControlBairro = new CCadBairro();
        }

        private void CadastroBairro_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            btnAlterar.Enabled = false;
        }

        public bool VerificaControles(Control.ControlCollection controles)
        {
            foreach (Control c in controles)
            {
                if (c is TextBox)
                {
                    if (c.Text == "")
                    {
                        return false;
                    }
                }
                if (c is ComboBox)
                {
                    if (((ComboBox)c).SelectedIndex == -1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void LimpaControles(Control.ControlCollection controles)
        {
            foreach (Control c in controles)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
            }
        }

        public void CarregarGrid()
        {
            dgBairro.DataSource = null;
            dgBairro.Rows.Clear();
            //dgCliente.Refresh();
            dgBairro.AutoGenerateColumns = false;
            var list = _ControlBairro.SelecionarTodos();

            foreach (var l in list)
            {
                var bairro = _ControlBairro.Selecionar(l.BairroID);

                dgBairro.Rows.Add(l.BairroID, bairro.Nome);
            }
            if (dgBairro.Rows.Count > 0)
            {
                dgBairro.Rows[0].Selected = false;
            }
        }

        private void dgBairro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {

                    Bairro oBairro = new Bairro();
                    idBairro = (int)dgBairro.Rows[e.RowIndex].Cells["BairroID"].Value;
                    oBairro = _ControlBairro.Selecionar(idBairro);

                    if (dgBairro.Columns[e.ColumnIndex].Name == "btnExcluirGrid")
                    {
                        if (MessageBox.Show("Deseja realmente excluir?", "Cadastro Bairro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                                _ControlBairro.Excluir(oBairro);
                                LimpaControles(this.Controls);
                                CarregarGrid();
                            }
                            catch (Exception ex)
                            {
                                if (ex.HResult.ToString() == "-2146233087")
                                {
                                    MessageBox.Show("Existem clientes cadastrados com essa informação!", "Cadastro Bairro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    else if (dgBairro.Columns[e.ColumnIndex].Name == "btnAlterarGrid")
                    {
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;

                        txtNomeBairro.Text = oBairro.Nome.ToString();

                        idBairro = oBairro.BairroID;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (VerificaControles(this.Controls))
            {
                Bairro oBairro = new Bairro();

                oBairro.Nome = txtNomeBairro.Text.ToString();

                _ControlBairro.CadastrarBairro(oBairro);

                MessageBox.Show("Bairro cadastrado com sucesso!", "Cadastro Bairro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaControles(this.Controls);
                CarregarGrid();
            }
            else
            {
                MessageBox.Show("Preenchimento de campos obrigatórios!", "Cadastro Bairro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Bairro oBairro = new Bairro();

            oBairro = _ControlBairro.Selecionar(idBairro);

            if (VerificaControles(this.Controls))
            {
                oBairro.Nome = txtNomeBairro.Text;

                _ControlBairro.Alterar(oBairro);
                MessageBox.Show("Bairro alterado com sucesso!", "Cadastro Bairro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnAlterar.Enabled = false;
                btnSalvar.Enabled = true;

                LimpaControles(this.Controls);
                CarregarGrid();
            }
            else
            {
                MessageBox.Show("Preenchimento de campos obrigatórios!", "Cadastro Bairro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
