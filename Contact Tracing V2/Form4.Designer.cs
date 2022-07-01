namespace Contact_Tracing_V2
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.pbQRcode = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scanbtn = new System.Windows.Forms.Button();
            this.cbDevice = new System.Windows.Forms.ComboBox();
            this.QRcodetxtbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.generatebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRcode)).BeginInit();
            this.SuspendLayout();
            // 
            // pbQRcode
            // 
            this.pbQRcode.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbQRcode.Location = new System.Drawing.Point(32, 104);
            this.pbQRcode.Name = "pbQRcode";
            this.pbQRcode.Size = new System.Drawing.Size(277, 278);
            this.pbQRcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbQRcode.TabIndex = 0;
            this.pbQRcode.TabStop = false;
            this.pbQRcode.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "CAMERA:";
            // 
            // scanbtn
            // 
            this.scanbtn.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanbtn.Location = new System.Drawing.Point(315, 104);
            this.scanbtn.Name = "scanbtn";
            this.scanbtn.Size = new System.Drawing.Size(75, 23);
            this.scanbtn.TabIndex = 2;
            this.scanbtn.Text = "Start Scan";
            this.scanbtn.UseVisualStyleBackColor = true;
            this.scanbtn.Click += new System.EventHandler(this.scanbtn_Click);
            // 
            // cbDevice
            // 
            this.cbDevice.FormattingEnabled = true;
            this.cbDevice.Location = new System.Drawing.Point(116, 63);
            this.cbDevice.Name = "cbDevice";
            this.cbDevice.Size = new System.Drawing.Size(121, 21);
            this.cbDevice.TabIndex = 3;
            // 
            // QRcodetxtbx
            // 
            this.QRcodetxtbx.Location = new System.Drawing.Point(315, 162);
            this.QRcodetxtbx.Multiline = true;
            this.QRcodetxtbx.Name = "QRcodetxtbx";
            this.QRcodetxtbx.Size = new System.Drawing.Size(160, 160);
            this.QRcodetxtbx.TabIndex = 4;
            this.QRcodetxtbx.TextChanged += new System.EventHandler(this.QRcodetxtbx_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Generate and Scan your QR Codes ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // generatebtn
            // 
            this.generatebtn.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatebtn.Location = new System.Drawing.Point(315, 133);
            this.generatebtn.Name = "generatebtn";
            this.generatebtn.Size = new System.Drawing.Size(75, 23);
            this.generatebtn.TabIndex = 6;
            this.generatebtn.Text = "Generate";
            this.generatebtn.UseVisualStyleBackColor = true;
            this.generatebtn.Click += new System.EventHandler(this.generatebtn_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(513, 394);
            this.Controls.Add(this.generatebtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QRcodetxtbx);
            this.Controls.Add(this.cbDevice);
            this.Controls.Add(this.scanbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbQRcode);
            this.Name = "Form4";
            this.Text = "Generate QR Code";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbQRcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbQRcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button scanbtn;
        private System.Windows.Forms.ComboBox cbDevice;
        private System.Windows.Forms.TextBox QRcodetxtbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button generatebtn;
    }
}