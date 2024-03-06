using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM.DTO
{
    class Staff
    {
        private string _Manv;
        private string _Name;
        private string _Email;
        private string _Address;
        private string _Role;
        private string _Status;

        public Staff() { }
        public Staff(string manv, string name, string email, string address, string role, string status)
        {
            _Manv = manv;
            _Name = name;
            _Email = email;
            _Address = address;
            _Role = role;
            _Status = status;
        }
        public string Manv { get => _Manv; set => _Manv = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Address { get => _Address; set => _Address = value; }
        public string Role { get => _Role; set => _Role = value; }
        public string Status { get => _Status; set => _Status = value; }
    }
}
