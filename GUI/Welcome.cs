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
    public partial class Welcome : Form
    {
        public static Welcome Instance;
        public Welcome()
        {
            InitializeComponent();
            Instance = this;
        }


        private void Welcome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.D)
            {
                Login loginform = new Login();
                loginform.Show();
            }
            if (e.Control && e.KeyCode == Keys.X)
            {
                this.Close();
            }
        }

        private void đăngNhậpCTRDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void thoátALTF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
