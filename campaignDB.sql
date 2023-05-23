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
(	 AD_SPACE�s�i�O��_PK int, --A+6�X 
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