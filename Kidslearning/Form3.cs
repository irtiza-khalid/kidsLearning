using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Kidslearning
{
    public partial class Form3 : Form
    {
        static int i = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label13.Text = "1";
                i += 1;

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label13.Text = "0";


            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                label14.Text = "1";
                i += 1;

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                label14.Text = "0";


            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                label18.Text = "1";
                i += 1;

            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                label18.Text = "0";


            }
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton16.Checked)
            {
                label20.Text = "1";
                i += 1;

            }
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton15.Checked)
            {
                label20.Text = "0";


            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
            {
                label22.Text = "1";
                i += 1;

            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                label22.Text = "0";


            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label29_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

            label29.Text = i.ToString();
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label13.Text = "1";
                i += 1;

            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label13.Text = "0";
               

            }
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                label14.Text = "1";
                i += 1;

            }
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                label13.Text = "0";
                

            }
        }

        private void radioButton8_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                label18.Text = "1";
               

            }
        }

        private void radioButton7_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                label18.Text = "1";
              

            }
        }

        private void radioButton16_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton16.Checked)
            {
                label20.Text = "1";
                i += 1;

            }
        }

        private void radioButton15_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton15.Checked)
            {
                label20.Text = "0";
                

            }
        }

        private void radioButton10_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
            {
                label22.Text = "1";
                i += 1;

            }
        }

        private void radioButton9_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                label22.Text = "0";
                

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label29.Text = i.ToString();
        }

        // private void panel2_Paint(object sender, PaintEventArgs e)
        // {

        //}
    }
}
