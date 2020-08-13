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
VALUES (0, N'Bảo Trì')
GO

INSERT INTO dtb_TrangThai(MaTrangThai, TenTrangThai)
VALUES (1, N'Bình Thường')
GO

-- Data PhongMay --
INSERT INTO dtb_PhongMay(MaPhongMay, TenPhongMay, SoLuongMay, TrangThai, GhiChu)
VALUES (1, 'F7-1', 50, 1, NULL)
GO

INSERT INTO dtb_PhongMay(MaPhongMay, TenPhongMay, SoLuongMay, TrangThai, GhiChu)
VALUES (2, 'F7-2', 50, 1, NULL)
GO

INSERT INTO dtb_PhongMay(MaPhongMay, TenPhongMay, SoLuongMay, TrangThai, GhiChu)
VALUES (3, 'F7-3', 50, 1, NULL)
GO

INSERT INTO dtb_PhongMay(MaPhongMay, TenPhongMay, SoLuongMay, TrangThai, GhiChu)
VALUES (4, 'F7-4', 40, 0, NULL)
GO

INSERT INTO dtb_PhongMay(MaPhongMay, TenPhongMay, SoLuongMay, TrangThai, GhiChu)
VALUES (5, 'F7-5', 40, 1, NULL)
GO

INSERT INTO dtb_PhongMay(MaPhongMay, TenPhongMay, SoLuongMay, TrangThai, GhiChu)
VALUES (6, 'F7-6', 40, 0, NULL)
GO

-- Data May --
INSERT INTO dtb_May(MaMay, MaPhong, TenMay, TrangThai, GhiChu)
VALUES (1, 1, 'F7-1-1', 1, NULL)
GO

INSERT INTO dtb_May(MaMay, MaPhong, TenMay, TrangThai, GhiChu)
VALUES (2, 1, 'F7-1-2', 1, NULL)
GO

INSERT INTO dtb_May(MaMay, MaPhong, TenMay, TrangThai, GhiChu)
VALUES (3, 1, 'F7-1-3', 1, NULL)
GO

INSERT INTO dtb_May(MaMay, MaPhong, TenMay, TrangThai, GhiChu)
VALUES (4, 1, 'F7-1-4', 0, NULL)
GO

-- Loai Thiet Bi --
INSERT INTO dtb_LoaiThietBi(MaLoai, TenLoaiThietBi)
VALUES (1, N'Màn Hình')
GO

INSERT INTO dtb_LoaiThietBi(MaLoai, TenLoaiThietBi)
VALUES (2, N'Chuột')
GO

INSERT INTO dtb_LoaiThietBi(MaLoai, TenLoaiThietBi)
VALUES (3, N'Bàn Phím')
GO

INSERT INTO dtb_LoaiThietBi(MaLoai, TenLoaiThietBi)
VALUES (4, N'Thùng')
GO

INSERT INTO dtb_LoaiThietBi(MaLoai, TenLoaiThietBi)
VALUES (5, N'CPU')
GO

INSERT INTO dtb_LoaiThietBi(MaLoai, TenLoaiThietBi)
VALUES (6, N'Mainboard')
GO

INSERT INTO dtb_LoaiThietBi(MaLoai, TenLoaiThietBi)
VALUES (7, N'RAM')
GO

INSERT INTO dtb_LoaiThietBi(MaLoai, TenLoaiThietBi)
VALUES (8, N'Ổ Cứng')
GO

INSERT INTO dtb_LoaiThietBi(MaLoai, TenLoaiThietBi)
VALUES (9, N'VGA')
GO

INSERT INTO dtb_LoaiThietBi(MaLoai, TenLoaiThietBi)
VALUES (10, N'PSU')
GO

INSERT INTO dtb_LoaiThietBi(MaLoai, TenLoaiThietBi)
VALUES (11, N'Hệ Điều Hành')
GO

-- Thiet Bi --
INSERT INTO dtb_ChiTietThietBi(MaThietBi, TenThietBi, TSThietBi, SoLuong, MaLoai, NamSanXuat, NhaSanXuat, HanThanhLy, GhiChu)
VALUES (1, 'Core i3 8100', '', 0, 5, 2020, '', 5, '')
GO

INSERT INTO dtb_ChiTietThietBi(MaThietBi, TenThietBi, TSThietBi, SoLuong, MaLoai, NamSanXuat, NhaSanXuat, HanThanhLy, GhiChu)
VALUES (2, 'Core i3 4130', '', 0, 5, 2020, '', 5, '')
GO

INSERT INTO dtb_ChiTietThietBi(MaThietBi, TenThietBi, TSThietBi, SoLuong, MaLoai, NamSanXuat, NhaSanXuat, HanThanhLy, GhiChu)
VALUES (3, 'Core i3 7100', '', 0, 5, 2020, '', 5, '')
GO

INSERT INTO dtb_ChiTietThietBi(MaThietBi, TenThietBi, TSThietBi, SoLuong, MaLoai, NamSanXuat, NhaSanXuat, HanThanhLy, GhiChu)
VALUES (4, 'HDD 500GB', '', 0, 8, 2020, '', 5, '')
GO

INSERT INTO dtb_ChiTietThietBi(MaThietBi, TenThietBi, TSThietBi, SoLuong, MaLoai, NamSanXuat, NhaSanXuat, HanThanhLy, GhiChu)
VALUES (5, 'RAM 8GB', '', 0, 7, 2020, '', 5, '')
GO

INSERT INTO dtb_ChiTietThietBi(MaThietBi, TenThietBi, TSThietBi, SoLuong, MaLoai, NamSanXuat, NhaSanXuat, HanThanhLy, GhiChu)
VALUES (3, 'Core i3 3240', '', 0, 5, 2020, '', 5, '')
GO