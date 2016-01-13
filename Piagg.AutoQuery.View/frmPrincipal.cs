using Piagg.AutoQuery.Helpers;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            
        }

        private void menuSubSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuSubImportador_Click(object sender, EventArgs e)
        {
            frmImportador importer = new frmImportador();
            importer.Show();
            
        }

        private void inicializar()
        {
            preencherRodape();
        }

        private void preencherRodape()
        {
            var conn = ConfigHelper.getConStringMysql();
            statusLbNomeBanco.Text = conn.Database;
        }

        private void menuSubControle_Click(object sender, EventArgs e)
        {
            frmControle frmControle = new frmControle();
            frmControle.Show();
        }

        private void menuSubSobre_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            sobre.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            inicializar();
        }

        private void menuSubCadGasto_Click(object sender, EventArgs e)
        {
            frmCadGasto cadGasto = new frmCadGasto();
            cadGasto.Show();
        }


    }
}
