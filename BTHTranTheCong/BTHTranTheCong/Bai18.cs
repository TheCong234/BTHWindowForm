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
    public partial class Bai18 : Form
    {
        public Bai18()
        {
            InitializeComponent();
        }
        //
        PictureBox picAnh;
        string path = string.Empty;
        Point oldPicPoint;
        //
        private void RandomImage()
        {
            picAnh = new PictureBox();
            Random rd = new Random();
            int num = rd.Next(1,18);
            picAnh.Image = Image.FromFile(path + num + ".jpg");
            picAnh.Width = picAnh.Height = 100;
            picAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picAnh.BorderStyle = BorderStyle.FixedSingle;
            picAnh.Location = new Point(0,0);
            
            this.Controls.Add(picAnh);
            picAnh.MouseDown += pictureBox1_MouseDown;
            picAnh.MouseMove += pictureBox1_MouseMove;
            picAnh.MouseUp += pictureBox1_MouseUp;
            flowLayoutPanel1.SendToBack();
            picAnh.BringToFront();
        }
        private void Bai18_Load(object sender, EventArgs e)
        {
            path = Application.StartupPath + @"\Image18\";
            RandomImage();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            oldPicPoint = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if(flowLayoutPanel1.Bounds.Contains(picAnh.Bounds))
            {
                flowLayoutPanel1.Controls.Add(picAnh);
                RandomImage();
            }    
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                int dx, dy;
                dx = e.X - oldPicPoint.X;
                dy = e.Y - oldPicPoint.Y;
                picAnh.Left += dx;
                picAnh.Top += dy;
            }
        }
    }
}
