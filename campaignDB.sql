use [iSpanDataBaseICook]
go

Create Table [dbo].[AD_SPACE_IMPRESSION_LOG_廣告版面曝光紀錄] --記錄每條看過廣告的紀錄，比如大雄5/23 12:22看到了A廣告，就會在此表增加一個資料[A廣告,5/23 12:22,大雄的IP]
(	AD_SPACE廣告版面_PK int, --A+6碼 FK參考到[AD_SPACE_廣告版面]的AD_SPACE廣告板位_PK
	IMPRESSION_TIME曝光時間 datetime,
	IP使用者IP NVARCHAR(20) --看到該廣告的使用者IP
	)

Create Table [dbo].[AD_SPACE_CLICK_LOG_廣告版面點擊紀錄] --跟[AD_SPACE_IMPRESSION_LOG_廣告版面曝光紀錄]一樣的道理，但是紀錄點擊事件
(	AD_SPACE廣告版面_PK int, --A+6碼 FK參考到[AD_SPACE_廣告版面]的AD_SPACE廣告板位_PK
	CLICK_TIME點擊時間 datetime,
	IP使用者IP NVARCHAR(20)
	)

Create Table [dbo].[AD_SPACE_廣告版面] --紀錄網站上有的廣告板面，一個板位一列資料，以下是每個欄位的範例
(	 AD_SPACE廣告板位_PK int, --A+6碼 
	AD_SPACE_NAME廣告板位名稱 NVARCHAR(40), --e.g.首頁A-2
	SIZE版面大小 NVARCHAR(50)　--該版面的廣告圖大小要求，e.g. 700*500
)

CREATE TABLE [dbo].[CAMPAIGN_廣告活動] --記錄所有建立過的廣告活動，比如今天有一檔母親節活動，就會是這裡的一條資料
(
	CAMPAIGN活動_PK NVARCHAR(20),　--C+6碼
	CAMPAIGN_NAME活動名稱 NVARCHAR(100), --e.g. 母親節活動
	URL連結 NVARCHAR(MAX), --點擊該廣告會跳轉的連結 
	AD_IMG廣告圖 NVARCHAR(MAX), --廣告圖的儲存位置，可能是網址或檔案位置

)

CREATE TABLE [dbo].[CAMPAIGN_AD廣告活動使用版面] --記錄所有廣告活動使用的廣告版面，比如母親節活動用了A版面跟B版面，就會是兩條資料
( 	CAMPAIGN活動_PK NVARCHAR(20),　--C+6碼 FK參考到[CAMPAIGN_廣告活動]的CAMPAIGN活動_PK
	AD_SPACE廣告版面_PK INT, --A+6碼 FK參考到[AD_SPACE_廣告版面]的AD_SPACE廣告板位_PK
	START_TIME開始期間 DATETIME, --表示該活動使用該版面的開始時間
	END_TIME結束時間 DATETIME --表示該活動使用該版面的開始時間
	)