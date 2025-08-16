using Estoque.Classes;
using Estoque.Databse;

namespace Estoque
{
    public partial class Login : Form
    {
        private DbConnection _context = new DbConnection();
        public Usuarios usuLogado;
        public static Login instance;
        public Login()
        {
            InitializeComponent();
            this.CenterToScreen();
            instance = this;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(txtUsu.Text != "")
            {
                if(txtSenha.Text != "")
                {
                    try
                    {
                        _context = new DbConnection();
                        var usu = _context.Usuarios.FirstOrDefault(i => i.usr == txtUsu.Text);

                        if (usu != null)
                        {
                            if (usu.senha == txtSenha.Text)
                            {
                                usuLogado = usu;
                                Principal p = new Principal();
                                this.Hide();
                                p.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Usuário ou senha incorretos");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuário não encontrado");
                        }
                        
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Digite a senha");
                    txtSenha.Focus();
                }
                
            }
            else
            {
                MessageBox.Show("Digite o usuário");
                txtUsu.Focus();
            }
            
            
            
        }
    }
}
