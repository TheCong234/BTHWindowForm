using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTHTranTheCong
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }
        //
        int[] dongGia = { 100000, 120000, 200000, 80000 };
        //
        private void cbCaoVoi_CheckedChanged(object sender, EventArgs e)
        {
            int sum = Convert.ToInt32(lbTotal.Text);
            CheckBox cb = (CheckBox)sender;
            //click vào cạo vôi.
            if (cb == cbCaoVoi)
            {
                if (cbCaoVoi.Checked)
                {
                    sum += 100000;
                    lbTotal.Text = sum.ToString();
                }
                else
                {
                    sum -= 100000;
                    lbTotal.Text = sum.ToString();
                }

            }
            //click vào tẩy trắng
            else if (cb == cbTayTrang)
            {
                if (cbTayTrang.Checked)
                {
                    sum += 1200000;
                    lbTotal.Text = sum.ToString();
                }
                else
                {
                    sum -= 1200000;
                    lbTotal.Text = sum.ToString();
                }

            }
            //click vào Chụp hình răng.
            else
            {
                if (cbChupHinh.Checked)
                {
                    sum += 200000;
                    lbTotal.Text = sum.ToString();
                }
                else
                {
                    sum -= 200000;
                    lbTotal.Text = sum.ToString();
                }

            }
        }
        int slCu = 0;
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal num = numericUpDown1.Value;
            int slMoi = (int)num;
            if (slCu < slMoi)
            {
                lbTotal.Text = (Convert.ToInt32(lbTotal.Text) + 80000).ToString();
                slCu = slMoi;
            }
            else
            {
                lbTotal.Text = (Convert.ToInt32(lbTotal.Text) - 80000).ToString();
                slCu = slMoi;
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            tbTen.Text = string.Empty;
            cbCaoVoi.Checked = false;
            cbTayTrang.Checked = false;
            cbChupHinh.Checked = false;
            numericUpDown1.Value = 0;
            slCu = 0;
            lbTotal.Text = "0";
        }

        //câu 15; xử lý dữ liệu trong file.
        int count = 0;
        private void btXacNhan_Click(object sender, EventArgs e)
        {
            //lưu thong tin khách hàng mới vào file.
            count++;
            string hoTen = tbTen.Text;
            string tongTien = lbTotal.Text;
            string item = count + ". " + hoTen + "__" + tongTien+" vnđ.";
            lsbHistory.Items.Add(item);
            File.AppendAllText("history.txt", item+"\n");
        }

        private void Bai7_Load(object sender, EventArgs e)
        {
            //load dữ liệu trong file có sẵn
            string[] listb = File.ReadAllLines("history.txt");
            lsbHistory.Items.Clear();
            lsbHistory.Items.AddRange(listb);
            count = listb.Length;
            lbGiaCV.Text = String.Format("{0:N} đ", dongGia[0]);
            lbGiaTR.Text = String.Format("{0:N} đ", dongGia[1]);
            lbGiaCHR.Text = String.Format("{0:N} đ", dongGia[2]);
            lbTramRang.Text = String.Format("{0:N} đ/cai", dongGia[3]);
        }

        private void tbTen_TextChanged(object sender, EventArgs e)
        {
            if(tbTen.Text.Length > 0)
            {
                cbCaoVoi.Enabled = cbChupHinh.Enabled = cbTayTrang.Enabled = numericUpDown1.Enabled = btXacNhan.Enabled = true;
            }
            else
            {
                cbCaoVoi.Enabled = cbChupHinh.Enabled = cbTayTrang.Enabled = numericUpDown1.Enabled = btXacNhan.Enabled = false;
            }
        }

        private void btCaiDat_Click(object sender, EventArgs e)
        {
            Bai15 f = new Bai15();
            f.Show();

        }
    }
}
