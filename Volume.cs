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
    public partial class Volume : Form
    {
        public Volume()
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
            Mass frmmass = new Mass();
            frmmass.Show();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (cboType.SelectedIndex == 0 && cboConvert.SelectedIndex == 1)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) * 1000).ToString();
            }
            else if (cboType.SelectedIndex == 0 && cboConvert.SelectedIndex == 2)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) * 1).ToString();
            }
            else if (cboType.SelectedIndex == 0 && cboConvert.SelectedIndex == 3)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) * 1000).ToString();
            }
            else if (cboType.SelectedIndex == 0 && cboConvert.SelectedIndex == 4)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) / 1000).ToString();
            }
            else if (cboType.SelectedIndex == 1 && cboConvert.SelectedIndex == 0)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) / 1000).ToString();
            }
            else if (cboType.SelectedIndex == 1 && cboConvert.SelectedIndex == 2)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) / 1000).ToString();
            }
            else if (cboType.SelectedIndex == 1 && cboConvert.SelectedIndex == 3)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) * 1).ToString();
            }
            else if (cboType.SelectedIndex == 1 && cboConvert.SelectedIndex == 4)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) / 1e+6).ToString();
            }
            else if (cboType.SelectedIndex == 2 && cboConvert.SelectedIndex == 0)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) * 1).ToString();
            }
            else if (cboType.SelectedIndex == 2 && cboConvert.SelectedIndex == 1)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) * 1000).ToString();
            }
            else if (cboType.SelectedIndex == 2 && cboConvert.SelectedIndex == 3)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) * 1000).ToString();
            }
            else if (cboType.SelectedIndex == 2 && cboConvert.SelectedIndex == 4)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) / 1000).ToString();
            }
            else if (cboType.SelectedIndex == 3 && cboConvert.SelectedIndex == 0)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) / 1000).ToString();
            }
            else if (cboType.SelectedIndex == 3 && cboConvert.SelectedIndex == 1)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) * 1).ToString();
            }
            else if (cboType.SelectedIndex == 3 && cboConvert.SelectedIndex == 2)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) / 1000).ToString();
            }
            else if (cboType.SelectedIndex == 4 && cboConvert.SelectedIndex == 0)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) / 1000).ToString();
            }
            else if (cboType.SelectedIndex == 4 && cboConvert.SelectedIndex == 1)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) / 1e+6).ToString();
            }
            else if (cboType.SelectedIndex == 4 && cboConvert.SelectedIndex == 2)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) * 1000).ToString();
            }
            else if (cboType.SelectedIndex == 4 && cboConvert.SelectedIndex == 3)
            {
                txtTo.Text = (double.Parse(txtFrom.Text) / 1e+6).ToString();
            }

            else
            {
                MessageBox.Show("Please choose different unit to convert.", "C-transform", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFrom.Text = " ";
            txtTo.Text = " ";
        }

        private void txtTo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Volume_Load(object sender, EventArgs e)
        {
            cboType.SelectedIndex = 0;
            cboConvert.SelectedIndex = 1;
        }

        private void cboConvert_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
        }


    }
}
