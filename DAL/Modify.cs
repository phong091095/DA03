
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;
using Microsoft.VisualBasic.ApplicationServices;

namespace DAM.DAL
{
    class Modify
    {
        SqlDataAdapter dataAdapter;
        SqlCommand cmd;
        public Modify()
        {

        }
        public DataTable GetDSKH()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = Connect.getConnection())
            {
                conn.Open();
                string query = "select TenKH,SDT,Diachi,  CASE WHEN Gioitinh = 1 THEN 'Nam' ELSE N'Nữ' END AS GioiTinh from KhachHang";
                using (cmd = new SqlCommand(query, conn))
                using (dataAdapter = new SqlDataAdapter(cmd))
                {
                    dataAdapter.Fill(dataTable);
                }
            }
            return dataTable;
        }
        public DataTable GetDSNV()
        {
            DataTable dataTable = new DataTable();
            using(SqlConnection conn = Connect.getConnection())
            {
                conn.Open();
                string query = "select ID ,MaNV ,Email ,TenNV ,Diachi ,Case When ChucVu = 0 then N'Nhân viên' else N'Quản Lý' end as ChucVu,Case when TinhTrang= 0 then N'Đang hợp tác' else N'Ngưng hợp tác' end as TinhTrang from NhanVien";
                using (cmd=new SqlCommand(query, conn))
                using (dataAdapter = new SqlDataAdapter(cmd))
                {
                    dataAdapter.Fill(dataTable);
                }
            }
            return dataTable;
        }
        public DataTable GetDSSP()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = Connect.getConnection())
            {
                conn.Open();
                string query = "select * from SanPham";
                using(cmd=new SqlCommand(query, conn))
                {
                    using (dataAdapter = new SqlDataAdapter(cmd))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }
        public (int Role, int RequirePasswordChange, int LoginCheck) CheckLogin(string email, string pw)
        {
            using (SqlConnection conn = Connect.getConnection())
            {
                conn.Open();
                int rpc = -1; // Mặc định giá trị RequirePasswordChange
                int role = -1; // Mặc định giá trị UserRole
                int loginCheck = 0; // Mặc định giá trị LoginCheck (0: Không hợp lệ, 1: Hợp lệ)

                using (SqlCommand cmd = new SqlCommand("CheckRPC", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", email);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        rpc = Convert.ToInt32(reader["RequirePasswordChange"]);
                        role = Convert.ToInt32(reader["UserRole"]);
                    }
                    reader.Close();
                }
                if(rpc == 0)
                {
                    using (SqlCommand cmd1 = new SqlCommand("CheckEmailAndPassword", conn))
                    {
                        cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.Parameters.AddWithValue("@Email", email);
                        cmd1.Parameters.AddWithValue("@Password", pw);
                        SqlDataReader reader1 = cmd1.ExecuteReader();
                        if (reader1.Read())
                        {
                            loginCheck = Convert.ToInt32(reader1["IsValid"]);
                        }
                        reader1.Close();
                    }
                }
                else if(rpc == 1)
                {
                    using (SqlCommand cmd2 = new SqlCommand("CheckEmailAndPassword", conn))
                    {
                        string haspw = HashPassword(pw);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@Email", email);
                        cmd2.Parameters.AddWithValue("@Password", haspw);
                        SqlDataReader reader2 = cmd2.ExecuteReader();
                        if (reader2.Read())
                        {
                            loginCheck = Convert.ToInt32(reader2["IsValid"]);
                        }
                        reader2.Close();
                    }
                }
                if (loginCheck == 1) // Nếu thông tin đăng nhập hợp lệ
                {
                   
                    return (role, rpc, loginCheck);
                }
            }
            // Trả về giá trị mặc định nếu không tìm thấy thông tin tài khoản
            return (-1, -1, 0);
        }

        public bool SavePw(string UserID, string npw)
        {
            int rowsAffected = 0;
            string hashedPw = HashPassword(npw);

            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("ChangePassword", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserID", UserID);
                        cmd.Parameters.AddWithValue("@NewPassword", hashedPw);

                        rowsAffected = cmd.ExecuteNonQuery();
                    }

                    return rowsAffected > 0; // Trả về true nếu có dòng dữ liệu bị thay đổi
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi SQL: " + ex.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                    return false;
                }
            }
        }


        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Mã hóa mật khẩu thành mảng byte
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Chuyển mảng byte thành chuỗi hexa
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
        public DataTable GetNK()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = Connect.getConnection())
            {
                conn.Open();
                string query = "select * from NhapKho";
                using (cmd = new SqlCommand(query, conn))
                {
                    using (dataAdapter = new SqlDataAdapter(cmd))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }
        public DataTable GetTK()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = Connect.getConnection())
            {
                conn.Open();
                string query = "select TenSP, SoLuong from SanPham";
                using (cmd = new SqlCommand(query, conn))
                {
                    using (dataAdapter = new SqlDataAdapter(cmd))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }
    }
}
