USE [CTSFullStack]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 7/6/2019 2:35:51 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](30) NOT NULL,
	[LastName] [varchar](30) NOT NULL,
	[EmployeeID] [varchar](6) NOT NULL,
	[ProjectID] [int] NULL,
	[TaskID] [int] NULL,
 CONSTRAINT [PK_Users1] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Projects] FOREIGN KEY([ProjectID])
REFERENCES [dbo].[Projects] ([ProjectID])
GO

ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Projects]
GO

ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Tasks] FOREIGN KEY([TaskID])
REFERENCES [dbo].[Tasks] ([TaskID])
GO

ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Tasks]
GO


