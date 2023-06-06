 use　[iSpanDataBaseICook]
DECLARE @_MAX INT, @_i INT
 SET @_i =1
 SET @_MAX = 146 -- 要產生幾筆資料
 WHILE (@_i<=@_MAX)
 BEGIN
	Update [dbo].[CATEGORY_食譜分類_LEVEL_THREE]
	Set [LEVEL_TWO_FK] = CONVERT(INT, [LEVEL_TWO_FK]+13)
	Where [FEATURED_CATEGORY精選分類LEVEL_THREE_PK] = @_i
	SET @_i = @_i+1
 END




  --端午節
  UPDATE [iSpanDataBaseICook].[dbo].[CATEGORY_食譜分類_LEVEL_THREE]
  SET [LEVEL_TWO_FK] = 6
  WHERE [LEVEL_TWO_FK] = 120
  GO

  --湯圓/元宵
 UPDATE [iSpanDataBaseICook].[dbo].[CATEGORY_食譜分類_LEVEL_THREE]
 SET [LEVEL_TWO_FK] = 9
 WHERE [LEVEL_TWO_FK] = 123
 GO

--情人節
 UPDATE [iSpanDataBaseICook].[dbo].[CATEGORY_食譜分類_LEVEL_THREE]
 SET [LEVEL_TWO_FK] = 10
 WHERE [LEVEL_TWO_FK] = 124
 GO

 --年菜
 UPDATE [iSpanDataBaseICook].[dbo].[CATEGORY_食譜分類_LEVEL_THREE]
 SET [LEVEL_TWO_FK] = 11
 WHERE [LEVEL_TWO_FK] =125

 --中秋
 UPDATE [iSpanDataBaseICook].[dbo].[CATEGORY_食譜分類_LEVEL_THREE]
 SET [LEVEL_TWO_FK] = 12
 WHERE [LEVEL_TWO_FK] = 126



