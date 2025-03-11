namespace hiep_14.components
{
    partial class _14_hiep_UC1
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
            hiep_14_txt1 = new TextBox();
            hiep_14_lb1 = new Label();
            hiep_14_btn2 = new Button();
            hiep_14_btn1 = new Button();
            hiep_14_lbRatio = new Label();
            hiep_14_time = new Label();
            hiep_14_timer1 = new System.Windows.Forms.Timer(components);
            hiep_14_lbTitle = new Label();
            hiep_14_lb2 = new Label();
            SuspendLayout();
            // 
            // hiep_14_lb2
            // 
            hiep_14_lb2.AutoSize = true;
            hiep_14_lb2.BackColor = Color.RoyalBlue;
            hiep_14_lb2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            hiep_14_lb2.ForeColor = Color.White;
            hiep_14_lb2.Location = new Point(475, 391);
            hiep_14_lb2.Name = "hiep_14_lb2";
            hiep_14_lb2.Size = new Size(262, 28);
            hiep_14_lb2.TabIndex = 11;
            hiep_14_lb2.Text = "Space to continue typing !";
            hiep_14_lb2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hiep_14_txt1
            // 
            hiep_14_txt1.BackColor = Color.LavenderBlush;
            hiep_14_txt1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hiep_14_txt1.Location = new Point(475, 328);
            hiep_14_txt1.Name = "hiep_14_txt1";
            hiep_14_txt1.Size = new Size(262, 41);
            hiep_14_txt1.TabIndex = 7;
            hiep_14_txt1.KeyUp += hiep_14_btn1_check;
            // 
            // hiep_14_lb1
            // 
            hiep_14_lb1.Anchor = AnchorStyles.Top;
            hiep_14_lb1.BackColor = Color.PowderBlue;
            hiep_14_lb1.Font = new Font("Arial Narrow", 20F, FontStyle.Bold);
            hiep_14_lb1.ForeColor = Color.Black;
            hiep_14_lb1.Location = new Point(355, 213);
            hiep_14_lb1.Name = "hiep_14_lb1";
            hiep_14_lb1.Size = new Size(484, 77);
            hiep_14_lb1.TabIndex = 6;
            hiep_14_lb1.Text = "!";
            hiep_14_lb1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hiep_14_btn2
            // 
            hiep_14_btn2.BackColor = Color.Crimson;
            hiep_14_btn2.Font = new Font("Arial Narrow", 14F, FontStyle.Bold);
            hiep_14_btn2.Location = new Point(541, 550);
            hiep_14_btn2.Name = "hiep_14_btn2";
            hiep_14_btn2.Size = new Size(121, 39);
            hiep_14_btn2.TabIndex = 5;
            hiep_14_btn2.Text = "Back";
            hiep_14_btn2.UseVisualStyleBackColor = false;
            hiep_14_btn2.Click += hiep_14_btn2_Click;
            // 
            // hiep_14_btn1
            // 
            hiep_14_btn1.Font = new Font("Arial Narrow", 14F, FontStyle.Bold);
            hiep_14_btn1.Location = new Point(541, 479);
            hiep_14_btn1.Name = "hiep_14_btn1";
            hiep_14_btn1.Size = new Size(121, 41);
            hiep_14_btn1.TabIndex = 4;
            hiep_14_btn1.Text = "Reset";
            hiep_14_btn1.UseVisualStyleBackColor = true;
            hiep_14_btn1.Click += hiep_14_btn1_Click;
            // 
            // hiep_14_lbRatio
            // 
            hiep_14_lbRatio.AutoSize = true;
            hiep_14_lbRatio.BackColor = Color.Transparent;
            hiep_14_lbRatio.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hiep_14_lbRatio.ForeColor = Color.WhiteSmoke;
            hiep_14_lbRatio.Location = new Point(22, 621);
            hiep_14_lbRatio.Name = "hiep_14_lbRatio";
            hiep_14_lbRatio.Padding = new Padding(10);
            hiep_14_lbRatio.Size = new Size(85, 51);
            hiep_14_lbRatio.TabIndex = 8;
            hiep_14_lbRatio.Text = "ratio";
            // 
            // hiep_14_time
            // 
            hiep_14_time.AutoSize = true;
            hiep_14_time.BackColor = Color.LightSkyBlue;
            hiep_14_time.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            hiep_14_time.ForeColor = Color.Black;
            hiep_14_time.Location = new Point(565, 135);
            hiep_14_time.Name = "hiep_14_time";
            hiep_14_time.Size = new Size(65, 32);
            hiep_14_time.TabIndex = 9;
            hiep_14_time.Text = "time";
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
            hiep_14_lbTitle.ForeColor = Color.Gold;
            hiep_14_lbTitle.Location = new Point(0, 0);
            hiep_14_lbTitle.Name = "hiep_14_lbTitle";
            hiep_14_lbTitle.Padding = new Padding(10);
            hiep_14_lbTitle.Size = new Size(1200, 58);
            hiep_14_lbTitle.TabIndex = 10;
            hiep_14_lbTitle.Text = "LETHAL TEMPO MODE";
            hiep_14_lbTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _14_hiep_UC1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = hiep_14_typing_speed.Properties.Resources.ru9ums16vqm11;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(hiep_14_lb2);
            Controls.Add(hiep_14_lbTitle);
            Controls.Add(hiep_14_time);
            Controls.Add(hiep_14_lbRatio);
            Controls.Add(hiep_14_txt1);
            Controls.Add(hiep_14_lb1);
            Controls.Add(hiep_14_btn2);
            Controls.Add(hiep_14_btn1);
            Margin = new Padding(5);
            Name = "_14_hiep_UC1";
            Size = new Size(1200, 750);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox hiep_14_txt1;
        private Label hiep_14_lb1;
        private Button hiep_14_btn2;
        private Button hiep_14_btn1;
        private Label hiep_14_lbRatio;
        private Label hiep_14_time;
        private System.Windows.Forms.Timer hiep_14_timer1;
        private Label hiep_14_lbTitle;
        private Label hiep_14_lb2;
    }
}
