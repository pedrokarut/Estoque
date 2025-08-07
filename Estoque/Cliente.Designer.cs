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
            textBox5 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnNovo = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
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
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(btnNovo);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(24, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(320, 389);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(144, 240);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(153, 27);
            textBox5.TabIndex = 19;
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
            // textBox4
            // 
            textBox4.Location = new Point(144, 188);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(153, 27);
            textBox4.TabIndex = 17;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(145, 142);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(153, 27);
            textBox3.TabIndex = 16;
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
            // textBox2
            // 
            textBox2.Location = new Point(144, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(153, 27);
            textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(144, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(153, 27);
            textBox1.TabIndex = 12;
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
            // btnNovo
            // 
            btnNovo.Location = new Point(8, 295);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(94, 40);
            btnNovo.TabIndex = 20;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(208, 295);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 40);
            btnExcluir.TabIndex = 21;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(108, 295);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 40);
            btnSalvar.TabIndex = 22;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
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
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
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
    }
}