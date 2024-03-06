using DAM.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM.BLL
{
    public class ProductBLL
    {
        private ProductDAL productDAL;
        public ProductBLL(string connectionString)
        {
            productDAL = new ProductDAL(connectionString);
        }
        public ProductBLL() { }
        public bool ValidInfo(string name, int soluong, int gianhap, int giaban, string ghichu)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(ghichu))
            {
                return false;
            }
            if (soluong > 0 && gianhap > 0 && giaban > 0)
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
