using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTHTranTheCong
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            try
            { 
                int a = Convert.ToInt32(tbSoA.Text);
                int b = Convert.ToInt32(tbSoB.Text);
                Button bt = (Button)sender;
                switch (bt.Text)
                {
                    case "+":
                        lbKetQua.Text = (a+b).ToString();
                        break;
                    case "-":
                        lbKetQua.Text = (a - b).ToString();
                        break;
                    case "*":
                        lbKetQua.Text = (a * b).ToString();
                        break;
                    case "/":
                        double c = (1.0 * a / b);
                        lbKetQua.Text = c.ToString();
                        break;
                    default:
                        lbKetQua.Text = string.Empty;
                        break;
                }

            }
            catch(Exception ex)
            {
                lbKetQua.Text = ex.Message;
            }
        }

        private void btĐóng_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
