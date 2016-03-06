namespace Piagg.AutoQuery.View
{
    partial class frmCadTipoGastoListar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadTipoGastoListar));
            this.gpbCadTipoGasto = new System.Windows.Forms.GroupBox();
            this.chkExcluido = new System.Windows.Forms.CheckBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.NumericUpDown();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.lblTipoGasto = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvListaTipoGastos = new System.Windows.Forms.DataGridView();
            this.codlIdTipoGastos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoGasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExcluido = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gpbCadTipoGasto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTipoGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbCadTipoGasto
            // 
            this.gpbCadTipoGasto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbCadTipoGasto.Controls.Add(this.chkExcluido);
            this.gpbCadTipoGasto.Controls.Add(this.lblCodigo);
            this.gpbCadTipoGasto.Controls.Add(this.txtCodigo);
            this.gpbCadTipoGasto.Controls.Add(this.txtLocal);
            this.gpbCadTipoGasto.Controls.Add(this.lblTipoGasto);
            this.gpbCadTipoGasto.Controls.Add(this.btnBuscar);
            this.gpbCadTipoGasto.Location = new System.Drawing.Point(12, 12);
            this.gpbCadTipoGasto.Name = "gpbCadTipoGasto";
            this.gpbCadTipoGasto.Size = new System.Drawing.Size(565, 94);
            this.gpbCadTipoGasto.TabIndex = 0;
            this.gpbCadTipoGasto.TabStop = false;
            this.gpbCadTipoGasto.Text = "Filtros";
            // 
            // chkExcluido
            // 
            this.chkExcluido.AutoSize = true;
            this.chkExcluido.Location = new System.Drawing.Point(410, 19);
            this.chkExcluido.Name = "chkExcluido";
            this.chkExcluido.Size = new System.Drawing.Size(74, 17);
            this.chkExcluido.TabIndex = 11;
            this.chkExcluido.Text = "Excluído?";
            this.chkExcluido.UseVisualStyleBackColor = true;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 33);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 10;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(15, 49);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(55, 20);
            this.txtCodigo.TabIndex = 9;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(89, 49);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(395, 20);
            this.txtLocal.TabIndex = 8;
            // 
            // lblTipoGasto
            // 
            this.lblTipoGasto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTipoGasto.AutoSize = true;
            this.lblTipoGasto.Location = new System.Drawing.Point(86, 33);
            this.lblTipoGasto.Name = "lblTipoGasto";
            this.lblTipoGasto.Size = new System.Drawing.Size(55, 13);
            this.lblTipoGasto.TabIndex = 7;
            this.lblTipoGasto.Text = "Descrição";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(501, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(50, 50);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvListaTipoGastos
            // 
            this.dgvListaTipoGastos.AllowUserToAddRows = false;
            this.dgvListaTipoGastos.AllowUserToDeleteRows = false;
            this.dgvListaTipoGastos.AllowUserToResizeRows = false;
            this.dgvListaTipoGastos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaTipoGastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaTipoGastos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListaTipoGastos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvListaTipoGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaTipoGastos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codlIdTipoGastos,
            this.colTipoGasto,
            this.colExcluido});
            this.dgvListaTipoGastos.Location = new System.Drawing.Point(12, 112);
            this.dgvListaTipoGastos.MultiSelect = false;
            this.dgvListaTipoGastos.Name = "dgvListaTipoGastos";
            this.dgvListaTipoGastos.ReadOnly = true;
            this.dgvListaTipoGastos.RowHeadersVisible = false;
            this.dgvListaTipoGastos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListaTipoGastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaTipoGastos.Size = new System.Drawing.Size(565, 316);
            this.dgvListaTipoGastos.TabIndex = 1;
            // 
            // codlIdTipoGastos
            // 
            this.codlIdTipoGastos.FillWeight = 67.21975F;
            this.codlIdTipoGastos.HeaderText = "Código";
            this.codlIdTipoGastos.Name = "codlIdTipoGastos";
            this.codlIdTipoGastos.ReadOnly = true;
            // 
            // colTipoGasto
            // 
            this.colTipoGasto.FillWeight = 187.095F;
            this.colTipoGasto.HeaderText = "Descrição Tipo Gasto";
            this.colTipoGasto.Name = "colTipoGasto";
            this.colTipoGasto.ReadOnly = true;
            // 
            // colExcluido
            // 
            this.colExcluido.FillWeight = 45.68528F;
            this.colExcluido.HeaderText = "Excluído?";
            this.colExcluido.Name = "colExcluido";
            this.colExcluido.ReadOnly = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.Location = new System.Drawing.Point(527, 434);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(50, 50);
            this.btnIncluir.TabIndex = 3;
            this.toolTip.SetToolTip(this.btnIncluir, "Incluir");
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(443, 434);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(50, 50);
            this.btnAlterar.TabIndex = 1;
            this.toolTip.SetToolTip(this.btnAlterar, "Alterar");
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // frmCadTipoGastoListar
            // 
            this.AcceptButton = this.btnBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 491);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.dgvListaTipoGastos);
            this.Controls.Add(this.gpbCadTipoGasto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadTipoGastoListar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Tipo de Gastos";
            this.gpbCadTipoGasto.ResumeLayout(false);
            this.gpbCadTipoGasto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTipoGastos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCadTipoGasto;
        private System.Windows.Forms.DataGridView dgvListaTipoGastos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lblTipoGasto;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.NumericUpDown txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codlIdTipoGastos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoGasto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colExcluido;
        private System.Windows.Forms.CheckBox chkExcluido;
    }
}