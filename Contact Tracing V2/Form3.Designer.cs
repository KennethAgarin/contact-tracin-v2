namespace Contact_Tracing_V2
{
    partial class Form3
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
            this.dglbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dglbl
            // 
            this.dglbl.AutoSize = true;
            this.dglbl.Location = new System.Drawing.Point(12, 9);
            this.dglbl.Name = "dglbl";
            this.dglbl.Size = new System.Drawing.Size(35, 13);
            this.dglbl.TabIndex = 0;
            this.dglbl.Text = "label1";
            this.dglbl.Click += new System.EventHandler(this.dglbl_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 204);
            this.Controls.Add(this.dglbl);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dglbl;
    }
}