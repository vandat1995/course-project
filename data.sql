USE [QLGas]
GO
/****** Object:  Table [dbo].[ChiTietPhieuXuat]    Script Date: 20/01/2018 8:01:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietPhieuXuat](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SoPhieuXuat] [varchar](5) NOT NULL,
	[MaSanPham] [varchar](5) NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_ChiTietPhieuXuat_1] PRIMARY KEY CLUSTERED 
(
	[SoPhieuXuat] ASC,
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HangSanXuat]    Script Date: 20/01/2018 8:01:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HangSanXuat](
	[MaHangSX] [varchar](5) NOT NULL,
	[TenHangSX] [nvarchar](50) NULL,
	[DiaChiVPChinhTaiVN] [nvarchar](100) NULL,
	[SoDienThoai] [varchar](11) NULL,
 CONSTRAINT [PK_HangSanXuat] PRIMARY KEY CLUSTERED 
(
	[MaHangSX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 20/01/2018 8:01:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhach] [varchar](5) NOT NULL,
	[TenKhach] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[SoDienThoai] [varchar](11) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NoiBaoHanh]    Script Date: 20/01/2018 8:01:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NoiBaoHanh](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaHangSX] [varchar](5) NOT NULL,
	[SoTT] [varchar](5) NOT NULL,
	[TenDiemBaoHanh] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[SoDienThoai] [varchar](11) NULL,
 CONSTRAINT [PK_NoiBaoHanh] PRIMARY KEY CLUSTERED 
(
	[MaHangSX] ASC,
	[SoTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuXuat]    Script Date: 20/01/2018 8:01:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuXuat](
	[SoPhieuXuat] [varchar](5) NOT NULL,
	[MaKhach] [varchar](5) NULL,
	[NgayLapPhieu] [datetime] NULL,
 CONSTRAINT [PK_PhieuXuat] PRIMARY KEY CLUSTERED 
(
	[SoPhieuXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 20/01/2018 8:01:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSanPham] [varchar](5) NOT NULL,
	[TenSanPham] [nvarchar](100) NULL,
	[NhaSanXuat] [nvarchar](100) NULL,
	[ThoiHanBaoHanh] [int] NULL,
	[DonGia] [float] NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 20/01/2018 8:01:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [varchar](10) NOT NULL,
	[Password] [varchar](10) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[ChiTietPhieuXuat] ON 

INSERT [dbo].[ChiTietPhieuXuat] ([ID], [SoPhieuXuat], [MaSanPham], [SoLuong]) VALUES (19, N'PX001', N'SP001', 1)
INSERT [dbo].[ChiTietPhieuXuat] ([ID], [SoPhieuXuat], [MaSanPham], [SoLuong]) VALUES (20, N'PX002', N'SP002', 2)
INSERT [dbo].[ChiTietPhieuXuat] ([ID], [SoPhieuXuat], [MaSanPham], [SoLuong]) VALUES (21, N'PX003', N'SP003', 2)
INSERT [dbo].[ChiTietPhieuXuat] ([ID], [SoPhieuXuat], [MaSanPham], [SoLuong]) VALUES (23, N'PX004', N'SP004', 3)
SET IDENTITY_INSERT [dbo].[ChiTietPhieuXuat] OFF
INSERT [dbo].[HangSanXuat] ([MaHangSX], [TenHangSX], [DiaChiVPChinhTaiVN], [SoDienThoai]) VALUES (N'H0001', N'Suzuki', N'Triều Ca', N'29387491237')
INSERT [dbo].[HangSanXuat] ([MaHangSX], [TenHangSX], [DiaChiVPChinhTaiVN], [SoDienThoai]) VALUES (N'H0002', N'Yamaha', N'Tây kì', N'01231231231')
INSERT [dbo].[HangSanXuat] ([MaHangSX], [TenHangSX], [DiaChiVPChinhTaiVN], [SoDienThoai]) VALUES (N'H0003', N'Durex', N'96 Hải Thượng Lãng Ông', N'01231231312')
INSERT [dbo].[HangSanXuat] ([MaHangSX], [TenHangSX], [DiaChiVPChinhTaiVN], [SoDienThoai]) VALUES (N'H0004', N'Honda', N'69 Trần Duy Hưng', N'01691919191')
INSERT [dbo].[KhachHang] ([MaKhach], [TenKhach], [DiaChi], [SoDienThoai]) VALUES (N'KH001', N'Nguyễn Văn Đạt', N'Hồ Chí Minh', N'01675646644')
INSERT [dbo].[KhachHang] ([MaKhach], [TenKhach], [DiaChi], [SoDienThoai]) VALUES (N'KH002', N'Phong Anh Đào', N'Hà Nội', N'01664842234')
INSERT [dbo].[KhachHang] ([MaKhach], [TenKhach], [DiaChi], [SoDienThoai]) VALUES (N'KH003', N'Trần Hạo Nam', N'Đà Nắng', N'01234123123')
INSERT [dbo].[KhachHang] ([MaKhach], [TenKhach], [DiaChi], [SoDienThoai]) VALUES (N'KH004', N'Độc Cô Cầu Bại', N'Huế', N'01238712637')
SET IDENTITY_INSERT [dbo].[NoiBaoHanh] ON 

INSERT [dbo].[NoiBaoHanh] ([ID], [MaHangSX], [SoTT], [TenDiemBaoHanh], [DiaChi], [SoDienThoai]) VALUES (5, N'H0001', N'PX001', N'HCM', N'12 Lê Văn Lương', N'01231231312')
INSERT [dbo].[NoiBaoHanh] ([ID], [MaHangSX], [SoTT], [TenDiemBaoHanh], [DiaChi], [SoDienThoai]) VALUES (6, N'H0002', N'PX003', N'HN', N'32 Trần Duy Hưng', N'01230123013')
INSERT [dbo].[NoiBaoHanh] ([ID], [MaHangSX], [SoTT], [TenDiemBaoHanh], [DiaChi], [SoDienThoai]) VALUES (7, N'H0003', N'PX002', N'ĐN', N'43 Hai Bà Trưng', N'0988881231')
INSERT [dbo].[NoiBaoHanh] ([ID], [MaHangSX], [SoTT], [TenDiemBaoHanh], [DiaChi], [SoDienThoai]) VALUES (8, N'H0004', N'PX004', N'BT', N'7 Trần Hưng Đạo', N'0987654324')
SET IDENTITY_INSERT [dbo].[NoiBaoHanh] OFF
INSERT [dbo].[PhieuXuat] ([SoPhieuXuat], [MaKhach], [NgayLapPhieu]) VALUES (N'PX001', N'KH001', CAST(N'2018-01-19 00:00:00.000' AS DateTime))
INSERT [dbo].[PhieuXuat] ([SoPhieuXuat], [MaKhach], [NgayLapPhieu]) VALUES (N'PX002', N'KH002', CAST(N'2018-01-19 00:00:00.000' AS DateTime))
INSERT [dbo].[PhieuXuat] ([SoPhieuXuat], [MaKhach], [NgayLapPhieu]) VALUES (N'PX003', N'KH003', CAST(N'2018-01-19 00:00:00.000' AS DateTime))
INSERT [dbo].[PhieuXuat] ([SoPhieuXuat], [MaKhach], [NgayLapPhieu]) VALUES (N'PX004', N'KH004', CAST(N'2018-01-19 00:00:00.000' AS DateTime))
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [NhaSanXuat], [ThoiHanBaoHanh], [DonGia]) VALUES (N'SP001', N'Bếp Ga A', N'Rạng Đông', 12, 10000)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [NhaSanXuat], [ThoiHanBaoHanh], [DonGia]) VALUES (N'SP002', N'Vô cực kiếm', N'riot', 21, 3600)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [NhaSanXuat], [ThoiHanBaoHanh], [DonGia]) VALUES (N'SP003', N'Vọng âm luden', N'riot', 12, 5600)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [NhaSanXuat], [ThoiHanBaoHanh], [DonGia]) VALUES (N'SP004', N'Bình ga C', N'Bình Minh', 12, 300000)
INSERT [dbo].[Users] ([ID], [Password]) VALUES (N'admin', N'datyasuo')
ALTER TABLE [dbo].[ChiTietPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuXuat_PhieuXuat] FOREIGN KEY([SoPhieuXuat])
REFERENCES [dbo].[PhieuXuat] ([SoPhieuXuat])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat] CHECK CONSTRAINT [FK_ChiTietPhieuXuat_PhieuXuat]
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuXuat_SanPham] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat] CHECK CONSTRAINT [FK_ChiTietPhieuXuat_SanPham]
GO
ALTER TABLE [dbo].[NoiBaoHanh]  WITH CHECK ADD  CONSTRAINT [FK_NoiBaoHanh_HangSanXuat] FOREIGN KEY([MaHangSX])
REFERENCES [dbo].[HangSanXuat] ([MaHangSX])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NoiBaoHanh] CHECK CONSTRAINT [FK_NoiBaoHanh_HangSanXuat]
GO
ALTER TABLE [dbo].[NoiBaoHanh]  WITH CHECK ADD  CONSTRAINT [FK_NoiBaoHanh_PhieuXuat] FOREIGN KEY([SoTT])
REFERENCES [dbo].[PhieuXuat] ([SoPhieuXuat])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NoiBaoHanh] CHECK CONSTRAINT [FK_NoiBaoHanh_PhieuXuat]
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuat_KhachHang] FOREIGN KEY([MaKhach])
REFERENCES [dbo].[KhachHang] ([MaKhach])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK_PhieuXuat_KhachHang]
GO
