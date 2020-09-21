namespace hospitalApp
{
    partial class register
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userusername = new System.Windows.Forms.TextBox();
            this.userpassword = new System.Windows.Forms.TextBox();
            this.userregister = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // userusername
            // 
            this.userusername.Location = new System.Drawing.Point(54, 57);
            this.userusername.Name = "userusername";
            this.userusername.Size = new System.Drawing.Size(243, 20);
            this.userusername.TabIndex = 1;
            // 
            // userpassword
            // 
            this.userpassword.AcceptsReturn = true;
            this.userpassword.Location = new System.Drawing.Point(54, 149);
            this.userpassword.Name = "userpassword";
            this.userpassword.PasswordChar = '*';
            this.userpassword.Size = new System.Drawing.Size(243, 20);
            this.userpassword.TabIndex = 2;
            // 
            // userregister
            // 
            this.userregister.Location = new System.Drawing.Point(54, 190);
            this.userregister.Name = "userregister";
            this.userregister.Size = new System.Drawing.Size(75, 23);
            this.userregister.TabIndex = 3;
            this.userregister.Text = "Register";
            this.userregister.UseVisualStyleBackColor = true;
            this.userregister.Click += new System.EventHandler(this.userregister_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(222, 190);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 4;
            this.login.Text = "Login ";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.login);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.userregister);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.userpassword);
            this.groupBox1.Controls.Add(this.userusername);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 255);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register Here";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hospitalApp.Properties.Resources.App_login;
            this.pictureBox1.Location = new System.Drawing.Point(440, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 179);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 338);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "register";
            this.Text = "Register Here";
            this.Load += new System.EventHandler(this.register_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userusername;
        private System.Windows.Forms.TextBox userpassword;
        private System.Windows.Forms.Button userregister;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}