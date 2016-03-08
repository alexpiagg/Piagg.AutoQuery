using Piagg.AutoQuery.DAL;
using Piagg.AutoQuery.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piagg.AutoQuery.BLL.BLL
{
    public class DBUtilBLL
    {

        /*
         * Efetua backup das informações de uma base de dados MySql
         */
        public void Backup(string pathComplete)
        {
            try
            {
                DBUtil.Backup(pathComplete);
            }
            catch (Exception ex)
            {
                LoggerUtil.ErrorLog(ex.Message);
            }
        }

        /*
         * Restaura as informações de uma base de dados MySql
         */
        public void Restore(string pathComplete)
        {
            try
            {
                DBUtil.Restore(pathComplete);
            }
            catch (Exception ex)
            {
                LoggerUtil.ErrorLog(ex.Message);
            }
        }
    }
}
