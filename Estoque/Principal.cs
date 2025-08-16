using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void compraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Compra c = new Compra();
            c.ShowDialog();
        }

        private void vendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Venda v = new Venda();
            v.ShowDialog();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Produto p = new Produto();
            p.ShowDialog();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.ShowDialog();
        }

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Fornecedor f = new Fornecedor();
            f.ShowDialog();
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.ShowDialog();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
