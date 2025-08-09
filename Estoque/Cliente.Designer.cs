namespace Estoque
{
    partial class Cliente
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
            groupBox1 = new GroupBox();
            txtId = new TextBox();
            btnSalvar = new Button();
            btnExcluir = new Button();
            btnNovo = new Button();
            txtTelefone = new TextBox();
            label5 = new Label();
            txtInsc = new TextBox();
            txtCnpj = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtEnd = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lvClientes = new ListView();
            id = new ColumnHeader();
            nome = new ColumnHeader();
            endereco = new ColumnHeader();
            cnpj = new ColumnHeader();
            incricaoEstadual = new ColumnHeader();
            telefone = new ColumnHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(btnNovo);
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtInsc);
            groupBox1.Controls.Add(txtCnpj);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtEnd);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(24, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(320, 389);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.InactiveCaption;
            txtId.Enabled = false;
            txtId.Location = new Point(6, 26);
            txtId.Name = "txtId";
            txtId.Size = new Size(30, 27);
            txtId.TabIndex = 23;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(108, 295);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 40);
            btnSalvar.TabIndex = 22;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(208, 295);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 40);
            btnExcluir.TabIndex = 21;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(8, 295);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(94, 40);
            btnNovo.TabIndex = 20;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(144, 240);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(153, 27);
            txtTelefone.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 243);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 18;
            label5.Text = "Telefone:";
            // 
            // txtInsc
            // 
            txtInsc.Location = new Point(144, 188);
            txtInsc.Name = "txtInsc";
            txtInsc.Size = new Size(153, 27);
            txtInsc.TabIndex = 17;
            // 
            // txtCnpj
            // 
            txtCnpj.Location = new Point(145, 142);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(153, 27);
            txtCnpj.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 191);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 15;
            label4.Text = "Inscrição estadual:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 147);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 14;
            label3.Text = "CNPJ:";
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(144, 95);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(153, 27);
            txtEnd.TabIndex = 13;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(144, 46);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(153, 27);
            txtNome.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 100);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 11;
            label2.Text = "Endereço:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 50);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 10;
            label1.Text = "Nome:";
            // 
            // lvClientes
            // 
            lvClientes.Columns.AddRange(new ColumnHeader[] { id, nome, endereco, cnpj, incricaoEstadual, telefone });
            lvClientes.Location = new Point(367, 40);
            lvClientes.Name = "lvClientes";
            lvClientes.Size = new Size(521, 375);
            lvClientes.TabIndex = 11;
            lvClientes.UseCompatibleStateImageBehavior = false;
            lvClientes.View = View.Details;
            lvClientes.Click += lvClientes_Click;
            lvClientes.DoubleClick += lvClientes_DoubleClick;
            // 
            // id
            // 
            id.Text = "id";
            id.Width = 25;
            // 
            // nome
            // 
            nome.Text = "Nome";
            nome.Width = 100;
            // 
            // endereco
            // 
            endereco.Text = "Endereço";
            endereco.Width = 100;
            // 
            // cnpj
            // 
            cnpj.Text = "CNPJ";
            cnpj.Width = 80;
            // 
            // incricaoEstadual
            // 
            incricaoEstadual.Text = "Inscrição Estadual";
            incricaoEstadual.Width = 80;
            // 
            // telefone
            // 
            telefone.Text = "Telefone";
            telefone.Width = 80;
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 479);
            Controls.Add(lvClientes);
            Controls.Add(groupBox1);
            Name = "Cliente";
            Text = "Cliente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtTelefone;
        private Label label5;
        private TextBox txtInsc;
        private TextBox txtCnpj;
        private Label label4;
        private Label label3;
        private TextBox txtEnd;
        private TextBox txtNome;
        private Label label2;
        private Label label1;
        private Button btnSalvar;
        private Button btnExcluir;
        private Button btnNovo;
        private ListView lvClientes;
        private ColumnHeader id;
        private ColumnHeader nome;
        private ColumnHeader endereco;
        private ColumnHeader cnpj;
        private ColumnHeader incricaoEstadual;
        private ColumnHeader telefone;
        private TextBox txtId;
    }
}