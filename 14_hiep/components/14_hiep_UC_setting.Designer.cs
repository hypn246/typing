namespace hiep_14_typing_speed.components
{
    partial class _14_hiep_UC_setting
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
            Label hiep_14_lb1;
            button1 = new Button();
            button2 = new Button();
            hiep_14_lb1 = new Label();
            SuspendLayout();
            // 
            // hiep_14_lb1
            // 
            hiep_14_lb1.AutoSize = true;
            hiep_14_lb1.Location = new Point(84, 64);
            hiep_14_lb1.Name = "hiep_14_lb1";
            hiep_14_lb1.Size = new Size(83, 31);
            hiep_14_lb1.TabIndex = 2;
            hiep_14_lb1.Text = "switch";
            hiep_14_lb1.TextAlign = ContentAlignment.MiddleCenter;
            hiep_14_lb1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(84, 151);
            button1.Name = "button1";
            button1.Size = new Size(153, 86);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += hiep_14_btn1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(84, 268);
            button2.Name = "button2";
            button2.Size = new Size(153, 76);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // _14_hiep_UC_setting
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(hiep_14_lb1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "_14_hiep_UC_setting";
            Size = new Size(695, 466);
            Load += _14_hiep_UC_setting_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label hiep_14_lb1;
        private Button button1;
        private Button button2;
    }
}
