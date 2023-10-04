namespace WinFormFirst
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void GetNotificationClick(object sender, EventArgs e)
        {
            
            {
                GameCanvas mainForm = new GameCanvas();
                mainForm.Show();
            }
            
        }

        private void MouseFormMove(object sender, MouseEventArgs e)
        {
            lbPoints.Text = $"X: {e.X} Y: {e.Y}";
        }

        private void FormClick(object sender, EventArgs e)
        {
            string text = lbPoints.Text;
            string title = "Coordinates";
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}