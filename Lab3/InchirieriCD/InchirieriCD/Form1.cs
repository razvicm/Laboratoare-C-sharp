using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InchirieriCD
{
    public partial class Form1 : Form
    {
        string[] film = { "Titanic", "Don Juan de Marco", "Tom si Jerry", "Matrix", "Letters to Juliet" };
        string[] domeniu = { "Dragoste", "Dragoste", "Animatie", "Actiune", "Dragoste" };
        int[] anu = { 1997, 2000, 1990, 2007, 2000 };
        string[] imagini = { "Titanic.jpg", "Don_Juan_de_Marco.jpg", "Tom_Jerry.jpg",
        "The_Matrix_Poster.jpg", "Letters_to_Juliet.jpg" };
        public Form1()
        {
           
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Now.AddDays(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                filmul.Items.Clear();
                string dom;
                int an;
                // Verificam daca am selectat un “domeniul” si un „anul”
                if (domeniul.SelectedIndex == -1)
                    dom = "";
                else
                    dom = domeniul.SelectedItem.ToString();
                if (anul.SelectedIndex == -1)
                    an = 0;
                else
                    an = Convert.ToUInt16(anul.SelectedItem);
                // Completam ComboBox filmul in functie de ce am selectat din celelalte doua ComboBox
                if (dom == "")
                    if (an == 0)
                        for (int i = 0; i < film.Length; i++)
                        {
                            filmul.Items.Add(film[i]);
                        }
                    else
                        for (int i = 0; i < film.Length; i++)
                        {
                            if (an == anu[i])
                                filmul.Items.Add(film[i]);
                        }
                else
                if (an == 0)
                    for (int i = 0; i < film.Length; i++)
                    {
                        if (dom == domeniu[i])
                            filmul.Items.Add(film[i]);
                    }
                else
                    for (int i = 0; i < film.Length; i++)
                    {
                        if (dom == domeniu[i] && an == anu[i])
                            filmul.Items.Add(film[i]);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (filmul.SelectedIndex == -1) // Nu a fost selectat nimic in combobox filmul
                MessageBox.Show("Va rugam selectati un film");
            else
            {
                // A fost selectat un film si am apasat butonul Inchiriez
                // Calculam numarul de zile pana la data inchirierii si il afisam in label
                int nrzile = dateTimePicker1.Value.Subtract(DateTime.Now).Days + 1;
                label5.Text = "Ati inchiriat filmul " + filmul.SelectedItem.ToString() + " pentru " +
                nrzile + " zile";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Resetam valoarea tuturor controalelor
            label4.Text = "";
            filmul.Items.Clear();
            filmul.Text = "";
            domeniul.Text = "";
            anul.Text = "";
            pictureBox1.Image = null;
            dateTimePicker1.Value = DateTime.Now.AddDays(1); // Data corespunzatoare zilei de maine
        }

        private void filmul_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cautam numele fisierului in care avem imaginea corespunzatoare filmului
            int i;
            for (i = 0; i < film.Length && filmul.SelectedItem.ToString() != film[i]; i++) ;
            pictureBox1.Image = Image.FromFile("..\\..\\..\\poze\\" + imagini[i]);
            // aceasta "..\\..\\..\\poze\\" este calea relativa spre folderul in care sunt pastrate
           // imaginile.Reperul este fisierul.exe al aplicatiei care se afla in \bin\Debug
            pictureBox1.Visible = true;
        }
    }
}
