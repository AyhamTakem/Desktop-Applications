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

namespace CafeMangment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ayham\Documents\Cafedb.mdf;Integrated Security=True;Connect Timeout=30");
        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestOrder gust = new GuestOrder();
            gust.Show();
        }
        public static string User;
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            User = Username_fild.Text;
            if(Username_fild.Text == "" || Password_fild.Text == "")
            {
                MessageBox.Show("Enter a Username or Password Please");
            }
            else
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Users_TB where UserName = '"+Username_fild.Text+"' and Upassword = '"+ Password_fild.Text+"'",con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if(dt.Rows[0][0].ToString() == "1")
                {
                    UserOrder uord = new UserOrder();
                    uord.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Worng Username or Password");
                }
                con.Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
