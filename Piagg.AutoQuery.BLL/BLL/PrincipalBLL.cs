﻿using Piagg.AutoQuery.DAL.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piagg.AutoQuery.BLL.BLL
{
    public class PrincipalBLL
    {

        public void TestarConexaoBD()
        {
            try
            {
                EFUtil.TestarConexaoBD();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
