namespace BTHTranTheCong
{
    partial class Bai14
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
            this.btCapNhat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.lbxLopA = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbxLopB = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btBeBe = new System.Windows.Forms.Button();
            this.btLonLon = new System.Windows.Forms.Button();
            this.btBe = new System.Windows.Forms.Button();
            this.btLon = new System.Windows.Forms.Button();
            this.btKetThuc = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCapNhat
            // 
            this.btCapNhat.AutoSize = true;
            this.btCapNhat.Location = new System.Drawing.Point(657, 130);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(118, 39);
            this.btCapNhat.TabIndex = 0;
            this.btCapNhat.Text = "Cập nhật";
            this.btCapNhat.UseVisualStyleBackColor = true;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(130, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(645, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bài 14: Danh sách sinh viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbHoTen
            // 
            this.tbHoTen.Location = new System.Drawing.Point(300, 132);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(326, 34);
            this.tbHoTen.TabIndex = 2;
            // 
            // lbxLopA
            // 
            this.lbxLopA.FormattingEnabled = true;
            this.lbxLopA.ItemHeight = 29;
            this.lbxLopA.Location = new System.Drawing.Point(6, 33);
            this.lbxLopA.Name = "lbxLopA";
            this.lbxLopA.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxLopA.Size = new System.Drawing.Size(326, 352);
            this.lbxLopA.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.groupBox1.Controls.Add(this.lbxLopA);
            this.groupBox1.Location = new System.Drawing.Point(19, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 397);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lớp A:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Controls.Add(this.lbxLopB);
            this.groupBox2.Location = new System.Drawing.Point(542, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 397);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp B:";
            // 
            // lbxLopB
            // 
            this.lbxLopB.FormattingEnabled = true;
            this.lbxLopB.ItemHeight = 29;
            this.lbxLopB.Location = new System.Drawing.Point(6, 33);
            this.lbxLopB.Name = "lbxLopB";
            this.lbxLopB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxLopB.Size = new System.Drawing.Size(326, 352);
            this.lbxLopB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Họ và Tên:";
            // 
            // btBeBe
            // 
            this.btBeBe.AutoSize = true;
            this.btBeBe.Location = new System.Drawing.Point(460, 407);
            this.btBeBe.Name = "btBeBe";
            this.btBeBe.Size = new System.Drawing.Size(77, 39);
            this.btBeBe.TabIndex = 7;
            this.btBeBe.Text = "<<";
            this.btBeBe.UseVisualStyleBackColor = true;
            this.btBeBe.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btLonLon
            // 
            this.btLonLon.AutoSize = true;
            this.btLonLon.Location = new System.Drawing.Point(372, 407);
            this.btLonLon.Name = "btLonLon";
            this.btLonLon.Size = new System.Drawing.Size(82, 39);
            this.btLonLon.TabIndex = 8;
            this.btLonLon.Text = ">>";
            this.btLonLon.UseVisualStyleBackColor = true;
            this.btLonLon.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btBe
            // 
            this.btBe.AutoSize = true;
            this.btBe.Location = new System.Drawing.Point(460, 331);
            this.btBe.Name = "btBe";
            this.btBe.Size = new System.Drawing.Size(77, 39);
            this.btBe.TabIndex = 9;
            this.btBe.Text = "<";
            this.btBe.UseVisualStyleBackColor = true;
            this.btBe.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btLon
            // 
            this.btLon.AutoSize = true;
            this.btLon.Location = new System.Drawing.Point(372, 331);
            this.btLon.Name = "btLon";
            this.btLon.Size = new System.Drawing.Size(82, 39);
            this.btLon.TabIndex = 10;
            this.btLon.Text = ">";
            this.btLon.UseVisualStyleBackColor = true;
            this.btLon.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btKetThuc
            // 
            this.btKetThuc.AutoSize = true;
            this.btKetThuc.Location = new System.Drawing.Point(530, 33);
            this.btKetThuc.Name = "btKetThuc";
            this.btKetThuc.Size = new System.Drawing.Size(109, 39);
            this.btKetThuc.TabIndex = 11;
            this.btKetThuc.Text = "Kết thúc";
            this.btKetThuc.UseVisualStyleBackColor = true;
            this.btKetThuc.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btXoa
            // 
            this.btXoa.AutoSize = true;
            this.btXoa.Location = new System.Drawing.Point(22, 31);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(102, 39);
            this.btXoa.TabIndex = 12;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btReset
            // 
            this.btReset.AutoSize = true;
            this.btReset.Location = new System.Drawing.Point(261, 33);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(109, 39);
            this.btReset.TabIndex = 13;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox3.Controls.Add(this.btXoa);
            this.groupBox3.Controls.Add(this.btKetThuc);
            this.groupBox3.Controls.Add(this.btReset);
            this.groupBox3.Location = new System.Drawing.Point(130, 596);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(645, 76);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // Bai14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(901, 715);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btLon);
            this.Controls.Add(this.btBe);
            this.Controls.Add(this.btLonLon);
            this.Controls.Add(this.btBeBe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbHoTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCapNhat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Bai14";
            this.Text = "Quản lý sinh viên";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.ListBox lbxLopA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbxLopB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btBeBe;
        private System.Windows.Forms.Button btLonLon;
        private System.Windows.Forms.Button btBe;
        private System.Windows.Forms.Button btLon;
        private System.Windows.Forms.Button btKetThuc;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}