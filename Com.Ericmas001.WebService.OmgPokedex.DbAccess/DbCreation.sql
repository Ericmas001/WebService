ALTER TABLE [ericmas001].[TTrainers] DROP CONSTRAINT [FK_TTrainers_TUsers]
GO
ALTER TABLE [ericmas001].[TCatchedPokemon] DROP CONSTRAINT [FK_TCatchedPokemon_TPokemonSummaries]
GO
ALTER TABLE [ericmas001].[TCatchedPokemon] DROP CONSTRAINT [FK_TCatchedPokemon_TBackpacks]
GO
ALTER TABLE [ericmas001].[TBackpacks] DROP CONSTRAINT [FK_TBackpacks_TTrainers]
GO
/****** Object:  Table [ericmas001].[TUsers]    Script Date: 2015-11-07 07:24:26 ******/
DROP TABLE [ericmas001].[TUsers]
GO
/****** Object:  Table [ericmas001].[TTrainers]    Script Date: 2015-11-07 07:24:26 ******/
DROP TABLE [ericmas001].[TTrainers]
GO
/****** Object:  Table [ericmas001].[TPokemonSummaries]    Script Date: 2015-11-07 07:24:26 ******/
DROP TABLE [ericmas001].[TPokemonSummaries]
GO
/****** Object:  Table [ericmas001].[TCatchedPokemon]    Script Date: 2015-11-07 07:24:26 ******/
DROP TABLE [ericmas001].[TCatchedPokemon]
GO
/****** Object:  Table [ericmas001].[TBackpacks]    Script Date: 2015-11-07 07:24:26 ******/
DROP TABLE [ericmas001].[TBackpacks]
GO
/****** Object:  Table [ericmas001].[TBackpacks]    Script Date: 2015-11-07 07:24:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ericmas001].[TBackpacks](
	[IdBackPack] [int] IDENTITY(1,1) NOT NULL,
	[IdTrainer] [int] NOT NULL,
	[Name] [nvarchar](200) NULL,
 CONSTRAINT [PK_TBackpacks] PRIMARY KEY CLUSTERED 
(
	[IdBackPack] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [ericmas001].[TCatchedPokemon]    Script Date: 2015-11-07 07:24:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [ericmas001].[TCatchedPokemon](
	[IdCatchedPokemon] [int] IDENTITY(1,1) NOT NULL,
	[IdBackpack] [int] NOT NULL,
	[IdPokemonSummary] [int] NOT NULL,
	[Notes] [varchar](max) NULL,
 CONSTRAINT [PK_TCatchedPokemon] PRIMARY KEY CLUSTERED 
(
	[IdCatchedPokemon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [ericmas001].[TPokemonSummaries]    Script Date: 2015-11-07 07:24:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ericmas001].[TPokemonSummaries](
	[IdPokemonSummary] [int] IDENTITY(1,1) NOT NULL,
	[PokedexNo] [int] UNIQUE NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Generation] [nvarchar](100) NULL,
	[Type] [nvarchar](500) NULL,
	[ImageUrl] [nvarchar](500) NULL,
 CONSTRAINT [PK_TPokemonSummaries] PRIMARY KEY CLUSTERED 
(
	[IdPokemonSummary] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [ericmas001].[TTrainers]    Script Date: 2015-11-07 07:24:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ericmas001].[TTrainers](
	[IdTrainer] [int] IDENTITY(1,1) NOT NULL,
	[IdUser] [int] NOT NULL,
	[Name] [nvarchar](200) NULL,
 CONSTRAINT [PK_TTrainers] PRIMARY KEY CLUSTERED 
(
	[IdTrainer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [ericmas001].[TUsers]    Script Date: 2015-11-07 07:24:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ericmas001].[TUsers](
	[IdUser] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](200) NULL,
	[SessionId] [nvarchar](100) NULL,
	[SessionValidUntil] [datetime] NULL,
 CONSTRAINT [PK_TUsers] PRIMARY KEY CLUSTERED 
(
	[IdUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [ericmas001].[TBackpacks]  WITH CHECK ADD  CONSTRAINT [FK_TBackpacks_TTrainers] FOREIGN KEY([IdTrainer])
REFERENCES [ericmas001].[TTrainers] ([IdTrainer])
GO
ALTER TABLE [ericmas001].[TBackpacks] CHECK CONSTRAINT [FK_TBackpacks_TTrainers]
GO
ALTER TABLE [ericmas001].[TCatchedPokemon]  WITH CHECK ADD  CONSTRAINT [FK_TCatchedPokemon_TBackpacks] FOREIGN KEY([IdBackpack])
REFERENCES [ericmas001].[TBackpacks] ([IdBackPack])
GO
ALTER TABLE [ericmas001].[TCatchedPokemon] CHECK CONSTRAINT [FK_TCatchedPokemon_TBackpacks]
GO
ALTER TABLE [ericmas001].[TCatchedPokemon]  WITH CHECK ADD  CONSTRAINT [FK_TCatchedPokemon_TPokemonSummaries] FOREIGN KEY([IdPokemonSummary])
REFERENCES [ericmas001].[TPokemonSummaries] ([IdPokemonSummary])
GO
ALTER TABLE [ericmas001].[TCatchedPokemon] CHECK CONSTRAINT [FK_TCatchedPokemon_TPokemonSummaries]
GO
ALTER TABLE [ericmas001].[TTrainers]  WITH CHECK ADD  CONSTRAINT [FK_TTrainers_TUsers] FOREIGN KEY([IdUser])
REFERENCES [ericmas001].[TUsers] ([IdUser])
GO
ALTER TABLE [ericmas001].[TTrainers] CHECK CONSTRAINT [FK_TTrainers_TUsers]
GO
