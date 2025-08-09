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
            txtNomeCli = new TextBox();
            txtIdCli = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(591, 76);
            label4.Name = "label4";
            label4.Size = new Size(156, 20);
            label4.TabIndex = 13;
            label4.Text = "Forma de pagamento:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(739, 65);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(282, 27);
            textBox4.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(648, 113);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
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
            label2.Location = new Point(679, 20);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 18;
            label2.Text = "Cliente:";
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
            groupBox1.Location = new Point(22, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(318, 133);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Produto";
            // 
            // txtMargemSel
            // 
            txtMargemSel.Enabled = false;
            txtMargemSel.Location = new Point(249, 60);
            txtMargemSel.Margin = new Padding(3, 4, 3, 4);
            txtMargemSel.Name = "txtMargemSel";
            txtMargemSel.Size = new Size(59, 27);
            txtMargemSel.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(249, 35);
            label9.Name = "label9";
            label9.Size = new Size(65, 20);
            label9.TabIndex = 38;
            label9.Text = "Margem";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(208, 35);
            label8.Name = "label8";
            label8.Size = new Size(37, 20);
            label8.TabIndex = 37;
            label8.Text = "Qtd:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(58, 35);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 36;
            label7.Text = "Prod";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 35);
            label6.Name = "label6";
            label6.Size = new Size(25, 20);
            label6.TabIndex = 35;
            label6.Text = "Id:";
            // 
            // txtQtd
            // 
            txtQtd.Location = new Point(210, 60);
            txtQtd.Margin = new Padding(3, 4, 3, 4);
            txtQtd.Name = "txtQtd";
            txtQtd.Size = new Size(31, 27);
            txtQtd.TabIndex = 34;
            // 
            // txtNomeProd
            // 
            txtNomeProd.Enabled = false;
            txtNomeProd.Location = new Point(58, 60);
            txtNomeProd.Margin = new Padding(3, 4, 3, 4);
            txtNomeProd.Name = "txtNomeProd";
            txtNomeProd.Size = new Size(145, 27);
            txtNomeProd.TabIndex = 33;
            // 
            // txtIdProdSel
            // 
            txtIdProdSel.Enabled = false;
            txtIdProdSel.Location = new Point(13, 60);
            txtIdProdSel.Margin = new Padding(3, 4, 3, 4);
            txtIdProdSel.Name = "txtIdProdSel";
            txtIdProdSel.Size = new Size(30, 27);
            txtIdProdSel.TabIndex = 32;
            // 
            // btnAddProd
            // 
            btnAddProd.Location = new Point(215, 97);
            btnAddProd.Name = "btnAddProd";
            btnAddProd.Size = new Size(94, 29);
            btnAddProd.TabIndex = 31;
            btnAddProd.Text = "Buscar";
            btnAddProd.UseVisualStyleBackColor = true;
            btnAddProd.Click += btnAddProd_Click;
            // 
            // btnAddSacola
            // 
            btnAddSacola.Location = new Point(346, 120);
            btnAddSacola.Name = "btnAddSacola";
            btnAddSacola.Size = new Size(120, 29);
            btnAddSacola.TabIndex = 41;
            btnAddSacola.Text = "Add na Sacola";
            btnAddSacola.UseVisualStyleBackColor = true;
            btnAddSacola.Click += button1_Click_2;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(739, 128);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(282, 127);
            richTextBox1.TabIndex = 42;
            richTextBox1.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(648, 383);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 43;
            label3.Text = "Total:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView1);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(22, 157);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(445, 311);
            groupBox2.TabIndex = 44;
            groupBox2.TabStop = false;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { id, nome, qtd, margem });
            listView1.LabelEdit = true;
            listView1.Location = new Point(7, 65);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(425, 216);
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
            label1.Location = new Point(7, 25);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 22;
            label1.Text = "Sacola de Produtos:";
            // 
            // btnBuscaCliente
            // 
            btnBuscaCliente.Location = new Point(995, 17);
            btnBuscaCliente.Name = "btnBuscaCliente";
            btnBuscaCliente.Size = new Size(33, 29);
            btnBuscaCliente.TabIndex = 45;
            btnBuscaCliente.Text = "S";
            btnBuscaCliente.UseVisualStyleBackColor = true;
            btnBuscaCliente.Click += btnBuscaCliente_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(726, 351);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(123, 71);
            btnCalcular.TabIndex = 46;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(854, 351);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(106, 72);
            btnFinalizar.TabIndex = 47;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // txtNomeCli
            // 
            txtNomeCli.Enabled = false;
            txtNomeCli.Location = new Point(739, 20);
            txtNomeCli.Margin = new Padding(3, 4, 3, 4);
            txtNomeCli.Name = "txtNomeCli";
            txtNomeCli.Size = new Size(250, 27);
            txtNomeCli.TabIndex = 49;
            // 
            // txtIdCli
            // 
            txtIdCli.Enabled = false;
            txtIdCli.Location = new Point(648, 20);
            txtIdCli.Margin = new Padding(3, 4, 3, 4);
            txtIdCli.Name = "txtIdCli";
            txtIdCli.Size = new Size(35, 27);
            txtIdCli.TabIndex = 50;
            txtIdCli.Visible = false;
            // 
            // Venda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 472);
            Controls.Add(txtIdCli);
            Controls.Add(txtNomeCli);
            Controls.Add(btnFinalizar);
            Controls.Add(btnCalcular);
            Controls.Add(btnBuscaCliente);
            Controls.Add(groupBox2);
            Controls.Add(label3);
            Controls.Add(richTextBox1);
            Controls.Add(btnAddSacola);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
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
        private TextBox txtNomeCli;
        private TextBox txtIdCli;
    }
}