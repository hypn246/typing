using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace hiep_14.components
{
    public partial class _14_hiep_UC1 : UserControl
    {
        string[] hiep_14_list = ["I", "love", "you", "apple", "banana", "cherry", "dog", "elephant", "flower", "grape", "house", "island", "jungle",
            "kite", "lemon", "mountain", "notebook", "orange", "pencil", "queen", "river", "sun", "tree",
            "umbrella", "violin", "window", "xylophone", "yellow", "zebra", "airplane", "butterfly", "cloud", "dolphin",
            "eagle", "forest", "guitar", "happy", "ice", "jacket", "kangaroo", "lamp", "moon", "nest",
            "ocean", "penguin", "quiet", "rain", "snow", "tiger", "unicorn", "volcano", "whale", "x-ray",
            "yogurt", "zeppelin", "artist", "bridge", "candle", "dragon", "energy", "fire", "globe", "horizon",
            "idea", "journey", "knowledge", "lantern", "mirror", "nature", "orbit", "planet", "quasar", "robot",
            "satellite", "telescope", "universe", "vortex", "wander", "xenon", "year", "zenith", "astronaut", "breeze",
            "comet", "destiny", "emerald", "fountain", "galaxy", "harmony", "infinity", "jewel", "kingdom", "legend",
            "mystery", "nebula", "oasis", "paradise", "quantum", "radiance", "spectrum", "twilight", "utopia", "voyage"
            ];
        Random rdn = new Random();
        int sec = 59;
        bool isStart = true;
        double accuracy;
        double wpm;
        int word = 0;
        int count = 0;
        string key = "";

        public _14_hiep_UC1()
        {
            InitializeComponent();
            hiep_14_timer1.Stop();
            hiep_14_lb1.Text = hiep_14_list[rdn.Next(0, hiep_14_list.Length)];
            hiep_14_time.Text = "1:00";
            hiep_14_lbRatio.Text = "";
        }

        private void hiep_14_btn1_check(object sender, KeyEventArgs e)
        {
            //count all key press
            count++;
            //time start here
            if (isStart)
            {
                hiep_14_timer1.Start();
                isStart = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                if (hiep_14_txt1.Text.Trim() == hiep_14_lb1.Text)
                {
                    key += hiep_14_lb1.Text;
                    word++;
                    hiep_14_lb1.Text = hiep_14_list[rdn.Next(0, hiep_14_list.Length)];
                    hiep_14_txt1.Text = null;
                }
                else
                {
                    hiep_14_lb1.Text = hiep_14_list[rdn.Next(0, hiep_14_list.Length)];
                    hiep_14_txt1.Text = null;
                }
            }
        }

        private void hiep_14_btn1_Click(object sender, EventArgs e)
        {
            hiep_14_txt1.Text = "";
            hiep_14_lbRatio.Text = "";
            isStart = true;
            hiep_14_time.Text = "1:00";
            sec = 10;
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
            if (sec < 0)
            {
                hiep_14_timer1.Stop();
                hiep_14_txt1.Enabled = false;
                wpm = (this.key.Length / 5);
                accuracy = (this.key.Length) * 100 / (this.count - hiep_14_txt1.Text.Length - word);
                hiep_14_lbRatio.Text = string.Format("WPM: {0:F1}\nAccuracy: {1:F2}%", this.wpm, this.accuracy);
            }
            else if (sec < 10)
                hiep_14_time.Text = "0:0" + sec--.ToString();
            else
                hiep_14_time.Text = "0:" + sec--.ToString();
        }

        private void hiep_14_lb1_Click(object sender, EventArgs e)
        {

        }

        private void hiep_14_lbTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
