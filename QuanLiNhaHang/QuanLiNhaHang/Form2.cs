using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaHang
{
    public partial class frmQuanLi : Form
    {
        public frmQuanLi()
        {
            InitializeComponent();
        }

        private void trangChủToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTrangChu frmtrangchu = new frmTrangChu();
            frmtrangchu.MdiParent = this;
            frmtrangchu.Show();
        }

        private void quảnLíToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmqlNhanVien frmqlnhanvien = new frmqlNhanVien();
            frmqlnhanvien.MdiParent = this;
            frmqlnhanvien.Show();
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmqlKhachHang frmqlkhachhang = new frmqlKhachHang();
            frmqlkhachhang.MdiParent = this;
            frmqlkhachhang.Show();
        }

        private void bànĂnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQuanLiBanAn frmqlbanan= new frmQuanLiBanAn();
            frmqlbanan.MdiParent = this;
            frmqlbanan.Show();
            
        }

        private void thựcĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void danhMụcMónĂnToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void mónĂnToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void hóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void thốngKêToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void frmQuanLi_Load(object sender, EventArgs e)
        {
        }
    }
}
