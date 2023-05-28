

DECLARE  @Table AS TABLE
(
    SPU NVARCHAR(100),
	SKU NVARCHAR(100),
	STOCK_NUMBER�w�s�ƶq INT,
	SOLD_NUMBER��X�ƶq INT
)

INSERT INTO @Table(SPU,SKU,STOCK_NUMBER�w�s�ƶq,SOLD_NUMBER��X�ƶq)
Select [SPU],(Select  ','+[SKU]
From [dbo].[PRODUCT_SKU_�ӫ~] as b
Where a.[SPU] = b.[SPU]
for xml path('')
) as sku,Sum([STOCK_NUMBER�w�s�ƶq])as '�w�s�ƶq',Sum([SOLD_NUMBER�w��X�ƶq]) as '�w��X�ƶq'
From [dbo].[PRODUCT_SKU_�ӫ~] as a
Group by [SPU]

SELECT * FROM @Table

Select a.SPU,[ON_SHELF�W�[���A],[CATEGORY�ӫ~�����W��],[PRODUCT_NAME�ӫ~�W��],[SALE_PRICE�P���],SKU,STOCK_NUMBER�w�s�ƶq,SOLD_NUMBER��X�ƶq
From [dbo].[PRODUCT_SPU_�ӫ~] as a
Join @Table as b
On a.SPU = b.SPU
Group By a.SPU,[ON_SHELF�W�[���A],[CATEGORY�ӫ~�����W��],[PRODUCT_NAME�ӫ~�W��],[SALE_PRICE�P���],SKU,STOCK_NUMBER�w�s�ƶq,SOLD_NUMBER��X�ƶq
go

--�إ��˵���
CREATE VIEW PRODUCT_SEARCH (SPU,SKU,STOCK_NUMBER�w�s�ƶq,SOLD_NUMBER��X�ƶq)
AS
Select [SPU],(Select  ','+[SKU]
From [dbo].[PRODUCT_SKU_�ӫ~] as b
Where a.[SPU] = b.[SPU]
for xml path('')
) as sku,Sum([STOCK_NUMBER�w�s�ƶq])as '�w�s�ƶq',Sum([SOLD_NUMBER�w��X�ƶq]) as '�w��X�ƶq'
From [dbo].[PRODUCT_SKU_�ӫ~] as a
Group by [SPU]
Go

--�d�߻y�k
Select a.SPU,[ON_SHELF�W�[���A],[CATEGORY�ӫ~�����W��],[PRODUCT_NAME�ӫ~�W��],[SALE_PRICE�P���],SKU,STOCK_NUMBER�w�s�ƶq,SOLD_NUMBER��X�ƶq
From [dbo].[PRODUCT_SPU_�ӫ~] as a
Join PRODUCT_SEARCH as b
On a.SPU = b.SPU
Group By a.SPU,[ON_SHELF�W�[���A],[CATEGORY�ӫ~�����W��],[PRODUCT_NAME�ӫ~�W��],[SALE_PRICE�P���],SKU,STOCK_NUMBER�w�s�ƶq,SOLD_NUMBER��X�ƶq
go