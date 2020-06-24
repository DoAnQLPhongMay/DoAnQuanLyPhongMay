-- Danh sách tài khoản --
SELECT * 
FROM dtb_TaiKhoan
GO

-- Danh sách phòng --
SELECT * 
FROM dtb_PhongMay
GO

-- Danh sách máy --
SELECT * 
FROM dtb_May
GO

-- Danh sách thiết bị --
SELECT MaThietBi, TenThietBi, TSThietBi, TenLoaiThietBi, SoLuong, NamSanXuat, NhaSanXuat, HanThanhLy, GhiChu
FROM dtb_ChiTietThietBi, dtb_LoaiThietBi
WHERE dtb_ChiTietThietBi.MaLoai = dtb_LoaiThietBi.MaLoai
GO

-- Danh sách nhập --
SELECT * 
FROM dtb_LichSuNhap
GO

-- Danh sách thanh lý --
SELECT * 
FROM dtb_LichSuThanhLy
GO

-- Danh sách máy của 1 phòng --
SELECT MaPhongMay, TenPhongMay, MaMay, TenMay, TrangThai, GhiChu
FROM dtb_PhongMay, dtb_May
WHERE dtb_PhongMay.MaPhongMay = dtb_May.MaPhong 
		AND dtb_PhongMay.MaPhongMay = 1
GO

-- Danh sách thiết bị của 1 loại --
SELECT MaThietBi, TenThietBi, TSThietBi, TenLoaiThietBi, SoLuong, HanThanhLy
FROM dtb_LoaiThietBi, dtb_ChiTietThietBi
WHERE dtb_LoaiThietBi.MaLoai = dtb_ChiTietThietBi.MaLoai
		AND dtb_ChiTietThietBi.MaLoai = 1
GO

-- Lấy thông tin tài khoản --
SELECT MaGiangVien, HoVaTen, GioiTinh, SDT, NgaySinh, DiaChi
FROM dtb_TaiKhoan
WHERE TenDangNhap = 'vmkhoi'
GO

-- Thông tin thiết bị của 1 máy --
SELECT dtb_ChiTietMay.MaMay, TenMay, dtb_ChiTietThietBi.MaThietBi, TenThietBi, TSThietBi, NamSanXuat, NhaSanXuat
FROM dtb_May, dtb_ChiTietMay, dtb_ChiTietThietBi
WHERE dtb_May.MaMay = dtb_ChiTietMay.MaMay 
		AND dtb_ChiTietMay.MaThietBi = dtb_ChiTietThietBi.MaThietBi 
		AND dtb_ChiTietMay.MaMay = 1
GO