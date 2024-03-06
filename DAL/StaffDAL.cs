using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Net.Http;
using System.Xml.Linq;

namespace DAM.DAL
{
    public class StaffDAL
    {
        private string connectionString;

        public StaffDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public StaffDAL() { }

       

        public string GetID(SqlConnection connection)
        {
            string sqlQuery = "select Max(ID) + 1 from NhanVien";

            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            {
                object result = command.ExecuteScalar();
                return result.ToString();
            }
        }
        
        public string RandomPassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            var password = new char[8];
            for (int i = 0; i < password.Length; i++)
            {
                password[i] = chars[random.Next(chars.Length)];
            }
            return new string(password);
        }
        public bool InsertStaff(string Email, string name, string address, string status, string role)
        {
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();

                    string pw = RandomPassword();

                    // Thực hiện truy vấn chèn thông tin nhân viên vào bảng NhanVien
                    string query1 = "insert into NhanVien (MaNV,Email,TenNV,Diachi,ChucVu,TinhTrang) values (@MaNV,@Email,@TenNV,@Diachi,@ChucVu,@TinhTrang)";
                    using (SqlCommand cmd = new SqlCommand(query1, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNV", "NV" + GetID(conn));
                        cmd.Parameters.AddWithValue("@Email", Email);
                        cmd.Parameters.AddWithValue("@TenNV", name);
                        cmd.Parameters.AddWithValue("@Diachi", address);
                        cmd.Parameters.AddWithValue("@TinhTrang", status);
                        cmd.Parameters.AddWithValue("@ChucVu", role);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Thực hiện truy vấn chèn thông tin đăng nhập vào bảng Login
                            string query2 = "insert into Login(UserID,UserPW,UserRole,RequirePasswordChange) values (@UserID,@Pw,@ChucVu,@RPC)";
                            using (SqlCommand cmd2 = new SqlCommand(query2, conn))
                            {
                                cmd2.Parameters.AddWithValue("@UserID", Email);
                                cmd2.Parameters.AddWithValue("@Pw", pw);
                                cmd2.Parameters.AddWithValue("@ChucVu", role);
                                cmd2.Parameters.AddWithValue("@RPC", 0);
                                rowsAffected = cmd2.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    // Gửi email với mật khẩu ngẫu nhiên đến địa chỉ email
                                    SendPasswordEmail(Email, pw);
                                    return true;
                                }
                            }
                        }
                        return false;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi kết nối hoặc lỗi thực thi câu lệnh SQL: " + ex.Message);
                    return false;
                }
            }
        }
        public void SendPasswordEmail(string Email, string password)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("Ttphong0910@gmail.com");
                mail.To.Add(Email);
                mail.Subject = "Mật khẩu mới của bạn";
                mail.Body = $"Mật khẩu mới của bạn là: {password}";

                smtpServer.Port = 587;
                smtpServer.Credentials = new NetworkCredential("kddk0910.kt@gmail.com", "oymzlksnqujeruxv");
                smtpServer.EnableSsl = true;
                smtpServer.UseDefaultCredentials = false;
                smtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpServer.Send(mail);

                MessageBox.Show("Email sent successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public bool DelStaff(string Manv)
        {
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("DeleteNV", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaNV", Manv);
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
        public bool UpdateStaff(string  Manv,string Email,string Name,string Address,string Status,string Role) {
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("UpdateNV", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaNV", Manv);
                        cmd.Parameters.AddWithValue("@Email", Email);
                        cmd.Parameters.AddWithValue("TenNV", Name);
                        cmd.Parameters.AddWithValue("@Diachi", Address);
                        cmd.Parameters.AddWithValue("@TinhTrang", Status);
                        cmd.Parameters.AddWithValue("@ChucVu", Role);
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
        public DataTable SearchCus(string name)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SearchStaffByName", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@StaffName", name);

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
        public bool UpdatePW(string email,string pw)
        {
            try
            {
                using (SqlConnection con = Connect.getConnection())
                {
                    string query = "update Login set UserPW = @pw , RequirePasswordChange = 0 where UserID = @email";
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@pw", pw);
                        cmd.Parameters.AddWithValue("@email", email);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            
            catch (SqlException ex)
                {
                MessageBox.Show("Lỗi kết nối hoặc lỗi thực thi câu lệnh SQL: " + ex.Message);
                return false;
            }
        }
    }
}
