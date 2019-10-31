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

INSERT INTO [IT_Enterprice].[dbo].[All_Info] VALUES ('2000.01.10','Microsoft', 'Вашингтон', 'Америка', 'Бусов', 1, 200);
INSERT INTO [IT_Enterprice].[dbo].[All_Info] VALUES ('2010.09.24','Google', 'Нью Йорк', 'Америка', 'Иванов', 1, 300);
INSERT INTO [IT_Enterprice].[dbo].[All_Info] VALUES ('2011.02.13','SoftServe', 'Киев', 'Украина', 'Король', 2, 500);
INSERT INTO [IT_Enterprice].[dbo].[All_Info] VALUES ('2007.08.30','Epam', 'Киев', 'Украина', 'Кравцев', 4, 700);
INSERT INTO [IT_Enterprice].[dbo].[All_Info] VALUES ('2001.03.12','PokoCode', 'Фастов', 'Украина', 'Литвин', 1, 200);
INSERT INTO [IT_Enterprice].[dbo].[All_Info] VALUES ('2005.07.05','Microsoft', 'Вашингтон', 'Америка', 'Шульц', 3, 500);
INSERT INTO [IT_Enterprice].[dbo].[All_Info] VALUES ('2002.04.02','Epam', 'Киев', 'Украина', 'Родригес', 2, 300);
INSERT INTO [IT_Enterprice].[dbo].[All_Info] VALUES ('2009.06.15','Google', 'Нью Йорк', 'Америка', 'Иванов', 1, 200);
INSERT INTO [IT_Enterprice].[dbo].[All_Info] VALUES ('2003.04.27','Glovo', 'Жмеренка', 'Украина', 'Перегон', 6, 900);
INSERT INTO [IT_Enterprice].[dbo].[All_Info] VALUES ('2008.05.21','SoffServe', 'Киев', 'Украина', 'Серена', 1, 800);
INSERT INTO [IT_Enterprice].[dbo].[All_Info] VALUES ('2004.10.09','PokoCode', 'Фастов', 'Украина', 'Гора', 1, 200);

INSERT INTO [IT_Enterprice].[dbo].[All_Info] VALUES ('2010.01.01','Восход', 'Киев', 'Украина', 'Иванов', 1, 100);
INSERT INTO [IT_Enterprice].[dbo].[All_Info] VALUES ('2010.01.01','Рик', 'Москва', 'Россия', 'Иванов', 2, 250);
INSERT INTO [IT_Enterprice].[dbo].[All_Info] VALUES ('2010.01.01','Рик', 'Москва', 'Россия', 'Петров', 5, 450);
INSERT INTO [IT_Enterprice].[dbo].[All_Info] VALUES ('2010.01.01','Восход', 'Киев', 'Украина', 'Петров', 7, 750);
INSERT INTO [IT_Enterprice].[dbo].[All_Info] VALUES ('2010.01.02','Рик', 'Москва', 'Россия', 'Сидоров', 10, 1050);

SELECT * FROM [IT_Enterprice].[dbo].[All_Info]

SELECT [Date], [Organization], SUM([Count]) AS [Count], SUM([Amount]) AS [Amount] FROM [IT_Enterprice].[dbo].[All_Info] GROUP BY [Date], [Organization] ORDER BY [Date];
	