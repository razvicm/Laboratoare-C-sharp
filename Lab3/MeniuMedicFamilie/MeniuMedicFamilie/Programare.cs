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
    public partial class Programare : Form
    {
        public Programare()
        {
            InitializeComponent();
            for (int i = 0; i < Form1.ore.Length; i++)
                if (Form1.p1[i] == 0) comboore.Items.Add(Form1.ore[i]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string orai = Convert.ToString(comboore.SelectedItem);
            informatii.Text = tnume.Text + " sunteti programat de la ora " + orai;
            for (int i = 0; i < Form1.p1.Length; i++)
                if (Form1.ore[i] == orai)
                {
                    Form1.p1[i] = 1;
                    Form1.nume[i] = tnume.Text;
                }
            tnume.Text = "";
            comboore.Items.Clear();
            comboore.Text = "";
            for (int i = 0; i < Form1.ore.Length; i++)
                if (Form1.p1[i] == 0)
                    comboore.Items.Add(Form1.ore[i]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
