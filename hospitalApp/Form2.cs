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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO patients(name,phone,gender,visit_date,symptom,starting,makes_better,caused,medicaton,medication_for) values (@name,@phone,@gender,@visit_date,@symptom,@starting,@makes_better,@caused,@medicaton,@medication_for)";
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
                        cmd.Parameters.AddWithValue("@symptom", symptoms.Text.Trim());
                        cmd.Parameters.AddWithValue("@starting", starting.Value);
                        cmd.Parameters.AddWithValue("@makes_better", makes_better.Text.Trim());
                        cmd.Parameters.AddWithValue("@caused", caused.Text.Trim());
                        cmd.Parameters.AddWithValue("@medicaton", medicaton.Text.Trim());
                        cmd.Parameters.AddWithValue("@medication_for", medication_for.Text.Trim());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("You have sucessfully added the patient to the data base. ");
                        Form2 new_pat = new Form2();
                        this.Hide();
                        new_pat.Show();
                    }

                }

            }
            catch (SqlException ex)
            {
                string msg = "Insert Error:";
                msg += ex.Message;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          /**  using (SqlConnection sqlcon = new SqlConnection("Data Source=.;Initial Catalog=sem2;User ID=sa;Password=sap"))
            {
                sqlcon.Open();
                SqlDataAdapter sqldata = new SqlDataAdapter("select * from patients", sqlcon);
                DataTable sqltable = new DataTable();
                sqldata.Fill(sqltable);

                current_patients.DataSource = sqltable;
            }**/
        }
    }
}
