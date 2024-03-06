using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAM.DTO
{
     class Product
    {
		private int _MaSP;
        private string _TenSP;
        private int _SoLuong;
        private int _GiaNhap;
        private int _GiaBan;
        private byte[] _Hinhanh;
        private string _GhiChu;
        private string _MaNV;
        public Product() { }
        public Product(int maSP, string tenSP, int soLuong, int giaNhap, int giaBan, byte[] hinhAnh, string ghiChu, string maNV)
        {
            MaSP = maSP;
            TenSP = tenSP;
            SoLuong = soLuong;
            GiaNhap = giaNhap;
            GiaBan = giaBan;
            HinhAnh = hinhAnh;
            GhiChu = ghiChu;
            MaNV = maNV;
        }

        public int MaSP { get => _MaSP; set => _MaSP = value; }
        public string TenSP { get => _TenSP; set => _TenSP = value; }
        public int SoLuong { get => SoLuong; set => SoLuong = value; }
        public int GiaNhap { get => _GiaNhap; set => _GiaNhap = value; }
        public int GiaBan { get => _GiaBan; set => _GiaBan = value; }
        public byte[] HinhAnh { get => _Hinhanh; set => _Hinhanh = value; }
        public string GhiChu { get => _GhiChu; set => _GhiChu = value; }
        public string MaNV { get => MaNV; set => MaNV = value; }
    }
}
