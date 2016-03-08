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
    public partial class frmCadTipoGastoListar : Form
    {
        public frmCadTipoGastoListar()
        {
            InitializeComponent();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (dgvListaTipoGastos.Rows.Count > 0)
            {
                dgvListaTipoGastos.Rows.Clear();
            }

            BuscarDados();
        }
        private void BuscarDados()
        {
            TipoGastosBLL tipoGastosBLL = new TipoGastosBLL();
            var filtro = Filtro();

            try
            {
                var listaTipoGastos = tipoGastosBLL.SelectAll(filtro);

                if (listaTipoGastos.Count == 0)
                {
                    MessageBox.Show("Nenhum tipo encontrado!");
                    return;
                }

                preencherGrid(listaTipoGastos);
            }
            catch (Exception ex)
            {
                LoggerUtil.ErrorLog(ex.Message, ex);
                MessageBox.Show("Erro ao buscar os dados.");
            }
        }

        /*
         * Recebe uma lista de gastos e preenche na grid
         */
        private void preencherGrid(List<TipoGastosTO> listaTipoGastos)
        {
            dgvListaTipoGastos.Rows.Clear();

            foreach (var tipoGasto in listaTipoGastos)
            {
                //Alinhando texto à esquerda
                this.dgvListaTipoGastos.Columns["codlIdTipoGastos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                bool MarcarExcluido = false;

                if (tipoGasto.EXCLUIDO != null)
                {
                    MarcarExcluido = (tipoGasto.EXCLUIDO == 0 ? false : true);
                }

                dgvListaTipoGastos.Rows.Add(tipoGasto.ID_TIPO_GASTOS,
                                            tipoGasto.TIPO,
                                            MarcarExcluido
                                            );
            }

        }

        /*
         * Verifica os filtros na tela e preenche o objeto de filtro
         */
        public FiltroTelaTO Filtro()
        {
            FiltroTelaTO filtro = new FiltroTelaTO();

            filtro.IdTipoGasto = (int) txtCodigo.Value;
            filtro.TipoGasto = txtLocal.Text.Trim();
            filtro.Excluido = (chkExcluido.Checked ? (int)Excluido.Sim : (int)Excluido.Nao);

            return filtro;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            frmCadTipoGasto frmCadGasto = new frmCadTipoGasto();
            frmCadGasto.Incluir();
            BuscarDados();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmCadTipoGasto frmCadTipoGasto = new frmCadTipoGasto();

            TipoGastosTO tipoGastosTO = new TipoGastosTO();
            if (dgvListaTipoGastos.CurrentRow != null)
            {
                DataGridViewRow row = this.dgvListaTipoGastos.SelectedRows[0];
                int idTipoGastos = (int)row.Cells["codlIdTipoGastos"].Value;

                tipoGastosTO.ID_TIPO_GASTOS = idTipoGastos;
                frmCadTipoGasto.Alterar(tipoGastosTO);
            }
            else
            {
                MessageBox.Show("Selecionar um item na lista :)");
            }

            BuscarDados();
        }

    }
}
