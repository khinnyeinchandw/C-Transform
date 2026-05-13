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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnDistance_MouseEnter(object sender, EventArgs e)
        {
            btnDistanceB.Visible = true;
        }

        private void btnDistanceB_MouseLeave(object sender, EventArgs e)
        {
            btnDistanceB.Visible = false;
        }

        private void btnSpeed_MouseEnter(object sender, EventArgs e)
        {
            btnSpeedB.Visible = true;
        }

        private void btnSpeedB_MouseLeave(object sender, EventArgs e)
        {
            btnSpeedB.Visible = false;
        }

        private void btnVolume_MouseEnter(object sender, EventArgs e)
        {
            btnVolumeB.Visible = true;
        }

        private void btnVolumeB_MouseLeave(object sender, EventArgs e)
        {
            btnVolumeB.Visible = false;
        }

        private void btntemp_MouseEnter(object sender, EventArgs e)
        {
            btnTempB.Visible = true;
        }

        private void btnTempB_MouseLeave(object sender, EventArgs e)
        {
            btnTempB.Visible = false;
        }

        private void btnArea_MouseEnter(object sender, EventArgs e)
        {
            btnAreaB.Visible = true;
        }

        private void btnAreaB_MouseLeave(object sender, EventArgs e)
        {
            btnAreaB.Visible = false;
        }

        private void btnPressure_MouseEnter(object sender, EventArgs e)
        {
            btnPressureB.Visible = true;
        }

        private void btnPressureB_MouseLeave(object sender, EventArgs e)
        {
            btnPressureB.Visible = false;
        }

        private void btnmass_MouseEnter(object sender, EventArgs e)
        {
            btnMassB.Visible = true;
        }

        private void btnMassB_MouseLeave(object sender, EventArgs e)
        {
            btnMassB.Visible = false;
        }

        private void btnimg_MouseEnter(object sender, EventArgs e)
        {
            btnImageB.Visible = true;
        }

        private void btnImageB_MouseLeave(object sender, EventArgs e)
        {
            btnImageB.Visible = false;
        }

        private void btnmedia_MouseEnter(object sender, EventArgs e)
        {
            btnMediaB.Visible = true;
        }

        private void btnMediaB_MouseLeave(object sender, EventArgs e)
        {
            btnMediaB.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDistanceB_Click(object sender, EventArgs e)
        {
            Distance frmDis = new Distance();
            frmDis.Show();
        }

        private void btnAreaB_Click(object sender, EventArgs e)
        {
            Area frmArea = new Area();
            frmArea.Show();
        }

        private void btnMediaB_Click(object sender, EventArgs e)
        {
            Media frmMedia = new Media();
            frmMedia.Show();
        }

        private void btnImageB_Click(object sender, EventArgs e)
        {
            Photo frmimg = new Photo();
            frmimg.Show();
        }

        private void btnPressureB_Click(object sender, EventArgs e)
        {
            Pressure frmpressure = new Pressure();
            frmpressure.Show();
        }

        private void btnSpeedB_Click(object sender, EventArgs e)
        {
            Speed frmspeed = new Speed();
            frmspeed.Show();
        }

        private void btnVolumeB_Click(object sender, EventArgs e)
        {
            Volume frmvolume = new Volume();
            frmvolume.Show();
        }

        private void btnMassB_Click(object sender, EventArgs e)
        {
            Mass frmmass = new Mass();
            frmmass.Show();

        }

        private void btnTempB_Click(object sender, EventArgs e)
        {
            Temperature frmtemp = new Temperature();
            frmtemp.Show();
        }
    }
}
