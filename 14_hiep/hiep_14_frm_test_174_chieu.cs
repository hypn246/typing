using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hiep_14_typing_speed
{
    public partial class hiep_14_frm_test_174_chieu : Form
    {
        public hiep_14_frm_test_174_chieu()
        {
            InitializeComponent();
            hiep_14_timer1.Stop();
            hiep_14_time.Text = "1:00";
            this.ActiveControl = hiep_14_txt1;
        }

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
        int hiep_14_dung=0;
        int hiep_14_sai=0;
        int hiep_14_count = 1;

        public string hiep_14_rand()
        {
            return hiep_14_list[hiep_14_rdn.Next(0, hiep_14_list.Length)];
        }

        private void hiep_14_frm_test_174_chieu_Load(object sender, EventArgs e)
        {
            hiep_14_lb1.Text= string.Format("{0}",hiep_14_rand());
        }

        private void hiep_14_btn1_check(object sender, KeyEventArgs e)
        {
            //time start here
            if (hiep_14_isStart)
            {
                hiep_14_timer1.Start();
                hiep_14_isStart = false;
            }
            if (e.KeyCode == Keys.Space || hiep_14_count==5)
            {
                if (hiep_14_txt1.Text.Trim() == hiep_14_lb1.Text)
                {
                    hiep_14_dung++;
                    hiep_14_lb1.Text = hiep_14_list[hiep_14_rdn.Next(0, hiep_14_list.Length)];
                    hiep_14_txt1.Text = null;
                    hiep_14_lbDung.Text = "Số tu gõ đúng: "+ hiep_14_dung;
                }
                else
                {
                    hiep_14_lb1.Text = hiep_14_list[hiep_14_rdn.Next(0, hiep_14_list.Length)];
                    hiep_14_txt1.Text = null;
                    hiep_14_sai++;
                    hiep_14_lbSai.Text = "Số tu gõ sai: "+ hiep_14_sai;
                }
                hiep_14_check();
                hiep_14_count++;
            }
        }
        public void hiep_14_reset()
        {
            hiep_14_count = 1;
            hiep_14_dung = 0;
            hiep_14_sai = 0;
            hiep_14_lbDung.Text = "Số tu gõ đúng: " + hiep_14_dung;
            hiep_14_lbSai.Text = "Số tu gõ sai: "+ hiep_14_sai;
            this.ActiveControl = hiep_14_txt1;
        }
        public void hiep_14_check()
        {
            if(hiep_14_dung>=2)
            {
                MessageBox.Show("Ban thang", "Thong bao");
                hiep_14_reset();
            }
            else if(hiep_14_sai>3)
            {
                MessageBox.Show("Ban thua", "Thong bao");
                hiep_14_reset();
            }
        }

        private void hiep_14_btn1_Click(object sender, EventArgs e)
        {
            hiep_14_txt1.Text = "";
            hiep_14_lbDung.Text = "Số tu gõ đúng: ";
            hiep_14_lbSai.Text = "Số tu gõ sai: ";
            hiep_14_isStart = true;
            hiep_14_time.Text = "1:00";
            hiep_14_sec = 59;
            hiep_14_txt1.Enabled = true;
            hiep_14_timer1.Stop();

            hiep_14_dung = 0;
            hiep_14_sai = 0;
        }


        private void hiep_14_timer1_Tick(object sender, EventArgs e)
        {
            if (hiep_14_sec < 0)
            {
                hiep_14_timer1.Stop();
                hiep_14_txt1.Enabled = false;
                hiep_14_check();
                hiep_14_lbSai.Text += this.hiep_14_sai.ToString();
                hiep_14_lbDung.Text += this.hiep_14_dung.ToString();
            }
            else if (hiep_14_sec < 10)
                hiep_14_time.Text = "0:0" + hiep_14_sec--.ToString();
            else
                hiep_14_time.Text = "0:" + hiep_14_sec--.ToString();
        }
    }
}
