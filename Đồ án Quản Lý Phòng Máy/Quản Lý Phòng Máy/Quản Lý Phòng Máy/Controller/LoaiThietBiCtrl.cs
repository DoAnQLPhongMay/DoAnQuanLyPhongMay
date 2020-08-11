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
    class LoaiThietBiCtrl
    {
        //Khởi tạo biến giá trị.
        LoaiThietBiData loaiThietBiData = new LoaiThietBiData();

        //Hàm xử lý hiển thị loại thiết bị lên combox.
        public void HienThiCbo(ComboBox cb)
        {
            cb.DataSource = loaiThietBiData.LayDSMaLoai().Tables[0];
            cb.DisplayMember = "TenLoaiThietbi";
            cb.ValueMember = "MaLoai";
        }
    }
}
