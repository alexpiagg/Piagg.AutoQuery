namespace Piagg.AutoQuery.View.Telas
{
    partial class frmCadTipoGasto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadTipoGasto));
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.chkExcluir = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(12, 62);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(484, 20);
            this.txtDescricao.TabIndex = 7;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(12, 46);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 6;
            this.lblDescricao.Text = "Descrição";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Piagg.AutoQuery.View.Properties.Resources.cancelar_32_x_32;
            this.btnCancelar.Location = new System.Drawing.Point(444, 91);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(50, 50);
            this.btnCancelar.TabIndex = 9;
            this.toolTip.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::Piagg.AutoQuery.View.Properties.Resources.salvar_32_x_32;
            this.btnSalvar.Location = new System.Drawing.Point(366, 91);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(50, 50);
            this.btnSalvar.TabIndex = 8;
            this.toolTip.SetToolTip(this.btnSalvar, "Salvar");
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // chkExcluir
            // 
            this.chkExcluir.AutoSize = true;
            this.chkExcluir.Location = new System.Drawing.Point(414, 25);
            this.chkExcluir.Name = "chkExcluir";
            this.chkExcluir.Size = new System.Drawing.Size(63, 17);
            this.chkExcluir.TabIndex = 10;
            this.chkExcluir.Text = "Excluir?";
            this.chkExcluir.UseVisualStyleBackColor = true;
            // 
            // frmCadTipoGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 153);
            this.Controls.Add(this.chkExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDescricao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadTipoGasto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Tipo Gasto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox chkExcluir;
    }
}