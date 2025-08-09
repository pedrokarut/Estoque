using System.Data;
using Estoque.Classes;
using Estoque.Databse;
using Microsoft.EntityFrameworkCore;

namespace Estoque
{
    public partial class Cliente : Form
    {
        private DbConnection _context = new DbConnection();
        public static Cliente instance;
        public Cliente()
        {
            InitializeComponent();
            instance = this;
            CarregaListView();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {//add                
                if (ChecarCampos())
                {
                    _context = new DbConnection();
                    Clientes p = new Clientes(
                        txtNome.Text,
                        txtEnd.Text,
                        txtCnpj.Text,
                        txtInsc.Text,
                        txtTelefone.Text,
                        DateTime.Now.ToString());
                    _context.Clientes.Add(p);
                    _context.SaveChangesAsync();
                    CarregaListView();
                    MessageBox.Show("Sucesso!");
                    Limpar();
                }
            }
            else
            {//edit
                if (ChecarCampos())
                {
                    _context = new DbConnection();
                    int id = Int32.Parse(txtId.Text);
                    var p = _context.Clientes.FirstOrDefault(e => e.id == id);

                    if (p is not null)
                    {
                        p.nome = txtNome.Text;
                        p.endereco = txtEnd.Text;
                        p.cnpj = txtCnpj.Text;
                        p.incricao_estadual = txtInsc.Text;
                        p.telefone = txtTelefone.Text;

                        _context.Clientes.Update(p);
                        _context.SaveChangesAsync();
                        CarregaListView();
                        MessageBox.Show("Sucesso!");
                        Limpar();
                    }

                }
            }

        }

        private bool ChecarCampos()
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Nome não pode ser vazio!");
                txtNome.Focus();
                return false;
            }
            else if (txtEnd.Text == "")
            {
                MessageBox.Show("Endereço não pode ser vazio!");
                txtEnd.Focus();
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
            else if (txtCnpj.Text == "")
            {
                MessageBox.Show("CNPJ não pode ser vazio!");
                txtCnpj.Focus();
                return false;
            }
            else return true;
        }

        private void Limpar()
        {
            CarregaListView();
            txtId.Clear();
            txtNome.Clear();
            txtEnd.Clear();
            txtInsc.Clear();
            txtCnpj.Clear();
            txtTelefone.Clear();
        }

        public void CarregaListView()
        {
            _context = new DbConnection();
            lvClientes.Items.Clear();

            foreach (var prod in _context.Clientes.OrderBy(p => p.id))
            {
                lvClientes.Items.Add(new ListViewItem
                (new String[] { prod.id.ToString(),
                                prod.nome,
                                prod.endereco,
                                prod.cnpj,
                                prod.incricao_estadual,
                                prod.telefone
                }));
            }


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Excluir Cliente?", "Confirmação",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (result == DialogResult.OK)
            {
                int id = Int32.Parse(txtId.Text);
                _context = new DbConnection();
                var p = _context.Clientes.FirstOrDefault(p => p.id == id);
                _context.Clientes.Remove(p);
                _context.SaveChangesAsync();
                Limpar();
                CarregaListView();
            }
        }

        private void lvClientes_DoubleClick(object sender, EventArgs e)
        {
            if (lvClientes.SelectedItems[0].Text != "")
            {
                this.Hide();
                Venda.instance.txtIdCliente.Text = lvClientes.SelectedItems[0].Text;
                int id = Int32.Parse(txtId.Text);
                _context = new DbConnection();
                var p = _context.Clientes.FirstOrDefault(p => p.id == id);
                Venda.instance.txtNomeCliente.Text = p.nome;
                Venda.instance.Show();
            }
        }

        private void lvClientes_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(lvClientes.SelectedItems[0].Text);

            FindClientes(id);
        }

        private async Task FindClientes(int id)
        {
            if (id != 0)
            {
                _context = new DbConnection();
                var prod = _context.Clientes.FirstOrDefault(e => e.id == id);

                if (prod != null)
                {

                    txtId.Text = prod.id.ToString();
                    txtNome.Text = prod.nome;
                    txtEnd.Text = prod.endereco;
                    txtCnpj.Text = prod.cnpj;
                    txtInsc.Text = prod.incricao_estadual;
                    txtTelefone.Text = prod.telefone;
                }
            }
        }
    }
}
