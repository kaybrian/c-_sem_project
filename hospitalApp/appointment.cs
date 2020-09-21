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
    }
}
