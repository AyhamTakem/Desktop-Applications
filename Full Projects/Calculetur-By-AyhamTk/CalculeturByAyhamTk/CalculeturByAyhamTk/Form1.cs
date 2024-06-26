using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculeturByAyhamTk
{
    public partial class Form1 : Form
    {
        double n1;
        double n2;
        double res;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble (txt_num1.Text);
            n2 = Convert.ToDouble(txt_num2.Text);
            res = n1 + n2;
            lb_result.Text = Convert.ToString (res);
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txt_num1.Text);
            n2 = Convert.ToDouble(txt_num2.Text);
            res = n1 - n2;
            lb_result.Text = Convert.ToString(res);
        }

        private void btn_cu_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txt_num1.Text);
            n2 = Convert.ToDouble(txt_num2.Text);
            res = n1 / n2;
            lb_result.Text = Convert.ToString(res);
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txt_num1.Text);
            n2 = Convert.ToDouble(txt_num2.Text);
            res = n1 * n2;
            lb_result.Text = Convert.ToString(res);
        }
    }
}
