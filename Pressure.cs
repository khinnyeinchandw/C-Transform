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
    public partial class Pressure : Form
    {
        public Pressure()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (cboFrom.SelectedIndex == 0 && cboTo.SelectedIndex == 1)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) / 760).ToString();
            }
            else if (cboFrom.SelectedIndex == 0 && cboTo.SelectedIndex == 2)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) * 133.3223684).ToString();
            }
            else if (cboFrom.SelectedIndex == 0 && cboTo.SelectedIndex == 3)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) / 51.715).ToString();
            }
            else if (cboFrom.SelectedIndex == 0 && cboTo.SelectedIndex == 4)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) / 750.1).ToString();
            }
            else if (cboFrom.SelectedIndex == 0 && cboTo.SelectedIndex == 5)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) * 1).ToString();
            }
            else if (cboFrom.SelectedIndex == 1 && cboTo.SelectedIndex == 0)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) * 760).ToString();
            }
            else if (cboFrom.SelectedIndex == 1 && cboTo.SelectedIndex == 2)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) * 101.325).ToString();
            }
            else if (cboFrom.SelectedIndex == 1 && cboTo.SelectedIndex == 3)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) * 14.696).ToString();
            }
            else if (cboFrom.SelectedIndex == 1 && cboTo.SelectedIndex == 4)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) * 1.013).ToString();
            }
            else if (cboFrom.SelectedIndex == 1 && cboTo.SelectedIndex == 5)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) * 760).ToString();
            }
            else if (cboFrom.SelectedIndex == 2 && cboTo.SelectedIndex == 0)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) / 133.3).ToString();
            }
            else if (cboFrom.SelectedIndex == 2 && cboTo.SelectedIndex == 1)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) / 101300).ToString();
            }
            else if (cboFrom.SelectedIndex == 2 && cboTo.SelectedIndex == 3)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) / 6895).ToString();
            }
            else if (cboFrom.SelectedIndex == 2 && cboTo.SelectedIndex == 4)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) / 100000).ToString();
            }
            else if (cboFrom.SelectedIndex == 2 && cboTo.SelectedIndex == 5)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) / 133.3).ToString();
            }
            else if (cboFrom.SelectedIndex == 3 && cboTo.SelectedIndex == 0)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) * 51.715).ToString();
            }
            else if (cboFrom.SelectedIndex == 3 && cboTo.SelectedIndex == 1)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) / 14.696).ToString();
            }
            else if (cboFrom.SelectedIndex == 3 && cboTo.SelectedIndex == 2)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) * 6895).ToString();
            }
            else if (cboFrom.SelectedIndex == 3 && cboTo.SelectedIndex == 4)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) / 14.504).ToString();
            }
            else if (cboFrom.SelectedIndex == 3 && cboTo.SelectedIndex == 5)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) * 51.715).ToString();
            }
            else if (cboFrom.SelectedIndex == 4 && cboTo.SelectedIndex == 0)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) * 750.1).ToString();
            }
            else if (cboFrom.SelectedIndex == 4 && cboTo.SelectedIndex == 1)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) / 1.013).ToString();
            }
            else if (cboFrom.SelectedIndex == 4 && cboTo.SelectedIndex == 2)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) * 100000).ToString();
            }
            else if (cboFrom.SelectedIndex == 4 && cboTo.SelectedIndex == 3)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) * 14.504).ToString();
            }
            else if (cboFrom.SelectedIndex == 4 && cboTo.SelectedIndex == 5)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) * 750.1).ToString();
            }
            else if (cboFrom.SelectedIndex == 5 && cboTo.SelectedIndex == 0)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) * 1).ToString();
            }
            else if (cboFrom.SelectedIndex == 5 && cboTo.SelectedIndex == 1)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) / 760).ToString();
            }
            else if (cboFrom.SelectedIndex == 5 && cboTo.SelectedIndex == 2)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) * 133.3).ToString();
            }
            else if (cboFrom.SelectedIndex == 5 && cboTo.SelectedIndex == 3)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) * 51.715).ToString();
            }
            else if (cboFrom.SelectedIndex == 5 && cboTo.SelectedIndex == 4)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) / 750.1).ToString();
            }
            else
            {
                MessageBox.Show("Please! choose different unit to convert.", "C-transform", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Pressure_Load(object sender, EventArgs e)
        {
            cboFrom.SelectedIndex = 0;
            cboTo.SelectedIndex = 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFrom.Text = "";
            txtTo.Text = "";
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
