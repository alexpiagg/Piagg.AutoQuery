using Piagg.AutoQuery.BLL.BLL;
using Piagg.AutoQuery.Helpers;
using System;
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
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
        }

        /*
         * Define o lugar onde será salvo o backup ou encontrado o arquivo de restore
         */
        private void btnPathDir_Click(object sender, EventArgs e)
        {

            
            if (rdbBackup.Checked)
            {
                //Se for backup então seleciona o diretorio e automaticamente defino no nome do arquivo
                DialogResult result = fbdDiretorio.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtPathDir.Text = fbdDiretorio.SelectedPath + @"\backup_dados.sql";
                }
            }
            else if (rdbRestore.Checked)
            {
                //Se for restore então seleciona o arquivo a ser restarurado
                DialogResult result = ofdDiretorio.ShowDialog();

                if (result == DialogResult.OK) // Test result.
                {
                    txtPathDir.Text = ofdDiretorio.FileName;
                }
            }
        }

        private void brnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciarBkp_Click(object sender, EventArgs e)
        {
            DBUtilBLL utilBLL = new DBUtilBLL();

            try
            {
                if (rdbBackup.Checked)
                {
                    utilBLL.Backup(txtPathDir.Text.Trim());
                    MessageBox.Show("Backup Concluído!");
                }
                else if (rdbRestore.Checked)
                {
                    utilBLL.Restore(txtPathDir.Text.Trim());
                    MessageBox.Show("Restore Concluído!");
                }
                
            }
            catch (Exception ex)
            {
                LoggerUtil.ErrorLog(ex.Message);
                MessageBox.Show("Erro ao efetuar o backup/restore");

            }
        }

    }
    
}
