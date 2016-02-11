﻿using Piagg.AutoQuery.BLL;
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
            var listaTipoGastos = tipoGastoBLL.SelectAll(new TipoGastosTO());

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

            var listaGastos = gastosBLL.SelectAll(filtro);

            if (listaGastos.Count == 0)
            {
                MessageBox.Show("Nenhum gasto encontrado nesse período");
                return;
            }

            preencherGrid(listaGastos);
        }

        /*
         * Recebe uma lista de gastos e preenche na grid
         */
        private void preencherGrid(List<GastosTO> listaGastos)
        {

            //Alinhando texto à esquerda
            this.dgvListaGastos.Columns["colValor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            foreach (var gasto in listaGastos)
            {
                dgvListaGastos.Rows.Add(gasto.ID_GASTOS,
                                        gasto.DATA,
                                        gasto.LOCAL,
                                        Convert.ToDecimal(OutrosUtil.FormatarDecimal(gasto.VALOR)),
                                        gasto.FK_ID_TIPO_GASTOS.TIPO
                                        );
            }

        }

        /*
         * Verifica os filtros na tela e preenche o objeto de filtro
         */
        public FiltroGastosTO Filtro()
        {
            FiltroGastosTO filtro = new FiltroGastosTO();

            filtro.DataInicio = dtpDataIni.Value;
            filtro.DataFim = dtpDataFim.Value;
            filtro.IdTipoGasto = Convert.ToInt32(cbxTipoGasto.SelectedValue);


            return filtro;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            frmCadGasto frmCadGasto = new frmCadGasto();
            frmCadGasto.Incluir();
        }


    }
}