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
    public partial class Bai11 : Form
    {
        public Bai11()
        {
            InitializeComponent();
        }
        PHANSO kq = new PHANSO(0, 1);
        string nhanXet = string.Empty;
        private void button3_Click(object sender, EventArgs e)
        {
            nhanXet = string.Empty;
            lbNhanXet.Text = nhanXet;
            string[] operators = { "+", "-", "*", "/" };
            Random rd = new Random();
            string phepTinh = operators[rd.Next(0,4)];
            lbPhepTinh.Text = phepTinh;
            int so1 = rd.Next(1,99);
            int so2= rd.Next(1, 99);
            int so3 = rd.Next(1, 99);
            int so4 = rd.Next(1, 99);
            lbSo1.Text = so1.ToString();
            lbSo2.Text = so2.ToString();
            lbSo3.Text = so3.ToString();
            lbSo4.Text = so4.ToString();


            PHANSO a = new PHANSO(so1, so2);
            PHANSO b = new PHANSO(so3, so4);
            switch (phepTinh)
            {
                case "+":
                    kq = kq.PhepCong(a, b);
                    break;
                case "-":
                    kq = kq.PhepTru(a, b);
                    break;
                case "*":
                    kq = kq.PhepNhan(a, b);
                    break;
                case "/":
                    kq = kq.PhepChia(a, b);
                    break;
                default: break;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int inp1 = Convert.ToInt32(tbSo5.Text);
                int inp2 = Convert.ToInt32(tbSo6.Text);
                PHANSO inp = new PHANSO(inp1, inp2);
                inp = inp.RutGon(inp);
                if (inp.TuSo == kq.TuSo && inp.MauSo == kq.MauSo)
                {
                    nhanXet = "Đáp án của bạn chính xác";
                    lbNhanXet.ForeColor = Color.Green;
                }
                else
                {
                    lbNhanXet.ForeColor = Color.Red;
                    nhanXet = "Sai rồi! Đáp án đúng là: " + kq.TuSo + "/" + kq.MauSo;
                }
                lbNhanXet.Text = nhanXet;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
