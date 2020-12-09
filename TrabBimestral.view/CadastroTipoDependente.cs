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
    public partial class FrmCadastroTipoDependente : Form
    {
        CCadTipoDependente _ControlTipoDependente = new CCadTipoDependente();
        int idTipoDependente;
        public FrmCadastroTipoDependente()
        {
            InitializeComponent();
        }

        private void CadastroTipoDependente_Load(object sender, EventArgs e)
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
            dgTipoDependente.DataSource = null;
            dgTipoDependente.Rows.Clear();
            //dgCliente.Refresh();
            dgTipoDependente.AutoGenerateColumns = false;
            var list = _ControlTipoDependente.SelecionarTodos();

            foreach (var l in list)
            {
                var tipoDependente = _ControlTipoDependente.Selecionar(l.TipoDependenteID);

                dgTipoDependente.Rows.Add(l.TipoDependenteID, tipoDependente.Tipo);
            }
            if (dgTipoDependente.Rows.Count > 0)
            {
                dgTipoDependente.Rows[0].Selected = false;
            }
        }

        private void dgTipoDependente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {

                    TipoDependente oTipoDependente = new TipoDependente();
                    idTipoDependente = (int)dgTipoDependente.Rows[e.RowIndex].Cells["TipoDependenteID"].Value;
                    oTipoDependente = _ControlTipoDependente.Selecionar(idTipoDependente);

                    if (dgTipoDependente.Columns[e.ColumnIndex].Name == "btnExcluirGrid")
                    {
                        if (MessageBox.Show("Deseja realmente excluir?", "Cadastro Tipo Dependente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                                _ControlTipoDependente.Excluir(oTipoDependente);
                                LimpaControles(this.Controls);
                                CarregarGrid();
                            }
                            catch (Exception ex)
                            {
                                if (ex.HResult.ToString() == "-2146233087")
                                {
                                    MessageBox.Show("Existem clientes cadastrados com essa informação!", "Cadastro Tipo de Dependente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    else if (dgTipoDependente.Columns[e.ColumnIndex].Name == "btnAlterarGrid")
                    {
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;

                        txtTipoDependente.Text = oTipoDependente.Tipo.ToString();

                        idTipoDependente = oTipoDependente.TipoDependenteID;
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
                TipoDependente oTipoDependente = new TipoDependente();

                oTipoDependente.Tipo = txtTipoDependente.Text.ToString();
                _ControlTipoDependente.CadastrarTipoDependente(oTipoDependente);

                MessageBox.Show("Tipo Dependente cadastrado com sucesso!", "Cadastro Tipo Dependente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaControles(this.Controls);
                CarregarGrid();
            }
            else
            {
                MessageBox.Show("Preenchimento de campos obrigatórios!", "Cadastro Tipo Dependente", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            TipoDependente oTipoDependente = new TipoDependente();

            oTipoDependente = _ControlTipoDependente.Selecionar(idTipoDependente);

            if (VerificaControles(this.Controls))
            {
                oTipoDependente.Tipo = txtTipoDependente.Text;

                _ControlTipoDependente.Alterar(oTipoDependente);
                MessageBox.Show("Tipo Dependente alterado com sucesso!", "Cadastro Tipo Dependente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnAlterar.Enabled = false;
                btnSalvar.Enabled = true;

                LimpaControles(this.Controls);
                CarregarGrid();
            }
            else
            {
                MessageBox.Show("Preenchimento de campos obrigatórios!", "Cadastro Tipo Dependente", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
