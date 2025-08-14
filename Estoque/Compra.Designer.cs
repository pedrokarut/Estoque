namespace Estoque
{
    partial class Compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compra));
            groupBox1 = new GroupBox();
            txtIdForn = new TextBox();
            txtIdProd = new TextBox();
            btnForn = new Button();
            btnProd = new Button();
            btnCancelar = new Button();
            btnSalvar = new Button();
            txtForn = new TextBox();
            txtQtd = new TextBox();
            txtProd = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lvCompras = new ListView();
            id = new ColumnHeader();
            produto = new ColumnHeader();
            quantidade = new ColumnHeader();
            forn = new ColumnHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtIdForn);
            groupBox1.Controls.Add(txtIdProd);
            groupBox1.Controls.Add(btnForn);
            groupBox1.Controls.Add(btnProd);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(txtForn);
            groupBox1.Controls.Add(txtQtd);
            groupBox1.Controls.Add(txtProd);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(303, 212);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // txtIdForn
            // 
            txtIdForn.Enabled = false;
            txtIdForn.Location = new Point(6, 100);
            txtIdForn.Name = "txtIdForn";
            txtIdForn.Size = new Size(32, 27);
            txtIdForn.TabIndex = 17;
            txtIdForn.UseWaitCursor = true;
            txtIdForn.Visible = false;
            // 
            // txtIdProd
            // 
            txtIdProd.Enabled = false;
            txtIdProd.Location = new Point(6, 27);
            txtIdProd.Name = "txtIdProd";
            txtIdProd.Size = new Size(32, 27);
            txtIdProd.TabIndex = 16;
            txtIdProd.Visible = false;
            // 
            // btnForn
            // 
            btnForn.Image = (Image)resources.GetObject("btnForn.Image");
            btnForn.Location = new Point(251, 99);
            btnForn.Name = "btnForn";
            btnForn.Size = new Size(37, 29);
            btnForn.TabIndex = 15;
            btnForn.UseVisualStyleBackColor = true;
            btnForn.Click += btnForn_Click;
            // 
            // btnProd
            // 
            btnProd.Image = (Image)resources.GetObject("btnProd.Image");
            btnProd.Location = new Point(252, 26);
            btnProd.Name = "btnProd";
            btnProd.Size = new Size(37, 29);
            btnProd.TabIndex = 14;
            btnProd.UseVisualStyleBackColor = true;
            btnProd.Click += btnProd_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(175, 143);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(113, 51);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(41, 143);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(115, 51);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtForn
            // 
            txtForn.Location = new Point(137, 100);
            txtForn.Name = "txtForn";
            txtForn.Size = new Size(111, 27);
            txtForn.TabIndex = 11;
            // 
            // txtQtd
            // 
            txtQtd.Location = new Point(137, 64);
            txtQtd.Name = "txtQtd";
            txtQtd.Size = new Size(152, 27);
            txtQtd.TabIndex = 10;
            // 
            // txtProd
            // 
            txtProd.Location = new Point(137, 27);
            txtProd.Name = "txtProd";
            txtProd.Size = new Size(111, 27);
            txtProd.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 100);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 8;
            label3.Text = "Fornecedor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 64);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 7;
            label2.Text = "Quantidade:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 27);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 6;
            label1.Text = "Produto:";
            // 
            // lvCompras
            // 
            lvCompras.Columns.AddRange(new ColumnHeader[] { id, produto, quantidade, forn });
            lvCompras.Location = new Point(334, 41);
            lvCompras.Name = "lvCompras";
            lvCompras.Size = new Size(502, 197);
            lvCompras.TabIndex = 9;
            lvCompras.UseCompatibleStateImageBehavior = false;
            lvCompras.View = View.Details;
            lvCompras.Click += lvCompras_Click;
            lvCompras.DoubleClick += lvCompras_DoubleClick;
            // 
            // id
            // 
            id.Text = "id";
            id.Width = 30;
            // 
            // produto
            // 
            produto.Text = "Produto";
            produto.Width = 100;
            // 
            // quantidade
            // 
            quantidade.Text = "Qtd";
            // 
            // forn
            // 
            forn.Text = "Fornecedor";
            forn.Width = 100;
            // 
            // Compra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 255);
            Controls.Add(lvCompras);
            Controls.Add(groupBox1);
            Name = "Compra";
            Text = "Compra";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCancelar;
        private Button btnSalvar;
        private TextBox txtForn;
        private TextBox txtQtd;
        private TextBox txtProd;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnProd;
        private Button btnForn;
        private ListView lvCompras;
        private TextBox txtIdForn;
        private TextBox txtIdProd;
        private ColumnHeader id;
        private ColumnHeader produto;
        private ColumnHeader quantidade;
        private ColumnHeader forn;
    }
}