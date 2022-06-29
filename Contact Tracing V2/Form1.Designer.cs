namespace Contact_Tracing_V2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Adminbtn = new System.Windows.Forms.Button();
            this.txtpas = new System.Windows.Forms.TextBox();
            this.txtboxtemp = new System.Windows.Forms.TextBox();
            this.temp = new System.Windows.Forms.Label();
            this.restartbtn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonsubmit = new System.Windows.Forms.Button();
            this.txtboxemail = new System.Windows.Forms.TextBox();
            this.txtboxphonenum = new System.Windows.Forms.TextBox();
            this.txtboxcity = new System.Windows.Forms.TextBox();
            this.txtboxbarangay = new System.Windows.Forms.TextBox();
            this.txtboxstreet = new System.Windows.Forms.TextBox();
            this.txtboxsurname = new System.Windows.Forms.TextBox();
            this.txtboxmi = new System.Windows.Forms.TextBox();
            this.txtbox1stname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Template = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Template)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(446, 489);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Gray;
            this.label16.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(33, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 14);
            this.label16.TabIndex = 69;
            this.label16.Text = "Password:";
            // 
            // Adminbtn
            // 
            this.Adminbtn.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adminbtn.Location = new System.Drawing.Point(137, 21);
            this.Adminbtn.Name = "Adminbtn";
            this.Adminbtn.Size = new System.Drawing.Size(90, 20);
            this.Adminbtn.TabIndex = 68;
            this.Adminbtn.Text = "Admin";
            this.Adminbtn.UseVisualStyleBackColor = true;
            this.Adminbtn.Click += new System.EventHandler(this.Adminbtn_Click);
            // 
            // txtpas
            // 
            this.txtpas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtpas.Location = new System.Drawing.Point(31, 21);
            this.txtpas.Name = "txtpas";
            this.txtpas.Size = new System.Drawing.Size(104, 20);
            this.txtpas.TabIndex = 67;
            this.txtpas.Tag = "Password";
            // 
            // txtboxtemp
            // 
            this.txtboxtemp.Location = new System.Drawing.Point(152, 400);
            this.txtboxtemp.Name = "txtboxtemp";
            this.txtboxtemp.Size = new System.Drawing.Size(143, 20);
            this.txtboxtemp.TabIndex = 66;
            // 
            // temp
            // 
            this.temp.AutoSize = true;
            this.temp.BackColor = System.Drawing.SystemColors.GrayText;
            this.temp.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp.ForeColor = System.Drawing.Color.Cornsilk;
            this.temp.Location = new System.Drawing.Point(134, 384);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(179, 15);
            this.temp.TabIndex = 65;
            this.temp.Text = "Temperature (in Celcius):";
            // 
            // restartbtn
            // 
            this.restartbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.restartbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartbtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.restartbtn.Location = new System.Drawing.Point(31, 426);
            this.restartbtn.Name = "restartbtn";
            this.restartbtn.Size = new System.Drawing.Size(180, 37);
            this.restartbtn.TabIndex = 64;
            this.restartbtn.Text = "Restart";
            this.restartbtn.UseVisualStyleBackColor = false;
            this.restartbtn.Click += new System.EventHandler(this.restartbtn_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.DimGray;
            this.label15.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(273, 67);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 29);
            this.label15.TabIndex = 63;
            this.label15.Text = "FORM";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.DimGray;
            this.label14.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(240, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(179, 19);
            this.label14.TabIndex = 62;
            this.label14.Text = "CONTACT TRACING";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.DimGray;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(235, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(191, 15);
            this.label13.TabIndex = 61;
            this.label13.Text = "AGARIN\'S SARI-SARI STORE";
            // 
            // buttonsubmit
            // 
            this.buttonsubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsubmit.ForeColor = System.Drawing.Color.Cornsilk;
            this.buttonsubmit.Location = new System.Drawing.Point(217, 426);
            this.buttonsubmit.Name = "buttonsubmit";
            this.buttonsubmit.Size = new System.Drawing.Size(192, 37);
            this.buttonsubmit.TabIndex = 60;
            this.buttonsubmit.Text = "Submit";
            this.buttonsubmit.UseVisualStyleBackColor = false;
            this.buttonsubmit.Click += new System.EventHandler(this.buttonsubmit_Click);
            // 
            // txtboxemail
            // 
            this.txtboxemail.Location = new System.Drawing.Point(201, 337);
            this.txtboxemail.Name = "txtboxemail";
            this.txtboxemail.Size = new System.Drawing.Size(198, 20);
            this.txtboxemail.TabIndex = 59;
            // 
            // txtboxphonenum
            // 
            this.txtboxphonenum.Location = new System.Drawing.Point(38, 337);
            this.txtboxphonenum.Name = "txtboxphonenum";
            this.txtboxphonenum.Size = new System.Drawing.Size(143, 20);
            this.txtboxphonenum.TabIndex = 58;
            // 
            // txtboxcity
            // 
            this.txtboxcity.Location = new System.Drawing.Point(275, 244);
            this.txtboxcity.Name = "txtboxcity";
            this.txtboxcity.Size = new System.Drawing.Size(124, 20);
            this.txtboxcity.TabIndex = 57;
            // 
            // txtboxbarangay
            // 
            this.txtboxbarangay.Location = new System.Drawing.Point(156, 244);
            this.txtboxbarangay.Name = "txtboxbarangay";
            this.txtboxbarangay.Size = new System.Drawing.Size(115, 20);
            this.txtboxbarangay.TabIndex = 56;
            // 
            // txtboxstreet
            // 
            this.txtboxstreet.Location = new System.Drawing.Point(38, 244);
            this.txtboxstreet.Name = "txtboxstreet";
            this.txtboxstreet.Size = new System.Drawing.Size(112, 20);
            this.txtboxstreet.TabIndex = 55;
            // 
            // txtboxsurname
            // 
            this.txtboxsurname.Location = new System.Drawing.Point(238, 150);
            this.txtboxsurname.Name = "txtboxsurname";
            this.txtboxsurname.Size = new System.Drawing.Size(161, 20);
            this.txtboxsurname.TabIndex = 54;
            // 
            // txtboxmi
            // 
            this.txtboxmi.Location = new System.Drawing.Point(203, 150);
            this.txtboxmi.Name = "txtboxmi";
            this.txtboxmi.Size = new System.Drawing.Size(29, 20);
            this.txtboxmi.TabIndex = 53;
            // 
            // txtbox1stname
            // 
            this.txtbox1stname.Location = new System.Drawing.Point(38, 150);
            this.txtbox1stname.Name = "txtbox1stname";
            this.txtbox1stname.Size = new System.Drawing.Size(162, 20);
            this.txtbox1stname.TabIndex = 52;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(200, 314);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 14);
            this.label12.TabIndex = 51;
            this.label12.Text = "Email:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(41, 315);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 14);
            this.label11.TabIndex = 50;
            this.label11.Text = "Phone Number:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(275, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 14);
            this.label10.TabIndex = 49;
            this.label10.Text = "City, Province:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(157, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 14);
            this.label9.TabIndex = 48;
            this.label9.Text = "Barangay:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 14);
            this.label8.TabIndex = 47;
            this.label8.Text = "Street:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(238, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 14);
            this.label7.TabIndex = 46;
            this.label7.Text = "Surname:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(203, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 14);
            this.label6.TabIndex = 45;
            this.label6.Text = "M.I.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 14);
            this.label5.TabIndex = 44;
            this.label5.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GrayText;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(38, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 43;
            this.label4.Text = "Contact:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GrayText;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(38, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GrayText;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(38, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GrayText;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(35, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "Date:";
            // 
            // Template
            // 
            this.Template.BackColor = System.Drawing.Color.Transparent;
            this.Template.Image = ((System.Drawing.Image)(resources.GetObject("Template.Image")));
            this.Template.Location = new System.Drawing.Point(-1, -2);
            this.Template.Name = "Template";
            this.Template.Size = new System.Drawing.Size(444, 477);
            this.Template.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Template.TabIndex = 39;
            this.Template.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "mm-dd-yy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(41, 67);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 20);
            this.dateTimePicker1.TabIndex = 70;
            this.dateTimePicker1.Value = new System.DateTime(2022, 6, 29, 12, 46, 36, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 472);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Adminbtn);
            this.Controls.Add(this.txtpas);
            this.Controls.Add(this.txtboxtemp);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.restartbtn);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonsubmit);
            this.Controls.Add(this.txtboxemail);
            this.Controls.Add(this.txtboxphonenum);
            this.Controls.Add(this.txtboxcity);
            this.Controls.Add(this.txtboxbarangay);
            this.Controls.Add(this.txtboxstreet);
            this.Controls.Add(this.txtboxsurname);
            this.Controls.Add(this.txtboxmi);
            this.Controls.Add(this.txtbox1stname);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Template);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Template)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button Adminbtn;
        private System.Windows.Forms.TextBox txtpas;
        private System.Windows.Forms.TextBox txtboxtemp;
        private System.Windows.Forms.Label temp;
        private System.Windows.Forms.Button restartbtn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonsubmit;
        private System.Windows.Forms.TextBox txtboxemail;
        private System.Windows.Forms.TextBox txtboxphonenum;
        private System.Windows.Forms.TextBox txtboxcity;
        private System.Windows.Forms.TextBox txtboxbarangay;
        private System.Windows.Forms.TextBox txtboxstreet;
        private System.Windows.Forms.TextBox txtboxsurname;
        private System.Windows.Forms.TextBox txtboxmi;
        private System.Windows.Forms.TextBox txtbox1stname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Template;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

