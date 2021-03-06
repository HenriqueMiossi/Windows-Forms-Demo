USE [WinFormsDemo]
GO
/****** Object:  Table [dbo].[ClientePessoaFisica]    Script Date: 25/06/2022 19:43:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientePessoaFisica](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [nvarchar](50) NOT NULL,
	[cpf] [nvarchar](50) NOT NULL,
	[rg] [nvarchar](50) NULL,
	[nome] [nvarchar](50) NOT NULL,
	[nomeAbreviado] [nvarchar](50) NULL,
	[email] [nvarchar](50) NOT NULL,
	[telefone] [nvarchar](50) NOT NULL,
	[inclusao] [datetime] NOT NULL,
	[alteracao] [datetime] NOT NULL,
	[bloqueado] [bit] NOT NULL,
	[endereco] [int] NOT NULL,
 CONSTRAINT [PK_ClientePessoaFisica] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClientePessoaJuridica]    Script Date: 25/06/2022 19:43:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientePessoaJuridica](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [nvarchar](50) NOT NULL,
	[cnpj] [nvarchar](50) NOT NULL,
	[ie] [nvarchar](50) NULL,
	[razaoSocial] [nvarchar](50) NOT NULL,
	[nomeFantasia] [nvarchar](50) NULL,
	[email] [nvarchar](50) NOT NULL,
	[telefone] [nvarchar](50) NOT NULL,
	[inclusao] [datetime] NOT NULL,
	[alteracao] [datetime] NOT NULL,
	[bloqueado] [bit] NOT NULL,
	[endereco] [int] NOT NULL,
 CONSTRAINT [PK_ClientePessoaJuridica] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Endereco]    Script Date: 25/06/2022 19:43:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Endereco](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cep] [nvarchar](50) NOT NULL,
	[logradouro] [nvarchar](50) NULL,
	[numero] [nvarchar](50) NULL,
	[complemento] [nvarchar](50) NULL,
	[bairro] [nvarchar](50) NULL,
	[municipio] [nvarchar](50) NULL,
	[uf] [nvarchar](2) NULL,
 CONSTRAINT [PK_Endereco] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ClientePessoaFisica]  WITH CHECK ADD  CONSTRAINT [FK_ClientePessoaFisica_Endereco] FOREIGN KEY([endereco])
REFERENCES [dbo].[Endereco] ([id])
GO
ALTER TABLE [dbo].[ClientePessoaFisica] CHECK CONSTRAINT [FK_ClientePessoaFisica_Endereco]
GO
ALTER TABLE [dbo].[ClientePessoaJuridica]  WITH CHECK ADD  CONSTRAINT [FK_ClientePessoaJuridica_Endereco] FOREIGN KEY([endereco])
REFERENCES [dbo].[Endereco] ([id])
GO
ALTER TABLE [dbo].[ClientePessoaJuridica] CHECK CONSTRAINT [FK_ClientePessoaJuridica_Endereco]
GO
