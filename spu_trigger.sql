

--�إ�trigger�H�۰ʲ���SPU
CREATE TRIGGER CreateProductSPUAutomatically
   ON  [dbo].[PRODUCT_SPU_�ӫ~_TMP]
   AFTER INSERT -- Ĳ�o�ƥ�
AS 
BEGIN
    Declare @img nvarchar(MAX),@category nvarchar(50),@productName nvarchar(50)
	DECLARE @SPU Nvarchar(100)
	DECLARE @start nvarchar(5)
	SELECT @start ='P'
	SELECT @SPU=@start + CAST((MAX(CAST(RIGHT([SPU], 6) AS INT))+1) AS nvarchar) from [dbo].[PRODUCT_SPU_�ӫ~_TMP]
	SELECT @img = [img] ,@category = [CATEGORY�ӫ~�����W��],@productName= [PRODUCT_NAME�ӫ~�W��] from Inserted
	update [dbo].[PRODUCT_SPU_�ӫ~_TMP] set [SPU]=@SPU where [img]=@img And [CATEGORY�ӫ~�����W��] = @category and [PRODUCT_NAME�ӫ~�W��]=@productName
END
go


