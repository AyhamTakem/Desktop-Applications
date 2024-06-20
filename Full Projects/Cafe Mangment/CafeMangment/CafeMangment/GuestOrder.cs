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
    public partial class GuestOrder : Form
    {
        public GuestOrder()
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
        void fillterbycat()
        {
            con.Open();
            string query = "Select * From Item_TB Where ItemCat = '" + Categorycb.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemsGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

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
            Form1 Login = new Form1();
            Login.Show();
        }

        private void GuestOrder_Load(object sender, EventArgs e)
        {
            Populate();
            table.Columns.Add("Number", typeof(int));
            table.Columns.Add("ItemName", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("UnitPrice", typeof(int));
            table.Columns.Add("theTotal", typeof(int));
            OrderGV.DataSource = table;
            Datetb.Text = DateTime.Today.Day.ToString()+"/"+ DateTime.Today.Month.ToString()+"/"+ DateTime.Today.Year.ToString();
        }
        int num = 0;
        int price, total;
        string item, Cat;

        DataTable table = new DataTable();
        int flag = 0;
        int sum = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Quantb.Text == "")
            {
                MessageBox.Show("What is The Quantity of Item?");
            }
            else if (flag == 0)
            {
                MessageBox.Show("Select The Product to be Orderred");
            }
            else
            {
                num = num + 1;
                total = price * Convert.ToInt32(Quantb.Text);
                table.Rows.Add(num, item, Cat, price, total);
                OrderGV.DataSource = table;
                flag = 0;
            }
            sum = sum + total;
            lblamnt.Text = "" + sum;
        }

        private void ItemsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            item = ItemsGV.SelectedRows[0].Cells[1].Value.ToString();
            Cat = ItemsGV.SelectedRows[0].Cells[2].Value.ToString();
            price = Convert.ToInt32(ItemsGV.SelectedRows[0].Cells[3].Value.ToString());
            flag = 1;
        }

        private void Datetb_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into Orders_TB values (" + Order_Numtb.Text + ",'" + Datetb.Text + "','" + Guesttb.Text + "',"+lblamnt.Text+")";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Order Succcessfully Created");
            con.Close();
            
        }

        private void Guesttb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Categorycb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fillterbycat();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Populate();
        }
    }
}
