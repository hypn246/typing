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
        List<string> hiep_14_list = new List<string>();
        string hiep_14_s1 = @"""You must be very patient,"" replied the fox. ""First you will sit down at a little distance from me like that in the grass. I shall look at you out of the corner of my eye, and you will say nothing. Words are the source of misunderstandings. ";
        string hiep_14_s2 = @"But you will sit a little closer to me, every day ""\n The next day the little prince came back.\n ""It would have been better to come back at the same hour,"" said the fox. ";
        string hiep_14_s3 = @"""If, for example, you come at four o'clock in the afternoon, then at three o'clock I shall begin to be happy. I shall feel happier and happier as the hour advances. At four o'clock, I shall already be worrying and jumping about. ";
        string hiep_14_s4 = @"I shall show you how happy I am! But if you come at just any time, I shall never know at what hour my heart is to be ready to greet you... One must observe the proper rites...""";
        int hiep_14_sec = 59;
        bool hiep_14_isStart = true;
        double hiep_14_accuracy;
        double hiep_14_wpm;
        int hiep_14_word = 0;
        int hiep_14_count = 0;
        string hiep_14_key;
        int hiep_14_p = 0;
        public _14_hiep_UC2()
        {
            InitializeComponent();
            hiep_14_list.Add(hiep_14_s1);
            hiep_14_list.Add(hiep_14_s2);
            hiep_14_list.Add(hiep_14_s3);
            hiep_14_list.Add(hiep_14_s4);
            hiep_14_lb1.Text = hiep_14_list[this.hiep_14_p];
            hiep_14_timer1.Stop();
            hiep_14_time.Text = "1:00";
            hiep_14_lbRatio.Text = "";
            this.ActiveControl = hiep_14_txt1;
        }

        private void hiep_14_txt_check(object sender, KeyEventArgs hiep_14_e)
        {
            //time start here
            if (hiep_14_isStart)
            {
                hiep_14_timer1.Start();
                hiep_14_isStart = false;
            }
            //hiep_14_soKTND all hiep_14_chuoiDe press
            if (hiep_14_e.KeyCode == Keys.Shift) { }
            else if (hiep_14_e.KeyCode == Keys.Enter)
            {
                hiep_14_p++;
                if (hiep_14_p > 3){
                    hiep_14_sec = 0;
                    return;
                }else
                    hiep_14_lb1.Text = hiep_14_list[hiep_14_p];
            }
            else
                hiep_14_count++;
        }
        private void hiep_14_cal()
        {
            string[] hiep_14_quest=hiep_14_lb1.Text.Split(' ');
            string[] hiep_14_current=hiep_14_txt1.Text.Split(' ');
            for(int hiep_14_i=0; hiep_14_i < hiep_14_current.Length; hiep_14_i++)
            {
                if (hiep_14_current[hiep_14_i].Equals(hiep_14_quest[hiep_14_i]))
                {
                    this.hiep_14_key += hiep_14_current[hiep_14_i];
                    this.hiep_14_word++;
                }
            }
        }

        private void hiep_14_btn1_Click(object sender, EventArgs e)
        {
            hiep_14_txt1.Text = "";
            hiep_14_lbRatio.Text = "";
            hiep_14_isStart = true;
            hiep_14_time.Text = "1:00";
            hiep_14_sec = 59;
            hiep_14_txt1.Enabled = true;
            hiep_14_timer1.Stop();
            hiep_14_word = 0;
            hiep_14_count = 0;
            hiep_14_key = "";
            hiep_14_wpm = 0;
            hiep_14_accuracy = 0;
            this.ActiveControl = hiep_14_txt1;
        }

        private void hiep_14_btn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            hiep_14_txt1.Text = "";
            hiep_14_lbRatio.Text = "";
            hiep_14_isStart = true;
            hiep_14_time.Text = "1:00";
            hiep_14_sec = 59;
            hiep_14_txt1.Enabled = true;
            hiep_14_timer1.Stop();
            hiep_14_word = 0;
            hiep_14_count = 0;
            hiep_14_key = "";
            hiep_14_wpm = 0;
            hiep_14_accuracy = 0;
            this.ActiveControl = hiep_14_txt1;
        }

        private void hiep_14_timer1_Tick(object sender, EventArgs e)
        {
            if (hiep_14_sec < 0)
            {
                hiep_14_timer1.Stop();
                hiep_14_txt1.Enabled = false;
                //here
                hiep_14_cal();
                hiep_14_wpm = (this.hiep_14_count / 5);
                hiep_14_accuracy = (this.hiep_14_key.Length) * 100 / (this.hiep_14_count-hiep_14_word);
                hiep_14_lbRatio.Text = string.Format("WPM: {0:F1}\nAccuracy: {1:F2}%", this.hiep_14_wpm, this.hiep_14_accuracy);
            }
            else if (hiep_14_sec < 10)
                hiep_14_time.Text = "0:0" + hiep_14_sec--.ToString();
            else
                hiep_14_time.Text = "0:" + hiep_14_sec--.ToString();
        }
    }
}
