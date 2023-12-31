﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace QuanLiNhaHang
{
    public partial class frmqlNhanVien : Form
    {
        KetNoi kn = new KetNoi();
        SqlDataAdapter da_nhanvien;
        DataSet ds_nhanvien;
        DataColumn[] key = new DataColumn[1];
        SqlConnection sqlconn;
        SqlCommand cmd;
        public frmqlNhanVien()
        {
            InitializeComponent();
            sqlconn = kn.conn;
            string strSelect = "select * from NhanVien";
            da_nhanvien = new SqlDataAdapter(strSelect, sqlconn);
            ds_nhanvien = new DataSet();
            da_nhanvien.Fill(ds_nhanvien, "NhanVien");
            key[0] = ds_nhanvien.Tables["NhanVien"].Columns[0];
            ds_nhanvien.Tables["NhanVien"].PrimaryKey = key;
        }
        void Databingding(DataTable pDT)
        {
            txtMaNhanVien.DataBindings.Clear();
            txtTenNhanVien.DataBindings.Clear();
            txtChucVu.DataBindings.Clear();
            txtLuongNhanVien.DataBindings.Clear();
            //lien ket du lieu trong text box voi truong du lieu trong database
            txtMaNhanVien.DataBindings.Add("Text", pDT, "MaNhanVien");
            txtTenNhanVien.DataBindings.Add("Text", pDT, "Ten");
            txtChucVu.DataBindings.Add("Text", pDT, "ChucVu");
            txtLuongNhanVien.DataBindings.Add("Text", pDT, "Luong");
        }
        void loadGrid()
        {
            dgvNhanVien.DataSource = ds_nhanvien.Tables[0];
            Databingding(ds_nhanvien.Tables[0]);
        }
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            DataRow newrow = ds_nhanvien.Tables[0].NewRow();
            newrow["MaNhanVien"] = txtMaNhanVien.Text;
            newrow["Ten"] = txtTenNhanVien.Text;
            newrow["ChucVu"] = txtChucVu.Text;
            newrow["Luong"] = txtLuongNhanVien.Text;
            ds_nhanvien.Tables[0].Rows.Add(newrow);
            SqlCommandBuilder cB = new SqlCommandBuilder(da_nhanvien);
            da_nhanvien.Update(ds_nhanvien, "NhanVien");
            txtMaNhanVien.Clear();
            txtTenNhanVien.Clear();
            txtChucVu.Clear();
            txtLuongNhanVien.Clear();
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            DataRow dr = ds_nhanvien.Tables[0].Rows.Find(txtMaNhanVien.Text);
            if (dr != null)
            {
                dr.Delete();
            }
            //cap nhap trong database
            SqlCommandBuilder cB = new SqlCommandBuilder(da_nhanvien);
            //cap nhat dataset
            da_nhanvien.Update(ds_nhanvien, "NhanVien");
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            DataRow dr = ds_nhanvien.Tables[0].Rows.Find(txtMaNhanVien.Text);
            if (dr != null)
            {
                dr["Ten"] = txtTenNhanVien.Text;
                dr["ChucVu"] = txtChucVu.Text;
                dr["Luong"] = txtLuongNhanVien.Text;

            }
            SqlCommandBuilder cB = new SqlCommandBuilder(da_nhanvien);
            da_nhanvien.Update(ds_nhanvien, "NhanVien");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Ban co muon thoat?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

        private void frmqlNhanVien_Load(object sender, EventArgs e)
        {
            loadGrid();
        }
    }
}
