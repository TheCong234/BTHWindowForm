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
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }
        public int luachon = 0;
        private void btTai_Click(object sender, EventArgs e)
        {
            btTai.BackColor = Color.Red;
            btXiu.BackColor = Color.White;
            luachon = 1;
            lbThongBao.Text = "";
        }

        private void btXiu_Click(object sender, EventArgs e)
        {
            btTai.BackColor = Color.White;
            btXiu.BackColor = Color.Red;
            luachon = 2;
            lbThongBao.Text = "";
        }

        private void btQuaySo_Click(object sender, EventArgs e)
        {
            lbThongBao.ForeColor = Color.Black;
            if (luachon == 0)
            {
                lbThongBao.ForeColor = Color.Brown;
                lbThongBao.Text = "Vui lòng dự đoán kết quả.";
            }
            else
            {
                lbThongBao.Text = string.Empty;
                Random rd = new Random();
                int a, b, c, sum = 0;
                for (int i = 0; i < 30; i++)
                {
                    a = (int)rd.Next(1, 6);
                    b = (int)rd.Next(1, 6);
                    c = (int)rd.Next(1, 6);
                    lbSoA.Text = a.ToString();
                    lbSoB.Text = b.ToString();
                    lbSoC.Text = c.ToString();
                    sum = a + b + c;
                    lbTong.Text = sum.ToString();
                    lbThongBao.Text = "Wait a moment";
                    Task.Delay(200).Wait();
                }

                int diem = Convert.ToInt32(lbDiem.Text);
                if ((sum < 11 && luachon == 1) || (sum > 10 && luachon == 2))
                {
                    diem += 10;
                    lbDiem.Text = diem.ToString();
                    lbThongBao.Text = "Bạn đã đoán đúng +10đ";
                    lbThongBao.ForeColor = Color.Green;

                }
                else
                {
                    diem -= 10;
                    lbDiem.Text = diem.ToString();
                    lbThongBao.Text = "Bạn đã đoán sai -10đ";
                    lbThongBao.ForeColor = Color.Red;
                }
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            btTai.BackColor = Color.White;
            btXiu.BackColor = Color.White;
            luachon = 0;
            lbThongBao.Text = "";
            lbDiem.Text = "0";
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
