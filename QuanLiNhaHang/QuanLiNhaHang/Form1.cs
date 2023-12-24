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
    public partial class frmDangNhap : Form
    {
        KetNoi kn = new KetNoi();
        SqlConnection sqlconn;
        SqlCommand cmd;
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtUsername.Text;
            string matKhau = txtPassword.Text;
            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập.");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
                return; // Nếu có ít nhất một trường rỗng, thoát khỏi phương thức
            }
            if (KiemTraDangNhap(tenDangNhap, matKhau))
            {
                MessageBox.Show("Đăng nhập thành công!");
                frmQuanLi frmquanli = new frmQuanLi();
                frmquanli.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng thử lại!");
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Ban co muon thoat?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private bool KiemTraDangNhap(string tenDangNhap,string matKhau)
        {
            using (SqlConnection sqlconn = kn.conn)
            {
                sqlconn.Open();
                using (SqlCommand command = new SqlCommand("SELECT 1 FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau", sqlconn))
                {
                    command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    command.Parameters.AddWithValue("@MatKhau", matKhau);

                    return command.ExecuteScalar() != null;
                }
            }
        }
    }
}
