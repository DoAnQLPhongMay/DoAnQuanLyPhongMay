﻿using System;
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
        //Khởi tạo biến giá trị.
        ThietBiData thietBiData = new ThietBiData();
        
        //Hàm xử lý lấy giá trị ID lớn nhất trong database.
        public int GetID()
        {
            return thietBiData.GetID();
        }

        //Hàm kiểm tra thiết bị có đang sử dụng.
        public bool KTThietBi(int maThietBi)
        {
            return thietBiData.KTThietBi(maThietBi);
        }

        //Hàm xử lý hiển thị ds thiết bị lên datagridview.
        public void HienThiDgv(DataGridView dgv)
        {
            dgv.DataSource = thietBiData.LayDSThietBi().Tables[0];
        }

        //Hàm xử lý hiển thị thiết bị lên combox.
        public void HienThiCbo(ComboBox cb)
        {
            cb.DataSource = thietBiData.LayDSThietBi().Tables[0];
            cb.DisplayMember = "TenThietBi";
            cb.ValueMember = "MaThietBi";
        }

        //Hàm xử lý thêm mới thiết bị.
        public int Them(ThietBi thietBi)
        {
            return thietBiData.Them(thietBi);
        }

        //Hàm xử lý xóa thiết bị.
        public int Xoa(int maThietBi)
        {
            return thietBiData.Xoa(maThietBi);
        }

        //Hàm xử lý cập nhật thiết bị.
        public int CapNhat(ThietBi thietBi)
        {
            return thietBiData.CapNhat(thietBi);
        }

        //Hàm xử lý tìm kiếm thiết bị.
        public void TimKiem(DataGridView dgv, string key, string loaiTK)
        {
            dgv.DataSource = thietBiData.LayDSTK(key, loaiTK).Tables[0];
        }
    }
}
