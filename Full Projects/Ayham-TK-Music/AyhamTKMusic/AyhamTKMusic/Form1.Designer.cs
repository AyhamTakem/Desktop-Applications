
namespace AyhamTKMusic
{
    partial class FRM_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Main));
            this.btn_Preview = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Open = new System.Windows.Forms.Button();
            this.P_bar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.Trak_List = new System.Windows.Forms.ListBox();
            this.Pic_Art = new System.Windows.Forms.PictureBox();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.Track_Volume = new System.Windows.Forms.TrackBar();
            this.Txt_Volume = new System.Windows.Forms.Label();
            this.lb_volume = new System.Windows.Forms.Label();
            this.lb_track_start = new System.Windows.Forms.Label();
            this.lb_track_end = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Art)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track_Volume)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Preview
            // 
            this.btn_Preview.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Preview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Preview.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Preview.Location = new System.Drawing.Point(5, 291);
            this.btn_Preview.Name = "btn_Preview";
            this.btn_Preview.Size = new System.Drawing.Size(92, 26);
            this.btn_Preview.TabIndex = 0;
            this.btn_Preview.Text = "Preview";
            this.btn_Preview.UseVisualStyleBackColor = true;
            this.btn_Preview.Click += new System.EventHandler(this.btn_Preview_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Next.Location = new System.Drawing.Point(103, 291);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(92, 26);
            this.btn_Next.TabIndex = 1;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_play
            // 
            this.btn_play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_play.Location = new System.Drawing.Point(201, 291);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(92, 26);
            this.btn_play.TabIndex = 2;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pause.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Pause.Location = new System.Drawing.Point(299, 291);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(92, 26);
            this.btn_Pause.TabIndex = 3;
            this.btn_Pause.Text = "Pause";
            this.btn_Pause.UseVisualStyleBackColor = true;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stop.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Stop.Location = new System.Drawing.Point(397, 291);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(92, 26);
            this.btn_Stop.TabIndex = 4;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Open
            // 
            this.btn_Open.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Open.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Open.Location = new System.Drawing.Point(495, 291);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(134, 26);
            this.btn_Open.TabIndex = 5;
            this.btn_Open.Text = "Open";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // P_bar
            // 
            this.P_bar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.P_bar.BorderRadius = 5;
            this.P_bar.Location = new System.Drawing.Point(5, 265);
            this.P_bar.MaximumValue = 100;
            this.P_bar.Name = "P_bar";
            this.P_bar.ProgressColor = System.Drawing.Color.DarkRed;
            this.P_bar.Size = new System.Drawing.Size(624, 15);
            this.P_bar.TabIndex = 6;
            this.P_bar.Value = 0;
            this.P_bar.progressChanged += new System.EventHandler(this.P_bar_progressChanged);
            this.P_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.P_bar_MouseDown);
            this.P_bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.P_bar_MouseMove);
            this.P_bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P_bar_MouseUp);
            // 
            // Trak_List
            // 
            this.Trak_List.BackColor = System.Drawing.Color.DimGray;
            this.Trak_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Trak_List.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trak_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Trak_List.FormattingEnabled = true;
            this.Trak_List.ItemHeight = 14;
            this.Trak_List.Location = new System.Drawing.Point(219, 95);
            this.Trak_List.Name = "Trak_List";
            this.Trak_List.Size = new System.Drawing.Size(363, 154);
            this.Trak_List.TabIndex = 7;
            this.Trak_List.SelectedIndexChanged += new System.EventHandler(this.Trak_List_SelectedIndexChanged);
            // 
            // Pic_Art
            // 
            this.Pic_Art.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Art.Image")));
            this.Pic_Art.Location = new System.Drawing.Point(5, 8);
            this.Pic_Art.Name = "Pic_Art";
            this.Pic_Art.Size = new System.Drawing.Size(208, 158);
            this.Pic_Art.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Art.TabIndex = 8;
            this.Pic_Art.TabStop = false;
            // 
            // Player
            // 
            this.Player.Dock = System.Windows.Forms.DockStyle.Top;
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(0, 0);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(634, 79);
            this.Player.TabIndex = 9;
            // 
            // Track_Volume
            // 
            this.Track_Volume.BackColor = System.Drawing.Color.DarkRed;
            this.Track_Volume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Track_Volume.Location = new System.Drawing.Point(586, 116);
            this.Track_Volume.Maximum = 100;
            this.Track_Volume.Name = "Track_Volume";
            this.Track_Volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Track_Volume.Size = new System.Drawing.Size(45, 119);
            this.Track_Volume.TabIndex = 10;
            this.Track_Volume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Track_Volume.Scroll += new System.EventHandler(this.Track_Volume_Scroll);
            // 
            // Txt_Volume
            // 
            this.Txt_Volume.AutoSize = true;
            this.Txt_Volume.BackColor = System.Drawing.Color.DarkRed;
            this.Txt_Volume.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Volume.ForeColor = System.Drawing.Color.White;
            this.Txt_Volume.Location = new System.Drawing.Point(585, 240);
            this.Txt_Volume.Name = "Txt_Volume";
            this.Txt_Volume.Size = new System.Drawing.Size(49, 13);
            this.Txt_Volume.TabIndex = 11;
            this.Txt_Volume.Text = "Volume";
            // 
            // lb_volume
            // 
            this.lb_volume.AutoSize = true;
            this.lb_volume.BackColor = System.Drawing.Color.DarkRed;
            this.lb_volume.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_volume.ForeColor = System.Drawing.Color.White;
            this.lb_volume.Location = new System.Drawing.Point(585, 97);
            this.lb_volume.Name = "lb_volume";
            this.lb_volume.Size = new System.Drawing.Size(34, 13);
            this.lb_volume.TabIndex = 12;
            this.lb_volume.Text = "50%";
            // 
            // lb_track_start
            // 
            this.lb_track_start.AutoSize = true;
            this.lb_track_start.BackColor = System.Drawing.Color.Transparent;
            this.lb_track_start.Font = new System.Drawing.Font("DecoType Naskh", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_track_start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lb_track_start.Location = new System.Drawing.Point(-1, 0);
            this.lb_track_start.Name = "lb_track_start";
            this.lb_track_start.Size = new System.Drawing.Size(95, 68);
            this.lb_track_start.TabIndex = 13;
            this.lb_track_start.Text = "00:00";
            // 
            // lb_track_end
            // 
            this.lb_track_end.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb_track_end.AutoSize = true;
            this.lb_track_end.BackColor = System.Drawing.Color.Black;
            this.lb_track_end.Font = new System.Drawing.Font("DecoType Naskh", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_track_end.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lb_track_end.Location = new System.Drawing.Point(545, 0);
            this.lb_track_end.Name = "lb_track_end";
            this.lb_track_end.Size = new System.Drawing.Size(95, 68);
            this.lb_track_end.TabIndex = 14;
            this.lb_track_end.Text = "00:00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.Pic_Art);
            this.panel1.Location = new System.Drawing.Point(0, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 174);
            this.panel1.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(634, 341);
            this.Controls.Add(this.lb_track_end);
            this.Controls.Add(this.lb_track_start);
            this.Controls.Add(this.lb_volume);
            this.Controls.Add(this.Txt_Volume);
            this.Controls.Add(this.Track_Volume);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Trak_List);
            this.Controls.Add(this.P_bar);
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Pause);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Preview);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FRM_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayham Takem Music  Player";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Art)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track_Volume)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Preview;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Open;
        private Bunifu.Framework.UI.BunifuProgressBar P_bar;
        private System.Windows.Forms.ListBox Trak_List;
        private System.Windows.Forms.PictureBox Pic_Art;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.TrackBar Track_Volume;
        private System.Windows.Forms.Label Txt_Volume;
        private System.Windows.Forms.Label lb_volume;
        private System.Windows.Forms.Label lb_track_start;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lb_track_end;
    }
}

