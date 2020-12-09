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
    public partial class FrmCadastroCliente : Form
    {
        CCadCliente _ControllCliente = new CCadCliente();
        CCadTipoLogradouro _ControllTipoLogradouro = new CCadTipoLogradouro();
        CCadBairro _ControllBairro = new CCadBairro();
        CCadCidade _ControllCidade = new CCadCidade();
        CCadDependente _ControlDependente = new CCadDependente();
        int idClienteAlter;
     


        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

        private void FrmCadastroCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bimestralTrabDataSet3.TipoDependente'. Você pode movê-la ou removê-la conforme necessário.
            this.tipoDependenteTableAdapter.Fill(this.bimestralTrabDataSet3.TipoDependente);
            // TODO: esta linha de código carrega dados na tabela 'bimestralTrabDataSet2.Bairro'. Você pode movê-la ou removê-la conforme necessário.
            this.bairroTableAdapter.Fill(this.bimestralTrabDataSet2.Bairro);
            // TODO: esta linha de código carrega dados na tabela 'bimestralTrabDataSet1.Cidade'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadeTableAdapter.Fill(this.bimestralTrabDataSet1.Cidade);
            // TODO: esta linha de código carrega dados na tabela 'bimestralTrabDataSet.Tipo_Logradouro'. Você pode movê-la ou removê-la conforme necessário.
            this.tipo_LogradouroTableAdapter.Fill(this.bimestralTrabDataSet.Tipo_Logradouro);
            cbLogradouro.SelectedIndex = -1;
            cbCidade.SelectedIndex = -1;
            cbBairro.SelectedIndex = -1;
            CarregarGrid();
            btnAlterar.Enabled = false;
        }

        public bool VerificaControles()
        {
            if (txtNome.Text == "")
            {
                return false;
            }
            if (cbBairro.SelectedIndex == -1)
            {
                return false;
            }
            if (cbCidade.SelectedIndex == -1)
            {
                return false;
            }
            if (txtCPF.Text == "")
            {
                return false;
            }
            if (txtLogradouro.Text == "")
            {
                return false;
            }
            if (txtRG.Text == "")
            {
                return false;
            }
            if (txtTelefone.Text == "")
            {
                return false;
            }
            if (txtUF.Text == "")
            {
                return false;
            }
            if (cbLogradouro.SelectedIndex == -1)
            {
                return false;
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
                if (c is MaskedTextBox)
                {
                    c.Text = "";
                }
            }
        }

        public void CarregarGrid()
        {
            dgCliente.DataSource = null;
            dgCliente.Rows.Clear();
            //dgCliente.Refresh();
            dgCliente.AutoGenerateColumns = false;
            var list = _ControllCliente.SelecionarTodos();

            foreach (var l in list)
            {
                var tipoLogadradouro = _ControllTipoLogradouro.Selecionar(l.TipoLogradouro);
                var bairro = _ControllBairro.Selecionar(l.Bairro);
                var cidade = _ControllCidade.Selecionar(l.Cidade);
                string tel = Convert.ToString(l.Telefone);
                tel = tel.Insert(0, "(");
                tel = tel.Insert(3, ")");
                tel = tel.Insert(9, "-");

                string rg = Convert.ToString(l.RG);
                rg = rg.Insert(2, ".");
                rg = rg.Insert(6, ".");
                rg = rg.Insert(10, "-");

                string cpf = Convert.ToString(l.CPF);
                cpf = cpf.Insert(3, ".");
                cpf = cpf.Insert(7, ".");
                cpf = cpf.Insert(11, ".");

                dgCliente.Rows.Add(l.ClienteID, l.Nome, tipoLogadradouro.Descricao, l.Logradouro, bairro.Nome, cidade.Nome, l.UF, tel, cpf, rg);
            }
            if (dgCliente.Rows.Count > 0)
            {
                dgCliente.Rows[0].Selected = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (VerificaControles())
            {
                Cliente C = new Cliente();
                try
                {
                    C.Nome = txtNome.Text;
                    C.TipoLogradouro = Convert.ToInt32(cbLogradouro.SelectedValue);
                    C.Logradouro = txtLogradouro.Text;
                    C.Bairro = Convert.ToInt32(cbBairro.SelectedValue);
                    C.Cidade = Convert.ToInt32(cbCidade.SelectedValue);
                    C.UF = txtUF.Text;

                    string tel = txtTelefone.Text;
                    tel = tel.Replace("-", "");
                    tel = tel.Replace("(", "");
                    tel = tel.Replace(")", "");
                    C.Telefone = Convert.ToInt64(tel);

                    string cpf = txtCPF.Text;
                    cpf = cpf.Replace("-", "");
                    cpf = cpf.Replace(",", "");
                    C.CPF = Convert.ToInt64(cpf);

                    string rg = txtRG.Text;
                    rg = rg.Replace("-", "");
                    rg = rg.Replace(",", "");
                    C.RG = Convert.ToInt64(rg);

                    _ControllCliente.CadastrarCliente(C);

                    MessageBox.Show("Cliente cadastrado com sucesso","Cadastro de clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaControles(this.Controls);
                    CarregarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencher campos obrigatórios", "Cadastro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void cbCidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {

                    Cliente oCliente = new Cliente();
                    
                    int IDCliente = (int)dgCliente.Rows[e.RowIndex].Cells["ClienteID"].Value;
                    oCliente = _ControllCliente.Selecionar(IDCliente);
                    

                    if (dgCliente.Columns[e.ColumnIndex].Name == "BtnExcluirGrid")
                    {
                        Dependente oDependente = new Dependente();
                        var list = _ControlDependente.SelecionarTodos();
                        if (MessageBox.Show("Deseja realmente excluir?", "Cadastro Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            foreach (var l in list)
                            {
                                if (l.Cliente == oCliente.ClienteID)
                                {
                                    oDependente = _ControlDependente.Selecionar(l.DependenteID);
                                    _ControlDependente.Excluir(oDependente);
                                }
                            }
                            _ControllCliente.Excluir(oCliente);
                            LimpaControles(this.Controls);
                            CarregarGrid();
                        }
                    }
                    else if (dgCliente.Columns[e.ColumnIndex].Name == "BtnAlterarGrid")
                    {
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;

                        txtNome.Text = oCliente.Nome.ToString();
                        txtLogradouro.Text = oCliente.Logradouro.ToString();
                        cbCidade.SelectedValue = oCliente.Cidade;
                        txtRG.Text = oCliente.RG.ToString();
                        cbLogradouro.SelectedValue = oCliente.TipoLogradouro;
                        txtUF.Text = oCliente.UF.ToString();
                        txtCPF.Text = oCliente.CPF.ToString();
                        txtTelefone.Text = oCliente.Telefone.ToString();
                        cbBairro.SelectedValue = oCliente.Bairro;

                        idClienteAlter = oCliente.ClienteID;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cliente oCliente = new Cliente();
            int IDCliente = idClienteAlter;
            oCliente = _ControllCliente.Selecionar(IDCliente);

            if (VerificaControles())
            {
                oCliente.Nome = txtNome.Text;
                oCliente.Logradouro = txtLogradouro.Text;
                oCliente.Cidade = (int)cbCidade.SelectedValue;

                string rg = txtRG.Text;
                rg = rg.Replace("-", "");
                rg = rg.Replace(",", "");
                oCliente.RG = Convert.ToInt64(rg);

                oCliente.TipoLogradouro = (int)cbLogradouro.SelectedValue;
                oCliente.UF = txtUF.Text;

                string cpf = txtCPF.Text;
                cpf = cpf.Replace("-", "");
                cpf = cpf.Replace(",", "");
                oCliente.CPF = Convert.ToInt64(cpf);

                string tel = txtTelefone.Text;
                tel = tel.Replace("-", "");
                tel = tel.Replace("(", "");
                tel = tel.Replace(")", "");
                oCliente.Telefone = Convert.ToInt64(tel);
                oCliente.Bairro = (int)cbBairro.SelectedValue;

                _ControllCliente.Alterar(oCliente);

                idClienteAlter = 0;

                MessageBox.Show("Cliente Alterado com sucesso", "Alteração de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnAlterar.Enabled = false;
                btnSalvar.Enabled = true;

                LimpaControles(this.Controls);
                CarregarGrid();
            }
            else
            {
                MessageBox.Show("Preencher campos obrigatórios", "Alteração de cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }


    }
}
