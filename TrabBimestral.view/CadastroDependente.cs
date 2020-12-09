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
    public partial class FrmCadastroDependente : Form
    {
        CCadDependente _ControlDependente = new CCadDependente();
        CCadCliente _ControlCliente = new CCadCliente();
        CCadTipoDependente _ControlTipoDependente = new CCadTipoDependente();
        CCadCliente _ControllCliente = new CCadCliente();

        int idDependenteAlter;
        int idClienteAlter;

        public FrmCadastroDependente()
        {
            InitializeComponent();
        }

        private void CadastroDependente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'clienteDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.clienteDataSet.Cliente);
            // TODO: esta linha de código carrega dados na tabela 'bimestralTrabDataSet2.Bairro'. Você pode movê-la ou removê-la conforme necessário.
            this.bairroTableAdapter.Fill(this.bimestralTrabDataSet2.Bairro);
            // TODO: esta linha de código carrega dados na tabela 'bimestralTrabDataSet.Tipo_Logradouro'. Você pode movê-la ou removê-la conforme necessário.
            this.tipo_LogradouroTableAdapter.Fill(this.bimestralTrabDataSet.Tipo_Logradouro);
            // TODO: esta linha de código carrega dados na tabela 'bimestralTrabDataSet1.Cidade'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadeTableAdapter.Fill(this.bimestralTrabDataSet1.Cidade);
            // TODO: esta linha de código carrega dados na tabela 'bimestralTrabDataSet4.TipoDependente'. Você pode movê-la ou removê-la conforme necessário.
            this.tipoDependenteTableAdapter.Fill(this.bimestralTrabDataSet4.TipoDependente);
            cbTipoDependente.SelectedIndex = -1;
            btnAlterar.Enabled = false;
            btnIncluir.Enabled = false;
            txtNomeDependente.Enabled = false;
            cbTipoDependente.Enabled = false;
            cbBairro.SelectedIndex = -1;
            //cbCidade.SelectedIndex = -1;
            cbLogradouro.SelectedIndex = -1;
            LimpaControles();
            BloquearCampos();
            cmbCliente.Enabled = true;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        public void BloquearCampos()
        {
            txtCPF.Enabled = false;
            txtLogradouro.Enabled = false;
            txtNome.Enabled = false;
            txtNomeDependente.Enabled = false;
            txtRG.Enabled = false;
            txtTelefone.Enabled = false;
            txtUF.Enabled = false;
            cbBairro.Enabled = false;
            cbCidade.Enabled = false;
            cbLogradouro.Enabled = false;
            cbTipoDependente.Enabled = false;
        }

        public void DesbloquearCampos()
        {
            txtCPF.Enabled = true;
            txtLogradouro.Enabled = true;
            txtNome.Enabled = true;
            txtNomeDependente.Enabled = true;
            txtRG.Enabled = true;
            txtTelefone.Enabled = true;
            txtUF.Enabled = true;
            cbBairro.Enabled = true;
            cbCidade.Enabled = true;
            cbLogradouro.Enabled = true;
            cbTipoDependente.Enabled = true;
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

        public void LimpaControles()
        {
            foreach (Control c in this.groupBox1.Controls)
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

            LimpaGrid();
        }

        public void CarregarGrid()
        {
            Cliente C = new Cliente();
            C = _ControlCliente.Selecionar(idClienteAlter);
            dgDependente.DataSource = null;
            dgDependente.Rows.Clear();
            //dgDependente.Refresh();
            dgDependente.AutoGenerateColumns = false;
            var list = _ControlDependente.SelecionarTodos();

            foreach (var l in list)
            {

                if (l.Cliente == C.ClienteID)
                {
                    var tipoDependente = _ControlTipoDependente.Selecionar(l.TipoDependente);

                    dgDependente.Rows.Add(l.DependenteID, l.Nome, tipoDependente.Tipo);
                }
            }
            if (dgDependente.Rows.Count > 0)
            {
                dgDependente.Rows[0].Selected = false;
            }
        }

        public void LimpaGrid()
        {
            dgDependente.DataSource = null;
            dgDependente.Rows.Clear();
            //dgDependente.Refresh();
            dgDependente.AutoGenerateColumns = false;
        }



        private void dgDependente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {

                    Dependente oDependente = new Dependente();
                    int IDDependente = (int)dgDependente.Rows[e.RowIndex].Cells["DependenteID"].Value;
                    oDependente = _ControlDependente.Selecionar(IDDependente);

                    if (dgDependente.Columns[e.ColumnIndex].Name == "btnExcluirGrid")
                    {
                        if (MessageBox.Show("Deseja realmente excluir?", "Cadastro Dependente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            _ControlDependente.Excluir(oDependente);
                            CarregarGrid();
                        }
                    }
                    else if (dgDependente.Columns[e.ColumnIndex].Name == "btnAlterarGrid")
                    {

                        btnAlterar.Enabled = true;
                        btnIncluir.Enabled = false;

                        txtNomeDependente.Text = oDependente.Nome;
                        //cbClienteVinculado.SelectedValue = oDependente.Cliente;
                        cbTipoDependente.SelectedValue = oDependente.TipoDependente;


                        idDependenteAlter = oDependente.DependenteID;
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

            if (idClienteAlter == 0) // Cadastro de novo cliente
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
                        MessageBox.Show("Cliente cadastrado com sucesso!", "Cadastro de clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.clienteTableAdapter.Fill(this.clienteDataSet.Cliente);
                        cmbCliente.SelectedIndex = -1;
                        cmbCliente.SelectedValue = C.ClienteID;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Preencher campos obrigatórios!", "Cadastro de Dependentes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else // Alteração de cliente
            {
                if (VerificaControles())
                {
                    Cliente C = new Cliente();

                    C = _ControlCliente.Selecionar(idClienteAlter);
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

                        _ControllCliente.Alterar(C);

                        this.clienteTableAdapter.Fill(this.clienteDataSet.Cliente);
                        cmbCliente.SelectedIndex = -1;
                        cmbCliente.SelectedValue = C.ClienteID;


                        MessageBox.Show("Cliente alterado com sucesso!", "Cadastro de clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Preencher campos obrigatórios!", "Cadastro de Dependentes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Dependente oDependente = new Dependente();
            int IDDependente = idDependenteAlter;
            oDependente = _ControlDependente.Selecionar(IDDependente);

            if (txtNomeDependente.Text != "" && cbTipoDependente.SelectedIndex > -1)
            {
                oDependente.Nome = txtNomeDependente.Text;
                oDependente.TipoDependente = (int)cbTipoDependente.SelectedValue;

                _ControlDependente.Alterar(oDependente);

                idDependenteAlter = 0;

                MessageBox.Show("Dependente Alterado com sucesso!", "Alteração de Dependente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnAlterar.Enabled = false;
                btnSalvar.Enabled = true;

                txtNomeDependente.Text = "";
                cbTipoDependente.SelectedIndex = -1;
                btnAlterar.Enabled = false;
                btnIncluir.Enabled = true;

                CarregarGrid();
            }
            else
            {
                MessageBox.Show("Preencher campos obrigatórios!", "Alteração de Dependente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaControles();
            txtNomeDependente.Text = "";
            cbTipoDependente.SelectedIndex = -1;
            txtNomeDependente.Enabled = false;
            cbTipoDependente.Enabled = false;
            idClienteAlter = 0;
            cmbCliente.SelectedIndex = -1;
            DesbloquearCampos();
            txtNomeDependente.Enabled = false;
            cbTipoDependente.Enabled = false;
            btnSalvar.Enabled = true;
            btnIncluir.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Cliente C = new Cliente();
            C = _ControlCliente.Selecionar(idClienteAlter);
            if (C.Nome == "")
            {

            }
            else if (C.Nome != "")
            {
                if (txtNomeDependente.Text != "" && cbTipoDependente.SelectedIndex > -1)
                {
                    Dependente Dep = new Dependente();
                    Dep.Cliente = C.ClienteID;
                    Dep.Nome = txtNomeDependente.Text;
                    Dep.TipoDependente = (int)cbTipoDependente.SelectedValue;

                    _ControlDependente.CadastrarDependente(Dep);
                    txtNomeDependente.Text = "";
                    cbTipoDependente.SelectedIndex = -1;

                    CarregarGrid();
                }
                else
                {
                    MessageBox.Show("Preencher campos obrigatórios!", "Alteração de Dependente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cmbCliente_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (cmbCliente.SelectedIndex > -1)
            {
                Cliente oCliente = new Cliente();

                oCliente = _ControlCliente.Selecionar(Convert.ToInt32(cmbCliente.SelectedValue));
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

                txtNomeDependente.Enabled = true;
                cbTipoDependente.Enabled = true;
                btnIncluir.Enabled = true;

                DesbloquearCampos();
                btnSalvar.Enabled = true;
                btnExcluir.Enabled = true;
                txtNomeDependente.Enabled = true;
                txtNomeDependente.Text = "";
                cbTipoDependente.Enabled = true;
                cbTipoDependente.SelectedIndex = -1;
                btnAlterar.Enabled = false;
                btnIncluir.Enabled = true;


                CarregarGrid();
            }
        }

        private void cmbCliente_TextUpdate_1(object sender, EventArgs e)
        {
            if (cmbCliente.Text == "")
            {
                LimpaControles();
                idClienteAlter = 0;
                BloquearCampos();
                btnSalvar.Enabled = false;
                btnIncluir.Enabled = false;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir?", "Exclusão de clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Dependente oDependente = new Dependente();
                Cliente C = new Cliente();

                C = _ControlCliente.Selecionar(idClienteAlter);


                var list = _ControlDependente.SelecionarTodos();
                foreach (var l in list)
                {
                    if (l.Cliente == C.ClienteID)
                    {
                        oDependente = _ControlDependente.Selecionar(l.DependenteID);
                        _ControlDependente.Excluir(oDependente);
                    }
                }
                _ControlCliente.Excluir(C);
                MessageBox.Show("Cliente excluído com sucesso!", "Exclusão de clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgDependente.DataSource = null;
                dgDependente.Rows.Clear();
                dgDependente.AutoGenerateColumns = false;
                idClienteAlter = 0;
                idDependenteAlter = 0;
                LimpaControles();
                this.clienteTableAdapter.Fill(this.clienteDataSet.Cliente);
                cmbCliente.SelectedIndex = -1;
                cmbCliente.Focus();
                btnExcluir.Enabled = false;

            }
        }
    }
}
