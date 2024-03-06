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

namespace DAM.GUI
{
    public partial class ThongKe : Form
    {
        Modify mod = new Modify();
        public ThongKe()
        {
            InitializeComponent();
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                DataTable dataTable = mod.GetNK();
                dataGridView1.DataSource = dataTable;
            }
            if (tabControl1.SelectedTab == tabPage2)
            {
                DataTable dataTable = mod.GetTK();
                dataGridView2.DataSource = dataTable;
            }
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            DataTable dataTable = mod.GetNK();
            dataGridView1.DataSource = dataTable;
        }
    }
}
