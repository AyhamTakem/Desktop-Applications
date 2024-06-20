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
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ayham\Documents\Cafedb.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        void Populate()
        {
            con.Open();
            string query = "Select * From Orders_TB";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            OrdersGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void ViewOrders_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void OrdersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("=====My Cafe Software=====" , new Font("Century", 23, FontStyle.Bold), Brushes.Red, new Point(180,10));
            e.Graphics.DrawString("=====Order Summary=====" , new Font("Century", 23, FontStyle.Bold), Brushes.Red, new Point(190,90));
            e.Graphics.DrawString("Number: "+OrdersGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century", 15, FontStyle.Regular), Brushes.Black, new Point(200, 150));
            e.Graphics.DrawString("Date: " + OrdersGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century", 15, FontStyle.Regular), Brushes.Black, new Point(200, 185));
            e.Graphics.DrawString("Seller: " + OrdersGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century", 15, FontStyle.Regular), Brushes.Black, new Point(200, 220));
            e.Graphics.DrawString("Amount in US_Dolar: " + OrdersGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century", 15, FontStyle.Regular), Brushes.Black, new Point(200, 255));
            e.Graphics.DrawString("=====Developer Ayham Takem=====", new Font("Century", 23, FontStyle.Bold), Brushes.Red, new Point(110, 300));
        }
    }
}
