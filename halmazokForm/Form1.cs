using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace halmazokForm
{
    public partial class Form1 : Form
    {
        int [] aElemek;
        int [] bElemek;
        int[] aUnioB;
        int[] aMetszetB;
        int[] aMinusB;
        int[] bMinusA;
        int aElem;
        int bElem;

        public Form1()
        {
            InitializeComponent();
            this.aElemek = new int[99];
            this.bElemek = new int[99];
            this.aUnioB = new int[99];
            this.aMetszetB = new int[99];
            this.aMinusB = new int[99];
            this.bMinusA = new int[99];
            this.aElem = 0;
            this.bElem = 0;
        }
        private void submitBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            this.aElem = Convert.ToInt32(elsoSzam.Text);
            this.bElem = Convert.ToInt32(masodikSzam.Text);

            if (this.aElem < 10) { this.aElem = 10; }
            else if (this.aElem > 100) { this.aElem = 100; }

            if (this.bElem < 10) { this.bElem = 10; }
            else if (this.bElem > 100) { this.bElem = 100; }

            // A elemek generálása, feltöltése

            for (int i = 0; i < this.aElem; i++)
            {
                listBox1.Items.Add(this.aElemek[i] = rnd.Next(100));
            }

            // B elemek generálása, feltöltése

            for (int y = 0; y < this.bElem; y++)
            {
                listBox2.Items.Add(this.bElemek[y] = rnd.Next(100));
            }
        }
    }
}
