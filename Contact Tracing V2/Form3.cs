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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            StreamReader reader = new StreamReader(@"C:\Users\DELL LATITUDE\Desktop\Contact Tracing new\contacttracevisitors.txt");
            string all = reader.ReadToEnd();
            MessageBox.Show(all);
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dglbl_Click(object sender, EventArgs e)
        {

        }
    }
}
