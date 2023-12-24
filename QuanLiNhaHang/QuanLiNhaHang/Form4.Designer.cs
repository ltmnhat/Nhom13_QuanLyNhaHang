
namespace QuanLiNhaHang
{
    partial class frmqlNhanVien
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
            this.gbTTNV = new System.Windows.Forms.GroupBox();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.txtLuongNhanVien = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.lbL = new System.Windows.Forms.Label();
            this.lbCV = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMNV = new System.Windows.Forms.Label();
            this.gbDSNV = new System.Windows.Forms.GroupBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.gbTTNV.SuspendLayout();
            this.gbDSNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTTNV
            // 
            this.gbTTNV.Controls.Add(this.btnXoaNV);
            this.gbTTNV.Controls.Add(this.btnSuaNV);
            this.gbTTNV.Controls.Add(this.btnThoat);
            this.gbTTNV.Controls.Add(this.btnThemNV);
            this.gbTTNV.Controls.Add(this.txtLuongNhanVien);
            this.gbTTNV.Controls.Add(this.txtTenNhanVien);
            this.gbTTNV.Controls.Add(this.txtChucVu);
            this.gbTTNV.Controls.Add(this.txtMaNhanVien);
            this.gbTTNV.Controls.Add(this.lbL);
            this.gbTTNV.Controls.Add(this.lbCV);
            this.gbTTNV.Controls.Add(this.label2);
            this.gbTTNV.Controls.Add(this.lbMNV);
            this.gbTTNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTTNV.Location = new System.Drawing.Point(47, 13);
            this.gbTTNV.Margin = new System.Windows.Forms.Padding(4);
            this.gbTTNV.Name = "gbTTNV";
            this.gbTTNV.Padding = new System.Windows.Forms.Padding(4);
            this.gbTTNV.Size = new System.Drawing.Size(831, 166);
            this.gbTTNV.TabIndex = 0;
            this.gbTTNV.TabStop = false;
            this.gbTTNV.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNV.Location = new System.Drawing.Point(502, 122);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(75, 37);
            this.btnXoaNV.TabIndex = 11;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.UseVisualStyleBackColor = true;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNV.Location = new System.Drawing.Point(608, 122);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(75, 37);
            this.btnSuaNV.TabIndex = 10;
            this.btnSuaNV.Text = "Sửa";
            this.btnSuaNV.UseVisualStyleBackColor = true;
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(708, 122);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 37);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNV.Location = new System.Drawing.Point(406, 122);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(75, 37);
            this.btnThemNV.TabIndex = 8;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // txtLuongNhanVien
            // 
            this.txtLuongNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLuongNhanVien.Location = new System.Drawing.Point(577, 69);
            this.txtLuongNhanVien.Name = "txtLuongNhanVien";
            this.txtLuongNhanVien.Size = new System.Drawing.Size(206, 30);
            this.txtLuongNhanVien.TabIndex = 7;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenNhanVien.Location = new System.Drawing.Point(577, 23);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(206, 30);
            this.txtTenNhanVien.TabIndex = 6;
            // 
            // txtChucVu
            // 
            this.txtChucVu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChucVu.Location = new System.Drawing.Point(150, 69);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(206, 30);
            this.txtChucVu.TabIndex = 5;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNhanVien.Location = new System.Drawing.Point(150, 27);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(206, 30);
            this.txtMaNhanVien.TabIndex = 4;
            // 
            // lbL
            // 
            this.lbL.AutoSize = true;
            this.lbL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbL.Location = new System.Drawing.Point(451, 69);
            this.lbL.Name = "lbL";
            this.lbL.Size = new System.Drawing.Size(67, 22);
            this.lbL.TabIndex = 3;
            this.lbL.Text = "Lương:";
            // 
            // lbCV
            // 
            this.lbCV.AutoSize = true;
            this.lbCV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCV.Location = new System.Drawing.Point(27, 70);
            this.lbCV.Name = "lbCV";
            this.lbCV.Size = new System.Drawing.Size(82, 22);
            this.lbCV.TabIndex = 2;
            this.lbCV.Text = "Chức vụ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(451, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên:";
            // 
            // lbMNV
            // 
            this.lbMNV.AutoSize = true;
            this.lbMNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMNV.Location = new System.Drawing.Point(27, 27);
            this.lbMNV.Name = "lbMNV";
            this.lbMNV.Size = new System.Drawing.Size(122, 22);
            this.lbMNV.TabIndex = 0;
            this.lbMNV.Text = "Mã nhân viên:";
            // 
            // gbDSNV
            // 
            this.gbDSNV.Controls.Add(this.dgvNhanVien);
            this.gbDSNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDSNV.Location = new System.Drawing.Point(40, 201);
            this.gbDSNV.Name = "gbDSNV";
            this.gbDSNV.Size = new System.Drawing.Size(831, 294);
            this.gbDSNV.TabIndex = 1;
            this.gbDSNV.TabStop = false;
            this.gbDSNV.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(38, 30);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(752, 250);
            this.dgvNhanVien.TabIndex = 0;
            // 
            // frmqlNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 535);
            this.Controls.Add(this.gbDSNV);
            this.Controls.Add(this.gbTTNV);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "frmqlNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.frmqlNhanVien_Load);
            this.gbTTNV.ResumeLayout(false);
            this.gbTTNV.PerformLayout();
            this.gbDSNV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTTNV;
        private System.Windows.Forms.GroupBox gbDSNV;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Label lbL;
        private System.Windows.Forms.Label lbCV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMNV;
        private System.Windows.Forms.TextBox txtLuongNhanVien;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThemNV;
    }
}