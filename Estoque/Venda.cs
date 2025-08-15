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
        private decimal total = 0;
        private int idVen = 0;
        private DbConnection _context = new DbConnection();


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
                frmProd.veioVenda = true;
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            if (listProd.Items.Count > 0)
            {
                foreach (ListViewItem i in listProd.Items)
                {

                    total += decimal.Parse(i.SubItems[3].Text);
                }
                txtTotal.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("Sacola de produtos vazia!");
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            

            if (ChecarCampos())
            {
                Vendas v = new Vendas();
                v.id_usuario = 0;
                v.id_cliente = Int32.Parse(txtIdCliente.Text);
                v.valor_total = total;
                v.forma_pagamento = cbFormaPagamento.Text;
                v.tstamp = DateTime.Now.ToString();
                v.obs = txtObs.Text;                    

                try
                {
                    _context = new DbConnection();
                    _context.Vendas.Add(v);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                idVen = v.id;


                foreach (ListViewItem i in listProd.Items)
                {
                    try
                    {

                        _context = new DbConnection();
                        ItemVenda iv = new ItemVenda();
                        iv.id_venda = idVen;
                        iv.id_usuario = 0;
                        iv.id_cliente = Int32.Parse(txtIdCliente.Text);
                        iv.id_produto = Int32.Parse(i.SubItems[0].Text);
                        iv.valor = decimal.Parse(i.SubItems[3].Text);
                        iv.quantidade = Int32.Parse(i.SubItems[2].Text);
                        iv.tstamp = DateTime.Now.ToString();

                        _context.ItemVenda.Add(iv);
                        _context.SaveChanges();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                MessageBox.Show("Sucesso");
                LimparCampos();

            }
                
            
        }

        private bool ChecarCampos()
        {
            if (txtIdCliente.Text == "")
            {
                MessageBox.Show("Cliente não pode ser vazio!");
                txtIdCliente.Focus();
                return false;
            }
            else if (cbFormaPagamento.Text == "")
            {
                MessageBox.Show("Forma de pagamento não pode ser vazia!");
                cbFormaPagamento.Focus();
                return false;
            }
            else if (listProd.Items.Count <= 0)
            {
                MessageBox.Show("Deve haver produtos!");
                listProd.Focus();
                return false;
            }
            else if (txtTotal.Text == "")
            {
                MessageBox.Show("Deve realizar o cálculo antes");
                btnCalcular.Focus();
                return false;
            }
            else return true;
        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtIdCliente.Clear();
            txtMargem.Clear();
            txtNome.Clear();
            txtNomeCliente.Clear();
            txtNomeProd.Clear();
            txtObs.Clear();
            txtQtd.Clear();
            txtTotal.Clear();
            txtIdProdSel.Clear();
            cbFormaPagamento.Text = "";
        }
    }
}



