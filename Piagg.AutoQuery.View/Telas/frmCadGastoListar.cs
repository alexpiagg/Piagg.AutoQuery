using Piagg.AutoQuery.BLL;
using Piagg.AutoQuery.BLL.BLL;
using Piagg.AutoQuery.Helpers;
using Piagg.AutoQuery.Model;
using Piagg.AutoQuery.View.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piagg.AutoQuery.View
{
    public partial class frmCadGastoListar : Form
    {
        public frmCadGastoListar()
        {
            InitializeComponent();
        }

        private void frmCadGasto_Load(object sender, EventArgs e)
        {
            carregarCombos();
        }

        private void carregarCombos()
        {
            //Impede que o comboBox seja editável
            cbxTipoGasto.DropDownStyle = ComboBoxStyle.DropDownList;

            TipoGastosBLL tipoGastoBLL = new TipoGastosBLL();
            var listaTipoGastos = tipoGastoBLL.SelectAll(new FiltroTelaTO());

            listaTipoGastos.Insert(0, new TipoGastosTO());
            
            cbxTipoGasto.DisplayMember = "TIPO";
            cbxTipoGasto.ValueMember = "ID_TIPO_GASTOS";
            cbxTipoGasto.DataSource = listaTipoGastos.OrderBy(x => x.TIPO).ToList();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (dgvListaGastos.Rows.Count > 0)
            {
                dgvListaGastos.Rows.Clear();
            }

            BuscarDados();
        }
        private void BuscarDados()
        {
            GastosBLL gastosBLL = new GastosBLL();
            var filtro = Filtro();

            try
            {
                var listaGastos = gastosBLL.SelectAll(filtro);
                
                if (listaGastos.Count == 0)
                {
                    MessageBox.Show("Nenhum gasto encontrado nesse período");
                    return;
                }

                preencherGrid(listaGastos);
            }
            catch (Exception ex)
            {
                LoggerUtil.ErrorLog(ex.Message);
                MessageBox.Show("Erro ao buscar os dados.");
            }
        }

        /*
         * Recebe uma lista de gastos e preenche na grid
         */
        private void preencherGrid(List<GastosTO> listaGastos)
        {

            dgvListaGastos.Rows.Clear();

            //Alinhando texto à esquerda
            this.dgvListaGastos.Columns["colValor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            foreach (var gasto in listaGastos)
            {
                dgvListaGastos.Rows.Add(gasto.ID_GASTOS,
                                        gasto.DATA,
                                        gasto.LOCAL,
                                        Convert.ToDecimal(OutrosUtil.FormatarDecimal(gasto.VALOR)),
                                        gasto.TIPO
                                        );
            }

        }

        /*
         * Verifica os filtros na tela e preenche o objeto de filtro
         */
        public FiltroTelaTO Filtro()
        {
            FiltroTelaTO filtro = new FiltroTelaTO();

            filtro.DataInicio = dtpDataIni.Value;
            filtro.DataFim = dtpDataFim.Value;
            filtro.IdTipoGasto = Convert.ToInt32(cbxTipoGasto.SelectedValue);
            filtro.Local = txtLocal.Text.Trim();

            return filtro;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            frmCadGasto frmCadGasto = new frmCadGasto();
            frmCadGasto.Incluir();
            BuscarDados();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmCadGasto frmCadGasto = new frmCadGasto();

            GastosTO gastosTO = new GastosTO();
            if (dgvListaGastos.CurrentRow != null)
            {
                DataGridViewRow row = this.dgvListaGastos.SelectedRows[0];
                int idGastos = (int) row.Cells["codlIdGastos"].Value;

                gastosTO.ID_GASTOS = idGastos;
                frmCadGasto.Alterar(gastosTO);
            }
            else
            {
                MessageBox.Show("Selecionar um item na lista :)");
            }

            BuscarDados();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            frmCadGasto frmCadGasto = new frmCadGasto();

            GastosTO gastosTO = new GastosTO();
            if (dgvListaGastos.CurrentRow != null)
            {
                DataGridViewRow row = this.dgvListaGastos.SelectedRows[0];
                int idGastos = (int)row.Cells["codlIdGastos"].Value;

                gastosTO.ID_GASTOS = idGastos;
                frmCadGasto.Excluir(gastosTO);
            }
            else
            {
                MessageBox.Show("Selecionar um item na lista :)");
            }

            BuscarDados();
        }


    }
}
