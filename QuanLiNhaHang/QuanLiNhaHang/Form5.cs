using System;
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
    public partial class frmqlKhachHang : Form
    {
        KetNoi kn = new KetNoi();
        SqlDataAdapter da_khachhang;
        DataSet ds_khachhang;
        DataColumn[] key = new DataColumn[1];
        SqlConnection sqlconn;
        SqlCommand cmd;
        public frmqlKhachHang()
        {
            InitializeComponent();
            sqlconn = kn.conn;
            string strSelect = "select * from KhachHang";
            da_khachhang = new SqlDataAdapter(strSelect, sqlconn);
            ds_khachhang = new DataSet();
            da_khachhang.Fill(ds_khachhang, "KhachHang");
            key[0] = ds_khachhang.Tables["KhachHang"].Columns[0];
            ds_khachhang.Tables["KhachHang"].PrimaryKey = key;
        }
        void Databingding(DataTable pDT)
        {
            txtMaKH.DataBindings.Clear();
            txtTenKH.DataBindings.Clear();
            txtDienThoai.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            //lien ket du lieu trong text box voi truong du lieu trong database
            txtMaKH.DataBindings.Add("Text", pDT, "MaKhachHang");
            txtTenKH.DataBindings.Add("Text", pDT, "Ten");
            txtDienThoai.DataBindings.Add("Text", pDT, "DienThoai");
            txtEmail.DataBindings.Add("Text", pDT, "Email");
            txtDiaChi.DataBindings.Add("Text", pDT, "DiaChi");
        }
        void loadGrid()
        {
            dgvKhachHang.DataSource = ds_khachhang.Tables[0];
            Databingding(ds_khachhang.Tables[0]);
        }
        private void btnThemKH_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Ban co muon thoat?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

        private void frmqlKhachHang_Load(object sender, EventArgs e)
        {
            loadGrid();
        }
    }
}
