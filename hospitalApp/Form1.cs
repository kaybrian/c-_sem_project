using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospitalApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection("Data Source=.;Initial Catalog=sem2;User ID=sa;Password=sap");
                string query = "select * from hosiptalLogin where username = '" + username.Text.Trim() + "' and password = '" + userpassword.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    home homepage = new home();
                    this.Hide();
                    homepage.Show();

                }
                else
                {
                    MessageBox.Show("Hey,! sorry we cant log you in at this time, try checking your password or Username again to make sure its right ");
                    Form1 stat = new Form1();
                    this.Hide();
                    stat.Show();
                }
            }
                catch (Exception)
                {
                    register reg = new register();
                    this.Hide();
                    reg.Show();
                }
            }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            register reg = new register();
            this.Hide();
            reg.Show();
        }
    }
}
