using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM.DAL
{
    public class CustomerDAL
    {
        private string connectionString;

        public CustomerDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public CustomerDAL() { }
        public bool SaveCus(string sdt, string name, string address, string sex)
        {
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("UpsertKH", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@SDT", sdt);
                        cmd.Parameters.AddWithValue("@TenKH", name);
                        cmd.Parameters.AddWithValue("@Diachi", address);
                        cmd.Parameters.AddWithValue("@GioiTinh", sex);

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
        public bool DelCus(string sdt)
        {
            using (SqlConnection conn = Connect.getConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("DeleteKH", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@SDT", sdt);
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
                    using (SqlCommand cmd = new SqlCommand("SearchCustomerByName", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CustomerName", name);

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

    }
}
