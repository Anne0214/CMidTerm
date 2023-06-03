
Begin Transaction

--1. �إߦ�identity���s�� create
USE [iSpanDataBaseICook]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[STEP_�B�J�C��_2](
	[STEP_�B�J_PK] [INT] IDENTITY(1,1) NOT NULL,
	[RECIPE_STEP_����_FK] [nvarchar](50) NULL,
	[STEP_DESCRIPTION�B�J����] [nvarchar](300) NULL,
	[STEP_DESCRIPTION_PICTURE�B�J����] [nvarchar](max) NULL,
	[UPDATE_USER] [nvarchar](255) NULL,
	[UPDATE_TIME] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

--2. ���ƶǨ�s��
INSERT INTO [dbo].[STEP_�B�J�C��_2] 
SELECT * FROM [dbo].[STEP_�B�J�C��]
GO
--3. �R���s�����ƪ����
DELETE [dbo].[STEP_�B�J�C��_2] where [STEP_�B�J_PK] NOT IN (Select Max([STEP_�B�J_PK]) From [dbo].[STEP_�B�J�C��_2] Group By [STEP_DESCRIPTION�B�J����])
GO
--4. ���s�s���C�طs��
CREATE TABLE [dbo].[STEP_�B�J�C��_3](
	[STEP_�B�J_PK] [INT] IDENTITY(1,1) NOT NULL,
	[RECIPE_STEP_����_FK] [nvarchar](50) NULL,
	[STEP_DESCRIPTION�B�J����] [nvarchar](300) NULL,
	[STEP_DESCRIPTION_PICTURE�B�J����] [nvarchar](max) NULL,
	[UPDATE_USER] [nvarchar](255) NULL,
	[UPDATE_TIME] [datetime] NULL,
	CONSTRAINT FK_RECIPE_STEP FOREIGN KEY ([RECIPE_STEP_����_FK])
        REFERENCES [dbo].[RECIPE_����] ([RECIPE����_PK])
        ON DELETE CASCADE
        ON UPDATE CASCADE,
	CONSTRAINT PK_STEP PRIMARY KEY CLUSTERED ([STEP_�B�J_PK])
)ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

--�N��ƶǤJ��s��
INSERT INTO [dbo].[STEP_�B�J�C��_3] 
SELECT [RECIPE_STEP_����_FK],[STEP_DESCRIPTION�B�J����],[STEP_DESCRIPTION_PICTURE�B�J����],[UPDATE_USER],[UPDATE_TIME]  FROM [dbo].[STEP_�B�J�C��_2]
GO
Commit Transaction 


