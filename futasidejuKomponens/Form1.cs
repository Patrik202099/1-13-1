using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace futasidejuKomponens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            double atlag;
            int osszeg = 0;
            int db = 0;
            int min = int.MaxValue;
            int max = int.MinValue;

            int ertek = rnd.Next(101);
            Label lb = new Label();
            lb.Location = new Point(e.X, e.Y);
            lb.Text = ertek.ToString();
            lb.AutoSize = true;
            Controls.Add(lb);
            osszeg += ertek;
            atlag = osszeg / (double)db;

            if (min > ertek) min = ertek;
            if (max < ertek) max = ertek;

            Eredmeny.Text = String.Format("Darabszám : {0} , összeg : {1} , átlag : {2} , " + "minimum : {3} , maximum: {4}.", db, osszeg, atlag, min, max);
        }
    }
}
