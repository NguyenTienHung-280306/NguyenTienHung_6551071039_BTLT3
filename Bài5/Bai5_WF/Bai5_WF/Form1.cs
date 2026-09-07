namespace Bai5_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            lblLapTrinhBoi.Text = txtHoTen.Text;
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            lblLapTrinhBoi.Text = txtHoTen.Text;
        }
        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinhBoi.ForeColor = Color.Red;
            txtHoTen.ForeColor = Color.Red;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinhBoi.ForeColor = Color.Green;
            txtHoTen.ForeColor = Color.Green;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinhBoi.ForeColor = Color.Blue;
            txtHoTen.ForeColor = Color.Blue;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinhBoi.ForeColor = Color.Black;
            txtHoTen.ForeColor = Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtHoTen.Focus();
            radRed.Checked = true;
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinhBoi.Font = new Font(lblLapTrinhBoi.Font.Name,
            lblLapTrinhBoi.Font.Size, lblLapTrinhBoi.Font.Style ^ FontStyle.Bold);
        }

        private void radRed_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
