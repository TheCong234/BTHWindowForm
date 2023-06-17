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
            this.label1 = new System.Windows.Forms.Label();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.cbCaoVoi = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTramRang = new System.Windows.Forms.Label();
            this.lbGiaCHR = new System.Windows.Forms.Label();
            this.lbGiaTR = new System.Windows.Forms.Label();
            this.lbGiaCV = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btDong = new System.Windows.Forms.Button();
            this.cbTayTrang = new System.Windows.Forms.CheckBox();
            this.cbChupHinh = new System.Windows.Forms.CheckBox();
            this.lsbHistory = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btCaiDat = new System.Windows.Forms.Button();
            this.btXacNhan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách hàng:";
            // 
            // tbTen
            // 
            this.tbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTen.Location = new System.Drawing.Point(176, 32);
            this.tbTen.Margin = new System.Windows.Forms.Padding(2);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(218, 29);
            this.tbTen.TabIndex = 1;
            this.tbTen.TextChanged += new System.EventHandler(this.tbTen_TextChanged);
            // 
            // cbCaoVoi
            // 
            this.cbCaoVoi.AutoSize = true;
            this.cbCaoVoi.Enabled = false;
            this.cbCaoVoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbCaoVoi.Location = new System.Drawing.Point(17, 89);
            this.cbCaoVoi.Margin = new System.Windows.Forms.Padding(2);
            this.cbCaoVoi.Name = "cbCaoVoi";
            this.cbCaoVoi.Size = new System.Drawing.Size(92, 28);
            this.cbCaoVoi.TabIndex = 2;
            this.cbCaoVoi.Text = "Cạo vôi";
            this.cbCaoVoi.UseVisualStyleBackColor = true;
            this.cbCaoVoi.CheckedChanged += new System.EventHandler(this.cbCaoVoi_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numericUpDown1.Location = new System.Drawing.Point(124, 219);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(52, 29);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btReset
            // 
            this.btReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btReset.Location = new System.Drawing.Point(17, 308);
            this.btReset.Margin = new System.Windows.Forms.Padding(2);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(70, 32);
            this.btReset.TabIndex = 4;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(14, 220);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Trám răng";
            // 
            // lbTotal
            // 
            this.lbTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTotal.Location = new System.Drawing.Point(292, 265);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(102, 24);
            this.lbTotal.TabIndex = 6;
            this.lbTotal.Text = "0";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(232, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total:";
            // 
            // lbTramRang
            // 
            this.lbTramRang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTramRang.Location = new System.Drawing.Point(213, 218);
            this.lbTramRang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTramRang.Name = "lbTramRang";
            this.lbTramRang.Size = new System.Drawing.Size(181, 24);
            this.lbTramRang.TabIndex = 8;
            this.lbTramRang.Text = "0";
            this.lbTramRang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbGiaCHR
            // 
            this.lbGiaCHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGiaCHR.Location = new System.Drawing.Point(213, 174);
            this.lbGiaCHR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGiaCHR.Name = "lbGiaCHR";
            this.lbGiaCHR.Size = new System.Drawing.Size(181, 24);
            this.lbGiaCHR.TabIndex = 9;
            this.lbGiaCHR.Text = "0";
            this.lbGiaCHR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbGiaTR
            // 
            this.lbGiaTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGiaTR.Location = new System.Drawing.Point(213, 131);
            this.lbGiaTR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGiaTR.Name = "lbGiaTR";
            this.lbGiaTR.Size = new System.Drawing.Size(181, 24);
            this.lbGiaTR.TabIndex = 10;
            this.lbGiaTR.Text = "0";
            this.lbGiaTR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbGiaCV
            // 
            this.lbGiaCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGiaCV.Location = new System.Drawing.Point(209, 78);
            this.lbGiaCV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGiaCV.Name = "lbGiaCV";
            this.lbGiaCV.Size = new System.Drawing.Size(185, 24);
            this.lbGiaCV.TabIndex = 11;
            this.lbGiaCV.Text = "0";
            this.lbGiaCV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.IndianRed;
            this.label9.Location = new System.Drawing.Point(72, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(320, 36);
            this.label9.TabIndex = 12;
            this.label9.Text = "Dental Payment Form";
            // 
            // btDong
            // 
            this.btDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btDong.Location = new System.Drawing.Point(337, 308);
            this.btDong.Margin = new System.Windows.Forms.Padding(2);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(70, 32);
            this.btDong.TabIndex = 13;
            this.btDong.Text = "Đóng";
            this.btDong.UseVisualStyleBackColor = true;
            // 
            // cbTayTrang
            // 
            this.cbTayTrang.AutoSize = true;
            this.cbTayTrang.Enabled = false;
            this.cbTayTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbTayTrang.Location = new System.Drawing.Point(17, 132);
            this.cbTayTrang.Margin = new System.Windows.Forms.Padding(2);
            this.cbTayTrang.Name = "cbTayTrang";
            this.cbTayTrang.Size = new System.Drawing.Size(103, 28);
            this.cbTayTrang.TabIndex = 14;
            this.cbTayTrang.Text = "Tẩy răng";
            this.cbTayTrang.UseVisualStyleBackColor = true;
            this.cbTayTrang.Click += new System.EventHandler(this.cbCaoVoi_CheckedChanged);
            // 
            // cbChupHinh
            // 
            this.cbChupHinh.AutoSize = true;
            this.cbChupHinh.Enabled = false;
            this.cbChupHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbChupHinh.Location = new System.Drawing.Point(17, 175);
            this.cbChupHinh.Margin = new System.Windows.Forms.Padding(2);
            this.cbChupHinh.Name = "cbChupHinh";
            this.cbChupHinh.Size = new System.Drawing.Size(160, 28);
            this.cbChupHinh.TabIndex = 15;
            this.cbChupHinh.Text = "Chụp hình răng";
            this.cbChupHinh.UseVisualStyleBackColor = true;
            this.cbChupHinh.Click += new System.EventHandler(this.cbCaoVoi_CheckedChanged);
            // 
            // lsbHistory
            // 
            this.lsbHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lsbHistory.FormattingEnabled = true;
            this.lsbHistory.ItemHeight = 20;
            this.lsbHistory.Location = new System.Drawing.Point(452, 88);
            this.lsbHistory.Margin = new System.Windows.Forms.Padding(2);
            this.lsbHistory.Name = "lsbHistory";
            this.lsbHistory.Size = new System.Drawing.Size(258, 324);
            this.lsbHistory.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox1.Controls.Add(this.btCaiDat);
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
            this.groupBox1.Location = new System.Drawing.Point(20, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(411, 351);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn dịch vụ";
            // 
            // btCaiDat
            // 
            this.btCaiDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btCaiDat.Location = new System.Drawing.Point(236, 308);
            this.btCaiDat.Margin = new System.Windows.Forms.Padding(2);
            this.btCaiDat.Name = "btCaiDat";
            this.btCaiDat.Size = new System.Drawing.Size(88, 32);
            this.btCaiDat.TabIndex = 17;
            this.btCaiDat.Text = "Cài đặt";
            this.btCaiDat.UseVisualStyleBackColor = true;
            this.btCaiDat.Click += new System.EventHandler(this.btCaiDat_Click);
            // 
            // btXacNhan
            // 
            this.btXacNhan.Enabled = false;
            this.btXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXacNhan.Location = new System.Drawing.Point(106, 308);
            this.btXacNhan.Margin = new System.Windows.Forms.Padding(2);
            this.btXacNhan.Name = "btXacNhan";
            this.btXacNhan.Size = new System.Drawing.Size(109, 32);
            this.btXacNhan.TabIndex = 16;
            this.btXacNhan.Text = "Xác nhận";
            this.btXacNhan.UseVisualStyleBackColor = true;
            this.btXacNhan.Click += new System.EventHandler(this.btXacNhan_Click);
            // 
            // Bai7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 425);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lsbHistory);
            this.Controls.Add(this.label9);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Bai7";
            this.Text = "Bai7";
            this.Load += new System.EventHandler(this.Bai7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.CheckBox cbCaoVoi;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTramRang;
        private System.Windows.Forms.Label lbGiaCHR;
        private System.Windows.Forms.Label lbGiaTR;
        private System.Windows.Forms.Label lbGiaCV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btDong;
        private System.Windows.Forms.CheckBox cbTayTrang;
        private System.Windows.Forms.CheckBox cbChupHinh;
        private System.Windows.Forms.ListBox lsbHistory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btXacNhan;
        private System.Windows.Forms.Button btCaiDat;
    }
}