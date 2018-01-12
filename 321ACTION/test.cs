using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;

namespace _321ACTION
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }
        private FilterInfoCollection videoDevice;
        private VideoCaptureDevice videoSource;
        Bitmap capture;

        private void test_Load(object sender, EventArgs e)
        {
            videoDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoSource = new VideoCaptureDevice(videoDevice[0].MonikerString);
            // set video resolution to 640*480
            videoSource.VideoResolution = videoSource.VideoCapabilities[0];
            videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
            videoSource.Start();
        }

        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = img;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            capture = new Bitmap(pictureBox1.Image, new Size(640, 480));
            Color p;
            for (int y = 0; y<480; y++ ) {
                for (int x = 0; x < 640; x++) {
                    p = capture.GetPixel(x, y);
                    int avg = (p.R + p.G + p.B) / 3;
                    if (avg > 170)
                    {
                        capture.SetPixel(x, y, Color.FromArgb(p.A, 255, 255, 255));
                        //avg = 255;
                    }
                    else
                    {
                        capture.SetPixel(x, y, Color.FromArgb(p.A, 0, 0, 0));
                    }
                }
            }
            pictureBox2.Image = capture;
            pictureBox2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
        }
    }
}
