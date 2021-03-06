USE [Busher]
GO
/****** Object:  Table [dbo].[Клиент]    Script Date: 23.05.2017 23:02:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Клиент](
	[Код] [int] IDENTITY(1,1) NOT NULL,
	[ФИО] [nchar](10) NULL,
	[Фирма] [nchar](10) NULL,
	[Город] [nchar](10) NULL,
	[Телефон] [nchar](10) NULL,
 CONSTRAINT [PK_Клиент] PRIMARY KEY CLUSTERED 
(
	[Код] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Сделка]    Script Date: 23.05.2017 23:02:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Сделка](
	[Код] [int] IDENTITY(1,1) NOT NULL,
	[Количество] [int] NULL,
	[Дата] [date] NULL,
	[Код_Товара] [int] NOT NULL,
	[Код_Клиента] [int] NOT NULL,
 CONSTRAINT [PK_Сделка] PRIMARY KEY CLUSTERED 
(
	[Код] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Товар]    Script Date: 23.05.2017 23:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Товар](
	[Код] [int] IDENTITY(1,1) NOT NULL,
	[Название] [nchar](10) NULL,
	[Цена] [int] NULL,
	[Сорт] [nchar](10) NULL,
	[Оттенок] [nchar](10) NULL,
	[Город] [nchar](10) NULL,
 CONSTRAINT [PK_Товар] PRIMARY KEY CLUSTERED 
(
	[Код] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[ClientView]    Script Date: 23.05.2017 23:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create view [dbo].[ClientView] 
as
Select * from Клиент
GO
SET IDENTITY_INSERT [dbo].[Клиент] ON 

INSERT [dbo].[Клиент] ([Код], [ФИО], [Фирма], [Город], [Телефон]) VALUES (1, N'И1        ', N'Ф1        ', N'Г1        ', NULL)
INSERT [dbo].[Клиент] ([Код], [ФИО], [Фирма], [Город], [Телефон]) VALUES (2, N'И2        ', N'Ф2        ', N'Г2        ', NULL)
INSERT [dbo].[Клиент] ([Код], [ФИО], [Фирма], [Город], [Телефон]) VALUES (3, N'И3        ', N'Ф3        ', N'Г3        ', NULL)
INSERT [dbo].[Клиент] ([Код], [ФИО], [Фирма], [Город], [Телефон]) VALUES (4, N'И4        ', N'Ф4        ', N'Г1        ', NULL)
INSERT [dbo].[Клиент] ([Код], [ФИО], [Фирма], [Город], [Телефон]) VALUES (5, N'И5        ', N'Ф1        ', N'Г2        ', NULL)
INSERT [dbo].[Клиент] ([Код], [ФИО], [Фирма], [Город], [Телефон]) VALUES (6, N'Пример фио', N'Моя фирма ', N'город     ', N'8800      ')
INSERT [dbo].[Клиент] ([Код], [ФИО], [Фирма], [Город], [Телефон]) VALUES (7, N'123       ', N'123       ', N'123       ', N'23        ')
INSERT [dbo].[Клиент] ([Код], [ФИО], [Фирма], [Город], [Телефон]) VALUES (9, N'И1        ', N'фрмач     ', N'городок   ', N'          ')
SET IDENTITY_INSERT [dbo].[Клиент] OFF
SET IDENTITY_INSERT [dbo].[Сделка] ON 

INSERT [dbo].[Сделка] ([Код], [Количество], [Дата], [Код_Товара], [Код_Клиента]) VALUES (1, 10, CAST(N'2017-05-02' AS Date), 1, 1)
INSERT [dbo].[Сделка] ([Код], [Количество], [Дата], [Код_Товара], [Код_Клиента]) VALUES (2, 50, CAST(N'2017-06-02' AS Date), 2, 1)
INSERT [dbo].[Сделка] ([Код], [Количество], [Дата], [Код_Товара], [Код_Клиента]) VALUES (3, 30, CAST(N'2017-05-02' AS Date), 1, 2)
INSERT [dbo].[Сделка] ([Код], [Количество], [Дата], [Код_Товара], [Код_Клиента]) VALUES (4, 1, CAST(N'2017-08-02' AS Date), 2, 3)
INSERT [dbo].[Сделка] ([Код], [Количество], [Дата], [Код_Товара], [Код_Клиента]) VALUES (5, 1, CAST(N'2017-09-02' AS Date), 1, 5)
SET IDENTITY_INSERT [dbo].[Сделка] OFF
SET IDENTITY_INSERT [dbo].[Товар] ON 

INSERT [dbo].[Товар] ([Код], [Название], [Цена], [Сорт], [Оттенок], [Город]) VALUES (1, N'Т1        ', 10000, NULL, NULL, NULL)
INSERT [dbo].[Товар] ([Код], [Название], [Цена], [Сорт], [Оттенок], [Город]) VALUES (2, N'Т2        ', 100000, NULL, NULL, NULL)
INSERT [dbo].[Товар] ([Код], [Название], [Цена], [Сорт], [Оттенок], [Город]) VALUES (3, N'Т3        ', 1000, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Товар] OFF
ALTER TABLE [dbo].[Сделка]  WITH CHECK ADD  CONSTRAINT [FK_Сделка_Клиент] FOREIGN KEY([Код_Клиента])
REFERENCES [dbo].[Клиент] ([Код])
GO
ALTER TABLE [dbo].[Сделка] CHECK CONSTRAINT [FK_Сделка_Клиент]
GO
ALTER TABLE [dbo].[Сделка]  WITH CHECK ADD  CONSTRAINT [FK_Сделка_Товар] FOREIGN KEY([Код_Товара])
REFERENCES [dbo].[Товар] ([Код])
GO
ALTER TABLE [dbo].[Сделка] CHECK CONSTRAINT [FK_Сделка_Товар]
GO
/****** Object:  StoredProcedure [dbo].[ClientDelete]    Script Date: 23.05.2017 23:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[ClientDelete]
@Код int
as
Delete Клиент
Where
Код= @Код
GO
/****** Object:  StoredProcedure [dbo].[ClientInsert]    Script Date: 23.05.2017 23:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ClientInsert]
@ФИО nchar(10), @Фирма nchar(10), @Город nchar(10), @Телефон nchar(10)
as
Insert into Клиент
values (@ФИО, @Фирма, @Город, @Телефон);


GO
/****** Object:  StoredProcedure [dbo].[ClientUpdate]    Script Date: 23.05.2017 23:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[ClientUpdate]
@Код int, @ФИО nchar(10), @Фирма nchar(10), @Город nchar(10), @Телефон nchar(10)
as
Update Клиент
set ФИО = @ФИО, Фирма = @Фирма,Город= @Город,Телефон =  @Телефон
Where
Код= @Код;


GO
/****** Object:  StoredProcedure [dbo].[Sample_Proc]    Script Date: 23.05.2017 23:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--создать процедуру опред. кол-ва сделок по заданому товару в заданом месяце текущего года
create proc [dbo].[Sample_Proc] @КолСделок int output, @КодТовара int, @НомерМесяца int
as
select @КолСделок = COUNT(Сделка.Код)
from Сделка
where Код_Товара = @КодТовара 
and MONTH(Дата) = @НомерМесяца
and YEAR(GETDATE()) = YEAR(Дата);

GO
/****** Object:  StoredProcedure [dbo].[sampleSelect]    Script Date: 23.05.2017 23:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sampleSelect] @fio varchar(20) 
as
select * from Клиент
where Клиент.ФИО = @fio
GO
