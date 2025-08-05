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
    public partial class Usuario : Form
    {
        private DbContextUsuarios _context = new DbContextUsuarios();
        public Usuario()
        {
            InitializeComponent();
            CarregaListView();
        }

        private void LimparCampos()
        {
            txtLogin.Clear();
            txtNome.Clear();
            txtSenha.Clear();
        }

        public void CarregaListView()
        {
            _context = new DbContextUsuarios();
            lvUsuarios.Items.Clear();

            foreach (var usu in _context.Usuarios.OrderBy(p => p.id))
            {
                lvUsuarios.Items.Add(new ListViewItem
                (new String[] { usu.id.ToString(), usu.name, usu.usr, usu.tstamp.ToString()}));
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
            else if (txtLogin.Text == "")
            {
                MessageBox.Show("Login não pode ser vazio!");
                txtLogin.Focus();
                return false;
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Senha não pode ser vazio!");
                txtSenha.Focus();
                return false;
            }
            else return true;
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {//add                
                if (ChecarCampos())
                {
                    _context = new DbContextUsuarios();
                    Usuarios u = new Usuarios(
                        txtNome.Text,
                        txtLogin.Text,
                        txtSenha.Text,
                        DateTime.Now);
                    _context.Usuarios.Add(u);
                    _context.SaveChangesAsync();
                    CarregaListView();
                    MessageBox.Show("Sucesso!");
                    LimparCampos();
                }
            }
            else
            {//edit
                if (ChecarCampos())
                {
                    _context = new DbContextUsuarios();
                    int id = Int32.Parse(txtId.Text);
                    var u = _context.Usuarios.FirstOrDefault(e => e.id == id);

                    if (u is not null)
                    {
                        u.name = txtNome.Text;
                        u.usr = txtLogin.Text;
                        
                        _context.Usuarios.Update(u);
                        _context.SaveChangesAsync();
                        CarregaListView();
                        MessageBox.Show("Sucesso!");
                        LimparCampos();
                    }

                }
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
