using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
