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
    public partial class Mass : Form
    {
        public Mass()
        {
            InitializeComponent();
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
            Speed frmspeed = new Speed();
            frmspeed.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Temperature frmtemp = new Temperature();
            frmtemp.Show();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            Volume frmvolume = new Volume();
            frmvolume.Show();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (cboUnit.SelectedIndex == 0 && cboconverter.SelectedIndex == 1)
            {
                txtthap.Text = (double.Parse(txtenternumber.Text) / 1000).ToString();
            }
            else if (cboUnit.SelectedIndex == 0 && cboconverter.SelectedIndex == 2)
            {

                txtthap.Text = (double.Parse(txtenternumber.Text) * 0.00220462).ToString();
            }
            else if (cboUnit.SelectedIndex == 1 && cboconverter.SelectedIndex == 0)
            {
                txtthap.Text = (double.Parse(txtenternumber.Text) * 1000).ToString();

            }
            else if (cboUnit.SelectedIndex == 1 && cboconverter.SelectedIndex == 2)
            {
                txtthap.Text = (double.Parse(txtenternumber.Text) * 2.205).ToString();

            }
            else if (cboUnit.SelectedIndex == 2 && cboconverter.SelectedIndex == 0)
            {
                txtthap.Text = (double.Parse(txtenternumber.Text) * 453.592).ToString();

            }
            else if (cboUnit.SelectedIndex == 2 && cboconverter.SelectedIndex == 1)
            {
                txtthap.Text = (double.Parse(txtenternumber.Text) / 2.205).ToString();

            }
            else
            {
                MessageBox.Show("Please Choose different unit to convert!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtenternumber.Text = "";
            txtthap.Text = "";
        }

        private void Mass_Load(object sender, EventArgs e)
        {
            cboUnit.SelectedIndex = 0;
            cboconverter.SelectedIndex = 1;
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
        }
    }
}
