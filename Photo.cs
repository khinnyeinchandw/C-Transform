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
    public partial class Photo : Form
    {
        public Photo()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (cboType.SelectedIndex == 0)
            {
                ofilDiagPhoto.Filter = "Png File(*.png)|*.png";
            }
            else if (cboType.SelectedIndex == 1)
            {
                ofilDiagPhoto.Filter = "Jpg File(*.jpg)|*.jpg";
            }
            else if (cboType.SelectedIndex == 2)
            {
                ofilDiagPhoto.Filter = "Jpeg File(*.jpeg)|*.jpeg";
            }
            else
            {
                ofilDiagPhoto.Filter = "Icon (*.ico)|*.ico";
            }
            DialogResult result = ofilDiagPhoto.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtPath.Text = ofilDiagPhoto.FileName;
                if (cboConvertType.SelectedIndex == 3)
                {
                    Image pngImage = Image.FromFile(ofilDiagPhoto.FileName);
                    Icon icon;
                    using (Bitmap bmp = new Bitmap(pngImage))
                    {
                        icon = Icon.FromHandle(bmp.GetHicon());
                    }
                    picPhoto.Image = icon.ToBitmap();
                }
                else
                {
                    picPhoto.Image = Image.FromFile(ofilDiagPhoto.FileName);
                }
                picPhoto.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (cboConvertType.SelectedIndex == 0)
            {
                sfilDiagPhoto.Filter = "Png File(*.png)|*.png";
            }
            else if (cboConvertType.SelectedIndex == 1)
            {
                sfilDiagPhoto.Filter = "Jpg File(*.jpg)|*.jpg";
            }
            else if (cboConvertType.SelectedIndex == 2)
            {
                sfilDiagPhoto.Filter = "Jpeg File(*.jpeg)|*.jpeg";
            }
            else
            {
                sfilDiagPhoto.Filter = "Icon (*.ico)|*.ico";
            }
            DialogResult result = sfilDiagPhoto.ShowDialog();
            if (result == DialogResult.OK)
            {
                picPhoto.Image.Save(sfilDiagPhoto.FileName);
                MessageBox.Show("Save Successful!");
            }
        }

        private void Photo_Load(object sender, EventArgs e)
        {
            cboType.SelectedIndex = 0;
            cboConvertType.SelectedIndex = 1;
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
