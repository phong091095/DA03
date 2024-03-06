using DAM.BLL;
using DAM.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DAM
{
    public partial class KhachHang : Form
    {
        Modify mod = new Modify();

        public KhachHang()
        {
            InitializeComponent();
        }

        private void lock_bt()
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            Del_Bt.Enabled = false;
            Update_Bt.Enabled = false;
            Save_Bt.Enabled = false;
        }

        private void clean_form()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void Close_Bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Reset_Bt_Click(object sender, EventArgs e)
        {
            lock_bt();
            clean_form();
            Add_Bt.Enabled = true;
            try
            {
                DataTable dataTable = mod.GetDSKH();
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu từ cơ sở dữ liệu: " + ex.Message);
            }
        }

        private void DS_Bt_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = mod.GetDSKH();
                dataGridView1.DataSource = dataTable;
                lock_bt();
                clean_form();
                Add_Bt.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu từ cơ sở dữ liệu: " + ex.Message);
            }
        }

        private void Add_Bt_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            Save_Bt.Enabled = true;
        }
        CustomerDAL customerDAL = new CustomerDAL();
        CustomerBLL customerBLL = new CustomerBLL();
        private void Save_Bt_Click(object sender, EventArgs e)
        {
            string sdt = textBox1.Text;
            string name = textBox2.Text;
            string address = textBox3.Text;
            string sex = radioButton1.Checked ? "1" : "0";

            if (!customerBLL.ValidateCustomerInfo(sdt, name, address))
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin.");
                return;
            }
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn giới tính");
                return;
            }
            try
            {
                bool isSuccess = customerDAL.SaveCus(sdt, name, address, sex);
                if (isSuccess)
                {
                    MessageBox.Show("Lưu thành công.");
                    DataTable dataTable = mod.GetDSKH();
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Lưu không thành công.");
                }
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi khác nếu cần
                MessageBox.Show("Lỗi không xác định: " + ex.Message);
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Lấy giá trị từ các ô trong dòng được chọn và gán vào các TextBox
                textBox2.Text = selectedRow.Cells["TenKH"].Value.ToString();
                textBox1.Text = selectedRow.Cells["SDT"].Value.ToString();
                textBox3.Text = selectedRow.Cells["DiaChi"].Value.ToString();
                Add_Bt.Enabled = false;
                Del_Bt.Enabled = true;
                Update_Bt.Enabled = true;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                Save_Bt.Enabled = true;
            }
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = mod.GetDSKH();
                dataGridView1.DataSource = dataTable;

                lock_bt();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu từ cơ sở dữ liệu: " + ex.Message);
            }
        }

        private void Del_Bt_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Hiển thị hộp thoại hỏi người dùng
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Nếu người dùng chọn "Yes"
                if (result == DialogResult.Yes)
                {
                    string sdt = textBox2.Text.ToString();
                    try
                    {
                        bool isSuccess = customerDAL.DelCus(sdt);
                        if (isSuccess)
                        {
                            MessageBox.Show("Xóa thành công");
                        }
                        else
                        {
                            MessageBox.Show("Xóa không thành công.");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Xử lý các lỗi khác nếu cần
                        MessageBox.Show("Lỗi không xác định: " + ex.Message);
                    }
                }
                // Nếu người dùng chọn "No", không thực hiện xóa
                else if (result == DialogResult.No)
                {

                }
            }
        }


                    private void Update_Bt_Click(object sender, EventArgs e)
        {
            string sdt = textBox1.Text;
            string name = textBox2.Text;
            string address = textBox3.Text;
            string sex = radioButton1.Checked ? "1" : "0";

            if (!customerBLL.ValidateCustomerInfo(sdt, name, address))
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin.");
                return;
            }
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn giới tính");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin khách hàng không?", "Xác nhận cập nhật", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    bool isSuccess = customerDAL.SaveCus(sdt, name, address, sex);
                    if (isSuccess)
                    {
                        MessageBox.Show("Lưu thành công.");
                        DataTable dataTable = mod.GetDSKH();
                        dataGridView1.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("Lưu không thành công.");
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý các lỗi khác nếu cần
                    MessageBox.Show("Lỗi không xác định: " + ex.Message);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
               
            }
        }

        private void TK_Button_Click(object sender, EventArgs e)
        {
            string name = textBox4.Text.Trim();
            DataTable result = customerDAL.SearchCus(name);

            if (result.Rows.Count > 0)
            {
                dataGridView1.DataSource = result;
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng với tên đã nhập.");
            }
        }

    }
}
