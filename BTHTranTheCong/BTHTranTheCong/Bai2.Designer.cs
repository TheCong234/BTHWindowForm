namespace BTHTranTheCong
{
    partial class Bai2
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
            this.label4 = new System.Windows.Forms.Label();
            this.btTinhTong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.btĐóng = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Lime;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(180, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(466, 44);
            this.label4.TabIndex = 21;
            this.label4.Text = "Bài 2: Tính tổng từ 1 tới N";
            // 
            // btTinhTong
            // 
            this.btTinhTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btTinhTong.Location = new System.Drawing.Point(215, 295);
            this.btTinhTong.Name = "btTinhTong";
            this.btTinhTong.Size = new System.Drawing.Size(156, 39);
            this.btTinhTong.TabIndex = 22;
            this.btTinhTong.Text = "Tính Tổng";
            this.btTinhTong.UseVisualStyleBackColor = true;
            this.btTinhTong.Click += new System.EventHandler(this.btTinhTong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(210, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nhập N:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(210, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tổng:";
            // 
            // tbNum
            // 
            this.tbNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbNum.Location = new System.Drawing.Point(321, 117);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(287, 34);
            this.tbNum.TabIndex = 25;
            // 
            // lbKetQua
            // 
            this.lbKetQua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbKetQua.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbKetQua.Location = new System.Drawing.Point(321, 188);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(287, 34);
            this.lbKetQua.TabIndex = 26;
            // 
            // btĐóng
            // 
            this.btĐóng.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btĐóng.Location = new System.Drawing.Point(370, 367);
            this.btĐóng.Name = "btĐóng";
            this.btĐóng.Size = new System.Drawing.Size(105, 39);
            this.btĐóng.TabIndex = 27;
            this.btĐóng.Text = "Đóng";
            this.btĐóng.UseVisualStyleBackColor = true;
            this.btĐóng.Click += new System.EventHandler(this.btĐóng_Click);
            // 
            // btReset
            // 
            this.btReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btReset.Location = new System.Drawing.Point(476, 295);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(132, 39);
            this.btReset.TabIndex = 28;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btĐóng);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.tbNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btTinhTong);
            this.Controls.Add(this.label4);
            this.Name = "Bai2";
            this.Text = "Tính Tổng (1 tới n)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btTinhTong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.Button btĐóng;
        private System.Windows.Forms.Button btReset;
    }
}