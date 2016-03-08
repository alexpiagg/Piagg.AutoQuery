using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Piagg.AutoQuery.Helpers
{
    public static class LoggerUtil
    {

        private static Logger logger = LogManager.GetCurrentClassLogger();
        
        public static void ErrorLog(string erro, Exception ex)
        {
            logger.Error(erro, ex);
        }

    }
}
