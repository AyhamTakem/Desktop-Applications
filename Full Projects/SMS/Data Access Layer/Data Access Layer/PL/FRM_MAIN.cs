using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Access_Layer.PL
{
    public partial class FRM_MAIN : Form
    {
        public FRM_MAIN()
        {
            InitializeComponent();
        }

        private void FRM_MAIN_Activated(object sender, EventArgs e)
        {
            try
            {
                BL.CLS_DBPRO dBPRO = new BL.CLS_DBPRO();
                DataTable dt = new DataTable();
                dt = dBPRO.LoadDB();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "التسلسل";
                dataGridView1.Columns[1].HeaderText = "الاسم الأول";
                dataGridView1.Columns[2].HeaderText = "الاسم الأخير";
                dataGridView1.Columns[3].HeaderText = "الصف";
                dataGridView1.Columns[4].HeaderText = "الإيميل";
                dataGridView1.Columns[5].HeaderText = "رقم الموبايل";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void FRM_MAIN_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.FRM_ADDandEDIT frmadd = new FRM_ADDandEDIT();
            frmadd.id = 0;
            frmadd.btn_1add.Text = "Add";
            frmadd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BL.CLS_DBPRO dBPRO = new BL.CLS_DBPRO();
            dBPRO.Delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            try
            {
                DataTable dt = new DataTable();
                dt = dBPRO.LoadDB();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "التسلسل";
                dataGridView1.Columns[1].HeaderText = "الاسم الأول";
                dataGridView1.Columns[2].HeaderText = "الاسم الأخير";
                dataGridView1.Columns[3].HeaderText = "الصف";
                dataGridView1.Columns[4].HeaderText = "الإيميل";
                dataGridView1.Columns[5].HeaderText = "رقم الموبايل";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PL.FRM_ADDandEDIT frm_add = new FRM_ADDandEDIT();
            frm_add.id = (int)Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            frm_add.txt_fname.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            frm_add.txt_lname.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            frm_add.txt_class.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            frm_add.txt_email.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            frm_add.txt_phonenum.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            frm_add.btn_1add.Text = "Edit";
            frm_add.Show();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            BL.CLS_DBPRO dBPRO = new BL.CLS_DBPRO();
            DataTable dt = new DataTable();
            dt = dBPRO.Search(txt_search.Text);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
