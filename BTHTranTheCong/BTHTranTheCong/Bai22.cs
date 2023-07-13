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
    public partial class Bai22 : Form
    {
        public Bai22()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtHoTen.Text.Length != 0 || txtHoTen.Text != " ")
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = txtHoTen.Text;
                item.SubItems.Add(dtpNgaySinh.Text);
                item.SubItems.Add(cbBangCap.Text);
                item.SubItems.Add(txtDienThoai.Text);
                item.SubItems.Add(txtDiaChi.Text);
                lsvNhanvien.Items.Add(item);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lsvNhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsvNhanvien.SelectedItems.Count == 1)
            {
                txtHoTen.Text = lsvNhanvien.SelectedItems[0].SubItems[0].Text;
                dtpNgaySinh.Text = lsvNhanvien.SelectedItems[0].SubItems[1].Text;
                cbBangCap.Text = lsvNhanvien.SelectedItems[0].SubItems[2].Text;
                txtDienThoai.Text = lsvNhanvien.SelectedItems[0].SubItems[3].Text;
                txtDiaChi.Text = lsvNhanvien.SelectedItems[0].SubItems[4].Text;
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lsvNhanvien.SelectedItems)
            {
                lsvNhanvien.Items.Remove(item);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvNhanvien.SelectedItems.Count == 1)
            {
                lsvNhanvien.SelectedItems[0].SubItems[0].Text = txtHoTen.Text;
                lsvNhanvien.SelectedItems[0].SubItems[1].Text = dtpNgaySinh.Text;
                lsvNhanvien.SelectedItems[0].SubItems[2].Text = cbBangCap.Text;
                lsvNhanvien.SelectedItems[0].SubItems[3].Text = txtDienThoai.Text;
                lsvNhanvien.SelectedItems[0].SubItems[4].Text = txtDiaChi.Text;
            }
        }
    }
}
