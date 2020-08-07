using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongMay.BUS
{
    class TaiKhoan
    {

        private string _magv;

        public string MaGV
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
        private string _sdt;

        public string SDT
        {
            get { return _sdt; }
            set { _sdt = value; }
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
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private int _loaitaikhoan;
        public int LoaiTaiKhoan
        {
            get { return _loaitaikhoan; }
            set { _loaitaikhoan = value; }
        }
        public TaiKhoan()
        {
            
        }

        public static implicit operator TaiKhoan(May v)
        {
            throw new NotImplementedException();
        }
    }
}
