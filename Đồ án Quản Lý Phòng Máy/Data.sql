-- Data TaiKhoan --
INSERT INTO dtb_TaiKhoan(TenDangNhap, MatKhau, MaTaiKhoan, HoVaTen, GioiTinh, SDT, Email, NgaySinh, DiaChi, LoaiTK)
VALUES ('vominhkhoi', '123', '0306171150', N'Võ Minh Khôi',1, '0123456789', 'khoi@gmail.com', NULL, NULL, 1)
GO

INSERT INTO dtb_TaiKhoan(TenDangNhap, MatKhau, MaTaiKhoan, HoVaTen, GioiTinh, SDT, Email, NgaySinh, DiaChi, LoaiTK)
VALUES ('tranquangthien', '123', '0306171201', N'Trần Quang Thiện',1, '0123456789', 'thien@gmail.com', NULL, NULL, 1)
GO

INSERT INTO dtb_TaiKhoan(TenDangNhap, MatKhau, MaTaiKhoan, HoVaTen, GioiTinh, SDT, Email, NgaySinh, DiaChi, LoaiTK)
VALUES ('nguyenducchuan', '123', NULL, N'Nguyễn Đức Chuẩn',1, '0123456789', 'chuan@gmail.com', NULL, NULL, 1)
GO

INSERT INTO dtb_TaiKhoan(TenDangNhap, MatKhau, MaTaiKhoan, HoVaTen, GioiTinh, SDT, Email, NgaySinh, DiaChi, LoaiTK)
VALUES ('vmkhoi', '123', '0306171150', N'Võ Minh Khôi',1, '0123456789', 'khoi@gmail.com', NULL, NULL, 0)
GO

INSERT INTO dtb_TaiKhoan(TenDangNhap, MatKhau, MaTaiKhoan, HoVaTen, GioiTinh, SDT, Email, NgaySinh, DiaChi, LoaiTK)
VALUES ('tqthien', '123', '0306171201', N'Trần Quang Thiện',1, '0123456789', 'thien@gmail.com', NULL, NULL, 0)
GO

INSERT INTO dtb_TaiKhoan(TenDangNhap, MatKhau, MaTaiKhoan, HoVaTen, GioiTinh, SDT, Email, NgaySinh, DiaChi, LoaiTK)
VALUES ('ndchuan', '123', NULL, N'Nguyễn Đức Chuẩn',1, '0123456789', 'chuan@gmail.com', NULL, NULL, 0)
GO

-- Data TrangThai --
INSERT INTO dtb_TrangThai(MaTrangThai, TenTrangThai)
VALUES (0, 'Bảo Trì')
GO

INSERT INTO dtb_TrangThai(MaTrangThai, TenTrangThai)
VALUES (1, 'Bình Thường')
GO

-- Data PhongMay --
INSERT INTO dtb_PhongMay(MaPhongMay, TenPhongMay, SoLuongMay, TrangThai, GhiChu)
VALUES (1, 'F7-1', 45, 1, NULL)
GO

INSERT INTO dtb_PhongMay(MaPhongMay, TenPhongMay, SoLuongMay, TrangThai, GhiChu)
VALUES (2, 'F7-2', 45, 1, NULL)
GO

INSERT INTO dtb_PhongMay(MaPhongMay, TenPhongMay, SoLuongMay, TrangThai, GhiChu)
VALUES (3, 'F7-3', 40, 1, NULL)
GO

INSERT INTO dtb_PhongMay(MaPhongMay, TenPhongMay, SoLuongMay, TrangThai, GhiChu)
VALUES (4, 'F7-4', 40, 0, NULL)
GO

INSERT INTO dtb_PhongMay(MaPhongMay, TenPhongMay, SoLuongMay, TrangThai, GhiChu)
VALUES (5, 'F7-5', 50, 1, NULL)
GO

INSERT INTO dtb_PhongMay(MaPhongMay, TenPhongMay, SoLuongMay, TrangThai, GhiChu)
VALUES (6, 'F7-6', 50, 0, NULL)
GO

-- Data May --
INSERT INTO dtb_May(MaMay, MaPhong, TenMay, TrangThai, GhiChu)
VALUES (1, 1, 'F7-1-1', 1, NULL)
GO

INSERT INTO dtb_May(MaMay, MaPhong, TenMay, TrangThai, GhiChu)
VALUES (46, 2, 'F7-2-1', 1, NULL)
GO

INSERT INTO dtb_May(MaMay, MaPhong, TenMay, TrangThai, GhiChu)
VALUES (91, 3, 'F7-3-1', 1, NULL)
GO

INSERT INTO dtb_May(MaMay, MaPhong, TenMay, TrangThai, GhiChu)
VALUES (131, 4, 'F7-4-1', 0, NULL)
GO

-- Loai Thiet Bi --
INSERT INTO dtb_LoaiThietBi(MaLoai, TenLoaiThietBi)
VALUES (1, 'Màn Hình')
GO

INSERT INTO dtb_LoaiThietBi(MaLoai, TenLoaiThietBi)
VALUES (2, 'Chuột')
GO

INSERT INTO dtb_LoaiThietBi(MaLoai, TenLoaiThietBi)
VALUES (3, 'Bàn Phím')
GO

INSERT INTO dtb_LoaiThietBi(MaLoai, TenLoaiThietBi)
VALUES (4, 'Thùng')
GO

INSERT INTO dtb_LoaiThietBi(MaLoai, TenLoaiThietBi)
VALUES (5, 'CPU')
GO

INSERT INTO dtb_LoaiThietBi(MaLoai, TenLoaiThietBi)
VALUES (6, 'Mainboard')
GO

INSERT INTO dtb_LoaiThietBi(MaLoai, TenLoaiThietBi)
VALUES (7, 'RAM')
GO

INSERT INTO dtb_LoaiThietBi(MaLoai, TenLoaiThietBi)
VALUES (8, 'Ổ Cứng')
GO

INSERT INTO dtb_LoaiThietBi(MaLoai, TenLoaiThietBi)
VALUES (9, 'VGA')
GO

INSERT INTO dtb_LoaiThietBi(MaLoai, TenLoaiThietBi)
VALUES (10, 'PSU')
GO

INSERT INTO dtb_LoaiThietBi(MaLoai, TenLoaiThietBi)
VALUES (11, 'Hệ Điều Hành')
GO

-- Thiet Bi --
INSERT INTO dtb_ChiTietThietBi(MaThietBi, TenThietBi, TSThietBi, SoLuong, MaLoai, NamSanXuat, NhaSanXuat, HanThanhLy, GhiChu)
VALUES (1, 'Core i3 8100', '', 50, 5, 2010, '', 10, '')
GO