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
    public partial class Bai23 : Form
    {
        public static string tenDN;
        public Bai23()
        {
            Login f = new Login();
            f.ShowDialog();
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ListViewItem nv = new ListViewItem();
            nv.SubItems[0].Text = txtName.Text;
            nv.SubItems.Add(dtBirthDay.Value.ToString("MM/dd/yyyy"));
            nv.SubItems.Add(rdbFemale.Checked ? "Nữ" : "Nam");
            nv.ImageIndex = rdbFemale.Checked ? 0 : 1;
            listView1.Items.Add(nv);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                listView1.SelectedItems[0].SubItems[0].Text = txtName.Text;
                listView1.SelectedItems[0].SubItems[1].Text = dtBirthDay.Value.ToString("MM/dd/yyyy");
                listView1.SelectedItems[0].SubItems[2].Text = rdbFemale.Checked ? "Nữ" : "Nam";
                listView1.SelectedItems[0].ImageIndex = rdbFemale.Checked ? 0 : 1;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 1)
            {
                txtName.Text = listView1.SelectedItems[0].SubItems[0].Text;
                dtBirthDay.Text = listView1.SelectedItems[0].SubItems[1].Text;
                if (listView1.SelectedItems[0].SubItems[2].Text == "Nam")
                {
                    rdbMale.Checked = true;
                }   
                else
                {
                    rdbFemale.Checked = true;
                }    
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }    
        }

        private void Bai23_Load(object sender, EventArgs e)
        {
            lbTen.Text = tenDN;
        }
    }
}
