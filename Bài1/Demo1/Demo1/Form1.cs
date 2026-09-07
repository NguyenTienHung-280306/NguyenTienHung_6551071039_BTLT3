namespace Demo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtNhapPass.Text;
        }

        private void btntiep_Click(object sender, EventArgs e)
        {
            txtNhapPass.Clear();
            txtHienThi.Clear();

            txtNhapPass.Focus();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
