using System;
using QuanLyPhongMay.DataLayer;
using QuanLyPhongMay.BUS;
using System.Windows.Forms;
using System.Data;
using QuanLyPhongMay.Class;

namespace QuanLyPhongMay.Controller
{
    class KhoaCtrl
    {
        //Khởi tạo biến giá trị.
        KhoaData khoaData = new KhoaData();

        //Hàm xử lý lấy giá trị ID lớn nhất trong database.
        public int GetID()
        {
            return khoaData.GetID();
        }

        //Hàm kiểm tra thiết bị có đang sử dụng.
        public bool KTSuDung(int maKhoa)
        {
            return khoaData.KTSuDung(maKhoa);
        }

        //Hàm kiểm tra tên.
        public bool KTTenKhoa(string tenKhoa)
        {
            return khoaData.KTTenKhoa(tenKhoa);
        }

        //Hàm xử lý hiển thị ds thiết bị lên datagridview.
        public void HienThiDgv(DataGridView dgv)
        {
            dgv.DataSource = khoaData.LayDSKhoa().Tables[0];
        }

        //Hàm xử lý hiển thị thiết bị lên combox.
        public void HienThiCbo(ComboBox cb)
        {
            cb.DataSource = khoaData.LayDSKhoa().Tables[0];
            cb.DisplayMember = "TenKhoa";
            cb.ValueMember = "MaKhoa";
        }

        //Hàm xử lý thêm mới thiết bị.
        public int Them(Khoa khoa)
        {
            return khoaData.Them(khoa);
        }

        //Hàm xử lý xóa thiết bị.
        public int Xoa(int maKhoa)
        {
            return khoaData.Xoa(maKhoa);
        }

        //Hàm xử lý cập nhật thiết bị.
        public int CapNhat(Khoa khoa)
        {
            return khoaData.CapNhat(khoa);
        }

        //Hàm xử lý tìm kiếm thiết bị.
        public void TimKiem(DataGridView dgv, string key, string loaiTK)
        {
            dgv.DataSource = khoaData.LayDSTK(key, loaiTK).Tables[0];
        }
    }
}
