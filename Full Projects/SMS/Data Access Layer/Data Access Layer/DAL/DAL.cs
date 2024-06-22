using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Data_Access_Layer.DAL
{
    class DAL
    {
        SqlConnection Con;
        public DAL()
        {
            Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\مشاريع C#\مشروع نهاية دورة C# tku\Data Access Layer\Data Access Layer\DB_Student.mdf;Integrated Security=True");
        }
        // Open Connection
        public void Open()
        {
            if(Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }
        // Close Connection
        public void Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }
        // Method to Read Data
        public DataTable Read(String Store, SqlParameter[] pr)
        {
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.CommandText = Store;
            if (pr != null)
            {
                Cmd.Parameters.AddRange(pr);
            }
            SqlDataAdapter Da = new SqlDataAdapter(Cmd);
            DataTable dt = new DataTable();
            Da.Fill(dt);
            return dt;
        }
        // Method for Insert , Delete, Edit
        public void Excute(String Store, SqlParameter[] pr)
        {
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.CommandText = Store;
            if (pr != null)
            {
                Cmd.Parameters.AddRange(pr);
            }
            Cmd.ExecuteNonQuery();
        }
    }
}
