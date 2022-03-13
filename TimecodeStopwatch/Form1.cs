using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimecodeStopwatch
{
    public partial class Form1 : Form
    {

        enum FR
        {
            fps24,
            fps30,
            fps60
        }
        public Form1()
        {
            InitializeComponent();
            _timer.Interval = 1;
            _timer.Tick += timer_Tick;
            _fps = FR.fps24;
        }

        Timer _timer = new Timer();
        TimeSpan _timeSpan = new TimeSpan(0);
        FR _fps;
        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan timeSpan = DateTime.Now - startDT + _timeSpan;
            var milliSec = 0;
            switch (_fps)
            {
                case FR.fps24:
                    milliSec = (timeSpan.Milliseconds * 24 / 1000);
                    break;
               case FR.fps30:
                    milliSec = (timeSpan.Milliseconds * 30 / 1000);
                    break;
               case FR.fps60: 
                    milliSec = (timeSpan.Milliseconds * 60 / 1000);
                    break;
            }
            timecode.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, milliSec);
        }

        DateTime startDT = DateTime.Now;

        private void start_Click(object sender, EventArgs e)
        {
            startDT = DateTime.Now;
            _timer.Start();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            _timeSpan += DateTime.Now - startDT;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            _timeSpan = new TimeSpan(0);
            startDT = DateTime.Now;
            timecode.Text = String.Format("00:00:00:00");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _timer.Stop();
            _timeSpan += DateTime.Now - startDT;
            _fps = FR.fps24;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            _timer.Stop();
            _timeSpan += DateTime.Now - startDT;
            _fps = FR.fps30;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            _timer.Stop();
            _timeSpan += DateTime.Now - startDT;
            _fps = FR.fps60;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Point mousePoint;

        private void Form1_MouseDown(object sender,
            System.Windows.Forms.MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                mousePoint = new Point(e.X, e.Y);
            }
        }

        private void Form1_MouseMove(object sender,
            System.Windows.Forms.MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Left += e.X - mousePoint.X;
                this.Top += e.Y - mousePoint.Y;
            }
        }
    }
}
