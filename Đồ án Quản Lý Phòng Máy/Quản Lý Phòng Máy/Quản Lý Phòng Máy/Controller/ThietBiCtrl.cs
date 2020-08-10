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
    class ThietBiCtrl
    {
        ThietBiData thietBiData = new ThietBiData();
        
        public int getID()
        {
            return thietBiData.getID();
        }

        public void HienThiDgv(DataGridView dgv)
        {
            dgv.DataSource = thietBiData.LayDSThietBi().Tables[0];
        }

        public void HienThiCbo(ComboBox cb)
        {
            cb.DataSource = thietBiData.LayDSThietBi().Tables[0];
            cb.DisplayMember = "TenThietBi";
            cb.ValueMember = "MaThietBi";
        }

        public int Them(ThietBi thietBi)
        {
            return thietBiData.Them(thietBi);
        }

        public int Xoa(int maThietBi)
        {
            return thietBiData.Xoa(maThietBi);
        }

        public int CapNhat(ThietBi thietBi)
        {
            return thietBiData.CapNhat(thietBi);
        }

        public void TimKiem(DataGridView dgv, string key, string loaiTK)
        {
            dgv.DataSource = thietBiData.LayDSTK(key, loaiTK).Tables[0];
        }
    }
}
