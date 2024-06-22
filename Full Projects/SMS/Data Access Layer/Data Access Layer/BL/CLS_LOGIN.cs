using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Data_Access_Layer.BL
{
    class CLS_LOGIN
    {
        DAL.DAL DAL = new Data_Access_Layer.DAL.DAL();
        public DataTable DT(string Usern, string Upass)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("UserName", Usern);
            pr[1] = new SqlParameter("UPassword", Upass);
            return DAL.Read("PR_LOGIN",pr);
        }
    }
}
