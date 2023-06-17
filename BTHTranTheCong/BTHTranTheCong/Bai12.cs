using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTHTranTheCong
{
    public partial class Bai12 : Form
    {
        public Bai12()
        {
            InitializeComponent();
        }
        int dx, dy;
        bool running = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(picBall.Left<0 || picBall.Right>ClientRectangle.Width)
            {
                dx = -dx;
            }
            if(picBall.Top < 0 || ((picBall.Bottom == lbVanTruot.Top) && (picBall.Left >= lbVanTruot.Left -53 && picBall.Right <= lbVanTruot.Right + 53)))
            {
                dy = -dy;
            }
            picBall.Left += dx;
            picBall.Top += dy;
            if (picBall.Bottom > lbVanTruot.Top)
            {
                timer1.Dispose();
                MessageBox.Show("Bạn chơi gà quá đáng lắm luôn á.");
            }


        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Space:
                    running = !running;
                    timer1.Enabled = running;
                    break;
                case Keys.Left:
                    lbVanTruot.Left -= 1;
                    if(lbVanTruot.Left < 0)
                        lbVanTruot.Left = 0;
                    break;
                case Keys.Right:
                    if(lbVanTruot.Right+1 <= ClientRectangle.Width)
                        lbVanTruot.Left += 1;

                    break;
                case Keys.Down:
                    break;
                case Keys.Up:
                    break;

            }
            lbVanTruot.Location = new Point(lbVanTruot.Location.X, ClientRectangle.Height - 20);

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Bai12_Load(object sender, EventArgs e)
        {
            dx = 1;
            dy = 1;
            lbVanTruot.Location = new Point(ClientRectangle.Width / 2, ClientRectangle.Height - 20);
        }
    }
}
