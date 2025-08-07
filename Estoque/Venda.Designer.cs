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
            textBox3 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            btnAddProd = new Button();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            checkedListBox1 = new CheckedListBox();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            listView1 = new ListView();
            id = new ColumnHeader();
            nome = new ColumnHeader();
            qtd = new ColumnHeader();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(172, 109);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(110, 23);
            textBox3.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 136);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 8;
            label3.Text = "Margem de lucro:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(511, 20);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 6;
            label1.Text = "Produto:";
            // 
            // btnAddProd
            // 
            btnAddProd.Location = new Point(659, 81);
            btnAddProd.Margin = new Padding(3, 2, 3, 2);
            btnAddProd.Name = "btnAddProd";
            btnAddProd.Size = new Size(82, 22);
            btnAddProd.TabIndex = 12;
            btnAddProd.Text = "Add";
            btnAddProd.UseVisualStyleBackColor = true;
            btnAddProd.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 162);
            label4.Name = "label4";
            label4.Size = new Size(124, 15);
            label4.TabIndex = 13;
            label4.Text = "Forma de pagamento:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(172, 160);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(110, 23);
            textBox4.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 190);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 15;
            label5.Text = "Observação:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(172, 186);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(110, 23);
            textBox5.TabIndex = 16;
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
            label2.Location = new Point(18, 20);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 18;
            label2.Text = "Cliente:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(84, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 23);
            textBox1.TabIndex = 19;
            // 
            // button1
            // 
            button1.Location = new Point(651, 31);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 20;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { id, nome, qtd });
            listView1.LabelEdit = true;
            listView1.Location = new Point(364, 106);
            listView1.Name = "listView1";
            listView1.Size = new Size(289, 163);
            listView1.TabIndex = 21;
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
            // Venda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 326);
            Controls.Add(listView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(btnAddProd);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Venda";
            Text = "Venda";
            Activated += Venda_Activated;
            Enter += Venda_Enter;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private Label label3;
        private Label label1;
        private Button btnAddProd;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private CheckedListBox checkedListBox1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private ListView listView1;
        private ColumnHeader id;
        private ColumnHeader nome;
        private ColumnHeader qtd;
    }
}