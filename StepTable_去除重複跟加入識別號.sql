
Begin Transaction

--1. 建立有identity的新表 create
USE [iSpanDataBaseICook]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[STEP_步驟列表_2](
	[STEP_步驟_PK] [INT] IDENTITY(1,1) NOT NULL,
	[RECIPE_STEP_食譜_FK] [nvarchar](50) NULL,
	[STEP_DESCRIPTION步驟說明] [nvarchar](300) NULL,
	[STEP_DESCRIPTION_PICTURE步驟附圖] [nvarchar](max) NULL,
	[UPDATE_USER] [nvarchar](255) NULL,
	[UPDATE_TIME] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

--2. 把資料傳到新表
INSERT INTO [dbo].[STEP_步驟列表_2] 
SELECT * FROM [dbo].[STEP_步驟列表]
GO
--3. 刪除新表中重複的資料
DELETE [dbo].[STEP_步驟列表_2] where [STEP_步驟_PK] NOT IN (Select Max([STEP_步驟_PK]) From [dbo].[STEP_步驟列表_2] Group By [STEP_DESCRIPTION步驟說明])
GO
--4. 重新編號。建新表
CREATE TABLE [dbo].[STEP_步驟列表_3](
	[STEP_步驟_PK] [INT] IDENTITY(1,1) NOT NULL,
	[RECIPE_STEP_食譜_FK] [nvarchar](50) NULL,
	[STEP_DESCRIPTION步驟說明] [nvarchar](300) NULL,
	[STEP_DESCRIPTION_PICTURE步驟附圖] [nvarchar](max) NULL,
	[UPDATE_USER] [nvarchar](255) NULL,
	[UPDATE_TIME] [datetime] NULL,
	CONSTRAINT FK_RECIPE_STEP FOREIGN KEY ([RECIPE_STEP_食譜_FK])
        REFERENCES [dbo].[RECIPE_食譜] ([RECIPE食譜_PK])
        ON DELETE CASCADE
        ON UPDATE CASCADE,
	CONSTRAINT PK_STEP PRIMARY KEY CLUSTERED ([STEP_步驟_PK])
)ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

--將資料傳入到新表
INSERT INTO [dbo].[STEP_步驟列表_3] 
SELECT [RECIPE_STEP_食譜_FK],[STEP_DESCRIPTION步驟說明],[STEP_DESCRIPTION_PICTURE步驟附圖],[UPDATE_USER],[UPDATE_TIME]  FROM [dbo].[STEP_步驟列表_2]
GO
Commit Transaction 


