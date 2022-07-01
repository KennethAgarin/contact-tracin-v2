using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge;
using AForge.Video.DirectShow;
using ZXing;
using System.IO;
using ZXing.Aztec;
using System.Drawing;

namespace Contact_Tracing_V2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cbDevice.Items.Add(filterInfo.Name);
            cbDevice.SelectedIndex = 0;
        }

        private void scanbtn_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cbDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();

           
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbQRcode.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbQRcode.Image != null)
            { 
            BarcodeReader barcode = new BarcodeReader();
            Result result = barcode.Decode((Bitmap)pbQRcode.Image);
            if (result != null)
            {
                QRcodetxtbx.Text = result.ToString();

                if (captureDevice.IsRunning)
                    captureDevice.Stop();
            }
            }
        }

        private void generatebtn_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.ShowDialog();

        }

        private void QRcodetxtbx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}