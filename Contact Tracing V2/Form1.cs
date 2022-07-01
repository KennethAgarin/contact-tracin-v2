using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonsubmit_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Your response have been submited");

            Application.Restart();

            StreamWriter file = new StreamWriter(@"C:\Users\DELL LATITUDE\Desktop\Contact Tracing new\contacttrace.txt", true);
            file.WriteLine("Date : " + dateTimePicker1.Text + " " + "Name: " + txtbox1stname.Text + " " + txtboxmi.Text + " " + txtboxsurname.Text + " " + "Address: " + txtboxstreet.Text + " " + txtboxbarangay.Text + " " + txtboxcity.Text + " " + "Contact: " + txtboxphonenum.Text + " " + txtboxemail.Text + " " + "Temperature: " + " " + txtboxtemp.Text);
            file.WriteLine(" ");
            file.Close();
        }

        private void restartbtn_Click(object sender, EventArgs e)
        {
           Form4 Form = new Form4();
            Form.ShowDialog();
        }

        private void Adminbtn_Click(object sender, EventArgs e)
        {
            String pas = txtpas.Text;
            if (pas == "KLA0719")
            {
                Form2 info = new Form2();
                info.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong password");
            }
        }

        private void cmBoxmonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmBoxday_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmBoxyear_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
