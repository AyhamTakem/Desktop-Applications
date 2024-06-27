using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AyhamTKDVDMangment
{
    public partial class FRM_ADDCAT : Form
    {
        // var for sql con
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public FRM_ADDCAT()
        {
            InitializeComponent();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txt_catname.Text != "")
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\مشاريع C#\مشروع إدارة الدفيدي\AyhamTKDVDMangment\AyhamTKDVDMangment\DBDVD.mdf;Integrated Security=True");
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO TB_CAT (CAT) VALUES (@CAT)";
                cmd.Parameters.AddWithValue("@CAT", txt_catname.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                FRM_DADD frad = new FRM_DADD();
                frad.Show();
                this.Close();
            }
            else
            {
                FRM_DEror frer = new FRM_DEror();
                frer.Show();
            }      
        }
    }
}
