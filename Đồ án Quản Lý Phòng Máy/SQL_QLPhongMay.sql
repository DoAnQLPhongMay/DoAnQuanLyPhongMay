USE [master]
GO
/****** Object:  Database [QLPHONGMAY]    Script Date: 07/01/2020 09:06:00 ******/
CREATE DATABASE [QLPHONGMAY]
GO
ALTER DATABASE [QLPHONGMAY] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLPHONGMAY].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLPHONGMAY] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [QLPHONGMAY] SET ANSI_NULLS OFF
GO
ALTER DATABASE [QLPHONGMAY] SET ANSI_PADDING OFF
GO
ALTER DATABASE [QLPHONGMAY] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [QLPHONGMAY] SET ARITHABORT OFF
GO
ALTER DATABASE [QLPHONGMAY] SET AUTO_CLOSE ON
GO
ALTER DATABASE [QLPHONGMAY] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [QLPHONGMAY] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [QLPHONGMAY] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [QLPHONGMAY] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [QLPHONGMAY] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [QLPHONGMAY] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [QLPHONGMAY] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [QLPHONGMAY] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [QLPHONGMAY] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [QLPHONGMAY] SET  ENABLE_BROKER
GO
ALTER DATABASE [QLPHONGMAY] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [QLPHONGMAY] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [QLPHONGMAY] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [QLPHONGMAY] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [QLPHONGMAY] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [QLPHONGMAY] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [QLPHONGMAY] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [QLPHONGMAY] SET  READ_WRITE
GO
ALTER DATABASE [QLPHONGMAY] SET RECOVERY SIMPLE
GO
ALTER DATABASE [QLPHONGMAY] SET  MULTI_USER
GO
ALTER DATABASE [QLPHONGMAY] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [QLPHONGMAY] SET DB_CHAINING OFF
GO
USE [QLPHONGMAY]
GO
/****** Object:  Table [dbo].[dtb_LoaiThietBi]    Script Date: 07/01/2020 09:06:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dtb_LoaiThietBi](
	[MaLoai] [int] NOT NULL,
	[TenLoaiThietBi] [nvarchar](50) NULL,
 CONSTRAINT [PK_dtb_LoaiThietBi] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dtb_TaiKhoan]    Script Date: 07/01/2020 09:06:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[dtb_TaiKhoan](
	[TenDangNhap] [varchar](20) NOT NULL,
	[MatKhau] [varchar](20) NOT NULL,
	[MaGiangVien] [varchar](20) NOT NULL,
	[HoVaTen] [nvarchar](50) NOT NULL,
	[GioiTinh] [int] NULL,
	[SDT] [nchar](10) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](100) NULL,
	[LoaiTK] [int] NULL,
 CONSTRAINT [PK_dtb_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[dtb_PhongMay]    Script Date: 07/01/2020 09:06:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dtb_PhongMay](
	[MaPhongMay] [int] NOT NULL,
	[TenPhongMay] [nvarchar](50) NULL,
	[SoLuongMay] [int] NULL,
 CONSTRAINT [PK_dtb_PhongMay] PRIMARY KEY CLUSTERED 
(
	[MaPhongMay] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dtb_May]    Script Date: 07/01/2020 09:06:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dtb_May](
	[MaMay] [int] NOT NULL,
	[MaPhong] [int] NULL,
	[TenMay] [nvarchar](50) NULL,
	[TrangThai] [int] NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_dtb_May] PRIMARY KEY CLUSTERED 
(
	[MaMay] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dtb_ChiTietThietBi]    Script Date: 07/01/2020 09:06:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dtb_ChiTietThietBi](
	[MaThietBi] [int] NOT NULL,
	[TenThietBi] [nvarchar](50) NULL,
	[TSThietBi] [nvarchar](100) NULL,
	[SoLuong] [int] NULL,
	[MaLoai] [int] NULL,
	[NamSanXuat] [date] NULL,
	[NhaSanXuat] [nvarchar](50) NULL,
	[HanThanhLy] [date] NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_dtb_ChiTietThietBi] PRIMARY KEY CLUSTERED 
(
	[MaThietBi] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dtb_LichSuThanhLy]    Script Date: 07/01/2020 09:06:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[dtb_LichSuThanhLy](
	[MaThanhLy] [int] NOT NULL,
	[NgayThanhLy] [date] NULL,
	[MaThietBi] [int] NULL,
	[NhaSanXuat] [nvarchar](50) NULL,
	[NamSanxuat] [date] NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
	[NguoiPhuTrach] [varchar](20) NULL,
	[TrangThai] [int] NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_dtb_LichSuThanhLy] PRIMARY KEY CLUSTERED 
(
	[MaThanhLy] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[dtb_LichSuNhap]    Script Date: 07/01/2020 09:06:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[dtb_LichSuNhap](
	[MaNhap] [int] NOT NULL,
	[NgayNhap] [date] NULL,
	[MaThietBi] [int] NULL,
	[NhaSanXuat] [nvarchar](50) NULL,
	[NamSanXuat] [date] NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
	[NhaCungCap] [nvarchar](50) NULL,
	[NguoiPhuTrach] [varchar](20) NULL,
	[TrangThai] [int] NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_dtb_LichSuNhap] PRIMARY KEY CLUSTERED 
(
	[MaNhap] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[dtb_LichSuCapNhat]    Script Date: 07/01/2020 09:06:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[dtb_LichSuCapNhat](
	[MaCapNhat] [int] NOT NULL,
	[MaPhongMay] [int] NULL,
	[MaMay] [int] NULL,
	[TenDangNhap] [varchar](20) NULL,
	[NgayCapNhat] [date] NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_dtb_LichSuCapNhat_1] PRIMARY KEY CLUSTERED 
(
	[MaCapNhat] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[dtb_ChiTietMay]    Script Date: 07/01/2020 09:06:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dtb_ChiTietMay](
	[MaMay] [int] NOT NULL,
	[MaLoaiThietBi] [int] NOT NULL,
	[MaThietBi] [int] NOT NULL,
 CONSTRAINT [PK_dtb_ChiTietMay_1] PRIMARY KEY CLUSTERED 
(
	[MaMay] ASC,
	[MaLoaiThietBi] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dtb_ChiTietCapNhat]    Script Date: 07/01/2020 09:06:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dtb_ChiTietCapNhat](
	[MaCapNhat] [int] NOT NULL,
	[MaThietBi] [int] NOT NULL,
 CONSTRAINT [PK_dtb_ChiTietCapNhat_1] PRIMARY KEY CLUSTERED 
(
	[MaCapNhat] ASC,
	[MaThietBi] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_dtb_May_dtb_PhongMay]    Script Date: 07/01/2020 09:06:01 ******/
ALTER TABLE [dbo].[dtb_May]  WITH CHECK ADD  CONSTRAINT [FK_dtb_May_dtb_PhongMay] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[dtb_PhongMay] ([MaPhongMay])
GO
ALTER TABLE [dbo].[dtb_May] CHECK CONSTRAINT [FK_dtb_May_dtb_PhongMay]
GO
/****** Object:  ForeignKey [FK_dtb_ChiTietThietBi_dtb_LoaiThietBi]    Script Date: 07/01/2020 09:06:01 ******/
ALTER TABLE [dbo].[dtb_ChiTietThietBi]  WITH CHECK ADD  CONSTRAINT [FK_dtb_ChiTietThietBi_dtb_LoaiThietBi] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[dtb_LoaiThietBi] ([MaLoai])
GO
ALTER TABLE [dbo].[dtb_ChiTietThietBi] CHECK CONSTRAINT [FK_dtb_ChiTietThietBi_dtb_LoaiThietBi]
GO
/****** Object:  ForeignKey [FK_dtb_LichSuThanhLy_dtb_ChiTietThietBi]    Script Date: 07/01/2020 09:06:01 ******/
ALTER TABLE [dbo].[dtb_LichSuThanhLy]  WITH CHECK ADD  CONSTRAINT [FK_dtb_LichSuThanhLy_dtb_ChiTietThietBi] FOREIGN KEY([MaThietBi])
REFERENCES [dbo].[dtb_ChiTietThietBi] ([MaThietBi])
GO
ALTER TABLE [dbo].[dtb_LichSuThanhLy] CHECK CONSTRAINT [FK_dtb_LichSuThanhLy_dtb_ChiTietThietBi]
GO
/****** Object:  ForeignKey [FK_dtb_LichSuThanhLy_dtb_TaiKhoan]    Script Date: 07/01/2020 09:06:01 ******/
ALTER TABLE [dbo].[dtb_LichSuThanhLy]  WITH CHECK ADD  CONSTRAINT [FK_dtb_LichSuThanhLy_dtb_TaiKhoan] FOREIGN KEY([NguoiPhuTrach])
REFERENCES [dbo].[dtb_TaiKhoan] ([TenDangNhap])
GO
ALTER TABLE [dbo].[dtb_LichSuThanhLy] CHECK CONSTRAINT [FK_dtb_LichSuThanhLy_dtb_TaiKhoan]
GO
/****** Object:  ForeignKey [FK_dtb_LichSuNhap_dtb_ChiTietThietBi]    Script Date: 07/01/2020 09:06:01 ******/
ALTER TABLE [dbo].[dtb_LichSuNhap]  WITH CHECK ADD  CONSTRAINT [FK_dtb_LichSuNhap_dtb_ChiTietThietBi] FOREIGN KEY([MaThietBi])
REFERENCES [dbo].[dtb_ChiTietThietBi] ([MaThietBi])
GO
ALTER TABLE [dbo].[dtb_LichSuNhap] CHECK CONSTRAINT [FK_dtb_LichSuNhap_dtb_ChiTietThietBi]
GO
/****** Object:  ForeignKey [FK_dtb_LichSuNhap_dtb_TaiKhoan]    Script Date: 07/01/2020 09:06:01 ******/
ALTER TABLE [dbo].[dtb_LichSuNhap]  WITH CHECK ADD  CONSTRAINT [FK_dtb_LichSuNhap_dtb_TaiKhoan] FOREIGN KEY([NguoiPhuTrach])
REFERENCES [dbo].[dtb_TaiKhoan] ([TenDangNhap])
GO
ALTER TABLE [dbo].[dtb_LichSuNhap] CHECK CONSTRAINT [FK_dtb_LichSuNhap_dtb_TaiKhoan]
GO
/****** Object:  ForeignKey [FK_dtb_LichSuCapNhat_dtb_May]    Script Date: 07/01/2020 09:06:01 ******/
ALTER TABLE [dbo].[dtb_LichSuCapNhat]  WITH CHECK ADD  CONSTRAINT [FK_dtb_LichSuCapNhat_dtb_May] FOREIGN KEY([MaMay])
REFERENCES [dbo].[dtb_May] ([MaMay])
GO
ALTER TABLE [dbo].[dtb_LichSuCapNhat] CHECK CONSTRAINT [FK_dtb_LichSuCapNhat_dtb_May]
GO
/****** Object:  ForeignKey [FK_dtb_LichSuCapNhat_dtb_PhongMay]    Script Date: 07/01/2020 09:06:01 ******/
ALTER TABLE [dbo].[dtb_LichSuCapNhat]  WITH CHECK ADD  CONSTRAINT [FK_dtb_LichSuCapNhat_dtb_PhongMay] FOREIGN KEY([MaPhongMay])
REFERENCES [dbo].[dtb_PhongMay] ([MaPhongMay])
GO
ALTER TABLE [dbo].[dtb_LichSuCapNhat] CHECK CONSTRAINT [FK_dtb_LichSuCapNhat_dtb_PhongMay]
GO
/****** Object:  ForeignKey [FK_dtb_LichSuCapNhat_dtb_TaiKhoan]    Script Date: 07/01/2020 09:06:01 ******/
ALTER TABLE [dbo].[dtb_LichSuCapNhat]  WITH CHECK ADD  CONSTRAINT [FK_dtb_LichSuCapNhat_dtb_TaiKhoan] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[dtb_TaiKhoan] ([TenDangNhap])
GO
ALTER TABLE [dbo].[dtb_LichSuCapNhat] CHECK CONSTRAINT [FK_dtb_LichSuCapNhat_dtb_TaiKhoan]
GO
/****** Object:  ForeignKey [FK_dtb_ChiTietMay_dtb_LoaiThietBi]    Script Date: 07/01/2020 09:06:01 ******/
ALTER TABLE [dbo].[dtb_ChiTietMay]  WITH CHECK ADD  CONSTRAINT [FK_dtb_ChiTietMay_dtb_LoaiThietBi] FOREIGN KEY([MaLoaiThietBi])
REFERENCES [dbo].[dtb_LoaiThietBi] ([MaLoai])
GO
ALTER TABLE [dbo].[dtb_ChiTietMay] CHECK CONSTRAINT [FK_dtb_ChiTietMay_dtb_LoaiThietBi]
GO
/****** Object:  ForeignKey [FK_dtb_ChiTietMay_dtb_May]    Script Date: 07/01/2020 09:06:01 ******/
ALTER TABLE [dbo].[dtb_ChiTietMay]  WITH CHECK ADD  CONSTRAINT [FK_dtb_ChiTietMay_dtb_May] FOREIGN KEY([MaMay])
REFERENCES [dbo].[dtb_May] ([MaMay])
GO
ALTER TABLE [dbo].[dtb_ChiTietMay] CHECK CONSTRAINT [FK_dtb_ChiTietMay_dtb_May]
GO
/****** Object:  ForeignKey [FK_dtb_ChiTietCapNhat_dtb_ChiTietThietBi]    Script Date: 07/01/2020 09:06:01 ******/
ALTER TABLE [dbo].[dtb_ChiTietCapNhat]  WITH CHECK ADD  CONSTRAINT [FK_dtb_ChiTietCapNhat_dtb_ChiTietThietBi] FOREIGN KEY([MaThietBi])
REFERENCES [dbo].[dtb_ChiTietThietBi] ([MaThietBi])
GO
ALTER TABLE [dbo].[dtb_ChiTietCapNhat] CHECK CONSTRAINT [FK_dtb_ChiTietCapNhat_dtb_ChiTietThietBi]
GO
/****** Object:  ForeignKey [FK_dtb_ChiTietCapNhat_dtb_LichSuCapNhat]    Script Date: 07/01/2020 09:06:01 ******/
ALTER TABLE [dbo].[dtb_ChiTietCapNhat]  WITH CHECK ADD  CONSTRAINT [FK_dtb_ChiTietCapNhat_dtb_LichSuCapNhat] FOREIGN KEY([MaCapNhat])
REFERENCES [dbo].[dtb_LichSuCapNhat] ([MaCapNhat])
GO
ALTER TABLE [dbo].[dtb_ChiTietCapNhat] CHECK CONSTRAINT [FK_dtb_ChiTietCapNhat_dtb_LichSuCapNhat]
GO
