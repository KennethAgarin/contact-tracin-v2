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

        private VideoCaptureDevice FinalFrame;
        private FilterInfoCollection CaptureDevice;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
                cbDevice.Items.Add(Device.Name);
            cbDevice.SelectedIndex = 0;

            FinalFrame = new VideoCaptureDevice();
        }

        private void scanbtn_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[cbDevice.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
            timer1.Start();
            
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbQRcode.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning)
                FinalFrame.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           if (pbQRcode.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pbQRcode.Image);
                if (result != null)
                {
                    QRcodetxtbx.Text = result.ToString();
                    timer1.Stop();
                    if (FinalFrame.IsRunning)
                        FinalFrame.Stop();
                }
            }
        }

        private void generatebtn_Click(object sender, EventArgs e)
        {

        }

        private void QRcodetxtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void readbtn_Click(object sender, EventArgs e)
        {
            timer1.Start();

            MessageBox.Show("Data will be saved on contacttrace.txt");
            StreamWriter file = new StreamWriter(@"C:\Users\DELL LATITUDE\Desktop\Contact Tracing new\contacttrace.txt");
            file.WriteLine(QRcodetxtbx.Text);
            file.WriteLine(" ");
            file.Close();
        }
    }
}