using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormFirst
{
    public partial class GameCanvas : Form
    {
        public GameCanvas()
        {
            InitializeComponent();
        }

        private void ButtonMoveEvent(object sender, EventArgs e)
        {
            Random random = new Random();
            int x = random.Next(0, 300);
            int y = random.Next(0, 300);
            btNo.Location = new Point(x, y);
            btNo.Update();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btYes_Click(object sender, EventArgs e)
        {
            string titel = "Thanks!";
            string message = "You made the right choice";
            var resultDialog = MessageBox.Show(message, titel, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (resultDialog == DialogResult.OK)
            {
                this.Close();
            }
            else if (resultDialog == DialogResult.Cancel)
            {
                this.Close();
            }
        }
    }
}
