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
    public partial class frmCadTipoGasto : Form    
    {

        private TipoGastosTO tipoGastoTO = null;

        public frmCadTipoGasto()
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
            List<TipoGastosTO> tipoGastoListaTO = new List<TipoGastosTO>();

            if (tipoGastoTO != null)
            {
                PreencherValoresSalvar();
                tipoGastoListaTO.Add(tipoGastoTO);
            }

            try
            {
                TipoGastosBLL tipoGastosBLL = new TipoGastosBLL();
                tipoGastosBLL.Save(tipoGastoListaTO);

                VerificarProcessoDepoisSalvar();
            }
            catch (Exception ex)
            {
                LoggerUtil.ErrorLog(ex.Message, ex);
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
            if (tipoGastoTO.StatusBD == StatusTransacao.Insert)
            {
                DialogResult dialogResult = MessageBox.Show(@"Dados salvos com sucesso! " + Environment.NewLine + 
                                                             "Deseja incluir um novo tipo?", "Incluir", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    LimparTela();
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }
            }
            else if (tipoGastoTO.StatusBD == StatusTransacao.Update || tipoGastoTO.StatusBD == StatusTransacao.Delete)
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
            tipoGastoTO.EXCLUIDO = (chkExcluir.Checked ? (int)Excluido.Sim : (int)Excluido.Nao);
            tipoGastoTO.TIPO = txtDescricao.Text.Trim();
        }

        /*
         * Verifica se todos os campos foram preenchido corretamente
         */
        private bool ValidarCampos()
        {

            if (String.IsNullOrEmpty(txtDescricao.Text))
            {
                return false;
            }

            return true;
        }


        public void Incluir()
        {
            tipoGastoTO = new TipoGastosTO();
            tipoGastoTO.StatusBD = StatusTransacao.Insert;
            this.ShowDialog();
        }

        /*
         * Limpa a tela para uma nova inclusão
         */
        private void LimparTela()
        {
            txtDescricao.Text = "";
            tipoGastoTO = new TipoGastosTO();
        }

        /*
         * Alteração de gastos
         */
        public void Alterar(TipoGastosTO objTipoGastosTO)
        {
            TipoGastosBLL gastoBLL = new TipoGastosBLL();
            this.tipoGastoTO = gastoBLL.SelectScalar(objTipoGastosTO.ID_TIPO_GASTOS);

            if (tipoGastoTO != null)
            {
                PreencherValoresTela(tipoGastoTO);
                tipoGastoTO.StatusBD = StatusTransacao.Update;
            }
            
            this.ShowDialog();
        }

        /*
         * Recebe o objeto com os dados completos dos gastos e apresenta na tela
         */
        private void PreencherValoresTela(TipoGastosTO objTipoGastosTO)
        {
            txtDescricao.Text = objTipoGastosTO.TIPO.Trim();

            if (objTipoGastosTO.EXCLUIDO != null)
            {
                chkExcluir.Checked = (objTipoGastosTO.EXCLUIDO == 0 ? false : true);
            }
            
        }

        /*
         * Desabilita todos os componentes de tela para o modo de delete
         */
        private void DesabilitarComponentes()
        {
            txtDescricao.Enabled = false;
        }

        public void Excluir(TipoGastosTO objTipoGastoTO)
        {
            TipoGastosBLL gastoBLL = new TipoGastosBLL();
            this.tipoGastoTO = gastoBLL.SelectScalar(objTipoGastoTO.ID_TIPO_GASTOS);

            if (tipoGastoTO != null)
            {
                PreencherValoresTela(tipoGastoTO);
                tipoGastoTO.StatusBD = StatusTransacao.Delete;
            }

            DesabilitarComponentes();
            this.ShowDialog();
        }
    }
}