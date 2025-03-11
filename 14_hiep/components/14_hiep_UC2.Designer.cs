namespace hiep_14_typing_speed.components
{
    partial class _14_hiep_UC2
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Label hiep_14_lb2;
            hiep_14_time = new Label();
            hiep_14_lbRatio = new Label();
            hiep_14_lb1 = new Label();
            hiep_14_btn2 = new Button();
            hiep_14_btn1 = new Button();
            hiep_14_timer1 = new System.Windows.Forms.Timer(components);
            hiep_14_lbTitle = new Label();
            hiep_14_txt1 = new RichTextBox();
            hiep_14_lb2 = new Label();
            SuspendLayout();
            // 
            // hiep_14_time
            // 
            hiep_14_time.AutoSize = true;
            hiep_14_time.BackColor = Color.Black;
            hiep_14_time.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            hiep_14_time.ForeColor = Color.Crimson;
            hiep_14_time.Location = new Point(564, 93);
            hiep_14_time.Name = "hiep_14_time";
            hiep_14_time.Size = new Size(65, 32);
            hiep_14_time.TabIndex = 16;
            hiep_14_time.Text = "time";
            // 
            // hiep_14_lbRatio
            // 
            hiep_14_lbRatio.AutoSize = true;
            hiep_14_lbRatio.BackColor = Color.Transparent;
            hiep_14_lbRatio.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hiep_14_lbRatio.ForeColor = Color.White;
            hiep_14_lbRatio.Location = new Point(22, 658);
            hiep_14_lbRatio.Name = "hiep_14_lbRatio";
            hiep_14_lbRatio.Size = new Size(65, 31);
            hiep_14_lbRatio.TabIndex = 15;
            hiep_14_lbRatio.Text = "ratio";
            // 
            // hiep_14_lb1
            // 
            hiep_14_lb1.Anchor = AnchorStyles.Top;
            hiep_14_lb1.BackColor = Color.Salmon;
            hiep_14_lb1.Font = new Font("Arial Narrow", 20F, FontStyle.Bold);
            hiep_14_lb1.ForeColor = Color.MidnightBlue;
            hiep_14_lb1.Location = new Point(194, 147);
            hiep_14_lb1.Name = "hiep_14_lb1";
            hiep_14_lb1.Size = new Size(805, 164);
            hiep_14_lb1.TabIndex = 13;
            hiep_14_lb1.Text = "!";
            hiep_14_lb1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hiep_14_btn2
            // 
            hiep_14_btn2.BackColor = Color.Crimson;
            hiep_14_btn2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            hiep_14_btn2.Location = new Point(519, 635);
            hiep_14_btn2.Name = "hiep_14_btn2";
            hiep_14_btn2.Size = new Size(121, 39);
            hiep_14_btn2.TabIndex = 12;
            hiep_14_btn2.Text = "Back";
            hiep_14_btn2.UseVisualStyleBackColor = false;
            hiep_14_btn2.Click += hiep_14_btn2_Click;
            // 
            // hiep_14_btn1
            // 
            hiep_14_btn1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            hiep_14_btn1.Location = new Point(519, 578);
            hiep_14_btn1.Name = "hiep_14_btn1";
            hiep_14_btn1.Size = new Size(121, 41);
            hiep_14_btn1.TabIndex = 11;
            hiep_14_btn1.Text = "Reset";
            hiep_14_btn1.UseVisualStyleBackColor = true;
            hiep_14_btn1.Click += hiep_14_btn1_Click;
            // 
            // hiep_14_timer1
            // 
            hiep_14_timer1.Enabled = true;
            hiep_14_timer1.Interval = 1000;
            hiep_14_timer1.Tick += hiep_14_timer1_Tick;
            // 
            // hiep_14_lbTitle
            // 
            hiep_14_lbTitle.BackColor = Color.Transparent;
            hiep_14_lbTitle.Dock = DockStyle.Top;
            hiep_14_lbTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            hiep_14_lbTitle.ForeColor = Color.Red;
            hiep_14_lbTitle.Location = new Point(0, 0);
            hiep_14_lbTitle.Name = "hiep_14_lbTitle";
            hiep_14_lbTitle.Padding = new Padding(10);
            hiep_14_lbTitle.Size = new Size(1200, 58);
            hiep_14_lbTitle.TabIndex = 17;
            hiep_14_lbTitle.Text = "FLAME CHASER MODE";
            hiep_14_lbTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hiep_14_txt1
            // 
            hiep_14_txt1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            hiep_14_txt1.ForeColor = Color.Navy;
            hiep_14_txt1.Location = new Point(194, 336);
            hiep_14_txt1.Name = "hiep_14_txt1";
            hiep_14_txt1.Size = new Size(805, 181);
            hiep_14_txt1.TabIndex = 18;
            hiep_14_txt1.Text = "";
            hiep_14_txt1.KeyUp += hiep_14_btn1_check;
            // 
            // hiep_14_lb2
            // 
            hiep_14_lb2.AutoSize = true;
            hiep_14_lb2.BackColor = Color.Moccasin;
            hiep_14_lb2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            hiep_14_lb2.ForeColor = Color.RoyalBlue;
            hiep_14_lb2.Location = new Point(452, 529);
            hiep_14_lb2.Name = "hiep_14_lb2";
            hiep_14_lb2.Size = new Size(257, 28);
            hiep_14_lb2.TabIndex = 19;
            hiep_14_lb2.Text = "Enter to continue typing !";
            hiep_14_lb2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _14_hiep_UC2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.Fire_Moth__B3_MU_0_;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(hiep_14_lb2);
            Controls.Add(hiep_14_txt1);
            Controls.Add(hiep_14_time);
            Controls.Add(hiep_14_lbRatio);
            Controls.Add(hiep_14_lb1);
            Controls.Add(hiep_14_btn2);
            Controls.Add(hiep_14_btn1);
            Controls.Add(hiep_14_lbTitle);
            Name = "_14_hiep_UC2";
            Size = new Size(1200, 755);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label hiep_14_time;
        private Label hiep_14_lbRatio;
        private Label hiep_14_lb1;
        private Button hiep_14_btn2;
        private Button hiep_14_btn1;
        private System.Windows.Forms.Timer hiep_14_timer1;
        private Label hiep_14_lbTitle;
        private RichTextBox hiep_14_txt1;
    }
}
