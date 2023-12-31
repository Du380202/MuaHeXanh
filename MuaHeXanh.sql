USE [master]
GO
/****** Object:  Database [MuaHeXanh]    Script Date: 2023-07-11 5:26:53 CH ******/
CREATE DATABASE [MuaHeXanh]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MuaHeXanh', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\MuaHeXanh.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MuaHeXanh_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\MuaHeXanh_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [MuaHeXanh] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MuaHeXanh].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MuaHeXanh] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MuaHeXanh] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MuaHeXanh] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MuaHeXanh] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MuaHeXanh] SET ARITHABORT OFF 
GO
ALTER DATABASE [MuaHeXanh] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MuaHeXanh] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MuaHeXanh] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MuaHeXanh] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MuaHeXanh] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MuaHeXanh] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MuaHeXanh] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MuaHeXanh] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MuaHeXanh] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MuaHeXanh] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MuaHeXanh] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MuaHeXanh] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MuaHeXanh] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MuaHeXanh] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MuaHeXanh] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MuaHeXanh] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MuaHeXanh] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MuaHeXanh] SET RECOVERY FULL 
GO
ALTER DATABASE [MuaHeXanh] SET  MULTI_USER 
GO
ALTER DATABASE [MuaHeXanh] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MuaHeXanh] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MuaHeXanh] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MuaHeXanh] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MuaHeXanh] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MuaHeXanh] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'MuaHeXanh', N'ON'
GO
ALTER DATABASE [MuaHeXanh] SET QUERY_STORE = ON
GO
ALTER DATABASE [MuaHeXanh] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [MuaHeXanh]
GO
/****** Object:  User [N20DCCN096]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE USER [N20DCCN096] FOR LOGIN [DVH] WITH DEFAULT_SCHEMA=[N20DCCN096]
GO
/****** Object:  User [N20DCCN015]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE USER [N20DCCN015] FOR LOGIN [vtd] WITH DEFAULT_SCHEMA=[N20DCCN015]
GO
/****** Object:  User [N20DCCN014]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE USER [N20DCCN014] FOR LOGIN [htd] WITH DEFAULT_SCHEMA=[N20DCCN014]
GO
/****** Object:  User [N20DCCN008]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE USER [N20DCCN008] FOR LOGIN [THC] WITH DEFAULT_SCHEMA=[N20DCCN008]
GO
/****** Object:  User [N20DCCN001]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE USER [N20DCCN001] FOR LOGIN [VHM] WITH DEFAULT_SCHEMA=[N20DCCN001]
GO
/****** Object:  User [GV10]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE USER [GV10] FOR LOGIN [htt] WITH DEFAULT_SCHEMA=[GV10]
GO
/****** Object:  User [GV05]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE USER [GV05] FOR LOGIN [ttt] WITH DEFAULT_SCHEMA=[GV05]
GO
/****** Object:  User [GV04]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE USER [GV04] FOR LOGIN [NTTH] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [GV03]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE USER [GV03] FOR LOGIN [NTH] WITH DEFAULT_SCHEMA=[GV03]
GO
/****** Object:  User [GV02]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE USER [GV02] FOR LOGIN [BN] WITH DEFAULT_SCHEMA=[GV02]
GO
/****** Object:  User [GV01]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE USER [GV01] FOR LOGIN [KT] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [SINHVIEN]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE ROLE [SINHVIEN]
GO
/****** Object:  DatabaseRole [QUANTRI]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE ROLE [QUANTRI]
GO
/****** Object:  DatabaseRole [KHOA]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE ROLE [KHOA]
GO
/****** Object:  DatabaseRole [GIAMSAT]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE ROLE [GIAMSAT]
GO
ALTER ROLE [SINHVIEN] ADD MEMBER [N20DCCN096]
GO
ALTER ROLE [GIAMSAT] ADD MEMBER [N20DCCN015]
GO
ALTER ROLE [GIAMSAT] ADD MEMBER [N20DCCN014]
GO
ALTER ROLE [SINHVIEN] ADD MEMBER [N20DCCN008]
GO
ALTER ROLE [SINHVIEN] ADD MEMBER [N20DCCN001]
GO
ALTER ROLE [GIAMSAT] ADD MEMBER [GV10]
GO
ALTER ROLE [GIAMSAT] ADD MEMBER [GV05]
GO
ALTER ROLE [KHOA] ADD MEMBER [GV04]
GO
ALTER ROLE [db_owner] ADD MEMBER [GV04]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [GV04]
GO
ALTER ROLE [GIAMSAT] ADD MEMBER [GV03]
GO
ALTER ROLE [GIAMSAT] ADD MEMBER [GV02]
GO
ALTER ROLE [QUANTRI] ADD MEMBER [GV01]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [GV01]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [GV01]
GO
ALTER ROLE [db_datareader] ADD MEMBER [GV01]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [QUANTRI]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [QUANTRI]
GO
ALTER ROLE [db_datareader] ADD MEMBER [QUANTRI]
GO
ALTER ROLE [db_owner] ADD MEMBER [KHOA]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [KHOA]
GO
/****** Object:  Schema [GV02]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE SCHEMA [GV02]
GO
/****** Object:  Schema [GV03]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE SCHEMA [GV03]
GO
/****** Object:  Schema [GV05]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE SCHEMA [GV05]
GO
/****** Object:  Schema [GV10]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE SCHEMA [GV10]
GO
/****** Object:  Schema [N20DCCN001]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE SCHEMA [N20DCCN001]
GO
/****** Object:  Schema [N20DCCN008]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE SCHEMA [N20DCCN008]
GO
/****** Object:  Schema [N20DCCN014]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE SCHEMA [N20DCCN014]
GO
/****** Object:  Schema [N20DCCN015]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE SCHEMA [N20DCCN015]
GO
/****** Object:  Schema [N20DCCN096]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE SCHEMA [N20DCCN096]
GO
/****** Object:  UserDefinedFunction [dbo].[CalculateAge]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[CalculateAge](@MaSinhVien nvarchar(10))
RETURNS INT
AS
BEGIN
    DECLARE @Age INT;
    DECLARE @NgaySinh date;

    SELECT @NgaySinh = NgaySinh
    FROM SinhVien
    WHERE MaSinhVien = @MaSinhVien;

    SET @Age = DATEDIFF(YEAR, @NgaySinh, GETDATE());
    RETURN @Age;
END;
GO
/****** Object:  UserDefinedFunction [dbo].[CountSinhVienByNhom]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[CountSinhVienByNhom](@MaNhom nvarchar(10))
RETURNS INT
AS
BEGIN
    DECLARE @Count INT;
    SET @Count = (
        SELECT COUNT(*) FROM dbo.SinhVien WHERE MaNhom = @MaNhom
    );
    RETURN @Count;
END;
GO
/****** Object:  UserDefinedFunction [dbo].[CheckNgaySinhValid]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[CheckNgaySinhValid](@NgaySinh date)
RETURNS BIT
AS
BEGIN
    DECLARE @IsValid BIT;

    -- Kiểm tra điều kiện về NgaySinh
    -- Ví dụ: Kiểm tra xem NgaySinh có lớn hơn 01/01/1990 hay không
    IF @NgaySinh < '2005-12-31'
        SET @IsValid = 1; -- Hợp lệ
    ELSE
        SET @IsValid = 0; -- Không hợp lệ

    RETURN @IsValid;
END;
GO
/****** Object:  Table [dbo].[DiaBan]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiaBan](
	[MaDiaBan] [nvarchar](10) NOT NULL,
	[TenDiaBan] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDiaBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ThongTinMaDiaBan]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Danh sách các mã khoa 
CREATE VIEW [dbo].[ThongTinMaDiaBan]
AS 
SELECT MaDiaBan FROM DiaBan 
GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[MaGiaoVien] [nvarchar](10) NOT NULL,
	[Ho] [nvarchar](30) NOT NULL,
	[Ten] [nvarchar](10) NOT NULL,
	[Phai] [nvarchar](3) NULL,
	[MaKhoa] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGiaoVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[GioiTinh]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[GioiTinh] 
AS 
SELECT DISTINCT Phai FROM GIAOVIEN  
GO
/****** Object:  Table [dbo].[Nhom]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhom](
	[MaNhom] [nvarchar](10) NOT NULL,
	[TenNhom] [nvarchar](50) NOT NULL,
	[MaNhomTruong] [nvarchar](10) NOT NULL,
	[MaNhaDan] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSinhVien] [nvarchar](10) NOT NULL,
	[Ho] [nvarchar](30) NOT NULL,
	[Ten] [nvarchar](10) NOT NULL,
	[Phai] [nvarchar](3) NULL,
	[NgaySinh] [date] NOT NULL,
	[DiaChi] [nvarchar](200) NULL,
	[SoDienThoai] [nvarchar](10) NOT NULL,
	[MaDiaBan] [nvarchar](10) NULL,
	[MaNhom] [nvarchar](10) NULL,
	[MaKhoa] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSinhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ViewNhomThieuThanhVien]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewNhomThieuThanhVien] 
AS
	SELECT n.MaNhom, n.TenNhom, COUNT(sv.MaNhom) AS SoLuongSinhVien
	FROM NHOM n
	LEFT JOIN SinhVien sv ON n.MaNhom = sv.MaNhom
	GROUP BY n.MaNhom, n.TenNhom
	HAVING COUNT(sv.MaNhom) < 6 ;
GO
/****** Object:  Table [dbo].[BuoiCV]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BuoiCV](
	[MaBuoi] [int] IDENTITY(1,1) NOT NULL,
	[TenBuoi] [nvarchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBuoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanCong]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanCong](
	[IDPhanCong] [int] IDENTITY(1,1) NOT NULL,
	[MaBuoi] [int] NOT NULL,
	[MaNhom] [nvarchar](10) NOT NULL,
	[GhiChu] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDPhanCong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[PhanCongChuaThucHien]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[PhanCongChuaThucHien]
AS
SELECT    P.IDPhanCong, P.MaBuoi, P.MaNhom, P.GhiChu, N.TenNhom, B.TenBuoi
FROM         dbo.PhanCong AS P INNER JOIN
                      dbo.BuoiCV AS B ON P.MaBuoi = B.MaBuoi INNER JOIN
                      dbo.Nhom AS N ON P.MaNhom = N.MaNhom
GO
/****** Object:  Table [dbo].[ThucHienCongViec]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThucHienCongViec](
	[IDThucHien] [int] IDENTITY(1,1) NOT NULL,
	[IDPhanCong] [int] NOT NULL,
	[IDChiTietCV] [int] NOT NULL,
	[NgayThucHien] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDThucHien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[MaKhoa] [nvarchar](10) NOT NULL,
	[TenKhoa] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[NHOMKHOA]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[NHOMKHOA]
AS
SELECT    n.MaNhom, n.TenNhom, k.TenKhoa, s.MaKhoa
FROM         dbo.Nhom AS n INNER JOIN
                      dbo.SinhVien AS s ON s.MaSinhVien = n.MaNhomTruong INNER JOIN
                      dbo.Khoa AS k ON s.MaKhoa = k.MaKhoa LEFT OUTER JOIN
                      dbo.PhanCong AS p ON p.MaNhom = n.MaNhom
GROUP BY n.MaNhom, n.TenNhom, k.TenKhoa, s.MaKhoa
HAVING     (COUNT(p.MaNhom) < 3) OR
                      (COUNT(p.MaNhom) IS NULL)
GO
/****** Object:  View [dbo].[VIEW_PHANCONG]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VIEW_PHANCONG]
AS
SELECT        P.IDPhanCong, nk.TenNhom, B.TenBuoi, nk.MaKhoa, nk.TenKhoa, P.GhiChu
FROM            dbo.PhanCong AS P INNER JOIN
                         dbo.BuoiCV AS B ON P.MaBuoi = B.MaBuoi INNER JOIN
                         dbo.NHOMKHOA AS nk ON nk.MaNhom = P.MaNhom
GO
/****** Object:  Table [dbo].[ChiTietCongViec]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietCongViec](
	[IDChiTietCV] [int] IDENTITY(1,1) NOT NULL,
	[MaCongViec] [nvarchar](10) NOT NULL,
	[MaAp] [nvarchar](10) NOT NULL,
	[NgayBatDau] [date] NOT NULL,
	[NgayKetThuc] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDChiTietCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ap]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ap](
	[MaAp] [nvarchar](10) NOT NULL,
	[TenAp] [nvarchar](50) NOT NULL,
	[MaXa] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaAp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CongViec]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongViec](
	[MaCongViec] [nvarchar](10) NOT NULL,
	[TenCongViec] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCongViec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Xa]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xa](
	[MaXa] [nvarchar](10) NOT NULL,
	[TenXa] [nvarchar](50) NOT NULL,
	[MaDiaBan] [nvarchar](10) NOT NULL,
	[MaGiamSat1] [nvarchar](10) NULL,
	[MaGiamSat2] [nvarchar](10) NULL,
	[MaDoiTruong] [nvarchar](10) NULL,
	[MaDoiPho] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaXa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VChiTietCV]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VChiTietCV]
AS
SELECT    c.IDChiTietCV, cv.TenCongViec, dbo.Ap.MaXa, c.MaAp, dbo.Ap.TenAp, c.NgayBatDau, c.NgayKetThuc, dbo.Xa.MaGiamSat1, dbo.Xa.MaGiamSat2, dbo.Xa.MaDoiPho, dbo.Xa.MaDoiTruong
FROM         dbo.ChiTietCongViec AS c INNER JOIN
                      dbo.CongViec AS cv ON cv.MaCongViec = c.MaCongViec INNER JOIN
                      dbo.Ap ON dbo.Ap.MaAp = c.MaAp INNER JOIN
                      dbo.Xa ON dbo.Ap.MaXa = dbo.Xa.MaXa
GO
/****** Object:  View [dbo].[ThucHien]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[ThucHien]
as
select ct.TenAp, p.TenNhom, ct.TenCongViec, p.TenBuoi, t.*
from ThucHienCongViec t 
inner join VIEW_PHANCONG p on p.IDPhanCong = t.IDPhanCong
inner join VChiTietCV ct on ct.IDChiTietCV = t.IDChiTietCV
GO
/****** Object:  Table [dbo].[NhaDan]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaDan](
	[MaNhaDan] [nvarchar](10) NOT NULL,
	[TenNhaDan] [nvarchar](50) NOT NULL,
	[MaNhom] [nvarchar](10) NULL,
	[MaAp] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhaDan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_ChiTietPhanCong]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_ChiTietPhanCong]
AS
SELECT        pc.IDPhanCong, n.TenNhom, dbo.Ap.TenAp, dbo.Xa.TenXa, dbo.Xa.MaXa, dbo.Ap.MaAp, pc.TenBuoi, pc.GhiChu, dbo.Xa.MaGiamSat1, dbo.Xa.MaGiamSat2, dbo.Xa.MaDoiPho, dbo.Xa.MaDoiTruong
FROM            dbo.PhanCongChuaThucHien AS pc INNER JOIN
                         dbo.Nhom AS n ON n.MaNhom = pc.MaNhom INNER JOIN
                         dbo.NhaDan AS nd ON n.MaNhaDan = nd.MaNhaDan INNER JOIN
                         dbo.Ap ON dbo.Ap.MaAp = nd.MaAp INNER JOIN
                         dbo.Xa ON dbo.Xa.MaXa = dbo.Ap.MaXa
GO
/****** Object:  View [dbo].[view_Xa]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_Xa]
AS
SELECT    MaXa, TenXa, MaDiaBan, MaGiamSat1, MaGiamSat2, MaDoiTruong, MaDoiPho
FROM         dbo.Xa
GO
/****** Object:  View [dbo].[view_SVGiamSat]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[view_SVGiamSat] 
as
SELECT DISTINCT U.NAME AS LoginName, sv.*
FROM sys.sysusers U
inner join SinhVien sv on sv.MaSinhVien = U.Name 
INNER JOIN sys.sysmembers M ON M.memberuid = U.UID
INNER JOIN sys.sysusers G ON G.UID = M.groupuid
WHERE G.NAME = 'GIAMSAT'
GO
/****** Object:  View [dbo].[view_GVGiamSat]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[view_GVGiamSat] 
as
SELECT DISTINCT U.NAME AS LoginName, gv.*
FROM sys.sysusers U
inner join GiaoVien gv on gv.MaGiaoVien = U.Name 
INNER JOIN sys.sysmembers M ON M.memberuid = U.UID
INNER JOIN sys.sysusers G ON G.UID = M.groupuid
WHERE G.NAME = 'GIAMSAT'
GO
/****** Object:  View [dbo].[view_LayGiaoVienVaSinhVienKhongCoTK]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view  [dbo].[view_LayGiaoVienVaSinhVienKhongCoTK]
AS

    SELECT MaGiaoVien AS Ma, Ho, Ten, MaKhoa, 'GiaoVien' AS Loai FROM dbo.GiaoVien
    WHERE NOT EXISTS(SELECT * FROM sys.sysusers WHERE name = MaGiaoVien)
    
    UNION ALL
    
    SELECT MaSinhVien AS Ma, Ho, Ten, MaKhoa,  'SinhVien' AS Loai FROM dbo.SinhVien
    WHERE NOT EXISTS(SELECT * FROM sys.sysusers WHERE name = MaSinhVien)
GO
/****** Object:  View [dbo].[SINHVIENKHONGNHOM]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[SINHVIENKHONGNHOM]
AS
	SELECT * FROM SinhVien WHERE MaNhom IS NULL
GO
/****** Object:  View [dbo].[view_Nhom]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[view_Nhom]
as
select n.MaNhom, n.TenNhom, s.Ho + ' ' + s.Ten as 'Nhóm trưởng' from Nhom n, SinhVien s
where s.MaSinhVien = n.MaNhomTruong
GO
/****** Object:  View [dbo].[NhomChuaCoNhaDan]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[NhomChuaCoNhaDan]
as
	select * from Nhom 
	where MaNhaDan is null 
GO
/****** Object:  View [dbo].[ChiTietAp]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[ChiTietAp]
as
	select Ap.MaAp, Ap.TenAp, Xa.MaXa, Xa.TenXa, d.MaDiaBan, d.TenDiaBan from Ap
	inner join Xa on Xa.MaXa = Ap.MaXa
	inner join DiaBan d on d.MaDiaBan = Xa.MaDiaBan
GO
/****** Object:  View [dbo].[ROLES]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ROLES]
AS
SELECT    name
FROM         sys.database_principals
WHERE     (type = 'R') AND (create_date IS NOT NULL) AND (is_fixed_role = 0) AND (name <> 'public') AND (name <> 'QUANTRI')
GO
/****** Object:  Table [dbo].[KhenThuong]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhenThuong](
	[IDKhenThuong] [int] IDENTITY(1,1) NOT NULL,
	[MaThanhTich] [nvarchar](10) NOT NULL,
	[MaSinhVien] [nvarchar](10) NOT NULL,
	[NgayKhenThuong] [date] NOT NULL,
	[GhiChu] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDKhenThuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThanhTich]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanhTich](
	[MaThanhTich] [nvarchar](10) NOT NULL,
	[TenThanhTich] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThanhTich] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'AP1', N'Khu Phố 1', N'Xa1')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'AP2', N'Khu Phố 5', N'Xa2')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'AP3', N'Khu Phố 8', N'Xa3')
GO
SET IDENTITY_INSERT [dbo].[BuoiCV] ON 

INSERT [dbo].[BuoiCV] ([MaBuoi], [TenBuoi]) VALUES (1, N'Sáng')
INSERT [dbo].[BuoiCV] ([MaBuoi], [TenBuoi]) VALUES (2, N'Chiều')
INSERT [dbo].[BuoiCV] ([MaBuoi], [TenBuoi]) VALUES (3, N'Tối')
SET IDENTITY_INSERT [dbo].[BuoiCV] OFF
GO
INSERT [dbo].[CongViec] ([MaCongViec], [TenCongViec]) VALUES (N'CV4', N'Dạy Học')
INSERT [dbo].[CongViec] ([MaCongViec], [TenCongViec]) VALUES (N'CV3', N'Đắp Đường')
INSERT [dbo].[CongViec] ([MaCongViec], [TenCongViec]) VALUES (N'CV2', N'Làm Nhà')
INSERT [dbo].[CongViec] ([MaCongViec], [TenCongViec]) VALUES (N'CV1', N'Xây Cầu')
GO
SET IDENTITY_INSERT [dbo].[ChiTietCongViec] ON 

INSERT [dbo].[ChiTietCongViec] ([IDChiTietCV], [MaCongViec], [MaAp], [NgayBatDau], [NgayKetThuc]) VALUES (3, N'CV4', N'AP2', CAST(N'2023-06-21' AS Date), CAST(N'2023-06-30' AS Date))
INSERT [dbo].[ChiTietCongViec] ([IDChiTietCV], [MaCongViec], [MaAp], [NgayBatDau], [NgayKetThuc]) VALUES (7, N'CV4', N'AP1', CAST(N'2023-07-18' AS Date), CAST(N'2023-07-21' AS Date))
INSERT [dbo].[ChiTietCongViec] ([IDChiTietCV], [MaCongViec], [MaAp], [NgayBatDau], [NgayKetThuc]) VALUES (9, N'CV3', N'AP1', CAST(N'2023-06-01' AS Date), CAST(N'2023-07-31' AS Date))
SET IDENTITY_INSERT [dbo].[ChiTietCongViec] OFF
GO
INSERT [dbo].[DiaBan] ([MaDiaBan], [TenDiaBan]) VALUES (N'Q1', N'Quận 1')
INSERT [dbo].[DiaBan] ([MaDiaBan], [TenDiaBan]) VALUES (N'Q2', N'Quận 2')
INSERT [dbo].[DiaBan] ([MaDiaBan], [TenDiaBan]) VALUES (N'Q7', N'Quận 7')
INSERT [dbo].[DiaBan] ([MaDiaBan], [TenDiaBan]) VALUES (N'Q9', N'Quận 9')
INSERT [dbo].[DiaBan] ([MaDiaBan], [TenDiaBan]) VALUES (N'TD', N'Thủ Đức')
GO
INSERT [dbo].[GiaoVien] ([MaGiaoVien], [Ho], [Ten], [Phai], [MaKhoa]) VALUES (N'GV01', N'Lưu Nguyễn Kỳ', N'Thư', N'Nam', N'CNTT')
INSERT [dbo].[GiaoVien] ([MaGiaoVien], [Ho], [Ten], [Phai], [MaKhoa]) VALUES (N'GV02', N'Nguyễn Thị Bích', N'Nguyên', N'Nữ', N'CNTT')
INSERT [dbo].[GiaoVien] ([MaGiaoVien], [Ho], [Ten], [Phai], [MaKhoa]) VALUES (N'GV03', N'Nguyễn Trung', N'Hiếu', N'Nam', N'CNTT')
INSERT [dbo].[GiaoVien] ([MaGiaoVien], [Ho], [Ten], [Phai], [MaKhoa]) VALUES (N'GV04', N'Nguyễn Thị Tuyết', N'Hải', N'Nữ', N'CNTT')
INSERT [dbo].[GiaoVien] ([MaGiaoVien], [Ho], [Ten], [Phai], [MaKhoa]) VALUES (N'GV05', N'Trần Thanh', N'Trà', N'Nam', N'QTKD')
INSERT [dbo].[GiaoVien] ([MaGiaoVien], [Ho], [Ten], [Phai], [MaKhoa]) VALUES (N'GV06', N'Nguyễn Hồng', N'Sơn', N'Nam', N'CNTT')
INSERT [dbo].[GiaoVien] ([MaGiaoVien], [Ho], [Ten], [Phai], [MaKhoa]) VALUES (N'GV07', N'Huỳnh Văn', N'Hóa', N'Nam', N'DT-VT')
INSERT [dbo].[GiaoVien] ([MaGiaoVien], [Ho], [Ten], [Phai], [MaKhoa]) VALUES (N'GV08', N'Huỳnh Trọng', N'Thưa', N'Nam', N'CNTT')
INSERT [dbo].[GiaoVien] ([MaGiaoVien], [Ho], [Ten], [Phai], [MaKhoa]) VALUES (N'GV09', N'Trần Công', N'Hùng', N'Nam', N'CNTT')
INSERT [dbo].[GiaoVien] ([MaGiaoVien], [Ho], [Ten], [Phai], [MaKhoa]) VALUES (N'GV10', N'Huỳnh Trung', N'Trụ', N'Nam', N'QTKD')
INSERT [dbo].[GiaoVien] ([MaGiaoVien], [Ho], [Ten], [Phai], [MaKhoa]) VALUES (N'GV11', N'Huỳnh Thị Tuyết', N'Trinh', N'Nữ', N'QTKD')
INSERT [dbo].[GiaoVien] ([MaGiaoVien], [Ho], [Ten], [Phai], [MaKhoa]) VALUES (N'GV12', N'Nguyễn Thị Thùy', N'An', N'Nữ', N'QTKD')
INSERT [dbo].[GiaoVien] ([MaGiaoVien], [Ho], [Ten], [Phai], [MaKhoa]) VALUES (N'GV13', N'Cao Trung', N'Tín', N'Nam', N'DT-VT')
INSERT [dbo].[GiaoVien] ([MaGiaoVien], [Ho], [Ten], [Phai], [MaKhoa]) VALUES (N'GV14', N'Ngô Quang', N'Quyền', N'Nam', N'DT-VT')
INSERT [dbo].[GiaoVien] ([MaGiaoVien], [Ho], [Ten], [Phai], [MaKhoa]) VALUES (N'GV17', N'Phan Hồng', N'Hải', N'Nam', N'DK-TDH')
INSERT [dbo].[GiaoVien] ([MaGiaoVien], [Ho], [Ten], [Phai], [MaKhoa]) VALUES (N'GV18', N'Huỳnh Nguyên', N'Chính', N'Nam', N'DK-TDH')
GO
SET IDENTITY_INSERT [dbo].[KhenThuong] ON 

INSERT [dbo].[KhenThuong] ([IDKhenThuong], [MaThanhTich], [MaSinhVien], [NgayKhenThuong], [GhiChu]) VALUES (12, N'CC', N'N20DCCN004', CAST(N'2023-07-10' AS Date), NULL)
SET IDENTITY_INSERT [dbo].[KhenThuong] OFF
GO
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'CNTT', N'Công Nghệ Thông Tin')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'DK-TDH', N'Điều Khiển - Tự Động Hóa')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'DT-VT', N'Điện Tử - Viễn Thông')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'QTKD', N'Quản Trị Kinh Doanh')
GO
INSERT [dbo].[NhaDan] ([MaNhaDan], [TenNhaDan], [MaNhom], [MaAp]) VALUES (N'ND1', N'Nhà 1', N'N2', N'AP1')
INSERT [dbo].[NhaDan] ([MaNhaDan], [TenNhaDan], [MaNhom], [MaAp]) VALUES (N'ND2', N'Nhà 2', NULL, N'AP1')
INSERT [dbo].[NhaDan] ([MaNhaDan], [TenNhaDan], [MaNhom], [MaAp]) VALUES (N'ND3', N'Nhà 3', N'N3', N'AP1')
INSERT [dbo].[NhaDan] ([MaNhaDan], [TenNhaDan], [MaNhom], [MaAp]) VALUES (N'ND5', N'Nha 5', N'N4', N'AP2')
INSERT [dbo].[NhaDan] ([MaNhaDan], [TenNhaDan], [MaNhom], [MaAp]) VALUES (N'ND6', N'Nhà 6', N'N5', N'AP2')
GO
INSERT [dbo].[Nhom] ([MaNhom], [TenNhom], [MaNhomTruong], [MaNhaDan]) VALUES (N'N1', N'Nhóm 1', N'N20DCCN001', NULL)
INSERT [dbo].[Nhom] ([MaNhom], [TenNhom], [MaNhomTruong], [MaNhaDan]) VALUES (N'N2', N'Nhóm 2', N'N20DCCN007', N'ND1')
INSERT [dbo].[Nhom] ([MaNhom], [TenNhom], [MaNhomTruong], [MaNhaDan]) VALUES (N'N3', N'Nhóm 3', N'N20DCCN013', N'ND3')
INSERT [dbo].[Nhom] ([MaNhom], [TenNhom], [MaNhomTruong], [MaNhaDan]) VALUES (N'N4', N'Nhom 4', N'N20DCCN014', N'ND5')
INSERT [dbo].[Nhom] ([MaNhom], [TenNhom], [MaNhomTruong], [MaNhaDan]) VALUES (N'N5', N'Nhóm 5', N'N20DCCN015', N'ND6')
GO
SET IDENTITY_INSERT [dbo].[PhanCong] ON 

INSERT [dbo].[PhanCong] ([IDPhanCong], [MaBuoi], [MaNhom], [GhiChu]) VALUES (1, 2, N'N1', NULL)
INSERT [dbo].[PhanCong] ([IDPhanCong], [MaBuoi], [MaNhom], [GhiChu]) VALUES (9, 2, N'N2', N'')
INSERT [dbo].[PhanCong] ([IDPhanCong], [MaBuoi], [MaNhom], [GhiChu]) VALUES (10, 1, N'N4', N'')
INSERT [dbo].[PhanCong] ([IDPhanCong], [MaBuoi], [MaNhom], [GhiChu]) VALUES (11, 3, N'N1', N'')
INSERT [dbo].[PhanCong] ([IDPhanCong], [MaBuoi], [MaNhom], [GhiChu]) VALUES (13, 1, N'N2', N'')
INSERT [dbo].[PhanCong] ([IDPhanCong], [MaBuoi], [MaNhom], [GhiChu]) VALUES (14, 1, N'N1', N'')
INSERT [dbo].[PhanCong] ([IDPhanCong], [MaBuoi], [MaNhom], [GhiChu]) VALUES (17, 2, N'N3', N'')
INSERT [dbo].[PhanCong] ([IDPhanCong], [MaBuoi], [MaNhom], [GhiChu]) VALUES (18, 3, N'N3', N'')
INSERT [dbo].[PhanCong] ([IDPhanCong], [MaBuoi], [MaNhom], [GhiChu]) VALUES (19, 3, N'N4', NULL)
SET IDENTITY_INSERT [dbo].[PhanCong] OFF
GO
INSERT [dbo].[SinhVien] ([MaSinhVien], [Ho], [Ten], [Phai], [NgaySinh], [DiaChi], [SoDienThoai], [MaDiaBan], [MaNhom], [MaKhoa]) VALUES (N'N20DCCN001', N'Vũ Hoàng', N'Mạnh', N'Nam', CAST(N'2002-11-25' AS Date), N'Quảng Ninh', N'0384612857', N'TD', N'N1', N'CNTT')
INSERT [dbo].[SinhVien] ([MaSinhVien], [Ho], [Ten], [Phai], [NgaySinh], [DiaChi], [SoDienThoai], [MaDiaBan], [MaNhom], [MaKhoa]) VALUES (N'N20DCCN002', N'Bùi Tuấn', N'Anh', N'Nam', CAST(N'2002-05-28' AS Date), N'Đồng Nai', N'0857700502', N'TD', N'N1', N'CNTT')
INSERT [dbo].[SinhVien] ([MaSinhVien], [Ho], [Ten], [Phai], [NgaySinh], [DiaChi], [SoDienThoai], [MaDiaBan], [MaNhom], [MaKhoa]) VALUES (N'N20DCCN003', N'Huỳnh Ngọc', N'Ánh', N'Nữ', CAST(N'2002-12-03' AS Date), N'Long An', N'0376475278', N'TD', N'N1', N'CNTT')
INSERT [dbo].[SinhVien] ([MaSinhVien], [Ho], [Ten], [Phai], [NgaySinh], [DiaChi], [SoDienThoai], [MaDiaBan], [MaNhom], [MaKhoa]) VALUES (N'N20DCCN004', N'Đoàn Long', N'Âu', N'Nam', CAST(N'2002-11-17' AS Date), N'Phú Yên', N'0989908041', N'TD', N'N1', N'CNTT')
INSERT [dbo].[SinhVien] ([MaSinhVien], [Ho], [Ten], [Phai], [NgaySinh], [DiaChi], [SoDienThoai], [MaDiaBan], [MaNhom], [MaKhoa]) VALUES (N'N20DCCN005', N'Phạm Gia', N'Bảo', N'Nam', CAST(N'2002-08-15' AS Date), N'Tiền Giang', N'0944750240', N'TD', N'N1', N'CNTT')
INSERT [dbo].[SinhVien] ([MaSinhVien], [Ho], [Ten], [Phai], [NgaySinh], [DiaChi], [SoDienThoai], [MaDiaBan], [MaNhom], [MaKhoa]) VALUES (N'N20DCCN006', N'Phạm Ngọc', N'Bảo', N'Nam', CAST(N'2002-04-21' AS Date), N'Quảng Ngãi', N'0365597196', N'TD', N'N1', N'CNTT')
INSERT [dbo].[SinhVien] ([MaSinhVien], [Ho], [Ten], [Phai], [NgaySinh], [DiaChi], [SoDienThoai], [MaDiaBan], [MaNhom], [MaKhoa]) VALUES (N'N20DCCN007', N'Phạm Khánh', N'Băng', N'Nam', CAST(N'2002-08-09' AS Date), N'Cà Mau', N'0865486537', N'Q2', N'N2', N'CNTT')
INSERT [dbo].[SinhVien] ([MaSinhVien], [Ho], [Ten], [Phai], [NgaySinh], [DiaChi], [SoDienThoai], [MaDiaBan], [MaNhom], [MaKhoa]) VALUES (N'N20DCCN008', N'Trần Hữu', N'Chiến', N'Nam', CAST(N'2002-12-26' AS Date), N'Bình Phước', N'0965197649', N'Q2', N'N2', N'CNTT')
INSERT [dbo].[SinhVien] ([MaSinhVien], [Ho], [Ten], [Phai], [NgaySinh], [DiaChi], [SoDienThoai], [MaDiaBan], [MaNhom], [MaKhoa]) VALUES (N'N20DCCN009', N'Nguyễn Đức Chí', N'Danh', N'Nam', CAST(N'2002-05-31' AS Date), N'Khánh Hòa', N'0868273914', N'Q2', N'N2', N'CNTT')
INSERT [dbo].[SinhVien] ([MaSinhVien], [Ho], [Ten], [Phai], [NgaySinh], [DiaChi], [SoDienThoai], [MaDiaBan], [MaNhom], [MaKhoa]) VALUES (N'N20DCCN010', N'Châu Huy', N'Diễn', N'Nam', CAST(N'2002-12-22' AS Date), N'Bình Định', N'0326917158', N'Q2', NULL, N'CNTT')
INSERT [dbo].[SinhVien] ([MaSinhVien], [Ho], [Ten], [Phai], [NgaySinh], [DiaChi], [SoDienThoai], [MaDiaBan], [MaNhom], [MaKhoa]) VALUES (N'N20DCCN011', N'Trần Văn', N'Du', N'Nam', CAST(N'2002-08-03' AS Date), N'Đăk Nông', N'0337873884', N'Q2', NULL, N'CNTT')
INSERT [dbo].[SinhVien] ([MaSinhVien], [Ho], [Ten], [Phai], [NgaySinh], [DiaChi], [SoDienThoai], [MaDiaBan], [MaNhom], [MaKhoa]) VALUES (N'N20DCCN012', N'Nguyễn Hữu', N'Dũng', N'Nam', CAST(N'2002-07-04' AS Date), N'Khánh Hòa', N'0866156874', N'Q2', NULL, N'CNTT')
INSERT [dbo].[SinhVien] ([MaSinhVien], [Ho], [Ten], [Phai], [NgaySinh], [DiaChi], [SoDienThoai], [MaDiaBan], [MaNhom], [MaKhoa]) VALUES (N'N20DCCN013', N'Nguyễn Quốc', N'Duy', N'Nam', CAST(N'2002-07-04' AS Date), N'Khánh Hòa', N'0866156874', N'TD', N'N3', N'CNTT')
INSERT [dbo].[SinhVien] ([MaSinhVien], [Ho], [Ten], [Phai], [NgaySinh], [DiaChi], [SoDienThoai], [MaDiaBan], [MaNhom], [MaKhoa]) VALUES (N'N20DCCN014', N'Hồ Thái', N'Đạt', N'Nam', CAST(N'2002-07-04' AS Date), N'Bình Định', N'0123556412', N'TD', N'N4', N'QTKD')
INSERT [dbo].[SinhVien] ([MaSinhVien], [Ho], [Ten], [Phai], [NgaySinh], [DiaChi], [SoDienThoai], [MaDiaBan], [MaNhom], [MaKhoa]) VALUES (N'N20DCCN015', N'Võ Thành ', N'Đạt', N'Nam', CAST(N'2002-07-23' AS Date), N'Quảng Nam', N'0123456789', N'Q9', N'N5', N'QTKD')
INSERT [dbo].[SinhVien] ([MaSinhVien], [Ho], [Ten], [Phai], [NgaySinh], [DiaChi], [SoDienThoai], [MaDiaBan], [MaNhom], [MaKhoa]) VALUES (N'N20DCCN096', N'Đậu Văn', N'Hoàngg', N'Nam', CAST(N'2002-07-01' AS Date), NULL, N'0365597199', N'Q1', NULL, N'CNTT')
GO
INSERT [dbo].[ThanhTich] ([MaThanhTich], [TenThanhTich]) VALUES (N'CC', N'Chăm Chỉ')
INSERT [dbo].[ThanhTich] ([MaThanhTich], [TenThanhTich]) VALUES (N'NL', N'Nỗ Lực')
INSERT [dbo].[ThanhTich] ([MaThanhTich], [TenThanhTich]) VALUES (N'PD', N'PHẤN ĐẤU')
INSERT [dbo].[ThanhTich] ([MaThanhTich], [TenThanhTich]) VALUES (N'VK', N'Vượt Khó')
GO
SET IDENTITY_INSERT [dbo].[ThucHienCongViec] ON 

INSERT [dbo].[ThucHienCongViec] ([IDThucHien], [IDPhanCong], [IDChiTietCV], [NgayThucHien]) VALUES (2, 1, 3, CAST(N'2023-06-25' AS Date))
INSERT [dbo].[ThucHienCongViec] ([IDThucHien], [IDPhanCong], [IDChiTietCV], [NgayThucHien]) VALUES (5, 13, 7, CAST(N'2023-07-20' AS Date))
INSERT [dbo].[ThucHienCongViec] ([IDThucHien], [IDPhanCong], [IDChiTietCV], [NgayThucHien]) VALUES (8, 9, 3, CAST(N'2023-06-23' AS Date))
INSERT [dbo].[ThucHienCongViec] ([IDThucHien], [IDPhanCong], [IDChiTietCV], [NgayThucHien]) VALUES (9, 10, 3, CAST(N'2023-06-23' AS Date))
INSERT [dbo].[ThucHienCongViec] ([IDThucHien], [IDPhanCong], [IDChiTietCV], [NgayThucHien]) VALUES (10, 13, 9, CAST(N'2023-07-12' AS Date))
SET IDENTITY_INSERT [dbo].[ThucHienCongViec] OFF
GO
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan], [MaGiamSat1], [MaGiamSat2], [MaDoiTruong], [MaDoiPho]) VALUES (N'Xa1', N'Linh Trung', N'TD', N'GV02', N'GV03', N'N20DCCN005', N'N20DCCN006')
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan], [MaGiamSat1], [MaGiamSat2], [MaDoiTruong], [MaDoiPho]) VALUES (N'Xa2', N'Tăng Nhơn Phú', N'Q9', N'GV05', N'GV10', N'N20DCCN014', N'N20DCCN015')
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan], [MaGiamSat1], [MaGiamSat2], [MaDoiTruong], [MaDoiPho]) VALUES (N'Xa3', N'Linh Đông', N'TD', N'GV05', N'GV10', N'N20DCCN014', N'N20DCCN015')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [idx_Ap_MaXa]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE NONCLUSTERED INDEX [idx_Ap_MaXa] ON [dbo].[Ap]
(
	[MaXa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [idx_Ap_TenAp]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE NONCLUSTERED INDEX [idx_Ap_TenAp] ON [dbo].[Ap]
(
	[TenAp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [idx_CongViec_Ten]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE NONCLUSTERED INDEX [idx_CongViec_Ten] ON [dbo].[CongViec]
(
	[TenCongViec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_CTCV]    Script Date: 2023-07-11 5:26:54 CH ******/
ALTER TABLE [dbo].[ChiTietCongViec] ADD  CONSTRAINT [UK_CTCV] UNIQUE NONCLUSTERED 
(
	[MaCongViec] ASC,
	[MaAp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [idx_TenDiaBan]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE NONCLUSTERED INDEX [idx_TenDiaBan] ON [dbo].[DiaBan]
(
	[TenDiaBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [idx_GiaoVien_TenHo]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE NONCLUSTERED INDEX [idx_GiaoVien_TenHo] ON [dbo].[GiaoVien]
(
	[Ten] ASC,
	[Ho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [idx_MaKhoa]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE NONCLUSTERED INDEX [idx_MaKhoa] ON [dbo].[GiaoVien]
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [idx_Nhom_TenNhom]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE NONCLUSTERED INDEX [idx_Nhom_TenNhom] ON [dbo].[Nhom]
(
	[TenNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_PHANCONG]    Script Date: 2023-07-11 5:26:54 CH ******/
ALTER TABLE [dbo].[PhanCong] ADD  CONSTRAINT [UK_PHANCONG] UNIQUE NONCLUSTERED 
(
	[MaBuoi] ASC,
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [idx_MaKhoa]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE NONCLUSTERED INDEX [idx_MaKhoa] ON [dbo].[SinhVien]
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [idx_SinhVien_MaNhom]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE NONCLUSTERED INDEX [idx_SinhVien_MaNhom] ON [dbo].[SinhVien]
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [idx_SinhVien_TenHo]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE NONCLUSTERED INDEX [idx_SinhVien_TenHo] ON [dbo].[SinhVien]
(
	[Ten] ASC,
	[Ho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [idx_Xa_MaDiaBan]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE NONCLUSTERED INDEX [idx_Xa_MaDiaBan] ON [dbo].[Xa]
(
	[MaDiaBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [idx_Xa_TenXa]    Script Date: 2023-07-11 5:26:54 CH ******/
CREATE NONCLUSTERED INDEX [idx_Xa_TenXa] ON [dbo].[Xa]
(
	[TenXa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Ap]  WITH CHECK ADD  CONSTRAINT [FK_Ap_Xa] FOREIGN KEY([MaXa])
REFERENCES [dbo].[Xa] ([MaXa])
GO
ALTER TABLE [dbo].[Ap] CHECK CONSTRAINT [FK_Ap_Xa]
GO
ALTER TABLE [dbo].[ChiTietCongViec]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietCongViec_Ap] FOREIGN KEY([MaAp])
REFERENCES [dbo].[Ap] ([MaAp])
GO
ALTER TABLE [dbo].[ChiTietCongViec] CHECK CONSTRAINT [FK_ChiTietCongViec_Ap]
GO
ALTER TABLE [dbo].[ChiTietCongViec]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietCongViec_CongViec] FOREIGN KEY([MaCongViec])
REFERENCES [dbo].[CongViec] ([MaCongViec])
GO
ALTER TABLE [dbo].[ChiTietCongViec] CHECK CONSTRAINT [FK_ChiTietCongViec_CongViec]
GO
ALTER TABLE [dbo].[GiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_GiaoVien_Khoa] FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[GiaoVien] CHECK CONSTRAINT [FK_GiaoVien_Khoa]
GO
ALTER TABLE [dbo].[KhenThuong]  WITH CHECK ADD  CONSTRAINT [FK_KhenThuong_SinhVien] FOREIGN KEY([MaSinhVien])
REFERENCES [dbo].[SinhVien] ([MaSinhVien])
GO
ALTER TABLE [dbo].[KhenThuong] CHECK CONSTRAINT [FK_KhenThuong_SinhVien]
GO
ALTER TABLE [dbo].[KhenThuong]  WITH CHECK ADD  CONSTRAINT [FK_KhenThuong_ThanhTich] FOREIGN KEY([MaThanhTich])
REFERENCES [dbo].[ThanhTich] ([MaThanhTich])
GO
ALTER TABLE [dbo].[KhenThuong] CHECK CONSTRAINT [FK_KhenThuong_ThanhTich]
GO
ALTER TABLE [dbo].[NhaDan]  WITH CHECK ADD  CONSTRAINT [FK_NhaDan_Ap] FOREIGN KEY([MaAp])
REFERENCES [dbo].[Ap] ([MaAp])
GO
ALTER TABLE [dbo].[NhaDan] CHECK CONSTRAINT [FK_NhaDan_Ap]
GO
ALTER TABLE [dbo].[NhaDan]  WITH CHECK ADD  CONSTRAINT [FK_NhaDan_Nhom] FOREIGN KEY([MaNhom])
REFERENCES [dbo].[Nhom] ([MaNhom])
GO
ALTER TABLE [dbo].[NhaDan] CHECK CONSTRAINT [FK_NhaDan_Nhom]
GO
ALTER TABLE [dbo].[Nhom]  WITH CHECK ADD  CONSTRAINT [FK_Nhom_NhaDan] FOREIGN KEY([MaNhaDan])
REFERENCES [dbo].[NhaDan] ([MaNhaDan])
GO
ALTER TABLE [dbo].[Nhom] CHECK CONSTRAINT [FK_Nhom_NhaDan]
GO
ALTER TABLE [dbo].[Nhom]  WITH CHECK ADD  CONSTRAINT [FK_Nhom_SinhVien] FOREIGN KEY([MaNhomTruong])
REFERENCES [dbo].[SinhVien] ([MaSinhVien])
GO
ALTER TABLE [dbo].[Nhom] CHECK CONSTRAINT [FK_Nhom_SinhVien]
GO
ALTER TABLE [dbo].[PhanCong]  WITH CHECK ADD  CONSTRAINT [FK_PhanCong_BuoiCV] FOREIGN KEY([MaBuoi])
REFERENCES [dbo].[BuoiCV] ([MaBuoi])
GO
ALTER TABLE [dbo].[PhanCong] CHECK CONSTRAINT [FK_PhanCong_BuoiCV]
GO
ALTER TABLE [dbo].[PhanCong]  WITH CHECK ADD  CONSTRAINT [FK_PhanCong_Nhom] FOREIGN KEY([MaNhom])
REFERENCES [dbo].[Nhom] ([MaNhom])
GO
ALTER TABLE [dbo].[PhanCong] CHECK CONSTRAINT [FK_PhanCong_Nhom]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_DiaBan] FOREIGN KEY([MaDiaBan])
REFERENCES [dbo].[DiaBan] ([MaDiaBan])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_DiaBan]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_Nhom] FOREIGN KEY([MaNhom])
REFERENCES [dbo].[Nhom] ([MaNhom])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_Nhom]
GO
ALTER TABLE [dbo].[ThucHienCongViec]  WITH CHECK ADD  CONSTRAINT [FK_ThucHienCongViec_ChiTietCongViec] FOREIGN KEY([IDChiTietCV])
REFERENCES [dbo].[ChiTietCongViec] ([IDChiTietCV])
GO
ALTER TABLE [dbo].[ThucHienCongViec] CHECK CONSTRAINT [FK_ThucHienCongViec_ChiTietCongViec]
GO
ALTER TABLE [dbo].[ThucHienCongViec]  WITH CHECK ADD  CONSTRAINT [FK_ThucHienCongViec_PhanCong] FOREIGN KEY([IDPhanCong])
REFERENCES [dbo].[PhanCong] ([IDPhanCong])
GO
ALTER TABLE [dbo].[ThucHienCongViec] CHECK CONSTRAINT [FK_ThucHienCongViec_PhanCong]
GO
ALTER TABLE [dbo].[Xa]  WITH CHECK ADD  CONSTRAINT [FK_Xa_DiaBan] FOREIGN KEY([MaDiaBan])
REFERENCES [dbo].[DiaBan] ([MaDiaBan])
GO
ALTER TABLE [dbo].[Xa] CHECK CONSTRAINT [FK_Xa_DiaBan]
GO
ALTER TABLE [dbo].[Xa]  WITH CHECK ADD  CONSTRAINT [FK_Xa_DoiPho] FOREIGN KEY([MaDoiPho])
REFERENCES [dbo].[SinhVien] ([MaSinhVien])
GO
ALTER TABLE [dbo].[Xa] CHECK CONSTRAINT [FK_Xa_DoiPho]
GO
ALTER TABLE [dbo].[Xa]  WITH CHECK ADD  CONSTRAINT [FK_Xa_DoiTruong] FOREIGN KEY([MaDoiTruong])
REFERENCES [dbo].[SinhVien] ([MaSinhVien])
GO
ALTER TABLE [dbo].[Xa] CHECK CONSTRAINT [FK_Xa_DoiTruong]
GO
ALTER TABLE [dbo].[Xa]  WITH CHECK ADD  CONSTRAINT [FK_Xa_GiaoVien1] FOREIGN KEY([MaGiamSat1])
REFERENCES [dbo].[GiaoVien] ([MaGiaoVien])
GO
ALTER TABLE [dbo].[Xa] CHECK CONSTRAINT [FK_Xa_GiaoVien1]
GO
ALTER TABLE [dbo].[Xa]  WITH CHECK ADD  CONSTRAINT [FK_Xa_GiaoVien2] FOREIGN KEY([MaGiamSat2])
REFERENCES [dbo].[GiaoVien] ([MaGiaoVien])
GO
ALTER TABLE [dbo].[Xa] CHECK CONSTRAINT [FK_Xa_GiaoVien2]
GO
/****** Object:  StoredProcedure [dbo].[ADDNHADAN]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ADDNHADAN] 
@MANHOM NVARCHAR(10),
@MANHADAN NVARCHAR(10),
@ERRORCODE INT OUTPUT
AS
BEGIN 
	IF EXISTS (
        SELECT 1
        FROM NHADAN
        WHERE MANHADAN = @MANHADAN AND MaNhom IS NOT NULL
    )
    BEGIN
        SET @ERRORCODE = -1
        RETURN
    END

    -- Tiến hành cập nhật
    UPDATE NHADAN
    SET MaNhom = @MANHOM
    WHERE MANHADAN = @MANHADAN;

    UPDATE NHOM
    SET MANHADAN = @MANHADAN
    WHERE MaNhom = @MANHOM;
	SET @ERRORCODE = 0
END
GO
/****** Object:  StoredProcedure [dbo].[BackupData]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[INSERTCTCV]    Script Date: 6/25/2023 7:41:38 PM ******/
CREATE PROCEDURE [dbo].[BackupData]
    @BackupFilePath NVARCHAR(500)
AS
BEGIN
    DECLARE @Backup NVARCHAR(1000);
    SET @Backup = 'BACKUP DATABASE MuaHeXanh TO DISK = ''' + @BackupFilePath + '''';
    EXEC sp_executesql @Backup;
END
GO
/****** Object:  StoredProcedure [dbo].[DelChiTietCV]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DelChiTietCV]
@id int 
as
begin 
	delete from ChiTietCongViec
	where IDChiTietCV = @id
end
GO
/****** Object:  StoredProcedure [dbo].[DELNHADAN]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DELNHADAN] 
@MANHOM NVARCHAR(10),
@MANHADAN NVARCHAR(10)
AS
BEGIN 
	UPDATE NHADAN
	SET MaNhom = NULL
	WHERE MANHADAN = @MANHADAN
	UPDATE NHOM
	SET MANHADAN = NULL
	WHERE MaNhom = @MANHOM
	
END
GO
/****** Object:  StoredProcedure [dbo].[INSERTCTCV]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[INSERTCTCV]
@macongviec nvarchar(10),
@maap nvarchar(10),
@ngaybatdau date,
@ngayketthuc date
as
begin 
	INSERT INTO ChiTietCongViec (MaCongViec, MaAp, NgayBatDau, NgayKetThuc)
    VALUES (@macongviec, @maap, @ngaybatdau, @ngayketthuc)
end
GO
/****** Object:  StoredProcedure [dbo].[RestoreData]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RestoreData]
    @BackupFilePath NVARCHAR(255)
AS
BEGIN
    -- Kiểm tra xem tệp sao lưu có tồn tại hay không
    IF NOT EXISTS (SELECT 1 FROM sys.sysdevices WHERE name = 'my_backup_device')
    BEGIN
        EXEC sp_addumpdevice 'disk', 'my_backup_device', @BackupFilePath;
    END;

    -- Phục hồi cơ sở dữ liệu từ tệp sao lưu
    RESTORE DATABASE MuaHeXanh
    FROM DISK = 'my_backup_device'
    WITH REPLACE, RECOVERY;

    -- Kiểm tra xem phục hồi thành công hay không
    IF @@ROWCOUNT > 0
    BEGIN
        SELECT 'Restore successful!' AS Message;
    END
    ELSE
    BEGIN
        SELECT 'Restore failed!' AS Message;
    END;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_AddThucHienCongViec]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_AddThucHienCongViec]
@idphancong int,
@idchitietcv int,
@ngaythuchien date
as
begin 
	insert into ThucHienCongViec(IDPhanCong, IDChiTietCV, NgayThucHien)
	values (@idphancong, @idchitietcv, @ngaythuchien)

end 
GO
/****** Object:  StoredProcedure [dbo].[sp_CTCVNHOM]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_CTCVNHOM]
@masv nvarchar(10)
as
begin
SELECT		 ct.TenAp, x.TenXa, p.TenNhom, ct.TenCongViec, p.TenBuoi,t.NgayThucHien
FROM         dbo.ThucHienCongViec AS t INNER JOIN
             dbo.VIEW_PHANCONG AS p ON p.IDPhanCong = t.IDPhanCong INNER JOIN
			 dbo.PhanCong AS pc ON p.IDPhanCong = pc.IDPhanCong INNER JOIN
             dbo.VChiTietCV AS ct ON ct.IDChiTietCV = t.IDChiTietCV inner join 
			 dbo.Xa As x on x.MaXa = ct.MaXa inner join 
			 dbo.SinhVien sv on pc.MaNhom = sv.MaNhom
			 where sv.MaSinhVien = @masv
end
GO
/****** Object:  StoredProcedure [dbo].[sp_DelThucHienCongViec]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DelThucHienCongViec] 
@id int 
as
begin 
	delete from ThucHienCongViec
	where IDThucHien = @id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertSinhVien]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertSinhVien]
    @MaSinhVien nvarchar(10),
    @Ho nvarchar(30),
    @Ten nvarchar(10),
    @Phai nvarchar(3),
    @NgaySinh date,
    @DiaChi nvarchar(200),
    @SoDienThoai nvarchar(10),
    @MaDiaBan nvarchar(10),
    @MaNhom nvarchar(10),
    @MaKhoa nvarchar(10)
AS
BEGIN
    SET NOCOUNT ON;
	IF dbo.CheckNgaySinhValid(@NgaySinh) = 0
	BEGIN
		RAISERROR('Sinh viên phải đủ 18 tuổi.', 16, 1);
		RETURN;
	END;
    INSERT INTO SinhVien (MaSinhVien, Ho, Ten, Phai, NgaySinh, DiaChi, SoDienThoai, MaDiaBan, MaNhom, MaKhoa)
    VALUES (@MaSinhVien, @Ho, @Ten, @Phai, @NgaySinh, @DiaChi, @SoDienThoai, @MaDiaBan, @MaNhom, @MaKhoa);
	 
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_MaNhom]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[sp_MaNhom] 
 @masv nvarchar(10)
 as
 begin 
 select MaNhom from SinhVien where MaSinhVien = @masv
 end 
GO
/****** Object:  StoredProcedure [dbo].[SP_TAOLOGIN]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TAOLOGIN]
  @LGNAME VARCHAR(50),
  @PASS VARCHAR(50),
  @USERNAME VARCHAR(50),
  @ROLE VARCHAR(50)
AS
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS,'MuaHeXanh'
  IF (@RET =1)  -- LOGIN NAME BI TRUNG
     RETURN 1
 
  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET =1)  -- USER  NAME BI TRUNG
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RETURN 2
  END
  EXEC sp_addrolemember @ROLE, @USERNAME
  IF @ROLE= 'QUANTRI' or @ROLE= 'KHOA'
  BEGIN 
    EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
  END
RETURN 0  -- THANH CONG
GO
/****** Object:  StoredProcedure [dbo].[sp_ThongKeCongViec]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ThongKeCongViec]
@ngaybd date,
@ngaykt date
as
begin
	SELECT ct.MaCongViec, cv.TenCongViec, dc.TenAp, dc.TenXa, dc.TenDiaBan
	FROM ChiTietCongViec ct
	INNER JOIN CongViec cv ON ct.MaCongViec = cv.MaCongViec
	INNER JOIN (
		SELECT ap.MaAp, ap.TenAp, xa.TenXa, db.TenDiaBan
		FROM Ap ap
		INNER JOIN Xa xa ON ap.MaXa = xa.MaXa
		INNER JOIN DiaBan db ON db.MaDiaBan = xa.MaDiaBan
	) dc ON dc.MaAp = ct.MaAp
	WHERE ct.NgayBatDau >= @ngaybd AND ct.NgayBatDau <= @ngaykt
end
GO
/****** Object:  StoredProcedure [dbo].[sp_ThongKeSinhVien]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_ThongKeSinhVien]
AS
BEGIN
	SELECT sv.MASINHVIEN, sv.HOTEN, sv.PHAI, sv.DIACHI, sv.SoDienThoai, k.TenKhoa
	FROM 
	(
		SELECT MaSinhVien, (Ho + ' ' + Ten) AS [HOTEN], Phai, DiaChi, SoDienThoai, MaKhoa
		FROM dbo.SinhVien
	) sv
	JOIN dbo.Khoa k 
	ON k.MaKhoa = sv.MaKhoa
	ORDER BY k.MaKhoa, sv.MaSinhVien

END

GO
/****** Object:  StoredProcedure [dbo].[sp_ThongKeSinhVienDiaBan]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ThongKeSinhVienDiaBan] 
@maDB nvarchar(10)
AS
BEGIN
	SELECT sv.MASINHVIEN, sv.HOTEN, sv.SoDienThoai, k.TenKhoa, ap.TenAp, xa.TenXa, d.TenDiaBan
	FROM 
	(
		SELECT MaSinhVien, (Ho + ' ' + Ten) AS HOTEN, SoDienThoai, MaNhom, MaKhoa FROM dbo.SinhVien
		WHERE MaDiaBan = @maDB
	) sv
	JOIN dbo.Khoa k 
	ON k.MaKhoa = sv.MaKhoa
	join DiaBan d on d.MaDiaBan = @maDB
	left join dbo.Nhom n
	ON n.MaNhom = sv.MaNhom

	left join dbo.Nhadan nd
	ON nd.MaNhom = sv.MaNhom

	left join dbo.Ap ap
	ON ap.MaAp = nd.MaAp

	left join dbo.Xa xa
	ON ap.MaXa = xa.MaXa
	ORDER BY   k.TenKhoa, d.TenDiaBan, xa.TenXa, ap.TenAp,sv.MaSinhVien, sv.HOTEN
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ThongKeSinhVienTatCaDiaBan]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ThongKeSinhVienTatCaDiaBan] 
AS
BEGIN
	SELECT sv.MASINHVIEN, sv.HOTEN, sv.SoDienThoai, k.TenKhoa, ap.TenAp, xa.TenXa, d.TenDiaBan
	FROM 
	(
		SELECT MaSinhVien, (Ho + ' ' + Ten) AS HOTEN, SoDienThoai, MaNhom, MaKhoa, MaDiaBan FROM dbo.SinhVien
	) sv
	JOIN dbo.Khoa k 
	ON k.MaKhoa = sv.MaKhoa
	
	left join dbo.Nhom n
	ON n.MaNhom = sv.MaNhom

	left join dbo.Nhadan nd
	ON nd.MaNhom = sv.MaNhom

	left join dbo.Ap ap
	ON ap.MaAp = nd.MaAp

	left join dbo.Xa xa
	ON ap.MaXa = xa.MaXa
	join DiaBan d on d.MaDiaBan = sv.MaDiaBan
	ORDER BY   k.TenKhoa, d.TenDiaBan,xa.TenXa, ap.TenAp,sv.MaSinhVien, sv.HOTEN
END
GO
/****** Object:  StoredProcedure [dbo].[SPKiemTraDangNhap]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPKiemTraDangNhap]
	@TENLOGIN NVARCHAR(100)
AS
BEGIN 
	DECLARE @UID NVARCHAR(20)
	DECLARE @MaNguoiDung NVARCHAR(100)

	SELECT @UID = uid, @MaNguoiDung = NAME FROM sys.sysusers WHERE sid = SUSER_SID(@TENLOGIN)

	IF EXISTS (SELECT 1 FROM dbo.GIAOVIEN WHERE MaGiaoVien = @MaNguoiDung)
	BEGIN
		SELECT  MAGIAOVIEN = @MaNguoiDung,
				TENGV = (SELECT Ho + ' ' + Ten FROM dbo.GIAOVIEN WHERE MaGiaoVien = @MaNguoiDung),
				TENNHOM = NAME,
				MaKhoa = (SELECT MaKhoa FROM dbo.GIAOVIEN WHERE MaGiaoVien = @MaNguoiDung)
		FROM sys.sysusers
		WHERE UID = (SELECT groupuid FROM sys.sysmembers WHERE memberuid = @UID)
	END
	ELSE IF EXISTS (SELECT 1 FROM dbo.SINHVIEN WHERE MaSinhVien = @MaNguoiDung)
	BEGIN
		SELECT  MASINHVIEN = @MaNguoiDung,
				TENSV = (SELECT Ho + ' ' + Ten FROM dbo.SINHVIEN WHERE MaSinhVien = @MaNguoiDung),
				TENNHOM = NAME,
				MaKhoa = (SELECT MaKhoa FROM dbo.SinhVien WHERE MaSinhVien = @MaNguoiDung)
		FROM sys.sysusers
		WHERE UID = (SELECT groupuid FROM sys.sysmembers WHERE memberuid = @UID)
	END
END
GO
/****** Object:  StoredProcedure [dbo].[SPPHANCONG]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SPPHANCONG] 
@MaBuoi int,
@MaNhom NVARCHAR(10),
@GhiChu ntext = null
as 
begin 
	INSERT INTO PhanCong(MaNhom, MaBuoi, GhiChu)
    VALUES (@MaNhom, @MaBuoi, @GhiChu)
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateNhomByMaSinhVien]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateNhomByMaSinhVien]
    @MaSinhVien NVARCHAR(10),
    @MaNhom NVARCHAR(10)
AS
BEGIN
    UPDATE SinhVien
    SET MaNhom = @MaNhom
    WHERE MaSinhVien = @MaSinhVien;
END
GO
/****** Object:  StoredProcedure [dbo].[updateXa]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updateXa]
@maxa nvarchar(10),
@giamsat1 nvarchar(10),
@giamsat2 nvarchar(10),
@doitruong nvarchar(10),
@doipho nvarchar(10)
as
begin 
	UPDATE Xa
    SET MaGiamSat1 = @giamsat1,
        MaGiamSat2 = @giamsat2,
        MaDoiTruong = @doitruong,
        MaDoiPho = @doipho
    WHERE maxa = @maxa;
end
GO
/****** Object:  StoredProcedure [dbo].[usp_KIEMTRAKHENTHUONG]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_KIEMTRAKHENTHUONG]
	@MaThanhTich NVARCHAR(10), @MaSinhVien NVARCHAR(10)
AS
BEGIN

	IF EXISTS(SELECT MaThanhTich, MaSinhVien FROM dbo.KhenThuong WHERE MaThanhTich = @MaThanhTich AND  MaSinhVien = @MaSinhVien)	
		Return 1
	return 0

END
GO
/****** Object:  StoredProcedure [dbo].[usp_ThongKeSinhVienDiaBan]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_ThongKeSinhVienDiaBan] 
@maDB nvarchar(10)
AS
BEGIN
	SELECT sv.MASINHVIEN, sv.HOTEN, sv.SoDienThoai, k.TenKhoa, ap.TenAp, xa.TenXa, d.TenDiaBan
	FROM 
	(
		SELECT MaSinhVien, (Ho + ' ' + Ten) AS HOTEN, SoDienThoai, MaNhom, MaKhoa FROM dbo.SinhVien
		WHERE MaDiaBan = @maDB
	) sv
	JOIN dbo.Khoa k 
	ON k.MaKhoa = sv.MaKhoa
	join DiaBan d on d.MaDiaBan = @maDB
	join dbo.Nhom n
	ON n.MaNhom = sv.MaNhom

	join dbo.Nhadan nd
	ON nd.MaNhom = sv.MaNhom

	join dbo.Ap ap
	ON ap.MaAp = nd.MaAp

	join dbo.Xa xa
	ON ap.MaXa = xa.MaXa
	ORDER BY   xa.TenXa, ap.TenAp,sv.MaSinhVien, sv.HOTEN

END
GO
/****** Object:  StoredProcedure [dbo].[Xoa_Login]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Xoa_Login]
  @LGNAME VARCHAR(50),
  @USRNAME VARCHAR(50)
AS
  EXEC SP_DROPUSER @USRNAME
  EXEC SP_DROPLOGIN @LGNAME
GO
/****** Object:  StoredProcedure [dbo].[XoaKhenThuong]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[XoaKhenThuong] 
@MaKT int
as
begin 
	delete from KhenThuong
	where IDKhenThuong = @MaKT
end
GO
/****** Object:  StoredProcedure [dbo].[XoaNhaDan]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[XoaNhaDan] 
	@manhadan nvarchar(10)
as
begin 
	delete from NhaDan
	where MaNhaDan = @manhadan
end
GO
/****** Object:  StoredProcedure [dbo].[XoaPhanCong]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[XoaPhanCong] 
@IDphancong int 
as
begin 
	delete from PhanCong
	where IDPhanCong = @IDphancong
end
GO
/****** Object:  StoredProcedure [dbo].[XoaSinhVien]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[XoaSinhVien]
	@maSV nvarchar(10)
as
begin 
	delete from SinhVien
	where MaSinhVien = @maSV
end
GO
/****** Object:  StoredProcedure [dbo].[XoaThanhTich]    Script Date: 2023-07-11 5:26:54 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[XoaThanhTich] 
@MaTT nvarchar(10)
as
begin 
	delete from ThanhTich
	where MaThanhTich = @MaTT
end
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "n"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 268
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "s"
            Begin Extent = 
               Top = 175
               Left = 48
               Bottom = 338
               Right = 258
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "k"
            Begin Extent = 
               Top = 343
               Left = 48
               Bottom = 462
               Right = 258
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "p"
            Begin Extent = 
               Top = 462
               Left = 48
               Bottom = 625
               Right = 258
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'NHOMKHOA'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'NHOMKHOA'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "P"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "B"
            Begin Extent = 
               Top = 175
               Left = 48
               Bottom = 294
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "N"
            Begin Extent = 
               Top = 294
               Left = 48
               Bottom = 457
               Right = 252
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'PhanCongChuaThucHien'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'PhanCongChuaThucHien'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "database_principals (sys)"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 389
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ROLES'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ROLES'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "c"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cv"
            Begin Extent = 
               Top = 175
               Left = 48
               Bottom = 294
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Ap"
            Begin Extent = 
               Top = 294
               Left = 48
               Bottom = 435
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Xa"
            Begin Extent = 
               Top = 7
               Left = 290
               Bottom = 170
               Right = 484
            End
            DisplayFlags = 280
            TopColumn = 3
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VChiTietCV'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VChiTietCV'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[54] 4[7] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "pc"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "n"
            Begin Extent = 
               Top = 34
               Left = 497
               Bottom = 197
               Right = 701
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "nd"
            Begin Extent = 
               Top = 187
               Left = 47
               Bottom = 350
               Right = 241
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Ap"
            Begin Extent = 
               Top = 344
               Left = 723
               Bottom = 485
               Right = 917
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Xa"
            Begin Extent = 
               Top = 384
               Left = 85
               Bottom = 547
               Right = 279
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ChiTietPhanCong'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ChiTietPhanCong'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ChiTietPhanCong'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "P"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "B"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 102
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "nk"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 136
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VIEW_PHANCONG'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VIEW_PHANCONG'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Xa"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'view_Xa'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'view_Xa'
GO
USE [master]
GO
ALTER DATABASE [MuaHeXanh] SET  READ_WRITE 
GO
