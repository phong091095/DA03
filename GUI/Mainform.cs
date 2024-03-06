using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAM.GUI
{
    public partial class Mainform : Form
    {
        private string email;
        private int role;

        public Mainform(string email, int role)
        {
            this.email = email;
            this.role = role;
            InitializeComponent();
            if (role == 0)
            {
                nhânViênALTNToolStripMenuItem.Enabled = false;
                kháchHàngALTKToolStripMenuItem.Enabled = false;
            }
            LoginLB.Text = "Xin chào " + email;

        }

        private void Mainform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.X)
            {
                Welcome welcome = new Welcome();
                welcome.Show();
                this.Close();
            }
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                this.Close();
                e.Handled = true;
            }
            if (e.Alt && e.KeyCode == Keys.S)
            {
                SanPham sanPham = new SanPham(email);
                sanPham.Show();
            }
            if (e.Alt && e.KeyCode == Keys.N)
            {
                if (role == 0)
                {
                    e.Handled = true;
                }
                else
                {
                    Nhanvien nhanvien = new Nhanvien();
                    nhanvien.Show();
                }
            }
            if (e.Alt && e.KeyCode == Keys.K)
            {
                if (role == 0)
                {
                    e.Handled = true;
                }
                else
                {
                    KhachHang khachHang = new KhachHang();
                    khachHang.Show();
                }
            }
            if (e.Alt && e.KeyCode == Keys.P)
            {
                ThongKe thongKe = new ThongKe();
                thongKe.Show();
            }
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thốngKêSảnPhẩmALTPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKe thongKe = new ThongKe();
            thongKe.Show();
        }

        private void đăngXuấtCTRLXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void thoátALTF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Welcome.Instance.Show();
            this.Close();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SanPham sanpham = new SanPham(email);
            sanpham.Show();
        }

        private void nhânViênALTNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhanvien nhanvien = new Nhanvien();
            nhanvien.Show();
        }

        private void kháchHàngALTKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang khachhang = new KhachHang();
            khachhang.Show();
        }
    }
}
