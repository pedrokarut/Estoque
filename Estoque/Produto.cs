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
        private Fornecedor frmForn;
        private int qtdAbreProd = 0;
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
                    prod.margem.ToString(),
                    prod.id_fornecedor.ToString(),
                    prod.qtd.ToString(),
                    (((prod.value - prod.custo)/100) * 100).ToString() + "%"
                }
                ));
            }
            //fazer cálculo da margem de lucro

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {//add                
                if (ChecarCampos())
                {
                    _context = new DbConnection();
                    Produtos p = new Produtos();
                    p.name = txtNome.Text;
                    p.value = double.Parse(txtValor.Text);
                    p.litros = Int32.Parse(txtLitros.Text);
                    p.cod_barras = txtCodBarras.Text;
                    p.custo = double.Parse(txtCusto.Text);
                    p.margem = 0;
                    p.id_fornecedor = 0;
                    p.qtd = Int32.Parse(txtQtd.Text);

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
                        p.custo = double.Parse(txtCusto.Text);
                        p.margem = 0;
                        p.id_fornecedor = 0; // Int32.Parse(txtIdForn.Text);
                        p.qtd = Int32.Parse(txtQtd.Text);

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
            else if (txtCusto.Text == "")
            {
                MessageBox.Show("Custo não pode ser vazio!");
                txtCusto.Focus();
                return false;
            }
            else if (txtQtd.Text == "")
            {
                MessageBox.Show("Quantidade não pode ser vazia!");
                txtQtd.Focus();
                return false;
            }
            else if (txtFornecedor.Text == "")
            {
                MessageBox.Show("Fornecedor não pode ser vazio!");
                txtFornecedor.Focus();
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
                    txtCusto.Text = prod.custo.ToString();
                    txtQtd.Text = prod.qtd.ToString();
                    txtMargem.Text = prod.margem.ToString();
                    txtIdForn.Text = prod.id_fornecedor.ToString();
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
            txtCusto.Clear();
            txtFornecedor.Clear();
            txtIdForn.Clear();
            txtQtd.Clear();
            txtMargem.Clear();
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
            if (lvProdutos.SelectedItems[0].Text != "")
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnForn_Click(object sender, EventArgs e)
        {
            if (qtdAbreProd == 0)
            {
                frmForn = new Fornecedor();
                frmForn.ShowDialog();
            }
            else
            {
                Fornecedor.instance.ShowDialog();
            }
        }
    }
}
