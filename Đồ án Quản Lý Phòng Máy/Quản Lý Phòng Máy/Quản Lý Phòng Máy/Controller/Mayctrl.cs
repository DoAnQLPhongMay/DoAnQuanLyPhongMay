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
    class MayCtrl
    {

        MayData mayData = new MayData();
        public void HienThiPhongCbo(ComboBox cb)
        {
            cb.DataSource = mayData.LayDSMay().Tables[0];
            cb.DisplayMember = "MaPhongMay";
            cb.ValueMember = "TenPhongMay";
        }

       /* public void HienThiTrangThaiCbo(ComboBox cb)
        {
            cb.DataSource = mayData.LayDSMay().Tables[0];
            cb.DisplayMember = "MaTrangThai";
            cb.ValueMember = "TenTrangThai";
        }*/

        public void HienThi(DataGridView dgv)
        {
            dgv.DataSource = mayData.LayDSMay().Tables[0];
        }
        public void TimKiem(DataGridView dgv, string tukhoa, string tieuchi)
        {
            dgv.DataSource = mayData.LayDSTK(tukhoa, tieuchi).Tables[0];
        }
        public int Them(May m)
        {
            if (!KiemTraMaMay(m.MaMay))
                return 0;
            if (KiemTraTenMay(m.TenMay))
                return -1;
            return mayData.Them(m);
        }
        public int Xoa(int ma)
        {
            return mayData.Xoa(ma);
        }
        public int Luu(May m)
        {
            return mayData.Luu(m);
        }
        public bool KiemTraMaMay(string mamay)
        {
            return mayData.KiemTraMaMay(mamay);
        }
        public bool KiemTraTenMay(string tenmay)
        {
            return mayData.KiemTraTenMay(tenmay);
        }

    }
}
