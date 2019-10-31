CREATE DATABASE [IT_Enterprice];

USE [IT_Enterprice];

GO;

CREATE TABLE All_Info(
	[Date] DATE NOT NULL,
	[Organization] NVARCHAR(30) NOT NULL,
	[City] NVARCHAR(20) NOT NULL,
	[Country] NVARCHAR(15) NOT NULL,
	[Manager] NVARCHAR(15) NOT NULL,
	[Count] INT NOT NULL,
	[Amount] INT NOT NULL,
);

INSERT INTO [IT_Enterprice].[dbo].[All_Info] VALUES ('2000.01.10','Microsoft', '���������', '�������', '�����', 1, 200);
INSERT INTO [IT_Enterprice].[dbo].[All_Info] VALUES ('2010.09.24','Google', '��� ����', '�������', '������', 1, 300);
INSERT INTO [IT_Enterprice].[dbo].[All_Info] VALUES ('2011.02.13','SoftServe', '����', '�������', '������', 2, 500);
INSERT INTO [IT_Enterprice].[dbo].[All_Info] VALUES ('2007.08.30','Epam', '����', '�������', '�������', 4, 700);
INSERT INTO [IT_Enterprice].[dbo].[All_Info] VALUES ('2001.03.12','PokoCode', '������', '�������', '������', 1, 200);
INSERT INTO [IT_Enterprice].[dbo].[All_Info] VALUES ('2005.07.05','Microsoft', '���������', '�������', '�����', 3, 500);
INSERT INTO [IT_Enterprice].[dbo].[All_Info] VALUES ('2002.04.02','Epam', '����', '�������', '��������', 2, 300);
INSERT INTO [IT_Enterprice].[dbo].[All_Info] VALUES ('2009.06.15','Google', '��� ����', '�������', '������', 1, 200);
INSERT INTO [IT_Enterprice].[dbo].[All_Info] VALUES ('2003.04.27','Glovo', '��������', '�������', '�������', 6, 900);
INSERT INTO [IT_Enterprice].[dbo].[All_Info] VALUES ('2008.05.21','SoffServe', '����', '�������', '������', 1, 800);
INSERT INTO [IT_Enterprice].[dbo].[All_Info] VALUES ('2004.10.09','PokoCode', '������', '�������', '����', 1, 200);

INSERT INTO [IT_Enterprice].[dbo].[All_Info] VALUES ('2010.01.01','������', '����', '�������', '������', 1, 100);
INSERT INTO [IT_Enterprice].[dbo].[All_Info] VALUES ('2010.01.01','���', '������', '������', '������', 2, 250);
INSERT INTO [IT_Enterprice].[dbo].[All_Info] VALUES ('2010.01.01','���', '������', '������', '������', 5, 450);
INSERT INTO [IT_Enterprice].[dbo].[All_Info] VALUES ('2010.01.01','������', '����', '�������', '������', 7, 750);
INSERT INTO [IT_Enterprice].[dbo].[All_Info] VALUES ('2010.01.02','���', '������', '������', '�������', 10, 1050);

SELECT * FROM [IT_Enterprice].[dbo].[All_Info]

SELECT [Date], [Organization], SUM([Count]) AS [Count], SUM([Amount]) AS [Amount] FROM [IT_Enterprice].[dbo].[All_Info] GROUP BY [Date], [Organization] ORDER BY [Date];
	