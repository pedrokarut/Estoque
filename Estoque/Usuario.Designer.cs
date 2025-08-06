namespace Estoque
{
    partial class Usuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            txtLogin = new TextBox();
            btNovo = new Button();
            btExcluir = new Button();
            btSalvar = new Button();
            lvUsuarios = new ListView();
            id = new ColumnHeader();
            nome = new ColumnHeader();
            login = new ColumnHeader();
            data = new ColumnHeader();
            txtId = new TextBox();
            txtSenha = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 55);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 96);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Login:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(97, 52);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(156, 23);
            txtNome.TabIndex = 2;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(97, 92);
            txtLogin.Margin = new Padding(3, 2, 3, 2);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(156, 23);
            txtLogin.TabIndex = 3;
            // 
            // btNovo
            // 
            btNovo.Location = new Point(12, 171);
            btNovo.Name = "btNovo";
            btNovo.Size = new Size(75, 23);
            btNovo.TabIndex = 4;
            btNovo.Text = "Novo";
            btNovo.UseVisualStyleBackColor = true;
            btNovo.Click += btNovo_Click;
            // 
            // btExcluir
            // 
            btExcluir.Location = new Point(178, 171);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(75, 23);
            btExcluir.TabIndex = 5;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = true;
            btExcluir.Click += btExcluir_Click;
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(97, 171);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(75, 23);
            btSalvar.TabIndex = 6;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // lvUsuarios
            // 
            lvUsuarios.Columns.AddRange(new ColumnHeader[] { id, nome, login, data });
            lvUsuarios.Location = new Point(276, 54);
            lvUsuarios.Name = "lvUsuarios";
            lvUsuarios.Size = new Size(280, 112);
            lvUsuarios.TabIndex = 7;
            lvUsuarios.UseCompatibleStateImageBehavior = false;
            lvUsuarios.View = View.Details;
            lvUsuarios.Click += lvUsuarios_Click;
            // 
            // id
            // 
            id.Text = "Id";
            id.Width = 25;
            // 
            // nome
            // 
            nome.Text = "Nome";
            nome.Width = 150;
            // 
            // login
            // 
            login.Text = "Login";
            login.Width = 100;
            // 
            // data
            // 
            data.Text = "Data Criação";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.InactiveCaption;
            txtId.Enabled = false;
            txtId.Location = new Point(12, 29);
            txtId.Name = "txtId";
            txtId.Size = new Size(27, 23);
            txtId.TabIndex = 8;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(97, 125);
            txtSenha.Margin = new Padding(3, 2, 3, 2);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(156, 23);
            txtSenha.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 129);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 9;
            label3.Text = "Senha:";
            // 
            // Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 241);
            Controls.Add(txtSenha);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(lvUsuarios);
            Controls.Add(btSalvar);
            Controls.Add(btExcluir);
            Controls.Add(btNovo);
            Controls.Add(txtLogin);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Usuario";
            Text = "Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private TextBox txtLogin;
        private Button btNovo;
        private Button btExcluir;
        private Button btSalvar;
        private ListView lvUsuarios;
        private ColumnHeader nome;
        private ColumnHeader login;
        private TextBox txtId;
        private TextBox txtSenha;
        private Label label3;
        private ColumnHeader id;
        private ColumnHeader data;
    }
}