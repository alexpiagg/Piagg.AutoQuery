using Piagg.AutoQuery.BLL;
using Piagg.AutoQuery.BLL.BLL;
using Piagg.AutoQuery.Helpers;
using Piagg.AutoQuery.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piagg.AutoQuery.View
{
    public partial class frmImportador : Form    
    {

        private bool linhaErro = false;

        public frmImportador()
        {
            InitializeComponent();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtArquivo.Text))
            {
                MessageBox.Show("Não há dados para importação!");
                return;
            }

            TextoBLL textoBLL = new TextoBLL();
            ArrayList listaRetorno = textoBLL.processaTexto(txtArquivo.Text);

            PreencherGrid(listaRetorno);
            ControlarTelaImportar();
        }

        private void PreencherGrid(ArrayList listaLinhas)
        {
            TextoBLL textoBLL = new TextoBLL();

            foreach (var linha in listaLinhas)
            {
                if (linha == null)
                {
                    continue;
                }

                string[] coluna = linha.ToString().Split(',');

                //Se já passou por algum linha com problema, não validar novamente
                if (!linhaErro)
                {
                    linhaErro = textoBLL.ValidarLinhas(coluna);
                    
                    //Houve erro? Então avisa na tela
                    if (linhaErro)
                    {
                        lblErro.Visible = true;
                    }                    
                }

                //Populando grid com os dados importados
                dgvGrid.Rows.Add(   coluna[1], //local
                                    coluna[2].Replace('.', ','), //valor                
                                    coluna[0], //data                                    
                                    coluna[3]); //tipo gasto
            }

            //Altera automaticamente para a tabPage de Grid
            tbPrincipal.SelectedIndex = 1;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            List<GastosTO> listaGastosSalvar = new List<GastosTO>();
            ControlarTelaSalvar();

            foreach (DataGridViewRow row in dgvGrid.Rows)
            {
                if (row == null)
                {
                    continue;
                }

                GastosTO gasto = new GastosTO();

                string local = String.Empty;
                string valor = String.Empty;
                string data = String.Empty;
                string tipoGasto = String.Empty;

                local = row.Cells["colLocal"].Value.ToString();
                valor = row.Cells["colValor"].Value.ToString();
                data = row.Cells["colData"].Value.ToString();
                tipoGasto = row.Cells["colTipoGasto"].Value.ToString();

                gasto.LOCAL = local;
                gasto.VALOR = Convert.ToDecimal(valor);
                gasto.DATA = OutrosUtil.StringToDate(data);
                gasto.ID_TIPO_GASTOS = Convert.ToInt32(tipoGasto);
                gasto.StatusBD = StatusTransacao.Insert;

                listaGastosSalvar.Add(gasto);
            }

            try
            {
                GastosBLL gastosBLL = new GastosBLL();
                gastosBLL.Save(listaGastosSalvar);


                MessageBox.Show("Dados Salvos com Sucesso!");
                IniciarTela();
            }
            catch (Exception ex)
            {                
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            IniciarTela();
        }

        private void IniciarTela()
        {
            dgvGrid.Rows.Clear();
            txtArquivo.Clear();

            btnImportar.Enabled = true;
            btnLimpar.Enabled = true;
            btnSalvar.Enabled = false;
            lblSalvando.Visible = false;
            lblTotalRegistros.Text = "";
            lblErro.Visible = false;
            linhaErro = false;

            //Altera automaticamente para a tabPage de Grid
            tbPrincipal.SelectedIndex = 0;
        }

        private void ControlarTelaSalvar()
        {
            btnSalvar.Enabled = false;
            btnLimpar.Enabled = false;
            lblSalvando.Visible = true;
        }

        private void ControlarTelaImportar()
        {
            if (!linhaErro)
            {
                btnSalvar.Enabled = true;
            }
            
            btnImportar.Enabled = false;
            lblTotalRegistros.Visible = true;
            lblTotalRegistros.Text += "Total Linhas: " + dgvGrid.Rows.Count;

            txtArquivo.Clear();
        }

    }
}
