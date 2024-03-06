using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DAM.DAL;

namespace DAM.BLL
{
    public class CustomerBLL
    {
        private CustomerDAL customerDAL;

        public CustomerBLL(string connectionString)
        {
            customerDAL = new CustomerDAL(connectionString);
        }
        public CustomerBLL() { }

        public bool ValidPhone(string phoneNumber)
        {
            string pattern = @"^[0-9]{10}$";

            if (Regex.IsMatch(phoneNumber, pattern))
            {
                return true;
            }
            else
            {
                return false; 
            }
        }
        public bool ValidName(string name)
        {
            string pattern = @"^[a-zA-Z ]+$";

            if (Regex.IsMatch(name, pattern))
            {
                return true; 
            }
            else
            {
                return false; 
            }
        }
            public bool ValidateCustomerInfo(string phone, string name, string address)
            {
                // Kiểm tra nghiệp vụ

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(address))
                {
                    return false;
                }

                if (!ValidPhone(phone))
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

