USE [BanHang_Kietbntps]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 08/19/2015 23:44:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MAKH] [varchar](15) NOT NULL,
	[TENK] [nvarchar](50) NULL,
	[GIOITINH] [nvarchar](5) NULL,
	[SDT] [varchar](20) NULL,
	[DIACHI] [nvarchar](150) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MAKH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[KHACHHANG] ([MAKH], [TENK], [GIOITINH], [SDT], [DIACHI]) VALUES (N'123', N'123', N'Nam', N'123', N'4124')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENK], [GIOITINH], [SDT], [DIACHI]) VALUES (N'123123', N'sdgfgsdgsd', N'Nam', N'123123', N'sdgdsgsdg')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENK], [GIOITINH], [SDT], [DIACHI]) VALUES (N'1234', N'123', N'Nam', N'1234', N'4124')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENK], [GIOITINH], [SDT], [DIACHI]) VALUES (N'124', N'214', N'Nam', N'124', N'124')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENK], [GIOITINH], [SDT], [DIACHI]) VALUES (N'2', N'5', N'Nam', N'2', N'5')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENK], [GIOITINH], [SDT], [DIACHI]) VALUES (N'23', N'r2', N'Nam', N'23', N'234')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENK], [GIOITINH], [SDT], [DIACHI]) VALUES (N'234234234', N'324234', N'Nữ', N'234234234', N'4234324')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENK], [GIOITINH], [SDT], [DIACHI]) VALUES (N'23435', N'24', N'Nam', N'23435', N'235')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENK], [GIOITINH], [SDT], [DIACHI]) VALUES (N'24', N'4', N'Nam', N'24', N'234')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENK], [GIOITINH], [SDT], [DIACHI]) VALUES (N'2414', N'124', N'Nam', N'2414', N'4124')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENK], [GIOITINH], [SDT], [DIACHI]) VALUES (N'2423', N'2342', N'Nam', N'2423', N'234')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENK], [GIOITINH], [SDT], [DIACHI]) VALUES (N'2424', N'ewf', N'Nam', N'2424', N'ewg')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENK], [GIOITINH], [SDT], [DIACHI]) VALUES (N'3', N'5', N'Nam', N'3', N'5')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENK], [GIOITINH], [SDT], [DIACHI]) VALUES (N'32144', N'213e', N'Nam', N'32144', N'')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENK], [GIOITINH], [SDT], [DIACHI]) VALUES (N'32235', N'324', N'Nam', N'32235', N'35235')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENK], [GIOITINH], [SDT], [DIACHI]) VALUES (N'34', N'sdf4', N'Nam', N'34', N'5235')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENK], [GIOITINH], [SDT], [DIACHI]) VALUES (N'345', N'34534', N'Nam', N'345', N'43tr')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENK], [GIOITINH], [SDT], [DIACHI]) VALUES (N'42', N'24', N'Nam', N'42', N'424')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENK], [GIOITINH], [SDT], [DIACHI]) VALUES (N'423', N'f23', N'Nam', N'423', N'234')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENK], [GIOITINH], [SDT], [DIACHI]) VALUES (N'42323', N'23', N'Nam', N'42323', N'5235235')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENK], [GIOITINH], [SDT], [DIACHI]) VALUES (N'5', N'35', N'Nam', N'5', N'3')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENK], [GIOITINH], [SDT], [DIACHI]) VALUES (N'edfd', N'235', N'Nam', N'edfd', N'egge')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENK], [GIOITINH], [SDT], [DIACHI]) VALUES (N'KH01', N'Nguyễn Văn An', N'Nam', N'0963182729', N'Hà Nội')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENK], [GIOITINH], [SDT], [DIACHI]) VALUES (N'KH02', N'Bùi Thị Ánh', N'Nữ', N'01628450120', N'Hải Phòng')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENK], [GIOITINH], [SDT], [DIACHI]) VALUES (N'KH03', N'Đinh Văn Bằng', N'Nam', N'01235248260', N'TP.Hồ Chí Minh')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENK], [GIOITINH], [SDT], [DIACHI]) VALUES (N'KH04', N'Tạ Thị Cành', N'Nữ', NULL, NULL)
INSERT [dbo].[KHACHHANG] ([MAKH], [TENK], [GIOITINH], [SDT], [DIACHI]) VALUES (N'KH05', N'Nguyễn Văn Minh', N'Nam', N'0965410002', N'An Giang')
/****** Object:  Table [dbo].[LOAISANPHAM]    Script Date: 08/19/2015 23:44:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOAISANPHAM](
	[MAL] [varchar](15) NOT NULL,
	[TENL] [nvarchar](150) NULL,
	[MOTA] [nvarchar](350) NULL,
 CONSTRAINT [PK_LOAISANPHAM] PRIMARY KEY CLUSTERED 
(
	[MAL] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[LOAISANPHAM] ([MAL], [TENL], [MOTA]) VALUES (N'L1', N'ádfghjk', N'abc')
INSERT [dbo].[LOAISANPHAM] ([MAL], [TENL], [MOTA]) VALUES (N'L2', N'ádfghjk', N'abc')
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 08/19/2015 23:44:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[MASP] [varchar](15) NOT NULL,
	[TENSP] [nvarchar](150) NULL,
	[MAL] [varchar](15) NULL,
	[DONGIA] [float] NULL,
	[MOTA] [nvarchar](350) NULL,
 CONSTRAINT [PK_SANPHAM] PRIMARY KEY CLUSTERED 
(
	[MASP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MAL], [DONGIA], [MOTA]) VALUES (N'12', N'23', N'L1', 4124, N'124214')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MAL], [DONGIA], [MOTA]) VALUES (N'23', N'1224124', N'L1', 41241, N'124124')
/****** Object:  StoredProcedure [dbo].[LOAISANPHAM_Update]    Script Date: 08/19/2015 23:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 8/17/2015 9:07:41 AM
-- Project: BanHang_Kietbntps
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[LOAISANPHAM_Update]
	@MAL varchar(15),
	@TENL nvarchar(300),
	@MOTA nvarchar(700)
As
	Update [LOAISANPHAM]  Set
		[TENL] = @TENL,
		[MOTA] = @MOTA
	Where ([MAL] = @MAL)
GO
/****** Object:  StoredProcedure [dbo].[LOAISANPHAM_SelectAll]    Script Date: 08/19/2015 23:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LOAISANPHAM_SelectAll]
As
SELECT MAL  as [Mã loại]
      ,TENL  as [Tên loại]
      ,MOTA as [Mô tả]
  FROM LOAISANPHAM
GO
/****** Object:  StoredProcedure [dbo].[LOAISANPHAM_Insert]    Script Date: 08/19/2015 23:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 8/17/2015 9:07:41 AM
-- Project: BanHang_Kietbntps
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[LOAISANPHAM_Insert]
	@MAL varchar(15),
	@TENL nvarchar(300),
	@MOTA nvarchar(700)
As
	Insert Into [LOAISANPHAM]
	(
		[MAL],
		[TENL],
		[MOTA]
	)
	Values
	(
		@MAL,
		@TENL,
		@MOTA
	)
GO
/****** Object:  StoredProcedure [dbo].[LOAISANPHAM_Delete]    Script Date: 08/19/2015 23:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 8/17/2015 9:07:41 AM
-- Project: BanHang_Kietbntps
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[LOAISANPHAM_Delete]
	@MAL varchar(15)
As
	Delete [LOAISANPHAM] 
	Where  ([MAL]= @MAL)
GO
/****** Object:  StoredProcedure [dbo].[KHACHHANG_Update]    Script Date: 08/19/2015 23:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 8/17/2015 9:07:41 AM
-- Project: BanHang_Kietbntps
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[KHACHHANG_Update]
	@MAKH varchar(15),
	@TENK nvarchar(100),
	@GIOITINH nvarchar(10),
	@SDT varchar(20),
	@DIACHI nvarchar(300)
As
	Update [KHACHHANG]  Set
		[TENK] = @TENK,
		[GIOITINH] = @GIOITINH,
		[SDT] = @SDT,
		[DIACHI] = @DIACHI
	Where ([MAKH] = @MAKH)
GO
/****** Object:  StoredProcedure [dbo].[KHACHHANG_SelectAll]    Script Date: 08/19/2015 23:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHACHHANG_SelectAll]
As
SELECT MAKH as [Mã khách]
      ,TENK as [Tên khách]
      ,GIOITINH as [Giới tính]
      ,SDT as [SĐT]
      ,DIACHI as [Địa chỉ]
  FROM KHACHHANG
GO
/****** Object:  StoredProcedure [dbo].[KHACHHANG_Select]    Script Date: 08/19/2015 23:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHACHHANG_Select]
@MaKH varchar(15)
As
SELECT MAKH as [Mã khách]
      ,TENK as [Tên khách]
      ,GIOITINH as [Giới tính]
      ,SDT as [SĐT]
      ,DIACHI as [Địa chỉ]
  FROM KHACHHANG
where MAKH=@MaKH
GO
/****** Object:  StoredProcedure [dbo].[KHACHHANG_Insert]    Script Date: 08/19/2015 23:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 8/17/2015 9:07:41 AM
-- Project: BanHang_Kietbntps
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[KHACHHANG_Insert]
	@MAKH varchar(15),
	@TENK nvarchar(100),
	@GIOITINH nvarchar(10),
	@SDT varchar(20),
	@DIACHI nvarchar(300)
As
	Insert Into [KHACHHANG]
	(
		[MAKH],
		[TENK],
		[GIOITINH],
		[SDT],
		[DIACHI]
	)
	Values
	(
		@MAKH,
		@TENK,
		@GIOITINH,
		@SDT,
		@DIACHI
	)
GO
/****** Object:  StoredProcedure [dbo].[KHACHHANG_Delete]    Script Date: 08/19/2015 23:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 8/17/2015 9:07:41 AM
-- Project: BanHang_Kietbntps
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[KHACHHANG_Delete]
	@MAKH varchar(15)
As
	Delete [KHACHHANG] 
	Where  ([MAKH]= @MAKH)
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 08/19/2015 23:44:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOADON](
	[SOHOADON] [varchar](15) NOT NULL,
	[NGAYHOADON] [smalldatetime] NULL,
	[MAKH] [varchar](15) NULL,
	[NHANVIEN] [nvarchar](50) NULL,
	[GHICHU] [nvarchar](250) NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[SOHOADON] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[HOADON] ([SOHOADON], [NGAYHOADON], [MAKH], [NHANVIEN], [GHICHU]) VALUES (N'1', CAST(0xA4F90000 AS SmallDateTime), N'3', N'2', N'4')
INSERT [dbo].[HOADON] ([SOHOADON], [NGAYHOADON], [MAKH], [NHANVIEN], [GHICHU]) VALUES (N'123', CAST(0xA4F90000 AS SmallDateTime), N'123', N'123', N'123')
INSERT [dbo].[HOADON] ([SOHOADON], [NGAYHOADON], [MAKH], [NHANVIEN], [GHICHU]) VALUES (N'2', CAST(0xA4F90000 AS SmallDateTime), N'2', N'3', N'4')
INSERT [dbo].[HOADON] ([SOHOADON], [NGAYHOADON], [MAKH], [NHANVIEN], [GHICHU]) VALUES (N'213x', CAST(0xA4F90000 AS SmallDateTime), N'32144', N'r12', N'21r')
INSERT [dbo].[HOADON] ([SOHOADON], [NGAYHOADON], [MAKH], [NHANVIEN], [GHICHU]) VALUES (N'23', CAST(0xA4F90000 AS SmallDateTime), N'124', N'123', N'124')
INSERT [dbo].[HOADON] ([SOHOADON], [NGAYHOADON], [MAKH], [NHANVIEN], [GHICHU]) VALUES (N'2342', CAST(0xA4F90000 AS SmallDateTime), N'42', N'42', N'42')
INSERT [dbo].[HOADON] ([SOHOADON], [NGAYHOADON], [MAKH], [NHANVIEN], [GHICHU]) VALUES (N'235fdgdfger', CAST(0xA4F90000 AS SmallDateTime), N'345', N'revere', N'revre3')
INSERT [dbo].[HOADON] ([SOHOADON], [NGAYHOADON], [MAKH], [NHANVIEN], [GHICHU]) VALUES (N'24', CAST(0xA4F90000 AS SmallDateTime), N'234234234', N'234', N'34')
INSERT [dbo].[HOADON] ([SOHOADON], [NGAYHOADON], [MAKH], [NHANVIEN], [GHICHU]) VALUES (N'24fdsf', CAST(0xA4F90000 AS SmallDateTime), N'2424', N'sv', N'4')
INSERT [dbo].[HOADON] ([SOHOADON], [NGAYHOADON], [MAKH], [NHANVIEN], [GHICHU]) VALUES (N'2fdgergerherh', CAST(0xA4F90000 AS SmallDateTime), N'345', N'rherh', N'herher')
INSERT [dbo].[HOADON] ([SOHOADON], [NGAYHOADON], [MAKH], [NHANVIEN], [GHICHU]) VALUES (N'2sfs', CAST(0xA4F90000 AS SmallDateTime), N'423', N'fw', N'34')
INSERT [dbo].[HOADON] ([SOHOADON], [NGAYHOADON], [MAKH], [NHANVIEN], [GHICHU]) VALUES (N'32', CAST(0xA4F90000 AS SmallDateTime), N'2414', N'123', N'123')
INSERT [dbo].[HOADON] ([SOHOADON], [NGAYHOADON], [MAKH], [NHANVIEN], [GHICHU]) VALUES (N'324234', CAST(0xA4F90000 AS SmallDateTime), N'edfd', N'34', N'234')
INSERT [dbo].[HOADON] ([SOHOADON], [NGAYHOADON], [MAKH], [NHANVIEN], [GHICHU]) VALUES (N'3242re', CAST(0xA4F90000 AS SmallDateTime), N'34', N't3', N'ưt3')
INSERT [dbo].[HOADON] ([SOHOADON], [NGAYHOADON], [MAKH], [NHANVIEN], [GHICHU]) VALUES (N'32432432', CAST(0xA4F90000 AS SmallDateTime), N'2423', N'23t23t32', N'4234')
INSERT [dbo].[HOADON] ([SOHOADON], [NGAYHOADON], [MAKH], [NHANVIEN], [GHICHU]) VALUES (N'3423t2', CAST(0xA4F90000 AS SmallDateTime), N'32235', N'3t3t', N'3t3t')
INSERT [dbo].[HOADON] ([SOHOADON], [NGAYHOADON], [MAKH], [NHANVIEN], [GHICHU]) VALUES (N'34342fdfsd', CAST(0xA4F90000 AS SmallDateTime), N'23435', N'fewwfwe', N'sfe')
INSERT [dbo].[HOADON] ([SOHOADON], [NGAYHOADON], [MAKH], [NHANVIEN], [GHICHU]) VALUES (N'4', CAST(0xA4F90000 AS SmallDateTime), N'5', N'34', N'5')
INSERT [dbo].[HOADON] ([SOHOADON], [NGAYHOADON], [MAKH], [NHANVIEN], [GHICHU]) VALUES (N'dfsef', CAST(0xA4F90000 AS SmallDateTime), N'34', N'ừew', N'423')
INSERT [dbo].[HOADON] ([SOHOADON], [NGAYHOADON], [MAKH], [NHANVIEN], [GHICHU]) VALUES (N'sdf324dsf', CAST(0xA4F90000 AS SmallDateTime), N'34', N'few', N'34')
INSERT [dbo].[HOADON] ([SOHOADON], [NGAYHOADON], [MAKH], [NHANVIEN], [GHICHU]) VALUES (N'uqe223', CAST(0xA4F90000 AS SmallDateTime), N'42323', N'ử2423', N'4234')
/****** Object:  StoredProcedure [dbo].[SANPHAM_Update]    Script Date: 08/19/2015 23:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 8/17/2015 9:07:40 AM
-- Project: BanHang_Kietbntps
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[SANPHAM_Update]
	@MASP varchar(15),
	@TENSP nvarchar(300),
	@MAL varchar(15),
	@DONGIA float,
	@MOTA nvarchar(700)
As
	Update [SANPHAM]  Set
		[TENSP] = @TENSP,
		[MAL] = @MAL,
		[DONGIA] = @DONGIA,
		[MOTA] = @MOTA
	Where ([MASP] = @MASP)
GO
/****** Object:  StoredProcedure [dbo].[SANPHAM_SelectAll]    Script Date: 08/19/2015 23:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SANPHAM_SelectAll]
As
SELECT MASP as [Mã sản phẩm]
      ,TENSP  as [Tên sản phẩm]
      ,sanpham.MAL  as [Mã loại]
      ,TENL  as [Tên loại]
      ,DONGIA  as [Đơn giá]
      ,sanpham.MOTA  as [Mô tả]
  FROM SANPHAM,LOAISANPHAM
  where SANPHAM.MAL=LOAISANPHAM.MAL
GO
/****** Object:  StoredProcedure [dbo].[SANPHAM_Insert]    Script Date: 08/19/2015 23:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 8/17/2015 9:07:40 AM
-- Project: BanHang_Kietbntps
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[SANPHAM_Insert]
	@MASP varchar(15),
	@TENSP nvarchar(300),
	@MAL varchar(15),
	@DONGIA float,
	@MOTA nvarchar(700)
As
	Insert Into [SANPHAM]
	(
		[MASP],
		[TENSP],
		[MAL],
		[DONGIA],
		[MOTA]
	)
	Values
	(
		@MASP,
		@TENSP,
		@MAL,
		@DONGIA,
		@MOTA
	)
GO
/****** Object:  StoredProcedure [dbo].[SANPHAM_Delete]    Script Date: 08/19/2015 23:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 8/17/2015 9:07:40 AM
-- Project: BanHang_Kietbntps
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[SANPHAM_Delete]
	@MASP varchar(15)
As
	Delete [SANPHAM] 
	Where  ([MASP]= @MASP)
GO
/****** Object:  Table [dbo].[CHITIETHOADON]    Script Date: 08/19/2015 23:44:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETHOADON](
	[SOHOADON] [varchar](15) NOT NULL,
	[MASP] [varchar](15) NOT NULL,
	[SOLUONG] [int] NULL,
	[CHIETKHAU] [float] NULL,
 CONSTRAINT [PK_CHITIETHOADON] PRIMARY KEY CLUSTERED 
(
	[SOHOADON] ASC,
	[MASP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CHITIETHOADON] ([SOHOADON], [MASP], [SOLUONG], [CHIETKHAU]) VALUES (N'1', N'12', 3, 4)
INSERT [dbo].[CHITIETHOADON] ([SOHOADON], [MASP], [SOLUONG], [CHIETKHAU]) VALUES (N'2', N'12', 23, 532)
INSERT [dbo].[CHITIETHOADON] ([SOHOADON], [MASP], [SOLUONG], [CHIETKHAU]) VALUES (N'213x', N'12', 124, 412)
INSERT [dbo].[CHITIETHOADON] ([SOHOADON], [MASP], [SOLUONG], [CHIETKHAU]) VALUES (N'23', N'12', 2, 4)
INSERT [dbo].[CHITIETHOADON] ([SOHOADON], [MASP], [SOLUONG], [CHIETKHAU]) VALUES (N'2342', N'12', 2, 4)
INSERT [dbo].[CHITIETHOADON] ([SOHOADON], [MASP], [SOLUONG], [CHIETKHAU]) VALUES (N'32', N'12', 24, 42)
INSERT [dbo].[CHITIETHOADON] ([SOHOADON], [MASP], [SOLUONG], [CHIETKHAU]) VALUES (N'324234', N'12', 3, 12)
INSERT [dbo].[CHITIETHOADON] ([SOHOADON], [MASP], [SOLUONG], [CHIETKHAU]) VALUES (N'3242re', N'12', 34, 3)
INSERT [dbo].[CHITIETHOADON] ([SOHOADON], [MASP], [SOLUONG], [CHIETKHAU]) VALUES (N'32432432', N'12', 324, 2)
INSERT [dbo].[CHITIETHOADON] ([SOHOADON], [MASP], [SOLUONG], [CHIETKHAU]) VALUES (N'3423t2', N'12', 325, 32)
INSERT [dbo].[CHITIETHOADON] ([SOHOADON], [MASP], [SOLUONG], [CHIETKHAU]) VALUES (N'3423t2', N'23', 325, 32)
INSERT [dbo].[CHITIETHOADON] ([SOHOADON], [MASP], [SOLUONG], [CHIETKHAU]) VALUES (N'uqe223', N'12', 324, 324)
/****** Object:  StoredProcedure [dbo].[HOADON_Update]    Script Date: 08/19/2015 23:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 8/17/2015 9:07:40 AM
-- Project: BanHang_Kietbntps
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[HOADON_Update]
	@SOHOADON varchar(15),
	@NGAYHOADON char(10),
	@MAKH varchar(15),
	@NHANVIEN nvarchar(100),
	@GHICHU nvarchar(500)
As
	Update [HOADON]  Set
		[NGAYHOADON] = convert(smalldatetime,@NGAYHOADON,103),
		[MAKH] = @MAKH,
		[NHANVIEN] = @NHANVIEN,
		[GHICHU] = @GHICHU
	Where ([SOHOADON] = @SOHOADON)
GO
/****** Object:  StoredProcedure [dbo].[HOADON_SelectHD]    Script Date: 08/19/2015 23:44:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HOADON_SelectHD]
@SOHOADON varchar(15)
As
SELECT SOHOADON as [Số hóa đơn]
      ,convert(char(10),NGAYHOADON,103) as [Ngày hóa đơn]
      ,TENK as [Tên khách]
      ,NHANVIEN as [Nhân viên]
      ,GHICHU as [Ghi chú]
  FROM HOADON,KHACHHANG
  where HOADON.MAKH=KHACHHANG.MAKH
  and SOHOADON=@SOHOADON
GO
/****** Object:  StoredProcedure [dbo].[HOADON_SelectAll]    Script Date: 08/19/2015 23:44:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HOADON_SelectAll]

As
SELECT SOHOADON as [Số hóa đơn]
      ,convert(char(10),NGAYHOADON,103) as [Ngày hóa đơn]
      ,TENK as [Tên khách]
      ,NHANVIEN as [Nhân viên]
      ,GHICHU as [Ghi chú]
  FROM HOADON,KHACHHANG
  where HOADON.MAKH=KHACHHANG.MAKH
GO
/****** Object:  StoredProcedure [dbo].[HOADON_Insert]    Script Date: 08/19/2015 23:44:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 8/17/2015 9:07:40 AM
-- Project: BanHang_Kietbntps
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[HOADON_Insert]
	@SOHOADON varchar(15),
	@NGAYHOADON char(10),
	@MAKH varchar(15),
	@NHANVIEN nvarchar(100),
	@GHICHU nvarchar(500)
As
	Insert Into [HOADON]
	(
		[SOHOADON],
		[NGAYHOADON],
		[MAKH],
		[NHANVIEN],
		[GHICHU]
	)
	Values
	(
		@SOHOADON,
		convert(smalldatetime,@NGAYHOADON,103),
		@MAKH,
		@NHANVIEN,
		@GHICHU
	)
GO
/****** Object:  StoredProcedure [dbo].[HOADON_Delete]    Script Date: 08/19/2015 23:44:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 8/17/2015 9:07:40 AM
-- Project: BanHang_Kietbntps
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[HOADON_Delete]
	@SOHOADON varchar(15)
As
	Delete [HOADON] 
	Where  ([SOHOADON]= @SOHOADON)
GO
/****** Object:  StoredProcedure [dbo].[CHITIETHOADON_Update]    Script Date: 08/19/2015 23:44:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 8/17/2015 9:07:41 AM
-- Project: BanHang_Kietbntps
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[CHITIETHOADON_Update]
	@SOHOADON varchar(15),
	@MASP varchar(15),
	@SOLUONG int,
	@CHIETKHAU float
As
	Update [CHITIETHOADON]  Set
		[SOLUONG] = @SOLUONG,
		[CHIETKHAU] = @CHIETKHAU
	Where ([SOHOADON] = @SOHOADON and [MASP] = @MASP)
GO
/****** Object:  StoredProcedure [dbo].[CHITIETHOADON_SelectAll]    Script Date: 08/19/2015 23:44:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CHITIETHOADON_SelectAll]
@SoHoaDon varchar(15)
As
SELECT SOHOADON as [Số hóa đơn]
      ,CHITIETHOADON.MASP as [Mã sản phẩm]
      ,TENSP as [Tên sản phẩm]
      ,SOLUONG as [Số lượng]
      ,DONGIA as [Đơn giá]
      ,CHIETKHAU as [Chiết khấu]
      ,SOLUONG*DONGIA*(100-CHIETKHAU) as [Thành tiền]
  FROM CHITIETHOADON,SANPHAM
  where SOHOADON=@SoHoaDon
  and CHITIETHOADON.MASP=SANPHAM.MASP
GO
/****** Object:  StoredProcedure [dbo].[CHITIETHOADON_Insert]    Script Date: 08/19/2015 23:44:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 8/17/2015 9:07:41 AM
-- Project: BanHang_Kietbntps
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[CHITIETHOADON_Insert]
	@SOHOADON varchar(15),
	@MASP varchar(15),
	@SOLUONG int,
	@CHIETKHAU float
As
	Insert Into [CHITIETHOADON]
	(
		[SOHOADON],
		[MASP],
		[SOLUONG],
		[CHIETKHAU]
	)
	Values
	(
		@SOHOADON,
		@MASP,
		@SOLUONG,
		@CHIETKHAU
	)
GO
/****** Object:  StoredProcedure [dbo].[CHITIETHOADON_Delete]    Script Date: 08/19/2015 23:44:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--==============================================
-- Author: AutoNetCoder @ 2015
-- Create date: 8/17/2015 9:07:41 AM
-- Project: BanHang_Kietbntps
-- Description: Auto code by AutoNetCoder
-- Website: http://.www.softviet.net
--==============================================

CREATE PROCEDURE [dbo].[CHITIETHOADON_Delete]
	@SOHOADON varchar(15),
	@MASP varchar(15)
As
	Delete [CHITIETHOADON] 
	Where  ([SOHOADON]= @SOHOADON and [MASP]= @MASP)
GO
/****** Object:  ForeignKey [FK_CHITIETHOADON_HOADON]    Script Date: 08/19/2015 23:44:34 ******/
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_HOADON] FOREIGN KEY([SOHOADON])
REFERENCES [dbo].[HOADON] ([SOHOADON])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_HOADON]
GO
/****** Object:  ForeignKey [FK_CHITIETHOADON_SANPHAM]    Script Date: 08/19/2015 23:44:34 ******/
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_SANPHAM] FOREIGN KEY([MASP])
REFERENCES [dbo].[SANPHAM] ([MASP])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_SANPHAM]
GO
/****** Object:  ForeignKey [FK_HOADON_KHACHHANG]    Script Date: 08/19/2015 23:44:34 ******/
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_KHACHHANG] FOREIGN KEY([MAKH])
REFERENCES [dbo].[KHACHHANG] ([MAKH])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_KHACHHANG]
GO
/****** Object:  ForeignKey [FK_SANPHAM_LOAISANPHAM]    Script Date: 08/19/2015 23:44:34 ******/
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_SANPHAM_LOAISANPHAM] FOREIGN KEY([MAL])
REFERENCES [dbo].[LOAISANPHAM] ([MAL])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [FK_SANPHAM_LOAISANPHAM]
GO
