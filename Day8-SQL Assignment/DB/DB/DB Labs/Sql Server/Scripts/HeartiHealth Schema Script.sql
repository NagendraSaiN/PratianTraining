USE [master]
GO
/****** Object:  Database [heartihealth]    Script Date: 12/9/2020 2:47:30 AM ******/
CREATE DATABASE [heartihealth]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'heartihealth', FILENAME = N'C:\heartidb\heartihealth.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'heartihealth_log', FILENAME = N'C:\heartidb\heartihealth_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [heartihealth] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [heartihealth].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [heartihealth] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [heartihealth] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [heartihealth] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [heartihealth] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [heartihealth] SET ARITHABORT OFF 
GO
ALTER DATABASE [heartihealth] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [heartihealth] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [heartihealth] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [heartihealth] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [heartihealth] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [heartihealth] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [heartihealth] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [heartihealth] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [heartihealth] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [heartihealth] SET  ENABLE_BROKER 
GO
ALTER DATABASE [heartihealth] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [heartihealth] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [heartihealth] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [heartihealth] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [heartihealth] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [heartihealth] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [heartihealth] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [heartihealth] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [heartihealth] SET  MULTI_USER 
GO
ALTER DATABASE [heartihealth] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [heartihealth] SET DB_CHAINING OFF 
GO
ALTER DATABASE [heartihealth] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [heartihealth] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [heartihealth] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [heartihealth] SET QUERY_STORE = OFF
GO
USE [heartihealth]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [heartihealth]
GO
/****** Object:  Table [dbo].[addressinfo]    Script Date: 12/9/2020 2:47:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[addressinfo](
	[address_id] [varchar](45) NOT NULL,
	[city] [varchar](45) NULL,
	[state] [varchar](45) NULL,
	[country] [varchar](45) NULL,
	[pincode] [varchar](45) NULL,
	[memberinfo_member_id] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[address_id] ASC,
	[memberinfo_member_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bloodtest]    Script Date: 12/9/2020 2:47:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bloodtest](
	[blood_id] [varchar](45) NOT NULL,
	[bloodtest_date] [datetime] NULL,
	[bloodpressure] [bigint] NULL,
	[fbs] [bigint] NULL,
	[thal] [bigint] NULL,
	[serumcholesterol] [bigint] NULL,
	[cardiodiagnosis_cardio_id] [varchar](45) NOT NULL,
 CONSTRAINT [blood_id_pk] PRIMARY KEY CLUSTERED 
(
	[blood_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cardiodiagnosis]    Script Date: 12/9/2020 2:47:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cardiodiagnosis](
	[cardio_id] [varchar](45) NOT NULL,
	[cardioarrestdetected] [int] NULL,
	[date] [datetime2](0) NULL,
	[memberinfo_member_id] [varchar](45) NOT NULL,
 CONSTRAINT [PK_cardiodiagnosis] PRIMARY KEY CLUSTERED 
(
	[cardio_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[diseasedetail]    Script Date: 12/9/2020 2:47:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[diseasedetail](
	[disease_id] [varchar](45) NOT NULL,
	[diagnoseddate] [datetime] NULL,
	[recovereddate] [datetime] NULL,
	[isrecovered] [smallint] NULL,
	[cardiodiagnosis_cardio_id] [varchar](45) NOT NULL,
 CONSTRAINT [disease_id_pk] PRIMARY KEY CLUSTERED 
(
	[disease_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ecgreport]    Script Date: 12/9/2020 2:47:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ecgreport](
	[ecg_id] [varchar](45) NOT NULL,
	[ecg_date] [datetime] NULL,
	[restecg] [bigint] NULL,
	[cardiodiagnosis_cardio_id] [varchar](45) NOT NULL,
 CONSTRAINT [ecg_id_pk] PRIMARY KEY CLUSTERED 
(
	[ecg_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[memberinfo]    Script Date: 12/9/2020 2:47:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[memberinfo](
	[member_id] [varchar](45) NOT NULL,
	[username] [varchar](45) NULL,
	[firstname] [varchar](45) NULL,
	[lastname] [varchar](45) NULL,
	[age] [int] NULL,
	[gender] [varchar](45) NULL,
	[email] [varchar](45) NULL,
	[phonenumber] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[member_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[symptom]    Script Date: 12/9/2020 2:47:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[symptom](
	[symptom_id] [varchar](45) NOT NULL,
	[symptom_date] [datetime] NULL,
	[exang] [bigint] NULL,
	[oldpeak] [float] NULL,
	[cp] [bigint] NULL,
	[cardiodiagnosis_cardio_id] [varchar](45) NOT NULL,
 CONSTRAINT [symptom_id_pk] PRIMARY KEY CLUSTERED 
(
	[symptom_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wearabledevicedata]    Script Date: 12/9/2020 2:47:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wearabledevicedata](
	[wearable_device_id] [varchar](45) NOT NULL,
	[thalach] [bigint] NULL,
	[slope] [bigint] NULL,
	[device_date] [datetime] NULL,
	[cardiodiagnosis_cardio_id] [varchar](45) NOT NULL,
 CONSTRAINT [wearable_device_id_pk] PRIMARY KEY CLUSTERED 
(
	[wearable_device_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[xray]    Script Date: 12/9/2020 2:47:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[xray](
	[xray_id] [varchar](45) NOT NULL,
	[xray_date] [datetime] NULL,
	[ca] [bigint] NULL,
	[cardiodiagnosis_cardio_id] [varchar](45) NOT NULL,
 CONSTRAINT [xray_id_pk] PRIMARY KEY CLUSTERED 
(
	[xray_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [fk_addressinfo_memberinfo_idx]    Script Date: 12/9/2020 2:47:31 AM ******/
CREATE NONCLUSTERED INDEX [fk_addressinfo_memberinfo_idx] ON [dbo].[addressinfo]
(
	[memberinfo_member_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [fk_cardiodiagnosis_memberinfo1_idx]    Script Date: 12/9/2020 2:47:31 AM ******/
CREATE NONCLUSTERED INDEX [fk_cardiodiagnosis_memberinfo1_idx] ON [dbo].[cardiodiagnosis]
(
	[memberinfo_member_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[addressinfo] ADD  DEFAULT (NULL) FOR [city]
GO
ALTER TABLE [dbo].[addressinfo] ADD  DEFAULT (NULL) FOR [state]
GO
ALTER TABLE [dbo].[addressinfo] ADD  DEFAULT (NULL) FOR [country]
GO
ALTER TABLE [dbo].[addressinfo] ADD  DEFAULT (NULL) FOR [pincode]
GO
ALTER TABLE [dbo].[cardiodiagnosis] ADD  DEFAULT (NULL) FOR [cardioarrestdetected]
GO
ALTER TABLE [dbo].[cardiodiagnosis] ADD  DEFAULT (NULL) FOR [date]
GO
ALTER TABLE [dbo].[memberinfo] ADD  DEFAULT (NULL) FOR [username]
GO
ALTER TABLE [dbo].[memberinfo] ADD  DEFAULT (NULL) FOR [firstname]
GO
ALTER TABLE [dbo].[memberinfo] ADD  DEFAULT (NULL) FOR [lastname]
GO
ALTER TABLE [dbo].[memberinfo] ADD  DEFAULT (NULL) FOR [age]
GO
ALTER TABLE [dbo].[memberinfo] ADD  DEFAULT (NULL) FOR [gender]
GO
ALTER TABLE [dbo].[memberinfo] ADD  DEFAULT (NULL) FOR [email]
GO
ALTER TABLE [dbo].[memberinfo] ADD  DEFAULT (NULL) FOR [phonenumber]
GO
ALTER TABLE [dbo].[addressinfo]  WITH CHECK ADD  CONSTRAINT [fk_addressinfo_memberinfo] FOREIGN KEY([memberinfo_member_id])
REFERENCES [dbo].[memberinfo] ([member_id])
GO
ALTER TABLE [dbo].[addressinfo] CHECK CONSTRAINT [fk_addressinfo_memberinfo]
GO
ALTER TABLE [dbo].[bloodtest]  WITH CHECK ADD  CONSTRAINT [fk_bloodtest_cardiodiagnosis1] FOREIGN KEY([cardiodiagnosis_cardio_id])
REFERENCES [dbo].[cardiodiagnosis] ([cardio_id])
GO
ALTER TABLE [dbo].[bloodtest] CHECK CONSTRAINT [fk_bloodtest_cardiodiagnosis1]
GO
ALTER TABLE [dbo].[cardiodiagnosis]  WITH CHECK ADD  CONSTRAINT [fk_cardiodiagnosis_memberinfo1] FOREIGN KEY([memberinfo_member_id])
REFERENCES [dbo].[memberinfo] ([member_id])
GO
ALTER TABLE [dbo].[cardiodiagnosis] CHECK CONSTRAINT [fk_cardiodiagnosis_memberinfo1]
GO
ALTER TABLE [dbo].[diseasedetail]  WITH CHECK ADD  CONSTRAINT [fk_dieseasedetail_cardiodiagnosis1] FOREIGN KEY([cardiodiagnosis_cardio_id])
REFERENCES [dbo].[cardiodiagnosis] ([cardio_id])
GO
ALTER TABLE [dbo].[diseasedetail] CHECK CONSTRAINT [fk_dieseasedetail_cardiodiagnosis1]
GO
ALTER TABLE [dbo].[ecgreport]  WITH CHECK ADD  CONSTRAINT [fk_ecgreport_cardiodiagnosis1] FOREIGN KEY([cardiodiagnosis_cardio_id])
REFERENCES [dbo].[cardiodiagnosis] ([cardio_id])
GO
ALTER TABLE [dbo].[ecgreport] CHECK CONSTRAINT [fk_ecgreport_cardiodiagnosis1]
GO
ALTER TABLE [dbo].[symptom]  WITH CHECK ADD  CONSTRAINT [fk_symptom_cardiodiagnosis1] FOREIGN KEY([cardiodiagnosis_cardio_id])
REFERENCES [dbo].[cardiodiagnosis] ([cardio_id])
GO
ALTER TABLE [dbo].[symptom] CHECK CONSTRAINT [fk_symptom_cardiodiagnosis1]
GO
ALTER TABLE [dbo].[wearabledevicedata]  WITH CHECK ADD  CONSTRAINT [fk_wearabledevicedata_cardiodiagnosis1] FOREIGN KEY([cardiodiagnosis_cardio_id])
REFERENCES [dbo].[cardiodiagnosis] ([cardio_id])
GO
ALTER TABLE [dbo].[wearabledevicedata] CHECK CONSTRAINT [fk_wearabledevicedata_cardiodiagnosis1]
GO
ALTER TABLE [dbo].[xray]  WITH CHECK ADD  CONSTRAINT [fk_xray_cardiodiagnosis1] FOREIGN KEY([cardiodiagnosis_cardio_id])
REFERENCES [dbo].[cardiodiagnosis] ([cardio_id])
GO
ALTER TABLE [dbo].[xray] CHECK CONSTRAINT [fk_xray_cardiodiagnosis1]
GO
USE [master]
GO
ALTER DATABASE [heartihealth] SET  READ_WRITE 
GO
