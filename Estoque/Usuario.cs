using System.Data;
using Estoque.Classes;
using Estoque.Databse;

namespace Estoque
{
    public partial class Usuario : Form
    {
        private DbConnection _context = new DbConnection();
        public Usuario()
        {
            InitializeComponent();
            CarregaListView();
        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtLogin.Clear();
            txtNome.Clear();
            txtSenha.Clear();
        }

        public void CarregaListView()
        {
            lvUsuarios.Items.Clear();

            foreach (var usu in _context.Usuarios.OrderBy(p => p.id))
            {
                lvUsuarios.Items.Add(new ListViewItem
                (new String[] { usu.id.ToString(), usu.name, usu.usr, usu.tstamp.ToString() }));
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
                    Usuarios u = new Usuarios(
                        txtNome.Text,
                        txtLogin.Text,
                        txtSenha.Text,
                        DateTime.Now.ToString());
                    _context.Usuarios.Add(u);
                    _context.SaveChanges();
                    CarregaListView();
                    MessageBox.Show("Sucesso!");
                    LimparCampos();
                }
            }
            else
            {//edit
                if (ChecarCampos())
                {
                    int id = Int32.Parse(txtId.Text);
                    var u = _context.Usuarios.FirstOrDefault(e => e.id == id);

                    if (u is not null)
                    {
                        u.name = txtNome.Text;
                        u.usr = txtLogin.Text;

                        _context.Usuarios.Update(u);
                        _context.SaveChanges();
                        CarregaListView();
                        MessageBox.Show("Sucesso!");
                        LimparCampos();
                    }

                }
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Excluir produto?", "Confirmação",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (result == DialogResult.OK)
            {
                int id = Int32.Parse(txtId.Text);
                _context = new DbConnection();
                var p = _context.Produtos.FirstOrDefault(p => p.id == id);
                _context.Produtos.Remove(p);
                _context.SaveChanges();
                LimparCampos();
                CarregaListView();
            }
        }

        private void lvUsuarios_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(lvUsuarios.SelectedItems[0].Text);

            FindUsuarios(id);
        }

        private async Task FindUsuarios(int id)
        {
            if (id != 0)
            {
                var usu = _context.Usuarios.FirstOrDefault(e => e.id == id);

                if (usu != null)
                {

                    txtId.Text = usu.id.ToString();
                    txtNome.Text = usu.name;
                    txtLogin.Text = usu.usr;
                    txtSenha.Text = usu.senha;
                }
            }
        }
    }
}
