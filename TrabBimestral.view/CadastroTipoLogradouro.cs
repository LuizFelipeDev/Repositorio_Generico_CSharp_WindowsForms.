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
    public partial class FrmCadastroTipoLogradouro : Form
    {
        CCadTipoLogradouro _ControllTipoLogradouro = new CCadTipoLogradouro();
        int idTipoLogradouro;
        public FrmCadastroTipoLogradouro()
        {
            InitializeComponent();
        }

        private void CadastroTipoLogradouro_Load(object sender, EventArgs e)
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
                    if(c.Text == "")
                    {
                        return false;
                    }
                }
                if (c is ComboBox)
                {
                    if(((ComboBox)c).SelectedIndex == -1)
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
            dgTipoLogradouro.DataSource = null;
            dgTipoLogradouro.Rows.Clear();
            //dgCliente.Refresh();
            dgTipoLogradouro.AutoGenerateColumns = false;
            var list = _ControllTipoLogradouro.SelecionarTodos();

            foreach (var l in list)
            {
                var tipoLogadradouro = _ControllTipoLogradouro.Selecionar(l.LogradouroID);

                dgTipoLogradouro.Rows.Add(l.LogradouroID, tipoLogadradouro.Descricao );
            }
            if (dgTipoLogradouro.Rows.Count > 0)
            {
                dgTipoLogradouro.Rows[0].Selected = false;
            }
        }

        private void dgTipoLogradouro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {

                    Tipo_Logradouro oTipoLogradouro = new Tipo_Logradouro();
                    int IDTipoLogradouro = (int)dgTipoLogradouro.Rows[e.RowIndex].Cells["LogradouroID"].Value;
                    oTipoLogradouro = _ControllTipoLogradouro.Selecionar(IDTipoLogradouro);

                    if (dgTipoLogradouro.Columns[e.ColumnIndex].Name == "BtnExcluirGrid")
                    {
                        if (MessageBox.Show("Deseja realmente excluir?", "Cadastro Tipo Logradouro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                                _ControllTipoLogradouro.Excluir(oTipoLogradouro);

                                LimpaControles(this.Controls);
                                CarregarGrid();
                            }
                            catch (Exception ex)
                            {
                                if (ex.HResult.ToString() == "-2146233087")
                                {
                                    MessageBox.Show("Existem clientes cadastrados com essa informação!", "Cadastro Tipo de Logradouro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    else if (dgTipoLogradouro.Columns[e.ColumnIndex].Name == "BtnAlterarGrid")
                    {
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;

                        txtDescricao.Text = oTipoLogradouro.Descricao.ToString();
                       
                        idTipoLogradouro = oTipoLogradouro.LogradouroID;
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
                Tipo_Logradouro tipo_Logradouro = new Tipo_Logradouro();

                tipo_Logradouro.Descricao = txtDescricao.Text.ToString();
                _ControllTipoLogradouro.CadastrarTipoLogradouro(tipo_Logradouro);

                MessageBox.Show("Tipo Logradouro cadastrado com sucesso!", "Cadastro Tipo Logradouro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaControles(this.Controls);
                CarregarGrid();
            }
            else
            {
                MessageBox.Show("Preenchimento de campos obrigatórios!", "Cadastro Tipo de Logradouro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Tipo_Logradouro tipo_Logradouro = new Tipo_Logradouro();

            tipo_Logradouro = _ControllTipoLogradouro.Selecionar(idTipoLogradouro);

            if (VerificaControles(this.Controls))
            {
                tipo_Logradouro.Descricao = txtDescricao.Text;

                _ControllTipoLogradouro.Alterar(tipo_Logradouro);
                MessageBox.Show("Tipo Logradouro alterado com sucesso!", "Cadastro Tipo Logradouro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnAlterar.Enabled = false;
                btnSalvar.Enabled = true;

                LimpaControles(this.Controls);
                CarregarGrid();
            }
            else
            {
                MessageBox.Show("Preenchimento de campos obrigatórios!", "Cadastro Tipo Logradouro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
