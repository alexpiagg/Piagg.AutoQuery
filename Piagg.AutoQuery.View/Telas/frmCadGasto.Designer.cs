namespace Piagg.AutoQuery.View
{
    partial class frmCadGasto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadGasto));
            this.gpbCadGasto = new System.Windows.Forms.GroupBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.cbxTipoGasto = new System.Windows.Forms.ComboBox();
            this.nupValor = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.dgvListaGastos = new System.Windows.Forms.DataGridView();
            this.gpbCadGasto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbCadGasto
            // 
            this.gpbCadGasto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbCadGasto.Controls.Add(this.lblLocal);
            this.gpbCadGasto.Controls.Add(this.lblTipo);
            this.gpbCadGasto.Controls.Add(this.lblValor);
            this.gpbCadGasto.Controls.Add(this.lblData);
            this.gpbCadGasto.Controls.Add(this.cbxTipoGasto);
            this.gpbCadGasto.Controls.Add(this.nupValor);
            this.gpbCadGasto.Controls.Add(this.textBox1);
            this.gpbCadGasto.Controls.Add(this.dtpData);
            this.gpbCadGasto.Location = new System.Drawing.Point(12, 12);
            this.gpbCadGasto.Name = "gpbCadGasto";
            this.gpbCadGasto.Size = new System.Drawing.Size(490, 117);
            this.gpbCadGasto.TabIndex = 0;
            this.gpbCadGasto.TabStop = false;
            this.gpbCadGasto.Text = "Cadastrar";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(6, 74);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(33, 13);
            this.lblLocal.TabIndex = 6;
            this.lblLocal.Text = "Local";
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(360, 23);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(52, 13);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Categoria";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(174, 23);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(54, 13);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor (R$)";
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(6, 23);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Data";
            // 
            // cbxTipoGasto
            // 
            this.cbxTipoGasto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxTipoGasto.FormattingEnabled = true;
            this.cbxTipoGasto.Location = new System.Drawing.Point(363, 39);
            this.cbxTipoGasto.Name = "cbxTipoGasto";
            this.cbxTipoGasto.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoGasto.TabIndex = 3;
            // 
            // nupValor
            // 
            this.nupValor.DecimalPlaces = 2;
            this.nupValor.Location = new System.Drawing.Point(177, 39);
            this.nupValor.Name = "nupValor";
            this.nupValor.Size = new System.Drawing.Size(120, 20);
            this.nupValor.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(6, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(478, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dtpData
            // 
            this.dtpData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpData.Location = new System.Drawing.Point(6, 40);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(100, 20);
            this.dtpData.TabIndex = 0;
            // 
            // dgvListaGastos
            // 
            this.dgvListaGastos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaGastos.Location = new System.Drawing.Point(12, 135);
            this.dgvListaGastos.Name = "dgvListaGastos";
            this.dgvListaGastos.Size = new System.Drawing.Size(490, 328);
            this.dgvListaGastos.TabIndex = 1;
            // 
            // frmCadGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 475);
            this.Controls.Add(this.dgvListaGastos);
            this.Controls.Add(this.gpbCadGasto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadGasto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Gasto";
            this.gpbCadGasto.ResumeLayout(false);
            this.gpbCadGasto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaGastos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCadGasto;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.NumericUpDown nupValor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbxTipoGasto;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DataGridView dgvListaGastos;
    }
}