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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lvProdutos
            // 
            lvProdutos.Columns.AddRange(new ColumnHeader[] { id, nome, valor, litros, codbarras });
            lvProdutos.Location = new Point(327, 58);
            lvProdutos.Name = "lvProdutos";
            lvProdutos.Size = new Size(528, 207);
            lvProdutos.TabIndex = 8;
            lvProdutos.UseCompatibleStateImageBehavior = false;
            lvProdutos.View = View.Details;
            lvProdutos.Click += lvProdutos_Click;
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
            // btAdd
            // 
            btAdd.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btAdd.Location = new Point(124, 221);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(86, 44);
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
            groupBox1.Location = new Point(24, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(279, 174);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.InactiveCaption;
            txtId.Enabled = false;
            txtId.Location = new Point(6, 12);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(24, 23);
            txtId.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 140);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 15;
            label3.Text = "Cod. Barras:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 100);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 14;
            label1.Text = "Litros:";
            // 
            // txtCodBarras
            // 
            txtCodBarras.Location = new Point(100, 132);
            txtCodBarras.Margin = new Padding(3, 2, 3, 2);
            txtCodBarras.Name = "txtCodBarras";
            txtCodBarras.Size = new Size(166, 23);
            txtCodBarras.TabIndex = 13;
            // 
            // txtLitros
            // 
            txtLitros.Location = new Point(100, 92);
            txtLitros.Margin = new Padding(3, 2, 3, 2);
            txtLitros.Name = "txtLitros";
            txtLitros.Size = new Size(166, 23);
            txtLitros.TabIndex = 12;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(100, 54);
            txtValor.Margin = new Padding(3, 2, 3, 2);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(166, 23);
            txtValor.TabIndex = 11;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(100, 20);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(166, 23);
            txtNome.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 56);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 9;
            label2.Text = "Valor:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(39, 20);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 8;
            lblNome.Text = "Nome:";
            lblNome.TextAlign = ContentAlignment.TopCenter;
            // 
            // btDel
            // 
            btDel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btDel.Location = new Point(216, 221);
            btDel.Name = "btDel";
            btDel.Size = new Size(87, 44);
            btDel.TabIndex = 11;
            btDel.Text = "Excluir";
            btDel.UseVisualStyleBackColor = true;
            btDel.Click += btDel_Click;
            // 
            // btNovo
            // 
            btNovo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btNovo.Location = new Point(24, 221);
            btNovo.Name = "btNovo";
            btNovo.Size = new Size(86, 44);
            btNovo.TabIndex = 12;
            btNovo.Text = "Novo";
            btNovo.UseVisualStyleBackColor = true;
            btNovo.Click += btNovo_Click;
            // 
            // Produto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 296);
            Controls.Add(btNovo);
            Controls.Add(btDel);
            Controls.Add(groupBox1);
            Controls.Add(btAdd);
            Controls.Add(lvProdutos);
            Margin = new Padding(3, 2, 3, 2);
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
    }
}