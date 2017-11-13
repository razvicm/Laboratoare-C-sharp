using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeniuMedicFamilie
{
    public partial class Form1 : Form
    {
        public static string[] ore = { "8", "8:30", "9", "9:30", "10", "10:30", "11", "11:30", "12", "12:30" };
        public static int[] p1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static string[] nume = new string[10];
        public static string inf;
        public static int numarp;
        public Form1()
        {
            InitializeComponent();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void programareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Programare prog = new Programare();
            prog.ShowDialog();
        }

        private void oreLibereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inf = "Ore libere:\n";
            for (int i = 0; i < Form1.p1.Length; i++)
                if (Form1.p1[i] == 0)
                    inf += Form1.ore[i] + " \n";
            Afisare orel = new Afisare();
            orel.Text = "Ore libere";
            orel.ShowDialog();
        }

        private void planificatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inf = "";
            for (int i = 0; i < p1.Length; i++)
                if (p1[i] == 1) inf += nume[i] + " ora " + ore[i] + "\n";
            Afisare plan = new Afisare();
            plan.Text = "Planificati";
            plan.ShowDialog();
        }

        private void numarTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inf = "";
            numarp = 0;
            for (int i = 0; i < p1.Length; i++)
                if (p1[i] == 1) numarp++;
            inf = "Numar pacienti programati azi " + Convert.ToString(numarp);
            Afisare totalp = new Afisare();
            totalp.Text = "Total programati";
            totalp.ShowDialog();
        }
    }
}
