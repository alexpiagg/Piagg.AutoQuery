namespace Piagg.AutoQuery.View
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuItemPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSubControle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSubSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFerramentas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSubImportador = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSubSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.statusInferior = new System.Windows.Forms.StatusStrip();
            this.statusLbBanco = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLbNomeBanco = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuPrincipal.SuspendLayout();
            this.statusInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemPrincipal,
            this.menuItemFerramentas,
            this.ajudaToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(784, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // menuItemPrincipal
            // 
            this.menuItemPrincipal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSubControle,
            this.menuSubSair});
            this.menuItemPrincipal.Name = "menuItemPrincipal";
            this.menuItemPrincipal.Size = new System.Drawing.Size(65, 20);
            this.menuItemPrincipal.Text = "Principal";
            // 
            // menuSubControle
            // 
            this.menuSubControle.Name = "menuSubControle";
            this.menuSubControle.Size = new System.Drawing.Size(120, 22);
            this.menuSubControle.Text = "Controle";
            this.menuSubControle.Click += new System.EventHandler(this.menuSubControle_Click);
            // 
            // menuSubSair
            // 
            this.menuSubSair.Name = "menuSubSair";
            this.menuSubSair.Size = new System.Drawing.Size(120, 22);
            this.menuSubSair.Text = "Sair";
            this.menuSubSair.Click += new System.EventHandler(this.menuSubSair_Click);
            // 
            // menuItemFerramentas
            // 
            this.menuItemFerramentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSubImportador});
            this.menuItemFerramentas.Name = "menuItemFerramentas";
            this.menuItemFerramentas.Size = new System.Drawing.Size(84, 20);
            this.menuItemFerramentas.Text = "Ferramentas";
            // 
            // menuSubImportador
            // 
            this.menuSubImportador.Name = "menuSubImportador";
            this.menuSubImportador.Size = new System.Drawing.Size(134, 22);
            this.menuSubImportador.Text = "Importador";
            this.menuSubImportador.Click += new System.EventHandler(this.menuSubImportador_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSubSobre});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // menuSubSobre
            // 
            this.menuSubSobre.Name = "menuSubSobre";
            this.menuSubSobre.Size = new System.Drawing.Size(104, 22);
            this.menuSubSobre.Text = "Sobre";
            this.menuSubSobre.Click += new System.EventHandler(this.menuSubSobre_Click);
            // 
            // statusInferior
            // 
            this.statusInferior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLbBanco,
            this.statusLbNomeBanco});
            this.statusInferior.Location = new System.Drawing.Point(0, 539);
            this.statusInferior.Name = "statusInferior";
            this.statusInferior.Size = new System.Drawing.Size(784, 22);
            this.statusInferior.TabIndex = 1;
            this.statusInferior.Text = "statusStrip";
            // 
            // statusLbBanco
            // 
            this.statusLbBanco.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbBanco.Name = "statusLbBanco";
            this.statusLbBanco.Size = new System.Drawing.Size(44, 17);
            this.statusLbBanco.Text = "Banco:";
            // 
            // statusLbNomeBanco
            // 
            this.statusLbNomeBanco.Name = "statusLbNomeBanco";
            this.statusLbNomeBanco.Size = new System.Drawing.Size(71, 17);
            this.statusLbNomeBanco.Text = "Banco Atual";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.statusInferior);
            this.Controls.Add(this.menuPrincipal);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "AutoQuery - Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.statusInferior.ResumeLayout(false);
            this.statusInferior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuItemPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuSubSair;
        private System.Windows.Forms.ToolStripMenuItem menuItemFerramentas;
        private System.Windows.Forms.ToolStripMenuItem menuSubImportador;
        private System.Windows.Forms.StatusStrip statusInferior;
        private System.Windows.Forms.ToolStripStatusLabel statusLbBanco;
        private System.Windows.Forms.ToolStripStatusLabel statusLbNomeBanco;
        private System.Windows.Forms.ToolStripMenuItem menuSubControle;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSubSobre;
    }
}