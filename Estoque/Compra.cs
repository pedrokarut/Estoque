using Estoque.Classes;
using Estoque.Databse;
using Microsoft.EntityFrameworkCore;

namespace Estoque
{
    public partial class Compra : Form
    {
        private Produto frmProd;
        private Fornecedor frmForn;
        public static Compra instance;
        private DbConnection _context = new DbConnection();
        int qtdAbreForn = 0;
        int qtdAbreProd = 0;
        public TextBox txtIdProduto;
        public TextBox txtNomeProduto;
        public TextBox txtIdFornecedor;
        public TextBox txtNomeFornecedor;

        private DbConnection _contextProd = new DbConnection();
        private DbConnection _contextForn = new DbConnection();

        public Compra()
        {
            InitializeComponent();
            CarregaListView();
            instance = this;
            this.CenterToScreen();
            txtIdProduto = txtIdProd;
            txtNomeProduto = txtProd;
            txtIdFornecedor = txtIdForn;
            txtNomeFornecedor = txtForn;

        }

       private void Limpar()
        {
            txtIdForn.Clear();
            txtIdProd.Clear();
            txtProd.Clear();
            txtForn.Clear();
            txtQtd.Clear();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(ChecarCampos())
            {
                Compras c = new Compras();
                c.id_prod = Int32.Parse(txtIdProd.Text);
                c.id_fornecedor = Int32.Parse(txtIdForn.Text);
                c.qtd = Int32.Parse(txtQtd.Text);
                c.tstamp = DateTime.Now.ToString();

                try
                {
                    var p = _contextProd.Produtos.FirstOrDefault(o => o.id == c.id_prod);
                    var qtdNova = p.qtd + c.qtd;
                    p.qtd = qtdNova;
                    _contextProd.Produtos.Update(p);
                    _contextProd.SaveChanges();

                    try
                    {//Registro Histórico
                        Historicos h = new Historicos();
                        h.id_usu = Login.instance.usuLogado.id;
                        h.obs = "Compra realizada " + p.id;
                        h.tstamp = DateTime.Now.ToString();

                        _context.Historicos.Add(h);
                        _context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Qtd do prod não atualizada " + ex.Message);
                }
                

                try
                {
                    _context = new DbConnection();
                    _context.Compras.Add(c);
                    _context.SaveChanges();
                    MessageBox.Show("Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Limpar();
                CarregaListView();
            }
            
        }

        public void CarregaListView()
        {
            try
            {
                _context = new DbConnection();
                lvCompras.Items.Clear();

                foreach (var prod in _context.Compras.OrderBy(p => p.id))
                {
                    var p = _contextProd.Produtos.FirstOrDefault(o => o.id == prod.id_prod);
                    var f = _contextForn.Fornecedores.FirstOrDefault(l => l.id == prod.id_fornecedor);
                    lvCompras.Items.Add(new ListViewItem
                    (new String[] { prod.id.ToString(),
                                    p.name,
                                    f.nome,
                                    prod.qtd.ToString()
                    }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private bool ChecarCampos()
        {
            if (txtForn.Text == "")
            {
                MessageBox.Show("Fornecedor não pode ser vazio!");
                txtForn.Focus();
                return false;
            }
            else if (txtProd.Text == "")
            {
                MessageBox.Show("Produto não pode ser vazio!");
                txtProd.Focus();
                return false;
            }
            else if (txtQtd.Text == "")
            {
                if(txtQtd.Text != "" && Int32.Parse(txtQtd.Text) > 0)
                {
                    MessageBox.Show("Quantidade deve ser maior que 0");
                    txtQtd.Focus();
                    return false;
                }
                else
                {
                    MessageBox.Show("Quantidade não pode ser vazia");
                    txtQtd.Focus();
                    return false;
                }
                
            }
            else return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            if (qtdAbreProd == 0)
            {
                frmProd = new Produto();
                frmProd.veioCompra = true;                
                frmProd.ShowDialog();                
            }
            else
            {
                Produto.instance.ShowDialog();
            }
        }

        private void btnForn_Click(object sender, EventArgs e)
        {
            if (qtdAbreProd == 0)
            {
                frmForn = new Fornecedor();
                frmForn.veioCompra=true;
                frmForn.ShowDialog();
            }
            else
            {
                Fornecedor.instance.ShowDialog();
            }
        }

        private void lvCompras_Click(object sender, EventArgs e)
        {

        }

        private void lvCompras_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
