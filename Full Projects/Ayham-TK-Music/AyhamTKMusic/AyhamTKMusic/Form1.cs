using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AyhamTKMusic
{
    public partial class FRM_Main : Form
    {
        public FRM_Main()
        {
            InitializeComponent();
            Track_Volume.Value = 50;
            lb_volume.Text = "50%";
        }
        string[] paths, files;

        private void Trak_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player.URL = paths[Trak_List.SelectedIndex];
            Player.Ctlcontrols.play();
            try
            {
                var file = TagLib.File.Create(paths[Trak_List.SelectedIndex]);
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                Pic_Art.Image = Image.FromStream(new MemoryStream(bin));
            }
            catch { }
           
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
            P_bar.Value = 0;
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.play();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (Trak_List.SelectedIndex<Trak_List.Items.Count-1)
            {
                Trak_List.SelectedIndex = Trak_List.SelectedIndex + 1;
            }
        }

        private void btn_Preview_Click(object sender, EventArgs e)
        {
            if (Trak_List.SelectedIndex >0)
            {
                Trak_List.SelectedIndex = Trak_List.SelectedIndex - 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                P_bar.Maximum_Value = (int)Player.Ctlcontrols.currentItem.duration;
                P_bar.Value = (int)Player.Ctlcontrols.currentPosition;
                
            }
            try
            {
                lb_track_start.Text = Player.Ctlcontrols.currentPositionString;
                lb_track_end.Text = Player.Ctlcontrols.currentItem.durationString.ToString();
            }
            catch
            {
            }
            
        }

        private void Track_Volume_Scroll(object sender, EventArgs e)
        {
            Player.settings.volume = Track_Volume.Value;
            lb_volume.Text = Track_Volume.Value.ToString() + "%";
        }

        private void P_bar_MouseDown(object sender, MouseEventArgs e)
        {
            Player.Ctlcontrols.currentPosition = Player.currentMedia.duration * e.X / P_bar.Width;
        }

        private void P_bar_progressChanged(object sender, EventArgs e)
        {
           
        }

        private void P_bar_MouseMove(object sender, MouseEventArgs e)
        {
          
        }

        private void P_bar_MouseUp(object sender, MouseEventArgs e)
        {
            Player.Ctlcontrols.currentPosition = Player.currentMedia.duration * e.X / P_bar.Width;
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;
                for (int x = 0; x < files.Length; x++)
                {
                    Trak_List.Items.Add(files[x]);
                }
            }
        }
    }
}
