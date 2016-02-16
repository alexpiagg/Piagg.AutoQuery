namespace Piagg.AutoQuery.View
{
    partial class frmCadGastoListar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadGastoListar));
            this.gpbCadGasto = new System.Windows.Forms.GroupBox();
            this.lblFim = new System.Windows.Forms.Label();
            this.dtpDataFim = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.cbxTipoGasto = new System.Windows.Forms.ComboBox();
            this.dtpDataIni = new System.Windows.Forms.DateTimePicker();
            this.dgvListaGastos = new System.Windows.Forms.DataGridView();
            this.codlIdGastos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gpbCadGasto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbCadGasto
            // 
            this.gpbCadGasto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbCadGasto.Controls.Add(this.lblFim);
            this.gpbCadGasto.Controls.Add(this.dtpDataFim);
            this.gpbCadGasto.Controls.Add(this.btnBuscar);
            this.gpbCadGasto.Controls.Add(this.lblTipo);
            this.gpbCadGasto.Controls.Add(this.lblInicio);
            this.gpbCadGasto.Controls.Add(this.cbxTipoGasto);
            this.gpbCadGasto.Controls.Add(this.dtpDataIni);
            this.gpbCadGasto.Location = new System.Drawing.Point(12, 12);
            this.gpbCadGasto.Name = "gpbCadGasto";
            this.gpbCadGasto.Size = new System.Drawing.Size(565, 79);
            this.gpbCadGasto.TabIndex = 0;
            this.gpbCadGasto.TabStop = false;
            this.gpbCadGasto.Text = "Cadastrar";
            // 
            // lblFim
            // 
            this.lblFim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFim.AutoSize = true;
            this.lblFim.Location = new System.Drawing.Point(164, 22);
            this.lblFim.Name = "lblFim";
            this.lblFim.Size = new System.Drawing.Size(23, 13);
            this.lblFim.TabIndex = 2;
            this.lblFim.Text = "Fim";
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpDataFim.Location = new System.Drawing.Point(164, 39);
            this.dtpDataFim.Name = "dtpDataFim";
            this.dtpDataFim.Size = new System.Drawing.Size(100, 20);
            this.dtpDataFim.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(496, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(50, 50);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(323, 23);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(52, 13);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Categoria";
            // 
            // lblInicio
            // 
            this.lblInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(6, 23);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(34, 13);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "Início";
            // 
            // cbxTipoGasto
            // 
            this.cbxTipoGasto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxTipoGasto.FormattingEnabled = true;
            this.cbxTipoGasto.Location = new System.Drawing.Point(326, 39);
            this.cbxTipoGasto.Name = "cbxTipoGasto";
            this.cbxTipoGasto.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoGasto.TabIndex = 5;
            // 
            // dtpDataIni
            // 
            this.dtpDataIni.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpDataIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataIni.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpDataIni.Location = new System.Drawing.Point(6, 39);
            this.dtpDataIni.Name = "dtpDataIni";
            this.dtpDataIni.Size = new System.Drawing.Size(100, 20);
            this.dtpDataIni.TabIndex = 1;
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
            this.codlIdGastos,
            this.colData,
            this.colLocal,
            this.colValor,
            this.colCategoria});
            this.dgvListaGastos.Location = new System.Drawing.Point(12, 97);
            this.dgvListaGastos.MultiSelect = false;
            this.dgvListaGastos.Name = "dgvListaGastos";
            this.dgvListaGastos.ReadOnly = true;
            this.dgvListaGastos.RowHeadersVisible = false;
            this.dgvListaGastos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListaGastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaGastos.Size = new System.Drawing.Size(565, 298);
            this.dgvListaGastos.TabIndex = 1;
            // 
            // codlIdGastos
            // 
            this.codlIdGastos.HeaderText = "IdGasto";
            this.codlIdGastos.Name = "codlIdGastos";
            this.codlIdGastos.ReadOnly = true;
            this.codlIdGastos.Visible = false;
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
            // colValor
            // 
            this.colValor.HeaderText = "Valor (R$)";
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.Location = new System.Drawing.Point(527, 413);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(50, 50);
            this.btnIncluir.TabIndex = 3;
            this.toolTip.SetToolTip(this.btnIncluir, "Incluir");
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(357, 413);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(50, 50);
            this.btnExcluir.TabIndex = 2;
            this.toolTip.SetToolTip(this.btnExcluir, "Excluir");
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(443, 413);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(50, 50);
            this.btnAlterar.TabIndex = 1;
            this.toolTip.SetToolTip(this.btnAlterar, "Alterar");
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // frmCadGastoListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 475);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.dgvListaGastos);
            this.Controls.Add(this.gpbCadGasto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadGastoListar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Gastos";
            this.Load += new System.EventHandler(this.frmCadGasto_Load);
            this.gpbCadGasto.ResumeLayout(false);
            this.gpbCadGasto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaGastos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCadGasto;
        private System.Windows.Forms.DateTimePicker dtpDataIni;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.DataGridView dgvListaGastos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblFim;
        private System.Windows.Forms.DateTimePicker dtpDataFim;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        protected System.Windows.Forms.ComboBox cbxTipoGasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codlIdGastos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.ToolTip toolTip;
    }
}