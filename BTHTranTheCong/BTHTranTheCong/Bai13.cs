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
    public partial class Bai13 : Form
    {
        public Bai13()
        {
            InitializeComponent();
        }
        //
        string pathImgae = string.Empty;
        int choose = 0;
        int resRand = 0;
        int numberOfGuess = 0;
        int numberOfWin = 0;
        int numberOfLost = 0;
        double percentOfWin = 0;
        double percentOfLost = 0;

        //
        public void AddImage(PictureBox ptb, string soAnh)
        {
            ptbDoan.Image = Image.FromFile(pathImgae + soAnh + ".bmp");
        }
        private void bt1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            ptbDoan.Image = Image.FromFile(pathImgae + bt.Text + ".bmp");
            choose = int.Parse(bt.Text);
        }

        private void Bai13_Load(object sender, EventArgs e)
        {
            pathImgae = Application.StartupPath + @"\HinhAnh\";
            ptbDoan.Image = Image.FromFile(pathImgae + "img_nem_dep.jpg");
            ptbRand.Image = Image.FromFile(pathImgae + "img_nem_dep.jpg");
        }
        public void touchEnter()
        {
            Random rd = new Random();
            resRand = rd.Next(1, 7);
            ptbRand.Image = Image.FromFile(pathImgae + resRand.ToString() + ".bmp");
            numberOfGuess++;
            string save = string.Empty;
            if (resRand == choose)
            {
                numberOfWin++;
                save = numberOfGuess + ". Thắng (Đoán " + choose + " ra " + resRand + ").";
                lbxLichSu.Items.Add(save);
            }
            else
            {
                numberOfLost++;
                save = numberOfGuess + ". Thua (Đoán " + choose + " ra " + resRand + ").";
                lbxLichSu.Items.Add(save);
            }
            percentOfWin = (1.0*100 /numberOfGuess) * numberOfWin;
            percentOfLost = (1.0 * 100 / numberOfGuess) * numberOfLost;
            lbLanDoan.Text = numberOfGuess.ToString();
            lbLanThang.Text = numberOfWin.ToString() + "(" + percentOfWin+ "%)";
            lbLanThua.Text = numberOfLost.ToString() + "(" + percentOfLost + "%)";
        }
        private void btQuay_Click(object sender, EventArgs e)
        {
            touchEnter();
        }
        public void touchEscape()
        {
            choose = 0;
            resRand = 0;
            numberOfGuess = 0;
            numberOfWin = 0;
            numberOfLost = 0;
            ptbDoan.Image = Image.FromFile(pathImgae + "img_nem_dep.jpg");
            ptbRand.Image = Image.FromFile(pathImgae + "img_nem_dep.jpg");
            lbxLichSu.Items.Clear();
            lbLanDoan.Text = numberOfGuess.ToString();
            lbLanThang.Text = numberOfWin.ToString() + "(" + percentOfWin + "%)";
            lbLanThua.Text = numberOfLost.ToString() + "(" + percentOfLost + "%)";
            percentOfWin = 0;
            percentOfLost = 0;
        }
        private void btReset_Click(object sender, EventArgs e)
        {
            touchEscape();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            object sender = keyData;
            switch (keyData)
            {
                case Keys.Enter:
                    touchEnter();
                    return true;
                case Keys.Escape:
                    touchEscape();
                    return true;

            }    
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
