Should Execute this to the SQL Management Studio with a new query.

```
USE [ContractDB]
GO

/****** Object:  Table [dbo].[ContractsTable]    Script Date: 24/10/2024 5:11:48 pm ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ContractsTable](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Contact_Number] [varchar](100) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Building_Number] [varchar](100) NOT NULL,
	[Room_Number] [varchar](100) NOT NULL,
	[Status] [varchar](100) NULL,
	[Pending] [varchar](100) NOT NULL,
	[InsertedDate] [datetime] NULL,
	[IsTerminated] [bit] NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ContractsTable] ADD  DEFAULT (getdate()) FOR [InsertedDate]
GO

ALTER TABLE [dbo].[ContractsTable] ADD  DEFAULT ((0)) FOR [IsTerminated]
GO
```


