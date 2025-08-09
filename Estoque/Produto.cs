using System.Threading.Tasks;
using Estoque.Classes;
using Estoque.Databse;
using Microsoft.EntityFrameworkCore;

namespace Estoque
{
    public partial class Produto : Form
    {
        private DbConnection _context = new DbConnection();
        public static Produto instance;
        public Produto()
        {
            InitializeComponent();
            CarregaListView();
            instance = this;
        }


        public void CarregaListView()
        {
            _context = new DbConnection();
            lvProdutos.Items.Clear();

            foreach (var prod in _context.Produtos.OrderBy(p => p.id))
            {
                lvProdutos.Items.Add(new ListViewItem
                (new String[] 
                {   prod.id.ToString(), 
                    prod.name, 
                    prod.value.ToString(), 
                    prod.litros.ToString(), 
                    prod.cod_barras, 
                    prod.custo.ToString(),
                    (((prod.value - prod.custo)/100) * 100).ToString() + "%"
                }
                ));
            }


        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {//add                
                if (ChecarCampos())
                {
                    _context = new DbConnection();
                    Produtos p = new Produtos(
                        txtNome.Text,
                        double.Parse(txtValor.Text),
                        Int32.Parse(txtLitros.Text),
                        txtCodBarras.Text);
                    _context.Produtos.Add(p);
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
                    var p = _context.Produtos.FirstOrDefault(e => e.id == id);

                    if (p is not null)
                    {
                        p.litros = Int32.Parse(txtLitros.Text);
                        p.value = double.Parse(txtValor.Text);
                        p.name = txtNome.Text;
                        p.cod_barras = txtCodBarras.Text;

                        _context.Produtos.Update(p);
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
            else if (txtLitros.Text == "")
            {
                MessageBox.Show("Litros não pode ser vazio!");
                txtLitros.Focus();
                return false;
            }
            else if (txtValor.Text == "")
            {
                MessageBox.Show("Valor não pode ser vazio!");
                txtValor.Focus();
                return false;
            }
            else if (txtCodBarras.Text == "")
            {
                MessageBox.Show("Código de barras não pode ser vazio!");
                txtCodBarras.Focus();
                return false;
            }
            else return true;
        }

        private async Task FindProdutos(int id)
        {
            if (id != 0)
            {
                _context = new DbConnection();
                var prod = _context.Produtos.FirstOrDefault(e => e.id == id);

                if (prod != null)
                {

                    txtId.Text = prod.id.ToString();
                    txtNome.Text = prod.name;
                    txtValor.Text = prod.value.ToString();
                    txtLitros.Text = prod.litros.ToString();
                    txtCodBarras.Text = prod.cod_barras.ToString();
                }
            }
        }


        private void lvProdutos_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(lvProdutos.SelectedItems[0].Text);

            FindProdutos(id);
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            CarregaListView();
            txtCodBarras.Clear();
            txtLitros.Clear();
            txtNome.Clear();
            txtId.Clear();
            txtValor.Clear();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Excluir produto?", "Confirmação",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (result == DialogResult.OK)
            {
                int id = Int32.Parse(txtId.Text);
                _context = new DbConnection();
                var p = _context.Produtos.FirstOrDefault(p => p.id == id);
                _context.Produtos.Remove(p);
                _context.SaveChangesAsync();
                Limpar();
                CarregaListView();
            }
        }

        private void lvProdutos_DoubleClick(object sender, EventArgs e)
        {
            if(lvProdutos.SelectedItems[0].Text != "")
            {
                //Venda v = new Venda(Int32.Parse(lvProdutos.SelectedItems[0].Text), "prod");
                this.Hide();
                Venda.instance.txtId.Text = lvProdutos.SelectedItems[0].Text;
                int id = Int32.Parse(txtId.Text);
                _context = new DbConnection();
                var p = _context.Produtos.FirstOrDefault(p => p.id == id);
                Venda.instance.txtNome.Text = p.name;
                Venda.instance.txtMargem.Text = p.value.ToString();
                Venda.instance.Show();
            }
            
        }
    }
}
