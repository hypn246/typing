namespace hiep_14
{
    partial class hiep_14_Frm1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hiep_14_Frm1));
            _14_hiep_uC11 = new components._14_hiep_UC1();
            _14_hiep_uC21 = new hiep_14_typing_speed.components._14_hiep_UC2();
            hiep_14_btn1 = new Button();
            hiep_14_btn2 = new Button();
            hiep_14_lb1 = new Label();
            hiep_14_btn3 = new Button();
            _14_hiep_uC_setting1 = new hiep_14_typing_speed.components._14_hiep_UC_setting();
            SuspendLayout();
            // 
            // _14_hiep_uC11
            // 
            _14_hiep_uC11.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _14_hiep_uC11.BackgroundImage = (Image)resources.GetObject("_14_hiep_uC11.BackgroundImage");
            _14_hiep_uC11.BackgroundImageLayout = ImageLayout.Stretch;
            _14_hiep_uC11.Location = new Point(496, 240);
            _14_hiep_uC11.Name = "_14_hiep_uC11";
            _14_hiep_uC11.Size = new Size(249, 64);
            _14_hiep_uC11.TabIndex = 0;
            // 
            // _14_hiep_uC21
            // 
            _14_hiep_uC21.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _14_hiep_uC21.BackgroundImage = (Image)resources.GetObject("_14_hiep_uC21.BackgroundImage");
            _14_hiep_uC21.BackgroundImageLayout = ImageLayout.Stretch;
            _14_hiep_uC21.Location = new Point(496, 327);
            _14_hiep_uC21.Name = "_14_hiep_uC21";
            _14_hiep_uC21.Size = new Size(197, 70);
            _14_hiep_uC21.TabIndex = 1;
            _14_hiep_uC21.Click += hiep_14_btn2_Click;
            // 
            // hiep_14_btn1
            // 
            hiep_14_btn1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            hiep_14_btn1.Location = new Point(96, 260);
            hiep_14_btn1.Name = "hiep_14_btn1";
            hiep_14_btn1.Size = new Size(217, 44);
            hiep_14_btn1.TabIndex = 2;
            hiep_14_btn1.Text = "LETHAL TEMPO";
            hiep_14_btn1.UseVisualStyleBackColor = true;
            hiep_14_btn1.Click += hiep_14_btn1_Click;
            // 
            // hiep_14_btn2
            // 
            hiep_14_btn2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            hiep_14_btn2.Location = new Point(96, 338);
            hiep_14_btn2.Name = "hiep_14_btn2";
            hiep_14_btn2.Size = new Size(217, 44);
            hiep_14_btn2.TabIndex = 3;
            hiep_14_btn2.Text = "FLAME CHASER";
            hiep_14_btn2.UseVisualStyleBackColor = true;
            hiep_14_btn2.Click += hiep_14_btn2_Click;
            // 
            // hiep_14_lb1
            // 
            hiep_14_lb1.AutoSize = true;
            hiep_14_lb1.BackColor = Color.LightPink;
            hiep_14_lb1.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            hiep_14_lb1.ForeColor = Color.Firebrick;
            hiep_14_lb1.ImageAlign = ContentAlignment.MiddleLeft;
            hiep_14_lb1.Location = new Point(96, 57);
            hiep_14_lb1.Name = "hiep_14_lb1";
            hiep_14_lb1.Size = new Size(802, 106);
            hiep_14_lb1.TabIndex = 4;
            hiep_14_lb1.Text = "TYPING SPEED TEST";
            hiep_14_lb1.UseWaitCursor = true;
            // 
            // hiep_14_btn3
            // 
            hiep_14_btn3.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            hiep_14_btn3.Location = new Point(96, 628);
            hiep_14_btn3.Name = "hiep_14_btn3";
            hiep_14_btn3.Size = new Size(145, 46);
            hiep_14_btn3.TabIndex = 5;
            hiep_14_btn3.Text = "SETTING";
            hiep_14_btn3.UseVisualStyleBackColor = true;
            hiep_14_btn3.Visible = false;
            // 
            // _14_hiep_uC_setting1
            // 
            _14_hiep_uC_setting1.BackgroundImageLayout = ImageLayout.Stretch;
            _14_hiep_uC_setting1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _14_hiep_uC_setting1.Location = new Point(496, 613);
            _14_hiep_uC_setting1.Margin = new Padding(5);
            _14_hiep_uC_setting1.Name = "_14_hiep_uC_setting1";
            _14_hiep_uC_setting1.Size = new Size(197, 72);
            _14_hiep_uC_setting1.TabIndex = 6;
            _14_hiep_uC_setting1.Visible = false;
            // 
            // hiep_14_Frm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = hiep_14_typing_speed.Properties.Resources.MissFortune_60;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1182, 753);
            Controls.Add(_14_hiep_uC_setting1);
            Controls.Add(hiep_14_btn3);
            Controls.Add(hiep_14_lb1);
            Controls.Add(hiep_14_btn2);
            Controls.Add(hiep_14_btn1);
            Controls.Add(_14_hiep_uC21);
            Controls.Add(_14_hiep_uC11);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "hiep_14_Frm1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "14_hiep Typing speed test";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private components._14_hiep_UC1 _14_hiep_uC11;
        private hiep_14_typing_speed.components._14_hiep_UC2 _14_hiep_uC21;
        private Button hiep_14_btn1;
        private Button hiep_14_btn2;
        private Label hiep_14_lb1;
        private Button hiep_14_btn3;
        private hiep_14_typing_speed.components._14_hiep_UC_setting _14_hiep_uC_setting1;
    }
}
