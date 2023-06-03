Begin Transaction T1

--�Ыطs��A��identity��FK
CREATE TABLE [dbo].[FOOD_����_2](
	[FOOD_����_PK] [INT] IDENTITY(1,1) NOT NULL,
	[RECIPE_FOOD_����_FK] [nvarchar](50) NULL,
	[FOOD_NAME�����W��] [nvarchar](200) NULL,
	[FOOD_AMOUNT�����ƶq] [nvarchar](200) NULL,
	[UPDATE_USER] [nvarchar](255) NULL,
	[UPDATE_TIME] [datetime] NULL,
	CONSTRAINT FK_RECIPE_FOOD FOREIGN KEY ([RECIPE_FOOD_����_FK])
        REFERENCES [dbo].[RECIPE_����] ([RECIPE����_PK])
        ON DELETE CASCADE
        ON UPDATE CASCADE,
	CONSTRAINT PK_FOOD PRIMARY KEY CLUSTERED ([FOOD_����_PK])
) ON [PRIMARY]
GO


--�N��Ʃ�i�s��
INSERT INTO [dbo].[FOOD_����_2]
SELECT [RECIPE_FOOD_����_FK],[FOOD_NAME�����W��],[FOOD_AMOUNT�����ƶq],[UPDATE_USER],[UPDATE_TIME]  FROM [dbo].[FOOD_����]
GO

Commit Transaction T1