namespace Piagg.AutoQuery.View
{
    partial class frmSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSobre));
            this.lblVersao = new System.Windows.Forms.Label();
            this.lblNroVersao = new System.Windows.Forms.Label();
            this.gpbEmpresa = new System.Windows.Forms.GroupBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblSite = new System.Windows.Forms.LinkLabel();
            this.lblSobreEmp = new System.Windows.Forms.Label();
            this.gpbEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.Location = new System.Drawing.Point(114, 239);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(50, 13);
            this.lblVersao.TabIndex = 1;
            this.lblVersao.Text = "Versão:";
            // 
            // lblNroVersao
            // 
            this.lblNroVersao.AutoSize = true;
            this.lblNroVersao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroVersao.Location = new System.Drawing.Point(170, 239);
            this.lblNroVersao.Name = "lblNroVersao";
            this.lblNroVersao.Size = new System.Drawing.Size(40, 13);
            this.lblNroVersao.TabIndex = 3;
            this.lblNroVersao.Text = "1.1.1.1";
            // 
            // gpbEmpresa
            // 
            this.gpbEmpresa.Controls.Add(this.lblAutor);
            this.gpbEmpresa.Controls.Add(this.lblCopyright);
            this.gpbEmpresa.Controls.Add(this.lblHome);
            this.gpbEmpresa.Controls.Add(this.lblSite);
            this.gpbEmpresa.Controls.Add(this.lblSobreEmp);
            this.gpbEmpresa.Location = new System.Drawing.Point(9, 12);
            this.gpbEmpresa.Name = "gpbEmpresa";
            this.gpbEmpresa.Size = new System.Drawing.Size(322, 134);
            this.gpbEmpresa.TabIndex = 6;
            this.gpbEmpresa.TabStop = false;
            this.gpbEmpresa.Text = "Desenvolvido por:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(105, 68);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(109, 13);
            this.lblAutor.TabIndex = 10;
            this.lblAutor.Text = "Autor: Alex Delapiagg";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(62, 88);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(196, 13);
            this.lblCopyright.TabIndex = 9;
            this.lblCopyright.Text = "( c ) Todos os direitos reservados - 2015";
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(18, 109);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(66, 13);
            this.lblHome.TabIndex = 8;
            this.lblHome.Text = "Home Page:";
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSite.Location = new System.Drawing.Point(83, 104);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(227, 20);
            this.lblSite.TabIndex = 7;
            this.lblSite.TabStop = true;
            this.lblSite.Text = "http://www.alexpiagg.com";
            this.lblSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSite_LinkClicked);
            // 
            // lblSobreEmp
            // 
            this.lblSobreEmp.AutoSize = true;
            this.lblSobreEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobreEmp.Location = new System.Drawing.Point(69, 21);
            this.lblSobreEmp.Name = "lblSobreEmp";
            this.lblSobreEmp.Size = new System.Drawing.Size(171, 25);
            this.lblSobreEmp.TabIndex = 6;
            this.lblSobreEmp.Text = "Piagg Software";
            // 
            // frmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 273);
            this.Controls.Add(this.gpbEmpresa);
            this.Controls.Add(this.lblNroVersao);
            this.Controls.Add(this.lblVersao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre";
            this.Load += new System.EventHandler(this.frmSobre_Load);
            this.gpbEmpresa.ResumeLayout(false);
            this.gpbEmpresa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label lblNroVersao;
        private System.Windows.Forms.GroupBox gpbEmpresa;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.LinkLabel lblSite;
        private System.Windows.Forms.Label lblSobreEmp;
        private System.Windows.Forms.Label lblAutor;

    }
}