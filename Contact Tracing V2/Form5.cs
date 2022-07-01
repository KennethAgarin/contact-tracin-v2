using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace Contact_Tracing_V2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void generatebtn_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator QR = new QRCoder.QRCodeGenerator();
            var MyData = QR.CreateQrCode(QRcodetxtbx.Text, QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(MyData);
            pbQRcode.Image = code.GetGraphic(5);

        }
    }
}
