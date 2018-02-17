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
    public partial class Form2 : Form
    {
        SqlConnection myCon = new SqlConnection();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Razvan\source\repos\Filme\Filme\Database1.mdf;Integrated Security=True";
            myCon.Open();
            SqlDataAdapter adFilm = new SqlDataAdapter();
            try
            {
                
                SqlCommand command = new SqlCommand(cmdText: "INSERT INTO Filme( Nume,An_aparitie) VALUES ( @Nume , @An_aparitie )", connection: myCon);
                System.Diagnostics.Debug.WriteLine(command);
                command.Parameters.Add("@Nume", SqlDbType.Text).Value = textBox1.Text;
                System.Diagnostics.Debug.WriteLine(textBox1.Text);
                command.Parameters.Add("@An_aparitie", SqlDbType.Int).Value = int.Parse(textBox2.Text);
                System.Diagnostics.Debug.WriteLine(textBox2.Text);
                
                Console.WriteLine(command);
                System.Diagnostics.Debug.WriteLine(command);
                adFilm.InsertCommand = command;
                adFilm.InsertCommand.ExecuteNonQuery();
                button1.Enabled = false;
                label4.Text = "Filmul a fost adaugat cu succes";
                label4.ForeColor = Color.FromArgb(0, 255, 0);


            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.ToString());
                MessageBox.Show("Datele introduse nu sunt corecte");
                label4.Text=("Datele introduse nu sunt corecte");
                label4.ForeColor = Color.FromArgb(255, 0, 0);
            }

            myCon.Close();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2_filme f = new Form2_filme();
            f.Show();
            this.Hide();
        }
    }
}
