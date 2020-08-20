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
    class LSCapNhatCtrl
    {
        LSCapNhatData lsCNData = new LSCapNhatData();

        public int GetID()
        {
            return lsCNData.GetID();
        }

        public void HienThi(DataGridView dgv)
        {
            dgv.DataSource = lsCNData.LayDSCapNhat().Tables[0];
        }

        public void ThemMoi(LichSuCapNhat lsCapNhat)
        {
            lsCNData.ThemLSCapNhat(lsCapNhat);
            lsCNData.ThemChiTietLSCapNhat(lsCapNhat);
        }
    }
}
