
namespace CalculeturByAyhamTk
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_sum = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_cu = new System.Windows.Forms.Button();
            this.btn_mult = new System.Windows.Forms.Button();
            this.lb_res = new System.Windows.Forms.Label();
            this.lb_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_num1
            // 
            this.txt_num1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_num1.Location = new System.Drawing.Point(12, 64);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(175, 33);
            this.txt_num1.TabIndex = 0;
            this.txt_num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_num2
            // 
            this.txt_num2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_num2.Location = new System.Drawing.Point(208, 64);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(175, 33);
            this.txt_num2.TabIndex = 1;
            this.txt_num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "أدخل رقمك الأول";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "أدخل رقمك الثاني";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(3, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Developer Ayham Takem";
            // 
            // btn_sum
            // 
            this.btn_sum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sum.Location = new System.Drawing.Point(26, 199);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(75, 35);
            this.btn_sum.TabIndex = 5;
            this.btn_sum.Text = "+";
            this.btn_sum.UseVisualStyleBackColor = true;
            this.btn_sum.Click += new System.EventHandler(this.btn_sum_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sub.Location = new System.Drawing.Point(115, 199);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(75, 35);
            this.btn_sub.TabIndex = 6;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_cu
            // 
            this.btn_cu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cu.Location = new System.Drawing.Point(204, 199);
            this.btn_cu.Name = "btn_cu";
            this.btn_cu.Size = new System.Drawing.Size(75, 35);
            this.btn_cu.TabIndex = 7;
            this.btn_cu.Text = "/";
            this.btn_cu.UseVisualStyleBackColor = true;
            this.btn_cu.Click += new System.EventHandler(this.btn_cu_Click);
            // 
            // btn_mult
            // 
            this.btn_mult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_mult.Location = new System.Drawing.Point(293, 199);
            this.btn_mult.Name = "btn_mult";
            this.btn_mult.Size = new System.Drawing.Size(75, 35);
            this.btn_mult.TabIndex = 8;
            this.btn_mult.Text = "X";
            this.btn_mult.UseVisualStyleBackColor = true;
            this.btn_mult.Click += new System.EventHandler(this.btn_mult_Click);
            // 
            // lb_res
            // 
            this.lb_res.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_res.AutoSize = true;
            this.lb_res.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_res.Location = new System.Drawing.Point(125, 292);
            this.lb_res.Name = "lb_res";
            this.lb_res.Size = new System.Drawing.Size(145, 42);
            this.lb_res.TabIndex = 9;
            this.lb_res.Text = ":النتيجة";
            // 
            // lb_result
            // 
            this.lb_result.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_result.AutoSize = true;
            this.lb_result.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_result.Location = new System.Drawing.Point(177, 345);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(40, 42);
            this.lb_result.TabIndex = 10;
            this.lb_result.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 468);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.lb_res);
            this.Controls.Add(this.btn_mult);
            this.Controls.Add(this.btn_cu);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_sum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.txt_num1);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.Text = "حاسبة أيهم البسيطة";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_cu;
        private System.Windows.Forms.Button btn_mult;
        private System.Windows.Forms.Label lb_res;
        private System.Windows.Forms.Label lb_result;
    }
}

