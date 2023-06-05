Begin Transaction T1

--創建新表，有identity跟FK
CREATE TABLE [dbo].[FOOD_食材_2](
	[FOOD_食材_PK] [INT] IDENTITY(1,1) NOT NULL,
	[RECIPE_FOOD_食譜_FK] [nvarchar](50) NULL,
	[FOOD_NAME食材名稱] [nvarchar](200) NULL,
	[FOOD_AMOUNT食材數量] [nvarchar](200) NULL,
	[UPDATE_USER] [nvarchar](255) NULL,
	[UPDATE_TIME] [datetime] NULL,
	CONSTRAINT FK_RECIPE_FOOD FOREIGN KEY ([RECIPE_FOOD_食譜_FK])
        REFERENCES [dbo].[RECIPE_食譜] ([RECIPE食譜_PK])
        ON DELETE CASCADE
        ON UPDATE CASCADE,
	CONSTRAINT PK_FOOD PRIMARY KEY CLUSTERED ([FOOD_食材_PK])
) ON [PRIMARY]
GO


--將資料放進新表
INSERT INTO [dbo].[FOOD_食材_2]
SELECT [RECIPE_FOOD_食譜_FK],[FOOD_NAME食材名稱],[FOOD_AMOUNT食材數量],[UPDATE_USER],[UPDATE_TIME]  FROM [dbo].[FOOD_食材]
GO

Commit Transaction T1