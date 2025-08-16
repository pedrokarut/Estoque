namespace Estoque
{
    partial class Principal
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
            menuStrip1 = new MenuStrip();
            compraToolStripMenuItem = new ToolStripMenuItem();
            compraToolStripMenuItem1 = new ToolStripMenuItem();
            vendaToolStripMenuItem = new ToolStripMenuItem();
            vendaToolStripMenuItem1 = new ToolStripMenuItem();
            produtoToolStripMenuItem = new ToolStripMenuItem();
            produtoToolStripMenuItem1 = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem1 = new ToolStripMenuItem();
            fornecedorToolStripMenuItem = new ToolStripMenuItem();
            fornecedorToolStripMenuItem1 = new ToolStripMenuItem();
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            usuarioToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { compraToolStripMenuItem, vendaToolStripMenuItem, produtoToolStripMenuItem, clienteToolStripMenuItem, fornecedorToolStripMenuItem, usuarioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // compraToolStripMenuItem
            // 
            compraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { compraToolStripMenuItem1 });
            compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            compraToolStripMenuItem.Size = new Size(76, 24);
            compraToolStripMenuItem.Text = "Compra";
            // 
            // compraToolStripMenuItem1
            // 
            compraToolStripMenuItem1.Name = "compraToolStripMenuItem1";
            compraToolStripMenuItem1.Size = new Size(145, 26);
            compraToolStripMenuItem1.Text = "Compra";
            compraToolStripMenuItem1.Click += compraToolStripMenuItem1_Click;
            // 
            // vendaToolStripMenuItem
            // 
            vendaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vendaToolStripMenuItem1 });
            vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            vendaToolStripMenuItem.Size = new Size(64, 24);
            vendaToolStripMenuItem.Text = "Venda";
            // 
            // vendaToolStripMenuItem1
            // 
            vendaToolStripMenuItem1.Name = "vendaToolStripMenuItem1";
            vendaToolStripMenuItem1.Size = new Size(133, 26);
            vendaToolStripMenuItem1.Text = "Venda";
            vendaToolStripMenuItem1.Click += vendaToolStripMenuItem1_Click;
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { produtoToolStripMenuItem1 });
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.Size = new Size(76, 24);
            produtoToolStripMenuItem.Text = "Produto";
            // 
            // produtoToolStripMenuItem1
            // 
            produtoToolStripMenuItem1.Name = "produtoToolStripMenuItem1";
            produtoToolStripMenuItem1.Size = new Size(145, 26);
            produtoToolStripMenuItem1.Text = "Produto";
            produtoToolStripMenuItem1.Click += produtoToolStripMenuItem1_Click;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clienteToolStripMenuItem1 });
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(69, 24);
            clienteToolStripMenuItem.Text = "Cliente";
            // 
            // clienteToolStripMenuItem1
            // 
            clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            clienteToolStripMenuItem1.Size = new Size(138, 26);
            clienteToolStripMenuItem1.Text = "Cliente";
            clienteToolStripMenuItem1.Click += clienteToolStripMenuItem1_Click;
            // 
            // fornecedorToolStripMenuItem
            // 
            fornecedorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fornecedorToolStripMenuItem1 });
            fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            fornecedorToolStripMenuItem.Size = new Size(98, 24);
            fornecedorToolStripMenuItem.Text = "Fornecedor";
            // 
            // fornecedorToolStripMenuItem1
            // 
            fornecedorToolStripMenuItem1.Name = "fornecedorToolStripMenuItem1";
            fornecedorToolStripMenuItem1.Size = new Size(167, 26);
            fornecedorToolStripMenuItem1.Text = "Fornecedor";
            fornecedorToolStripMenuItem1.Click += fornecedorToolStripMenuItem1_Click;
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuarioToolStripMenuItem1 });
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(73, 24);
            usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // usuarioToolStripMenuItem1
            // 
            usuarioToolStripMenuItem1.Name = "usuarioToolStripMenuItem1";
            usuarioToolStripMenuItem1.Size = new Size(142, 26);
            usuarioToolStripMenuItem1.Text = "Usuario";
            usuarioToolStripMenuItem1.Click += usuarioToolStripMenuItem1_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Principal";
            Text = "Principal";
            FormClosed += Principal_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem compraToolStripMenuItem;
        private ToolStripMenuItem compraToolStripMenuItem1;
        private ToolStripMenuItem vendaToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem fornecedorToolStripMenuItem;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem vendaToolStripMenuItem1;
        private ToolStripMenuItem produtoToolStripMenuItem1;
        private ToolStripMenuItem clienteToolStripMenuItem1;
        private ToolStripMenuItem fornecedorToolStripMenuItem1;
        private ToolStripMenuItem usuarioToolStripMenuItem1;
    }
}