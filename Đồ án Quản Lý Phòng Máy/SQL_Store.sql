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
	SELECT dtb_LichSuCapNhat.MaCapNhat, MaPhongMay, MaMay, MaThietBi, TenDangNhap, NgayCapNhat, GhiChu
	FROM dtb_LichSuCapNhat, dtb_ChiTietCapNhat
	WHERE dtb_LichSuCapNhat.MaCapNhat = dtb_ChiTietCapNhat.MaCapNhat
	GO

-- THÊM MỚI --
	-- Thêm mới tài khoản --
	INSERT INTO dtb_TaiKhoan(TenDangNhap, MatKhau, MaGiangVien, HoVaTen, LoaiTK)
	VALUES ('vominhkhoi', 'abc123', '0306171150', 'Võ Minh Khôi', 1)
	GO
	
	-- Thêm mới phòng máy --
	GO
	
	-- Thêm mới máy --
	GO
	
	-- Thêm mới thiết bị --
	GO
	
	-- Thêm mới loại thiết bị --
	GO
	
	-- Thêm mới chi tiết máy --
	GO
	
	-- Thêm mới lịch sử cập nhật --
	GO
	
	-- Thêm mới chi tiết cập nhật --
	GO
	
	-- Thêm mới lịch sử nhập --
	GO
	
	-- Thêm mới lịch sử thanh lý --
	GO
	
	
-- CẬP NHẬT --
	-- Cập nhật thông tin tài khoản --
	UPDATE dtb_TaiKhoan
	SET GioiTinh = 1, SDT = '0123456789', NgaySinh = '02-02-2020', DiaChi = 'HCM', LoaiTK = 1
	WHERE TenDangNhap = 'vominhkhoi'
	
	-- Cập nhật phòng máy --
	GO
	
	-- Cập nhật máy --
	GO
	
	-- Cập nhật chi tiết máy --
	GO
	
	-- Cập nhật loại thiết bị --
	GO
	
	-- Cập nhật chi tiết thiết bị --
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
	WHERE MaLoaiThietBi = 1
	GO
	
	-- Xóa chi tiết thiết bị --
	DELETE FROM dtb_ChiTietThietBi 
	WHERE MaThietBi = 1
	GO
	