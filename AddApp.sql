USE [TataPower]
GO

/****** Object:  Table [dbo].[AddApp]    Script Date: 14-11-2021 23:35:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AddApp](
	[AppId] [int] NOT NULL,
	[AppName] [nvarchar](50) NOT NULL,
	[AppDescription] [nvarchar](max) NULL,
	[InsertedBy] [nvarchar](50) NULL,
	[InsertedOn] [datetime] NULL,
	[UpdatedBy] [nvarchar](50) NULL,
	[AppLink] [nvarchar](max) NOT NULL,
	[AppIcon] [nvarchar](max) NULL,
	[DownloadCount] [int] IDENTITY(1,1) NOT NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_AddApp] PRIMARY KEY CLUSTERED 
(
	[AppId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

