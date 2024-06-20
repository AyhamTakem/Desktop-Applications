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
    public partial class ItemsForm : Form
    {
        public ItemsForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ayham\Documents\Cafedb.mdf;Integrated Security=True;Connect Timeout=30");
        void Populate()
        {
            con.Open();
            string query = "Select * From Item_TB";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemsGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOrder useord = new UserOrder();
            useord.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ItemNametb.Text == "" || ItemNumtb.Text == "" || ItemPricetb.Text == "")
            {
                MessageBox.Show("Fill All The Data");
            }
            else
            {
                con.Open();
                string query = "insert into Item_TB values (" + ItemNumtb.Text + ",'" + ItemNametb.Text + "','" + Cattb.SelectedItem.ToString() + "',"+ ItemPricetb.Text +")";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Succcessfully Added");
                con.Close();
                Populate();
            }

        }

        private void ItemsForm_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void ItemsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {          
            ItemNumtb.Text = ItemsGV.SelectedRows[0].Cells[0].Value.ToString();
            ItemNametb.Text = ItemsGV.SelectedRows[0].Cells[1].Value.ToString();
            Cattb.SelectedItem = ItemsGV.SelectedRows[0].Cells[2].Value.ToString();
            ItemPricetb.Text = ItemsGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ItemNumtb.Text == "")
            {
                MessageBox.Show("Select The Item To Be Deleted");
            }
            else
            {
                con.Open();
                string query = "Delete From Item_TB where ItemNum = '" + ItemNumtb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Successfuly Deleted");
                con.Close();
                Populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ItemNumtb.Text == "" || ItemNametb.Text == "" || ItemPricetb.Text == "")
            {
                MessageBox.Show("Fill All The Fields");
            }
            else
            {
                con.Open();
                string query = "Update Item_TB Set ItemName = '" + ItemNametb.Text + "', ItemCat = '" + Cattb.SelectedItem.ToString() + "' where ItemPrice = " + ItemPricetb.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Successfuly Edit");
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm useform = new UsersForm();
            useform.Show();
        }
    }
}
