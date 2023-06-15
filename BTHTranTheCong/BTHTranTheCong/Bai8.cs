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
    public partial class Bai8 : Form
    {
        public Bai8()
        {
            InitializeComponent();
        }
        public void EventEnter()
        {
            string code = tbCode.Text;
            if (code == "")
                MessageBox.Show("Vui lòng nhập Security code.");
            else
            {
                DateTime dt = DateTime.Now;
                string gio = (DateTime.Now).ToString();
                if (code.Equals("1645") || code.Equals("1689"))
                {
                    lbHistory.Items.Add(gio + "\t\tTechnicians");
                }
                else if (code.Equals("8345"))
                {
                    lbHistory.Items.Add(gio + "\t\tCustodians");
                }
                else if (code.Equals("9998") || code.Equals("1006") || code.Equals("1008"))
                {
                    lbHistory.Items.Add(gio + "\t\tScientist");
                }
                else
                {
                    lbHistory.Items.Add(gio + "\t\tRestricted Access!");
                }
            }
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            EventEnter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSo1_Click(object sender, EventArgs e)
        {
            try
            {
                Button bt = (Button)sender;
                if (bt.Text == "C")
                {
                    string nhap = tbCode.Text;
                    nhap = nhap.Remove(nhap.Length - 1);
                    tbCode.Text = nhap;
                }
                else
                {
                    tbCode.Text += bt.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                EventEnter();
                return true;
            }
            if (keyData == Keys.Escape)
            {
                //tbCode.Text = keyData.ToString();
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        
    }
}
