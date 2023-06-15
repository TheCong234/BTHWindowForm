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
    public partial class Bai10 : Form
    {
        public Bai10()
        {
            InitializeComponent();
        }
        
        private void btCong_Click(object sender, EventArgs e)
        {
            try
            {
                Button bt = (Button)sender;
                int so1 = Convert.ToInt32(tbSo1.Text);
                int so2 = Convert.ToInt32(tbSo2.Text);
                int so3 = Convert.ToInt32(tbSo3.Text);
                int so4 = Convert.ToInt32(tbSo4.Text);
                if (so2*so4 == 0)
                {
                    throw new Exception("Mẫu số phải khác 0.");
                }
                PHANSO kq = new PHANSO(0, 1);
                PHANSO a = new PHANSO(so1, so2);
                PHANSO b = new PHANSO(so3, so4);
                switch (bt.Text)
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
                lbSo5.Text = kq.TuSo.ToString();
                lbSo6.Text = kq.MauSo.ToString();
                lbPhepTinh.Text = bt.Text;

            }
            catch (Exception ex)
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
