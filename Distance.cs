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
    public partial class Distance : Form
    {
        public Distance()
        {
            InitializeComponent();
        }

        private void btnconvert_Click(object sender, EventArgs e)
        {
            if (cbofirst.SelectedIndex == 0 && cboSecond.SelectedIndex == 1)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 1000).ToString();

            }
            else if (cbofirst.SelectedIndex == 0 && cboSecond.SelectedIndex == 2)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 10000).ToString();

            }
            else if (cbofirst.SelectedIndex == 0 && cboSecond.SelectedIndex == 3)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 100000).ToString();

            }
            else if (cbofirst.SelectedIndex == 0 && cboSecond.SelectedIndex == 4)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 1000000).ToString();

            }
            else if (cbofirst.SelectedIndex == 0 && cboSecond.SelectedIndex == 5)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 0.621371192).ToString();

            }
            else if (cbofirst.SelectedIndex == 0 && cboSecond.SelectedIndex == 6)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 3280.8399).ToString();

            }
            else if (cbofirst.SelectedIndex == 0 && cboSecond.SelectedIndex == 7)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 39370.0787).ToString();

            }

            else if (cbofirst.SelectedIndex == 1 && cboSecond.SelectedIndex == 0)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 0.001).ToString();

            }
            else if (cbofirst.SelectedIndex == 1 && cboSecond.SelectedIndex == 2)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 10).ToString();

            }
            else if (cbofirst.SelectedIndex == 1 && cboSecond.SelectedIndex == 3)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 100).ToString();

            }
            else if (cbofirst.SelectedIndex == 1 && cboSecond.SelectedIndex == 4)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 1000).ToString();

            }
            else if (cbofirst.SelectedIndex == 1 && cboSecond.SelectedIndex == 5)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 0.000621371192).ToString();

            }
            else if (cbofirst.SelectedIndex == 1 && cboSecond.SelectedIndex == 6)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 3.2808399).ToString();

            }
            else if (cbofirst.SelectedIndex == 1 && cboSecond.SelectedIndex == 7)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 39.3700787).ToString();

            }
            else if (cbofirst.SelectedIndex == 2 && cboSecond.SelectedIndex == 0)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 0.0001).ToString();

            }
            else if (cbofirst.SelectedIndex == 2 && cboSecond.SelectedIndex == 1)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 0.1).ToString();

            }
            else if (cbofirst.SelectedIndex == 2 && cboSecond.SelectedIndex == 3)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 10).ToString();

            }
            else if (cbofirst.SelectedIndex == 2 && cboSecond.SelectedIndex == 4)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 100).ToString();

            }
            else if (cbofirst.SelectedIndex == 2 && cboSecond.SelectedIndex == 5)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 6.21371192e-5).ToString();

            }
            else if (cbofirst.SelectedIndex == 2 && cboSecond.SelectedIndex == 6)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 0.32808399).ToString();

            }
            else if (cbofirst.SelectedIndex == 2 && cboSecond.SelectedIndex == 7)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 3.93700787).ToString();

            }
            else if (cbofirst.SelectedIndex == 3 && cboSecond.SelectedIndex == 0)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 0.00001).ToString();

            }
            else if (cbofirst.SelectedIndex == 3 && cboSecond.SelectedIndex == 1)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 0.01).ToString();

            }
            else if (cbofirst.SelectedIndex == 3 && cboSecond.SelectedIndex == 2)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 0.1).ToString();

            }
            else if (cbofirst.SelectedIndex == 3 && cboSecond.SelectedIndex == 4)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 10).ToString();

            }
            else if (cbofirst.SelectedIndex == 3 && cboSecond.SelectedIndex == 5)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 6.21371192e-6).ToString();

            }
            else if (cbofirst.SelectedIndex == 3 && cboSecond.SelectedIndex == 6)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 0.032808399).ToString();

            }
            else if (cbofirst.SelectedIndex == 3 && cboSecond.SelectedIndex == 7)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 0.393700787).ToString();

            }

            else if (cbofirst.SelectedIndex == 4 && cboSecond.SelectedIndex == 0)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 0.000001).ToString();

            }
            else if (cbofirst.SelectedIndex == 4 && cboSecond.SelectedIndex == 1)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 0.001).ToString();

            }
            else if (cbofirst.SelectedIndex == 4 && cboSecond.SelectedIndex == 2)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 0.01).ToString();

            }
            else if (cbofirst.SelectedIndex == 4 && cboSecond.SelectedIndex == 3)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 0.1).ToString();

            }
            else if (cbofirst.SelectedIndex == 4 && cboSecond.SelectedIndex == 5)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 6.21371192e-7).ToString();

            }
            else if (cbofirst.SelectedIndex == 4 && cboSecond.SelectedIndex == 6)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 0.0032808399).ToString();

            }
            else if (cbofirst.SelectedIndex == 4 && cboSecond.SelectedIndex == 7)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 0.0393700787).ToString();

            }
            else if (cbofirst.SelectedIndex == 5 && cboSecond.SelectedIndex == 0)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 1.609344).ToString();

            }
            else if (cbofirst.SelectedIndex == 5 && cboSecond.SelectedIndex == 1)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 1609.344).ToString();

            }
            else if (cbofirst.SelectedIndex == 5 && cboSecond.SelectedIndex == 2)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 16093.44).ToString();

            }
            else if (cbofirst.SelectedIndex == 5 && cboSecond.SelectedIndex == 3)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 160934.4).ToString();

            }
            else if (cbofirst.SelectedIndex == 5 && cboSecond.SelectedIndex == 4)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 1609344).ToString();

            }
            else if (cbofirst.SelectedIndex == 5 && cboSecond.SelectedIndex == 6)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 5280).ToString();

            }
            else if (cbofirst.SelectedIndex == 5 && cboSecond.SelectedIndex == 7)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 633360).ToString();

            }
            else if (cbofirst.SelectedIndex == 6 && cboSecond.SelectedIndex == 0)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 0.0003048).ToString();

            }
            else if (cbofirst.SelectedIndex == 6 && cboSecond.SelectedIndex == 1)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 0.3048).ToString();

            }
            else if (cbofirst.SelectedIndex == 6 && cboSecond.SelectedIndex == 2)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 3.048).ToString();

            }
            else if (cbofirst.SelectedIndex == 6 && cboSecond.SelectedIndex == 3)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 30.48).ToString();

            }
            else if (cbofirst.SelectedIndex == 6 && cboSecond.SelectedIndex == 4)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 304.8).ToString();

            }
            else if (cbofirst.SelectedIndex == 6 && cboSecond.SelectedIndex == 5)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 0.000189393939).ToString();

            }
            else if (cbofirst.SelectedIndex == 6 && cboSecond.SelectedIndex == 7)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 12).ToString();

            }
            else if (cbofirst.SelectedIndex == 7 && cboSecond.SelectedIndex == 0)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 0.0000254).ToString();

            }
            else if (cbofirst.SelectedIndex == 7 && cboSecond.SelectedIndex == 1)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 0.0254).ToString();

            }
            else if (cbofirst.SelectedIndex == 7 && cboSecond.SelectedIndex == 2)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 0.254).ToString();

            }
            else if (cbofirst.SelectedIndex == 7 && cboSecond.SelectedIndex == 3)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 2.54).ToString();

            }
            else if (cbofirst.SelectedIndex == 7 && cboSecond.SelectedIndex == 4)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 25.4).ToString();

            }
            else if (cbofirst.SelectedIndex == 7 && cboSecond.SelectedIndex == 5)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 1.57828283e-5).ToString();

            }
            else if (cbofirst.SelectedIndex == 7 && cboSecond.SelectedIndex == 6)
            {
                txtSecond.Text = (double.Parse(txtFirst.Text) * 0.0833333333).ToString();

            }
            else
            {
                MessageBox.Show("Please enter number which you would like to convert!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirst.Text = " ";
            txtSecond.Text = " ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Distance_Load(object sender, EventArgs e)
        {
            cbofirst.SelectedIndex = 0;
            cboSecond.SelectedIndex = 1;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Area frmArea = new Area();
            frmArea.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Media frmMedia = new Media();
            frmMedia.Show();
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
