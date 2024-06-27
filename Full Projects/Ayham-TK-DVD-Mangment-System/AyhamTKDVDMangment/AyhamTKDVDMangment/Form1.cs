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
using System.IO;

namespace AyhamTKDVDMangment
{
    public partial class Form1 : Form
    {
        // Var For Move
        int move;
        int movex;
        int movey;
        // Var For SQL Con
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        List<string> List = new List<string>();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movex = e.X;
            movey = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movex, MousePosition.Y - movey);
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\مشاريع C#\مشروع إدارة الدفيدي\AyhamTKDVDMangment\AyhamTKDVDMangment\DBDVD.mdf;Integrated Security=True");
            var sql = "SELECT Id as التسلسل,Title as 'اسم القرص' ,Cat as 'نوع القرص', Price as 'سعر القرص', Adedak as 'عدد الأقراص' FROM TB_DVDINFO";
            da = new SqlDataAdapter(sql,con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            FRM_ADDDVD Frmadd = new FRM_ADDDVD();
            Frmadd.btn_Add.ButtonText = "إضافة";
            Frmadd.state = 0;
            bunifuTransition1.ShowSync(Frmadd);
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            FRM_ADDDVD Frmadd = new FRM_ADDDVD();         
            Frmadd.btn_Add.ButtonText = "تعديل";
            Frmadd.state = Convert.ToInt16 (dataGridView1.CurrentRow.Cells[0].Value);
            bunifuTransition1.ShowSync(Frmadd);
            try
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\مشاريع C#\مشروع إدارة الدفيدي\AyhamTKDVDMangment\AyhamTKDVDMangment\DBDVD.mdf;Integrated Security=True");
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "SELECT Title,Cat,Price,Rent,Adedak,Note FROM TB_DVDINFO WHERE ID=@ID";
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt16 (dataGridView1.CurrentRow.Cells[0].Value));
                var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    List.Add(Convert.ToString(rd[0]));
                    List.Add(Convert.ToString(rd[1]));
                    List.Add(Convert.ToString(rd[2]));
                    List.Add(Convert.ToString(rd[3]));
                    List.Add(Convert.ToString(rd[4]));
                    List.Add(Convert.ToString(rd[5]));
                }
                Frmadd.txt_dvdtitle.Text = List[0];
                Frmadd.comboBox_cat.Text = List[1];
                Frmadd.txt_dvdprice.Text = List[2];
                Frmadd.txt_rate.Value = Convert.ToInt16 (List[3]);
                Frmadd.txt_dvdnum.Text = List[4];
                Frmadd.rtxt_note.Text = List[5];
                con.Close();

                // Read Image from DTB
                con.Open();
                cmd.CommandText = "SELECT Cover FROM TB_DVDINFO WHERE ID=@IDIMAGE";
                cmd.Parameters.AddWithValue("@IDIMAGE", dataGridView1.CurrentRow.Cells[0].Value);
                byte[] imag = (byte[])cmd.ExecuteScalar();
                MemoryStream ma = new MemoryStream();
                ma.Write(imag, 0, imag.Length);
                Frmadd.Cover.Image = Image.FromStream(ma);
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            finally
            {
                con.Close();
            }
            cmd.Parameters.Clear();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\مشاريع C#\مشروع إدارة الدفيدي\AyhamTKDVDMangment\AyhamTKDVDMangment\DBDVD.mdf;Integrated Security=True");
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "DELETE FROM TB_DVDINFO WHERE ID=@ID";
            cmd.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells[0].Value);
            cmd.ExecuteNonQuery();
            con.Close();
            FRM_DDelete frmd = new FRM_DDelete();
            frmd.Show();
            cmd.Parameters.Clear();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            FRM_DDetaelse Frmdd = new FRM_DDetaelse();
            bunifuTransition1.ShowSync(Frmdd);
            try
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\مشاريع C#\مشروع إدارة الدفيدي\AyhamTKDVDMangment\AyhamTKDVDMangment\DBDVD.mdf;Integrated Security=True");
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "SELECT Title,Cat,Price,Rent,Adedak,Note FROM TB_DVDINFO WHERE ID=@ID";
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    List.Add(Convert.ToString(rd[0]));
                    List.Add(Convert.ToString(rd[1]));
                    List.Add(Convert.ToString(rd[2]));
                    List.Add(Convert.ToString(rd[3]));
                    List.Add(Convert.ToString(rd[4]));
                    List.Add(Convert.ToString(rd[5]));
                }
                Frmdd.txt_dvdtitle.Text = List[0];
                Frmdd.comboBox_cat.Text = List[1];
                Frmdd.txt_dvdprice.Text = List[2];
                Frmdd.txt_rate.Value = Convert.ToInt16(List[3]);
                Frmdd.txt_dvdnum.Text = List[4];
                Frmdd.rtxt_note.Text = List[5];
                con.Close();

                // Read Image from DTB
                con.Open();
                cmd.CommandText = "SELECT Cover FROM TB_DVDINFO WHERE ID=@IDIMAGE";
                cmd.Parameters.AddWithValue("@IDIMAGE", dataGridView1.CurrentRow.Cells[0].Value);
                byte[] imag = (byte[])cmd.ExecuteScalar();
                MemoryStream ma = new MemoryStream();
                ma.Write(imag, 0, imag.Length);
                Frmdd.Cover.Image = Image.FromStream(ma);
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            finally
            {
                con.Close();
            }
            cmd.Parameters.Clear();
        }
    }
}
