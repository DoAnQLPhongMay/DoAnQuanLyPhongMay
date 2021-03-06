-- LẤY DANH SÁCH --
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
	
	-- Danh sách lịch sử cập nhật --
	SELECT * 
	FROM dtb_LichSuCapNhat
	GO
	
-- LẤY THÔNG TIN CHI TIẾT --
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
	
	-- Thông tin chi tiết cập nhật --
	SELECT dtb_LichSuCapNhat.MaCapNhat, MaPhongMay, MaMay, MaThietBi, TenDangNhap, NgayCapNhat, dtb_ChiTietCapNhat.GhiChu
	FROM dtb_LichSuCapNhat, dtb_ChiTietCapNhat
	WHERE dtb_LichSuCapNhat.MaCapNhat = dtb_ChiTietCapNhat.MaCapNhat
	GO

-- THÊM MỚI --
	-- Thêm mới tài khoản --
	INSERT INTO dtb_TaiKhoan(TenDangNhap, MatKhau, MaGiangVien, HoVaTen, LoaiTK)
	VALUES ('vominhkhoi', 'abc123', '0306171150', 'Võ Minh Khôi', 1)
	GO
	
	-- Thêm mới phòng máy --
	INSERT INTO dtb_PhongMay(MaPhongMay, TenPhongMay, SoLuongMay)
	VALUES (10, 'F7.10', 40)
	GO
	
	-- Thêm mới máy --
	INSERT INTO dtb_May(MaMay, MaPhong, TenMay, TrangThai, GhiChu)
	VALUES (20, 10, 'F7.10-1', 1, '')
	GO
	
	-- Thêm mới thiết bị --
	INSERT INTO dtb_ChiTietThietBi(MaThietBi, TenThietBi, TSThietBi, SoLuong, MaLoai, NamSanXuat, NhaSanXuat, HanThanhLy, GhiChu)
	VALUES (45, 'Màn Hình Dell', '', 45, 1, '02-05-2020', 'Dell', '02-05-2030', '')
	GO
	
	-- Thêm mới loại thiết bị --
	INSERT INTO dtb_LoaiThietBi(MaLoai, TenLoaiThietBi)
	VALUES (12, 'Hệ Điều Hành')
	GO
	
	-- Thêm mới chi tiết máy --
	INSERT INTO dtb_ChiTietMay(MaMay, MaLoaiThietBi, MaThietBi)
	VALUES (1, 1, 45)
	GO
	
	-- Thêm mới lịch sử cập nhật --
	INSERT INTO dtb_LichSuCapNhat(MaCapNhat, MaPhongMay, MaMay, TenDangNhap, NgayCapNhat, GhiChu)
	VALUES (1, 1, 5, 'vmkhoi', '01-07-2020', '')
	GO
	
	-- Thêm mới chi tiết cập nhật --
	INSERT INTO dtb_ChiTietCapNhat(MaCapNhat, MaLoaiThietBi, MaThietBi, GhiChu)
	VALUES (1, 1, 45, '')
	GO
	
	-- Thêm mới lịch sử nhập --
	INSERT INTO dtb_LichSuNhap(MaNhap, NgayNhap, MaThietBi, NhaSanXuat, NamSanXuat, SoLuong, DonGia, NhaCungCap, NguoiPhuTrach, TrangThai, GhiChu)
	VALUES (21, '01-07-2020', 45, 'Dell', '02-05-2020', 45, 300000, 'PhongVu', 'vmkhoi', 1, '')
	GO
	
	-- Thêm mới lịch sử thanh lý --
	INSERT INTO dtb_LichSuThanhLy(MaThanhLy, NgayThanhLy, MaThietBi, NhaSanXuat, NamSanXuat, SoLuong, DonGia, NguoiPhuTrach, TrangThai, GhiChu)
	VALUES (11, '01-07-2020', 45, 'Dell', '02-05-2020', 45, 300000,'vmkhoi', 1, '')
	GO
	
	
-- CẬP NHẬT --
	-- Cập nhật thông tin tài khoản --
	UPDATE dtb_TaiKhoan
	SET GioiTinh = 1, SDT = '0123456789', NgaySinh = '02-02-2020', DiaChi = 'HCM', LoaiTK = 1
	WHERE TenDangNhap = 'vominhkhoi'
	GO
	
	-- Cập nhật phòng máy --
	UPDATE dtb_PhongMay
	SET TenPhongMay = 'F7.1', SoLuongMay = 45
	WHERE MaPhongMay = 1
	GO
	
	-- Cập nhật máy --
	UPDATE dtb_May
	SET TenMay = 'F7.1-1', MaPhong = 1, GhiChu = '', TrangThai = 1
	WHERE MaMay = 1
	GO
	
	-- Cập nhật chi tiết máy --
	UPDATE dtb_ChiTietMay
	SET MaThietBi = 4
	WHERE MaMay = 1 AND MaLoaiThietBi = 1
	GO
	
	-- Cập nhật loại thiết bị --
	UPDATE dtb_LoaiThietBi
	SET TenLoaiThietBi = 'Màn Hình'
	WHERE MaLoai = 1
	GO
	
	-- Cập nhật chi tiết thiết bị --
	UPDATE dtb_ChiTietThietBi
	SET TenThietBi = 'Màn Hình Dell X50', TSThietBi = '', SoLuong = 45, MaLoai = 1, NamSanXuat = '02-05-2020', NhaSanXuat = 'Dell', HanThanhLy = '02-02-2030', GhiChu = ''
	WHERE MaThietBi = 1
	GO
	
	
-- XÓA --
	-- Xóa thông tin tài khoản --
	DELETE FROM dtb_TaiKhoan 
	WHERE TenDangNhap = 'vominhkhoi'
	GO
	
	-- Xóa phòng máy --
	DELETE FROM dtb_PhongMay 
	WHERE MaPhongMay = 1
	GO
	
	-- Xóa máy --
	DELETE FROM dtb_May 
	WHERE MaMay = 1
	GO
	
	-- Xóa chi tiết máy --
	DELETE FROM dtb_ChiTietMay 
	WHERE MaMay = 1 AND MaLoaiThietBi = 1
	GO
	
	-- Xóa loại thiết bị --
	DELETE FROM dtb_LoaiThietBi 
	WHERE MaLoai = 1
	GO
	
	-- Xóa chi tiết thiết bị --
	DELETE FROM dtb_ChiTietThietBi 
	WHERE MaThietBi = 1
	GO
	