using Piagg.AutoQuery.BLL;
using Piagg.AutoQuery.BLL.BLL;
using Piagg.AutoQuery.Helpers;
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

            DialogResult dialogResult = MessageBox.Show("Deseja salvar?", "Salvando...", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            List<GastosTO> gastoListaTO = new List<GastosTO>();

            if (gastosTO != null)
            {
                PreencherValoresSalvar();
                gastoListaTO.Add(gastosTO);
            }

            try
            {
                GastosBLL gastosBLL = new GastosBLL();
                gastosBLL.Save(gastoListaTO);

                VerificarProcessoDepoisSalvar();
            }
            catch (Exception ex)
            {
                LoggerUtil.ErrorLog(ex.Message);
                MessageBox.Show("Erro ao salvar os dados.");
            }            
        }

        /*
         * Caso o usuário optar por continuar inserindo gastos, deverá limpar a tela e o objeto.
         * Senão deverá encerrar o form
         */
        private void VerificarProcessoDepoisSalvar()
        {
            /*Se for inclusão:
             * Pergunta se quer adicionar mais e limpa a tela, senão fecha a tela
             */
            if (gastosTO.StatusBD == StatusTransacao.Insert)
            {
                DialogResult dialogResult = MessageBox.Show(@"Dados salvos com sucesso! " + Environment.NewLine + 
                                                             "Deseja incluir um novo gasto?", "Incluir", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    LimparTela();
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }
            }
            else if (gastosTO.StatusBD == StatusTransacao.Update || gastosTO.StatusBD == StatusTransacao.Delete)
            {
                MessageBox.Show("Dados salvos com sucesso :)");
                this.Close();
            }
        }

        /*
         * Insere os valores capturados da tela no objeto a ser salvo no banco de dados 
         */
        private void PreencherValoresSalvar()
        {
            gastosTO.DATA = dtpData.Value;
            gastosTO.LOCAL = txtLocal.Text.Trim();
            gastosTO.VALOR = Convert.ToDecimal(txtValor.Text);
            gastosTO.ID_TIPO_GASTOS = (int) cbxTipoGasto.SelectedValue;
        }
    
        private void carregarCombos()
        {
            //Impede que o comboBox seja editável
            cbxTipoGasto.DropDownStyle = ComboBoxStyle.DropDownList;

            TipoGastosBLL tipoGastoBLL = new TipoGastosBLL();
            var listaTipoGastos = tipoGastoBLL.SelectAll(new FiltroTelaTO());

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


        public void Incluir()
        {
            carregarCombos();

            gastosTO = new GastosTO();
            gastosTO.StatusBD = StatusTransacao.Insert;
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

        /*
         * Formata o campo de valores monetarios ao sair do campo
         */
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
        public void Alterar(GastosTO objGastosTO)
        {
            GastosBLL gastoBLL = new GastosBLL();
            this.gastosTO = gastoBLL.SelectScalar(objGastosTO.ID_GASTOS);

            if (gastosTO != null)
            {
                PreencherValoresTela(gastosTO);
                gastosTO.StatusBD = StatusTransacao.Update;
            }
            
            this.ShowDialog();
        }

        /*
         * Recebe o objeto com os dados completos dos gastos e apresenta na tela
         */
        private void PreencherValoresTela(GastosTO gastosTO)
        {

            carregarCombos();

            txtLocal.Text = gastosTO.LOCAL.Trim();
            txtValor.Text = gastosTO.VALOR.ToString();
            dtpData.Value = gastosTO.DATA;
            cbxTipoGasto.SelectedValue = gastosTO.ID_TIPO_GASTOS;            
        }

        /*
         * Desabilita todos os componentes de tela para o modo de delete
         */
        private void DesabilitarComponentes()
        {
            txtLocal.Enabled = false;
            txtValor.Enabled = false;
            dtpData.Enabled = false;
            cbxTipoGasto.Enabled = false;
        }

        public void Excluir(GastosTO objGastosTO)
        {
            GastosBLL gastoBLL = new GastosBLL();
            this.gastosTO = gastoBLL.SelectScalar(objGastosTO.ID_GASTOS);

            if (gastosTO != null)
            {
                PreencherValoresTela(gastosTO);
                gastosTO.StatusBD = StatusTransacao.Delete;
            }
            
            DesabilitarComponentes();
            this.ShowDialog();
        }
    }
}