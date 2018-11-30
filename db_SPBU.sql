USE [db_SPBU]
GO
/****** Object:  Table [dbo].[tbl_bbm]    Script Date: 30/11/2018 19:07:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_bbm](
	[id_bbm] [varchar](15) NOT NULL,
	[nama_bbm] [varchar](20) NULL,
	[harga] [bigint] NULL,
 CONSTRAINT [PK_tbl_bbm] PRIMARY KEY CLUSTERED 
(
	[id_bbm] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_penerimaan]    Script Date: 30/11/2018 19:07:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_penerimaan](
	[id_penerimaan] [int] IDENTITY(1,1) NOT NULL,
	[id_bbm] [varchar](15) NULL,
	[tgl_penerimaan] [date] NULL,
	[jumlah_penerimaan] [bigint] NULL,
 CONSTRAINT [PK_tbl_pemasukan] PRIMARY KEY CLUSTERED 
(
	[id_penerimaan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_pengeluaran]    Script Date: 30/11/2018 19:07:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_pengeluaran](
	[id_pengeluaran] [varchar](15) NOT NULL,
	[deskripsi] [varchar](20) NULL,
	[jumlah_pengeluaran] [bigint] NULL,
	[tgl_pengeluaran] [date] NULL,
 CONSTRAINT [PK_tbl_pengeluaran] PRIMARY KEY CLUSTERED 
(
	[id_pengeluaran] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_pengguna]    Script Date: 30/11/2018 19:07:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_pengguna](
	[nama_pengguna] [varchar](50) NOT NULL,
	[kata_sandi] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_pengguna] PRIMARY KEY CLUSTERED 
(
	[nama_pengguna] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_pompa]    Script Date: 30/11/2018 19:07:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_pompa](
	[id_pompa] [varchar](15) NOT NULL,
	[nama_pompa] [varchar](50) NULL,
	[id_bbm] [varchar](15) NULL,
 CONSTRAINT [PK_tbl_pompa] PRIMARY KEY CLUSTERED 
(
	[id_pompa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_stock]    Script Date: 30/11/2018 19:07:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_stock](
	[id_stok] [int] IDENTITY(1,1) NOT NULL,
	[id_bbm] [varchar](15) NULL,
	[tgl_stok] [date] NULL,
	[jumlah_stok] [bigint] NULL,
 CONSTRAINT [PK_tbl_stock] PRIMARY KEY CLUSTERED 
(
	[id_stok] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_transaksi]    Script Date: 30/11/2018 19:07:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_transaksi](
	[id_transaksi] [varchar](15) NOT NULL,
	[tgl_transaksi] [date] NULL,
 CONSTRAINT [PK_tbl_transaksi] PRIMARY KEY CLUSTERED 
(
	[id_transaksi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_transaksi_detail]    Script Date: 30/11/2018 19:07:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_transaksi_detail](
	[id_transaksi_detail] [int] IDENTITY(1,1) NOT NULL,
	[id_transaksi] [varchar](15) NULL,
	[id_pompa] [varchar](15) NULL,
	[id_bbm] [varchar](15) NULL,
	[stand_meter_awal] [bigint] NULL,
	[stand_meter_akhir] [bigint] NULL,
	[harga] [bigint] NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[id_transaksi_detail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[vpenerimaan]    Script Date: 30/11/2018 19:07:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vpenerimaan]
AS
SELECT        dbo.tbl_penerimaan.id_penerimaan, dbo.tbl_bbm.nama_bbm, dbo.tbl_penerimaan.tgl_penerimaan, dbo.tbl_penerimaan.jumlah_penerimaan
FROM            dbo.tbl_bbm INNER JOIN
                         dbo.tbl_penerimaan ON dbo.tbl_bbm.id_bbm = dbo.tbl_penerimaan.id_bbm

GO
/****** Object:  View [dbo].[vpompa]    Script Date: 30/11/2018 19:07:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vpompa]
AS
SELECT        dbo.tbl_pompa.id_pompa, dbo.tbl_pompa.nama_pompa, dbo.tbl_bbm.nama_bbm
FROM            dbo.tbl_bbm INNER JOIN
                         dbo.tbl_pompa ON dbo.tbl_bbm.id_bbm = dbo.tbl_pompa.id_bbm

GO
/****** Object:  View [dbo].[vstock]    Script Date: 30/11/2018 19:07:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vstock]
AS
SELECT        dbo.tbl_stock.id_stok, dbo.tbl_stock.id_bbm, dbo.tbl_bbm.nama_bbm, dbo.tbl_stock.tgl_stok, dbo.tbl_stock.jumlah_stok, dbo.tbl_bbm.harga
FROM            dbo.tbl_bbm INNER JOIN
                         dbo.tbl_stock ON dbo.tbl_bbm.id_bbm = dbo.tbl_stock.id_bbm

GO
/****** Object:  View [dbo].[vtransaksi]    Script Date: 30/11/2018 19:07:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vtransaksi]
AS
SELECT        dbo.tbl_transaksi.id_transaksi, dbo.tbl_transaksi.tgl_transaksi, dbo.tbl_transaksi_detail.id_transaksi_detail, dbo.tbl_transaksi_detail.id_pompa, dbo.tbl_pompa.nama_pompa, dbo.tbl_transaksi_detail.id_bbm, 
                         dbo.tbl_bbm.nama_bbm, dbo.tbl_transaksi_detail.stand_meter_awal, dbo.tbl_transaksi_detail.stand_meter_akhir, dbo.tbl_transaksi_detail.harga, 
                         dbo.tbl_transaksi_detail.stand_meter_akhir - dbo.tbl_transaksi_detail.stand_meter_awal AS total
FROM            dbo.tbl_bbm INNER JOIN
                         dbo.tbl_pompa ON dbo.tbl_bbm.id_bbm = dbo.tbl_pompa.id_bbm INNER JOIN
                         dbo.tbl_transaksi_detail ON dbo.tbl_bbm.id_bbm = dbo.tbl_transaksi_detail.id_bbm AND dbo.tbl_pompa.id_pompa = dbo.tbl_transaksi_detail.id_pompa INNER JOIN
                         dbo.tbl_transaksi ON dbo.tbl_transaksi_detail.id_transaksi = dbo.tbl_transaksi.id_transaksi

GO
ALTER TABLE [dbo].[tbl_penerimaan]  WITH CHECK ADD  CONSTRAINT [FK_tbl_penerimaan_tbl_bbm] FOREIGN KEY([id_bbm])
REFERENCES [dbo].[tbl_bbm] ([id_bbm])
GO
ALTER TABLE [dbo].[tbl_penerimaan] CHECK CONSTRAINT [FK_tbl_penerimaan_tbl_bbm]
GO
ALTER TABLE [dbo].[tbl_pompa]  WITH CHECK ADD  CONSTRAINT [FK_tbl_pompa_tbl_bbm] FOREIGN KEY([id_bbm])
REFERENCES [dbo].[tbl_bbm] ([id_bbm])
GO
ALTER TABLE [dbo].[tbl_pompa] CHECK CONSTRAINT [FK_tbl_pompa_tbl_bbm]
GO
ALTER TABLE [dbo].[tbl_stock]  WITH CHECK ADD  CONSTRAINT [FK_tbl_stock_tbl_bbm] FOREIGN KEY([id_bbm])
REFERENCES [dbo].[tbl_bbm] ([id_bbm])
GO
ALTER TABLE [dbo].[tbl_stock] CHECK CONSTRAINT [FK_tbl_stock_tbl_bbm]
GO
ALTER TABLE [dbo].[tbl_transaksi_detail]  WITH CHECK ADD  CONSTRAINT [FK_tbl_transaksi_detail_tbl_bbm] FOREIGN KEY([id_bbm])
REFERENCES [dbo].[tbl_bbm] ([id_bbm])
GO
ALTER TABLE [dbo].[tbl_transaksi_detail] CHECK CONSTRAINT [FK_tbl_transaksi_detail_tbl_bbm]
GO
ALTER TABLE [dbo].[tbl_transaksi_detail]  WITH CHECK ADD  CONSTRAINT [FK_tbl_transaksi_detail_tbl_pompa] FOREIGN KEY([id_pompa])
REFERENCES [dbo].[tbl_pompa] ([id_pompa])
GO
ALTER TABLE [dbo].[tbl_transaksi_detail] CHECK CONSTRAINT [FK_tbl_transaksi_detail_tbl_pompa]
GO
ALTER TABLE [dbo].[tbl_transaksi_detail]  WITH CHECK ADD  CONSTRAINT [FK_tbl_transaksi_detail_tbl_transaksi] FOREIGN KEY([id_transaksi])
REFERENCES [dbo].[tbl_transaksi] ([id_transaksi])
GO
ALTER TABLE [dbo].[tbl_transaksi_detail] CHECK CONSTRAINT [FK_tbl_transaksi_detail_tbl_transaksi]
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
         Begin Table = "tbl_bbm"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 119
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_penerimaan"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 440
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vpenerimaan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vpenerimaan'
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
         Begin Table = "tbl_bbm"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 187
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_pompa"
            Begin Extent = 
               Top = 46
               Left = 354
               Bottom = 214
               Right = 524
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vpompa'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vpompa'
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
         Begin Table = "tbl_bbm"
            Begin Extent = 
               Top = 22
               Left = 322
               Bottom = 135
               Right = 492
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_stock"
            Begin Extent = 
               Top = 49
               Left = 583
               Bottom = 179
               Right = 753
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vstock'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vstock'
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
         Begin Table = "tbl_bbm"
            Begin Extent = 
               Top = 213
               Left = 763
               Bottom = 326
               Right = 933
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_pompa"
            Begin Extent = 
               Top = 128
               Left = 232
               Bottom = 241
               Right = 402
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_transaksi_detail"
            Begin Extent = 
               Top = 28
               Left = 493
               Bottom = 212
               Right = 678
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_transaksi"
            Begin Extent = 
               Top = 99
               Left = 940
               Bottom = 195
               Right = 1110
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
         Table = 1920
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vtransaksi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vtransaksi'
GO
