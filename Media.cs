using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConverterProject
{
    public partial class Media : Form
    {
        string videoPath, videoName, musicPath, musicName;
        public Media()
        {
            InitializeComponent();
        }

        private void btnOpenVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog()
            {
                Multiselect = false,
                Filter = "MP4 file|*.mp4"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                videoPath = openFileDialog.FileName;
                videoName = openFileDialog.SafeFileName;
            }
            txtPathVideo.Text = videoPath;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderbrowserDialog = new FolderBrowserDialog();
            if (folderbrowserDialog.ShowDialog() == DialogResult.OK)
            {
                musicPath = folderbrowserDialog.SelectedPath;
                musicName = videoName.Substring(0, videoName.Length - 4);
                musicPath += ("\\" + musicName + ".mp3");
            }
            txtSaveTo.Text = musicPath;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            var convert = new NReco.VideoConverter.FFMpegConverter();
            string videoPath = txtPathVideo.Text.Trim();
            string musicPath = txtSaveTo.Text.Trim();
            convert.ConvertMedia(videoPath, musicPath, "mp3");
            MessageBox.Show("Convert Successful!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Area frmArea = new Area();
            frmArea.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Distance frmDis = new Distance();
            frmDis.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Photo frmimg = new Photo();
            frmimg.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Pressure frmpressure = new Pressure();
            frmpressure.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Speed frmspeed = new Speed();
            frmspeed.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Temperature frmtemp = new Temperature();
            frmtemp.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Volume frmvolume = new Volume();
            frmvolume.Show();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            Mass frmmass = new Mass();
            frmmass.Show();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
        }

    }
}
