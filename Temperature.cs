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
    public partial class Temperature : Form
    {
        public Temperature()
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
            Volume frmvolume = new Volume();
            frmvolume.Show();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            Mass frmmass = new Mass();
            frmmass.Show();
        }

        private void btnconverter_Click(object sender, EventArgs e)
        {
            if (cboInputUnit.SelectedIndex == 0 && cboOutputUnit.SelectedIndex == 1)
            {
                txtresult.Text = (double.Parse(txtTemp.Text) - 273.15).ToString();
            }
            else if (cboInputUnit.SelectedIndex == 0 && cboOutputUnit.SelectedIndex == 2)
            {
                txtresult.Text = (((double.Parse(txtTemp.Text) - 273.15) * 1.8) + 32).ToString();
            }
            else if (cboInputUnit.SelectedIndex == 1 && cboOutputUnit.SelectedIndex == 0)
            {
                txtresult.Text = (double.Parse(txtTemp.Text) + 273.15).ToString();
            }
            else if (cboInputUnit.SelectedIndex == 1 && cboOutputUnit.SelectedIndex == 2)
            {
                txtresult.Text = ((double.Parse(txtTemp.Text) * 1.8) + 32).ToString();
            }
            else if (cboInputUnit.SelectedIndex == 2 && cboOutputUnit.SelectedIndex == 0)
            {
                txtresult.Text = ((double.Parse(txtTemp.Text) - 32) * 0.555 + 273.15).ToString();
            }
            else if (cboInputUnit.SelectedIndex == 2 && cboOutputUnit.SelectedIndex == 1)
            {
                txtresult.Text = ((double.Parse(txtTemp.Text) - 32) * 0.555).ToString();
            }
            else
            {
                MessageBox.Show("Please Choose different unit to convert!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTemp.Text = "";
            txtresult.Text = "";
        }

        private void Temperature_Load(object sender, EventArgs e)
        {
            cboInputUnit.SelectedIndex = 0;
            cboOutputUnit.SelectedIndex = 1;
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
        }
    }
}
