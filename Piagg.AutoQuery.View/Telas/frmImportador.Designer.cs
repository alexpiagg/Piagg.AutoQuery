namespace Piagg.AutoQuery.View
{
    partial class frmImportador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportador));
            this.btnImportar = new System.Windows.Forms.Button();
            this.tbPrincipal = new System.Windows.Forms.TabControl();
            this.tabArquivo = new System.Windows.Forms.TabPage();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.tabGrid = new System.Windows.Forms.TabPage();
            this.dgvGrid = new System.Windows.Forms.DataGridView();
            this.colLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoGasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblSalvando = new System.Windows.Forms.Label();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.lblErro = new System.Windows.Forms.Label();
            this.tbPrincipal.SuspendLayout();
            this.tabArquivo.SuspendLayout();
            this.tabGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImportar
            // 
            this.btnImportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportar.Location = new System.Drawing.Point(539, 446);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(75, 34);
            this.btnImportar.TabIndex = 0;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // tbPrincipal
            // 
            this.tbPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPrincipal.Controls.Add(this.tabArquivo);
            this.tbPrincipal.Controls.Add(this.tabGrid);
            this.tbPrincipal.Location = new System.Drawing.Point(12, 12);
            this.tbPrincipal.Name = "tbPrincipal";
            this.tbPrincipal.SelectedIndex = 0;
            this.tbPrincipal.Size = new System.Drawing.Size(862, 423);
            this.tbPrincipal.TabIndex = 1;
            // 
            // tabArquivo
            // 
            this.tabArquivo.Controls.Add(this.txtArquivo);
            this.tabArquivo.Location = new System.Drawing.Point(4, 22);
            this.tabArquivo.Name = "tabArquivo";
            this.tabArquivo.Padding = new System.Windows.Forms.Padding(3);
            this.tabArquivo.Size = new System.Drawing.Size(854, 397);
            this.tabArquivo.TabIndex = 0;
            this.tabArquivo.Text = "Arquivo";
            this.tabArquivo.UseVisualStyleBackColor = true;
            // 
            // txtArquivo
            // 
            this.txtArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArquivo.Location = new System.Drawing.Point(0, 3);
            this.txtArquivo.Multiline = true;
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(851, 391);
            this.txtArquivo.TabIndex = 0;
            // 
            // tabGrid
            // 
            this.tabGrid.Controls.Add(this.dgvGrid);
            this.tabGrid.Location = new System.Drawing.Point(4, 22);
            this.tabGrid.Name = "tabGrid";
            this.tabGrid.Padding = new System.Windows.Forms.Padding(3);
            this.tabGrid.Size = new System.Drawing.Size(854, 397);
            this.tabGrid.TabIndex = 1;
            this.tabGrid.Text = "Grid";
            this.tabGrid.UseVisualStyleBackColor = true;
            // 
            // dgvGrid
            // 
            this.dgvGrid.AllowUserToAddRows = false;
            this.dgvGrid.AllowUserToDeleteRows = false;
            this.dgvGrid.AllowUserToResizeRows = false;
            this.dgvGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLocal,
            this.colValor,
            this.colData,
            this.colTipoGasto});
            this.dgvGrid.Location = new System.Drawing.Point(-3, 0);
            this.dgvGrid.Name = "dgvGrid";
            this.dgvGrid.RowHeadersVisible = false;
            this.dgvGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrid.Size = new System.Drawing.Size(857, 397);
            this.dgvGrid.TabIndex = 0;
            // 
            // colLocal
            // 
            this.colLocal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colLocal.FillWeight = 400F;
            this.colLocal.HeaderText = "Local";
            this.colLocal.MinimumWidth = 400;
            this.colLocal.Name = "colLocal";
            this.colLocal.Width = 400;
            // 
            // colValor
            // 
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            // 
            // colData
            // 
            this.colData.FillWeight = 80F;
            this.colData.HeaderText = "Data";
            this.colData.Name = "colData";
            // 
            // colTipoGasto
            // 
            this.colTipoGasto.FillWeight = 50F;
            this.colTipoGasto.HeaderText = "Categoria";
            this.colTipoGasto.Name = "colTipoGasto";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(789, 446);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 34);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Location = new System.Drawing.Point(631, 446);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 34);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblSalvando
            // 
            this.lblSalvando.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSalvando.AutoSize = true;
            this.lblSalvando.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalvando.Location = new System.Drawing.Point(360, 454);
            this.lblSalvando.Name = "lblSalvando";
            this.lblSalvando.Size = new System.Drawing.Size(114, 24);
            this.lblSalvando.TabIndex = 4;
            this.lblSalvando.Text = "Salvando...";
            this.lblSalvando.Visible = false;
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.Location = new System.Drawing.Point(13, 441);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(68, 13);
            this.lblTotalRegistros.TabIndex = 5;
            this.lblTotalRegistros.Text = "Total Linhas:";
            this.lblTotalRegistros.Visible = false;
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(13, 465);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(242, 20);
            this.lblErro.TabIndex = 6;
            this.lblErro.Text = "Existem erros na importação!";
            this.lblErro.Visible = false;
            // 
            // frmImportador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 487);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.lblTotalRegistros);
            this.Controls.Add(this.lblSalvando);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tbPrincipal);
            this.Controls.Add(this.btnImportar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmImportador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importador";
            this.tbPrincipal.ResumeLayout(false);
            this.tabArquivo.ResumeLayout(false);
            this.tabArquivo.PerformLayout();
            this.tabGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.TabControl tbPrincipal;
        private System.Windows.Forms.TabPage tabArquivo;
        private System.Windows.Forms.TabPage tabGrid;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.DataGridView dgvGrid;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoGasto;
        private System.Windows.Forms.Label lblSalvando;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.Label lblErro;
    }
}

