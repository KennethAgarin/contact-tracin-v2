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
            StreamReader reader = new StreamReader(@"C:\Users\DELL LATITUDE\Desktop\Contact Tracing new\contacttrace.txt");
            List<string> dates = new List<string>();

            string InfoDate = datepickerform2.Text;
            int countDate = 0;

            while(!reader.EndOfStream)
            {
                string datesdata = reader.ReadLine();
                if (datesdata.Contains(InfoDate))
                {
                    countDate++;

                    dates.Add(datesdata);
                }
            }
            if (countDate == 0)
            {
                MessageBox.Show("No visitors on this date.");
                reader.Close();
            }
            else
            {
                reader.Close();
                StreamWriter file = new StreamWriter(@"C:\Users\DELL LATITUDE\Desktop\Contact Tracing new\contacttracevisitors.txt");
                foreach (string datesdata in dates)
                {
                    file.WriteLine(datesdata);
                }
                MessageBox.Show("Found: " + countDate.ToString() + " data needed");

                file.Close();


            }

        }

        private void cmBoxyear_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmBoxday_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmBoxmonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
