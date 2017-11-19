using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema
{
    public partial class Form1 : Form
    {
        int[] total = new int[5];
        public Form1()
        {
            InitializeComponent();
            
        }

        private void verif_Click(object sender, EventArgs e)
        {

            if (r1.Checked)
                total[0] = 1;
            else if (r2.Checked)
                total[0] = 2;
            else if (r3.Checked)
                total[0]= 3;

            if (r4.Checked)
                total [1]= 3;
            else if (r5.Checked)
            {
                total [1]= 2;
                Console.WriteLine(total);
            }
            else if (r6.Checked)
                total [1]= 1;

            if (r7.Checked)
                total [2]= 2;
            else if (r8.Checked)
                total [2]= 1;
            else if (r9.Checked)
                total [2]= 3;
            if (r10.Checked)
                total [3]= 1;
            else if (r11.Checked)
                total [3]= 3;
            else if (r12.Checked)
                total [3]= 2;

             if (r13.Checked)
                total [4]= 1;
            else if (r14.Checked)
                total [4]= 2;
            else if (r15.Checked)
                total [4]= 3;
            //punctaj.Text = ("Ai obtinut {0}",total +" puncte");
            punctaj.Text = ("Ai obtinut "+ total.Sum() + " puncte");
            if(total.Sum()<9)
            rezultat.Text = " Lasi impresia unei persoane care se adapteaza foarte usor unor situatii noi.";
            else if (total.Sum() >= 9)
                rezultat.Text = "  La prima vedere lasi impresia unei persoane foarte echilibrate.";
            if (total.Sum() > 11)
                rezultat.Text = " Primul lucru care se observa la tine este siguranta de care dai dovada in actiunile tale.";
        }

        private void inchide_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
