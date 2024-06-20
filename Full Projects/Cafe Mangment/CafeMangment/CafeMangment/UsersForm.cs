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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ayham\Documents\Cafedb.mdf;Integrated Security=True;Connect Timeout=30");
        void Populate()
        {
            con.Open();
            string query = "Select * From Users_TB";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UserssGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserOrder usord = new UserOrder();
            usord.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ItemsForm itemf = new ItemsForm();
            itemf.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into Users_TB values ('" + Usernametb.Text + "','" + Uphonetb.Text + "','" + Upasstb.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Succcessfully Created");
            con.Close();
            Populate();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void UserssGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Usernametb.Text = UserssGV.SelectedRows[0].Cells[0].Value.ToString();
            Uphonetb.Text = UserssGV.SelectedRows[0].Cells[1].Value.ToString();
            Upasstb.Text = UserssGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(Uphonetb.Text == "")
            {
                MessageBox.Show("Select The User To Be Deleted");
            }
            else
            {
                con.Open();
                string query = "Delete From Users_TB where Uphone = '" + Uphonetb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfuly Deleted");
                con.Close();
                Populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Uphonetb.Text == "" || Upasstb.Text == "" || Usernametb.Text == "")
            {
                MessageBox.Show("Fill All The Fields");
            }
            else
            {
                con.Open();
                string query = "Update Users_TB Set UserName = '"+ Usernametb.Text +"', Upassword = '" + Upasstb.Text + "' where Uphone = '"+ Uphonetb.Text +"'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfuly Edit");
                con.Close();
                Populate();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
