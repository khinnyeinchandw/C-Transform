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
    public partial class Area : Form
    {
        public Area()
        {
            InitializeComponent();
        }

        private void btnCorvert_Click(object sender, EventArgs e)
        {
            if (txtChooseArea.Text.Trim() != "")
            {
                if (cboFirstArea.SelectedIndex == 0 && cboSecondArea.SelectedIndex == 1)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 100).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 0 && cboSecondArea.SelectedIndex == 2)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 1000000).ToString();
                }
                else if (cboFirstArea.SelectedIndex == 0 && cboSecondArea.SelectedIndex == 3)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 10000).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 0 && cboSecondArea.SelectedIndex == 4)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 1000000000000).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 0 && cboSecondArea.SelectedIndex == 5)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 2.59 * 1000000000000).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 0 && cboSecondArea.SelectedIndex == 6)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 2.529 * 10000000).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 0 && cboSecondArea.SelectedIndex == 7)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 92900).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 0 && cboSecondArea.SelectedIndex == 8)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 645.2).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 1 && cboSecondArea.SelectedIndex == 0)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) * 100).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 1 && cboSecondArea.SelectedIndex == 2)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 10000).ToString();
                }
                else if (cboFirstArea.SelectedIndex == 1 && cboSecondArea.SelectedIndex == 3)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 100).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 1 && cboSecondArea.SelectedIndex == 4)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 10000000000).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 1 && cboSecondArea.SelectedIndex == 5)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 2.59 * 10000000000).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 1 && cboSecondArea.SelectedIndex == 6)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 25.293).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 1 && cboSecondArea.SelectedIndex == 7)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 929).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 1 && cboSecondArea.SelectedIndex == 8)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 6.452).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 2 && cboSecondArea.SelectedIndex == 0)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) * 1000000).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 2 && cboSecondArea.SelectedIndex == 1)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) * 10000).ToString();
                }
                else if (cboFirstArea.SelectedIndex == 2 && cboSecondArea.SelectedIndex == 3)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) * 100).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 2 && cboSecondArea.SelectedIndex == 4)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 1000000).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 2 && cboSecondArea.SelectedIndex == 5)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 2.59 * 1000000).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 2 && cboSecondArea.SelectedIndex == 6)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 25.293).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 2 && cboSecondArea.SelectedIndex == 7)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) * 10.764).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 2 && cboSecondArea.SelectedIndex == 8)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) * 1550).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 3 && cboSecondArea.SelectedIndex == 0)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) * 10000).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 3 && cboSecondArea.SelectedIndex == 1)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) * 100).ToString();
                }
                else if (cboFirstArea.SelectedIndex == 3 && cboSecondArea.SelectedIndex == 2)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 100).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 3 && cboSecondArea.SelectedIndex == 4)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 100000000).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 3 && cboSecondArea.SelectedIndex == 5)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 2.5 * 100000000).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 3 && cboSecondArea.SelectedIndex == 6)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 2529).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 3 && cboSecondArea.SelectedIndex == 7)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 9.29).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 3 && cboSecondArea.SelectedIndex == 8)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) * 15.5).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 4 && cboSecondArea.SelectedIndex == 0)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) * 1000000000000).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 4 && cboSecondArea.SelectedIndex == 1)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) * 10000000000).ToString();
                }
                else if (cboFirstArea.SelectedIndex == 4 && cboSecondArea.SelectedIndex == 2)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) * 1000000).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 4 && cboSecondArea.SelectedIndex == 3)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) * 100000000).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 4 && cboSecondArea.SelectedIndex == 5)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 2.59).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 4 && cboSecondArea.SelectedIndex == 6)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) * 39540).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 4 && cboSecondArea.SelectedIndex == 7)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) * 1.076 * 10000000).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 4 && cboSecondArea.SelectedIndex == 8)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) * 1.55 * 1000000000).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 5 && cboSecondArea.SelectedIndex == 0)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) * 2.59 * 1000000000000).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 5 && cboSecondArea.SelectedIndex == 1)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) * 2.59 * 10000000000).ToString();
                }
                else if (cboFirstArea.SelectedIndex == 5 && cboSecondArea.SelectedIndex == 2)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) * 2.59 * 1000000).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 5 && cboSecondArea.SelectedIndex == 3)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) * 2.59 * 100000000).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 5 && cboSecondArea.SelectedIndex == 4)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) * 2.59).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 5 && cboSecondArea.SelectedIndex == 6)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) * 102400).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 5 && cboSecondArea.SelectedIndex == 7)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) * 2.529 * 10000000).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 5 && cboSecondArea.SelectedIndex == 8)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) * 4.014 * 1000000000).ToString();

                }
                if (cboFirstArea.SelectedIndex == 6 && cboSecondArea.SelectedIndex == 0)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) * 2.529 * 10000000).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 6 && cboSecondArea.SelectedIndex == 1)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) * 252900).ToString();
                }
                else if (cboFirstArea.SelectedIndex == 6 && cboSecondArea.SelectedIndex == 2)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) * 25.293).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 6 && cboSecondArea.SelectedIndex == 3)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) * 2529).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 6 && cboSecondArea.SelectedIndex == 4)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 39540).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 6 && cboSecondArea.SelectedIndex == 5)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 102400).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 6 && cboSecondArea.SelectedIndex == 7)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) * 272.3).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 6 && cboSecondArea.SelectedIndex == 8)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) * 39200).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 7 && cboSecondArea.SelectedIndex == 0)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) * 92900).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 7 && cboSecondArea.SelectedIndex == 1)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) * 929).ToString();
                }
                else if (cboFirstArea.SelectedIndex == 7 && cboSecondArea.SelectedIndex == 2)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 10.764).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 7 && cboSecondArea.SelectedIndex == 3)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 9.29).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 7 && cboSecondArea.SelectedIndex == 4)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 1.076 * 10000000).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 7 && cboSecondArea.SelectedIndex == 5)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 2.788 * 10000000).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 7 && cboSecondArea.SelectedIndex == 6)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 272.3).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 7 && cboSecondArea.SelectedIndex == 8)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) * 144).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 8 && cboSecondArea.SelectedIndex == 0)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) * 645.2).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 8 && cboSecondArea.SelectedIndex == 1)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) * 6.452).ToString();
                }
                else if (cboFirstArea.SelectedIndex == 8 && cboSecondArea.SelectedIndex == 2)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 1550).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 8 && cboSecondArea.SelectedIndex == 3)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 15.5).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 8 && cboSecondArea.SelectedIndex == 4)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 1.55 * 1000000000).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 8 && cboSecondArea.SelectedIndex == 5)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 4.014 * 1000000000).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 8 && cboSecondArea.SelectedIndex == 6)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 39200).ToString();

                }
                else if (cboFirstArea.SelectedIndex == 8 && cboSecondArea.SelectedIndex == 7)
                {
                    txtAnswerArea.Text = (double.Parse(txtChooseArea.Text) / 144).ToString();
                }


            }

            else
            {
                MessageBox.Show("Please enter number which you would like to convert!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Area_Load(object sender, EventArgs e)
        {
            cboFirstArea.SelectedIndex = 0;
            cboSecondArea.SelectedIndex = 1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAnswerArea.Text = " ";
            txtChooseArea.Text = " ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Distance frmDis = new Distance();
            frmDis.Show();
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
