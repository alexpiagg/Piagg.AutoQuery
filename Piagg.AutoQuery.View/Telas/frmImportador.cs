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
        public frmImportador()
        {
            InitializeComponent();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            TextoBLL textoBLL = new TextoBLL();
            ArrayList listaRetorno = textoBLL.processaTexto(txtArquivo.Text);

            PreencherGrid(listaRetorno);
            btnSalvar.Enabled = true;
            btnImportar.Enabled = false;
            txtArquivo.Clear();
        }

        private void PreencherGrid(ArrayList listaLinhas)
        {

            foreach (var linha in listaLinhas)
            {
                if (linha == null)
                {
                    continue;
                }

                string[] coluna = linha.ToString().Split(',');

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

                listaGastosSalvar.Add(gasto);
            }

            try
            {
                GastosBLL gastosBLL = new GastosBLL();

                foreach (var gasto in listaGastosSalvar)
                {
                    //gastosBLL.inserirGastos(listaGastosSalvar);
                    gasto.StatusBD = StatusTransacao.Insert;
                    gastosBLL.Save(gasto);
                }
                

                MessageBox.Show("Dados Salvos com Sucesso!");
                LimparTela();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparTela();
        }

        private void LimparTela()
        {
            dgvGrid.Rows.Clear();
            txtArquivo.Clear();

            btnImportar.Enabled = true;
            btnSalvar.Enabled = false;

            //Altera automaticamente para a tabPage de Grid
            tbPrincipal.SelectedIndex = 0;

        }
    }
}
