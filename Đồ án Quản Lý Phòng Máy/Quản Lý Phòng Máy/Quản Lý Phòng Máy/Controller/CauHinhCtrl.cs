using QuanLyPhongMay.DataLayer;
using QuanLyPhongMay.BUS;
using System.Windows.Forms;

namespace QuanLyPhongMay.Controller
{
    class CauHinhCtrl
    {
        //Khởi tạo biến giá trị.
        CauHinhData cauHinhData = new CauHinhData();

        //Hàm xử lý lấy giá trị ID lớn nhất trong database.
        public int GetID()
        {
            return cauHinhData.GetID();
        }

        //Hàm kiểm tra thiết bị có đang sử dụng.
        public bool KTSuDung(int maCauHinh)
        {
            return cauHinhData.KTSuDung(maCauHinh);
        }

        //Hàm kiểm tra tên.
        public bool KTCauHinh(string tenCauHinh)
        {
            return cauHinhData.KTCauHinh(tenCauHinh);
        }

        //Hàm xử lý hiển thị ds thiết bị lên datagridview.
        public void HienThiDgv(DataGridView dgv)
        {
            dgv.DataSource = cauHinhData.LayDSCauHinh().Tables[0];
        }

        //Hàm xử lý hiển thị thiết bị lên combox.
        public void HienThiCbo(ComboBox cbo)
        {
            cbo.DataSource = cauHinhData.LayDSCauHinh().Tables[0];
            cbo.DisplayMember = "TenCauHinh";
            cbo.ValueMember = "MaCauHinh";
        }

        //Hàm xử lý thêm mới.
        public int Them(CauHinh cauHinh)
        {
            return cauHinhData.Them(cauHinh);
        }

        //Hàm xử lý xóa.
        public int Xoa(int maCauHinh)
        {
            return cauHinhData.Xoa(maCauHinh);
        }

        //Hàm xử lý cập nhật.
        public int CapNhat(CauHinh cauHinh)
        {
            return cauHinhData.CapNhat(cauHinh);
        }

        //Hàm xử lý tìm kiếm.
        public void TimKiem(DataGridView dgv, string key, string loaiTK)
        {
            dgv.DataSource = cauHinhData.LayDSTK(key, loaiTK).Tables[0];
        }
    }
}
