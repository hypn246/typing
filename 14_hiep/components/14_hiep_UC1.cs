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
        Random hiep_14_rdn = new Random();
        int hiep_14_sec = 59;
        bool hiep_14_isStart = true;
        double hiep_14_accuracy;
        double hiep_14_wpm;
        int hiep_14_word = 0;
        int hiep_14_count = 0;
        string hiep_14_key = "";

        public _14_hiep_UC1()
        {
            InitializeComponent();
            hiep_14_timer1.Stop();
            hiep_14_lb1.Text = hiep_14_list[hiep_14_rdn.Next(0, hiep_14_list.Length)];
            hiep_14_time.Text = "1:00";
            hiep_14_lbRatio.Text = "";
            this.ActiveControl = hiep_14_txt1;
        }

        private void hiep_14_btn1_check(object sender, KeyEventArgs hiep_14_e)
        {
            //hiep_14_soKTND all hiep_14_chuoiDe press
            hiep_14_count++;
            //time start here
            if (hiep_14_isStart)
            {
                hiep_14_timer1.Start();
                hiep_14_isStart = false;
            }
            if (hiep_14_e.KeyCode == Keys.Space)
            {
                if (hiep_14_txt1.Text.Trim() == hiep_14_lb1.Text)
                {
                    hiep_14_key += hiep_14_lb1.Text;
                    hiep_14_word++;
                    hiep_14_lb1.Text = hiep_14_list[hiep_14_rdn.Next(0, hiep_14_list.Length)];
                    hiep_14_txt1.Text = null;
                }
                else
                {
                    hiep_14_lb1.Text = hiep_14_list[hiep_14_rdn.Next(0, hiep_14_list.Length)];
                    hiep_14_txt1.Text = null;
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
                hiep_14_wpm = (this.hiep_14_key.Length / 5);
                hiep_14_accuracy = (this.hiep_14_key.Length) * 100 / (this.hiep_14_count - hiep_14_txt1.Text.Length - hiep_14_word);
                hiep_14_lbRatio.Text = string.Format("WPM: {0:F1}\nAccuracy: {1:F2}%", this.hiep_14_wpm, this.hiep_14_accuracy);
            }
            else if (hiep_14_sec < 10)
                hiep_14_time.Text = "0:0" + hiep_14_sec--.ToString();
            else
                hiep_14_time.Text = "0:" + hiep_14_sec--.ToString();
        }
    }
}
