

--建立trigger以自動產生SPU
CREATE TRIGGER CreateProductSPUAutomatically
   ON  [dbo].[PRODUCT_SPU_商品_TMP]
   AFTER INSERT -- 觸發事件
AS 
BEGIN
    Declare @img nvarchar(MAX),@category nvarchar(50),@productName nvarchar(50)
	DECLARE @SPU Nvarchar(100)
	DECLARE @start nvarchar(5)
	SELECT @start ='P'
	SELECT @SPU=@start + CAST((MAX(CAST(RIGHT([SPU], 6) AS INT))+1) AS nvarchar) from [dbo].[PRODUCT_SPU_商品_TMP]
	SELECT @img = [img] ,@category = [CATEGORY商品分類名稱],@productName= [PRODUCT_NAME商品名稱] from Inserted
	update [dbo].[PRODUCT_SPU_商品_TMP] set [SPU]=@SPU where [img]=@img And [CATEGORY商品分類名稱] = @category and [PRODUCT_NAME商品名稱]=@productName
END
go


