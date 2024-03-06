using DAM.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAM.BLL
{
    public class StaffBLL
    {
        private StaffDAL staffDAL;

        public StaffBLL(string connectionString)
        {
            staffDAL = new StaffDAL(connectionString);
        }
        public StaffBLL() { }
        public bool ValidName(string name)
        {
            string pattern = @"^[a-zA-Zàáãạảăắằẵặấầẫẩâấầẫẩéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵ\s]+$";

            if (Regex.IsMatch(name, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
        public bool ValidateStaffInfo(string email, string name, string address)
        {
            // Kiểm tra nghiệp vụ

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(address))
            {
                return false;
            }

            if (!ValidEmail(email))
            {
                return false;
            }

            if (!ValidName(name))
            {
                return false;
            }

            return true;
        }
    }
}
