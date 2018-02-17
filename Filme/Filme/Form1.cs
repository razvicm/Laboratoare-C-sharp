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
    public partial class Form1 : Form
    {
        SqlConnection myCon = new SqlConnection();
        DataSet dsUtil;
        public Form1()
        {
            
             
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            myCon.Open();
            dsUtil = new DataSet();

            SqlDataAdapter daUtil = new SqlDataAdapter("SELECT * FROM Utilizatori", myCon);
            daUtil.Fill(dsUtil, "Utilizatori");

            foreach (DataRow dr in dsUtil.Tables["Utilizatori"].Rows)
            {

                String name = dr.ItemArray.GetValue(1).ToString();
                String parola = dr.ItemArray.GetValue(2).ToString();
                if (textBox1.Text == name && textBox2.Text==parola)
                {
                    label3.Text = "Corect";
                    Form2_filme f = new Form2_filme();
                    f.Show();
                    //f.ShowDialog();
                    this.Hide();
                }
                else
                    label3.Text = "Incorect";
                label3.ForeColor = Color.FromArgb(255, 0, 0); 

            }

            myCon.Close();
        }
    }
}
