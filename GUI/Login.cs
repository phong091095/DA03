using DAM.DAL;
using DAM.GUI;
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
    public partial class Login : Form
    {
        Modify mod = new Modify();
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBt_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string pw = txtPw.Text;
            (int role, int requirePasswordChange, int logincheck) = mod.CheckLogin(email, pw);

            if (logincheck == 1)
            {
                if (requirePasswordChange == 0)
                {
                    MessageBox.Show("Vui lòng đổi mật khẩu mới cho lần đăng nhập đầu tiên");
                    ChangePassword changepw = new ChangePassword(email, pw);
                    changepw.Show();
                    this.Close();
                }
                else
                {
                    Mainform mainform = new Mainform(email, role);
                    mainform.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin đăng nhập.");
            }
        }


        private void CloseBt_Click(object sender, EventArgs e)
        {
            Welcome.Instance.Show();
            this.Close();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword fp = new ForgetPassword();
            fp.Show();
        }
    }
}
