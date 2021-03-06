/****** Object:  Table [dbo].[Courpus]    Script Date: 17.05.2022 18:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courpus](
	[Corpus_ID] [int] IDENTITY(1,1) NOT NULL,
	[CorpusName] [nvarchar](15) NOT NULL,
	[RoomCount] [smallint] NOT NULL,
	[RoomNumber] [smallint] NOT NULL,
	[RoomCapacity] [smallint] NOT NULL,
	[Capacity] [smallint] NOT NULL,
 CONSTRAINT [PK_Courpus] PRIMARY KEY CLUSTERED 
(
	[Corpus_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 17.05.2022 18:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Student_ID] [int] IDENTITY(1,1) NOT NULL,
	[Corpus_ID] [int] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[DOB] [nvarchar](20) NOT NULL,
	[Qroup] [nvarchar](15) NOT NULL,
	[Phone] [nvarchar](25) NOT NULL,
	[Other] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[Student_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[General1]    Script Date: 17.05.2022 18:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[General1]
AS
SELECT        dbo.Student.Student_ID, dbo.Student.Corpus_ID, dbo.Courpus.RoomNumber, dbo.Student.Name, dbo.Student.Address, dbo.Student.Qroup, dbo.Student.Phone, dbo.Student.Other
FROM            dbo.Courpus INNER JOIN
                         dbo.Student ON dbo.Courpus.Corpus_ID = dbo.Student.Corpus_ID
GO
/****** Object:  Table [dbo].[Aeroport]    Script Date: 17.05.2022 18:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aeroport](
	[Aeroport_ID] [int] NOT NULL,
	[Adi] [nvarchar](max) NOT NULL,
	[Yerləşdiyi_yer] [nvarchar](max) NOT NULL,
	[IATA] [nvarchar](max) NOT NULL,
	[ICAO] [nvarchar](max) NOT NULL,
	[Koordinatlar] [nvarchar](max) NOT NULL,
	[UEZ] [nvarchar](max) NOT NULL,
	[Şəkil_Bayraq] [nvarchar](max) NOT NULL,
	[Şəkil_Aeroport] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Aeroport] PRIMARY KEY CLUSTERED 
(
	[Aeroport_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[General]    Script Date: 17.05.2022 18:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[General](
	[General_ID] [int] IDENTITY(1,1) NOT NULL,
	[RoomNumber] [smallint] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Qroup] [nvarchar](15) NOT NULL,
	[Phone] [nvarchar](25) NOT NULL,
	[Other] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK_General_1] PRIMARY KEY CLUSTERED 
(
	[General_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[İsci]    Script Date: 17.05.2022 18:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[İsci](
	[İsci_ID] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](50) NOT NULL,
	[Soyad] [nvarchar](50) NOT NULL,
	[Cinsi] [nvarchar](50) NOT NULL,
	[Yas] [nvarchar](50) NOT NULL,
	[Tevellud] [nvarchar](50) NOT NULL,
	[Doguldugu_yer] [nvarchar](50) NOT NULL,
	[FİN] [nvarchar](7) NOT NULL,
	[İse_Basladi] [nvarchar](12) NOT NULL,
	[İsden_Cix] [nvarchar](12) NOT NULL,
	[İs_Veziyyeti] [nvarchar](20) NOT NULL,
	[Vezife] [nvarchar](50) NOT NULL,
	[Maas] [nvarchar](50) NOT NULL,
	[Unvan] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Telefon] [nvarchar](50) NOT NULL,
	[Sekil] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_İsci] PRIMARY KEY CLUSTERED 
(
	[İsci_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teyyare]    Script Date: 17.05.2022 18:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teyyare](
	[Teyyare_ID] [int] IDENTITY(1,1) NOT NULL,
	[Adı] [nvarchar](50) NOT NULL,
	[Növü] [nvarchar](50) NOT NULL,
	[Mənşə] [nvarchar](50) NOT NULL,
	[İstehsalçı] [nvarchar](50) NOT NULL,
	[Uçuş_Heyyəti] [nvarchar](50) NOT NULL,
	[Uzunluğu] [nvarchar](50) NOT NULL,
	[Hündürlüyü] [nvarchar](50) NOT NULL,
	[Sərnişin_Tutumu] [nvarchar](50) NOT NULL,
	[Qaldırdığı_Çəki] [nvarchar](50) NOT NULL,
	[Şəkil] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Teyyare] PRIMARY KEY CLUSTERED 
(
	[Teyyare_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Aeroport] ([Aeroport_ID], [Adi], [Yerləşdiyi_yer], [IATA], [ICAO], [Koordinatlar], [UEZ], [Şəkil_Bayraq], [Şəkil_Aeroport]) VALUES (1, N'Bakı Beynəlxalq Hava Limanı', N'
Bakı, Azərbaycan', N'GYD', N'UBBB', N'40 28''00"N, 050*02''60"E', N'4.000 x 60 m', N'E:\C#-təcürbə\Project\WindowsFormsApp1\Resources\bay.png', N'E:\C#-təcürbə\Project\WindowsFormsApp1\Resources\Baki.jpg')
INSERT [dbo].[Aeroport] ([Aeroport_ID], [Adi], [Yerləşdiyi_yer], [IATA], [ICAO], [Koordinatlar], [UEZ], [Şəkil_Bayraq], [Şəkil_Aeroport]) VALUES (2, N'Gəncə Beynəlxalq Hava Limanı', N'
Gəncə, Azərbaycan', N'KVD', N'UBBG', N'40° 44'' 16" N, 46° 19'' 3" E', N'2,505 x 44 m', N'E:\C#-təcürbə\Project\WindowsFormsApp1\Resources\bay.png', N'E:\C#-təcürbə\Project\WindowsFormsApp1\Resources\Gence.jpg')
INSERT [dbo].[Aeroport] ([Aeroport_ID], [Adi], [Yerləşdiyi_yer], [IATA], [ICAO], [Koordinatlar], [UEZ], [Şəkil_Bayraq], [Şəkil_Aeroport]) VALUES (3, N'Naxçıvan Hava Limanı', N'Naxçıvan, AZƏRBAYCAN', N'NAJ', N'UBBN', N'39° 11'' 19" N, 45° 27'' 30" E', N'3,300 x 42 m, 3,300 x 45 m', N'E:\C#-təcürbə\Project\WindowsFormsApp1\Resources\bay.png', N'E:\C#-təcürbə\Project\WindowsFormsApp1\Resources\Naxcivan.jpg')
INSERT [dbo].[Aeroport] ([Aeroport_ID], [Adi], [Yerləşdiyi_yer], [IATA], [ICAO], [Koordinatlar], [UEZ], [Şəkil_Bayraq], [Şəkil_Aeroport]) VALUES (4, N'Zaqatala Beynəlxalq Hava Limanı', N'Zaqatala, Azərbaycan', N'ZTU', N'UBBY
', N'41° 33'' 44" N, 46° 40'' 2" E
', N'3000m
', N'E:\C#-təcürbə\Project\WindowsFormsApp1\Resources\bay.png', N'E:\C#-təcürbə\Project\WindowsFormsApp1\Resources\Zaqatala.jpg')
INSERT [dbo].[Aeroport] ([Aeroport_ID], [Adi], [Yerləşdiyi_yer], [IATA], [ICAO], [Koordinatlar], [UEZ], [Şəkil_Bayraq], [Şəkil_Aeroport]) VALUES (5, N'London Heathrow Hava Limanı
', N'London, BIRLEŞIK KRALLIK
', N'LHR
', N'EGLL
', N'51° 28'' 39" N, 0° 27'' 41" W
', N'3902m,3660m
', N'E:\C#-təcürbə\Project\WindowsFormsApp1\Resources\bayLon.jpg', N'E:\C#-təcürbə\Project\WindowsFormsApp1\Resources\London.jpg')
INSERT [dbo].[Aeroport] ([Aeroport_ID], [Adi], [Yerləşdiyi_yer], [IATA], [ICAO], [Koordinatlar], [UEZ], [Şəkil_Bayraq], [Şəkil_Aeroport]) VALUES (6, N'Bournemouth Hava Limani
', N'Bournemouth, BIRLEŞİK KRALLIK
', N'BOH
', N'EGHH
', N'50° 46'' 48" N, 1° 50'' 33" W ', N'2271m
', N'E:\C#-təcürbə\Project\WindowsFormsApp1\Resources\bayLon.jpg', N'E:\C#-təcürbə\Project\WindowsFormsApp1\Resources\Bour.jpg')
INSERT [dbo].[Aeroport] ([Aeroport_ID], [Adi], [Yerləşdiyi_yer], [IATA], [ICAO], [Koordinatlar], [UEZ], [Şəkil_Bayraq], [Şəkil_Aeroport]) VALUES (7, N'London Luton Hava limanı
', N'London, BİRLEŞİK KRALLIK
', N'LTN
', N'EGGW
', N'51 52''29″N 000 22''06"W
', N'2162m
', N'E:\C#-təcürbə\Project\WindowsFormsApp1\Resources\bayLon.jpg', N'E:\C#-təcürbə\Project\WindowsFormsApp1\Resources\Lotur.jpg')
INSERT [dbo].[Aeroport] ([Aeroport_ID], [Adi], [Yerləşdiyi_yer], [IATA], [ICAO], [Koordinatlar], [UEZ], [Şəkil_Bayraq], [Şəkil_Aeroport]) VALUES (8, N'Frankfurt am Main Hava limanı
', N'Frankfurt am Main, Hessen, ALMANYA
', N'FRA
', N'EDDF
', N'50°02′00″N 008°34′14″E
', N'2800m,4000m, 4000m, 4000m
', N'E:\C#-təcürbə\Project\WindowsFormsApp1\Resources\German.jpg', N'E:\C#-təcürbə\Project\WindowsFormsApp1\Resources\Frank.jpg')
INSERT [dbo].[Aeroport] ([Aeroport_ID], [Adi], [Yerləşdiyi_yer], [IATA], [ICAO], [Koordinatlar], [UEZ], [Şəkil_Bayraq], [Şəkil_Aeroport]) VALUES (9, N'Münhen hava limanı
', N'Münih, Bavariya, ALMANYA
', N'MUC
', N'EDDM
', N'48°21′14″N 011°47′10″E
48°21′14″N 011°47′10″E
', N'4000m, 4000m
', N'E:\C#-təcürbə\Project\WindowsFormsApp1\Resources\German.jpg', N'E:\C#-təcürbə\Project\WindowsFormsApp1\Resources\Munich.jpg')
INSERT [dbo].[Aeroport] ([Aeroport_ID], [Adi], [Yerləşdiyi_yer], [IATA], [ICAO], [Koordinatlar], [UEZ], [Şəkil_Bayraq], [Şəkil_Aeroport]) VALUES (10, N'Berlin Brandenburg Hava limani
', N'Berlin, Brandenburg, ALMANYA
', N'BER
', N'EDDB
', N'52°22''00"N 013 30''12"E
', N'3600m,4000m
', N'E:\C#-təcürbə\Project\WindowsFormsApp1\Resources\German.jpg', N'E:\C#-təcürbə\Project\WindowsFormsApp1\Resources\Berlin.jpg')
INSERT [dbo].[Aeroport] ([Aeroport_ID], [Adi], [Yerləşdiyi_yer], [IATA], [ICAO], [Koordinatlar], [UEZ], [Şəkil_Bayraq], [Şəkil_Aeroport]) VALUES (11, N'Hamburg Helmut Schmidt Hava lima....
', N'Hamburg, ALMANYA
', N'HAM
', N'EDDH
', N'53°37′49″N 009°59′28″E
', N'3250m,3666m
', N'E:\C#-təcürbə\Project\WindowsFormsApp1\Resources\German.jpg', N'E:\C#-təcürbə\Project\WindowsFormsApp1\Resources\Ham.jpg')
INSERT [dbo].[Aeroport] ([Aeroport_ID], [Adi], [Yerləşdiyi_yer], [IATA], [ICAO], [Koordinatlar], [UEZ], [Şəkil_Bayraq], [Şəkil_Aeroport]) VALUES (12, N'Dresden Hava limanı
', N'Dresden, Saksoniya, ALMANYA
', N'DRS
', N'EDDC
', N'51°08′04″N 13°46''05"E
', N'2850m
', N'E:\C#-təcürbə\Project\WindowsFormsApp1\Resources\German.jpg', N'E:\C#-təcürbə\Project\WindowsFormsApp1\Resources\Dresdenjpg.jpg')
GO
SET IDENTITY_INSERT [dbo].[Courpus] ON 

INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (1, N'3', 36, 301, 2, 105)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (2, N'3', 36, 302, 3, 105)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (3, N'3', 36, 303, 2, 105)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (4, N'3', 36, 304, 3, 105)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (5, N'3', 36, 305, 3, 105)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (6, N'3', 36, 306, 3, 105)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (7, N'3', 36, 307, 2, 105)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (8, N'3', 36, 308, 3, 105)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (9, N'3', 36, 309, 3, 105)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (10, N'3', 36, 310, 3, 105)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (11, N'3', 36, 311, 2, 105)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (12, N'3', 36, 312, 4, 105)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (13, N'3', 36, 313, 2, 105)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (14, N'2', 23, 201, 2, 95)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (15, N'2', 23, 202, 2, 95)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (16, N'2', 23, 203, 3, 95)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (17, N'2', 23, 204, 2, 95)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (18, N'2', 23, 205, 3, 95)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (19, N'2', 23, 206, 3, 95)
INSERT [dbo].[Courpus] ([Corpus_ID], [CorpusName], [RoomCount], [RoomNumber], [RoomCapacity], [Capacity]) VALUES (20, N'2', 23, 207, 3, 95)
SET IDENTITY_INSERT [dbo].[Courpus] OFF
GO
SET IDENTITY_INSERT [dbo].[General] ON 

INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (1, 304, N'Pasayev Damir Esqin', N'Gəncə şəhəri', N'1449a', N'125135561', N'655412654')
INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (2, 308, N'Cabbarov Mehdi Elsen', N'Göygöl rayonu', N'1449a', N'655412654', N'216551125')
INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (3, 301, N'Veliyev Abbas Qalib', N'Balakən rayonu', N'1159r', N'456484854', N'564848588')
INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (4, 302, N'Talibov Eli Sahib', N'Qax rayonu', N'2441a', N'652512314', N'456541511')
INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (5, 303, N'Eliyev Abutalib Abbas', N'Lənkaran', N'1159i', N'564541465', N'585444444')
INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (6, 305, N'Qenberov Esqin Veli', N'Lerik', N'1459a', N'465415454', N'656556212')
INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (7, 306, N'Memmedov Eli Talib', N'Gəncə', N'2440r', N'465654151', N'564848888')
INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (8, 307, N'Eliyev Mehemmed Xeqani', N'Daşkəsən', N'2441r', N'985565886', N'556588899')
INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (9, 304, N'Eliyev Eli Eli', N'Qax', N'1449a', N'554548665', N'845441215')
INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (10, 309, N'Xelilov Xalil Xeqani', N'Gəncə', N'1241a', N'564585448', N'668548228')
INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (11, 310, N'Ekbarov Veli Elsen', N'Lənkaran', N'1459a', N'654122558', N'884454747')
INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (12, 311, N'Memmedli Xelil Eli', N'Göycay', N'1159a', N'635448545', N'546588836')
INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (13, 312, N'Seferov Ruzi Bayram', N'Gəncə', N'1131i', N'456454155', N'645488665')
INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (14, 301, N'Bayramov Ferid Abbas', N'Daşkəsən', N'1121r', N'688688545', N'456848688')
INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (15, 313, N'Canbarev Umid Ramin', N'Lerik', N'1159a', N'645658885', N'546468888')
INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (16, 201, N'Əkbərov Dunyamali Aqil', N'Sumqayit', N'1449a', N'644885566', N'564566844')
INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (17, 203, N'Mammadzada Aqil Qabil', N'Lerik', N'1449a', N'545485555', N'457184187')
INSERT [dbo].[General] ([General_ID], [RoomNumber], [Name], [Address], [Qroup], [Phone], [Other]) VALUES (18, 204, N'Bayramov Aqil Eli', N'Gəncə', N'1121i', N'665455548', N'545474744')
SET IDENTITY_INSERT [dbo].[General] OFF
GO
SET IDENTITY_INSERT [dbo].[İsci] ON 

INSERT [dbo].[İsci] ([İsci_ID], [Ad], [Soyad], [Cinsi], [Yas], [Tevellud], [Doguldugu_yer], [FİN], [İse_Basladi], [İsden_Cix], [İs_Veziyyeti], [Vezife], [Maas], [Unvan], [Email], [Telefon], [Sekil]) VALUES (7, N'Ləman', N'İsmayilova', N'Q', N'19', N'24.02.2003', N'Gence', N'1dsvsd8', N'23.03.2019', N'-', N'İsleyir', N'Front-End', N'1300', N'Gence sh. ev4', N'leman@mail.ru', N'45612378', N'E:\C#\Təcürbə\Classes\kiz2.jpg')
INSERT [dbo].[İsci] ([İsci_ID], [Ad], [Soyad], [Cinsi], [Yas], [Tevellud], [Doguldugu_yer], [FİN], [İse_Basladi], [İsden_Cix], [İs_Veziyyeti], [Vezife], [Maas], [Unvan], [Email], [Telefon], [Sekil]) VALUES (8, N'Aytac', N'Veysli', N'Q', N'20', N'24.02.2002', N'Gence', N'3ddscs9', N'07.01.2019', N'-', N'İsleyir', N'Dizainer', N'1000', N'Gence sh. ev6', N'aitac@mail.ru', N'12345645', N'E:\C#\Təcürbə\Classes\kiz2.jpg')
INSERT [dbo].[İsci] ([İsci_ID], [Ad], [Soyad], [Cinsi], [Yas], [Tevellud], [Doguldugu_yer], [FİN], [İse_Basladi], [İsden_Cix], [İs_Veziyyeti], [Vezife], [Maas], [Unvan], [Email], [Telefon], [Sekil]) VALUES (9, N'Demir', N'Pashayev', N'K', N'21', N'01.01.2001', N'Gence', N'7gsach1', N'28.01.2018', N'-', N'İsleyir', N'Back-End', N'2300', N'Gence sh. ev5', N'pashayev@mail.ru', N'75488787', N'E:\C#\Təcürbə\Classes\chibi.jpg')
INSERT [dbo].[İsci] ([İsci_ID], [Ad], [Soyad], [Cinsi], [Yas], [Tevellud], [Doguldugu_yer], [FİN], [İse_Basladi], [İsden_Cix], [İs_Veziyyeti], [Vezife], [Maas], [Unvan], [Email], [Telefon], [Sekil]) VALUES (10, N'Mehdi', N'Cabbarov', N'K', N'20', N'24.01.2002', N'Goycay', N'6sacas2', N'28.02.2020', N'-', N'İsleyir', N'Security', N'2500', N'Baki sh. Caxrli kendi', N'mexdi@mail.ru', N'54785578', N'E:\C#\Təcürbə\Classes\123.jpg')
INSERT [dbo].[İsci] ([İsci_ID], [Ad], [Soyad], [Cinsi], [Yas], [Tevellud], [Doguldugu_yer], [FİN], [İse_Basladi], [İsden_Cix], [İs_Veziyyeti], [Vezife], [Maas], [Unvan], [Email], [Telefon], [Sekil]) VALUES (11, N'Aqil', N'Memmedzade', N'K', N'20', N'17.01.2002', N'Baki', N'5kacna3', N'18.02.2020', N'-', N'İsleyir', N'Menecer', N'2500', N'Agsu sh. Caxrli kendi', N'alim_56@mail.ru', N'56655456', N'E:\C#\Təcürbə\Classes\aqil.jpg')
INSERT [dbo].[İsci] ([İsci_ID], [Ad], [Soyad], [Cinsi], [Yas], [Tevellud], [Doguldugu_yer], [FİN], [İse_Basladi], [İsden_Cix], [İs_Veziyyeti], [Vezife], [Maas], [Unvan], [Email], [Telefon], [Sekil]) VALUES (12, N'Bahadur', N'Quliyev', N'K', N'20', N'18.01.2002', N'Sumqayit', N'1urjmx5', N'01.02.2020', N'-', N'İsleyir', N'Direktor', N'3500', N'Sirvan sh. Caxrli kendi', N'hesen123@mail.ru', N'89878878', N'E:\C#\Təcürbə\Classes\cartoons.jpg')
INSERT [dbo].[İsci] ([İsci_ID], [Ad], [Soyad], [Cinsi], [Yas], [Tevellud], [Doguldugu_yer], [FİN], [İse_Basladi], [İsden_Cix], [İs_Veziyyeti], [Vezife], [Maas], [Unvan], [Email], [Telefon], [Sekil]) VALUES (13, N'Solmaz', N'Eliyeva', N'Q', N'22', N'19.01.2000', N'Samaxi', N'3nbxcv4', N'08.02.2021', N'-', N'İsleyir', N'Muavin', N'1250', N'Tovuz sh. Caxrli kendi', N'sbai333@mail.ru', N'65523112', N'E:\C#\Təcürbə\Classes\kiz1.jpg')
INSERT [dbo].[İsci] ([İsci_ID], [Ad], [Soyad], [Cinsi], [Yas], [Tevellud], [Doguldugu_yer], [FİN], [İse_Basladi], [İsden_Cix], [İs_Veziyyeti], [Vezife], [Maas], [Unvan], [Email], [Telefon], [Sekil]) VALUES (14, N'Cabir', N'Qedirov', N'K', N'22', N'09.04.2000', N'Naxcivan', N'2bnvhg7', N'17.02.2018', N'-', N'İsleyir', N'Full-Stek', N'2750', N'Baki sh. Caxrli kendi', N'ashah22@mail.ru', N'75461234', N'E:\C#\Təcürbə\Classes\deba.jpg')
INSERT [dbo].[İsci] ([İsci_ID], [Ad], [Soyad], [Cinsi], [Yas], [Tevellud], [Doguldugu_yer], [FİN], [İse_Basladi], [İsden_Cix], [İs_Veziyyeti], [Vezife], [Maas], [Unvan], [Email], [Telefon], [Sekil]) VALUES (43, N'Ken', N'Sánchez', N'Q', N'19', N'29.01.1969', N'Bothell', N'1dsvsd8', N'23.03.2019', N'-', N'İsleyir', N'Chief Executive Officer', N'1300', N'5747 Shirley Drive', N'ken0@adventure-works.com', N'45612378', N'E:\C#\Təcürbə\Classes\kiz2.jpg')
INSERT [dbo].[İsci] ([İsci_ID], [Ad], [Soyad], [Cinsi], [Yas], [Tevellud], [Doguldugu_yer], [FİN], [İse_Basladi], [İsden_Cix], [İs_Veziyyeti], [Vezife], [Maas], [Unvan], [Email], [Telefon], [Sekil]) VALUES (44, N'Terri', N'Duffy', N'Q', N'20', N'1.08.1971', N'Portland', N'3ddscs9', N'7.01.2019', N'-', N'İsleyir', N'Vice President of Engineering', N'1000', N'636 Vine Hill Way', N'terri0@adventure-works.com', N'12345645', N'E:\C#\Təcürbə\Classes\kiz2.jpg')
INSERT [dbo].[İsci] ([İsci_ID], [Ad], [Soyad], [Cinsi], [Yas], [Tevellud], [Doguldugu_yer], [FİN], [İse_Basladi], [İsden_Cix], [İs_Veziyyeti], [Vezife], [Maas], [Unvan], [Email], [Telefon], [Sekil]) VALUES (45, N'Roberto', N'Tamburello', N'K', N'21', N'12.11.1974', N'Seattle', N'7gsach1', N'28.01.2018', N'-', N'İsleyir', N'Engineering Manager', N'2300', N'6657 Sand Pointe Lane', N'roberto0@adventure-works.com', N'75488787', N'E:\C#\Təcürbə\Classes\chibi.jpg')
INSERT [dbo].[İsci] ([İsci_ID], [Ad], [Soyad], [Cinsi], [Yas], [Tevellud], [Doguldugu_yer], [FİN], [İse_Basladi], [İsden_Cix], [İs_Veziyyeti], [Vezife], [Maas], [Unvan], [Email], [Telefon], [Sekil]) VALUES (46, N'Rob', N'Walters', N'K', N'20', N'23.12.1974', N'Duluth', N'6sacas2', N'28.02.2020', N'-', N'İsleyir', N'Senior Tool Designer', N'2500', N'80 Sunview Terrace', N'rob0@adventure-works.com', N'54785578', N'E:\C#\Təcürbə\Classes\123.jpg')
INSERT [dbo].[İsci] ([İsci_ID], [Ad], [Soyad], [Cinsi], [Yas], [Tevellud], [Doguldugu_yer], [FİN], [İse_Basladi], [İsden_Cix], [İs_Veziyyeti], [Vezife], [Maas], [Unvan], [Email], [Telefon], [Sekil]) VALUES (47, N'Gail', N'Erickson', N'K', N'20', N'27.09.1952', N'Dallas', N'5kacna3', N'18.02.2020', N'-', N'İsleyir', N'Design Engineer', N'2500', N'9178 Jumping St.', N'gail0@adventure-works.com', N'56655456', N'E:\C#\Təcürbə\Classes\aqil.jpg')
INSERT [dbo].[İsci] ([İsci_ID], [Ad], [Soyad], [Cinsi], [Yas], [Tevellud], [Doguldugu_yer], [FİN], [İse_Basladi], [İsden_Cix], [İs_Veziyyeti], [Vezife], [Maas], [Unvan], [Email], [Telefon], [Sekil]) VALUES (48, N'Jossef', N'Goldberg', N'K', N'20', N'11.03.1959', N'San Francisco', N'1urjmx5', N'1.02.2020', N'-', N'İsleyir', N'Design Engineer', N'3500', N'5725 Glaze Drive', N'jossef0@adventure-works.com', N'89878878', N'E:\C#\Təcürbə\Classes\cartoons.jpg')
INSERT [dbo].[İsci] ([İsci_ID], [Ad], [Soyad], [Cinsi], [Yas], [Tevellud], [Doguldugu_yer], [FİN], [İse_Basladi], [İsden_Cix], [İs_Veziyyeti], [Vezife], [Maas], [Unvan], [Email], [Telefon], [Sekil]) VALUES (49, N'Dylan', N'Miller', N'Q', N'22', N'24.02.1987', N'Nevada', N'3nbxcv4', N'8.02.2021', N'-', N'İsleyir', N'Research and Development Manager', N'1250', N'2487 Riverside Drive', N'dylan0@adventure-works.com', N'65523112', N'E:\C#\Təcürbə\Classes\kiz1.jpg')
INSERT [dbo].[İsci] ([İsci_ID], [Ad], [Soyad], [Cinsi], [Yas], [Tevellud], [Doguldugu_yer], [FİN], [İse_Basladi], [İsden_Cix], [İs_Veziyyeti], [Vezife], [Maas], [Unvan], [Email], [Telefon], [Sekil]) VALUES (50, N'Diane', N'Margheim', N'K', N'22', N'5.06.1986', N'Phoenix', N'2bnvhg7', N'17.02.2018', N'-', N'İsleyir', N'Research and Development Engineer', N'2750', N'9228 Via Del Sol', N'diane1@adventure-works.com', N'75461234', N'E:\C#\Təcürbə\Classes\deba.jpg')
INSERT [dbo].[İsci] ([İsci_ID], [Ad], [Soyad], [Cinsi], [Yas], [Tevellud], [Doguldugu_yer], [FİN], [İse_Basladi], [İsden_Cix], [İs_Veziyyeti], [Vezife], [Maas], [Unvan], [Email], [Telefon], [Sekil]) VALUES (51, N'Gigi', N'Matthew', N'K', N'22', N'21.01.1979', N'Memphis', N'2bnvhg7', N'17.02.2018', N'-', N'İsleyir', N'Research and Development Engineer', N'2750', N'8291 Crossbow Way', N'gigi0@adventure-works.com', N'75461234', N'E:\C#\Təcürbə\Classes\deba.jpg')
INSERT [dbo].[İsci] ([İsci_ID], [Ad], [Soyad], [Cinsi], [Yas], [Tevellud], [Doguldugu_yer], [FİN], [İse_Basladi], [İsden_Cix], [İs_Veziyyeti], [Vezife], [Maas], [Unvan], [Email], [Telefon], [Sekil]) VALUES (52, N'Michael', N'Raheem', N'K', N'21', N'30.11.1984', N'Orlando', N'7gsach1', N'28.01.2018', N'-', N'İsleyir', N'Research and Development Manager', N'2300', N'9707 Coldwater Drive', N'michael6@adventure-works.com', N'75488787', N'E:\C#\Təcürbə\Classes\chibi.jpg')
INSERT [dbo].[İsci] ([İsci_ID], [Ad], [Soyad], [Cinsi], [Yas], [Tevellud], [Doguldugu_yer], [FİN], [İse_Basladi], [İsden_Cix], [İs_Veziyyeti], [Vezife], [Maas], [Unvan], [Email], [Telefon], [Sekil]) VALUES (53, N'Ovidiu', N'Cracium', N'K', N'20', N'17.01.1978', N'Ottawa', N'6sacas2', N'28.02.2020', N'-', N'İsleyir', N'Senior Tool Designer', N'2500', N'9100 Sheppard Avenue North', N'ovidiu0@adventure-works.com', N'54785578', N'E:\C#\Təcürbə\Classes\123.jpg')
INSERT [dbo].[İsci] ([İsci_ID], [Ad], [Soyad], [Cinsi], [Yas], [Tevellud], [Doguldugu_yer], [FİN], [İse_Basladi], [İsden_Cix], [İs_Veziyyeti], [Vezife], [Maas], [Unvan], [Email], [Telefon], [Sekil]) VALUES (54, N'Thierry', N'Hers', N'K', N'20', N'29.07.1959', N'Montreal', N'5kacna3', N'18.02.2020', N'-', N'İsleyir', N'Tool Designer', N'2500', N'26910 Indela Road', N'thierry0@adventure-works.com', N'56655456', N'E:\C#\Təcürbə\Classes\aqil.jpg')
INSERT [dbo].[İsci] ([İsci_ID], [Ad], [Soyad], [Cinsi], [Yas], [Tevellud], [Doguldugu_yer], [FİN], [İse_Basladi], [İsden_Cix], [İs_Veziyyeti], [Vezife], [Maas], [Unvan], [Email], [Telefon], [Sekil]) VALUES (55, N'Janice', N'Galvin', N'K', N'20', N'28.05.1989', N'Calgary', N'1urjmx5', N'1.02.2020', N'-', N'İsleyir', N'Tool Designer', N'3500', N'10203 Acorn Avenue', N'janice0@adventure-works.com', N'89878878', N'E:\C#\Təcürbə\Classes\cartoons.jpg')
INSERT [dbo].[İsci] ([İsci_ID], [Ad], [Soyad], [Cinsi], [Yas], [Tevellud], [Doguldugu_yer], [FİN], [İse_Basladi], [İsden_Cix], [İs_Veziyyeti], [Vezife], [Maas], [Unvan], [Email], [Telefon], [Sekil]) VALUES (56, N'Michael', N'Sullivan', N'Q', N'22', N'16.06.1979', N'Bordeaux', N'3nbxcv4', N'8.02.2021', N'-', N'İsleyir', N'Senior Design Engineer', N'1250', N'94, rue Descartes', N'michael8@adventure-works.com', N'65523112', N'E:\C#\Təcürbə\Classes\kiz1.jpg')
INSERT [dbo].[İsci] ([İsci_ID], [Ad], [Soyad], [Cinsi], [Yas], [Tevellud], [Doguldugu_yer], [FİN], [İse_Basladi], [İsden_Cix], [İs_Veziyyeti], [Vezife], [Maas], [Unvan], [Email], [Telefon], [Sekil]) VALUES (57, N'Sharon', N'Salavaria', N'K', N'22', N'2.05.1961', N'Berlin', N'2bnvhg7', N'17.02.2018', N'-', N'İsleyir', N'Design Engineer', N'2750', N'Pascalstr 951', N'sharon0@adventure-works.com', N'75461234', N'E:\C#\Təcürbə\Classes\deba.jpg')
SET IDENTITY_INSERT [dbo].[İsci] OFF
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (1, 4, N'Pasayev Damir Esqin', N'Gəncə şəhəri', N'01/01/2001', N'1449a', N'125135561', N'655412654')
INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (2, 8, N'Cabbarov Mehdi Elsen', N'Göygöl rayonu', N'24/01/2002', N'1449a', N'655412654', N'216551125')
INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (3, 1, N'Veliyev Abbas Qalib', N'Balakən rayonu', N'02/01/2002', N'1159r', N'456484854', N'564848588')
INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (4, 2, N'Talibov Eli Sahib', N'Qax rayonu', N'12/01/2003', N'2441a', N'652512314', N'456541511')
INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (5, 3, N'Eliyev Abutalib Abbas', N'Lənkaran', N'06/10/2001', N'1159i', N'564541465', N'585444444')
INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (6, 5, N'Qenberov Esqin Veli', N'Lerik', N'08/06/2002', N'1459a', N'465415454', N'656556212')
INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (7, 6, N'Memmedov Eli Talib', N'Gəncə', N'07/11/2003', N'2440r', N'465654151', N'564848888')
INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (8, 7, N'Eliyev Mehemmed Xeqani', N'Daşkəsən', N'29/07/2003', N'2441r', N'985565886', N'556588899')
INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (9, 4, N'Eliyev Eli Eli', N'Qax', N'07/11/2002', N'1449a', N'554548665', N'845441215')
INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (10, 9, N'Xelilov Xalil Xeqani', N'Gəncə', N'08/03/2003', N'1241a', N'564585448', N'668548228')
INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (11, 10, N'Ekbarov Veli Elsen', N'Lənkaran', N'22/12/2002', N'1459a', N'654122558', N'884454747')
INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (12, 11, N'Memmedli Xelil Eli', N'Göycay', N'28/06/2002', N'1159a', N'635448545', N'546588836')
INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (13, 12, N'Seferov Ruzi Bayram', N'Gəncə', N'27/11/2002', N'1131i', N'456454155', N'645488665')
INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (14, 1, N'Bayramov Ferid Abbas', N'Daşkəsən', N'30/11/2002', N'1121r', N'688688545', N'456848688')
INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (15, 13, N'Canbarev Umid Ramin', N'Lerik', N'31/05/2002', N'1159a', N'645658885', N'546468888')
INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (16, 14, N'Əkbərov Dunyamali Aqil', N'Sumqayit', N'21/11/2001', N'1449a', N'644885566', N'564566844')
INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (17, 16, N'Mammadzada Aqil Qabil', N'Lerik', N'11/01/2002', N'1449a', N'545485555', N'457184187')
INSERT [dbo].[Student] ([Student_ID], [Corpus_ID], [Name], [Address], [DOB], [Qroup], [Phone], [Other]) VALUES (18, 17, N'Bayramov Aqil Eli', N'Gəncə', N'12/02/2002', N'1121i', N'665455548', N'545474744')
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
SET IDENTITY_INSERT [dbo].[Teyyare] ON 

INSERT [dbo].[Teyyare] ([Teyyare_ID], [Adı], [Növü], [Mənşə], [İstehsalçı], [Uçuş_Heyyəti], [Uzunluğu], [Hündürlüyü], [Sərnişin_Tutumu], [Qaldırdığı_Çəki], [Şəkil]) VALUES (1, N'Boeing 757', N'sernişin', N'ABŞ', N'Boenig', N'2-4', N'47', N'13.56', N'180', N'109315', N'E:\C#-təcürbə\Project\WindowsFormsApp1\Resources\Boeing.jpg')
INSERT [dbo].[Teyyare] ([Teyyare_ID], [Adı], [Növü], [Mənşə], [İstehsalçı], [Uçuş_Heyyəti], [Uzunluğu], [Hündürlüyü], [Sərnişin_Tutumu], [Qaldırdığı_Çəki], [Şəkil]) VALUES (2, N'Airbus 319-100', N'sernişin', N'çox millətli', N'Airbus Industrie', N'2-4', N'33.84', N'11.76', N'122', N'73500', N'E:\C#-təcürbə\Project\WindowsFormsApp1\Resources\319-100.jpg')
INSERT [dbo].[Teyyare] ([Teyyare_ID], [Adı], [Növü], [Mənşə], [İstehsalçı], [Uçuş_Heyyəti], [Uzunluğu], [Hündürlüyü], [Sərnişin_Tutumu], [Qaldırdığı_Çəki], [Şəkil]) VALUES (3, N'Boeing 767-300', N'sernişin', N'ABŞ', N'Boenig', N'2-6', N'54.94', N'15.85', N'198', N'186880', N'E:\C#-təcürbə\Project\WindowsFormsApp1\Resources\767-300.jpg')
INSERT [dbo].[Teyyare] ([Teyyare_ID], [Adı], [Növü], [Mənşə], [İstehsalçı], [Uçuş_Heyyəti], [Uzunluğu], [Hündürlüyü], [Sərnişin_Tutumu], [Qaldırdığı_Çəki], [Şəkil]) VALUES (4, N'Airbus A320', N'sernişin', N'çox millətli', N'Airbus Industrie', N'2-3', N'37.57', N'11.76', N'174', N'77000', N'E:\C#-təcürbə\Project\WindowsFormsApp1\Resources\A320.jpg')
INSERT [dbo].[Teyyare] ([Teyyare_ID], [Adı], [Növü], [Mənşə], [İstehsalçı], [Uçuş_Heyyəti], [Uzunluğu], [Hündürlüyü], [Sərnişin_Tutumu], [Qaldırdığı_Çəki], [Şəkil]) VALUES (5, N'Boeing 787-8 Dreamliner', N'sernişin', N'ABŞ', N'Boenig', N'2-4', N'56.72', N'16.92', N'210', N'2277930', N'E:\C#-təcürbə\Project\WindowsFormsApp1\Resources\787-8.jpg')
INSERT [dbo].[Teyyare] ([Teyyare_ID], [Adı], [Növü], [Mənşə], [İstehsalçı], [Uçuş_Heyyəti], [Uzunluğu], [Hündürlüyü], [Sərnişin_Tutumu], [Qaldırdığı_Çəki], [Şəkil]) VALUES (6, N'Airbus A340-500', N'sernişin', N'çox millətli', N'Airbus Industrie', N'2-4', N'67.87', N'17.29', N'237', N'380000', N'E:\C#-təcürbə\Project\WindowsFormsApp1\Resources\340-500.jpg')
INSERT [dbo].[Teyyare] ([Teyyare_ID], [Adı], [Növü], [Mənşə], [İstehsalçı], [Uçuş_Heyyəti], [Uzunluğu], [Hündürlüyü], [Sərnişin_Tutumu], [Qaldırdığı_Çəki], [Şəkil]) VALUES (7, N'JF-17 Thunder', N'çoxməqsədli', N'Pakistan,ÇXR', N'PAC,CAC', N'1', N'14.93', N'4.72', N'-', N'13', N'E:\C#-təcürbə\Project\WindowsFormsApp1\Resources\17.jpg')
INSERT [dbo].[Teyyare] ([Teyyare_ID], [Adı], [Növü], [Mənşə], [İstehsalçı], [Uçuş_Heyyəti], [Uzunluğu], [Hündürlüyü], [Sərnişin_Tutumu], [Qaldırdığı_Çəki], [Şəkil]) VALUES (9, N'MiQ-25', N'döyüş-kəşfiyyat', N'Rusiya,Hindistan', N'SSRİ', N'1', N'19.75', N'6.1', N'-', N'36000', N'E:\C#-təcürbə\Project\WindowsFormsApp1\Resources\MiG-25.jpg')
INSERT [dbo].[Teyyare] ([Teyyare_ID], [Adı], [Növü], [Mənşə], [İstehsalçı], [Uçuş_Heyyəti], [Uzunluğu], [Hündürlüyü], [Sərnişin_Tutumu], [Qaldırdığı_Çəki], [Şəkil]) VALUES (11, N'Su-25', N'hücum', N'Ulan,Tblis', N'SSRİ', N'1', N'15.53', N'4.8', N'-', N'19300', N'E:\C#-təcürbə\Project\WindowsFormsApp1\Resources\Su-25.jpg')
INSERT [dbo].[Teyyare] ([Teyyare_ID], [Adı], [Növü], [Mənşə], [İstehsalçı], [Uçuş_Heyyəti], [Uzunluğu], [Hündürlüyü], [Sərnişin_Tutumu], [Qaldırdığı_Çəki], [Şəkil]) VALUES (12, N'Su-17', N'bombardmançı', N'Rusiya', N'Suxoy Dizayn Bürosu', N'1', N'19.02', N'5.12', N'-', N'19430', N'E:\C#-təcürbə\Project\WindowsFormsApp1\Resources\Su-12.jpg')
SET IDENTITY_INSERT [dbo].[Teyyare] OFF
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Courpus] FOREIGN KEY([Corpus_ID])
REFERENCES [dbo].[Courpus] ([Corpus_ID])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Courpus]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Courpus"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Student"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'General1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'General1'
GO
