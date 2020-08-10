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

        public string TenTK { get => tenTK; set => tenTK = value; }
        public string TenUser { get => tenUser; set => tenUser = value; }
        public bool PhanQuyen { get => phanQuyen; set => phanQuyen = value; }

        public User()
        {
            this.TenTK = "";
            this.TenUser = "";
            this.PhanQuyen = false;
        }

        public User(User user)
        {
            this.TenTK = user.TenTK;
            this.TenUser = user.TenUser;
            this.PhanQuyen = user.PhanQuyen;
        }

        public void dangXuat()
        {
            this.TenTK = "";
            this.TenUser = "";
            this.PhanQuyen = false;
        }
    }
}
