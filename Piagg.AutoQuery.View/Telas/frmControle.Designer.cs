namespace Piagg.AutoQuery.View
{
    partial class frmControle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControle));
            this.gpbFiltros = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblFim = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dgvMaster = new System.Windows.Forms.DataGridView();
            this.colIdTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalhe = new System.Windows.Forms.DataGridView();
            this.lblMaster = new System.Windows.Forms.Label();
            this.lblDetalhe = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtValorTotalDet = new System.Windows.Forms.TextBox();
            this.lblTotalDetalhe = new System.Windows.Forms.Label();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorDet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalhe)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbFiltros
            // 
            this.gpbFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbFiltros.Controls.Add(this.btnBuscar);
            this.gpbFiltros.Controls.Add(this.lblFim);
            this.gpbFiltros.Controls.Add(this.lblInicio);
            this.gpbFiltros.Controls.Add(this.dtpFim);
            this.gpbFiltros.Controls.Add(this.dtpInicio);
            this.gpbFiltros.Location = new System.Drawing.Point(12, 12);
            this.gpbFiltros.Name = "gpbFiltros";
            this.gpbFiltros.Size = new System.Drawing.Size(595, 74);
            this.gpbFiltros.TabIndex = 0;
            this.gpbFiltros.TabStop = false;
            this.gpbFiltros.Text = "Filtros";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(514, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblFim
            // 
            this.lblFim.AutoSize = true;
            this.lblFim.Location = new System.Drawing.Point(155, 19);
            this.lblFim.Name = "lblFim";
            this.lblFim.Size = new System.Drawing.Size(23, 13);
            this.lblFim.TabIndex = 2;
            this.lblFim.Text = "Fim";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(6, 19);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(34, 13);
            this.lblInicio.TabIndex = 1;
            this.lblInicio.Text = "Início";
            // 
            // dtpFim
            // 
            this.dtpFim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(158, 35);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(114, 20);
            this.dtpFim.TabIndex = 1;
            this.dtpFim.Value = new System.DateTime(2015, 12, 2, 0, 0, 0, 0);
            // 
            // dtpInicio
            // 
            this.dtpInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(6, 35);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(114, 20);
            this.dtpInicio.TabIndex = 0;
            this.dtpInicio.Value = new System.DateTime(2015, 12, 2, 0, 0, 0, 0);
            // 
            // dgvMaster
            // 
            this.dgvMaster.AllowUserToAddRows = false;
            this.dgvMaster.AllowUserToDeleteRows = false;
            this.dgvMaster.AllowUserToResizeRows = false;
            this.dgvMaster.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaster.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdTipo,
            this.colTipo,
            this.colValor});
            this.dgvMaster.Location = new System.Drawing.Point(12, 113);
            this.dgvMaster.Name = "dgvMaster";
            this.dgvMaster.ReadOnly = true;
            this.dgvMaster.RowHeadersVisible = false;
            this.dgvMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaster.Size = new System.Drawing.Size(595, 152);
            this.dgvMaster.TabIndex = 1;
            this.dgvMaster.SelectionChanged += new System.EventHandler(this.dgvMaster_SelectionChanged);
            // 
            // colIdTipo
            // 
            this.colIdTipo.HeaderText = "Id_Tipo";
            this.colIdTipo.Name = "colIdTipo";
            this.colIdTipo.ReadOnly = true;
            this.colIdTipo.Visible = false;
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Categoria";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            // 
            // colValor
            // 
            this.colValor.FillWeight = 30F;
            this.colValor.HeaderText = "Valor (R$)";
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            // 
            // dgvDetalhe
            // 
            this.dgvDetalhe.AllowUserToAddRows = false;
            this.dgvDetalhe.AllowUserToDeleteRows = false;
            this.dgvDetalhe.AllowUserToResizeRows = false;
            this.dgvDetalhe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetalhe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalhe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvDetalhe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalhe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colData,
            this.colLocal,
            this.colValorDet});
            this.dgvDetalhe.Location = new System.Drawing.Point(12, 296);
            this.dgvDetalhe.Name = "dgvDetalhe";
            this.dgvDetalhe.ReadOnly = true;
            this.dgvDetalhe.RowHeadersVisible = false;
            this.dgvDetalhe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalhe.Size = new System.Drawing.Size(595, 164);
            this.dgvDetalhe.TabIndex = 2;
            // 
            // lblMaster
            // 
            this.lblMaster.AutoSize = true;
            this.lblMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaster.Location = new System.Drawing.Point(12, 97);
            this.lblMaster.Name = "lblMaster";
            this.lblMaster.Size = new System.Drawing.Size(88, 13);
            this.lblMaster.TabIndex = 3;
            this.lblMaster.Text = "Por Categoria:";
            // 
            // lblDetalhe
            // 
            this.lblDetalhe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDetalhe.AutoSize = true;
            this.lblDetalhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalhe.Location = new System.Drawing.Point(12, 280);
            this.lblDetalhe.Name = "lblDetalhe";
            this.lblDetalhe.Size = new System.Drawing.Size(69, 13);
            this.lblDetalhe.TabIndex = 4;
            this.lblDetalhe.Text = "Detalhado:";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(415, 271);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(71, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "TOTAL R$:";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtValorTotal.Location = new System.Drawing.Point(497, 268);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(110, 20);
            this.txtValorTotal.TabIndex = 6;
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValorTotalDet
            // 
            this.txtValorTotalDet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorTotalDet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtValorTotalDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotalDet.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtValorTotalDet.Location = new System.Drawing.Point(497, 468);
            this.txtValorTotalDet.Name = "txtValorTotalDet";
            this.txtValorTotalDet.ReadOnly = true;
            this.txtValorTotalDet.Size = new System.Drawing.Size(110, 20);
            this.txtValorTotalDet.TabIndex = 8;
            this.txtValorTotalDet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalDetalhe
            // 
            this.lblTotalDetalhe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalDetalhe.AutoSize = true;
            this.lblTotalDetalhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDetalhe.Location = new System.Drawing.Point(360, 471);
            this.lblTotalDetalhe.Name = "lblTotalDetalhe";
            this.lblTotalDetalhe.Size = new System.Drawing.Size(132, 13);
            this.lblTotalDetalhe.TabIndex = 7;
            this.lblTotalDetalhe.Text = "TOTAL DETALHE R$:";
            // 
            // colData
            // 
            this.colData.FillWeight = 40F;
            this.colData.HeaderText = "Data";
            this.colData.Name = "colData";
            this.colData.ReadOnly = true;
            // 
            // colLocal
            // 
            this.colLocal.FillWeight = 116.8786F;
            this.colLocal.HeaderText = "Local";
            this.colLocal.Name = "colLocal";
            this.colLocal.ReadOnly = true;
            // 
            // colValorDet
            // 
            this.colValorDet.FillWeight = 59.63196F;
            this.colValorDet.HeaderText = "Valor (R$)";
            this.colValorDet.Name = "colValorDet";
            this.colValorDet.ReadOnly = true;
            // 
            // frmControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 493);
            this.Controls.Add(this.txtValorTotalDet);
            this.Controls.Add(this.lblTotalDetalhe);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDetalhe);
            this.Controls.Add(this.lblMaster);
            this.Controls.Add(this.dgvDetalhe);
            this.Controls.Add(this.dgvMaster);
            this.Controls.Add(this.gpbFiltros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmControle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle";
            this.gpbFiltros.ResumeLayout(false);
            this.gpbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalhe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbFiltros;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFim;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvMaster;
        private System.Windows.Forms.DataGridView dgvDetalhe;
        private System.Windows.Forms.Label lblMaster;
        private System.Windows.Forms.Label lblDetalhe;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtValorTotalDet;
        private System.Windows.Forms.Label lblTotalDetalhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorDet;
    }
}