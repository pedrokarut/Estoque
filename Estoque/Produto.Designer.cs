namespace Estoque
{
    partial class Produto
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
            lvProdutos = new ListView();
            id = new ColumnHeader();
            nome = new ColumnHeader();
            valor = new ColumnHeader();
            litros = new ColumnHeader();
            codbarras = new ColumnHeader();
            custo = new ColumnHeader();
            btAdd = new Button();
            groupBox1 = new GroupBox();
            txtId = new TextBox();
            label3 = new Label();
            label1 = new Label();
            txtCodBarras = new TextBox();
            txtLitros = new TextBox();
            txtValor = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            lblNome = new Label();
            btDel = new Button();
            btNovo = new Button();
            margem = new ColumnHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lvProdutos
            // 
            lvProdutos.Columns.AddRange(new ColumnHeader[] { id, nome, valor, litros, codbarras, custo, margem });
            lvProdutos.Location = new Point(374, 77);
            lvProdutos.Margin = new Padding(3, 4, 3, 4);
            lvProdutos.Name = "lvProdutos";
            lvProdutos.Size = new Size(603, 275);
            lvProdutos.TabIndex = 8;
            lvProdutos.UseCompatibleStateImageBehavior = false;
            lvProdutos.View = View.Details;
            lvProdutos.Click += lvProdutos_Click;
            lvProdutos.DoubleClick += lvProdutos_DoubleClick;
            // 
            // id
            // 
            id.Text = "Id";
            id.Width = 25;
            // 
            // nome
            // 
            nome.Text = "Nome";
            nome.Width = 120;
            // 
            // valor
            // 
            valor.Text = "Valor";
            valor.Width = 50;
            // 
            // litros
            // 
            litros.Text = "Litros";
            litros.Width = 50;
            // 
            // codbarras
            // 
            codbarras.Text = "Código de barras";
            codbarras.Width = 250;
            // 
            // custo
            // 
            custo.Text = "Custo";
            custo.Width = 80;
            // 
            // btAdd
            // 
            btAdd.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btAdd.Location = new Point(142, 295);
            btAdd.Margin = new Padding(3, 4, 3, 4);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(98, 59);
            btAdd.TabIndex = 9;
            btAdd.Text = "Salvar";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCodBarras);
            groupBox1.Controls.Add(txtLitros);
            groupBox1.Controls.Add(txtValor);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblNome);
            groupBox1.Location = new Point(27, 55);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(319, 232);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.InactiveCaption;
            txtId.Enabled = false;
            txtId.Location = new Point(7, 16);
            txtId.Name = "txtId";
            txtId.Size = new Size(27, 27);
            txtId.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 187);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 15;
            label3.Text = "Cod. Barras:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 133);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 14;
            label1.Text = "Litros:";
            // 
            // txtCodBarras
            // 
            txtCodBarras.Location = new Point(114, 176);
            txtCodBarras.Name = "txtCodBarras";
            txtCodBarras.Size = new Size(189, 27);
            txtCodBarras.TabIndex = 13;
            // 
            // txtLitros
            // 
            txtLitros.Location = new Point(114, 123);
            txtLitros.Name = "txtLitros";
            txtLitros.Size = new Size(189, 27);
            txtLitros.TabIndex = 12;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(114, 72);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(189, 27);
            txtValor.TabIndex = 11;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(114, 27);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(189, 27);
            txtNome.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 75);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 9;
            label2.Text = "Valor:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(45, 27);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 20);
            lblNome.TabIndex = 8;
            lblNome.Text = "Nome:";
            lblNome.TextAlign = ContentAlignment.TopCenter;
            // 
            // btDel
            // 
            btDel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btDel.Location = new Point(247, 295);
            btDel.Margin = new Padding(3, 4, 3, 4);
            btDel.Name = "btDel";
            btDel.Size = new Size(99, 59);
            btDel.TabIndex = 11;
            btDel.Text = "Excluir";
            btDel.UseVisualStyleBackColor = true;
            btDel.Click += btDel_Click;
            // 
            // btNovo
            // 
            btNovo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btNovo.Location = new Point(27, 295);
            btNovo.Margin = new Padding(3, 4, 3, 4);
            btNovo.Name = "btNovo";
            btNovo.Size = new Size(98, 59);
            btNovo.TabIndex = 12;
            btNovo.Text = "Novo";
            btNovo.UseVisualStyleBackColor = true;
            btNovo.Click += btNovo_Click;
            // 
            // margem
            // 
            margem.Text = "Margem Lucro";
            margem.Width = 100;
            // 
            // Produto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 395);
            Controls.Add(btNovo);
            Controls.Add(btDel);
            Controls.Add(groupBox1);
            Controls.Add(btAdd);
            Controls.Add(lvProdutos);
            Name = "Produto";
            Text = "Produto";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListView lvProdutos;
        private Button btAdd;
        private ColumnHeader nome;
        private ColumnHeader valor;
        private ColumnHeader litros;
        private ColumnHeader codbarras;
        private GroupBox groupBox1;
        private Label label3;
        private Label label1;
        private TextBox txtCodBarras;
        private TextBox txtLitros;
        private TextBox txtValor;
        private TextBox txtNome;
        private Label label2;
        private Label lblNome;
        private ColumnHeader id;
        private Button btDel;
        private TextBox txtId;
        private Button btNovo;
        private ColumnHeader custo;
        private ColumnHeader margem;
    }
}