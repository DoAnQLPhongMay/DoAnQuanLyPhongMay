using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongMay.Class
{
    public class User
    {
        //Khởi tạo biến giá trị.
        private string tenTK, tenUser;
        private bool phanQuyen;

        //Hàm xử lý getter và setter
        public string TenTK { get => tenTK; set => tenTK = value; }
        public string TenUser { get => tenUser; set => tenUser = value; }
        public bool PhanQuyen { get => phanQuyen; set => phanQuyen = value; }

        //Khởi tạo mặc định của class.
        public User()
        {
            this.TenTK = "vmkhoi";
            this.TenUser = "";
            this.PhanQuyen = true;
        }

        public User(User user)
        {
            this.TenTK = user.TenTK;
            this.TenUser = user.TenUser;
            this.PhanQuyen = user.PhanQuyen;
        }

        //Hàm gán giá trị user sau khi đăng xuất.
        public void dangXuat()
        {
            this.TenTK = "";
            this.TenUser = "";
            this.PhanQuyen = false;
        }
    }
}
