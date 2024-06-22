
namespace Data_Access_Layer.PL
{
    partial class FRM_ADDandEDIT
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.btn_1add = new System.Windows.Forms.Button();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_class = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_phonenum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // txt_fname
            // 
            this.txt_fname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_fname.Location = new System.Drawing.Point(243, 74);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(200, 30);
            this.txt_fname.TabIndex = 1;
            this.txt_fname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_fname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_1add
            // 
            this.btn_1add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_1add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_1add.Location = new System.Drawing.Point(145, 373);
            this.btn_1add.Name = "btn_1add";
            this.btn_1add.Size = new System.Drawing.Size(253, 38);
            this.btn_1add.TabIndex = 2;
            this.btn_1add.Text = "Add";
            this.btn_1add.UseVisualStyleBackColor = false;
            this.btn_1add.Click += new System.EventHandler(this.btn_1add_Click);
            // 
            // txt_lname
            // 
            this.txt_lname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_lname.Location = new System.Drawing.Point(243, 127);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(200, 30);
            this.txt_lname.TabIndex = 4;
            this.txt_lname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name:";
            // 
            // txt_class
            // 
            this.txt_class.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_class.Location = new System.Drawing.Point(243, 180);
            this.txt_class.Name = "txt_class";
            this.txt_class.Size = new System.Drawing.Size(200, 30);
            this.txt_class.TabIndex = 6;
            this.txt_class.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Class:";
            // 
            // txt_email
            // 
            this.txt_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_email.Location = new System.Drawing.Point(243, 233);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(200, 30);
            this.txt_email.TabIndex = 8;
            this.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email:";
            // 
            // txt_phonenum
            // 
            this.txt_phonenum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_phonenum.Location = new System.Drawing.Point(243, 287);
            this.txt_phonenum.Name = "txt_phonenum";
            this.txt_phonenum.Size = new System.Drawing.Size(200, 30);
            this.txt_phonenum.TabIndex = 10;
            this.txt_phonenum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mobail Number:";
            // 
            // FRM_ADDandEDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 464);
            this.Controls.Add(this.txt_phonenum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_class);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_1add);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FRM_ADDandEDIT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD AND EDIT STUDENTS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btn_1add;
        public System.Windows.Forms.TextBox txt_fname;
        public System.Windows.Forms.TextBox txt_lname;
        public System.Windows.Forms.TextBox txt_class;
        public System.Windows.Forms.TextBox txt_email;
        public System.Windows.Forms.TextBox txt_phonenum;
    }
}