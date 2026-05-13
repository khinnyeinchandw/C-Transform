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
    public partial class Speed : Form
    {
        public Speed()
        {
            InitializeComponent();
        }

        private void btnconvert_Click(object sender, EventArgs e)
        {
            if (cbotype.SelectedIndex == 0 && cboconvert.SelectedIndex == 1)
            {

                txtto.Text = (double.Parse(txtspeed.Text) * 3.6).ToString();
            }
            else if (cbotype.SelectedIndex == 0 && cboconvert.SelectedIndex == 2)
            {
                txtto.Text = (double.Parse(txtspeed.Text) * 2.237).ToString();
            }
            else if (cbotype.SelectedIndex == 1 && cboconvert.SelectedIndex == 0)
            {
                txtto.Text = (double.Parse(txtspeed.Text) / 3.6).ToString();
            }
            else if (cbotype.SelectedIndex == 1 && cboconvert.SelectedIndex == 2)
            {
                txtto.Text = (double.Parse(txtspeed.Text) / 1.609).ToString();
            }
            else if (cbotype.SelectedIndex == 2 && cboconvert.SelectedIndex == 0)
            {
                txtto.Text = (double.Parse(txtspeed.Text) / 2.237).ToString();
            }
            else if (cbotype.SelectedIndex == 2 && cboconvert.SelectedIndex == 1)
            {
                txtto.Text = (double.Parse(txtspeed.Text) * 1.609).ToString();
            }
            else
            {
                MessageBox.Show("Please Choose different unit to convert!");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtspeed.Text = " ";
            txtto.Text = " ";
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
            Media frmMedia = new Media();
            frmMedia.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Photo frmimg = new Photo();
            frmimg.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Pressure frmpressure = new Pressure();
            frmpressure.Show();
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

        private void Speed_Load(object sender, EventArgs e)
        {
            cbotype.SelectedIndex = 0;
            cboconvert.SelectedIndex = 1;
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
        }
    }
}
