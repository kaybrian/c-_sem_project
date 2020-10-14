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
    public partial class register : Form
    {
        public register()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userregister_Click(object sender, EventArgs e)
        {
            string userkey = "m23n4ff4gcw4fs4";
            try
            {
                
                string sql = "INSERT INTO hosiptalLogin (username,password) values (@username,@password)";
                using (SqlConnection sqlcon = new SqlConnection("Data Source=.;Initial Catalog=sem2;User ID=sa;Password=sap"))
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, sqlcon))
                    {
                        if (userusername.Text != null && userpassword.Text != null)
                        {
                            string user_password = Encrypts(userpassword.Text, userkey);
                            cmd.Parameters.AddWithValue("@username", userusername.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", user_password);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Hey " + userusername.Text.Trim() + " you have successfully been registered, Login in to Continue");
                            Form1 login = new Form1();
                            this.Hide();
                            login.Show();

                            
                        }
                        else
                        {
                            MessageBox.Show("Please Fill in the Required fields to Continue");
                            register reg = new register();
                            this.Hide();
                            reg.Show();
                        }

                    }
                }
            }
            catch (SqlException ex)
            {
                string msg = "Insert Error:";
                msg += ex.Message;
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.Show();
        }

        private void register_Load(object sender, EventArgs e)
        {

        }
    }
}
