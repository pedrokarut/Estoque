namespace Estoque
{
    partial class Venda
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
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            checkedListBox1 = new CheckedListBox();
            label2 = new Label();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            txtMargemSel = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtQtd = new TextBox();
            txtNomeProd = new TextBox();
            txtIdProdSel = new TextBox();
            btnAddProd = new Button();
            btnAddSacola = new Button();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            listView1 = new ListView();
            id = new ColumnHeader();
            nome = new ColumnHeader();
            qtd = new ColumnHeader();
            margem = new ColumnHeader();
            label1 = new Label();
            btnBuscaCliente = new Button();
            btnCalcular = new Button();
            btnFinalizar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(517, 57);
            label4.Name = "label4";
            label4.Size = new Size(124, 15);
            label4.TabIndex = 13;
            label4.Text = "Forma de pagamento:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(647, 49);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(247, 23);
            textBox4.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(567, 85);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 15;
            label5.Text = "Observação:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.Location = new Point(0, 0);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 96);
            checkedListBox1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(594, 15);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 18;
            label2.Text = "Cliente:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(647, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 23);
            textBox1.TabIndex = 19;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMargemSel);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtQtd);
            groupBox1.Controls.Add(txtNomeProd);
            groupBox1.Controls.Add(txtIdProdSel);
            groupBox1.Controls.Add(btnAddProd);
            groupBox1.Location = new Point(19, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(278, 100);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Produto";
            // 
            // txtMargemSel
            // 
            txtMargemSel.Enabled = false;
            txtMargemSel.Location = new Point(218, 45);
            txtMargemSel.Name = "txtMargemSel";
            txtMargemSel.Size = new Size(52, 23);
            txtMargemSel.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(218, 26);
            label9.Name = "label9";
            label9.Size = new Size(52, 15);
            label9.TabIndex = 38;
            label9.Text = "Margem";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(182, 26);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 37;
            label8.Text = "Qtd:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 26);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 36;
            label7.Text = "Prod";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 26);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 35;
            label6.Text = "Id:";
            // 
            // txtQtd
            // 
            txtQtd.Location = new Point(184, 45);
            txtQtd.Name = "txtQtd";
            txtQtd.Size = new Size(28, 23);
            txtQtd.TabIndex = 34;
            // 
            // txtNomeProd
            // 
            txtNomeProd.Enabled = false;
            txtNomeProd.Location = new Point(51, 45);
            txtNomeProd.Name = "txtNomeProd";
            txtNomeProd.Size = new Size(127, 23);
            txtNomeProd.TabIndex = 33;
            // 
            // txtIdProdSel
            // 
            txtIdProdSel.Enabled = false;
            txtIdProdSel.Location = new Point(11, 45);
            txtIdProdSel.Name = "txtIdProdSel";
            txtIdProdSel.Size = new Size(27, 23);
            txtIdProdSel.TabIndex = 32;
            // 
            // btnAddProd
            // 
            btnAddProd.Location = new Point(188, 73);
            btnAddProd.Margin = new Padding(3, 2, 3, 2);
            btnAddProd.Name = "btnAddProd";
            btnAddProd.Size = new Size(82, 22);
            btnAddProd.TabIndex = 31;
            btnAddProd.Text = "Buscar";
            btnAddProd.UseVisualStyleBackColor = true;
            btnAddProd.Click += btnAddProd_Click;
            // 
            // btnAddSacola
            // 
            btnAddSacola.Location = new Point(303, 90);
            btnAddSacola.Margin = new Padding(3, 2, 3, 2);
            btnAddSacola.Name = "btnAddSacola";
            btnAddSacola.Size = new Size(105, 22);
            btnAddSacola.TabIndex = 41;
            btnAddSacola.Text = "Add na Sacola";
            btnAddSacola.UseVisualStyleBackColor = true;
            btnAddSacola.Click += button1_Click_2;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(647, 96);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(247, 96);
            richTextBox1.TabIndex = 42;
            richTextBox1.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(567, 287);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 43;
            label3.Text = "Total:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView1);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(19, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(389, 233);
            groupBox2.TabIndex = 44;
            groupBox2.TabStop = false;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { id, nome, qtd, margem });
            listView1.LabelEdit = true;
            listView1.Location = new Point(6, 49);
            listView1.Name = "listView1";
            listView1.Size = new Size(372, 163);
            listView1.TabIndex = 23;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // id
            // 
            id.Text = "id";
            id.Width = 25;
            // 
            // nome
            // 
            nome.Text = "Nome";
            // 
            // qtd
            // 
            qtd.Text = "QTD";
            qtd.Width = 30;
            // 
            // margem
            // 
            margem.Text = "Margem de Lucro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 22;
            label1.Text = "Sacola de Produtos:";
            // 
            // btnBuscaCliente
            // 
            btnBuscaCliente.Location = new Point(871, 13);
            btnBuscaCliente.Margin = new Padding(3, 2, 3, 2);
            btnBuscaCliente.Name = "btnBuscaCliente";
            btnBuscaCliente.Size = new Size(29, 22);
            btnBuscaCliente.TabIndex = 45;
            btnBuscaCliente.Text = "S";
            btnBuscaCliente.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(635, 263);
            btnCalcular.Margin = new Padding(3, 2, 3, 2);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(108, 53);
            btnCalcular.TabIndex = 46;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(747, 263);
            btnFinalizar.Margin = new Padding(3, 2, 3, 2);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(93, 54);
            btnFinalizar.TabIndex = 47;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // Venda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 354);
            Controls.Add(btnFinalizar);
            Controls.Add(btnCalcular);
            Controls.Add(btnBuscaCliente);
            Controls.Add(groupBox2);
            Controls.Add(label3);
            Controls.Add(richTextBox1);
            Controls.Add(btnAddSacola);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Venda";
            Text = "Venda";
            Activated += Venda_Activated;
            Enter += Venda_Enter;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private CheckedListBox checkedListBox1;
        private Label label2;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private TextBox txtMargemSel;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtQtd;
        private TextBox txtNomeProd;
        private TextBox txtIdProdSel;
        private Button btnAddProd;
        private Button btnAddSacola;
        private RichTextBox richTextBox1;
        private Label label3;
        private GroupBox groupBox2;
        private ListView listView1;
        private ColumnHeader id;
        private ColumnHeader nome;
        private ColumnHeader qtd;
        private ColumnHeader margem;
        private Label label1;
        private Button btnBuscaCliente;
        private Button btnCalcular;
        private Button btnFinalizar;
    }
}