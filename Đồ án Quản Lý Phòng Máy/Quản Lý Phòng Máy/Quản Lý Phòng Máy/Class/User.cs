using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongMay.Class
{
    public class User
    {
        private string tenTK, tenUser;
        private bool phanQuyen;

        public User()
        {
            this.tenTK = "";
            this.tenUser = "";
            this.phanQuyen = false;
        }

        public User(User user)
        {
            this.tenTK = user.tenTK;
            this.tenUser = user.tenUser;
            this.phanQuyen = user.phanQuyen;
        }

        public void DangNhap(string tenTK, string tenUser, bool phanQuyen)
        {
            this.tenTK = tenTK;
            this.tenUser = tenUser;
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

        public bool getPhanQuyen()
        {
            return phanQuyen;
        }
    }
}
