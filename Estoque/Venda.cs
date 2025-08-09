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

namespace Estoque
{
    public partial class Venda : Form
    {
        public static Venda instance;
        public ListView listProd;
        private int qtdAbreProd = 0;
        private int qtdAbreCli = 0;
        private Produto frmProd;
        private Cliente frmCli;
        public TextBox txtId;
        public TextBox txtNome;
        public TextBox txtMargem;
        public TextBox txtIdCliente;
        public TextBox txtNomeCliente;


        public Venda()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            instance = this;
            listProd = listView1;
            txtId = txtIdProdSel;
            txtNome = txtNomeProd;
            txtMargem = txtMargemSel;
            txtIdCliente = txtIdCli;
            txtNomeCliente = txtNomeCli;
        }

        private void LimparCamposProdutos()
        {
            txtIdProdSel.Clear();
            txtNomeProd.Clear();
            txtQtd.Clear();
            txtMargem.Clear();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (qtdAbreProd == 0)
            {
                frmProd = new Produto();
                frmProd.StartPosition = FormStartPosition.CenterScreen;
                frmProd.ShowDialog();
            }
            else
            {
                Produto.instance.ShowDialog();
            }

        }

        private void Venda_Enter(object sender, EventArgs e)
        {

        }

        private void Venda_Activated(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {//add na sacola

            if (txtQtd.Text != "")
            {
                if (Int32.Parse(txtQtd.Text) > 0)
                {
                    listProd.Items.Add(new ListViewItem
                    (new String[] {
                                txtId.Text,
                                txtNomeProd.Text,
                                txtQtd.Text,
                                txtMargem.Text
                    }));
                    LimparCamposProdutos();
                }
                else
                {
                    MessageBox.Show("Quantidade não pode ser zero");
                }
            }
            else
            {
                MessageBox.Show("Quantidade não pode ser vazia");
            }


        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            if (qtdAbreProd == 0)
            {
                frmProd = new Produto();
                frmProd.ShowDialog();
            }
            else
            {
                Produto.instance.ShowDialog();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //add na sacola

            if (txtQtd.Text != "")
            {
                if (Int32.Parse(txtQtd.Text) > 0)
                {
                    listProd.Items.Add(new ListViewItem
                    (new String[] {
                                txtId.Text,
                                txtNomeProd.Text,
                                txtQtd.Text,
                                txtMargem.Text
                    }));
                    LimparCamposProdutos();
                }
                else
                {
                    MessageBox.Show("Quantidade não pode ser zero");
                }
            }
            else
            {
                MessageBox.Show("Quantidade não pode ser vazia");
            }
        }

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            if (qtdAbreCli == 0)
            {
                frmCli = new Cliente();
                frmCli.StartPosition = FormStartPosition.CenterScreen;
                frmCli.ShowDialog();
            }
            else
            {
                Cliente.instance.ShowDialog();
            }
        }
    }
}
