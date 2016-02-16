using Piagg.AutoQuery.BLL;
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

namespace Piagg.AutoQuery.View.Telas
{
    public partial class frmCadGasto : Form    
    {

        private GastosTO gastosTO = null;

        public frmCadGasto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                MessageBox.Show("Existem campos não preenchidos"); 
                return;
            }
            List<GastosTO> gastoListaTO = new List<GastosTO>();

            if (gastosTO != null)
            {
                PreencherValores();
                gastoListaTO.Add(gastosTO);
            }

            GastosBLL gastosBLL = new GastosBLL();
            gastosBLL.Save(gastoListaTO);

            VerificarNovaInclusao();
        }

        /*
         * Caso o usuário optar por continuar inserindo gastos, deverá limpar a tela e o objeto.
         * Senão deverá encerrar o form
         */
        private void VerificarNovaInclusao()
        {
            DialogResult dialogResult = MessageBox.Show("Deseja incluir um novo gasto?", "Incluir", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                LimparTela();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
            }
        }

        /*
         * Insere os valores capturados da tela no objeto a ser salvo no banco de dados 
         */
        private void PreencherValores()
        {
            gastosTO.DATA = dtpData.Value;
            gastosTO.LOCAL = txtLocal.Text.Trim();
            gastosTO.VALOR = Convert.ToDecimal(txtValor.Text);
            gastosTO.ID_TIPO_GASTOS = (int) cbxTipoGasto.SelectedValue;
            gastosTO.StatusBD = StatusTransacao.Insert;
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

        /*
         * Verifica se todos os campos foram preenchido corretamente
         */
        private bool ValidarCampos()
        {

            if (String.IsNullOrEmpty(txtLocal.Text))
            {
                return false;
            }
            else if (String.IsNullOrEmpty(txtValor.Text))
            {
                return false;
            }
            else if (String.IsNullOrEmpty(dtpData.Text))
            {
                return false;
            }
            else if (Convert.ToInt32(cbxTipoGasto.SelectedValue) <= 0)
            {
                return false;
            }

            return true;
        }

        private void frmCadGasto_Load(object sender, EventArgs e)
        {
            carregarCombos();
        }


        public void Incluir()
        {
            gastosTO = new GastosTO();
            this.ShowDialog();
        }

        /*
         * Limpa a tela para uma nova inclusão
         */
        private void LimparTela()
        {
            dtpData.Value = DateTime.Now;
            txtValor.ResetText();
            txtLocal.Text = "";
            cbxTipoGasto.SelectedItem = 1;
            gastosTO = new GastosTO();

        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            Double value;
            if (Double.TryParse(txtValor.Text, out value))
            {
                txtValor.Text = String.Format("{0:C2}", value);
                txtValor.Text = txtValor.Text.Replace("R$", "");
                txtValor.Text.Trim();
            }
            else
            {
                txtValor.Text = String.Empty;
            }                
        }

        /*
         * Alteração de gastos
         */
        public void Alterar(GastosTO gastoTO)
        {
            
        }
    }
}