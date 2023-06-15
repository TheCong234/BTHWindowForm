namespace BTHTranTheCong
{
    partial class Bai4
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
            this.tbSoB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btReset = new System.Windows.Forms.Button();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.tbSoA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtMod = new System.Windows.Forms.RadioButton();
            this.rdbtChia = new System.Windows.Forms.RadioButton();
            this.rdbtNhan = new System.Windows.Forms.RadioButton();
            this.rdbtTru = new System.Windows.Forms.RadioButton();
            this.rdbtCong = new System.Windows.Forms.RadioButton();
            this.btTinh = new System.Windows.Forms.Button();
            this.btDong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSoB
            // 
            this.tbSoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSoB.Location = new System.Drawing.Point(569, 168);
            this.tbSoB.Name = "tbSoB";
            this.tbSoB.Size = new System.Drawing.Size(103, 34);
            this.tbSoB.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(488, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 29);
            this.label3.TabIndex = 46;
            this.label3.Text = "Số B:";
            // 
            // btReset
            // 
            this.btReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btReset.Location = new System.Drawing.Point(454, 426);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(105, 39);
            this.btReset.TabIndex = 45;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // lbKetQua
            // 
            this.lbKetQua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbKetQua.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbKetQua.Location = new System.Drawing.Point(272, 357);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(287, 34);
            this.lbKetQua.TabIndex = 44;
            this.lbKetQua.Text = "0";
            this.lbKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSoA
            // 
            this.tbSoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSoA.Location = new System.Drawing.Point(215, 168);
            this.tbSoA.Name = "tbSoA";
            this.tbSoA.Size = new System.Drawing.Size(103, 34);
            this.tbSoA.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(127, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 29);
            this.label1.TabIndex = 42;
            this.label1.Text = "Số A:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Lime;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(56, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(697, 44);
            this.label4.TabIndex = 41;
            this.label4.Text = "Bài 4: Các phép tính đơn giản (update)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtMod);
            this.groupBox1.Controls.Add(this.rdbtChia);
            this.groupBox1.Controls.Add(this.rdbtNhan);
            this.groupBox1.Controls.Add(this.rdbtTru);
            this.groupBox1.Controls.Add(this.rdbtCong);
            this.groupBox1.Location = new System.Drawing.Point(132, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 108);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phép tính";
            // 
            // rdbtMod
            // 
            this.rdbtMod.AutoSize = true;
            this.rdbtMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbtMod.Location = new System.Drawing.Point(477, 40);
            this.rdbtMod.Name = "rdbtMod";
            this.rdbtMod.Size = new System.Drawing.Size(57, 33);
            this.rdbtMod.TabIndex = 4;
            this.rdbtMod.TabStop = true;
            this.rdbtMod.Text = "%";
            this.rdbtMod.UseVisualStyleBackColor = true;
            // 
            // rdbtChia
            // 
            this.rdbtChia.AutoSize = true;
            this.rdbtChia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbtChia.Location = new System.Drawing.Point(361, 40);
            this.rdbtChia.Name = "rdbtChia";
            this.rdbtChia.Size = new System.Drawing.Size(42, 33);
            this.rdbtChia.TabIndex = 3;
            this.rdbtChia.TabStop = true;
            this.rdbtChia.Text = "/";
            this.rdbtChia.UseVisualStyleBackColor = true;
            // 
            // rdbtNhan
            // 
            this.rdbtNhan.AutoSize = true;
            this.rdbtNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbtNhan.Location = new System.Drawing.Point(247, 40);
            this.rdbtNhan.Name = "rdbtNhan";
            this.rdbtNhan.Size = new System.Drawing.Size(45, 33);
            this.rdbtNhan.TabIndex = 2;
            this.rdbtNhan.TabStop = true;
            this.rdbtNhan.Text = "*";
            this.rdbtNhan.UseVisualStyleBackColor = true;
            // 
            // rdbtTru
            // 
            this.rdbtTru.AutoSize = true;
            this.rdbtTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbtTru.Location = new System.Drawing.Point(123, 40);
            this.rdbtTru.Name = "rdbtTru";
            this.rdbtTru.Size = new System.Drawing.Size(43, 33);
            this.rdbtTru.TabIndex = 1;
            this.rdbtTru.TabStop = true;
            this.rdbtTru.Text = "-";
            this.rdbtTru.UseVisualStyleBackColor = true;
            // 
            // rdbtCong
            // 
            this.rdbtCong.AutoSize = true;
            this.rdbtCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbtCong.Location = new System.Drawing.Point(6, 40);
            this.rdbtCong.Name = "rdbtCong";
            this.rdbtCong.Size = new System.Drawing.Size(49, 33);
            this.rdbtCong.TabIndex = 0;
            this.rdbtCong.TabStop = true;
            this.rdbtCong.Text = "+";
            this.rdbtCong.UseVisualStyleBackColor = true;
            // 
            // btTinh
            // 
            this.btTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btTinh.Location = new System.Drawing.Point(272, 426);
            this.btTinh.Name = "btTinh";
            this.btTinh.Size = new System.Drawing.Size(105, 39);
            this.btTinh.TabIndex = 49;
            this.btTinh.Text = "Tính";
            this.btTinh.UseVisualStyleBackColor = true;
            this.btTinh.Click += new System.EventHandler(this.btTinh_Click);
            // 
            // btDong
            // 
            this.btDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btDong.Location = new System.Drawing.Point(357, 492);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(105, 39);
            this.btDong.TabIndex = 50;
            this.btDong.Text = "Đóng";
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 565);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btTinh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbSoB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.tbSoA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "Bai4";
            this.Text = "Bai4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbSoB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.TextBox tbSoA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbtCong;
        private System.Windows.Forms.RadioButton rdbtMod;
        private System.Windows.Forms.RadioButton rdbtChia;
        private System.Windows.Forms.RadioButton rdbtNhan;
        private System.Windows.Forms.RadioButton rdbtTru;
        private System.Windows.Forms.Button btTinh;
        private System.Windows.Forms.Button btDong;
    }
}