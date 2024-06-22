using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Layer.BL
{
    class CLS_DBPRO
    {
        DAL.DAL DAL = new Data_Access_Layer.DAL.DAL();
        // Load Data From Databease
        public DataTable LoadDB()
        {
            SqlParameter[] pr = null;
            return DAL.Read("PR_Loaddatas", pr);
        }
        // Search
        public DataTable Search(string Search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("Search", Search);
            return DAL.Read("PR_Search", pr);
        }
        // Insert Deta
        public void ADD(string fname,string lname,string C_Class,string E_Email,int phone)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("FName", fname);
            pr[1] = new SqlParameter("LName", lname);
            pr[2] = new SqlParameter("Class", C_Class);
            pr[3] = new SqlParameter("Email", E_Email);
            pr[4] = new SqlParameter("Phone", phone);
            DAL.Open();
            DAL.Excute("PR_ADD", pr);
            DAL.Close();
        }
        // Delete Data
        public void Delete(int id)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ID",id);
            DAL.Open();
            DAL.Excute("PR_DELETE", pr);
            DAL.Close();
        }
        // Edit Deta
        public void Update(string fname, string lname, string C_Class, string E_Email, int phone,int id)
        {
            SqlParameter[] pr = new SqlParameter[6];
            pr[0] = new SqlParameter("FName", fname);
            pr[1] = new SqlParameter("LName", lname);
            pr[2] = new SqlParameter("Class", C_Class);
            pr[3] = new SqlParameter("Email", E_Email);
            pr[4] = new SqlParameter("Phone", phone);
            pr[5] = new SqlParameter("ID", id);
            DAL.Open();
            DAL.Excute("PR_Edit", pr);
            DAL.Close();
        }
    }
}
