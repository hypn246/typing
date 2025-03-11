namespace hiep_14
{
    public partial class hiep_14_Frm1 : Form
    {
        public hiep_14_Frm1()
        {
            InitializeComponent();
            _14_hiep_uC21.Hide();
            _14_hiep_uC11.Hide();
        }
        private void hiep_14_btn1_Click(object sender, EventArgs e)
        {
            _14_hiep_uC11.Show();
            _14_hiep_uC11.Dock = DockStyle.Fill;
            _14_hiep_uC11.BringToFront();
            _14_hiep_uC21.Hide();
        }
        private void hiep_14_btn2_Click(object sender, EventArgs e)
        {
            _14_hiep_uC11.Hide();
            _14_hiep_uC21.Show();
            _14_hiep_uC21.BringToFront();
            _14_hiep_uC21.Dock = DockStyle.Fill;
        }
    }
}
