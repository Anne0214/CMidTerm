use [iSpanDataBaseICook]
go

Create Table [dbo].[AD_SPACE_IMPRESSION_LOG_�s�i�����n������] --�O���C���ݹL�s�i�������A��p�j��5/23 12:22�ݨ�FA�s�i�A�N�|�b����W�[�@�Ӹ��[A�s�i,5/23 12:22,�j����IP]
(	AD_SPACE�s�i����_PK int, --A+6�X FK�ѦҨ�[AD_SPACE_�s�i����]��AD_SPACE�s�i�O��_PK
	IMPRESSION_TIME�n���ɶ� datetime,
	IP�ϥΪ�IP NVARCHAR(20) --�ݨ�Ӽs�i���ϥΪ�IP
	)

Create Table [dbo].[AD_SPACE_CLICK_LOG_�s�i�����I������] --��[AD_SPACE_IMPRESSION_LOG_�s�i�����n������]�@�˪��D�z�A���O�����I���ƥ�
(	AD_SPACE�s�i����_PK int, --A+6�X FK�ѦҨ�[AD_SPACE_�s�i����]��AD_SPACE�s�i�O��_PK
	CLICK_TIME�I���ɶ� datetime,
	IP�ϥΪ�IP NVARCHAR(20)
	)

Create Table [dbo].[AD_SPACE_�s�i����] --���������W�����s�i�O���A�@�ӪO��@�C��ơA�H�U�O�C����쪺�d��
(	 AD_SPACE�s�i�O��_PK int,
	AD_SPACE_NAME�s�i�O��W�� NVARCHAR(40), --e.g.����A-2
	SIZE�����j�p NVARCHAR(50)�@--�Ӫ������s�i�Ϥj�p�n�D�Ae.g. 700*500
)

CREATE TABLE [dbo].[CAMPAIGN_�s�i����] --�O���Ҧ��إ߹L���s�i���ʡA��p���Ѧ��@�ɥ��˸`���ʡA�N�|�O�o�̪��@�����
(
	CAMPAIGN����_PK NVARCHAR(20),�@--C+6�X
	CAMPAIGN_NAME���ʦW�� NVARCHAR(100), --e.g. ���˸`����
	URL�s�� NVARCHAR(MAX), --�I���Ӽs�i�|���઺�s�� 
	AD_IMG�s�i�� NVARCHAR(MAX), --�s�i�Ϫ��x�s��m�A�i��O���}���ɮצ�m

)

CREATE TABLE [dbo].[CAMPAIGN_AD�s�i���ʨϥΪ���] --�O���Ҧ��s�i���ʨϥΪ��s�i�����A��p���˸`���ʥΤFA������B�����A�N�|�O������
( 	CAMPAIGN����_PK NVARCHAR(20),�@--C+6�X FK�ѦҨ�[CAMPAIGN_�s�i����]��CAMPAIGN����_PK
	AD_SPACE�s�i����_PK INT, --A+6�X FK�ѦҨ�[AD_SPACE_�s�i����]��AD_SPACE�s�i�O��_PK
	START_TIME�}�l���� DATETIME, --��ܸӬ��ʨϥθӪ������}�l�ɶ�
	END_TIME�����ɶ� DATETIME --��ܸӬ��ʨϥθӪ������}�l�ɶ�
	)

GO

INSERT [dbo].[AD_SPACE_�s�i����]
VALUES('����A-1','700*300'),
('����A-2','700*300'),
('����A-3','700*300'),
('�j�M���G��B-1','300*500'),
('�j�M���G��B-2','300*500'),
('�j�M���G��B-3','300*500'),
('�ӤH��C','300*700')
GO




CREATE FUNCTION GetCampaignPK()
RETURNS nvarchar(20)
AS
BEGIN
  DECLARE @CampaignID Nvarchar(20)
  DECLARE @DT nvarchar(5)
  SELECT @DT ='C'
  SELECT @CampaignID=
                    @DT + MAX(CAST(RIGHT([CAMPAIGN����_PK], 6) AS INT)) from [dbo].[CAMPAIGN_�s�i����]
  RETURN @CampaignID
END
GO

CREATE TRIGGER CreateCampaignPKAutomatically
   ON  [dbo].[CAMPAIGN_�s�i����]
   AFTER INSERT -- Ĳ�o�ƥ�
AS 
BEGIN
    Declare @c_name NVARCHAR(100),@url NVARCHAR(MAX),@ad_img NVARCHAR(MAX),@ad_space int,@s_time DateTime,@e_timd DateTime
	DECLARE @CampaignID Nvarchar(20)
	DECLARE @DT nvarchar(5)
	SELECT @DT ='C'
	SELECT @CampaignID=
                    @DT + CAST((MAX(CAST(RIGHT([CAMPAIGN����_PK], 6) AS INT))+1) AS nvarchar) from [dbo].[CAMPAIGN_�s�i����]
	select @c_name=[CAMPAIGN_NAME���ʦW��],@ad_space = [AD_SPACE�s�i����_PK],@s_time = [START_TIME�}�l����],@e_timd=[END_TIME�����ɶ�] from Inserted
	update [dbo].[CAMPAIGN_�s�i����] set [CAMPAIGN����_PK]=@CampaignID where @c_name=[CAMPAIGN_NAME���ʦW��] and @s_time = [START_TIME�}�l����] and @e_timd=[END_TIME�����ɶ�] and @ad_space = [AD_SPACE�s�i����_PK]

END
go

Drop Trigger CreateCampaignPKAutomatically 
go

Insert [dbo].[CAMPAIGN_�s�i����]
Values ('C100001','name','name','name',1,'1998-02-21 12:01:01','1999-03-04 12:02:02')
Go

Insert [dbo].[CAMPAIGN_�s�i����]
Values ('1','name','name','name',1,'1998-02-21 12:01:01','1999-03-05 12:02:02')
Go