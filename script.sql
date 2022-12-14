create database Cosmetic
go
USE [Cosmetic]
GO
ALTER TABLE [dbo].[SanPham] DROP CONSTRAINT [FK__SanPham__MaL__4222D4EF]
GO
ALTER TABLE [dbo].[SanPham] DROP CONSTRAINT [FK__SanPham__MaH__412EB0B6]
GO
ALTER TABLE [dbo].[HoaDon] DROP CONSTRAINT [FK__HoaDon__MaNV__440B1D61]
GO
ALTER TABLE [dbo].[HoaDon] DROP CONSTRAINT [FK__HoaDon__MaKH__4316F928]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 5/12/2022 4:28:38 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SanPham]') AND type in (N'U'))
DROP TABLE [dbo].[SanPham]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 5/12/2022 4:28:38 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NhanVien]') AND type in (N'U'))
DROP TABLE [dbo].[NhanVien]
GO
/****** Object:  Table [dbo].[Loai]    Script Date: 5/12/2022 4:28:38 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Loai]') AND type in (N'U'))
DROP TABLE [dbo].[Loai]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 5/12/2022 4:28:38 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KhachHang]') AND type in (N'U'))
DROP TABLE [dbo].[KhachHang]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 5/12/2022 4:28:38 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HoaDon]') AND type in (N'U'))
DROP TABLE [dbo].[HoaDon]
GO
/****** Object:  Table [dbo].[Hang]    Script Date: 5/12/2022 4:28:38 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Hang]') AND type in (N'U'))
DROP TABLE [dbo].[Hang]
GO
/****** Object:  Table [dbo].[Hang]    Script Date: 5/12/2022 4:28:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hang](
	[MaH] [char](10) NOT NULL,
	[TenHang] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 5/12/2022 4:28:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [char](10) NOT NULL,
	[MaNV] [char](10) NOT NULL,
	[MaKH] [char](10) NOT NULL,
	[Price] [int] NULL,
	[Ngay] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 5/12/2022 4:28:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [char](10) NOT NULL,
	[Hoten] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[SDT] [char](100) NOT NULL,
	[NgaySinh] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loai]    Script Date: 5/12/2022 4:28:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loai](
	[MaL] [char](10) NOT NULL,
	[TenL] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 5/12/2022 4:28:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [char](10) NOT NULL,
	[Hoten] [nvarchar](100) NOT NULL,
	[Diachi] [nvarchar](100) NOT NULL,
	[SDT] [char](20) NOT NULL,
	[Ngaysinh] [datetime] NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 5/12/2022 4:28:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [char](10) NOT NULL,
	[TenSP] [char](100) NOT NULL,
	[MaH] [char](10) NOT NULL,
	[MaL] [char](10) NOT NULL,
	[Price] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Hang] ([MaH], [TenHang]) VALUES (N'H01       ', N'VALMONT')
INSERT [dbo].[Hang] ([MaH], [TenHang]) VALUES (N'H02       ', N'CORTHE')
INSERT [dbo].[Hang] ([MaH], [TenHang]) VALUES (N'H03       ', N'DIOR')
INSERT [dbo].[Hang] ([MaH], [TenHang]) VALUES (N'H04       ', N'LA MER')
INSERT [dbo].[Hang] ([MaH], [TenHang]) VALUES (N'H05       ', N'PESTLO')
INSERT [dbo].[Hang] ([MaH], [TenHang]) VALUES (N'H06       ', N'OLAY')
INSERT [dbo].[Hang] ([MaH], [TenHang]) VALUES (N'H07       ', N'MUJI')
GO
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [MaKH], [Price], [Ngay]) VALUES (N'HD01      ', N'MaNV01    ', N'MaKH01    ', 100000, CAST(N'2020-02-10T00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [MaKH], [Price], [Ngay]) VALUES (N'HD02      ', N'MaNV02    ', N'MaKH02    ', 200000, CAST(N'2022-05-10T00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [MaKH], [Price], [Ngay]) VALUES (N'HD03      ', N'MaNV03    ', N'MaKH03    ', 300000, CAST(N'2021-03-01T00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [MaKH], [Price], [Ngay]) VALUES (N'HD04      ', N'MaNV01    ', N'MaKH04    ', 250000, CAST(N'2021-04-16T00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [MaKH], [Price], [Ngay]) VALUES (N'HD05      ', N'MaNV02    ', N'MaKH05    ', 1100000, CAST(N'2022-06-21T00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [MaKH], [Price], [Ngay]) VALUES (N'HD06      ', N'MaNV04    ', N'MaKH06    ', 190000, CAST(N'2022-07-30T00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [MaKH], [Price], [Ngay]) VALUES (N'HD07      ', N'MaNV01    ', N'MaKH07    ', 500000, CAST(N'2022-08-10T00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [MaKH], [Price], [Ngay]) VALUES (N'HD08      ', N'MaNV02    ', N'MaKH08    ', 308000, CAST(N'2022-09-12T00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [MaKH], [Price], [Ngay]) VALUES (N'HD09      ', N'MaNV01    ', N'MaKH09    ', 439999, CAST(N'2022-10-22T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[KhachHang] ([MaKH], [Hoten], [DiaChi], [SDT], [NgaySinh]) VALUES (N'MaKH01    ', N' Ðồng Quốc Tiến', N'26A Lý 
Thường Kiệt,Quận 2 ,TP Hồ Chí Minh', N'0123456778                                                                                          ', CAST(N'1972-07-20T00:00:00.000' AS DateTime))
INSERT [dbo].[KhachHang] ([MaKH], [Hoten], [DiaChi], [SDT], [NgaySinh]) VALUES (N'MaKH02    ', N' Huỳnh Thị Anh Thý', N'36/27 
Nguyễn Vãn Lượngng,Quận Gò Vấp ,TP Hồ Chí 
Minh', N'0671839302                                                                                          ', CAST(N'1991-11-02T00:00:00.000' AS DateTime))
INSERT [dbo].[KhachHang] ([MaKH], [Hoten], [DiaChi], [SDT], [NgaySinh]) VALUES (N'MaKH03    ', N' Nguyễn Ngọc Giang', N'Ký túc 
Xá lam Sơn, Quận Gò Vấp ,TP Hồ Chí Minh', N'0999993456                                                                                          ', CAST(N'1945-01-01T00:00:00.000' AS DateTime))
INSERT [dbo].[KhachHang] ([MaKH], [Hoten], [DiaChi], [SDT], [NgaySinh]) VALUES (N'MaKH04    ', N' Bùi Ngọc ', N' Nguyễn 
Kiệm,Quận 6,TP Hồ Chí Minh', N'01346678899                                                                                         ', CAST(N'1937-01-11T00:00:00.000' AS DateTime))
INSERT [dbo].[KhachHang] ([MaKH], [Hoten], [DiaChi], [SDT], [NgaySinh]) VALUES (N'MaKH05    ', N' Dương Thúy', N'Chợ Gò Vấp ,TP 
Hồ Chí Minh', N'0597356778                                                                                          ', CAST(N'1992-09-09T00:00:00.000' AS DateTime))
INSERT [dbo].[KhachHang] ([MaKH], [Hoten], [DiaChi], [SDT], [NgaySinh]) VALUES (N'MaKH06    ', N' Nguyễn Thủy Tiên', N' Quận Bình Tân 
,TP Hồ Chí Minh', N'0198765443                                                                                          ', CAST(N'1972-12-12T00:00:00.000' AS DateTime))
INSERT [dbo].[KhachHang] ([MaKH], [Hoten], [DiaChi], [SDT], [NgaySinh]) VALUES (N'MaKH07    ', N' Ðồng Quốc Tiến', N'27B Âu 
Cõ,Quận 5 ,TP Hồ Chí Minh', N'0945566677                                                                                          ', CAST(N'1972-12-29T00:00:00.000' AS DateTime))
INSERT [dbo].[KhachHang] ([MaKH], [Hoten], [DiaChi], [SDT], [NgaySinh]) VALUES (N'MaKH08    ', N' Trần Quốc Tuấn', N'26A Nguyễn 
Du,Quận 6 ,TP Hồ Chí Minh', N'0122890378                                                                                          ', CAST(N'1976-07-27T00:00:00.000' AS DateTime))
INSERT [dbo].[KhachHang] ([MaKH], [Hoten], [DiaChi], [SDT], [NgaySinh]) VALUES (N'MaKH09    ', N' Lương Thế Thành', N'26A Lý 
Thái Sõn,Quận 2 ,TP Hồ Chí Minh', N'059156778                                                                                           ', CAST(N'1971-07-29T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Loai] ([MaL], [TenL]) VALUES (N'L01       ', N'Nuoc Tay Trang')
INSERT [dbo].[Loai] ([MaL], [TenL]) VALUES (N'L02       ', N'Sua Rua Mat')
INSERT [dbo].[Loai] ([MaL], [TenL]) VALUES (N'L03       ', N'Tooner')
INSERT [dbo].[Loai] ([MaL], [TenL]) VALUES (N'L04       ', N'Kem Duong Am')
INSERT [dbo].[Loai] ([MaL], [TenL]) VALUES (N'L05       ', N'Kem Chong Nang')
INSERT [dbo].[Loai] ([MaL], [TenL]) VALUES (N'L06       ', N'Son')
GO
INSERT [dbo].[NhanVien] ([MaNV], [Hoten], [Diachi], [SDT], [Ngaysinh], [GioiTinh]) VALUES (N'MaNV01    ', N'Le Thái Trần', N'20 Le 
Duẩn,Quận Gò Vấp,TPHCM', N'0165538970          ', CAST(N'1980-04-24T00:00:00.000' AS DateTime), N'Nữ')
INSERT [dbo].[NhanVien] ([MaNV], [Hoten], [Diachi], [SDT], [Ngaysinh], [GioiTinh]) VALUES (N'MaNV010   ', N'Le Thành Ân', N'56 Nguyễn Vãn 
Nghi,Quận 4,TPHCM', N'096234562           ', CAST(N'1981-12-24T00:00:00.000' AS DateTime), N'Nam')
INSERT [dbo].[NhanVien] ([MaNV], [Hoten], [Diachi], [SDT], [Ngaysinh], [GioiTinh]) VALUES (N'MaNV02    ', N'Ðồng Quốc Cỏ', N'26B Tân 
Phú,Quận Tân Bình,TPHCM', N'0934179463          ', CAST(N'1982-07-14T00:00:00.000' AS DateTime), N'Nam')
INSERT [dbo].[NhanVien] ([MaNV], [Hoten], [Diachi], [SDT], [Ngaysinh], [GioiTinh]) VALUES (N'MaNV03    ', N'Nguyễn Tuấn Anh', N'12/34 
Nguyễn Oanh,Quận Gò Vấp,TPHCM', N'0126356784          ', CAST(N'1983-09-11T00:00:00.000' AS DateTime), N'Nam')
INSERT [dbo].[NhanVien] ([MaNV], [Hoten], [Diachi], [SDT], [Ngaysinh], [GioiTinh]) VALUES (N'MaNV04    ', N'Nguyễn Thu Hồng', N'01 Lý 
Thường Kiệt,Quận 12,TPHCM', N'0188534678          ', CAST(N'1980-11-25T00:00:00.000' AS DateTime), N'Nữ')
INSERT [dbo].[NhanVien] ([MaNV], [Hoten], [Diachi], [SDT], [Ngaysinh], [GioiTinh]) VALUES (N'MaNV05    ', N'Trần Thu Hà ', N'125 Le Hồng 
Thái,Quận 8,TPHCM', N'0165343970          ', CAST(N'1984-08-21T00:00:00.000' AS DateTime), N'Nữ')
INSERT [dbo].[NhanVien] ([MaNV], [Hoten], [Diachi], [SDT], [Ngaysinh], [GioiTinh]) VALUES (N'MaNV06    ', N'Phạm Thị Cẩm Phýợng', N'27A Le 
Thái Sõn,Quận 1,TPHCM', N'096544680           ', CAST(N'1981-09-07T00:00:00.000' AS DateTime), N'Nữ')
INSERT [dbo].[NhanVien] ([MaNV], [Hoten], [Diachi], [SDT], [Ngaysinh], [GioiTinh]) VALUES (N'MaNV07    ', N'Le Huỳnh Bảo Tôn', N'13/34 
Quang Trung,Quận 3,TPHCM', N'012258970           ', CAST(N'1983-02-21T00:00:00.000' AS DateTime), N'Nam')
INSERT [dbo].[NhanVien] ([MaNV], [Hoten], [Diachi], [SDT], [Ngaysinh], [GioiTinh]) VALUES (N'MaNV08    ', N'Nguyễn Thị Thanh Thu', N'60 
Phan Vãn Trị,Quận Tân Bình,TPHCM', N'0188521970          ', CAST(N'1983-01-10T00:00:00.000' AS DateTime), N'Nữ')
INSERT [dbo].[NhanVien] ([MaNV], [Hoten], [Diachi], [SDT], [Ngaysinh], [GioiTinh]) VALUES (N'MaNV09    ', N'Hoàng Thu Hiền', N'46/12 Hà Huy 
Hùng,Quận 9,TPHCM', N'0165633270          ', CAST(N'1984-03-11T00:00:00.000' AS DateTime), N'Nữ')
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaH], [MaL], [Price]) VALUES (N'SP01      ', N'CORTHE DERMO PROTECTION ULTRA SUN BLOCK SPF50+/PA+++                                                ', N'H02       ', N'L05       ', 500000)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaH], [MaL], [Price]) VALUES (N'SP02      ', N'Valmont Restoring Perfection SPF 50 30ml                                                            ', N'H01       ', N'L05       ', 5000000)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaH], [MaL], [Price]) VALUES (N'SP03      ', N'Dior Hydra Life Triple Impact 125ml                                                                 ', N'H03       ', N'L01       ', 500000)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaH], [MaL], [Price]) VALUES (N'SP04      ', N'Dior Dreamskin Care And Perfect 30ml                                                                ', N'H03       ', N'L04       ', 2000000)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaH], [MaL], [Price]) VALUES (N'SP05      ', N'La Mer The Treatment Lotion 100ml                                                                   ', N'H04       ', N'L03       ', 3700000)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaH], [MaL], [Price]) VALUES (N'SP06      ', N'Pestlo Safe Recipe Sun Essence SPF50 PA+++                                                          ', N'H05       ', N'L06       ', 300000)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaH], [MaL], [Price]) VALUES (N'SP07      ', N'Olay Regenerist Regenerist Micro-Sculpting Cream Night                                              ', N'H06       ', N'L04       ', 300000)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaH], [MaL], [Price]) VALUES (N'SP08      ', N'Muji Lip Cream Menthol                                                                              ', N'H07       ', N'L06       ', 100000)
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD FOREIGN KEY([MaH])
REFERENCES [dbo].[Hang] ([MaH])
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD FOREIGN KEY([MaL])
REFERENCES [dbo].[Loai] ([MaL])
GO