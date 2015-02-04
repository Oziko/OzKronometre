using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _150202_Win_Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayi1 = 0;
        int sayi2 = 0;
        int sayi3 = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer3.Start();
            button1.Hide();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            sayi3++;
            if(sayi3 >= 60)
            {
                sayi3 = 0;
                sayi2++;
                if(sayi2 >= 60)
                {
                    sayi1++;
                    sayi2 = 0;
                }
                if(sayi1 >=24)
                {
                    sayi1 = 0;
                }
            }
            saniye.Text = sayi3.ToString();
            dakika.Text = sayi2.ToString();
            saat.Text = sayi1.ToString();
        }
    }
}
