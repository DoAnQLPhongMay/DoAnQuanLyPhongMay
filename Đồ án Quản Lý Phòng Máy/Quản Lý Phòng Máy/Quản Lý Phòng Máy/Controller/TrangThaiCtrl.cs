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
        TrangThaiData trangThaiData = new TrangThaiData();

        public void HienThiCbo(ComboBox cb)
        {
            cb.DataSource = trangThaiData.LayDSTrangThai().Tables[0];
            cb.DisplayMember = "TenTrangThai";
            cb.ValueMember = "MaTrangThai";
        }
    }
}
