using QuanLyPhongMay.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongMay.Controller
{
    class TrangThaiCtrl
    {
        //Khởi tạo biến giá trị.
        TrangThaiData trangThaiData = new TrangThaiData();

        //Hàm xử lý hiển thị dữ liệu lên combox.
        public void HienThiCbo(ComboBox cb)
        {
            cb.DataSource = trangThaiData.LayDSTrangThai().Tables[0];
            cb.DisplayMember = "TenTrangThai";
            cb.ValueMember = "MaTrangThai";
        }
    }
}
