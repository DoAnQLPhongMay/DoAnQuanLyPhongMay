﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using QuanLyPhongMay.BUS;
using System.Data.SqlClient;

namespace QuanLyPhongMay.DataLayer
{
    class GiangVienDATA
    {
        DataProvider cls = new DataProvider();
        public DataSet LayDLMotDong(string ten)
        {
            SqlCommand cmd = new SqlCommand("select * from NhanVien where TenDangNhap=@tendangnhap");
            cmd.Parameters.Add("tendangnhap", SqlDbType.VarChar).Value = ten;
            return cls.LayDuLieu(cmd);
        }
        public DataSet LayDSGiangVien()
        {
            SqlCommand sqlcmd = new SqlCommand("select * from NhanVien");
            return cls.LayDuLieu(sqlcmd);
        }
        public DataSet LayDSTK(string tukhoa, string tieuchi)
        {
            string sql = "select * from NhanVien";

            switch (tieuchi)
            {
                case "tennv":
                    sql += " where TenNV like \"%" + tukhoa + "%\"";
                    break;
                case "diachi":
                    sql += " where DiaChi like \"%" + tukhoa + "%\"";
                    break;
                case "tendangnhap":
                    sql += " where TenDangNhap like \"%" + tukhoa + "%\"";
                    break;
            }
            SqlCommand sqlcmd = new SqlCommand(sql);
            return cls.LayDuLieu(sqlcmd);
        }
        public int Xoa(int ma)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "delete from NhanVien where MaNV=@manv";
            cmd.Parameters.Add("manv", SqlDbType.SmallInt).Value = ma;
            return cls.CapNhatDL(cmd);
        }
        public int Them(GiangVien gv)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into NhanVien(TenNV,GioiTinh,NgaySinh,DiaChi,SoDienThoai,TenDangNhap,MatKhau) values(@ten,@gioitinh,@ngsinh,@diachi,@sdt,@tendangnhap,@matkhau)";
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = gv.TenGV;
            cmd.Parameters.Add("gioitinh", SqlDbType.Int).Value = gv.Gioitinh;
            cmd.Parameters.Add("ngsinh", SqlDbType.Date).Value = gv.Ngaysinh;
            cmd.Parameters.Add("diachi", SqlDbType.NVarChar).Value = gv.Diachi;
            cmd.Parameters.Add("sdt", SqlDbType.NChar).Value = gv.SoDienThoai;
            cmd.Parameters.Add("tendangnhap", SqlDbType.VarChar).Value = gv.TenDangNhap;
            cmd.Parameters.Add("matkhau", SqlDbType.VarChar).Value = DataProvider.MD5(gv.MatKhau);
            return cls.CapNhatDL(cmd);
        }
        public int Luu(GiangVien gv)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update NhanVien set TenNV=@ten,GioiTinh=@gt,NgaySinh=@ngsinh,DiaChi=@diachi,SoDienThoai=@sdt where MaNV=@ma";
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = gv.TenGV;
            cmd.Parameters.Add("gioitinh", SqlDbType.Int).Value = gv.Gioitinh;
            cmd.Parameters.Add("ngsinh", SqlDbType.Date).Value = gv.Ngaysinh;
            cmd.Parameters.Add("diachi", SqlDbType.NVarChar).Value = gv.Diachi;
            cmd.Parameters.Add("sdt", SqlDbType.NChar).Value = gv.SoDienThoai;
            cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = gv.MaGV;
            return cls.CapNhatDL(cmd);
        }
        public bool KiemTra(string tk)
        {
            SqlCommand cmd = new SqlCommand();
            
            cmd.CommandText = "select * from NhanVien where TenDangNhap=@tdn";
            cmd.Parameters.Add("tdn", OleDbType.VarChar).Value = tk;
            return (cls.LayDuLieu(cmd).Tables[0].Rows.Count > 0);
        }
        public int DoiThongTin(GiangVien gv)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update NhanVien set TenNV=@ten,GioiTinh=@gt,NgaySinh=@ngsinh,DiaChi=@diachi,SoDienThoai=@sdt,MatKhau=@matkhau where MaNV=@ma";
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = gv.TenGV;
            cmd.Parameters.Add("gioitinh", SqlDbType.Int).Value = gv.Gioitinh;
            cmd.Parameters.Add("ngsinh", SqlDbType.Date).Value = gv.Ngaysinh;
            cmd.Parameters.Add("diachi", SqlDbType.NVarChar).Value = gv.Diachi;
            cmd.Parameters.Add("sdt", SqlDbType.NChar).Value = gv.SoDienThoai;
            cmd.Parameters.Add("matkhau", SqlDbType.VarChar).Value = DataProvider.MD5(gv.MatKhau);
            cmd.Parameters.Add("ma", SqlDbType.SmallInt).Value = gv.MaGV;
            return cls.CapNhatDL(cmd);
        }
    }
}
