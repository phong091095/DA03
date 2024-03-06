using DAM.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAM
{
    public partial class ChangePassword : Form
    {
        string loginemail;
        string loginpw;
        public ChangePassword(string email, string pw)
        {
            InitializeComponent();
            this.loginemail = email;
            this.loginpw = pw;
        }
        Modify mod = new Modify();
        private void button2_Click(object sender, EventArgs e)
        {
            Welcome.Instance.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string opw = textBox1.Text;
            string npw = textBox2.Text;
            string rnpw = textBox3.Text;
            string cemail = textBox4.Text;

            if (opw == loginpw && cemail == loginemail)
            {
                if (npw == rnpw && npw.Trim().Length > 8)
                {
                    bool isSuccess = mod.SavePw(cemail, npw);
                    if (isSuccess)
                    {
                        MessageBox.Show("Đổi mật khẩu không thành công, vui lòng kiểm tra lại");
                       
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thành công. Vui lòng đăng nhập lại");
                        Welcome.Instance.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu không thành công. Mật khẩu mới phải có ít nhất 9 ký tự và nhập lại mật khẩu phải khớp.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại Email hoặc mật khẩu.");
            }
        }

    }
}
