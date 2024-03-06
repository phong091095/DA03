using DAM.BLL;
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
    public partial class Nhanvien : Form
    {
        public Nhanvien()
        {
            InitializeComponent();

        }
        Modify mod = new Modify();
        StaffDAL staffDAL = new StaffDAL();
        StaffBLL staffBLL = new StaffBLL();
        private void Close_Bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lock_bt()
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            Del_Bt.Enabled = false;
            Update_Bt.Enabled = false;
            Save_Bt.Enabled = false;
        }

        private void clean_form()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
        }
        private void Nhanvien_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = mod.GetDSNV();
                dataGridView1.DataSource = dataTable;

                lock_bt();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu từ cơ sở dữ liệu: " + ex.Message);
            }
        }

        private void Reset_Bt_Click(object sender, EventArgs e)
        {
            lock_bt();
            clean_form();
            Add_Bt.Enabled = true;
            try
            {
                DataTable dataTable = mod.GetDSNV();
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
                DataTable dataTable = mod.GetDSNV();
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
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            Save_Bt.Enabled = true;
        }

        private void Save_Bt_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string name = textBox2.Text;
            string address = textBox3.Text;
            string status = radioButton1.Checked ? "0" : (radioButton2.Checked ? "1" : "");
            string role = radioButton3.Checked ? "0" : (radioButton4.Checked ? "1" : "");

            if (!staffBLL.ValidateStaffInfo(email, name, address))
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin.");
                return;
            }
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn chức vụ");
                return;
            }
            if (radioButton3.Checked == false && radioButton4.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn tình trạng");
                return;
            }
            try
            {
                bool isSuccess = staffDAL.InsertStaff(email, name, address, status, role);
                if (isSuccess)
                {
                    MessageBox.Show("Lưu thành công.");
                    DataTable dataTable = mod.GetDSNV();
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
                textBox1.Text = selectedRow.Cells["Email"].Value.ToString();
                textBox2.Text = selectedRow.Cells["TenNV"].Value.ToString();
                textBox3.Text = selectedRow.Cells["DiaChi"].Value.ToString();
                textBox5.Text = selectedRow.Cells["MaNV"].Value.ToString();
                Add_Bt.Enabled = false;
                Del_Bt.Enabled = true;
                Update_Bt.Enabled = true;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                radioButton4.Enabled = true;
                Save_Bt.Enabled = true;
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
                    string manv = textBox5.Text.ToString();
                    try
                    {
                        bool isSuccess = staffDAL.DelStaff(manv);
                        if (isSuccess)
                        {
                            MessageBox.Show("Xóa thành công");
                            DataTable dataTable = mod.GetDSNV();
                            dataGridView1.DataSource = dataTable;
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
            string manv = textBox5.Text;
            string email = textBox1.Text;
            string name = textBox2.Text;
            string address = textBox3.Text;
            string status = radioButton1.Checked ? "0" : (radioButton2.Checked ? "1" : "");
            string role = radioButton3.Checked ? "0" : (radioButton4.Checked ? "1" : "");
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Hiển thị hộp thoại hỏi người dùng
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Nếu người dùng chọn "Yes"
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        bool issuc = staffDAL.UpdateStaff(manv, email, name, address, status, role);
                        if (issuc)
                        {
                            MessageBox.Show("Sửa thành công");
                            DataTable dataTable = mod.GetDSNV();
                            dataGridView1.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("Sửa không thành công.");
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

        private void TK_Bt_Click(object sender, EventArgs e)
        {
            string name = textBox4.Text.Trim();
            DataTable result = staffDAL.SearchCus(name);

            if (result.Rows.Count > 0)
            {
                dataGridView1.DataSource = result;
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên với tên đã nhập.");
            }
        }
    }
}
