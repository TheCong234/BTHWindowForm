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
    public partial class Bai14 : Form
    {
        public Bai14()
        {
            InitializeComponent();
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            string singVien = tbHoTen.Text;
            lbxLopA.Items.Add(singVien);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                Button bt = (Button)sender;
                ListBox.SelectedObjectCollection dsA = lbxLopA.SelectedItems;
                ListBox.SelectedObjectCollection dsB = lbxLopB.SelectedItems;
                switch (bt.Text)
                {
                    case "Xóa":
                        for (int i = dsA.Count - 1; i >= 0; i--)
                        {
                            lbxLopA.Items.Remove(dsA[i]);
                        }
                        for (int i = dsB.Count - 1; i >= 0; i--)
                        {
                            lbxLopB.Items.Remove(dsB[i]);
                        }
                        break;
                    //chuyển nhiều từ A qua B
                    case ">":
                        foreach (string item in dsA)
                        {
                            lbxLopB.Items.Add(item);
                        }
                        for (int i = dsA.Count - 1; i >= 0; i--)
                        {
                            lbxLopA.Items.Remove(dsA[i]);
                        }
                        break;
                    //Chuyển nhiều từ b qua A
                    case "<":
                        foreach (string item in dsB)
                        {
                            lbxLopA.Items.Add(item);
                        }
                        for (int i = dsB.Count - 1; i >= 0; i--)
                        {
                            lbxLopB.Items.Remove(dsB[i]);
                        }
                        break;
                    //Chuyển hết từ a qua b
                    case ">>":
                        lbxLopB.Items.AddRange(lbxLopA.Items);
                        lbxLopA.Items.Clear();
                        break;
                    //Chuyển hết từ b qua A
                    case "<<":
                        lbxLopA.Items.AddRange(lbxLopB.Items);
                        lbxLopB.Items.Clear();
                        break;
                    case "Reset":
                        lbxLopA.Items.Clear();
                        lbxLopB.Items.Clear();
                        tbHoTen.Text = string.Empty;
                        break;
                    case "Kết thúc":
                        Close();
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
              
            
        }
    }
}
