using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telecom
{
    public partial class Form1 : Form
    {
        string mesajul;
        int p, f, c;

        public Form1()
        {
            InitializeComponent();
            p = 1; f = 1; c = 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inchide_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void renunta_Click(object sender, EventArgs e)
        {
            mesaj.Text = mesajul;
            pf.Checked = false;
            info.Checked = false;
            cs.Checked = false;
            nume.Text = "";
            adresa.Text = "";
            parola.Text = "";
        }

        private void continuare_Click(object sender, EventArgs e)
        {
            if (parola.Text == "administrator12telekom")
                inchide.Visible = true;
            else
            {
                mesajul = nume.Text;
                if (fizica.Checked)
                    mesajul += " persoana fizica \n";
                else mesajul += " persoana juridica \n";
                if (pf.Checked)
                {
                    mesajul += " numarul pentru plata factura este" + Convert.ToString(p);
                    p++;
                }
                if (info.Checked)
                {
                    mesajul += "\n numarul pentru informatii factura este" + Convert.ToString(f);
                    f++;
                }
                if (cs.Checked)
                {
                    mesajul += "\n numarul pentru contractari servicii" + Convert.ToString(c);
                    c++;
                }
                mesaj.Text = mesajul;
                pf.Checked = false;
                info.Checked = false;
                cs.Checked = false;
                nume.Text = "";
                adresa.Text = "";
                parola.Text = "";
            }
        }

        private void cs_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
