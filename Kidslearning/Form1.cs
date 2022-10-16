using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kidslearning
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            Form3 n=new Form3();
            n.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
           animal animal1 = new animal();
            animal1.Show();  
            Hide();

        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            Form2 animal1 = new Form2();
            animal1.Show();
            Hide();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
