using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongMay.Class
{
    public class User
    {
        private string tenTK, tenUser, sdt, diaChi, ngaySinh, email;
        private bool gioiTinh, phanQuyen;

        public User()
        {
            this.tenTK = "";
            this.tenUser = "";
            this.sdt = "";
            this.diaChi = "";
            this.ngaySinh = "";
            this.email = "";
            this.gioiTinh = false;
            this.phanQuyen = false;
        }

        public User(User user)
        {
            this.tenTK = user.tenTK;
            this.tenUser = user.tenUser;
            this.sdt = user.sdt;
            this.diaChi = user.diaChi;
            this.ngaySinh = user.ngaySinh;
            this.email = "";
            this.gioiTinh = user.gioiTinh;
            this.phanQuyen = user.phanQuyen;
        }

        public void DangNhap(string tenTK, string tenUser, string sdt, string diaChi, string ngaySinh, bool gioiTinh, bool phanQuyen)
        {
            this.tenTK = tenTK;
            this.tenUser = tenUser;
            this.sdt = sdt;
            this.diaChi = diaChi;
            this.ngaySinh = ngaySinh;
            this.email = "";
            this.gioiTinh = gioiTinh;
            this.phanQuyen = phanQuyen;
        }

        public string getTenTK()
        {
            return tenTK;
        }

        public string getTenUser()
        {
            return tenUser;
        }

        public string getSDT()
        {
            return sdt;
        }

        public string getDiaChi()
        {
            return diaChi;
        }

        public string getNgaySinh()
        {
            return ngaySinh;
        }

        public bool getGioiTinh()
        {
            return gioiTinh;
        }

        public bool getPhanQuyen()
        {
            return phanQuyen;
        }
    }
}
