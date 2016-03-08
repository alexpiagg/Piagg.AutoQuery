namespace Piagg.AutoQuery.View
{
    partial class frmBackup
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackup));
            this.gpbConfigBackup = new System.Windows.Forms.GroupBox();
            this.brnCancelar = new System.Windows.Forms.Button();
            this.btnIniciarBkp = new System.Windows.Forms.Button();
            this.btnPathDir = new System.Windows.Forms.Button();
            this.txtPathDir = new System.Windows.Forms.TextBox();
            this.gpbTipoBkp = new System.Windows.Forms.GroupBox();
            this.rdbRestore = new System.Windows.Forms.RadioButton();
            this.rdbBackup = new System.Windows.Forms.RadioButton();
            this.fbdDiretorio = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ofdDiretorio = new System.Windows.Forms.OpenFileDialog();
            this.gpbConfigBackup.SuspendLayout();
            this.gpbTipoBkp.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbConfigBackup
            // 
            this.gpbConfigBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbConfigBackup.Controls.Add(this.brnCancelar);
            this.gpbConfigBackup.Controls.Add(this.btnIniciarBkp);
            this.gpbConfigBackup.Controls.Add(this.btnPathDir);
            this.gpbConfigBackup.Controls.Add(this.txtPathDir);
            this.gpbConfigBackup.Controls.Add(this.gpbTipoBkp);
            this.gpbConfigBackup.Location = new System.Drawing.Point(12, 12);
            this.gpbConfigBackup.Name = "gpbConfigBackup";
            this.gpbConfigBackup.Size = new System.Drawing.Size(523, 171);
            this.gpbConfigBackup.TabIndex = 0;
            this.gpbConfigBackup.TabStop = false;
            this.gpbConfigBackup.Text = "Configurar";
            // 
            // brnCancelar
            // 
            this.brnCancelar.Image = global::Piagg.AutoQuery.View.Properties.Resources.cancelar_32_x_32;
            this.brnCancelar.Location = new System.Drawing.Point(467, 115);
            this.brnCancelar.Name = "brnCancelar";
            this.brnCancelar.Size = new System.Drawing.Size(50, 50);
            this.brnCancelar.TabIndex = 9;
            this.toolTip.SetToolTip(this.brnCancelar, "Cancelar");
            this.brnCancelar.UseVisualStyleBackColor = true;
            this.brnCancelar.Click += new System.EventHandler(this.brnCancelar_Click);
            // 
            // btnIniciarBkp
            // 
            this.btnIniciarBkp.Image = global::Piagg.AutoQuery.View.Properties.Resources.backup_32_x_32;
            this.btnIniciarBkp.Location = new System.Drawing.Point(404, 115);
            this.btnIniciarBkp.Name = "btnIniciarBkp";
            this.btnIniciarBkp.Size = new System.Drawing.Size(50, 50);
            this.btnIniciarBkp.TabIndex = 8;
            this.toolTip.SetToolTip(this.btnIniciarBkp, "Iniciar Backup / Restore");
            this.btnIniciarBkp.UseVisualStyleBackColor = true;
            this.btnIniciarBkp.Click += new System.EventHandler(this.btnIniciarBkp_Click);
            // 
            // btnPathDir
            // 
            this.btnPathDir.Image = ((System.Drawing.Image)(resources.GetObject("btnPathDir.Image")));
            this.btnPathDir.Location = new System.Drawing.Point(467, 21);
            this.btnPathDir.Name = "btnPathDir";
            this.btnPathDir.Size = new System.Drawing.Size(50, 50);
            this.btnPathDir.TabIndex = 7;
            this.toolTip.SetToolTip(this.btnPathDir, "Localizar Destino do Arquivo");
            this.btnPathDir.UseVisualStyleBackColor = true;
            this.btnPathDir.Click += new System.EventHandler(this.btnPathDir_Click);
            // 
            // txtPathDir
            // 
            this.txtPathDir.Location = new System.Drawing.Point(99, 35);
            this.txtPathDir.Name = "txtPathDir";
            this.txtPathDir.Size = new System.Drawing.Size(355, 20);
            this.txtPathDir.TabIndex = 5;
            // 
            // gpbTipoBkp
            // 
            this.gpbTipoBkp.Controls.Add(this.rdbRestore);
            this.gpbTipoBkp.Controls.Add(this.rdbBackup);
            this.gpbTipoBkp.Location = new System.Drawing.Point(6, 19);
            this.gpbTipoBkp.Name = "gpbTipoBkp";
            this.gpbTipoBkp.Size = new System.Drawing.Size(74, 70);
            this.gpbTipoBkp.TabIndex = 3;
            this.gpbTipoBkp.TabStop = false;
            this.gpbTipoBkp.Text = "Tipo:";
            // 
            // rdbRestore
            // 
            this.rdbRestore.AutoSize = true;
            this.rdbRestore.Location = new System.Drawing.Point(6, 47);
            this.rdbRestore.Name = "rdbRestore";
            this.rdbRestore.Size = new System.Drawing.Size(62, 17);
            this.rdbRestore.TabIndex = 4;
            this.rdbRestore.TabStop = true;
            this.rdbRestore.Text = "Restore";
            this.rdbRestore.UseVisualStyleBackColor = true;
            // 
            // rdbBackup
            // 
            this.rdbBackup.AutoSize = true;
            this.rdbBackup.Location = new System.Drawing.Point(6, 19);
            this.rdbBackup.Name = "rdbBackup";
            this.rdbBackup.Size = new System.Drawing.Size(62, 17);
            this.rdbBackup.TabIndex = 3;
            this.rdbBackup.TabStop = true;
            this.rdbBackup.Text = "Backup";
            this.rdbBackup.UseVisualStyleBackColor = true;
            // 
            // ofdDiretorio
            // 
            this.ofdDiretorio.FileName = "openFileDialog1";
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 195);
            this.Controls.Add(this.gpbConfigBackup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco de Dados - (Backup / Restore)";
            this.gpbConfigBackup.ResumeLayout(false);
            this.gpbConfigBackup.PerformLayout();
            this.gpbTipoBkp.ResumeLayout(false);
            this.gpbTipoBkp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbConfigBackup;
        private System.Windows.Forms.GroupBox gpbTipoBkp;
        private System.Windows.Forms.RadioButton rdbRestore;
        private System.Windows.Forms.RadioButton rdbBackup;
        private System.Windows.Forms.FolderBrowserDialog fbdDiretorio;
        private System.Windows.Forms.TextBox txtPathDir;
        private System.Windows.Forms.Button btnPathDir;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.OpenFileDialog ofdDiretorio;
        private System.Windows.Forms.Button brnCancelar;
        private System.Windows.Forms.Button btnIniciarBkp;
    }
}