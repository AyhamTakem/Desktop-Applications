using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace AyhamTKDVDMangment
{
    public partial class FRM_ADDDVD : Form
    {
        // var for consql
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        List<string> List = new List<string>();
        public int state;

        public FRM_ADDDVD()
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRM_ADDCAT frmadc = new FRM_ADDCAT();
            bunifuTransition1.ShowSync(frmadc);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FRM_ADDDVD_Load(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\مشاريع C#\مشروع إدارة الدفيدي\AyhamTKDVDMangment\AyhamTKDVDMangment\DBDVD.mdf;Integrated Security=True");
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "SELECT CAT FROM TB_CAT";
                var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    List.Add(Convert.ToString(rd[0]));
                }
                int i = 0;
                while (i < List.LongCount())
                {
                    comboBox_cat.Items.Add(List[i]);
                    i = i + 1;
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void FRM_ADDDVD_Activated(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            

            if(txt_dvdtitle.Text == "" || txt_dvdnum.Text == "" || txt_dvdprice.Text == "")
            {
                FRM_DEror frer = new FRM_DEror();
                frer.Show();
            }
            else
            {
                if(state == 0)
                {
                    // Insert Data

                    // for convert image to bin
                    MemoryStream ma = new MemoryStream();
                    Cover.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    var cover = ma.ToArray();

                    // sql comand
                    con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\مشاريع C#\مشروع إدارة الدفيدي\AyhamTKDVDMangment\AyhamTKDVDMangment\DBDVD.mdf;Integrated Security=True");
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO TB_DVDINFO (Title,Cat,Price,Rent,Adedak,Note,Cover) VALUES (@Title,@Cat,@Price,@Rent,@Adedak,@Note,@Cover)";
                    cmd.Parameters.AddWithValue("@Title", txt_dvdtitle.Text);
                    cmd.Parameters.AddWithValue("@Cat", comboBox_cat.Text);
                    cmd.Parameters.AddWithValue("@Price", txt_dvdprice.Text);
                    cmd.Parameters.AddWithValue("@Rent", txt_rate.Text);
                    cmd.Parameters.AddWithValue("@Adedak", txt_dvdnum.Text);
                    cmd.Parameters.AddWithValue("@Note", rtxt_note.Text);
                    cmd.Parameters.AddWithValue("@Cover", cover);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    FRM_DADD frad = new FRM_DADD();
                    frad.Show();
                    this.Close();
                }
                else
                {
                    // Edite Data

                    // for convert image to bin
                    MemoryStream ma = new MemoryStream();
                    Cover.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    var cover = ma.ToArray();

                    // sql comand
                    con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\مشاريع C#\مشروع إدارة الدفيدي\AyhamTKDVDMangment\AyhamTKDVDMangment\DBDVD.mdf;Integrated Security=True");
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "UPDATE TB_DVDINFO SET Title=@Title,Cat=@Cat,Price=@Price,Rent=@Rent,Adedak=@Adedak,Note=@Note,Cover=@Cover WHERE ID=@ID";
                    cmd.Parameters.AddWithValue("@Title", txt_dvdtitle.Text);
                    cmd.Parameters.AddWithValue("@Cat", comboBox_cat.Text);
                    cmd.Parameters.AddWithValue("@Price", txt_dvdprice.Text);
                    cmd.Parameters.AddWithValue("@Rent", txt_rate.Text);
                    cmd.Parameters.AddWithValue("@Adedak", txt_dvdnum.Text);
                    cmd.Parameters.AddWithValue("@Note", rtxt_note.Text);
                    cmd.Parameters.AddWithValue("@Cover", cover);
                    cmd.Parameters.AddWithValue("@ID", state);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    FRM_DEdit frad = new FRM_DEdit();
                    frad.Show();
                    this.Close();
                }
               
            }
            cmd.Parameters.Clear();
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var dia = new OpenFileDialog();
            var result = dia.ShowDialog();
            if(result == DialogResult.OK)
            {
                Cover.Image = Image.FromFile(dia.FileName);
            }
        }
    }
}
