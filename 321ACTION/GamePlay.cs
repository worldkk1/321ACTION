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
    public partial class GamePlay : Form
    {
        public GamePlay()
        {
            InitializeComponent();
        }
        // GLOBAL VARAIBLE
        //public static int score = 0;
        //int start_sec = 4, play_sec = 6, round = 1;
        //int index_question = 1;
        public static int score;
        int start_sec, play_sec, round;
        int index_question;
        Bitmap label;
        Bitmap img_question = new Bitmap("img/Easy/show/1.png");
        Bitmap img_compare = new Bitmap("img/Easy/compare/1.jpg");
        Bitmap img_capture;
        Bitmap img_prepare = new Bitmap("img/UI/prepare.png");
        //Bitmap img_capture = new Bitmap("img/Easy/compare/1.jpg");
        private FilterInfoCollection videoDevice;
        private VideoCaptureDevice videoSource;
        
        

        private void GamePlay_Load(object sender, EventArgs e)
        {
            videoDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoSource = new VideoCaptureDevice(videoDevice[0].MonikerString);
            // set video resolution to 640*480
            videoSource.VideoResolution = videoSource.VideoCapabilities[0];
            videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
            videoSource.Start();

            pb_motion.Controls.Add(pb_question);
            pb_question.Location = new System.Drawing.Point(0, 0);
            //pb_question.Image = img_question;
            pb_question.BackColor = Color.Transparent;

            label_time.Parent = pb_question;
            label_time.BackColor = Color.Transparent;
            label_round.Parent = pb_question;
            label_round.BackColor = Color.Transparent;
            label_score.Parent = pb_question;
            label_score.BackColor = Color.Transparent;
            label_setup.Parent = pb_question;
            label_setup.BackColor = Color.Transparent;

            pb_question.Image = img_prepare;
            pb_question.Visible = true;
            pb_motion.Visible = true;
            start_label.Visible = false;
        }

        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
            pb_motion.Image = img;
        }

        private void time_start_Tick(object sender, EventArgs e)
        {
            if (start_sec == 0)
            {
                time_start.Enabled = false;
                start_label.Visible = false;
                pb_motion.Visible = true;
                pb_question.Visible = true;
                time_play.Enabled = true;
                label_round.Visible = true;
                label_score.Visible = true;
                label_time.Visible = true;
            }
            else {
                start_sec--;
                label = new Bitmap("img/label/" + start_sec + ".jpg");
                start_label.Image = label;
            }
        }

        public void Compare() {
            img_capture = new Bitmap(pb_motion.Image);
            //img_capture = new Bitmap("img/Easy/compare/1.jpg");
            //img_capture = new Bitmap(img_capture, new Size(640, 480));
            img_compare = new Bitmap(img_compare, new Size(640, 480));
            img_capture = new Bitmap(img_capture, new Size(640, 480));
            Color cCapture, cCompare;
            int size = 0, match = 0;
            for (int y = 0; y < 480; y++)
            {
                for (int x = 0; x < 640; x++)
                {
                    cCapture = img_capture.GetPixel(x, y);
                    cCompare = img_compare.GetPixel(x, y);

                    int avgCapture = (cCapture.R + cCapture.G + cCapture.B) / 3;
                    int avgCompare = (cCompare.R + cCompare.G + cCompare.B) / 3;

                    if (avgCompare > 170)
                    {
                        avgCompare = 255;
                        size++;
                    }

                    //if (avgCapture < 50)
                    //{
                    //    img_capture.SetPixel(x, y, Color.FromArgb(cCapture.A, 255, 255, 255));
                    //    avgCapture = 255;
                    //}
                    if (avgCapture > 170)
                    {
                        //img_capture.SetPixel(x, y, Color.FromArgb(cCapture.A, 255, 255, 255));
                        avgCapture = 255;
                    }
                    else
                    {
                        //img_capture.SetPixel(x, y, Color.FromArgb(cCapture.A, 0, 0, 0));
                    }

                    if (avgCompare == 255 && avgCompare == avgCapture)
                    {
                        match++;
                    }
                }
            }
            int result = (match * 100) / size;
            //MessageBox.Show("result: " + result + ", match: " + match + ", size" + size);
            label1.Text = "result: " + result + ", match: " + match + ", size" + size;
            if (result > 50)
            {
                //MessageBox.Show("true");
                score = score + 10;
                label_score.Text = "score: " + score;
            }
            else
            {
                //MessageBox.Show("false");
            }
        }

        public void Change(int index)
        {
            //img_capture = new Bitmap("img/Easy/compare/" + index + ".jpg");
            img_compare = new Bitmap("img/Easy/compare/" + index + ".jpg");
            img_question = new Bitmap("img/Easy/show/" + index + ".png");
            pb_question.Image = img_question;
            //pictureBox4.Image = img_capture;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index_question++;
            Change(index_question);
            pb_question.Image = img_question;
        }

        private void time_play_Tick(object sender, EventArgs e)
        {
            if (play_sec == 0)
            {
                Compare();
                round++;
                if (round < 6)
                {
                    play_sec = 6;
                    //round++;
                    //index_question++;
                    Change(round);
                    label_round.Text = "round: " + round.ToString();
                }
                else if (round > 5 && round < 10)
                {
                    play_sec = 5;
                    //index_question++;
                    Change(round);
                    label_round.Text = "round: " + round.ToString();
                }
                else if (round == 10)
                {
                    play_sec = 4;
                    Change(round);
                    label_round.Text = "round: " + round.ToString();
                }
                else if (round > 10)
                {
                    time_play.Enabled = false;
                    ShowScore ss = new ShowScore();
                    ss.Show();
                    //this.Close();
                    this.Hide();
                    pb_question.Image = img_prepare;
                    label_round.Visible = false;
                    label_score.Visible = false;
                    label_time.Visible = false;
                    label_setup.Visible = true;
                    btn_go.Visible = true;
                }
            }
            else
            {
                play_sec--;
                label_time.Text = "Time: " + play_sec;
            }
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            score = 0;
            round = 1;
            start_sec = 4;
            play_sec = 6;
            index_question = 1;
            label_round.Text = "round: 1";
            label_time.Text = "time: 5";
            label_score.Text = "score: 0";

            pb_motion.Visible = false;
            pb_question.Visible = false;
            pb_question.Image = img_question;
            label_setup.Visible = false;
            btn_go.Visible = false;
            start_label.Visible = true;
            time_start.Enabled = true;
            start_label.Image = new Bitmap("img/label/ready.jpg");
        }
    }
}
