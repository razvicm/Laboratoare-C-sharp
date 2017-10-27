using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1
{
    public partial class Form1 : Form
    {
        double val1, tva1, val2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pret_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToDouble(valoare.Text);
            tva1 = Convert.ToDouble(tva.Text);
            val2 = val1 + val1 * tva1 / 100;
            valtva.Text = "Valoarea produsului cu TVA este:\n "+ Convert.ToString(val2);
        }
    }
}
