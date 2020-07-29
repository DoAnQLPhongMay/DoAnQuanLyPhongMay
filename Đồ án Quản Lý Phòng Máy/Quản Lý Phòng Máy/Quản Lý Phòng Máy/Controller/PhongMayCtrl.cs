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
    class PhongMayCtrl
    {
        PhongMayData phongData = new PhongMayData();

        //Hàm hiển thị danh sách phòng máy vào Combobox.
        public void HienThiComboBox(ComboBox cb)
        {
            cb.DataSource = phongData.LayDSPhong().Tables[0];
            cb.DisplayMember = "TenPhong";
            cb.ValueMember = "MaPhong";
        }

        //Hàm hiển thị danh sách phòng máy lên Datagridview.
        public void HienThiDgv(DataGridView dgv)
        {
            dgv.DataSource = phongData.LayDSPhong().Tables[0];
        }

        //Hàm xử chức năng tìm kiếm phòng máy.
        public void TimKiem(DataGridView dgv, string key, string loaiTK)
        {
            dgv.DataSource = phongData.LayDSTK(key, loaiTK).Tables[0];
        }

        //Hàm xử chức năng thêm mới phòng máy.
        public int Them(PhongMay phong)
        {
            return phongData.Them(phong);
        }

        //Hàm xử chức năng xóa phòng máy.
        public int Xoa(int maPhong)
        {
            return phongData.Xoa(maPhong);
        }

        //Hàm xử chức năng cập nhật phòng máy.
        public int CapNhat(PhongMay phong)
        {
            return phongData.CapNhat(phong);
        }
    }
}
