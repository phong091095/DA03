using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM.DTO
{
   class Customer
    {
        private string _SDT;
        private string _CusName;
        private string _Address;
        private string _Sex;


        public Customer()
        {

        }

        public Customer(string sDT, string cusName, string address, string sex)
        {
            _SDT = sDT;
            _CusName = cusName;
            _Address = address;
            _Sex = sex;
        }

        public string SDT { get => _SDT; set => _SDT = value; }
        public string CusName { get => _CusName; set => _CusName = value; }
        public string Address { get => _Address; set => _Address = value; }
        public string Sex { get => _Sex; set => _Sex = value; }
    }
}
