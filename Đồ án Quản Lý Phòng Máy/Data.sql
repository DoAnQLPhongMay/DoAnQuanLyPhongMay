-- Data TaiKhoan --
INSERT INTO dtb_TaiKhoan(TenDangNhap, MatKhau, MaTaiKhoan, HoVaTen, GioiTinh, SDT, Email, NgaySinh, DiaChi, LoaiTK)
VALUES ('vominhkhoi', '123', '0306171150', N'Võ Minh Khôi',1, '0123456789', 'khoi@gmail.com', '9/29/1999', NULL, 1)
GO

INSERT INTO dtb_TaiKhoan(TenDangNhap, MatKhau, MaTaiKhoan, HoVaTen, GioiTinh, SDT, Email, NgaySinh, DiaChi, LoaiTK)
VALUES ('tranquangthien', '123', '0306171201', N'Trần Quang Thiện',1, '0123456789', 'thien@gmail.com', '1/1/1999', NULL, 1)
GO

INSERT INTO dtb_TaiKhoan(TenDangNhap, MatKhau, MaTaiKhoan, HoVaTen, GioiTinh, SDT, Email, NgaySinh, DiaChi, LoaiTK)
VALUES ('nguyenducchuan', '123', NULL, N'Nguyễn Đức Chuẩn',1, '0123456789', 'chuan@gmail.com', '1/1/1990', NULL, 1)
GO

INSERT INTO dtb_TaiKhoan(TenDangNhap, MatKhau, MaTaiKhoan, HoVaTen, GioiTinh, SDT, Email, NgaySinh, DiaChi, LoaiTK)
VALUES ('vmkhoi', '123', '0306171150', N'Võ Minh Khôi',1, '0123456789', 'khoi@gmail.com', '9/29/1999', NULL, 0)
GO

INSERT INTO dtb_TaiKhoan(TenDangNhap, MatKhau, MaTaiKhoan, HoVaTen, GioiTinh, SDT, Email, NgaySinh, DiaChi, LoaiTK)
VALUES ('tqthien', '123', '0306171201', N'Trần Quang Thiện',1, '0123456789', 'thien@gmail.com', '1/1/1999', NULL, 0)
GO

INSERT INTO dtb_TaiKhoan(TenDangNhap, MatKhau, MaTaiKhoan, HoVaTen, GioiTinh, SDT, Email, NgaySinh, DiaChi, LoaiTK)
VALUES ('ndchuan', '123', NULL, N'Nguyễn Đức Chuẩn',1, '0123456789', 'chuan@gmail.com', '1/1/1990', NULL, 0)
GO

-- Data TrangThai --
INSERT INTO dtb_TrangThai(MaTrangThai, TenTrangThai)
VALUES (0, N'Bảo Trì')
GO

INSERT INTO dtb_TrangThai(MaTrangThai, TenTrangThai)
VALUES (1, N'Bình Thường')
GO

INSERT INTO dtb_TrangThai(MaTrangThai, TenTrangThai)
VALUES (2, N'Bị Lỗi')
GO

-- Khoa --
INSERT INTO dtb_Khoa(MaKhoa, TenKhoa)
VALUES (1, N'CNTT')
GO

INSERT INTO dtb_Khoa(MaKhoa, TenKhoa)
VALUES (2, N'Điện - Điện Tử')
GO

-- Data PhongMay --
INSERT INTO dtb_PhongMay(MaPhongMay, TenPhongMay, SoLuongMay,Khoa, TrangThai, GhiChu)
VALUES (1, 'F7-1', 50, 1, 1, NULL)
GO

INSERT INTO dtb_PhongMay(MaPhongMay, TenPhongMay, SoLuongMay, Khoa, TrangThai, GhiChu)
VALUES (2, 'F7-2', 50, 1, 1, NULL)
GO

INSERT INTO dtb_PhongMay(MaPhongMay, TenPhongMay, SoLuongMay, Khoa, TrangThai, GhiChu)
VALUES (3, 'F7-3', 50, 1, 1, NULL)
GO

INSERT INTO dtb_PhongMay(MaPhongMay, TenPhongMay, SoLuongMay, Khoa, TrangThai, GhiChu)
VALUES (4, 'F7-4', 40, 1, 0, NULL)
GO

INSERT INTO dtb_PhongMay(MaPhongMay, TenPhongMay, SoLuongMay, Khoa, TrangThai, GhiChu)
VALUES (5, 'F7-5', 40, 1, 1, NULL)
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
INSERT INTO dtb_ThietBi(MaThietBi, TenThietBi, TSThietBi, SoLuong, MaLoai, NamSanXuat, NhaSanXuat, HanThanhLy, GhiChu)
VALUES (1, N'LCD LG 22MN430M-B.ATV', '', 0, 1, 2020, '', 5, '')
GO

INSERT INTO dtb_ThietBi(MaThietBi, TenThietBi, TSThietBi, SoLuong, MaLoai, NamSanXuat, NhaSanXuat, HanThanhLy, GhiChu)
VALUES (2, N'Chuột Logitech MK200', '', 0, 2, 2020, '', 5, '')
GO

INSERT INTO dtb_ThietBi(MaThietBi, TenThietBi, TSThietBi, SoLuong, MaLoai, NamSanXuat, NhaSanXuat, HanThanhLy, GhiChu)
VALUES (3, N'Bàn Phim Logitech MK200', '', 0, 3, 2020, '', 5, '')
GO

INSERT INTO dtb_ThietBi(MaThietBi, TenThietBi, TSThietBi, SoLuong, MaLoai, NamSanXuat, NhaSanXuat, HanThanhLy, GhiChu)
VALUES (4, N'Xigmatek NYX 3F RGB', '', 0, 4, 2020, '', 5, '')
GO

INSERT INTO dtb_ThietBi(MaThietBi, TenThietBi, TSThietBi, SoLuong, MaLoai, NamSanXuat, NhaSanXuat, HanThanhLy, GhiChu)
VALUES (5, N'Intel Pentium G6400', '', 0, 5, 2020, '', 5, '')
GO

INSERT INTO dtb_ThietBi(MaThietBi, TenThietBi, TSThietBi, SoLuong, MaLoai, NamSanXuat, NhaSanXuat, HanThanhLy, GhiChu)
VALUES (6, N'MSI H410M A-PRO', '', 0, 6, 2020, '', 5, '')
GO

INSERT INTO dtb_ThietBi(MaThietBi, TenThietBi, TSThietBi, SoLuong, MaLoai, NamSanXuat, NhaSanXuat, HanThanhLy, GhiChu)
VALUES (7, N'Kingston HyperX Fury Black', '', 0, 7, 2020, '', 5, '')
GO

INSERT INTO dtb_ThietBi(MaThietBi, TenThietBi, TSThietBi, SoLuong, MaLoai, NamSanXuat, NhaSanXuat, HanThanhLy, GhiChu)
VALUES (8, N'PNY SSD CS900 120G', '', 0, 8, 2020, '', 5, '')
GO

INSERT INTO dtb_ThietBi(MaThietBi, TenThietBi, TSThietBi, SoLuong, MaLoai, NamSanXuat, NhaSanXuat, HanThanhLy, GhiChu)
VALUES (9, N'MSI GTX 1650 Ventus XS', '', 0, 9, 2020, '', 5, '')
GO

INSERT INTO dtb_ThietBi(MaThietBi, TenThietBi, TSThietBi, SoLuong, MaLoai, NamSanXuat, NhaSanXuat, HanThanhLy, GhiChu)
VALUES (10, N'Deepcool DN450 80 Plus', '', 0, 10, 2020, '', 5, '')
GO

INSERT INTO dtb_ThietBi(MaThietBi, TenThietBi, TSThietBi, SoLuong, MaLoai, NamSanXuat, NhaSanXuat, HanThanhLy, GhiChu)
VALUES (11, N'Window 7 PRO', '', 0, 11, 2020, '', 5, '')
GO

-- Cau Hinh --
INSERT INTO dtb_CauHinh(MaCauHinh, TenCauHinh, ManHinh, Chuot, BanPhim, Thung, CPU, MainBoard, RAM, OCung, VGA, PSU, HeDieuHanh)
VALUES (1, N'Titan 10M', 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11)
GO

-- Data May --
INSERT INTO dtb_May(MaMay, TenMay, MaPhong, MaCauHinh, TrangThai, GhiChu)
VALUES (1, N'F7-1-1', 1, 1, 1, NULL)
GO

INSERT INTO dtb_May(MaMay, TenMay, MaPhong, MaCauHinh, TrangThai, GhiChu)
VALUES (2, N'F7-1-2', 1, 1, 1, NULL)
GO

INSERT INTO dtb_May(MaMay, TenMay, MaPhong, MaCauHinh, TrangThai, GhiChu)
VALUES (3, N'F7-1-3', 1, 1, 1, NULL)
GO

INSERT INTO dtb_May(MaMay, TenMay, MaPhong, MaCauHinh, TrangThai, GhiChu)
VALUES (4, N'F7-1-4', 1, 1, 1, NULL)
GO