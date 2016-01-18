using Piagg.AutoQuery.BLL.BLL;
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
    public partial class frmCadGasto : Form
    {
        public frmCadGasto()
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
            

            cbxTipoGasto.DisplayMember = "TIPO";
            cbxTipoGasto.ValueMember = "ID_TIPO_GASTOS";
            cbxTipoGasto.DataSource = listaTipoGastos.OrderBy(x => x.TIPO).ToList();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarDados();
        }
        private void BuscarDados()
        { 

        }

    }
}
