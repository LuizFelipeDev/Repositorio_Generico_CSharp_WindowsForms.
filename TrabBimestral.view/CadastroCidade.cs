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
    public partial class FrmCadastroCidade : Form
    {
        CCadCidade _ControlCidade = new CCadCidade();
        int idCidade;
        public FrmCadastroCidade()
        {
            InitializeComponent();
        }

        private void CadastroCidade_Load(object sender, EventArgs e)
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
            dgCidade.DataSource = null;
            dgCidade.Rows.Clear();
            //dgCliente.Refresh();
            dgCidade.AutoGenerateColumns = false;
            var list = _ControlCidade.SelecionarTodos();

            foreach (var l in list)
            {
                var Cidade = _ControlCidade.Selecionar(l.CidadeID);

                dgCidade.Rows.Add(l.CidadeID, Cidade.Nome);
            }
            if (dgCidade.Rows.Count > 0)
            {
                dgCidade.Rows[0].Selected = false;
            }
        }

        private void dgCidade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {

                    Cidade oCidade = new Cidade();
                    idCidade = (int)dgCidade.Rows[e.RowIndex].Cells["CidadeID"].Value;
                    oCidade = _ControlCidade.Selecionar(idCidade);

                    if (dgCidade.Columns[e.ColumnIndex].Name == "btnExcluirGrid")
                    {
                        if (MessageBox.Show("Deseja realmente excluir?", "Cadastro Cidade", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                                _ControlCidade.Excluir(oCidade);
                                LimpaControles(this.Controls);
                                CarregarGrid();
                            }catch(Exception ex)
                            {
                                if (ex.HResult.ToString() == "-2146233087")
                                {
                                    MessageBox.Show("Existem clientes cadastrados com essa informação!", "Cadastro Cidade", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    else if (dgCidade.Columns[e.ColumnIndex].Name == "btnAlterarGrid")
                    {
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;

                        txtNomeCidade.Text = oCidade.Nome.ToString();

                        idCidade = oCidade.CidadeID;
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
                Cidade oCidade = new Cidade();

                oCidade.Nome = txtNomeCidade.Text.ToString();
                _ControlCidade.CadastrarCidade(oCidade);

                MessageBox.Show("Cidade cadastrada com sucesso!", "Cadastro Cidade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaControles(this.Controls);
                CarregarGrid();
            }
            else
            {
                MessageBox.Show("Preenchimento de campos obrigatórios!", "Cadastro Cidade", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cidade oCidade = new Cidade();

            oCidade = _ControlCidade.Selecionar(idCidade);

            if (VerificaControles(this.Controls))
            {
                oCidade.Nome = txtNomeCidade.Text;

                _ControlCidade.Alterar(oCidade);
                MessageBox.Show("Cidade alterada com sucesso!", "Cadastro Cidade", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnAlterar.Enabled = false;
                btnSalvar.Enabled = true;

                LimpaControles(this.Controls);
                CarregarGrid();
            }
            else
            {
                MessageBox.Show("Preenchimento de campos obrigatórios!", "Cadastro Cidade", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
