USE [ScSc]
GO
/****** Object:  Table [dbo].[ApplicationTBs]    Script Date: 29.05.2023 22:07:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ApplicationTBs](
	[ID_application] [int] IDENTITY(1,1) NOT NULL,
	[FIO_application] [nvarchar](50) NOT NULL,
	[Application] [nvarchar](300) NOT NULL,
	[Status_application] [nvarchar](1) NULL,
 CONSTRAINT [PK_ApplicationTBs] PRIMARY KEY CLUSTERED 
(
	[ID_application] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Class]    Script Date: 29.05.2023 22:07:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class](
	[ID_class] [int] NOT NULL,
	[Number] [nvarchar](2) NOT NULL,
	[letter] [nvarchar](1) NOT NULL,
 CONSTRAINT [PK_Class] PRIMARY KEY CLUSTERED 
(
	[ID_class] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClassLesson]    Script Date: 29.05.2023 22:07:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClassLesson](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ID_class] [int] NULL,
	[ID_lessons] [int] NULL,
	[Day_Life] [tinyint] NULL,
	[Lesson_Number] [int] NULL,
 CONSTRAINT [PK_ClassLesson] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lessons]    Script Date: 29.05.2023 22:07:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lessons](
	[ID_lessons] [int] NOT NULL,
	[lessons] [nvarchar](30) NOT NULL,
	[Сabinet_Number] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Lessons] PRIMARY KEY CLUSTERED 
(
	[ID_lessons] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rols]    Script Date: 29.05.2023 22:07:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rols](
	[User_Rols] [int] NOT NULL,
	[Rols] [nchar](30) NOT NULL,
 CONSTRAINT [PK_Rols] PRIMARY KEY CLUSTERED 
(
	[User_Rols] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 29.05.2023 22:07:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[id_User] [int] NOT NULL,
	[User_Name] [nvarchar](50) NOT NULL,
	[User_Password] [nvarchar](50) NOT NULL,
	[User_Rols] [int] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[id_User] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ClassLesson]  WITH CHECK ADD  CONSTRAINT [FK_ClassLesson_Lessons] FOREIGN KEY([ID_lessons])
REFERENCES [dbo].[Lessons] ([ID_lessons])
GO
ALTER TABLE [dbo].[ClassLesson] CHECK CONSTRAINT [FK_ClassLesson_Lessons]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Rols] FOREIGN KEY([User_Rols])
REFERENCES [dbo].[Rols] ([User_Rols])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Rols]
GO
/****** Object:  StoredProcedure [dbo].[MaintainIdOrderProcedure]    Script Date: 29.05.2023 22:07:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MaintainIdOrderProcedure]
AS
BEGIN
    -- Создаем временную таблицу для сохранения данных
    CREATE TABLE #TempTable (
        NewId INT IDENTITY(1, 1),
        ID_class INT,
        ID_lessons INT,
        Day_Life TINYINT,
        Lesson_Number INT        
    );

    -- Вставляем данные из таблицы ClassLesson во временную таблицу
    INSERT INTO #TempTable (ID_class, ID_lessons, Day_Life, Lesson_Number)
    SELECT ID_class, ID_lessons, Day_Life, Lesson_Number 
    FROM ClassLesson;

    -- Удаляем все строки из таблицы ClassLesson
    DELETE FROM ClassLesson;

    -- Сбрасываем автоинкрементное значение идентификатора
    DBCC CHECKIDENT ('ClassLesson', RESEED, 0);

    -- Включаем параметр IDENTITY_INSERT для таблицы ClassLesson
    SET IDENTITY_INSERT ClassLesson ON;

    -- Вставляем данные обратно в таблицу ClassLesson с обновленными идентификаторами
    INSERT INTO ClassLesson (id, ID_class, ID_lessons, Day_Life, Lesson_Number)
    SELECT NewId, ID_class, ID_lessons, Day_Life, Lesson_Number
    FROM #TempTable;

    -- Выключаем параметр IDENTITY_INSERT
    SET IDENTITY_INSERT ClassLesson OFF;

    -- Удаляем временную таблицу
    DROP TABLE #TempTable;
END;
GO
