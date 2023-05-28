

DECLARE  @Table AS TABLE
(
    SPU NVARCHAR(100),
	SKU NVARCHAR(100),
	STOCK_NUMBER庫存數量 INT,
	SOLD_NUMBER售出數量 INT
)

INSERT INTO @Table(SPU,SKU,STOCK_NUMBER庫存數量,SOLD_NUMBER售出數量)
Select [SPU],(Select  ','+[SKU]
From [dbo].[PRODUCT_SKU_商品] as b
Where a.[SPU] = b.[SPU]
for xml path('')
) as sku,Sum([STOCK_NUMBER庫存數量])as '庫存數量',Sum([SOLD_NUMBER已售出數量]) as '已售出數量'
From [dbo].[PRODUCT_SKU_商品] as a
Group by [SPU]

SELECT * FROM @Table

Select a.SPU,[ON_SHELF上架狀態],[CATEGORY商品分類名稱],[PRODUCT_NAME商品名稱],[SALE_PRICE銷售價],SKU,STOCK_NUMBER庫存數量,SOLD_NUMBER售出數量
From [dbo].[PRODUCT_SPU_商品] as a
Join @Table as b
On a.SPU = b.SPU
Group By a.SPU,[ON_SHELF上架狀態],[CATEGORY商品分類名稱],[PRODUCT_NAME商品名稱],[SALE_PRICE銷售價],SKU,STOCK_NUMBER庫存數量,SOLD_NUMBER售出數量
go

--建立檢視表
CREATE VIEW PRODUCT_SEARCH (SPU,SKU,STOCK_NUMBER庫存數量,SOLD_NUMBER售出數量)
AS
Select [SPU],(Select  ','+[SKU]
From [dbo].[PRODUCT_SKU_商品] as b
Where a.[SPU] = b.[SPU]
for xml path('')
) as sku,Sum([STOCK_NUMBER庫存數量])as '庫存數量',Sum([SOLD_NUMBER已售出數量]) as '已售出數量'
From [dbo].[PRODUCT_SKU_商品] as a
Group by [SPU]
Go

--查詢語法
Select a.SPU,[ON_SHELF上架狀態],[CATEGORY商品分類名稱],[PRODUCT_NAME商品名稱],[SALE_PRICE銷售價],SKU,STOCK_NUMBER庫存數量,SOLD_NUMBER售出數量
From [dbo].[PRODUCT_SPU_商品] as a
Join PRODUCT_SEARCH as b
On a.SPU = b.SPU
Group By a.SPU,[ON_SHELF上架狀態],[CATEGORY商品分類名稱],[PRODUCT_NAME商品名稱],[SALE_PRICE銷售價],SKU,STOCK_NUMBER庫存數量,SOLD_NUMBER售出數量
go