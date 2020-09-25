namespace hospitalApp
{
    partial class patients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.patient_records = new System.Windows.Forms.Button();
            this.patient = new System.Windows.Forms.Button();
            this.appointment = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.current_patients = new System.Windows.Forms.DataGridView();
            this.results = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.current_patients)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.patient_records);
            this.groupBox1.Controls.Add(this.patient);
            this.groupBox1.Controls.Add(this.appointment);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(27, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 406);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Action";
            // 
            // patient_records
            // 
            this.patient_records.Location = new System.Drawing.Point(53, 282);
            this.patient_records.Name = "patient_records";
            this.patient_records.Size = new System.Drawing.Size(155, 23);
            this.patient_records.TabIndex = 1;
            this.patient_records.Text = "See paitent Records";
            this.patient_records.UseVisualStyleBackColor = true;
            this.patient_records.Click += new System.EventHandler(this.patient_records_Click);
            // 
            // patient
            // 
            this.patient.Location = new System.Drawing.Point(53, 253);
            this.patient.Name = "patient";
            this.patient.Size = new System.Drawing.Size(155, 23);
            this.patient.TabIndex = 1;
            this.patient.Text = "Add a patient";
            this.patient.UseVisualStyleBackColor = true;
            this.patient.Click += new System.EventHandler(this.patient_Click);
            // 
            // appointment
            // 
            this.appointment.Location = new System.Drawing.Point(53, 224);
            this.appointment.Name = "appointment";
            this.appointment.Size = new System.Drawing.Size(155, 23);
            this.appointment.TabIndex = 1;
            this.appointment.Text = "Set Appointment";
            this.appointment.UseVisualStyleBackColor = true;
            this.appointment.Click += new System.EventHandler(this.appointment_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hospitalApp.Properties.Resources.hospital;
            this.pictureBox1.Location = new System.Drawing.Point(53, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.current_patients);
            this.groupBox2.Location = new System.Drawing.Point(334, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 372);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patient Records";
            // 
            // current_patients
            // 
            this.current_patients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.current_patients.Location = new System.Drawing.Point(6, 19);
            this.current_patients.Name = "current_patients";
            this.current_patients.Size = new System.Drawing.Size(584, 330);
            this.current_patients.TabIndex = 0;
            this.current_patients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // results
            // 
            this.results.Location = new System.Drawing.Point(340, 47);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(130, 23);
            this.results.TabIndex = 3;
            this.results.Text = "See Patient Results";
            this.results.UseVisualStyleBackColor = true;
            this.results.Click += new System.EventHandler(this.results_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(540, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Export As pdf";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.results);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "patients";
            this.Text = "patients";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.current_patients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button patient_records;
        private System.Windows.Forms.Button patient;
        private System.Windows.Forms.Button appointment;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView current_patients;
        private System.Windows.Forms.Button results;
        private System.Windows.Forms.Button button1;
    }
}