namespace BTHTranTheCong
{
    partial class Bai7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bill = new System.Windows.Forms.TabControl();
            this.tabBill = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btXacNhan = new System.Windows.Forms.Button();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbChupHinh = new System.Windows.Forms.CheckBox();
            this.cbCaoVoi = new System.Windows.Forms.CheckBox();
            this.cbTayTrang = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btDong = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbGiaCV = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbGiaTR = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbGiaCHR = new System.Windows.Forms.Label();
            this.lbTramRang = new System.Windows.Forms.Label();
            this.lsbHistory = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabUpdate = new System.Windows.Forms.TabPage();
            this.tbTayRang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTramRang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbChupHinh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btUdXacNhan = new System.Windows.Forms.Button();
            this.tbCaoVoi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bill.SuspendLayout();
            this.tabBill.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // bill
            // 
            this.bill.Controls.Add(this.tabBill);
            this.bill.Controls.Add(this.tabUpdate);
            this.bill.Location = new System.Drawing.Point(12, 3);
            this.bill.Name = "bill";
            this.bill.SelectedIndex = 0;
            this.bill.Size = new System.Drawing.Size(943, 559);
            this.bill.TabIndex = 0;
            // 
            // tabBill
            // 
            this.tabBill.Controls.Add(this.groupBox1);
            this.tabBill.Controls.Add(this.lsbHistory);
            this.tabBill.Controls.Add(this.label9);
            this.tabBill.Location = new System.Drawing.Point(4, 25);
            this.tabBill.Name = "tabBill";
            this.tabBill.Padding = new System.Windows.Forms.Padding(3);
            this.tabBill.Size = new System.Drawing.Size(935, 530);
            this.tabBill.TabIndex = 0;
            this.tabBill.Text = "Bill";
            this.tabBill.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox1.Controls.Add(this.btXacNhan);
            this.groupBox1.Controls.Add(this.tbTen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbChupHinh);
            this.groupBox1.Controls.Add(this.cbCaoVoi);
            this.groupBox1.Controls.Add(this.cbTayTrang);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.btDong);
            this.groupBox1.Controls.Add(this.btReset);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbGiaCV);
            this.groupBox1.Controls.Add(this.lbTotal);
            this.groupBox1.Controls.Add(this.lbGiaTR);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbGiaCHR);
            this.groupBox1.Controls.Add(this.lbTramRang);
            this.groupBox1.Location = new System.Drawing.Point(7, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(548, 432);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn dịch vụ";
            // 
            // btXacNhan
            // 
            this.btXacNhan.Enabled = false;
            this.btXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXacNhan.Location = new System.Drawing.Point(219, 379);
            this.btXacNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btXacNhan.Name = "btXacNhan";
            this.btXacNhan.Size = new System.Drawing.Size(145, 39);
            this.btXacNhan.TabIndex = 16;
            this.btXacNhan.Text = "Xác nhận";
            this.btXacNhan.UseVisualStyleBackColor = true;
            this.btXacNhan.Click += new System.EventHandler(this.btXacNhan_Click);
            // 
            // tbTen
            // 
            this.tbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTen.Location = new System.Drawing.Point(235, 39);
            this.tbTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(289, 34);
            this.tbTen.TabIndex = 1;
            this.tbTen.TextChanged += new System.EventHandler(this.tbTen_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(19, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách hàng:";
            // 
            // cbChupHinh
            // 
            this.cbChupHinh.AutoSize = true;
            this.cbChupHinh.Enabled = false;
            this.cbChupHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbChupHinh.Location = new System.Drawing.Point(23, 215);
            this.cbChupHinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbChupHinh.Name = "cbChupHinh";
            this.cbChupHinh.Size = new System.Drawing.Size(197, 33);
            this.cbChupHinh.TabIndex = 15;
            this.cbChupHinh.Text = "Chụp hình răng";
            this.cbChupHinh.UseVisualStyleBackColor = true;
            this.cbChupHinh.Click += new System.EventHandler(this.cbCaoVoi_CheckedChanged);
            // 
            // cbCaoVoi
            // 
            this.cbCaoVoi.AutoSize = true;
            this.cbCaoVoi.Enabled = false;
            this.cbCaoVoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbCaoVoi.Location = new System.Drawing.Point(23, 110);
            this.cbCaoVoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCaoVoi.Name = "cbCaoVoi";
            this.cbCaoVoi.Size = new System.Drawing.Size(116, 33);
            this.cbCaoVoi.TabIndex = 2;
            this.cbCaoVoi.Text = "Cạo vôi";
            this.cbCaoVoi.UseVisualStyleBackColor = true;
            this.cbCaoVoi.Click += new System.EventHandler(this.cbCaoVoi_CheckedChanged);
            // 
            // cbTayTrang
            // 
            this.cbTayTrang.AutoSize = true;
            this.cbTayTrang.Enabled = false;
            this.cbTayTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbTayTrang.Location = new System.Drawing.Point(23, 162);
            this.cbTayTrang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTayTrang.Name = "cbTayTrang";
            this.cbTayTrang.Size = new System.Drawing.Size(129, 33);
            this.cbTayTrang.TabIndex = 14;
            this.cbTayTrang.Text = "Tẩy răng";
            this.cbTayTrang.UseVisualStyleBackColor = true;
            this.cbTayTrang.Click += new System.EventHandler(this.cbCaoVoi_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numericUpDown1.Location = new System.Drawing.Point(165, 270);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(69, 34);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Click += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btDong
            // 
            this.btDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btDong.Location = new System.Drawing.Point(449, 379);
            this.btDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(93, 39);
            this.btDong.TabIndex = 13;
            this.btDong.Text = "Đóng";
            this.btDong.UseVisualStyleBackColor = true;
            // 
            // btReset
            // 
            this.btReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btReset.Location = new System.Drawing.Point(23, 379);
            this.btReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(93, 39);
            this.btReset.TabIndex = 4;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(19, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Trám răng";
            // 
            // lbGiaCV
            // 
            this.lbGiaCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGiaCV.Location = new System.Drawing.Point(279, 96);
            this.lbGiaCV.Name = "lbGiaCV";
            this.lbGiaCV.Size = new System.Drawing.Size(247, 30);
            this.lbGiaCV.TabIndex = 11;
            this.lbGiaCV.Text = "0";
            this.lbGiaCV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTotal
            // 
            this.lbTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTotal.Location = new System.Drawing.Point(389, 326);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(135, 29);
            this.lbTotal.TabIndex = 6;
            this.lbTotal.Text = "0";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbGiaTR
            // 
            this.lbGiaTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGiaTR.Location = new System.Drawing.Point(284, 161);
            this.lbGiaTR.Name = "lbGiaTR";
            this.lbGiaTR.Size = new System.Drawing.Size(241, 30);
            this.lbGiaTR.TabIndex = 10;
            this.lbGiaTR.Text = "0";
            this.lbGiaTR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(309, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total:";
            // 
            // lbGiaCHR
            // 
            this.lbGiaCHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGiaCHR.Location = new System.Drawing.Point(284, 214);
            this.lbGiaCHR.Name = "lbGiaCHR";
            this.lbGiaCHR.Size = new System.Drawing.Size(241, 30);
            this.lbGiaCHR.TabIndex = 9;
            this.lbGiaCHR.Text = "0";
            this.lbGiaCHR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTramRang
            // 
            this.lbTramRang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTramRang.Location = new System.Drawing.Point(284, 268);
            this.lbTramRang.Name = "lbTramRang";
            this.lbTramRang.Size = new System.Drawing.Size(241, 30);
            this.lbTramRang.TabIndex = 8;
            this.lbTramRang.Text = "0";
            this.lbTramRang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lsbHistory
            // 
            this.lsbHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lsbHistory.FormattingEnabled = true;
            this.lsbHistory.ItemHeight = 25;
            this.lsbHistory.Location = new System.Drawing.Point(583, 99);
            this.lsbHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsbHistory.Name = "lsbHistory";
            this.lsbHistory.Size = new System.Drawing.Size(343, 379);
            this.lsbHistory.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.IndianRed;
            this.label9.Location = new System.Drawing.Point(76, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(398, 45);
            this.label9.TabIndex = 18;
            this.label9.Text = "Dental Payment Form";
            // 
            // tabUpdate
            // 
            this.tabUpdate.Controls.Add(this.tbTayRang);
            this.tabUpdate.Controls.Add(this.label5);
            this.tabUpdate.Controls.Add(this.tbTramRang);
            this.tabUpdate.Controls.Add(this.label3);
            this.tabUpdate.Controls.Add(this.tbChupHinh);
            this.tabUpdate.Controls.Add(this.label6);
            this.tabUpdate.Controls.Add(this.btUdXacNhan);
            this.tabUpdate.Controls.Add(this.tbCaoVoi);
            this.tabUpdate.Controls.Add(this.label7);
            this.tabUpdate.Controls.Add(this.label8);
            this.tabUpdate.Location = new System.Drawing.Point(4, 25);
            this.tabUpdate.Name = "tabUpdate";
            this.tabUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdate.Size = new System.Drawing.Size(935, 530);
            this.tabUpdate.TabIndex = 1;
            this.tabUpdate.Text = "Update";
            this.tabUpdate.UseVisualStyleBackColor = true;
            // 
            // tbTayRang
            // 
            this.tbTayRang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTayRang.Location = new System.Drawing.Point(195, 119);
            this.tbTayRang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTayRang.Name = "tbTayRang";
            this.tbTayRang.Size = new System.Drawing.Size(129, 30);
            this.tbTayRang.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(56, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Trám răng";
            // 
            // tbTramRang
            // 
            this.tbTramRang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTramRang.Location = new System.Drawing.Point(195, 193);
            this.tbTramRang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTramRang.Name = "tbTramRang";
            this.tbTramRang.Size = new System.Drawing.Size(129, 30);
            this.tbTramRang.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(71, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tẩy răng";
            // 
            // tbChupHinh
            // 
            this.tbChupHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbChupHinh.Location = new System.Drawing.Point(195, 156);
            this.tbChupHinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbChupHinh.Name = "tbChupHinh";
            this.tbChupHinh.Size = new System.Drawing.Size(129, 30);
            this.tbChupHinh.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(8, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Chụp hình răng";
            // 
            // btUdXacNhan
            // 
            this.btUdXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btUdXacNhan.Location = new System.Drawing.Point(195, 257);
            this.btUdXacNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btUdXacNhan.Name = "btUdXacNhan";
            this.btUdXacNhan.Size = new System.Drawing.Size(131, 34);
            this.btUdXacNhan.TabIndex = 13;
            this.btUdXacNhan.Text = "Xác nhận";
            this.btUdXacNhan.UseVisualStyleBackColor = true;
            this.btUdXacNhan.Click += new System.EventHandler(this.btUdXacNhan_Click);
            // 
            // tbCaoVoi
            // 
            this.tbCaoVoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbCaoVoi.Location = new System.Drawing.Point(195, 82);
            this.tbCaoVoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCaoVoi.Name = "tbCaoVoi";
            this.tbCaoVoi.Size = new System.Drawing.Size(129, 30);
            this.tbCaoVoi.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(83, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cạo vôi";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Yellow;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(6, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 36);
            this.label8.TabIndex = 10;
            this.label8.Text = "Cập nhật bảng giá";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bai7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 769);
            this.Controls.Add(this.bill);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Bai7";
            this.Text = "Bai7";
            this.Load += new System.EventHandler(this.Bai7_Load);
            this.bill.ResumeLayout(false);
            this.tabBill.ResumeLayout(false);
            this.tabBill.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabUpdate.ResumeLayout(false);
            this.tabUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl bill;
        private System.Windows.Forms.TabPage tabBill;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btXacNhan;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbChupHinh;
        private System.Windows.Forms.CheckBox cbCaoVoi;
        private System.Windows.Forms.CheckBox cbTayTrang;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btDong;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbGiaCV;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbGiaTR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbGiaCHR;
        private System.Windows.Forms.Label lbTramRang;
        private System.Windows.Forms.ListBox lsbHistory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabUpdate;
        private System.Windows.Forms.TextBox tbTayRang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTramRang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbChupHinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btUdXacNhan;
        private System.Windows.Forms.TextBox tbCaoVoi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}