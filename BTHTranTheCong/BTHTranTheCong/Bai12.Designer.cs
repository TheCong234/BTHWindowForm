namespace BTHTranTheCong
{
    partial class Bai12
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbVanTruot = new System.Windows.Forms.Label();
            this.picBall = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbVanTruot
            // 
            this.lbVanTruot.BackColor = System.Drawing.Color.Lime;
            this.lbVanTruot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbVanTruot.Location = new System.Drawing.Point(149, 523);
            this.lbVanTruot.Margin = new System.Windows.Forms.Padding(0);
            this.lbVanTruot.Name = "lbVanTruot";
            this.lbVanTruot.Size = new System.Drawing.Size(250, 10);
            this.lbVanTruot.TabIndex = 1;
            // 
            // picBall
            // 
            this.picBall.Image = global::BTHTranTheCong.Properties.Resources.nemdepbai12;
            this.picBall.Location = new System.Drawing.Point(231, 187);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(88, 81);
            this.picBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBall.TabIndex = 0;
            this.picBall.TabStop = false;
            // 
            // Bai12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.lbVanTruot);
            this.Controls.Add(this.picBall);
            this.Name = "Bai12";
            this.Text = "Tâng bóng";
            this.Load += new System.EventHandler(this.Bai12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.Label lbVanTruot;
    }
}