namespace hiep_14_typing_speed
{
    partial class hiep_14_frm_test_174_chieu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Label hiep_14_lb2;
            hiep_14_time = new Label();
            hiep_14_lbDung = new Label();
            hiep_14_txt1 = new TextBox();
            hiep_14_lb1 = new Label();
            hiep_14_btn1 = new Button();
            hiep_14_timer1 = new System.Windows.Forms.Timer(components);
            hiep_14_lbTitle = new Label();
            hiep_14_lbSai = new Label();
            hiep_14_lb2 = new Label();
            SuspendLayout();
            // 
            // hiep_14_lb2
            // 
            hiep_14_lb2.AutoSize = true;
            hiep_14_lb2.BackColor = Color.RoyalBlue;
            hiep_14_lb2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            hiep_14_lb2.ForeColor = Color.White;
            hiep_14_lb2.Location = new Point(460, 298);
            hiep_14_lb2.Name = "hiep_14_lb2";
            hiep_14_lb2.Size = new Size(262, 28);
            hiep_14_lb2.TabIndex = 27;
            hiep_14_lb2.Text = "Space to continue typing !";
            hiep_14_lb2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hiep_14_time
            // 
            hiep_14_time.AutoSize = true;
            hiep_14_time.BackColor = Color.LightSkyBlue;
            hiep_14_time.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            hiep_14_time.ForeColor = Color.Black;
            hiep_14_time.Location = new Point(565, 77);
            hiep_14_time.Name = "hiep_14_time";
            hiep_14_time.Size = new Size(65, 32);
            hiep_14_time.TabIndex = 25;
            hiep_14_time.Text = "time";
            // 
            // hiep_14_lbDung
            // 
            hiep_14_lbDung.AutoSize = true;
            hiep_14_lbDung.BackColor = Color.Transparent;
            hiep_14_lbDung.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hiep_14_lbDung.ForeColor = Color.WhiteSmoke;
            hiep_14_lbDung.Location = new Point(12, 449);
            hiep_14_lbDung.Name = "hiep_14_lbDung";
            hiep_14_lbDung.Padding = new Padding(10);
            hiep_14_lbDung.Size = new Size(203, 51);
            hiep_14_lbDung.TabIndex = 24;
            hiep_14_lbDung.Text = "Số lần gõ đúng:";
            // 
            // hiep_14_txt1
            // 
            hiep_14_txt1.BackColor = Color.LavenderBlush;
            hiep_14_txt1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hiep_14_txt1.Location = new Point(287, 234);
            hiep_14_txt1.Name = "hiep_14_txt1";
            hiep_14_txt1.Size = new Size(617, 41);
            hiep_14_txt1.TabIndex = 23;
            hiep_14_txt1.KeyUp += hiep_14_btn1_check;
            // 
            // hiep_14_lb1
            // 
            hiep_14_lb1.Anchor = AnchorStyles.Top;
            hiep_14_lb1.BackColor = Color.PowderBlue;
            hiep_14_lb1.Font = new Font("Arial Narrow", 20F, FontStyle.Bold);
            hiep_14_lb1.ForeColor = Color.Black;
            hiep_14_lb1.Location = new Point(271, 133);
            hiep_14_lb1.Name = "hiep_14_lb1";
            hiep_14_lb1.Size = new Size(662, 77);
            hiep_14_lb1.TabIndex = 22;
            hiep_14_lb1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hiep_14_btn1
            // 
            hiep_14_btn1.Font = new Font("Arial Narrow", 14F, FontStyle.Bold);
            hiep_14_btn1.Location = new Point(526, 372);
            hiep_14_btn1.Name = "hiep_14_btn1";
            hiep_14_btn1.Size = new Size(121, 41);
            hiep_14_btn1.TabIndex = 20;
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
            hiep_14_lbTitle.ForeColor = Color.Gold;
            hiep_14_lbTitle.Location = new Point(0, 0);
            hiep_14_lbTitle.Name = "hiep_14_lbTitle";
            hiep_14_lbTitle.Padding = new Padding(10);
            hiep_14_lbTitle.Size = new Size(1182, 58);
            hiep_14_lbTitle.TabIndex = 26;
            hiep_14_lbTitle.Text = "TEST WITH 5 CASES";
            hiep_14_lbTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hiep_14_lbSai
            // 
            hiep_14_lbSai.AutoSize = true;
            hiep_14_lbSai.BackColor = Color.Transparent;
            hiep_14_lbSai.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hiep_14_lbSai.ForeColor = Color.WhiteSmoke;
            hiep_14_lbSai.Location = new Point(12, 514);
            hiep_14_lbSai.Name = "hiep_14_lbSai";
            hiep_14_lbSai.Padding = new Padding(10);
            hiep_14_lbSai.Size = new Size(175, 51);
            hiep_14_lbSai.TabIndex = 28;
            hiep_14_lbSai.Text = "Số lần gõ sai:";
            // 
            // hiep_14_frm_test_174_chieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1182, 608);
            Controls.Add(hiep_14_lbSai);
            Controls.Add(hiep_14_lb2);
            Controls.Add(hiep_14_time);
            Controls.Add(hiep_14_lbDung);
            Controls.Add(hiep_14_txt1);
            Controls.Add(hiep_14_lb1);
            Controls.Add(hiep_14_btn1);
            Controls.Add(hiep_14_lbTitle);
            Name = "hiep_14_frm_test_174_chieu";
            Text = "hiep_14_frm_test_174_chieu";
            Load += hiep_14_frm_test_174_chieu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label hiep_14_time;
        private Label hiep_14_lbDung;
        private TextBox hiep_14_txt1;
        private Label hiep_14_lb1;
        private Button hiep_14_btn1;
        private System.Windows.Forms.Timer hiep_14_timer1;
        private Label hiep_14_lbTitle;
        private Label hiep_14_lbSai;
    }
}