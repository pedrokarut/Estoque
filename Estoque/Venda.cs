using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque
{
    public partial class Venda : Form
    {
        public static Venda instance;
        public ListView listProd;
        private int qtdAbreProd = 0;
        private Produto frmProd;


        public Venda()
        {
            InitializeComponent();
            instance = this;
            listProd = listView1;
        }

        //public Venda(int id, string tela)
        //{
          //  InitializeComponent();
            //frmProd = new Produto();
          //  if (id != 0 && tela == "prod")
         //   {
        //        listBox1.Items.Add(id.ToString());
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            if(qtdAbreProd == 0)
            {
                frmProd = new Produto();
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
        {
        }
    }
}
