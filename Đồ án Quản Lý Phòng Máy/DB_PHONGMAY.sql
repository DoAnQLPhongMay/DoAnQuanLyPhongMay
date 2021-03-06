USE [master]
GO
/****** Object:  Database [QLPHONGMAY]    Script Date: 08/20/2020 06:39:56 ******/
CREATE DATABASE [QLPHONGMAY] ON  PRIMARY 
( NAME = N'QLPHONGMAY', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\QLPHONGMAY.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLPHONGMAY_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\QLPHONGMAY_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
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
ALTER DATABASE [QLPHONGMAY] SET AUTO_CLOSE OFF
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
ALTER DATABASE [QLPHONGMAY] SET  DISABLE_BROKER
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
/****** Object:  Table [dbo].[dtb_CauHinh]    Script Date: 08/20/2020 06:39:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dtb_CauHinh](
	[MaCauHinh] [int] NOT NULL,
	[TenCauHinh] [nvarchar](50) NULL,
	[ManHinh] [int] NULL,
	[Chuot] [int] NULL,
	[BanPhim] [int] NULL,
	[Thung] [int] NULL,
	[CPU] [int] NULL,
	[MainBoard] [int] NULL,
	[RAM] [int] NULL,
	[OCung] [int] NULL,
	[VGA] [int] NULL,
	[PSU] [int] NULL,
	[HeDieuHanh] [int] NULL,
 CONSTRAINT [PK_dtb_CauHinh] PRIMARY KEY CLUSTERED 
(
	[MaCauHinh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dtb_TaiKhoan]    Script Date: 08/20/2020 06:39:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[dtb_TaiKhoan](
	[TenDangNhap] [varchar](20) NOT NULL,
	[MatKhau] [varchar](20) NULL,
	[MaTaiKhoan] [varchar](20) NULL,
	[HoVaTen] [nvarchar](50) NULL,
	[GioiTinh] [bit] NULL,
	[SDT] [nchar](10) NULL,
	[Email] [varchar](50) NULL,
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
/****** Object:  Table [dbo].[dtb_TrangThai]    Script Date: 08/20/2020 06:39:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dtb_TrangThai](
	[MaTrangThai] [int] NOT NULL,
	[TenTrangThai] [nvarchar](50) NULL,
 CONSTRAINT [PK_dtb_TrangThai] PRIMARY KEY CLUSTERED 
(
	[MaTrangThai] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dtb_LoaiThietBi]    Script Date: 08/20/2020 06:39:57 ******/
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
/****** Object:  Table [dbo].[dtb_LichSuThanhLy]    Script Date: 08/20/2020 06:39:57 ******/
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
	[MaCauHinh] [int] NULL,
	[NhaSanXuat] [nvarchar](50) NOT NULL,
	[NamSanxuat] [int] NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
	[NguoiPhuTrach] [varchar](20) NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_dtb_LichSuThanhLy] PRIMARY KEY CLUSTERED 
(
	[MaThanhLy] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[dtb_LichSuNhap]    Script Date: 08/20/2020 06:39:57 ******/
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
	[MaCauHinh] [int] NULL,
	[NhaCungCap] [nvarchar](50) NULL,
	[NhaSanXuat] [nvarchar](50) NULL,
	[NamSanXuat] [int] NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
	[NguoiPhuTrach] [varchar](20) NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_dtb_LichSuNhap] PRIMARY KEY CLUSTERED 
(
	[MaNhap] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[dtb_LichSuCapNhat]    Script Date: 08/20/2020 06:39:57 ******/
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
 CONSTRAINT [PK_dtb_LichSuCapNhat] PRIMARY KEY CLUSTERED 
(
	[MaCapNhat] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[dtb_Khoa]    Script Date: 08/20/2020 06:39:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dtb_Khoa](
	[MaKhoa] [int] NOT NULL,
	[TenKhoa] [nvarchar](50) NULL,
 CONSTRAINT [PK_dtb_Khoa] PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dtb_ChiTietCapNhat]    Script Date: 08/20/2020 06:39:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dtb_ChiTietCapNhat](
	[MaCapNhat] [int] NOT NULL,
	[TenMay] [nvarchar](50) NULL,
	[MaCauHinh] [int] NOT NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_dtb_ChiTietCapNhat] PRIMARY KEY CLUSTERED 
(
	[MaCapNhat] ASC,
	[MaCauHinh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dtb_ThietBi]    Script Date: 08/20/2020 06:39:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dtb_ThietBi](
	[MaThietBi] [int] NOT NULL,
	[TenThietBi] [nvarchar](100) NULL,
	[TSThietBi] [nvarchar](100) NULL,
	[SoLuong] [int] NULL,
	[MaLoai] [int] NULL,
	[NamSanXuat] [int] NULL,
	[NhaSanXuat] [nvarchar](50) NULL,
	[HanThanhLy] [int] NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_dtb_ThietBi] PRIMARY KEY CLUSTERED 
(
	[MaThietBi] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dtb_PhongMay]    Script Date: 08/20/2020 06:39:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dtb_PhongMay](
	[MaPhongMay] [int] NOT NULL,
	[TenPhongMay] [nvarchar](50) NULL,
	[SoLuongMay] [int] NULL,
	[TrangThai] [int] NULL,
	[Khoa] [int] NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_dtb_PhongMay] PRIMARY KEY CLUSTERED 
(
	[MaPhongMay] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dtb_May]    Script Date: 08/20/2020 06:39:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dtb_May](
	[MaMay] [int] NOT NULL,
	[MaPhong] [int] NULL,
	[TenMay] [nvarchar](50) NULL,
	[MaCauHinh] [int] NULL,
	[TrangThai] [int] NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_dtb_May] PRIMARY KEY CLUSTERED 
(
	[MaMay] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_dtb_ChiTietCapNhat_dtb_LichSuCapNhat]    Script Date: 08/20/2020 06:39:57 ******/
ALTER TABLE [dbo].[dtb_ChiTietCapNhat]  WITH CHECK ADD  CONSTRAINT [FK_dtb_ChiTietCapNhat_dtb_LichSuCapNhat] FOREIGN KEY([MaCapNhat])
REFERENCES [dbo].[dtb_LichSuCapNhat] ([MaCapNhat])
GO
ALTER TABLE [dbo].[dtb_ChiTietCapNhat] CHECK CONSTRAINT [FK_dtb_ChiTietCapNhat_dtb_LichSuCapNhat]
GO
/****** Object:  ForeignKey [FK_dtb_ThietBi_dtb_LoaiThietBi]    Script Date: 08/20/2020 06:39:57 ******/
ALTER TABLE [dbo].[dtb_ThietBi]  WITH CHECK ADD  CONSTRAINT [FK_dtb_ThietBi_dtb_LoaiThietBi] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[dtb_LoaiThietBi] ([MaLoai])
GO
ALTER TABLE [dbo].[dtb_ThietBi] CHECK CONSTRAINT [FK_dtb_ThietBi_dtb_LoaiThietBi]
GO
/****** Object:  ForeignKey [FK_dtb_PhongMay_dtb_Khoa]    Script Date: 08/20/2020 06:39:57 ******/
ALTER TABLE [dbo].[dtb_PhongMay]  WITH CHECK ADD  CONSTRAINT [FK_dtb_PhongMay_dtb_Khoa] FOREIGN KEY([Khoa])
REFERENCES [dbo].[dtb_Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[dtb_PhongMay] CHECK CONSTRAINT [FK_dtb_PhongMay_dtb_Khoa]
GO
/****** Object:  ForeignKey [FK_dtb_PhongMay_dtb_TrangThai]    Script Date: 08/20/2020 06:39:57 ******/
ALTER TABLE [dbo].[dtb_PhongMay]  WITH CHECK ADD  CONSTRAINT [FK_dtb_PhongMay_dtb_TrangThai] FOREIGN KEY([TrangThai])
REFERENCES [dbo].[dtb_TrangThai] ([MaTrangThai])
GO
ALTER TABLE [dbo].[dtb_PhongMay] CHECK CONSTRAINT [FK_dtb_PhongMay_dtb_TrangThai]
GO
/****** Object:  ForeignKey [FK_dtb_May_dtb_CauHinh]    Script Date: 08/20/2020 06:39:57 ******/
ALTER TABLE [dbo].[dtb_May]  WITH CHECK ADD  CONSTRAINT [FK_dtb_May_dtb_CauHinh] FOREIGN KEY([MaCauHinh])
REFERENCES [dbo].[dtb_CauHinh] ([MaCauHinh])
GO
ALTER TABLE [dbo].[dtb_May] CHECK CONSTRAINT [FK_dtb_May_dtb_CauHinh]
GO
/****** Object:  ForeignKey [FK_dtb_May_dtb_PhongMay]    Script Date: 08/20/2020 06:39:57 ******/
ALTER TABLE [dbo].[dtb_May]  WITH CHECK ADD  CONSTRAINT [FK_dtb_May_dtb_PhongMay] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[dtb_PhongMay] ([MaPhongMay])
GO
ALTER TABLE [dbo].[dtb_May] CHECK CONSTRAINT [FK_dtb_May_dtb_PhongMay]
GO
/****** Object:  ForeignKey [FK_dtb_May_dtb_TrangThai]    Script Date: 08/20/2020 06:39:57 ******/
ALTER TABLE [dbo].[dtb_May]  WITH CHECK ADD  CONSTRAINT [FK_dtb_May_dtb_TrangThai] FOREIGN KEY([TrangThai])
REFERENCES [dbo].[dtb_TrangThai] ([MaTrangThai])
GO
ALTER TABLE [dbo].[dtb_May] CHECK CONSTRAINT [FK_dtb_May_dtb_TrangThai]
GO
