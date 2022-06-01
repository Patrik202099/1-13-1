using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KepetForgat
{
    public partial class kepForgat : Form
    {
        public kepForgat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image a = label8.Image;
            label8.Image = label7.Image;
            label7.Image = label6.Image;
            label6.Image = label5.Image;
            label5.Image = label4.Image;
            label4.Image = label3.Image;
            label3.Image = label2.Image;
            label2.Image = label1.Image;

            label1.Image = a;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Image b = label1.Image;
            label1.Image = label2.Image;
            label2.Image = label3.Image;
            label3.Image = label4.Image;
            label4.Image = label5.Image;
            label5.Image = label6.Image;
            label6.Image = label7.Image;
            label7.Image = label8.Image;

            label8.Image = b;
        }
    }
}
