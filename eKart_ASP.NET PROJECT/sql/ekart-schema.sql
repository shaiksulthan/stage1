IF EXISTS (SELECT * FROM sys.databases WHERE name = N'ekart')
BEGIN
	DROP DATABASE ekart
	CREATE DATABASE ekart
END
ELSE
BEGIN
	CREATE DATABASE ekart
END
GO

USE ekart
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cart](
	[ct_id] [int] IDENTITY(1,1) NOT NULL,
	[ct_us_id] [bigint] NULL,
	[ct_pr_id] [bigint] NULL,
 CONSTRAINT [PK_cart] PRIMARY KEY CLUSTERED 
(
	[ct_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[product]    Script Date: 8/1/2019 9:17:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[product](
	[pr_id] [bigint] IDENTITY(1,1) NOT NULL,
	[pr_title] [varchar](100) NULL,
	[pr_price] [decimal](8, 2) NULL,
	[pr_in_stock] [varchar](3) NULL,
	[pr_date_of_expiry] [date] NULL,
	[pr_category] [varchar](45) NULL,
	[pr_free_delivery] [varchar](3) NULL,
 CONSTRAINT [PK_product] PRIMARY KEY CLUSTERED 
(
	[pr_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[user]    Script Date: 8/1/2019 9:17:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[user](
	[us_id] [bigint] IDENTITY(1,1) NOT NULL,
	[us_name] [varchar](60) NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[us_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[cart]  WITH CHECK ADD  CONSTRAINT [ct_pr_fk] FOREIGN KEY([ct_pr_id])
REFERENCES [dbo].[product] ([pr_id])
GO
ALTER TABLE [dbo].[cart] CHECK CONSTRAINT [ct_pr_fk]
GO
ALTER TABLE [dbo].[cart]  WITH CHECK ADD  CONSTRAINT [ct_us_fk] FOREIGN KEY([ct_us_id])
REFERENCES [dbo].[user] ([us_id])
GO
ALTER TABLE [dbo].[cart] CHECK CONSTRAINT [ct_us_fk]
GO
