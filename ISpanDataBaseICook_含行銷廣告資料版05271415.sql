USE [master]
GO
/****** Object:  Database [iSpanDataBaseICook]    Script Date: 2023/5/27 下午 02:16:14 ******/
CREATE DATABASE [iSpanDataBaseICook]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'iSpanDataBaseICook', FILENAME = N'D:\SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\iSpanDataBaseICook.mdf' , SIZE = 90112KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'iSpanDataBaseICook_log', FILENAME = N'D:\SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\iSpanDataBaseICook_log.ldf' , SIZE = 425984KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [iSpanDataBaseICook] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [iSpanDataBaseICook].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [iSpanDataBaseICook] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [iSpanDataBaseICook] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [iSpanDataBaseICook] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [iSpanDataBaseICook] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [iSpanDataBaseICook] SET ARITHABORT OFF 
GO
ALTER DATABASE [iSpanDataBaseICook] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [iSpanDataBaseICook] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [iSpanDataBaseICook] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [iSpanDataBaseICook] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [iSpanDataBaseICook] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [iSpanDataBaseICook] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [iSpanDataBaseICook] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [iSpanDataBaseICook] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [iSpanDataBaseICook] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [iSpanDataBaseICook] SET  ENABLE_BROKER 
GO
ALTER DATABASE [iSpanDataBaseICook] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [iSpanDataBaseICook] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [iSpanDataBaseICook] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [iSpanDataBaseICook] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [iSpanDataBaseICook] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [iSpanDataBaseICook] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [iSpanDataBaseICook] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [iSpanDataBaseICook] SET RECOVERY FULL 
GO
ALTER DATABASE [iSpanDataBaseICook] SET  MULTI_USER 
GO
ALTER DATABASE [iSpanDataBaseICook] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [iSpanDataBaseICook] SET DB_CHAINING OFF 
GO
ALTER DATABASE [iSpanDataBaseICook] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [iSpanDataBaseICook] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [iSpanDataBaseICook] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [iSpanDataBaseICook] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'iSpanDataBaseICook', N'ON'
GO
ALTER DATABASE [iSpanDataBaseICook] SET QUERY_STORE = OFF
GO
USE [iSpanDataBaseICook]
GO
/****** Object:  User [sa5]    Script Date: 2023/5/27 下午 02:16:15 ******/
CREATE USER [sa5] FOR LOGIN [sa5] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [sa5]
GO
/****** Object:  Table [dbo].[AD_SPACE_CLICK_LOG_廣告版面點擊紀錄]    Script Date: 2023/5/27 下午 02:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AD_SPACE_CLICK_LOG_廣告版面點擊紀錄](
	[AD_SPACE廣告版面_PK] [int] NULL,
	[CLICK_TIME點擊時間] [datetime] NULL,
	[IP使用者IP] [nvarchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AD_SPACE_IMPRESSION_LOG_廣告版面曝光紀錄]    Script Date: 2023/5/27 下午 02:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AD_SPACE_IMPRESSION_LOG_廣告版面曝光紀錄](
	[AD_SPACE廣告版面_PK] [int] NULL,
	[IMPRESSION_TIME曝光時間] [datetime] NULL,
	[IP使用者IP] [nvarchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AD_SPACE_廣告版面]    Script Date: 2023/5/27 下午 02:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AD_SPACE_廣告版面](
	[AD_SPACE廣告板位_PK] [int] IDENTITY(1,1) NOT NULL,
	[AD_SPACE_NAME廣告板位名稱] [nvarchar](40) NULL,
	[SIZE版面大小] [nvarchar](50) NULL,
 CONSTRAINT [PK_AD_SPACE_廣告版面] PRIMARY KEY CLUSTERED 
(
	[AD_SPACE廣告板位_PK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CAMPAIGN_廣告活動]    Script Date: 2023/5/27 下午 02:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CAMPAIGN_廣告活動](
	[CAMPAIGN活動_PK] [nvarchar](20) NOT NULL,
	[CAMPAIGN_NAME活動名稱] [nvarchar](100) NULL,
	[URL連結] [nvarchar](max) NULL,
	[AD_IMG廣告圖] [nvarchar](max) NULL,
	[AD_SPACE廣告版面_PK] [int] NULL,
	[START_TIME開始期間] [datetime] NULL,
	[END_TIME結束時間] [datetime] NULL,
 CONSTRAINT [PK_CAMPAIGN_廣告活動] PRIMARY KEY CLUSTERED 
(
	[CAMPAIGN活動_PK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CATEGORY_食譜分類_LEVEL_ONE]    Script Date: 2023/5/27 下午 02:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORY_食譜分類_LEVEL_ONE](
	[FEATURED_CATEGORY精選分類LEVEL_ONE_PK] [int] NOT NULL,
	[FEATURED_CATEGORY精選分類LEVEL_ONE_NAME名稱] [nvarchar](40) NULL,
	[UPDATE_USER] [nvarchar](255) NULL,
	[UPDATE_TIME] [datetime] NULL,
 CONSTRAINT [PK_CATEGORY_食譜分類_LEVEL_ONE] PRIMARY KEY CLUSTERED 
(
	[FEATURED_CATEGORY精選分類LEVEL_ONE_PK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CATEGORY_食譜分類_LEVEL_ONE_TMP]    Script Date: 2023/5/27 下午 02:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORY_食譜分類_LEVEL_ONE_TMP](
	[FEATURED_CATEGORY精選分類LEVEL_ONE_PK] [int] NOT NULL,
	[FEATURED_CATEGORY精選分類LEVEL_ONE_NAME名稱] [nvarchar](40) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CATEGORY_食譜分類_LEVEL_THREE]    Script Date: 2023/5/27 下午 02:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORY_食譜分類_LEVEL_THREE](
	[FEATURED_CATEGORY精選分類LEVEL_THREE_PK] [int] IDENTITY(1,1) NOT NULL,
	[FEATURED_CATEGORY精選分類LEVEL_THREE_NAME名稱] [nvarchar](40) NULL,
	[LEVEL_TWO_FK] [int] NOT NULL,
	[UPDATE_USER] [nvarchar](255) NULL,
	[UPDATE_TIME] [datetime] NULL,
 CONSTRAINT [PK_CATEGORY_食譜分類_LEVEL_THREE] PRIMARY KEY CLUSTERED 
(
	[FEATURED_CATEGORY精選分類LEVEL_THREE_PK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CATEGORY_食譜分類_LEVEL_THREE_TMP]    Script Date: 2023/5/27 下午 02:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORY_食譜分類_LEVEL_THREE_TMP](
	[FEATURED_CATEGORY精選分類LEVEL_THREE_PK] [nvarchar](40) NOT NULL,
	[LEVEL_TWO_FK] [nvarchar](40) NOT NULL,
	[LEVEL_TWO_NAME] [nvarchar](40) NULL,
	[FEATURED_CATEGORY精選分類LEVEL_THREE_NAME名稱] [nvarchar](40) NULL,
	[EXTRA_COL] [nvarchar](40) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CATEGORY_食譜分類_LEVEL_TWO]    Script Date: 2023/5/27 下午 02:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORY_食譜分類_LEVEL_TWO](
	[FEATURED_CATEGORY精選分類LEVEL_TWO_PK] [int] IDENTITY(1,1) NOT NULL,
	[FEATURED_CATEGORY精選分類LEVEL_TWO_NAME名稱] [nvarchar](40) NULL,
	[LEVEL_ONE_FK] [int] NULL,
	[UPDATE_USER] [nvarchar](255) NULL,
	[UPDATE_TIME] [datetime] NULL,
 CONSTRAINT [PK_CATEGORY_食譜分類_LEVEL_TWO] PRIMARY KEY CLUSTERED 
(
	[FEATURED_CATEGORY精選分類LEVEL_TWO_PK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CATEGORY_食譜分類_LEVEL_TWO_TMP]    Script Date: 2023/5/27 下午 02:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORY_食譜分類_LEVEL_TWO_TMP](
	[FEATURED_CATEGORY精選分類LEVEL_TWO_PK] [nvarchar](40) NOT NULL,
	[LEVEL_ONE_FK] [nvarchar](40) NULL,
	[LEVEL_ONE_NAME] [nvarchar](40) NULL,
	[FEATURED_CATEGORY精選分類LEVEL_TWO_NAME名稱] [nvarchar](40) NULL,
	[EXTRA_COL] [nvarchar](40) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FOOD_食材]    Script Date: 2023/5/27 下午 02:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FOOD_食材](
	[RECIPE_FOOD_食譜_FK] [nvarchar](50) NULL,
	[FOOD_NAME食材名稱] [nvarchar](200) NULL,
	[FOOD_AMOUNT食材數量] [nvarchar](200) NULL,
	[UPDATE_USER] [nvarchar](255) NULL,
	[UPDATE_TIME] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FOOD_食材_TMP]    Script Date: 2023/5/27 下午 02:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FOOD_食材_TMP](
	[RECIPE_FOOD_食譜_FK] [nvarchar](50) NULL,
	[FOOD_NAME食材名稱] [nvarchar](200) NULL,
	[FOOD_AMOUNT食材數量] [nvarchar](200) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MEMBER_會員]    Script Date: 2023/5/27 下午 02:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MEMBER_會員](
	[MEMBER_ID會員_PK] [nvarchar](50) NOT NULL,
	[MEMBER_EMAIL] [nvarchar](max) NULL,
	[MEMBER_PASSWORD] [nvarchar](32) NULL,
	[REGISTER_TIME註冊時間] [date] NULL,
	[NICK_NAME暱稱] [nvarchar](40) NULL,
	[PROFILE_PHOTO頭貼] [nvarchar](max) NULL,
	[SELF_INTRO自介] [nvarchar](400) NULL,
	[RECEIVED_PERSON_NAME收件人姓名] [nvarchar](200) NULL,
	[RECEIVED_PERSON_PHONE收件人電話] [nvarchar](200) NULL,
	[RECEIVED_PERSON_ADDRESS收件人地址] [nvarchar](200) NULL,
	[UPDATE_USER] [nvarchar](200) NULL,
	[UPDATE_TIME] [nvarchar](200) NULL,
 CONSTRAINT [PK_MEMBER_會員] PRIMARY KEY CLUSTERED 
(
	[MEMBER_ID會員_PK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MEMBER_會員_TMP]    Script Date: 2023/5/27 下午 02:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MEMBER_會員_TMP](
	[MEMBER_ID會員_PK] [nvarchar](50) NOT NULL,
	[MEMBER_EMAIL] [nvarchar](max) NULL,
	[MEMBER_PASSWORD] [nvarchar](32) NULL,
	[REGISTER_TIME註冊時間] [nvarchar](50) NULL,
	[NICK_NAME暱稱] [nvarchar](40) NULL,
	[PROFILE_PHOTO頭貼] [nvarchar](max) NULL,
	[SELF_INTRO自介] [nvarchar](400) NULL,
	[RECEIVED_PERSON_NAME收件人姓名] [nvarchar](200) NULL,
	[RECEIVED_PERSON_PHONE收件人電話] [nvarchar](200) NULL,
	[RECEIVED_PERSON_ADDRESS收件人地址] [nvarchar](200) NULL,
	[UPDATE_USER] [nvarchar](200) NULL,
	[UPDATE_TIME] [nvarchar](200) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ORDER_ID_DETAIL訂單細項]    Script Date: 2023/5/27 下午 02:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDER_ID_DETAIL訂單細項](
	[ORDER_ID訂單編號FK] [int] NULL,
	[SKU] [nvarchar](100) NULL,
	[PRODUCT_NAME商品名稱] [nvarchar](50) NULL,
	[PURCHASE_AMOUNT購買數量] [int] NULL,
	[ORDERED_SALE_PRICE購買價格] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ORDER_ID訂單]    Script Date: 2023/5/27 下午 02:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDER_ID訂單](
	[ORDER_ID訂單編號] [int] NOT NULL,
	[ORDERED_MEMBER訂購會員] [nvarchar](50) NULL,
	[PAYMENT_METHOD支付方式] [nvarchar](30) NULL,
	[DELIVERY_METHOD運送方式] [nvarchar](20) NULL,
	[DELIVERY_ID運送單號] [int] NULL,
	[ORDERED_TIME訂單成立時間] [datetime] NULL,
	[SEND_TIME發貨時間] [datetime] NULL,
	[RECEIVED_TIME收貨時間] [datetime] NULL,
	[RETURN_GOODS是否退貨] [nvarchar](10) NULL,
	[RETURN_GOODS_ESTABLISHED_DATE退貨退款時間] [datetime] NULL,
 CONSTRAINT [PK_ORDER_ID訂單] PRIMARY KEY CLUSTERED 
(
	[ORDER_ID訂單編號] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ORDER_ID訂單_TMP]    Script Date: 2023/5/27 下午 02:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDER_ID訂單_TMP](
	[ORDER_ID訂單編號] [int] NOT NULL,
	[ORDERED_MEMBER訂購會員] [nvarchar](50) NULL,
	[PAYMENT_METHOD支付方式] [nvarchar](30) NULL,
	[DELIVERY_METHOD運送方式] [nvarchar](20) NULL,
	[DELIVERY_ID運送單號] [int] NULL,
	[ORDERED_TIME訂單成立時間] [datetime] NULL,
	[SEND_TIME發貨時間] [datetime] NULL,
	[RECEIVED_TIME收貨時間] [datetime] NULL,
	[RETURN_GOODS是否退貨] [nvarchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ORDERED_CART]    Script Date: 2023/5/27 下午 02:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDERED_CART](
	[MEMBER_ID會員_FK] [nvarchar](50) NULL,
	[SKU] [nvarchar](100) NULL,
	[ORDERED_AMOUNT] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUCT_PICTURE商品圖]    Script Date: 2023/5/27 下午 02:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCT_PICTURE商品圖](
	[SPU] [nvarchar](100) NULL,
	[PRODUCT_PICTURE商品圖] [nvarchar](max) NULL,
	[step_img] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUCT_PICTURE商品圖_tmp]    Script Date: 2023/5/27 下午 02:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCT_PICTURE商品圖_tmp](
	[SPU] [nvarchar](100) NULL,
	[PRODUCT_PICTURE商品圖] [nvarchar](max) NULL,
	[step_img] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUCT_SKU_商品]    Script Date: 2023/5/27 下午 02:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCT_SKU_商品](
	[SPU] [nvarchar](100) NOT NULL,
	[SKU] [nvarchar](100) NOT NULL,
	[TYPE_NAME型號] [nvarchar](100) NULL,
	[STOCK_NUMBER庫存數量] [int] NULL,
	[SOLD_NUMBER已售出數量] [int] NULL,
	[UPDATE_USER] [nvarchar](255) NULL,
	[UPDATE_TIME] [datetime] NULL,
 CONSTRAINT [PK_PRODUCT_SKU_商品] PRIMARY KEY CLUSTERED 
(
	[SKU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUCT_SKU_商品_TMP]    Script Date: 2023/5/27 下午 02:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCT_SKU_商品_TMP](
	[SPU] [nvarchar](255) NOT NULL,
	[SKU] [nvarchar](255) NOT NULL,
	[TYPE_NAME型號] [nvarchar](255) NULL,
	[STOCK_NUMBER庫存數量] [nvarchar](255) NULL,
	[SOLD_NUMBER已售出數量] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUCT_SPU_商品]    Script Date: 2023/5/27 下午 02:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCT_SPU_商品](
	[SPU] [nvarchar](100) NOT NULL,
	[img] [nvarchar](max) NULL,
	[ON_SHELF上架狀態] [nvarchar](10) NULL,
	[CATEGORY商品分類名稱] [nvarchar](50) NULL,
	[PRODUCT_NAME商品名稱] [nvarchar](50) NULL,
	[PRODUCT_DESCRIPTION簡短商品說明] [nvarchar](500) NULL,
	[FULL_PRODUCT_DESCRIPTION完整說明圖片] [nvarchar](max) NULL,
	[PURCHASE_PRICE採購價] [int] NULL,
	[TAG_PRICE吊牌價] [int] NULL,
	[SALE_PRICE銷售價] [int] NULL,
	[UPDATE_USER] [nvarchar](255) NULL,
	[UPDATE_TIME] [datetime] NULL,
 CONSTRAINT [PK_PRODUCT_SPU_商品] PRIMARY KEY CLUSTERED 
(
	[SPU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUCT_SPU_商品_TMP]    Script Date: 2023/5/27 下午 02:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCT_SPU_商品_TMP](
	[SPU] [nvarchar](500) NOT NULL,
	[img] [nvarchar](max) NULL,
	[ON_SHELF上架狀態] [nvarchar](500) NULL,
	[CATEGORY商品分類名稱] [nvarchar](500) NULL,
	[PRODUCT_NAME商品名稱] [nvarchar](500) NULL,
	[PRODUCT_DESCRIPTION簡短商品說明] [nvarchar](500) NULL,
	[FULL_PRODUCT_DESCRIPTION完整說明圖片] [nvarchar](500) NULL,
	[PURCHASE_PRICE採購價] [nvarchar](500) NULL,
	[TAG_PRICE吊牌價] [nvarchar](500) NULL,
	[SALE_PRICE銷售價] [nvarchar](500) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RECIPE_食譜]    Script Date: 2023/5/27 下午 02:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RECIPE_食譜](
	[RECIPE食譜_PK] [nvarchar](50) NOT NULL,
	[RECIPE_NAME食譜名稱] [nvarchar](40) NULL,
	[UPDATE_TIME更新時間] [datetime] NULL,
	[PUBLISHED_TIME出版時間] [datetime] NULL,
	[FEATURED_CATEGORY精選分類LEVEL_ONE] [int] NULL,
	[FEATURED_CATEGORY精選分類LEVEL_TWO] [int] NULL,
	[FEATURED_CATEGORY精選分類LEVEL_THREE] [int] NULL,
	[PUBLISHED_TIME發表時間] [datetime] NULL,
	[AUTHOR_作者] [nvarchar](50) NULL,
	[LIKES_讚數] [int] NULL,
	[RECIPE_COVER] [nvarchar](max) NULL,
	[SHORT_DESCRIPTION簡短說明] [nvarchar](400) NULL,
	[COST_MINUTES花費時間] [nvarchar](20) NULL,
	[AMOUNT_份量] [nvarchar](20) NULL,
	[CALORIES_熱量] [int] NULL,
	[TIPS_小撇步] [nvarchar](300) NULL,
	[FAVORITE_NUMBER收藏數] [int] NULL,
 CONSTRAINT [PK_RECIPE_食譜] PRIMARY KEY CLUSTERED 
(
	[RECIPE食譜_PK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RECIPE_食譜_TMP]    Script Date: 2023/5/27 下午 02:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RECIPE_食譜_TMP](
	[RECIPE食譜_PK] [nvarchar](400) NOT NULL,
	[RECIPE_NAME食譜名稱] [nvarchar](400) NULL,
	[UPDATE_TIME更新時間] [nvarchar](400) NULL,
	[FEATURED_CATEGORY精選分類LEVEL_ONE] [nvarchar](400) NULL,
	[FEATURED_CATEGORY精選分類LEVEL_TWO] [nvarchar](400) NULL,
	[FEATURED_CATEGORY精選分類LEVEL_THREE] [nvarchar](400) NULL,
	[PUBLISHED_TIME發表時間] [nvarchar](400) NULL,
	[AUTHOR_作者] [nvarchar](400) NULL,
	[LIKES_讚數] [nvarchar](400) NULL,
	[RECIPE_COVER] [nvarchar](400) NULL,
	[SHORT_DESCRIPTION簡短說明] [nvarchar](400) NULL,
	[COST_MINUTES花費時間] [nvarchar](400) NULL,
	[AMOUNT_份量] [nvarchar](400) NULL,
	[CALORIES_熱量] [nvarchar](400) NULL,
	[TIPS_小撇步] [nvarchar](400) NULL,
	[FAVORITE_NUMBER收藏數] [nvarchar](400) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RECIPE_食譜_TMPTest]    Script Date: 2023/5/27 下午 02:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RECIPE_食譜_TMPTest](
	[RECIPE食譜_PK] [nvarchar](50) NOT NULL,
	[RECIPE_NAME食譜名稱] [nvarchar](40) NULL,
	[UPDATE_TIME更新時間] [datetime] NULL,
	[PUBLISHED_TIME出版時間] [datetime] NULL,
	[FEATURED_CATEGORY精選分類LEVEL_ONE] [int] NULL,
	[FEATURED_CATEGORY精選分類LEVEL_TWO] [int] NULL,
	[FEATURED_CATEGORY精選分類LEVEL_THREE] [int] NULL,
	[PUBLISHED_TIME發表時間] [datetime] NULL,
	[AUTHOR_作者] [nvarchar](50) NULL,
	[LIKES_讚數] [int] NULL,
	[RECIPE_COVER] [nvarchar](max) NULL,
	[SHORT_DESCRIPTION簡短說明] [nvarchar](400) NULL,
	[COST_MINUTES花費時間] [nvarchar](20) NULL,
	[AMOUNT_份量] [nvarchar](20) NULL,
	[CALORIES_熱量] [int] NULL,
	[TIPS_小撇步] [nvarchar](300) NULL,
	[FAVORITE_NUMBER收藏數] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[STEP_步驟列表]    Script Date: 2023/5/27 下午 02:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STEP_步驟列表](
	[RECIPE_STEP_食譜_FK] [nvarchar](50) NULL,
	[STEP_DESCRIPTION步驟說明] [nvarchar](300) NULL,
	[STEP_DESCRIPTION_PICTURE步驟附圖] [nvarchar](max) NULL,
	[UPDATE_USER] [nvarchar](255) NULL,
	[UPDATE_TIME] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[STEP_步驟列表_TMP]    Script Date: 2023/5/27 下午 02:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STEP_步驟列表_TMP](
	[RECIPE_STEP_食譜_FK] [nvarchar](255) NULL,
	[STEP_DESCRIPTION步驟說明] [nvarchar](255) NULL,
	[STEP_DESCRIPTION_PICTURE步驟附圖] [nvarchar](500) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AD_SPACE_CLICK_LOG_廣告版面點擊紀錄]  WITH CHECK ADD  CONSTRAINT [FK_AD_SPACE_CLICK_LOG_廣告版面點擊紀錄_AD_SPACE_廣告版面] FOREIGN KEY([AD_SPACE廣告版面_PK])
REFERENCES [dbo].[AD_SPACE_廣告版面] ([AD_SPACE廣告板位_PK])
GO
ALTER TABLE [dbo].[AD_SPACE_CLICK_LOG_廣告版面點擊紀錄] CHECK CONSTRAINT [FK_AD_SPACE_CLICK_LOG_廣告版面點擊紀錄_AD_SPACE_廣告版面]
GO
ALTER TABLE [dbo].[AD_SPACE_IMPRESSION_LOG_廣告版面曝光紀錄]  WITH CHECK ADD  CONSTRAINT [FK_AD_SPACE_IMPRESSION_LOG_廣告版面曝光紀錄_AD_SPACE_廣告版面] FOREIGN KEY([AD_SPACE廣告版面_PK])
REFERENCES [dbo].[AD_SPACE_廣告版面] ([AD_SPACE廣告板位_PK])
GO
ALTER TABLE [dbo].[AD_SPACE_IMPRESSION_LOG_廣告版面曝光紀錄] CHECK CONSTRAINT [FK_AD_SPACE_IMPRESSION_LOG_廣告版面曝光紀錄_AD_SPACE_廣告版面]
GO
ALTER TABLE [dbo].[CAMPAIGN_廣告活動]  WITH CHECK ADD  CONSTRAINT [FK_CAMPAIGN_廣告活動_AD_SPACE_廣告版面] FOREIGN KEY([AD_SPACE廣告版面_PK])
REFERENCES [dbo].[AD_SPACE_廣告版面] ([AD_SPACE廣告板位_PK])
GO
ALTER TABLE [dbo].[CAMPAIGN_廣告活動] CHECK CONSTRAINT [FK_CAMPAIGN_廣告活動_AD_SPACE_廣告版面]
GO
ALTER TABLE [dbo].[CATEGORY_食譜分類_LEVEL_THREE]  WITH NOCHECK ADD  CONSTRAINT [FK_CATEGORY_食譜分類_LEVEL_THREE_CATEGORY_食譜分類_LEVEL_TWO] FOREIGN KEY([LEVEL_TWO_FK])
REFERENCES [dbo].[CATEGORY_食譜分類_LEVEL_TWO] ([FEATURED_CATEGORY精選分類LEVEL_TWO_PK])
GO
ALTER TABLE [dbo].[CATEGORY_食譜分類_LEVEL_THREE] CHECK CONSTRAINT [FK_CATEGORY_食譜分類_LEVEL_THREE_CATEGORY_食譜分類_LEVEL_TWO]
GO
ALTER TABLE [dbo].[CATEGORY_食譜分類_LEVEL_TWO]  WITH NOCHECK ADD  CONSTRAINT [FK_CATEGORY_食譜分類_LEVEL_TWO_CATEGORY_食譜分類_LEVEL_ONE] FOREIGN KEY([LEVEL_ONE_FK])
REFERENCES [dbo].[CATEGORY_食譜分類_LEVEL_ONE] ([FEATURED_CATEGORY精選分類LEVEL_ONE_PK])
GO
ALTER TABLE [dbo].[CATEGORY_食譜分類_LEVEL_TWO] CHECK CONSTRAINT [FK_CATEGORY_食譜分類_LEVEL_TWO_CATEGORY_食譜分類_LEVEL_ONE]
GO
ALTER TABLE [dbo].[FOOD_食材]  WITH CHECK ADD  CONSTRAINT [FK_FOOD_食材_RECIPE_食譜] FOREIGN KEY([RECIPE_FOOD_食譜_FK])
REFERENCES [dbo].[RECIPE_食譜] ([RECIPE食譜_PK])
GO
ALTER TABLE [dbo].[FOOD_食材] CHECK CONSTRAINT [FK_FOOD_食材_RECIPE_食譜]
GO
ALTER TABLE [dbo].[ORDER_ID_DETAIL訂單細項]  WITH CHECK ADD  CONSTRAINT [FK_ORDER_ID_DETAIL訂單細項_ORDER_ID訂單] FOREIGN KEY([ORDER_ID訂單編號FK])
REFERENCES [dbo].[ORDER_ID訂單] ([ORDER_ID訂單編號])
GO
ALTER TABLE [dbo].[ORDER_ID_DETAIL訂單細項] CHECK CONSTRAINT [FK_ORDER_ID_DETAIL訂單細項_ORDER_ID訂單]
GO
ALTER TABLE [dbo].[ORDER_ID_DETAIL訂單細項]  WITH CHECK ADD  CONSTRAINT [FK_ORDER_ID_DETAIL訂單細項_PRODUCT_SKU_商品] FOREIGN KEY([SKU])
REFERENCES [dbo].[PRODUCT_SKU_商品] ([SKU])
GO
ALTER TABLE [dbo].[ORDER_ID_DETAIL訂單細項] CHECK CONSTRAINT [FK_ORDER_ID_DETAIL訂單細項_PRODUCT_SKU_商品]
GO
ALTER TABLE [dbo].[ORDER_ID訂單]  WITH CHECK ADD  CONSTRAINT [FK_ORDER_ID訂單_MEMBER_會員] FOREIGN KEY([ORDERED_MEMBER訂購會員])
REFERENCES [dbo].[MEMBER_會員] ([MEMBER_ID會員_PK])
GO
ALTER TABLE [dbo].[ORDER_ID訂單] CHECK CONSTRAINT [FK_ORDER_ID訂單_MEMBER_會員]
GO
ALTER TABLE [dbo].[ORDERED_CART]  WITH CHECK ADD  CONSTRAINT [FK_ORDERED_CART_MEMBER_會員] FOREIGN KEY([MEMBER_ID會員_FK])
REFERENCES [dbo].[MEMBER_會員] ([MEMBER_ID會員_PK])
GO
ALTER TABLE [dbo].[ORDERED_CART] CHECK CONSTRAINT [FK_ORDERED_CART_MEMBER_會員]
GO
ALTER TABLE [dbo].[ORDERED_CART]  WITH CHECK ADD  CONSTRAINT [FK_ORDERED_CART_PRODUCT_SKU_商品] FOREIGN KEY([SKU])
REFERENCES [dbo].[PRODUCT_SKU_商品] ([SKU])
GO
ALTER TABLE [dbo].[ORDERED_CART] CHECK CONSTRAINT [FK_ORDERED_CART_PRODUCT_SKU_商品]
GO
ALTER TABLE [dbo].[PRODUCT_PICTURE商品圖]  WITH NOCHECK ADD  CONSTRAINT [FK_PRODUCT_PICTURE商品圖_PRODUCT_SPU_商品] FOREIGN KEY([SPU])
REFERENCES [dbo].[PRODUCT_SPU_商品] ([SPU])
GO
ALTER TABLE [dbo].[PRODUCT_PICTURE商品圖] CHECK CONSTRAINT [FK_PRODUCT_PICTURE商品圖_PRODUCT_SPU_商品]
GO
ALTER TABLE [dbo].[PRODUCT_SKU_商品]  WITH NOCHECK ADD  CONSTRAINT [FK_PRODUCT_SKU_商品_PRODUCT_SPU_商品] FOREIGN KEY([SPU])
REFERENCES [dbo].[PRODUCT_SPU_商品] ([SPU])
GO
ALTER TABLE [dbo].[PRODUCT_SKU_商品] CHECK CONSTRAINT [FK_PRODUCT_SKU_商品_PRODUCT_SPU_商品]
GO
ALTER TABLE [dbo].[RECIPE_食譜]  WITH NOCHECK ADD  CONSTRAINT [FK_RECIPE_食譜_CATEGORY_食譜分類_LEVEL_THREE] FOREIGN KEY([FEATURED_CATEGORY精選分類LEVEL_THREE])
REFERENCES [dbo].[CATEGORY_食譜分類_LEVEL_THREE] ([FEATURED_CATEGORY精選分類LEVEL_THREE_PK])
GO
ALTER TABLE [dbo].[RECIPE_食譜] CHECK CONSTRAINT [FK_RECIPE_食譜_CATEGORY_食譜分類_LEVEL_THREE]
GO
ALTER TABLE [dbo].[RECIPE_食譜]  WITH CHECK ADD  CONSTRAINT [FK_RECIPE_食譜_MEMBER_會員] FOREIGN KEY([AUTHOR_作者])
REFERENCES [dbo].[MEMBER_會員] ([MEMBER_ID會員_PK])
GO
ALTER TABLE [dbo].[RECIPE_食譜] CHECK CONSTRAINT [FK_RECIPE_食譜_MEMBER_會員]
GO
ALTER TABLE [dbo].[STEP_步驟列表]  WITH CHECK ADD  CONSTRAINT [FK_STEP_步驟列表_RECIPE_食譜] FOREIGN KEY([RECIPE_STEP_食譜_FK])
REFERENCES [dbo].[RECIPE_食譜] ([RECIPE食譜_PK])
GO
ALTER TABLE [dbo].[STEP_步驟列表] CHECK CONSTRAINT [FK_STEP_步驟列表_RECIPE_食譜]
GO
USE [master]
GO
ALTER DATABASE [iSpanDataBaseICook] SET  READ_WRITE 
GO
