USE [CryptoBot]
GO
/****** Object:  Table [dbo].[channelNames]    Script Date: 17.05.2018 16:44:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[channelNames](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ChannelName] [nvarchar](max) NULL,
 CONSTRAINT [PK_channelNames] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 17.05.2018 16:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](max) NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[SecondName] [nvarchar](max) NULL,
	[ChatId] [int] NOT NULL,
	[subscribe] [int] NULL,
	[StartDate] [datetime] NOT NULL,
	[StartToSub] [datetime] NULL,
	[TaxId] [nvarchar](max) NULL,
	[EndToSub] [datetime] NULL,
	[chanelNamesId] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_channelNames] FOREIGN KEY([chanelNamesId])
REFERENCES [dbo].[channelNames] ([Id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_channelNames]
GO
