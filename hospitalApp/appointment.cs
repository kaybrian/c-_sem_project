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
    public partial class appointment : Form
    {
        public appointment()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void patient_Click(object sender, EventArgs e)
        {
            Form2 pat = new Form2();
            this.Hide();
            pat.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            appointment appt = new appointment();
            this.Hide();
            appt.Show();
        }

        private void patient_records_Click(object sender, EventArgs e)
        {
            patients seepat = new patients();
            this.Hide();
            seepat.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO appointment (name,phone,gender,visit_date) values (@name,@phone,@gender,@visit_date)";
                using (SqlConnection sqlcon = new SqlConnection("Data Source=.;Initial Catalog=sem2;User ID=sa;Password=sap"))
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, sqlcon))
                    {
                        cmd.Parameters.AddWithValue("@name", name.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", phone.Text.Trim());
                        cmd.Parameters.AddWithValue("@visit_date", visit_date.Value);
                        string gender_value = "";
                        bool isChecked = radioButton1.Checked;
                        if (isChecked)
                            gender_value = radioButton1.Text;
                        else
                            gender_value = radioButton2.Text;

                        cmd.Parameters.AddWithValue("@gender", gender_value);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("You have successfully added the patient appointment to the database");
                        appointment appt = new appointment();
                        this.Hide();
                        appt.Show();
                    }
                }
            }
            catch (SqlException ex)
            {
                string msg = "Insert Error:";
                msg += ex.Message;
            }
        }
    }
}
