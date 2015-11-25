using Piagg.AutoQuery.BLL;
using Piagg.AutoQuery.Model;
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
    public partial class frmControle : Form
    {
        public frmControle()
        {
            InitializeComponent();
        }

        private List<GastosTO> listaGastosDetalhe { get; set; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarDados();
        }

        /*
         * Inicia a comunicação com o banco de dados
         */
        private void BuscarDados()
        {
            //Se houver dados na grid de detlhes, limpa
            if (listaGastosDetalhe != null)
            {
                listaGastosDetalhe.Clear();
            }

            //Verifica os filtros de tela
            var filtro = Filtro();


            GastosBLL gastosBLL = new GastosBLL();
            //Busca os dados agrupados por tipo do gasto
            var listaGastosMaster = gastosBLL.getSomatorioPorTipo(filtro);

            if (listaGastosMaster.Count == 0)
            {
                MessageBox.Show("Nenhum gasto encontrado nesse período");
                return;
            }

            //Busca dos dados da grid de detalhes com o filtro de tela, para permanecer em memória
            listaGastosDetalhe = gastosBLL.SelectAll(filtro);

            //Popula a grid master
            PreencherGridMaster(listaGastosMaster);
        }

        private void PreencherGridMaster(List<GastosTO> listaGastos)
        {
            dgvMaster.Rows.Clear();

            //Alinhando texto à esquerda
            this.dgvMaster.Columns["colValor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            foreach (var gasto in listaGastos)
            {

                //valor decimal formatado
                var valor = String.Format("{0:0.0,0}",gasto.VALOR);

                dgvMaster.Rows.Add(gasto.ID_TIPO_GASTOS,
                                   gasto.TIPO,
                                   valor);
            }

            var total = Convert.ToDecimal(listaGastos.Sum(x => x.VALOR));
            txtValorTotal.Text = total.ToString("#0.00");
        }


        private void PreencherGridDetalhe(List<GastosTO> listaGastos)
        {
            dgvMaster.Rows.Clear();

            //Alinhando texto à direita
            this.dgvMaster.Columns["colValor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            foreach (var gasto in listaGastos)
            {

                //valor decimal formatado
                var valor = String.Format("{0:0.0,0}", gasto.VALOR);

                dgvMaster.Rows.Add(gasto.ID_TIPO_GASTOS,
                                   gasto.TIPO,
                                   valor);
            }

            var total = Convert.ToDecimal(listaGastos.Sum(x => x.VALOR));
            txtValorTotal.Text = total.ToString("#0.00");
        }

        public GastosFiltroTela Filtro()
        {
            GastosFiltroTela filtro = new GastosFiltroTela();

            filtro.DataInicio = dtpInicio.Value;
            filtro.DataFim = dtpFim.Value;

            return filtro;
        }

        private void dgvMaster_SelectionChanged(object sender, EventArgs e)
        {
            //Alinhando texto à direita
            this.dgvDetalhe.Columns["colData"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvDetalhe.Columns["colValorDet"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            
            foreach (DataGridViewRow row in dgvMaster.SelectedRows)
            {
                int idTipoGastos = Convert.ToInt32(row.Cells[0].Value.ToString());

                var listaFiltradaPorTipo = GetListaDadosDetalhe(idTipoGastos);
                dgvDetalhe.Rows.Clear();

                foreach (var detalhe in listaFiltradaPorTipo)
                {
                    //valor decimal formatado
                    var valor = String.Format("{0:0.0,0}", detalhe.VALOR);

                    dgvDetalhe.Rows.Add(detalhe.DATA,
                                       detalhe.LOCAL,
                                       valor);
                }

                var total = Convert.ToDecimal(listaFiltradaPorTipo.Sum(x => x.VALOR));
                txtValorTotalDet.Text = String.Format("{0:0.0,0}", total);
            }
        }

        private List<GastosTO> GetListaDadosDetalhe(int idTipoGastos)
        {
            var retorno = listaGastosDetalhe.FindAll(x => x.ID_TIPO_GASTOS == Convert.ToInt32(idTipoGastos));

            return retorno;
        }

    }
}
