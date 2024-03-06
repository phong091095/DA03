using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DAM.DAL
{
    public class ProductDAL
    {
        private string connectionString;

        public ProductDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public ProductDAL() { }

        public DataTable SearchPro(string name)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SearchProByName", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ProName", name);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi kết nối hoặc lỗi thực thi câu lệnh SQL: " + ex.Message);
                }
            }
            return dt;
        }
        public bool InsertSP(string name, int sl, int gianhap, int giaban, byte[] hinhanh, string ghichu, string email)
        {
            try
            {
                using (SqlConnection conn = Connect.getConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("InsertOrUpdateSanPham", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@tensp", name);
                        cmd.Parameters.AddWithValue("@soluong", sl);
                        cmd.Parameters.AddWithValue("@gianhap", gianhap);
                        cmd.Parameters.AddWithValue("@giaban", giaban);
                        cmd.Parameters.AddWithValue("@hinhanh", hinhanh);
                        cmd.Parameters.AddWithValue("@ghichu", ghichu);
                        cmd.Parameters.AddWithValue("@email", email);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {

                            using (SqlCommand cmd2 = new SqlCommand("InsertKho", conn))
                            {
                                cmd2.CommandType = CommandType.StoredProcedure;
                                cmd2.Parameters.AddWithValue("@TenSP", name);
                                cmd2.Parameters.AddWithValue("@Soluong", sl);
                                cmd2.Parameters.AddWithValue("@email", email);
                                int rowsInserted = cmd2.ExecuteNonQuery();
                                return rowsInserted > 0;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
            }
            return false;
        }


        public Image GetImg()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.ico|All Files|*.*";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = openFileDialog.FileName;

                    try
                    {
                        Image selectedImage = Image.FromFile(selectedImagePath);
                        return selectedImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                }
                else
                {
                    return null; // Trả về null nếu người dùng không chọn hình ảnh
                }
            }
        }
        public byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
        public bool DelPro(string MaSP)
        {
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("DeleteSP", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaSP", MaSP);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi kết nối hoặc lỗi thực thi câu lệnh SQL: " + ex.Message);
                    return false;
                }
            }
        }
        public bool UpdateSP(int masp, string name, int sl, int gianhap, int giaban, byte[] hinhanh, string ghichu, string email)
        {
            try
            {
                using (SqlConnection conn = Connect.getConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("UpdateSP", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@masp", masp);
                        cmd.Parameters.AddWithValue("@tensp", name);
                        cmd.Parameters.AddWithValue("@soluong", sl);
                        cmd.Parameters.AddWithValue("@gianhap", gianhap);
                        cmd.Parameters.AddWithValue("@giaban", giaban);
                        cmd.Parameters.AddWithValue("@hinhanh", hinhanh);
                        cmd.Parameters.AddWithValue("@ghichu", ghichu);
                        cmd.Parameters.AddWithValue("@email", email);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa dữ liệu: " + ex.Message);
                return false;
            }
        }

    }
}

