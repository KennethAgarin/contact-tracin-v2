namespace Contact_Tracing_V2
{
    partial class Form5
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
            this.QRcodetxtbx = new System.Windows.Forms.TextBox();
            this.generatebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbQRcode = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRcode)).BeginInit();
            this.SuspendLayout();
            // 
            // QRcodetxtbx
            // 
            this.QRcodetxtbx.Location = new System.Drawing.Point(322, 27);
            this.QRcodetxtbx.Multiline = true;
            this.QRcodetxtbx.Name = "QRcodetxtbx";
            this.QRcodetxtbx.Size = new System.Drawing.Size(160, 151);
            this.QRcodetxtbx.TabIndex = 9;
            this.QRcodetxtbx.TextChanged += new System.EventHandler(this.QRcodetxtbx_TextChanged);
            // 
            // generatebtn
            // 
            this.generatebtn.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatebtn.Location = new System.Drawing.Point(364, 184);
            this.generatebtn.Name = "generatebtn";
            this.generatebtn.Size = new System.Drawing.Size(75, 23);
            this.generatebtn.TabIndex = 7;
            this.generatebtn.Text = "Generate";
            this.generatebtn.UseVisualStyleBackColor = true;
            this.generatebtn.Click += new System.EventHandler(this.generatebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "QR CODE:";
            // 
            // pbQRcode
            // 
            this.pbQRcode.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbQRcode.Location = new System.Drawing.Point(27, 27);
            this.pbQRcode.Name = "pbQRcode";
            this.pbQRcode.Size = new System.Drawing.Size(277, 278);
            this.pbQRcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbQRcode.TabIndex = 5;
            this.pbQRcode.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Note: Ths QR Code will be your easy access on entering your data. Thank You.";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(497, 356);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QRcodetxtbx);
            this.Controls.Add(this.generatebtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbQRcode);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.pbQRcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QRcodetxtbx;
        private System.Windows.Forms.Button generatebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbQRcode;
        private System.Windows.Forms.Label label2;
    }
}