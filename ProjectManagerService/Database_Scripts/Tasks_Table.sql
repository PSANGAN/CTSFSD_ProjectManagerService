USE [CTSFullStack]
GO

/****** Object:  Table [dbo].[Tasks]    Script Date: 7/6/2019 2:51:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tasks](
	[TaskID] [int] IDENTITY(1,1) NOT NULL,
	[ParentTaskID] [int] NULL,
	[ProjectID] [int] NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
	[Priority] [int] NOT NULL,
	[Status] [bit] NOT NULL,
	[TaskName] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Tasks1] PRIMARY KEY CLUSTERED 
(
	[TaskID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Tasks]  WITH CHECK ADD  CONSTRAINT [FK_Tasks_ParentTasks] FOREIGN KEY([ParentTaskID])
REFERENCES [dbo].[ParentTasks] ([ParentTaskID])
GO

ALTER TABLE [dbo].[Tasks] CHECK CONSTRAINT [FK_Tasks_ParentTasks]
GO


