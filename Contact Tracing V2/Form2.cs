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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            string month = dateTimePicker1.Text;
            string day = dateTimePicker1.Text;
            string year = dateTimePicker1.Text;

            try
            {
                StreamReader Visitors = new StreamReader(@"C:\Users\DELL LATITUDE\Desktop\Contact Tracing new\" + (month) + " " + (day) + " " + (year) + "contacttrace.txt");
                MessageBox.Show(Visitors.ReadToEnd());
                Visitors.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No visitors on this date.");
            }

        }
    }
}
