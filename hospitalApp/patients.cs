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
    public partial class patients : Form
    {
        public patients()
        {
            InitializeComponent();

        }

        private void patient_records_Click(object sender, EventArgs e)
        {
            patients appt = new patients();
            this.Hide();
            appt.Show();
        }

        private void patient_Click(object sender, EventArgs e)
        {
            Form2 seepat = new Form2();
            this.Hide();
            seepat.Show();
        }

        private void appointment_Click(object sender, EventArgs e)
        {
            appointment pat = new appointment();
            this.Hide();
            pat.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void results_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection("Data Source=.;Initial Catalog=sem2;User ID=sa;Password=sap"))
            {
                sqlcon.Open();
                SqlDataAdapter sqldata = new SqlDataAdapter("select * from patients", sqlcon);
                DataTable sqltable = new DataTable();
                sqldata.Fill(sqltable);

                current_patients.DataSource = sqltable;
            }
        }
    }
}
