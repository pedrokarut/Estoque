namespace Estoque
{
    partial class Fornecedor
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
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnNovo = new Button();
            txtTelefone = new TextBox();
            label5 = new Label();
            txtInsc = new TextBox();
            txtCNPJ = new TextBox();
            txtEndereco = new TextBox();
            txtNome = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lvForn = new ListView();
            id = new ColumnHeader();
            nome = new ColumnHeader();
            endereco = new ColumnHeader();
            cnpj = new ColumnHeader();
            inscEst = new ColumnHeader();
            telefone = new ColumnHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(btnNovo);
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtInsc);
            groupBox1.Controls.Add(txtCNPJ);
            groupBox1.Controls.Add(txtEndereco);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 13);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(343, 376);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.InactiveCaption;
            txtId.Enabled = false;
            txtId.Location = new Point(6, 27);
            txtId.Name = "txtId";
            txtId.Size = new Size(31, 27);
            txtId.TabIndex = 13;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(233, 255);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(95, 77);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(118, 255);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(103, 77);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(6, 255);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(99, 77);
            btnNovo.TabIndex = 10;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(136, 198);
            txtTelefone.Margin = new Padding(3, 4, 3, 4);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(192, 27);
            txtTelefone.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 201);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 8;
            label5.Text = "Telefone:";
            // 
            // txtInsc
            // 
            txtInsc.Location = new Point(136, 163);
            txtInsc.Margin = new Padding(3, 4, 3, 4);
            txtInsc.Name = "txtInsc";
            txtInsc.Size = new Size(192, 27);
            txtInsc.TabIndex = 7;
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(136, 128);
            txtCNPJ.Margin = new Padding(3, 4, 3, 4);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(192, 27);
            txtCNPJ.TabIndex = 6;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(136, 93);
            txtEndereco.Margin = new Padding(3, 4, 3, 4);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(192, 27);
            txtEndereco.TabIndex = 5;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(136, 58);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(192, 27);
            txtNome.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 167);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 3;
            label4.Text = "Inscrição Estadual:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 135);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 2;
            label3.Text = "CNPJ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 100);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Endereço:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 65);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // lvForn
            // 
            lvForn.Columns.AddRange(new ColumnHeader[] { id, nome, endereco, cnpj, inscEst, telefone });
            lvForn.Location = new Point(361, 27);
            lvForn.Margin = new Padding(3, 4, 3, 4);
            lvForn.Name = "lvForn";
            lvForn.Size = new Size(375, 362);
            lvForn.TabIndex = 1;
            lvForn.UseCompatibleStateImageBehavior = false;
            lvForn.View = View.Details;
            lvForn.Click += lvForn_Click;
            lvForn.DoubleClick += lvForn_DoubleClick;
            // 
            // id
            // 
            id.Text = "Id";
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
            // 
            // inscEst
            // 
            inscEst.Text = "Inscrição Estadual";
            // 
            // telefone
            // 
            telefone.Text = "Telefone";
            telefone.Width = 100;
            // 
            // Fornecedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 410);
            Controls.Add(lvForn);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Fornecedor";
            Text = "Fornecedor";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtInsc;
        private TextBox txtCNPJ;
        private TextBox txtEndereco;
        private TextBox txtNome;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListView lvForn;
        private TextBox txtTelefone;
        private Label label5;
        private TextBox txtId;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnNovo;
        private ColumnHeader id;
        private ColumnHeader nome;
        private ColumnHeader endereco;
        private ColumnHeader cnpj;
        private ColumnHeader inscEst;
        private ColumnHeader telefone;
    }
}