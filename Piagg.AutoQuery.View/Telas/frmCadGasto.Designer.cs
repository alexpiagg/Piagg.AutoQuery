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
            this.nupValor = new System.Windows.Forms.NumericUpDown();
            this.lblLocal = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.cbxTipoGasto = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.dgvListaGastos = new System.Windows.Forms.DataGridView();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.gpbCadGasto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbCadGasto
            // 
            this.gpbCadGasto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbCadGasto.Controls.Add(this.button1);
            this.gpbCadGasto.Controls.Add(this.nupValor);
            this.gpbCadGasto.Controls.Add(this.lblLocal);
            this.gpbCadGasto.Controls.Add(this.lblTipo);
            this.gpbCadGasto.Controls.Add(this.lblValor);
            this.gpbCadGasto.Controls.Add(this.lblData);
            this.gpbCadGasto.Controls.Add(this.cbxTipoGasto);
            this.gpbCadGasto.Controls.Add(this.textBox1);
            this.gpbCadGasto.Controls.Add(this.dtpData);
            this.gpbCadGasto.Location = new System.Drawing.Point(12, 12);
            this.gpbCadGasto.Name = "gpbCadGasto";
            this.gpbCadGasto.Size = new System.Drawing.Size(565, 117);
            this.gpbCadGasto.TabIndex = 0;
            this.gpbCadGasto.TabStop = false;
            this.gpbCadGasto.Text = "Cadastrar";
            // 
            // nupValor
            // 
            this.nupValor.DecimalPlaces = 2;
            this.nupValor.Location = new System.Drawing.Point(146, 39);
            this.nupValor.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupValor.Name = "nupValor";
            this.nupValor.Size = new System.Drawing.Size(120, 20);
            this.nupValor.TabIndex = 8;
            this.nupValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.lblTipo.Location = new System.Drawing.Point(306, 23);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(52, 13);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Categoria";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(143, 23);
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
            this.cbxTipoGasto.Location = new System.Drawing.Point(309, 39);
            this.cbxTipoGasto.Name = "cbxTipoGasto";
            this.cbxTipoGasto.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoGasto.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(6, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(553, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dtpData
            // 
            this.dtpData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpData.Location = new System.Drawing.Point(6, 39);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(100, 20);
            this.dtpData.TabIndex = 0;
            // 
            // dgvListaGastos
            // 
            this.dgvListaGastos.AllowUserToAddRows = false;
            this.dgvListaGastos.AllowUserToDeleteRows = false;
            this.dgvListaGastos.AllowUserToResizeRows = false;
            this.dgvListaGastos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaGastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaGastos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListaGastos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvListaGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaGastos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colData,
            this.colLocal,
            this.col,
            this.colCategoria});
            this.dgvListaGastos.Location = new System.Drawing.Point(12, 135);
            this.dgvListaGastos.Name = "dgvListaGastos";
            this.dgvListaGastos.ReadOnly = true;
            this.dgvListaGastos.RowHeadersVisible = false;
            this.dgvListaGastos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListaGastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaGastos.Size = new System.Drawing.Size(565, 328);
            this.dgvListaGastos.TabIndex = 1;
            // 
            // colData
            // 
            this.colData.HeaderText = "Data";
            this.colData.Name = "colData";
            this.colData.ReadOnly = true;
            // 
            // colLocal
            // 
            this.colLocal.HeaderText = "Local";
            this.colLocal.Name = "colLocal";
            this.colLocal.ReadOnly = true;
            // 
            // col
            // 
            this.col.HeaderText = "Valor (R$)";
            this.col.Name = "col";
            this.col.ReadOnly = true;
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCadGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 475);
            this.Controls.Add(this.dgvListaGastos);
            this.Controls.Add(this.gpbCadGasto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadGasto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Gastos";
            this.Load += new System.EventHandler(this.frmCadGasto_Load);
            this.gpbCadGasto.ResumeLayout(false);
            this.gpbCadGasto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaGastos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCadGasto;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbxTipoGasto;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DataGridView dgvListaGastos;
        private System.Windows.Forms.NumericUpDown nupValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn col;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.Button button1;
    }
}