
namespace QuanLiNhaHang
{
    partial class frmTrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangChu));
            this.lbintro = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbSVTH = new System.Windows.Forms.GroupBox();
            this.gbGVHD = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbSVTH.SuspendLayout();
            this.gbGVHD.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbintro
            // 
            this.lbintro.AutoSize = true;
            this.lbintro.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbintro.ForeColor = System.Drawing.Color.Red;
            this.lbintro.Location = new System.Drawing.Point(61, 38);
            this.lbintro.Name = "lbintro";
            this.lbintro.Size = new System.Drawing.Size(906, 38);
            this.lbintro.TabIndex = 0;
            this.lbintro.Text = "CHƯƠNG TRÌNH QUẢN LÍ NHÀ HÀNG NHẬT NGUYÊN";
            this.lbintro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbintro.Click += new System.EventHandler(this.lbintro_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 331);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lưu Thùy Minh Nhật- 2033210404";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Huỳnh Thảo Nguyên- 2033210471";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // gbSVTH
            // 
            this.gbSVTH.Controls.Add(this.label2);
            this.gbSVTH.Controls.Add(this.label3);
            this.gbSVTH.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSVTH.Location = new System.Drawing.Point(504, 131);
            this.gbSVTH.Name = "gbSVTH";
            this.gbSVTH.Size = new System.Drawing.Size(326, 101);
            this.gbSVTH.TabIndex = 5;
            this.gbSVTH.TabStop = false;
            this.gbSVTH.Text = "Sinh viên thực hiện";
            // 
            // gbGVHD
            // 
            this.gbGVHD.Controls.Add(this.label1);
            this.gbGVHD.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGVHD.Location = new System.Drawing.Point(504, 280);
            this.gbGVHD.Name = "gbGVHD";
            this.gbGVHD.Size = new System.Drawing.Size(326, 100);
            this.gbGVHD.TabIndex = 6;
            this.gbGVHD.TabStop = false;
            this.gbGVHD.Text = "Giảng Viên Hướng Dẫn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nguyễn Trọng Tiến";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.gbGVHD);
            this.Controls.Add(this.gbSVTH);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbintro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Trang chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbSVTH.ResumeLayout(false);
            this.gbSVTH.PerformLayout();
            this.gbGVHD.ResumeLayout(false);
            this.gbGVHD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbintro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbSVTH;
        private System.Windows.Forms.GroupBox gbGVHD;
        private System.Windows.Forms.Label label1;
    }
}