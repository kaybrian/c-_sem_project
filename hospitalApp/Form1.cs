using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
        public string Encrypts(string source, string key)
        {
            using (TripleDESCryptoServiceProvider tripledes = new TripleDESCryptoServiceProvider())
            {
                using (MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider())
                {
                    byte[] bt = hashmd5.ComputeHash(Encoding.UTF8.GetBytes(key));
                    tripledes.Key = bt;
                    tripledes.Mode = CipherMode.ECB;
                    byte[] data = Encoding.Unicode.GetBytes(source);
                    return Convert.ToBase64String(tripledes.CreateEncryptor().TransformFinalBlock(data, 0, data.Length));


                }
            }
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
            string userkey = "m23n4ff4gcw4fs4";
            try
            {
                string user_password = Encrypts(userpassword.Text, userkey);
                SqlConnection sqlcon = new SqlConnection("Data Source=.;Initial Catalog=sem2;User ID=sa;Password=sap");
                string query = "select * from hosiptalLogin where username = '" + username.Text.Trim() + "' and password = '" + user_password + "'";
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
