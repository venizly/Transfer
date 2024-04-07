USE [ProjectFinal1DB]
GO
ALTER TABLE [dbo].[TraSub] DROP CONSTRAINT [FK_TraSub_0_0]
GO
ALTER TABLE [dbo].[TransferSub] DROP CONSTRAINT [FK_TransferSub_2_0]
GO
ALTER TABLE [dbo].[TransferSub] DROP CONSTRAINT [FK_TransferSub_1_0]
GO
ALTER TABLE [dbo].[TransferSub] DROP CONSTRAINT [FK_TransferSub_0_0]
GO
ALTER TABLE [dbo].[TransferCourse] DROP CONSTRAINT [FK_TransferCourse_1_0]
GO
ALTER TABLE [dbo].[TransferCourse] DROP CONSTRAINT [FK_TransferCourse_0_0]
GO
ALTER TABLE [dbo].[TableTransfer] DROP CONSTRAINT [FK_TableTransfer_0_0]
GO
ALTER TABLE [dbo].[TableTransfer] DROP CONSTRAINT [FK__TableTran__UserI__28ED12D1]
GO
ALTER TABLE [dbo].[CsSubgroup] DROP CONSTRAINT [FK_CsSubgroup_0_0]
GO
ALTER TABLE [dbo].[CsCourseStruc] DROP CONSTRAINT [FK_CsCourseStruc_1_0]
GO
ALTER TABLE [dbo].[CsCourseStruc] DROP CONSTRAINT [FK_CsCourseStruc_0_0]
GO
/****** Object:  Table [dbo].[File]    Script Date: 4/8/2024 1:41:06 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[File]') AND type in (N'U'))
DROP TABLE [dbo].[File]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 4/8/2024 1:41:06 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AspNetUserTokens]') AND type in (N'U'))
DROP TABLE [dbo].[AspNetUserTokens]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 4/8/2024 1:41:06 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AspNetUserRoles]') AND type in (N'U'))
DROP TABLE [dbo].[AspNetUserRoles]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 4/8/2024 1:41:06 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AspNetUserLogins]') AND type in (N'U'))
DROP TABLE [dbo].[AspNetUserLogins]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 4/8/2024 1:41:06 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AspNetUserClaims]') AND type in (N'U'))
DROP TABLE [dbo].[AspNetUserClaims]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 4/8/2024 1:41:06 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AspNetRoles]') AND type in (N'U'))
DROP TABLE [dbo].[AspNetRoles]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 4/8/2024 1:41:06 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AspNetRoleClaims]') AND type in (N'U'))
DROP TABLE [dbo].[AspNetRoleClaims]
GO
/****** Object:  View [dbo].[V_DataUser]    Script Date: 4/8/2024 1:41:06 AM ******/
DROP VIEW [dbo].[V_DataUser]
GO
/****** Object:  Table [dbo].[Ins]    Script Date: 4/8/2024 1:41:06 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Ins]') AND type in (N'U'))
DROP TABLE [dbo].[Ins]
GO
/****** Object:  View [dbo].[V_CourseTra]    Script Date: 4/8/2024 1:41:06 AM ******/
DROP VIEW [dbo].[V_CourseTra]
GO
/****** Object:  View [dbo].[V_TransferSub]    Script Date: 4/8/2024 1:41:06 AM ******/
DROP VIEW [dbo].[V_TransferSub]
GO
/****** Object:  View [dbo].[V_CourseCsTra]    Script Date: 4/8/2024 1:41:06 AM ******/
DROP VIEW [dbo].[V_CourseCsTra]
GO
/****** Object:  View [dbo].[V_CourseCss]    Script Date: 4/8/2024 1:41:06 AM ******/
DROP VIEW [dbo].[V_CourseCss]
GO
/****** Object:  Table [dbo].[CsSubtype]    Script Date: 4/8/2024 1:41:06 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CsSubtype]') AND type in (N'U'))
DROP TABLE [dbo].[CsSubtype]
GO
/****** Object:  Table [dbo].[CsSubgroup]    Script Date: 4/8/2024 1:41:06 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CsSubgroup]') AND type in (N'U'))
DROP TABLE [dbo].[CsSubgroup]
GO
/****** Object:  View [dbo].[V_User_Tranfer_Course]    Script Date: 4/8/2024 1:41:06 AM ******/
DROP VIEW [dbo].[V_User_Tranfer_Course]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 4/8/2024 1:41:06 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AspNetUsers]') AND type in (N'U'))
DROP TABLE [dbo].[AspNetUsers]
GO
/****** Object:  Table [dbo].[TraSub]    Script Date: 4/8/2024 1:41:06 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TraSub]') AND type in (N'U'))
DROP TABLE [dbo].[TraSub]
GO
/****** Object:  Table [dbo].[TransferSub]    Script Date: 4/8/2024 1:41:06 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TransferSub]') AND type in (N'U'))
DROP TABLE [dbo].[TransferSub]
GO
/****** Object:  Table [dbo].[TransferCourse]    Script Date: 4/8/2024 1:41:06 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TransferCourse]') AND type in (N'U'))
DROP TABLE [dbo].[TransferCourse]
GO
/****** Object:  Table [dbo].[TraCourse]    Script Date: 4/8/2024 1:41:06 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TraCourse]') AND type in (N'U'))
DROP TABLE [dbo].[TraCourse]
GO
/****** Object:  Table [dbo].[TableTransfer]    Script Date: 4/8/2024 1:41:06 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TableTransfer]') AND type in (N'U'))
DROP TABLE [dbo].[TableTransfer]
GO
/****** Object:  Table [dbo].[CsCourseStruc]    Script Date: 4/8/2024 1:41:06 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CsCourseStruc]') AND type in (N'U'))
DROP TABLE [dbo].[CsCourseStruc]
GO
/****** Object:  Table [dbo].[CsCourse]    Script Date: 4/8/2024 1:41:06 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CsCourse]') AND type in (N'U'))
DROP TABLE [dbo].[CsCourse]
GO
/****** Object:  Table [dbo].[CsCourse]    Script Date: 4/8/2024 1:41:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CsCourse](
	[Codecoursecs] [int] NOT NULL,
	[Namecoursecs] [nvarchar](255) NULL,
	[statuscoursecs] [nvarchar](255) NULL,
 CONSTRAINT [sqlite_master_PK_CsCourse] PRIMARY KEY CLUSTERED 
(
	[Codecoursecs] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CsCourseStruc]    Script Date: 4/8/2024 1:41:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CsCourseStruc](
	[Codecssub] [int] NOT NULL,
	[Codecoursecs] [int] NOT NULL,
	[Codesubgroup] [int] NOT NULL,
	[Codesubcs] [nvarchar](255) NULL,
	[Namethaics] [nvarchar](255) NULL,
	[Nameengcs] [nvarchar](255) NULL,
	[Credits] [nvarchar](255) NULL,
	[Subdescs] [nvarchar](255) NULL,
	[Status] [nvarchar](255) NULL,
 CONSTRAINT [sqlite_autoindex_CsCourseStruc_1] PRIMARY KEY CLUSTERED 
(
	[Codecssub] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TableTransfer]    Script Date: 4/8/2024 1:41:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableTransfer](
	[TransReCode] [int] NOT NULL,
	[Transcode] [nvarchar](255) NULL,
	[CodeSubtran] [int] NOT NULL,
	[GradeTra] [nvarchar](255) NULL,
	[UserId] [nvarchar](255) NULL,
 CONSTRAINT [sqlite_autoindex_TableTransfer_1] PRIMARY KEY CLUSTERED 
(
	[TransReCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TraCourse]    Script Date: 4/8/2024 1:41:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TraCourse](
	[Codecoursetra] [int] NOT NULL,
	[Namecoursetra] [nvarchar](255) NULL,
	[statuscoursetra] [nvarchar](255) NULL,
 CONSTRAINT [sqlite_master_PK_TraCourse] PRIMARY KEY CLUSTERED 
(
	[Codecoursetra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TransferCourse]    Script Date: 4/8/2024 1:41:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransferCourse](
	[CodeCoursetrans] [int] NOT NULL,
	[Coursecs] [int] NOT NULL,
	[Coursetra] [int] NOT NULL,
 CONSTRAINT [sqlite_autoindex_TransferCourse_1] PRIMARY KEY CLUSTERED 
(
	[CodeCoursetrans] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TransferSub]    Script Date: 4/8/2024 1:41:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransferSub](
	[CodeSubtrans] [int] NOT NULL,
	[CodeCoursetran] [int] NOT NULL,
	[Codecs] [int] NOT NULL,
	[Codetra] [int] NOT NULL,
 CONSTRAINT [sqlite_autoindex_TransferSub_1] PRIMARY KEY CLUSTERED 
(
	[CodeSubtrans] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TraSub]    Script Date: 4/8/2024 1:41:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TraSub](
	[Codetrasub] [int] NOT NULL,
	[Codecourse] [int] NOT NULL,
	[Codesubtra] [nvarchar](255) NULL,
	[Namethaitra] [nvarchar](255) NULL,
	[Nameengtra] [nvarchar](255) NULL,
	[Credittra] [nvarchar](255) NULL,
	[Subdestra] [nvarchar](255) NULL,
	[Status] [nvarchar](255) NULL,
 CONSTRAINT [sqlite_autoindex_TraSub_1] PRIMARY KEY CLUSTERED 
(
	[Codetrasub] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 4/8/2024 1:41:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](255) NOT NULL,
	[FirstName] [nvarchar](255) NOT NULL,
	[LastName] [nvarchar](255) NOT NULL,
	[UserName] [nvarchar](255) NULL,
	[NormalizedUserName] [nvarchar](255) NULL,
	[Email] [nvarchar](255) NULL,
	[NormalizedEmail] [nvarchar](255) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](255) NULL,
	[SecurityStamp] [nvarchar](255) NULL,
	[ConcurrencyStamp] [nvarchar](255) NULL,
	[PhoneNumber] [nvarchar](255) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [nvarchar](255) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[Transcode] [nvarchar](255) NOT NULL,
	[Facebook] [nvarchar](255) NOT NULL,
	[Status] [nvarchar](255) NOT NULL,
	[InsCode] [int] NULL,
	[Codecoursetra] [int] NOT NULL,
	[CourseCs] [nvarchar](255) NULL,
 CONSTRAINT [sqlite_autoindex_AspNetUsers_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_User_Tranfer_Course]    Script Date: 4/8/2024 1:41:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE VIEW [dbo].[V_User_Tranfer_Course] As
SELECT 
Id,UserName
,AspNetUsers.Codecoursetra
,TraCourse.Namecoursetra
,AspNetUsers.CourseCs
,TransferCourse.CodeCoursetrans
,TraSub.Namethaitra
,CsCourseStruc.Namethaics
, CsCourse.Codecoursecs
,TableTransfer.TransReCode
,TableTransfer.GradeTra
,TransferSub.CodeSubtrans
FROM AspNetUsers
INNER JOIN TraCourse ON TraCourse.Codecoursetra = AspNetUsers.Codecoursetra
INNER JOIN CsCourse ON CAST(CsCourse.Namecoursecs as nvarchar) = CAST(AspNetUsers.CourseCs AS nvarchar)
INNER JOIN TransferCourse ON TransferCourse.Coursetra=TraCourse.Codecoursetra
AND TransferCourse.Coursecs = CsCourse.Codecoursecs
LEFT JOIN TransferSub ON TransferSub.CodeCoursetran =TransferCourse.CodeCoursetrans
LEFT JOIN CsCourseStruc ON CsCourseStruc.Codecssub = TransferSub.Codecs
LEFT JOIN TraSub ON TraSub.Codetrasub = TransferSub.Codetra
LEFT JOIN TableTransfer ON TableTransfer.CodeSubtran =TransferSub.CodeSubtrans AND AspNetUsers.ID = TableTransfer.UserId
GO
/****** Object:  Table [dbo].[CsSubgroup]    Script Date: 4/8/2024 1:41:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CsSubgroup](
	[Codesubgroup] [int] NOT NULL,
	[Codesubtype] [int] NOT NULL,
	[Namesubgroup] [nvarchar](255) NULL,
	[Credit] [nvarchar](255) NULL,
 CONSTRAINT [sqlite_autoindex_CsSubgroup_1] PRIMARY KEY CLUSTERED 
(
	[Codesubgroup] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CsSubtype]    Script Date: 4/8/2024 1:41:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CsSubtype](
	[Codesubtype] [int] NOT NULL,
	[Namesubtype] [nvarchar](255) NULL,
	[Credit] [nvarchar](255) NULL,
 CONSTRAINT [sqlite_master_PK_CsSubtype] PRIMARY KEY CLUSTERED 
(
	[Codesubtype] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_CourseCss]    Script Date: 4/8/2024 1:41:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_CourseCss] AS 
SELECT CsCourseStruc.Codecssub, CsCourse.Namecoursecs, CsSubgroup.Namesubgroup, CsSubtype.Namesubtype, CsCourseStruc.Codecoursecs, CsCourseStruc.Codesubgroup, CsCourseStruc.Codesubcs,  
                  CsCourseStruc.Namethaics, CsCourseStruc.Nameengcs, CsCourseStruc.Credits, CsCourseStruc.Subdescs, CsCourseStruc.Status 
FROM CsCourseStruc 
INNER JOIN CsCourse ON CsCourse.Codecoursecs = CsCourseStruc.Codecoursecs 
INNER JOIN CsSubgroup ON CsCourseStruc.Codesubgroup = CsSubgroup.Codesubgroup 
INNER JOIN CsSubtype ON CsSubgroup.Codesubtype = CsSubtype.Codesubtype;
GO
/****** Object:  View [dbo].[V_CourseCsTra]    Script Date: 4/8/2024 1:41:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_CourseCsTra] AS 
SELECT TransferCourse.CodeCoursetrans, TransferCourse.Coursecs, CsCourse.Namecoursecs, TransferCourse.Coursetra, TraCourse.Namecoursetra 
FROM TransferCourse 
INNER JOIN CsCourse ON CsCourse.Codecoursecs = TransferCourse.Coursecs 
INNER JOIN TraCourse ON TransferCourse.Coursetra = TraCourse.Codecoursetra;
GO
/****** Object:  View [dbo].[V_TransferSub]    Script Date: 4/8/2024 1:41:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_TransferSub] AS 
SELECT TransferSub.CodeSubtrans, TransferSub.CodeCoursetran, TransferCourse.Coursecs, CsCourse.Namecoursecs, TransferCourse.Coursetra, TraCourse.Namecoursetra, TransferSub.Codecs,  
                  CsCourseStruc.Codesubcs, CsCourseStruc.Namethaics, TransferSub.Codetra, TraSub.Codesubtra, TraSub.Namethaitra 
FROM TransferSub 
INNER JOIN TransferCourse ON TransferSub.CodeCoursetran = TransferCourse.CodeCoursetrans 
INNER JOIN CsCourseStruc ON TransferSub.Codecs = CsCourseStruc.Codecssub 
INNER JOIN TraSub ON TransferSub.Codetra = TraSub.Codetrasub 
INNER JOIN CsCourse ON TransferCourse.Coursecs = CsCourse.Codecoursecs AND CsCourseStruc.Codecoursecs = CsCourse.Codecoursecs 
INNER JOIN TraCourse ON TransferCourse.Coursetra = TraCourse.Codecoursetra AND TraSub.Codecourse = TraCourse.Codecoursetra;
GO
/****** Object:  View [dbo].[V_CourseTra]    Script Date: 4/8/2024 1:41:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_CourseTra] AS 
SELECT TraSub.Codetrasub, TraSub.Codecourse, TraCourse.Namecoursetra, TraSub.Codesubtra, TraSub.Namethaitra, TraSub.Nameengtra, TraSub.Credittra, TraSub.Subdestra, TraSub.Status 
FROM TraCourse 
INNER JOIN TraSub ON TraCourse.Codecoursetra = TraSub.Codecourse;
GO
/****** Object:  Table [dbo].[Ins]    Script Date: 4/8/2024 1:41:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ins](
	[InsCode] [int] NOT NULL,
	[InsName] [nvarchar](255) NULL,
 CONSTRAINT [sqlite_master_PK_Ins] PRIMARY KEY CLUSTERED 
(
	[InsCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_DataUser]    Script Date: 4/8/2024 1:41:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_DataUser] AS 
SELECT AspNetUsers.FirstName AS Expr1, AspNetUsers.LastName AS Expr2, AspNetUsers.Transcode AS Expr3, AspNetUsers.CourseCs AS Expr4, Ins.InsName, TraCourse.Namecoursetra,  
                  AspNetUsers.Facebook AS Expr5, AspNetUsers.Status AS Expr6, AspNetUsers.InsCode AS Expr7, AspNetUsers.Codecoursetra AS Expr8, AspNetUsers.* 
FROM AspNetUsers 
INNER JOIN TraCourse ON AspNetUsers.Codecoursetra = TraCourse.Codecoursetra 
INNER JOIN Ins ON AspNetUsers.InsCode = Ins.InsCode;
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 4/8/2024 1:41:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](255) NOT NULL,
	[ClaimType] [nvarchar](255) NULL,
	[ClaimValue] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 4/8/2024 1:41:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](255) NOT NULL,
	[Name] [nvarchar](255) NULL,
	[NormalizedName] [nvarchar](255) NULL,
	[ConcurrencyStamp] [nvarchar](255) NULL,
 CONSTRAINT [sqlite_autoindex_AspNetRoles_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 4/8/2024 1:41:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](255) NOT NULL,
	[ClaimType] [nvarchar](255) NULL,
	[ClaimValue] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 4/8/2024 1:41:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](255) NOT NULL,
	[ProviderKey] [nvarchar](255) NOT NULL,
	[ProviderDisplayName] [nvarchar](255) NULL,
	[UserId] [nvarchar](255) NOT NULL,
 CONSTRAINT [sqlite_autoindex_AspNetUserLogins_1] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 4/8/2024 1:41:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](255) NOT NULL,
	[RoleId] [nvarchar](255) NOT NULL,
 CONSTRAINT [sqlite_autoindex_AspNetUserRoles_1] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 4/8/2024 1:41:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](255) NOT NULL,
	[LoginProvider] [nvarchar](255) NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Value] [nvarchar](255) NULL,
 CONSTRAINT [sqlite_autoindex_AspNetUserTokens_1] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[File]    Script Date: 4/8/2024 1:41:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[File](
	[Id] [int] NULL,
	[FileName] [nvarchar](255) NULL,
	[Content] [image] NULL,
	[Transcode] [nvarchar](255) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Transcode], [Facebook], [Status], [InsCode], [Codecoursetra], [CourseCs]) VALUES (N'08d91e4d-7d46-4de6-b74b-58b7448c1e3e', N'a', N'b', N'BooBoo', N'BOOBOO', N'pattarpon_fake00@gmail.com', N'PATTARPON_FAKE00@GMAIL.COM', 0, N'AQAAAAIAAYagAAAAEBC3F3Txvcttbw9hUE7pg5qPHwSxblT9BsrAMAmhGuaMhV7+XjBDEVFKBgV1EHgbuA==', N'A4U5U4F4TAGRFPONCOX4AJEHVAW6G4E6', N'e6098a06-695e-4e98-8e1b-ebe6d9c2ada7', NULL, 0, 0, NULL, 1, 0, N'BooBoo', N'adf', N'ไม่มีไฟล์ทรานสคริปต์', 706, 1, N'หลักสูตรปี 2565')
GO
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Transcode], [Facebook], [Status], [InsCode], [Codecoursetra], [CourseCs]) VALUES (N'1ed1ff86-bc64-4026-9461-bbd3a1d61120', N'-', N'-', N'Admin2', N'ADMIN', N'sorrawit.cho@rmutto.ac.th', N'SORRAWIT.CHO@RMUTTO.AC.TH', 0, N'AQAAAAIAAYagAAAAEKnP0NF/mytdzBkkHgxdfgXqHTiHaDHY5Urrfa/EovAHfy37xvnPvLgtYAtIESh9XQ==', N'7VE4AZP6PIDSLOTHBTZAQ2ONC4OU5OW5', N'1adc04cd-ea3e-490a-bb3e-efa440af8efa', NULL, 0, 0, NULL, 1, 0, N'Admin', N'-', N'ไม่มีไฟล์ทรานสคริปต์', 706, 1, N'หลักสูตรปี 2565')
GO
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Transcode], [Facebook], [Status], [InsCode], [Codecoursetra], [CourseCs]) VALUES (N'b88cd97c-cda4-4557-b0b8-14c6ae101545', N'ga', N'me', N'016230641026-6', N'016230641026-6', N'sorrawit.cho33705@rmutto.ac.th', N'SORRAWIT.CHO33705@RMUTTO.AC.TH', 0, N'AQAAAAIAAYagAAAAEBNzl2GxHAl3NC3Ke/rIm3kJw9WESapfV0Fa6xcSQ8FfCymxYdqhZ4IPUhqpiQCTkQ==', N'YHUXM22NKQMJTDGOHOH4XICCPFVEB57C', N'fde8e7e3-2938-417c-a498-dac789140380', NULL, 0, 0, NULL, 1, 0, N'016230641026-6', N'sa', N'ไม่มีไฟล์ทรานสคริปต์', 82200404, 1, N'หลักสูตรปี 2555')
GO
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Transcode], [Facebook], [Status], [InsCode], [Codecoursetra], [CourseCs]) VALUES (N'bd6686d4-5f3c-4ba2-9a7b-29ac86d00c6c', N'-', N'-', N'Admin', N'ADMI', N'sorrawit.cho@gmail.com', N'SORRAWIT.CHO@GMAIL.COM', 0, N'AQAAAAIAAYagAAAAEE9ABadxe/7mboh2VBVrnMiZJ4xpid38sYnAVltbIZa7NjaxK7dLPpgwTG62UUaUYg==', N'BATJB5ER4BILMVU35QQQP2VIBKCC3XFG', N'b3be1cf5-8179-4e6d-9227-18ce87dae34d', NULL, 0, 0, NULL, 1, 0, N'Admin', N'-', N'ไม่มีไฟล์ทรานสคริปต์', 706, 1, N'หลักสูตรปี 2565')
GO
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Transcode], [Facebook], [Status], [InsCode], [Codecoursetra], [CourseCs]) VALUES (N'ebbb7b11-4672-49de-a6e2-503a1bdb02d9', N'Sorrawit', N'choatwongwachira', N'016230641016-6', N'016230641016-6', NULL, NULL, 0, N'AQAAAAIAAYagAAAAEI8V0UoxIM8YIzdZW6Yw53EQfUVl+XERElmB2Mnq4NHo4ijVxApPAr15QNSwxxd0UA==', N'6YLMCK4VOEVK6F45QAJW5UDRUEZRBB2B', N'6b89771e-38e7-49a0-a200-04382f11577b', NULL, 0, 0, NULL, 1, 0, N'016230641016-6', N'Srw.game', N'ไม่มีไฟล์ทรานสคริปต์', 82200404, 2, N'หลักสูตรปี 2565')
GO
INSERT [dbo].[CsCourse] ([Codecoursecs], [Namecoursecs], [statuscoursecs]) VALUES (1, N'หลักสูตรปี 2555', N'เปิดใช้งาน')
GO
INSERT [dbo].[CsCourse] ([Codecoursecs], [Namecoursecs], [statuscoursecs]) VALUES (2, N'หลักสูตรปี 2560', N'เปิดใช้งาน')
GO
INSERT [dbo].[CsCourse] ([Codecoursecs], [Namecoursecs], [statuscoursecs]) VALUES (3, N'หลักสูตรปี 2565', N'เปิดใช้งาน')
GO
INSERT [dbo].[CsCourse] ([Codecoursecs], [Namecoursecs], [statuscoursecs]) VALUES (4, N'หลักสูตรปี 2570', N'ปิดใช้งาน')
GO
INSERT [dbo].[CsCourse] ([Codecoursecs], [Namecoursecs], [statuscoursecs]) VALUES (5, N'หลักสูตรปี 2575', N'ปิดใช้งาน')
GO
INSERT [dbo].[CsCourseStruc] ([Codecssub], [Codecoursecs], [Codesubgroup], [Codesubcs], [Namethaics], [Nameengcs], [Credits], [Subdescs], [Status]) VALUES (1, 1, 101, N'00-00-01', N'ภาษาไทย', N'thai', N'3', N'as', N'เปิดใช้งาน')
GO
INSERT [dbo].[CsCourseStruc] ([Codecssub], [Codecoursecs], [Codesubgroup], [Codesubcs], [Namethaics], [Nameengcs], [Credits], [Subdescs], [Status]) VALUES (2, 1, 105, N'00-00-11', N'ว่ายน้ำ', N'swiming', N'3', N'sa', N'เปิดใช้งาน')
GO
INSERT [dbo].[CsCourseStruc] ([Codecssub], [Codecoursecs], [Codesubgroup], [Codesubcs], [Namethaics], [Nameengcs], [Credits], [Subdescs], [Status]) VALUES (3, 2, 102, N'00-00-02', N'พัฒนาบุคลิก', N'ass', N'2', N'a', N'เปิดใช้งาน')
GO
INSERT [dbo].[CsCourseStruc] ([Codecssub], [Codecoursecs], [Codesubgroup], [Codesubcs], [Namethaics], [Nameengcs], [Credits], [Subdescs], [Status]) VALUES (4, 2, 103, N'00-00-03', N'สังคม', N'df', N'3', N'asd5', N'เปิดใช้งาน')
GO
INSERT [dbo].[CsCourseStruc] ([Codecssub], [Codecoursecs], [Codesubgroup], [Codesubcs], [Namethaics], [Nameengcs], [Credits], [Subdescs], [Status]) VALUES (5, 3, 104, N'00-00-04', N'วิทย์', N'thf', N'2', N'asd', N'เปิดใช้งาน')
GO
INSERT [dbo].[CsCourseStruc] ([Codecssub], [Codecoursecs], [Codesubgroup], [Codesubcs], [Namethaics], [Nameengcs], [Credits], [Subdescs], [Status]) VALUES (6, 4, 105, N'00-00-05', N'คณิต', N'sds', N'3', N'asd', N'เปิดใช้งาน')
GO
INSERT [dbo].[CsCourseStruc] ([Codecssub], [Codecoursecs], [Codesubgroup], [Codesubcs], [Namethaics], [Nameengcs], [Credits], [Subdescs], [Status]) VALUES (7, 4, 101, N'00-00-12', N'วาทศิลท์', N'ฟหก', N'3', N'ฟหก', N'เปิดใช้งาน')
GO
INSERT [dbo].[CsCourseStruc] ([Codecssub], [Codecoursecs], [Codesubgroup], [Codesubcs], [Namethaics], [Nameengcs], [Credits], [Subdescs], [Status]) VALUES (8, 1, 102, N'00-00-15', N'สังคม', N'ฟหก', N'3(3-0-6)', N'ฟก', N'เปิดใช้งาน')
GO
INSERT [dbo].[CsSubgroup] ([Codesubgroup], [Codesubtype], [Namesubgroup], [Credit]) VALUES (101, 1, N'กลุ่มสังคมศาสตร์และมนุษยศาสตร์', N'6')
GO
INSERT [dbo].[CsSubgroup] ([Codesubgroup], [Codesubtype], [Namesubgroup], [Credit]) VALUES (102, 1, N'กลุ่มภาษา', N'12')
GO
INSERT [dbo].[CsSubgroup] ([Codesubgroup], [Codesubtype], [Namesubgroup], [Credit]) VALUES (103, 1, N'กลุ่มวิทยาศาสตร์และคณิตศาสตร์', N'6')
GO
INSERT [dbo].[CsSubgroup] ([Codesubgroup], [Codesubtype], [Namesubgroup], [Credit]) VALUES (104, 1, N'กลุ่มบูรณาการ', N'6')
GO
INSERT [dbo].[CsSubgroup] ([Codesubgroup], [Codesubtype], [Namesubgroup], [Credit]) VALUES (105, 2, N'กลุ่มวิชาแกน', N'15')
GO
INSERT [dbo].[CsSubgroup] ([Codesubgroup], [Codesubtype], [Namesubgroup], [Credit]) VALUES (106, 2, N'กลุ่มวิชาเฉพาะด้าน', N'62')
GO
INSERT [dbo].[CsSubgroup] ([Codesubgroup], [Codesubtype], [Namesubgroup], [Credit]) VALUES (107, 2, N'กลุ่มวิชาเลือก', N'24')
GO
INSERT [dbo].[CsSubtype] ([Codesubtype], [Namesubtype], [Credit]) VALUES (1, N'หมวดวิชาศึกษาทั่วไป', N'30')
GO
INSERT [dbo].[CsSubtype] ([Codesubtype], [Namesubtype], [Credit]) VALUES (2, N'หมวดวิชาเฉพาะ', N'101')
GO
INSERT [dbo].[CsSubtype] ([Codesubtype], [Namesubtype], [Credit]) VALUES (3, N'หมวดวิชาเสรี', N'6')
GO
INSERT [dbo].[Ins] ([InsCode], [InsName]) VALUES (706, N'706-มหาวิทยาลัยเทคโนโลยีราชมงคลตะวันออก วิทยาเขตบางพระ')
GO
INSERT [dbo].[Ins] ([InsCode], [InsName]) VALUES (82200404, N'82200404-วิทยาลัยเทคโนโลยีอักษรพัทยา')
GO
INSERT [dbo].[TableTransfer] ([TransReCode], [Transcode], [CodeSubtran], [GradeTra], [UserId]) VALUES (1, NULL, 7, N'F', N'08d91e4d-7d46-4de6-b74b-58b7448c1e3e')
GO
INSERT [dbo].[TableTransfer] ([TransReCode], [Transcode], [CodeSubtran], [GradeTra], [UserId]) VALUES (2, NULL, 7, N'A', N'1ed1ff86-bc64-4026-9461-bbd3a1d61120')
GO
INSERT [dbo].[TableTransfer] ([TransReCode], [Transcode], [CodeSubtran], [GradeTra], [UserId]) VALUES (3, NULL, 7, N'A', N'bd6686d4-5f3c-4ba2-9a7b-29ac86d00c6c')
GO
INSERT [dbo].[TraCourse] ([Codecoursetra], [Namecoursetra], [statuscoursetra]) VALUES (1, N'สาขาวิชาการบัญชี', N'เปิดใช้งาน')
GO
INSERT [dbo].[TraCourse] ([Codecoursetra], [Namecoursetra], [statuscoursetra]) VALUES (2, N'สาขาวิชาการตลาด', N'ปิดใช้งาน')
GO
INSERT [dbo].[TraCourse] ([Codecoursetra], [Namecoursetra], [statuscoursetra]) VALUES (3, N'สาขาวิชาการดนตรี', N'เปิดใช้งาน')
GO
INSERT [dbo].[TraCourse] ([Codecoursetra], [Namecoursetra], [statuscoursetra]) VALUES (4, N'สาขาวิชาการขนส่ง', N'เปิดใช้งาน')
GO
INSERT [dbo].[TransferCourse] ([CodeCoursetrans], [Coursecs], [Coursetra]) VALUES (1, 1, 2)
GO
INSERT [dbo].[TransferCourse] ([CodeCoursetrans], [Coursecs], [Coursetra]) VALUES (2, 2, 3)
GO
INSERT [dbo].[TransferCourse] ([CodeCoursetrans], [Coursecs], [Coursetra]) VALUES (3, 3, 4)
GO
INSERT [dbo].[TransferCourse] ([CodeCoursetrans], [Coursecs], [Coursetra]) VALUES (4, 1, 4)
GO
INSERT [dbo].[TransferCourse] ([CodeCoursetrans], [Coursecs], [Coursetra]) VALUES (5, 1, 1)
GO
INSERT [dbo].[TransferCourse] ([CodeCoursetrans], [Coursecs], [Coursetra]) VALUES (6, 3, 1)
GO
INSERT [dbo].[TransferCourse] ([CodeCoursetrans], [Coursecs], [Coursetra]) VALUES (7, 3, 2)
GO
INSERT [dbo].[TransferSub] ([CodeSubtrans], [CodeCoursetran], [Codecs], [Codetra]) VALUES (1, 1, 1, 3)
GO
INSERT [dbo].[TransferSub] ([CodeSubtrans], [CodeCoursetran], [Codecs], [Codetra]) VALUES (2, 2, 3, 5)
GO
INSERT [dbo].[TransferSub] ([CodeSubtrans], [CodeCoursetran], [Codecs], [Codetra]) VALUES (3, 3, 5, 4)
GO
INSERT [dbo].[TransferSub] ([CodeSubtrans], [CodeCoursetran], [Codecs], [Codetra]) VALUES (4, 4, 8, 4)
GO
INSERT [dbo].[TransferSub] ([CodeSubtrans], [CodeCoursetran], [Codecs], [Codetra]) VALUES (5, 1, 2, 2)
GO
INSERT [dbo].[TransferSub] ([CodeSubtrans], [CodeCoursetran], [Codecs], [Codetra]) VALUES (6, 5, 1, 1)
GO
INSERT [dbo].[TransferSub] ([CodeSubtrans], [CodeCoursetran], [Codecs], [Codetra]) VALUES (7, 6, 1, 1)
GO
INSERT [dbo].[TransferSub] ([CodeSubtrans], [CodeCoursetran], [Codecs], [Codetra]) VALUES (8, 7, 1, 1)
GO
INSERT [dbo].[TraSub] ([Codetrasub], [Codecourse], [Codesubtra], [Namethaitra], [Nameengtra], [Credittra], [Subdestra], [Status]) VALUES (1, 1, N'3000-1101', N'ภาษาไทยเพื่อสื่อสารในงานอาชีพ', N't', N'3-0-3', N'-', N'เปิดใช้งาน')
GO
INSERT [dbo].[TraSub] ([Codetrasub], [Codecourse], [Codesubtra], [Namethaitra], [Nameengtra], [Credittra], [Subdestra], [Status]) VALUES (2, 2, N'3000-1102', N'สังคมศึกษา', N'a', N'3-0-3', N'2', N'เปิดใช้งาน')
GO
INSERT [dbo].[TraSub] ([Codetrasub], [Codecourse], [Codesubtra], [Namethaitra], [Nameengtra], [Credittra], [Subdestra], [Status]) VALUES (3, 2, N'3000-1103', N'ว่ายน้ำ', N's', N'3-0-3', N'0', N'เปิดใช้งาน')
GO
INSERT [dbo].[TraSub] ([Codetrasub], [Codecourse], [Codesubtra], [Namethaitra], [Nameengtra], [Credittra], [Subdestra], [Status]) VALUES (4, 4, N'3000-1104', N'ภาษาอังกฤษเพื่อสื่อสาร', N'g', N'3-0-3', N'5', N'เปิดใช้งาน')
GO
INSERT [dbo].[TraSub] ([Codetrasub], [Codecourse], [Codesubtra], [Namethaitra], [Nameengtra], [Credittra], [Subdestra], [Status]) VALUES (5, 3, N'3000-1105', N'คณิตศาสตร์', N's', N'3-0-3', N's', N'เปิดใช้งาน')
GO
ALTER TABLE [dbo].[CsCourseStruc]  WITH CHECK ADD  CONSTRAINT [FK_CsCourseStruc_0_0] FOREIGN KEY([Codesubgroup])
REFERENCES [dbo].[CsSubgroup] ([Codesubgroup])
GO
ALTER TABLE [dbo].[CsCourseStruc] CHECK CONSTRAINT [FK_CsCourseStruc_0_0]
GO
ALTER TABLE [dbo].[CsCourseStruc]  WITH CHECK ADD  CONSTRAINT [FK_CsCourseStruc_1_0] FOREIGN KEY([Codecoursecs])
REFERENCES [dbo].[CsCourse] ([Codecoursecs])
GO
ALTER TABLE [dbo].[CsCourseStruc] CHECK CONSTRAINT [FK_CsCourseStruc_1_0]
GO
ALTER TABLE [dbo].[CsSubgroup]  WITH CHECK ADD  CONSTRAINT [FK_CsSubgroup_0_0] FOREIGN KEY([Codesubtype])
REFERENCES [dbo].[CsSubtype] ([Codesubtype])
GO
ALTER TABLE [dbo].[CsSubgroup] CHECK CONSTRAINT [FK_CsSubgroup_0_0]
GO
ALTER TABLE [dbo].[TableTransfer]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[TableTransfer]  WITH CHECK ADD  CONSTRAINT [FK_TableTransfer_0_0] FOREIGN KEY([CodeSubtran])
REFERENCES [dbo].[TransferSub] ([CodeSubtrans])
GO
ALTER TABLE [dbo].[TableTransfer] CHECK CONSTRAINT [FK_TableTransfer_0_0]
GO
ALTER TABLE [dbo].[TransferCourse]  WITH CHECK ADD  CONSTRAINT [FK_TransferCourse_0_0] FOREIGN KEY([Coursetra])
REFERENCES [dbo].[TraCourse] ([Codecoursetra])
GO
ALTER TABLE [dbo].[TransferCourse] CHECK CONSTRAINT [FK_TransferCourse_0_0]
GO
ALTER TABLE [dbo].[TransferCourse]  WITH CHECK ADD  CONSTRAINT [FK_TransferCourse_1_0] FOREIGN KEY([Coursecs])
REFERENCES [dbo].[CsCourse] ([Codecoursecs])
GO
ALTER TABLE [dbo].[TransferCourse] CHECK CONSTRAINT [FK_TransferCourse_1_0]
GO
ALTER TABLE [dbo].[TransferSub]  WITH CHECK ADD  CONSTRAINT [FK_TransferSub_0_0] FOREIGN KEY([Codetra])
REFERENCES [dbo].[TraSub] ([Codetrasub])
GO
ALTER TABLE [dbo].[TransferSub] CHECK CONSTRAINT [FK_TransferSub_0_0]
GO
ALTER TABLE [dbo].[TransferSub]  WITH CHECK ADD  CONSTRAINT [FK_TransferSub_1_0] FOREIGN KEY([Codecs])
REFERENCES [dbo].[CsCourseStruc] ([Codecssub])
GO
ALTER TABLE [dbo].[TransferSub] CHECK CONSTRAINT [FK_TransferSub_1_0]
GO
ALTER TABLE [dbo].[TransferSub]  WITH CHECK ADD  CONSTRAINT [FK_TransferSub_2_0] FOREIGN KEY([CodeCoursetran])
REFERENCES [dbo].[TransferCourse] ([CodeCoursetrans])
GO
ALTER TABLE [dbo].[TransferSub] CHECK CONSTRAINT [FK_TransferSub_2_0]
GO
ALTER TABLE [dbo].[TraSub]  WITH CHECK ADD  CONSTRAINT [FK_TraSub_0_0] FOREIGN KEY([Codecourse])
REFERENCES [dbo].[TraCourse] ([Codecoursetra])
GO
ALTER TABLE [dbo].[TraSub] CHECK CONSTRAINT [FK_TraSub_0_0]
GO
