using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhongMay.DataLayer;
using QuanLyPhongMay.BUS;
using System.Windows.Forms;

namespace QuanLyPhongMay.Controller
{
    class LichSuNhapCtrl
    {
        //Khởi tạo biến giá trị.
        LichSuNhapData lsNhapData = new LichSuNhapData();

        //Hàm xử lý lấy giá trị ID lớn nhất trong database.
        public int GetID()
        {
            return lsNhapData.GetID();
        }

        //Hàm hiển thị danh sách LSNhap lên datagridview.
        public void HienThiDgv(DataGridView dgv)
        {
            dgv.DataSource = lsNhapData.LayDSLichSuNhap().Tables[0];
        }

        //Hàm xử lý thêm mới LSNhap.
        public int Them(LichSuNhap lsNhap)
        {
            return lsNhapData.Them(lsNhap);
        }

        //Hàm cập nhật lại số lượng sau khi thêm mới LSNhap.
        public int CapNhatSL(LichSuNhap lsNhap)
        {
            return lsNhapData.CapNhatSL(lsNhap);
        }

        //Hàm xử lý tìm kiếm LSNhap.
        public void TimKiem(DataGridView dgv, string key, string loaiTK)
        {
            dgv.DataSource = lsNhapData.LayDSTK(key, loaiTK).Tables[0];
        }
    }
}
