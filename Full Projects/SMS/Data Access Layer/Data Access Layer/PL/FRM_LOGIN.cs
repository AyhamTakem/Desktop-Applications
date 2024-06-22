using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Data_Access_Layer
{
    public partial class FRM_LOGIN : Form
    {
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BL.CLS_LOGIN Login = new BL.CLS_LOGIN();
            DataTable dt = new DataTable();
            dt = Login.DT(txt_user.Text, txt_passw.Text);
            if (dt.Rows.Count > 0)
            {
                PL.FRM_MAIN frm_main = new PL.FRM_MAIN();
                frm_main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error in Login");
            }
        }
    }
}
