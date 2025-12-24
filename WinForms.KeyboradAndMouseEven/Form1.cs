namespace WinForms.KeyboradAndMouseEven
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        int step = 10;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
            /*
            if (e.Control && e.KeyCode == Keys.S)
            {
                MessageBox.Show("Save");
            }
            else if (e.Control && e.KeyCode == Keys.O)
            {
                MessageBox.Show("Open");
            }
            else if (e.Control && e.KeyCode == Keys.Q)
            {
                Application.Exit();
            }*/

            if (e.KeyCode == Keys.Up)
                lblResult.Top -= step;
            else if (e.KeyCode == Keys.Down)
                lblResult.Top += step;
            else if (e.KeyCode == Keys.Left)
                lblResult.Left -= step;
            else if (e.KeyCode == Keys.Right)
                lblResult.Left += step;
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);

            if (txtCode.Text.Length >= 5 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCode2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && txtCode.Text.Length >= 30 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
