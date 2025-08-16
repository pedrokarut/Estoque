using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estoque.Classes;
using Estoque.Databse;
using Microsoft.EntityFrameworkCore;

namespace Estoque
{
    public partial class Fornecedor : Form
    {
        private DbConnection _context = new DbConnection();
        public static Fornecedor instance;
        public bool veioCompra = false;
        public bool veioProd = false;

        public Fornecedor()
        {
            InitializeComponent();
            instance = this;
            CarregaListView();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        public void CarregaListView()
        {
            try
            {
                _context = new DbConnection();
                lvForn.Items.Clear();

                foreach (var prod in _context.Fornecedores.OrderBy(p => p.id))
                {
                    lvForn.Items.Add(new ListViewItem
                    (new String[] { prod.id.ToString(),
                                    prod.nome,
                                    prod.endereco,
                                    prod.cnpj,
                                    prod.incricao_estadual,
                                    prod.telefone
                    }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Limpar()
        {
            txtCNPJ.Clear();
            txtEndereco.Clear();
            txtId.Clear();
            txtInsc.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
        }

        private bool ChecarCampos()
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Nome não pode ser vazio!");
                txtNome.Focus();
                return false;
            }
            else if (txtEndereco.Text == "")
            {
                MessageBox.Show("Endereço não pode ser vazio!");
                txtEndereco.Focus();
                return false;
            }
            else if (txtInsc.Text == "")
            {
                MessageBox.Show("Inscrição não pode ser vazia!");
                txtInsc.Focus();
                return false;
            }
            else if (txtTelefone.Text == "")
            {
                MessageBox.Show("Telefone não pode ser vazio!");
                txtTelefone.Focus();
                return false;
            }
            else if (txtCNPJ.Text == "")
            {
                MessageBox.Show("CNPJ não pode ser vazio!");
                txtCNPJ.Focus();
                return false;
            }
            else return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {//add                
                if (ChecarCampos())
                {
                    _context = new DbConnection();
                    Fornecedores p = new Fornecedores();
                    p.nome = txtNome.Text;
                    p.endereco = txtEndereco.Text;
                    p.cnpj = txtCNPJ.Text;
                    p.incricao_estadual = txtInsc.Text;
                    p.telefone = txtTelefone.Text;
                    p.tstamp = DateTime.Now.ToString();
                    _context.Fornecedores.Add(p);
                    _context.SaveChangesAsync();
                    CarregaListView();
                    MessageBox.Show("Sucesso!");
                    Limpar();

                    try
                    {//Registro Histórico
                        Historicos h = new Historicos();
                        h.id_usu = Login.instance.usuLogado.id;
                        h.obs = "Fornecedor incluido " + p.id;
                        h.tstamp = DateTime.Now.ToString();

                        _context.Historicos.Add(h);
                        _context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            else
            {//edit
                if (ChecarCampos())
                {
                    _context = new DbConnection();
                    int id = Int32.Parse(txtId.Text);
                    var p = _context.Fornecedores.FirstOrDefault(e => e.id == id);

                    if (p is not null)
                    {
                        p.nome = txtNome.Text;
                        p.endereco = txtEndereco.Text;
                        p.cnpj = txtCNPJ.Text;
                        p.incricao_estadual = txtInsc.Text;
                        p.telefone = txtTelefone.Text;

                        _context.Fornecedores.Update(p);
                        _context.SaveChangesAsync();
                        CarregaListView();
                        MessageBox.Show("Sucesso!");
                        Limpar();

                        try
                        {//Registro Histórico
                            Historicos h = new Historicos();
                            h.id_usu = Login.instance.usuLogado.id;
                            h.obs = "Fornecedor alterado " + p.id;
                            h.tstamp = DateTime.Now.ToString();

                            _context.Historicos.Add(h);
                            _context.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }

                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Excluir Fornecedor?", "Confirmação",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (result == DialogResult.OK)
            {
                int id = Int32.Parse(txtId.Text);
                _context = new DbConnection();
                var p = _context.Fornecedores.FirstOrDefault(p => p.id == id);
                _context.Fornecedores.Remove(p);
                _context.SaveChangesAsync();
                Limpar();
                CarregaListView();

                try
                {//Registro Histórico
                    Historicos h = new Historicos();
                    h.id_usu = Login.instance.usuLogado.id;
                    h.obs = "Fornecedor excluido " + p.id;
                    h.tstamp = DateTime.Now.ToString();

                    _context.Historicos.Add(h);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private async Task FindFornecedores(int id)
        {
            if (id != 0)
            {
                _context = new DbConnection();
                var prod = _context.Fornecedores.FirstOrDefault(e => e.id == id);

                if (prod != null)
                {

                    txtId.Text = prod.id.ToString();
                    txtNome.Text = prod.nome;
                    txtEndereco.Text = prod.endereco;
                    txtCNPJ.Text = prod.cnpj;
                    txtInsc.Text = prod.incricao_estadual;
                    txtTelefone.Text = prod.telefone;
                }
            }
        }

        private void lvForn_DoubleClick(object sender, EventArgs e)
        {
            if(veioCompra)
            {
                veioCompra = false;

                if (lvForn.SelectedItems[0].Text != "")
                {
                    this.Hide();
                    Compra.instance.txtIdFornecedor.Text = lvForn.SelectedItems[0].Text;
                    var f = _context.Fornecedores.FirstOrDefault(p => p.id == Int32.Parse(Compra.instance.txtIdFornecedor.Text));
                    Compra.instance.txtNomeFornecedor.Text = f.nome;
                    Compra.instance.Show();
                }
            }
            if(veioProd)
            {
                veioProd = false;

                if (lvForn.SelectedItems[0].Text != "")
                {
                    this.Hide();
                    Produto.instance.txtIdFornecedor.Text = lvForn.SelectedItems[0].Text;
                    Produto.instance.Show();
                }
            }
            
        }

        private void lvForn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(lvForn.SelectedItems[0].Text);

            FindFornecedores(id);
        }

        private void lvForn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
