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
    public partial class ForgetPassword : Form
    {
        StaffDAL staffDAL = new StaffDAL();
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ForgetPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.X)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string pw = staffDAL.RandomPassword();
            staffDAL.SendPasswordEmail(email, pw);
            bool issuc = staffDAL.UpdatePW(email, pw);
            if(issuc)
            {
                MessageBox.Show("Mật khẩu mới đã được gửi về email, vui lòng kiểm tra");
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra thông tin đã nhập");
            }
        }
    }
}
