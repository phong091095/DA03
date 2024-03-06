using DAM.BLL;
using DAM.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DAM
{
    public partial class SanPham : Form
    {
        string email;
        Modify mod = new Modify();
        ProductDAL product = new ProductDAL();
        ProductBLL productBLL = new ProductBLL();
        public SanPham(string email)
        {
            this.email = email;
            InitializeComponent();
        }
        private void lock_bt()
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            Del_Bt.Enabled = false;
            Update_Bt.Enabled = false;
            Save_Bt.Enabled = false;
            Pic_Bt.Enabled = false;
        }

        private void clean_form()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
        }
        private void SanPham_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = mod.GetDSSP();
                dataGridView1.DataSource = dataTable;

                lock_bt();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu từ cơ sở dữ liệu: " + ex.Message);
            }
        }

        private void Close_Bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reset_Bt_Click(object sender, EventArgs e)
        {
            lock_bt();
            clean_form();
            try
            {
                DataTable dataTable = mod.GetDSSP();
                dataGridView1.DataSource = dataTable;
                Add_Bt.Enabled = true;
                lock_bt();
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
                DataTable dataTable = mod.GetDSSP();
                dataGridView1.DataSource = dataTable;
                Add_Bt.Enabled= true;
                lock_bt();
                clean_form();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu từ cơ sở dữ liệu: " + ex.Message);
            }
        }

        private void TK_Bt_Click(object sender, EventArgs e)
        {
            string proname = textBox7.Text.Trim();
            DataTable result = product.SearchPro(proname);

            if (result.Rows.Count > 0)
            {
                dataGridView1.DataSource = result;
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên với tên đã nhập.");
            }
        }

        private void Add_Bt_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            Save_Bt.Enabled = true;
            Pic_Bt.Enabled = true;
        }

        private void Save_Bt_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text.Trim();
            int soluong = Convert.ToInt32(textBox3.Text.Trim());
            int gianhap = Convert.ToInt32(textBox4.Text.Trim());
            int giaban = Convert.ToInt32(textBox5.Text.Trim());
            byte[] imgData = null;
            if (pictureBox1.Image != null)
            {
                imgData = product.ImageToByteArray(pictureBox1.Image);
            }
            string ghichu = textBox6.Text;
            bool checkprice = productBLL.ValidInfo(name,soluong,gianhap, giaban,ghichu);
            if(checkprice)
            {
                bool succeed = product.InsertSP(name, soluong, gianhap, giaban, imgData, ghichu, email);
                if (succeed)
                {
                    MessageBox.Show("Sản phẩm đã được thêm");
                    DataTable dataTable = mod.GetDSSP();
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm thất bại, vui lòng kiểm tra lại");
                }
            }
            else
            {
                MessageBox.Show("Giá sản phẩm nhập vào phải là số dương");
            }
        }
        private void Pic_Bt_Click(object sender, EventArgs e)
        {
            Image selectedImage = product.GetImg();

            if (selectedImage != null)
            {
                // Hiển thị hình ảnh trong PictureBox
                pictureBox1.Image = selectedImage;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Add_Bt.Enabled = false;
            Del_Bt.Enabled = true;
            Update_Bt.Enabled = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Lấy thông tin từ các ô trong dòng được nhấp
                textBox1.Text = selectedRow.Cells["MaSP"].Value.ToString();
                textBox2.Text = selectedRow.Cells["TenSP"].Value.ToString();
                textBox3.Text = selectedRow.Cells["SoLuong"].Value.ToString();
                textBox4.Text = selectedRow.Cells["GiaNhap"].Value.ToString();
                textBox5.Text = selectedRow.Cells["GiaBan"].Value.ToString();
                if (selectedRow.Cells["HinhAnh"].Value != DBNull.Value)
                {
                    byte[] imageData = (byte[])selectedRow.Cells["HinhAnh"].Value;
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBox1.Image = null; // Nếu không có hình ảnh, hiển thị PictureBox trống
                }
                textBox6.Text = selectedRow.Cells["GhiChu"].Value.ToString();
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
                    string masp = textBox1.Text.ToString();
                    try
                    {
                        bool isSuccess = product.DelPro(masp);
                        if (isSuccess)
                        {
                            MessageBox.Show("Xóa thành công");
                            DataTable dataTable = mod.GetDSSP();
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
            int masp = Convert.ToInt32(textBox1.Text.Trim());
            string name = textBox2.Text.Trim();
            int soluong = Convert.ToInt32(textBox3.Text.Trim());
            int gianhap = Convert.ToInt32(textBox4.Text.Trim());
            int giaban = Convert.ToInt32(textBox5.Text.Trim());
            byte[] imgData = null;
            if (pictureBox1.Image != null)
            {
                imgData = product.ImageToByteArray(pictureBox1.Image);
            }
            string ghichu = textBox6.Text;
            bool succeed = product.UpdateSP(masp,name, soluong, gianhap, giaban, imgData, ghichu, email);
            if (succeed)
            {
                MessageBox.Show("Sản phẩm đã được sửa");
                DataTable dataTable = mod.GetDSSP();
                dataGridView1.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Sửa thông tin thất bại, vui lòng kiểm tra lại");
            }
        }
    }
}
