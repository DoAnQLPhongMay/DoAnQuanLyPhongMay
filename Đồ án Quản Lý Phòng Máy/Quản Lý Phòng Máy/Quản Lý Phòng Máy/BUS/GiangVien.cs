using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongMay.BUS
{
    class GiangVien
    {

        private int _magv;

        public int MaGV
        {
            get { return _magv; }
            set { _magv = value; }
        }
        private string _tengv;

        public string TenGV
        {
            get { return _tengv; }
            set { _tengv = value; }
        }
        private DateTime _ngaysinh;

        public DateTime Ngaysinh
        {
            get { return _ngaysinh; }
            set { _ngaysinh = value; }
        }
        private bool _gioitinh;

        public bool Gioitinh
        {
            get { return _gioitinh; }
            set { _gioitinh = value; }
        }
        private string _diachi;

        public string Diachi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }
        private string _sodienthoai;

        public string SoDienThoai
        {
            get { return _sodienthoai; }
            set { _sodienthoai = value; }
        }
        private string _tendangnhap;

        public string TenDangNhap
        {
            get { return _tendangnhap; }
            set { _tendangnhap = value; }
        }
        private string _matkhau;

        public string MatKhau
        {
            get { return _matkhau; }
            set { _matkhau = value; }
        }
        public GiangVien()
        {
            
        }


    }
}
