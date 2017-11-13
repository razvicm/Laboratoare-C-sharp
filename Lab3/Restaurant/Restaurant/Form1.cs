using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Form1 : Form
    {
        string[] preparate = { "Pizza quattro formaggi", "Pizza calzone", "Pizza canibale", "Pizza Margherita", "Tarta cu fructe", "Dobos", "Diplomat", "Inghetata" };
        string[] bauturi = { "Apa plata 0.5l Dorna", "Apa carbo Borsec 0.5l", "Pepsi 0.5l", "Limonada 0.5l", "Ceai verde", "Cafea expresso" };
        int[] pretp = { 19, 21, 20, 12, 5, 4, 5, 10 };
        int[] pretb = { 3, 3, 5, 9, 4, 6 };
        public static string c;
        int cost;
        string mas;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Meniul zilei de:" + Convert.ToString(DateTime.Now);
            foreach (string elem in preparate)
                listam.Items.Add(elem);
            foreach (string elem in bauturi)
                listab.Items.Add(elem);
        }

        private void comanda_Click(object sender, EventArgs e)
        {
            try
            {
                cost = 0;
                c = "";
                foreach (int i in listam.CheckedIndices)
                {
                    cost = cost + pretp[i];
                    c = c + preparate[i] + " pret " + Convert.ToString(pretp[i]) + " lei\n";
                }
                listam.ClearSelected();
                foreach (int i in listab.CheckedIndices)
                {
                    cost = cost + pretb[i];
                    c = c + bauturi[i] + " pret " + Convert.ToString(pretb[i]) + " lei\n";
                }
                listab.ClearSelected();
                mas = Convert.ToString(nrmasa.SelectedItem);
                c = c + "\nTOTAL masa " + mas + " : " + Convert.ToString(cost) + " lei";
                // Verificam daca a bifat bauturi sau preparate si daca a selectat masa
                if (cost == 0) throw new Exception("Va rugam comandati ceva !");
                if (nrmasa.SelectedIndex == -1) throw new Exception("Va rugam selectati masa !");
                Form2 f = new Form2();
                this.listab.ClearSelected();
                
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

            private void preluat_Click(object sender, EventArgs e)
        {
            foreach (int i in listab.CheckedIndices)
                listab.SetItemChecked(i, false);
            foreach (int i in listam.CheckedIndices)
                listam.SetItemChecked(i, false);
            nrmasa.SelectedIndex = -1;
        }
    }
}
