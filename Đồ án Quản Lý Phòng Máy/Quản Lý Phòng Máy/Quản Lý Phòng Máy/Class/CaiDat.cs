using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using QuanLyPhongMay.Class;

namespace QuanLyPhongMay
{
    class CaiDat
    {

        DataProvider cls = new DataProvider();
        public CaiDat()
        {
            KhoiTaoAdmin();
        }
        public void KhoiTaoAdmin()
        {
            SqlCommand cmd = new SqlCommand("select * from dtb_TaiKhoan");
            DataSet ds = cls.LayDuLieu(cmd);
            if (ds.Tables[0].Rows.Count <= 0)
            {
                SqlCommand scmd = new SqlCommand("insert into dtb_TaiKhoan(TenDangNhap,MatKhau,MaTaiKhoan,HoVaTen,GioiTinh,SDT,Email,NgaySinh,DiaChi,LoaiTK) values(@tendn,@mk,@matk,@hoten,@gtinh,@sdt,@email,@ngsinh,@dchi,@loaitk)");
                scmd.Parameters.Add("tendn", SqlDbType.VarChar).Value = "thien";
                scmd.Parameters.Add("mk", SqlDbType.VarChar).Value = "123";
                scmd.Parameters.Add("matk", SqlDbType.VarChar).Value = "0306171201";
                scmd.Parameters.Add("hoten", SqlDbType.NVarChar).Value = "Tran Quang Thien";
                scmd.Parameters.Add("gtinh", SqlDbType.Bit).Value = 1;
                scmd.Parameters.Add("sdt", SqlDbType.NChar).Value = "0327869533";
                scmd.Parameters.Add("email", SqlDbType.VarChar).Value ="tranquangthien0@gmail.com";
                scmd.Parameters.Add("ngsinh", SqlDbType.Date).Value = "30-07-1999";
                scmd.Parameters.Add("dchi", SqlDbType.NVarChar).Value = "71 duong so 2";
                scmd.Parameters.Add("loaitk", SqlDbType.Bit).Value = 1;
                cls.CapNhatDL(scmd);
            }
        }
        

    }
}
