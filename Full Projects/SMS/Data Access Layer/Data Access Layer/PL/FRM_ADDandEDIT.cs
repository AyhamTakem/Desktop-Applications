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
    public partial class FRM_ADDandEDIT : Form
    {
        public int id;
        public FRM_ADDandEDIT()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_1add_Click(object sender, EventArgs e)
        {
            if(id == 0)
                // Add
            {
                try
                {
                    BL.CLS_DBPRO _DBPRO = new BL.CLS_DBPRO();
                    _DBPRO.ADD(txt_fname.Text, txt_lname.Text, txt_class.Text, txt_email.Text, Convert.ToInt32(txt_phonenum.Text));
                    MessageBox.Show("Add Seccssfully");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            // Edit
            {
                try
                {
                    BL.CLS_DBPRO _DBPRO = new BL.CLS_DBPRO();
                    _DBPRO.Update(txt_fname.Text, txt_lname.Text, txt_class.Text, txt_email.Text, Convert.ToInt32(txt_phonenum.Text),id);
                    MessageBox.Show("Edit Seccssfully");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
