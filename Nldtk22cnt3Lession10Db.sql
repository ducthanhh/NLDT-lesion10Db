USE [NldtK22cnt3lession10Db]
GO
/****** Object:  Table [dbo].[NldtAccount]    Script Date: 03/07/2024 9:28:36 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NldtAccount](
	[NldtID] [int] NOT NULL,
	[NldtName] [nvarchar](50) NULL,
	[NldtPassword] [nvarchar](50) NULL,
	[NldtFullName] [nvarchar](50) NULL,
	[NldtEmail] [nvarchar](50) NULL,
	[NldtPhone] [nvarchar](50) NULL,
	[NldtActive] [bit] NULL,
 CONSTRAINT [PK_NldtAccount] PRIMARY KEY CLUSTERED 
(
	[NldtID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NldtAccount] ([NldtID], [NldtName], [NldtPassword], [NldtFullName], [NldtEmail], [NldtPhone], [NldtActive]) VALUES (1, N'duc thanh', N'12345', N'nguyen le duc ', N'thanhbt901@gmai.com', N'0975157823', 1)
GO
