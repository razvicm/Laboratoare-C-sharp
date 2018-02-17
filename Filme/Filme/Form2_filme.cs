using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Filme
{
    public partial class Form2_filme : Form
    {
        SqlConnection myCon = new SqlConnection();
        DataSet dsFilm;
        Filme.ServiceReference1.PrimulserviciuwebSoapClient service = new Filme.ServiceReference1.PrimulserviciuwebSoapClient();
        public Form2_filme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            //f.ShowDialog();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_filme_Load(object sender, EventArgs e)
        {
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Razvan\source\repos\Filme\Filme\Database1.mdf;Integrated Security=True";
            myCon.Open();
            dsFilm = new DataSet();
            SqlDataAdapter interogFilm = new SqlDataAdapter("SELECT * FROM Filme", myCon);
            interogFilm.Fill(dsFilm, "Filme");
            foreach (DataRow dr in dsFilm.Tables["Filme"].Rows)
            {

                String name = dr.ItemArray.GetValue(1).ToString();
                cBox_film.Items.Add(name);

            }

            //SqlCommand command = new SqlCommand(cmdText: "INSERT INTO Filme( Nume,An_aparitie,Id_imdb) VALUES ( @Nume , @An_aparitie , @Id_imdb)", connection: myCon);


            myCon.Close();
        }

        private void cBox_film_SelectedIndexChanged(object sender, EventArgs e)
        {
            int code = 0;
            String filmSelectat = cBox_film.SelectedItem.ToString();
            foreach (DataRow dr in dsFilm.Tables["Filme"].Rows)
            {
                if (filmSelectat == dr.ItemArray.GetValue(1).ToString())
                {
                    tBox_an.Text = dr.ItemArray.GetValue(2).ToString();
                    //code = Convert.ToInt16(dr.ItemArray.GetValue(3));
                    
                    string link = service.generateUrl("https://en.m.wikipedia.org/wiki/", dr.ItemArray.GetValue(1).ToString());
                    //webBrowser1.Url= "https://en.m.wikipedia.org/wiki/" + dr.ItemArray.GetValue(1).ToString();
                    //webBrowser1.Url= new System.Uri("https://en.m.wikipedia.org/wiki/" + dr.ItemArray.GetValue(1).ToString(), System.UriKind.Absolute);
                    webBrowser1.Url = new System.Uri(link);
                }
            }

        }
    }
}
