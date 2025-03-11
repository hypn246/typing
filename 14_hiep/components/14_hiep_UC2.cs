using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hiep_14_typing_speed.components
{
    public partial class _14_hiep_UC2 : UserControl
    {
        List<string> list = new List<string>();
        string s1 = @"""You must be very patient,"" replied the fox. ""First you will sit down at a little distance from me like that in the grass. I shall look at you out of the corner of my eye, and you will say nothing. Words are the source of misunderstandings. ";
        string s2 = @"But you will sit a little closer to me, every day ""\n The next day the little prince came back.\n ""It would have been better to come back at the same hour,"" said the fox. ";
        string s3 = @"""If, for example, you come at four o'clock in the afternoon, then at three o'clock I shall begin to be happy. I shall feel happier and happier as the hour advances. At four o'clock, I shall already be worrying and jumping about. ";
        string s4 = @"I shall show you how happy I am! But if you come at just any time, I shall never know at what hour my heart is to be ready to greet you... One must observe the proper rites...""";
        int sec = 59;
        bool isStart = true;
        double accuracy;
        double wpm;
        int word = 0;
        int count = 0;
        string key;
        int p = 0;
        public _14_hiep_UC2()
        {
            InitializeComponent();
            list.Add(s1);
            list.Add(s2);
            list.Add(s3);
            list.Add(s4);
            hiep_14_lb1.Text = list[this.p];
            hiep_14_timer1.Stop();
            hiep_14_time.Text = "1:00";
            hiep_14_lbRatio.Text = "";
        }

        private void hiep_14_btn1_check(object sender, KeyEventArgs e)
        {
            //count all key press
            //time start here
            if (isStart)
            {
                hiep_14_timer1.Start();
                isStart = false;
            }
            else if (e.KeyCode == Keys.Shift) { }
            else if (e.KeyCode == Keys.Enter)
            {
                p++;
                if (p > 3){
                    sec = 0;
                    return;
                }else
                    hiep_14_lb1.Text = list[p];
            }
            else
                count++;
        }
        private void hiep_14_cal()
        {
            string[] quest=hiep_14_lb1.Text.Split(' ');
            string[] current=hiep_14_txt1.Text.Split(' ');
            for(int i=0; i < current.Length; i++)
            {
                if (current[i].Equals(quest[i]))
                {
                    this.key += current[i];
                    this.word++;
                }
            }
        }

        private void hiep_14_btn1_Click(object sender, EventArgs e)
        {
            hiep_14_txt1.Text = "";
            hiep_14_lbRatio.Text = "";
            isStart = true;
            hiep_14_time.Text = "1:00";
            sec = 59;
            hiep_14_txt1.Enabled = true;
            hiep_14_timer1.Stop();
            word = 0;
            count = 0;
            key = "";
            wpm = 0;
            accuracy = 0;
        }

        private void hiep_14_btn2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void hiep_14_timer1_Tick(object sender, EventArgs e)
        {
            {
                if (sec < 0)
                {
                    hiep_14_timer1.Stop();
                    hiep_14_txt1.Enabled = false;
                    //here
                    hiep_14_cal();
                    wpm = (this.count / 5);
                    accuracy = (this.key.Length) * 100 / (this.count-word);
                    hiep_14_lbRatio.Text = string.Format("WPM: {0:F1}\nAccuracy: {1:F2}%", this.wpm, this.accuracy);
                }
                else if (sec < 10)
                    hiep_14_time.Text = "0:0" + sec--.ToString();
                else
                    hiep_14_time.Text = "0:" + sec--.ToString();
            }
        }
    }
}
