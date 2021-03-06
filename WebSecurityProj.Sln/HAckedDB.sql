USE [HackedDB]
GO
/****** Object:  Table [dbo].[ASPCookies]    Script Date: 7/5/2020 5:24:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ASPCookies](
	[ASPCookie] [varchar](max) NULL,
	[Email] [varchar](max) NULL,
	[Password] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BrowserDetails]    Script Date: 7/5/2020 5:24:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BrowserDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Url] [varchar](max) NULL,
	[Email] [varchar](max) NULL,
	[Password] [varchar](max) NULL,
 CONSTRAINT [PK_BrowserDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HackedLogin]    Script Date: 7/5/2020 5:24:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HackedLogin](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [varchar](max) NULL,
	[Password] [varchar](max) NULL,
 CONSTRAINT [PK_HackedLogin] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ASPCookies] ([ASPCookie], [Email], [Password]) VALUES (N'.AspNetCore.Cookies=CfDJ8OiEzK1SF-9HtrTpkD9SXfL7xKL96U0sZcYflf7omtSXe3JMUDGb5vgIoHgord0NVixc5uXnr18p_CRFSFu39WJpLcCZifbYsSK2DtFhJV2_4LDJsEn4vwuuyVeullWiE4t0hExYOOdoluhZ7kmRNB8ef3Jcjr9fA_PWwnCay3AD-TpiuEga81rGCnObmcK7t-Es-9Fb-uQyKNYc2rK4zlpvz3zkVZo0RjoMS7_YdcTTyjW2cCxO1g6fiTtEKeotml--qsFrPxLtshtmmF-jjTzdd9JM7dli2v8f5Qw7NkQzeQs-s7lAqfMNgxwY21FsaNR208o5vW5tgRRbne9SOYbtzmEbw9zltxE3v7s9pti1Riv1_mpWjPrEooLTPhqqyxA3Xrncethp7rvVEeRZnOJSGPY0vjtf6ZvgN4JCWfo6XGxYhDARIPofyaeCJGJyTV_dKeul3SyMhcp5cfNOCj-16BWRbm9HGEKUp3cfo1ZZ', N' Email=jayanth%40g2tsolutions.com', N' Password=India%40123')
INSERT [dbo].[ASPCookies] ([ASPCookie], [Email], [Password]) VALUES (N'.AspNetCore.Cookies=CfDJ8OiEzK1SF-9HtrTpkD9SXfI6ag76HaOfvwiRnCZzK0OMhbPW1rgsrfZ-Y8axgHLb3ESQ1KErGusLd5zcutSCX6ErCWOMORITR_LEaIYR_eey6lI0sJTNX3Voo0qea0HlEAv7sYv9QcrqnyQe9pVh4zBTzgztZRaCFGKcmIrPIzQgj5eOT8HLhlMgt1wb12ILEnfaZXEhRMNYaXekaIbEJxLeXwp5p9nmIf3WV43DtUoLDnfGjoDyIwUt-oiF3XdXDBDOb25IJ27k7prmr-7Fsx04IHT0nadrda38zv0yKQ73LixwM1psh3CC4hZN4OP6cYLNS6Tuc0Vzs9GSGVT-2TxGohjCNs2gimjW69Vr6s7EmG7hsKibkTPkNGs9YO_aIlR-uccQdDoFLT9oVgR9bLLwFVBDaq4fUXJhMbDSaNQAxyocSQ5pndfFEj9HfYcpFKDuCkXMSjJ1SdK8ERRbQO6ODXu63hKw2CLdUztLM7mH', N' Email=John%40g2tsolutions.com', N' Password=Welcom%40123')
SET IDENTITY_INSERT [dbo].[BrowserDetails] ON 

INSERT [dbo].[BrowserDetails] ([Id], [Url], [Email], [Password]) VALUES (1, N'urlasdas', N'email', N'password')
INSERT [dbo].[BrowserDetails] ([Id], [Url], [Email], [Password]) VALUES (2, N'urlasdas', N'email', N'password')
INSERT [dbo].[BrowserDetails] ([Id], [Url], [Email], [Password]) VALUES (3, N'https://www.google.com/?as_qdr=all', N'email', N'password')
INSERT [dbo].[BrowserDetails] ([Id], [Url], [Email], [Password]) VALUES (4, N'https://www.google.com/?as_qdr=all', N'email', N'password')
INSERT [dbo].[BrowserDetails] ([Id], [Url], [Email], [Password]) VALUES (5, N'https://www.google.com/?as_qdr=all', N'email', N'password')
INSERT [dbo].[BrowserDetails] ([Id], [Url], [Email], [Password]) VALUES (6, N'http://www.banksite.com:84/Product/TrackDelivery', N'email', N'password')
INSERT [dbo].[BrowserDetails] ([Id], [Url], [Email], [Password]) VALUES (7, N'https://developer.chrome.com/extensions/tut_debugging', N'email', N'password')
INSERT [dbo].[BrowserDetails] ([Id], [Url], [Email], [Password]) VALUES (8, N'https://developer.chrome.com/extensions/tut_debugging', N'email', N'password')
INSERT [dbo].[BrowserDetails] ([Id], [Url], [Email], [Password]) VALUES (9, N'http://www.banksite.com:84/Product/TrackDelivery', N'email', N'password')
INSERT [dbo].[BrowserDetails] ([Id], [Url], [Email], [Password]) VALUES (10, N'chrome://settings/cookies/detail?site=www.securedbanksite.com', N'email', N'password')
INSERT [dbo].[BrowserDetails] ([Id], [Url], [Email], [Password]) VALUES (11, N'chrome://settings/cookies/detail?site=www.securedbanksite.com', N'email', N'password')
INSERT [dbo].[BrowserDetails] ([Id], [Url], [Email], [Password]) VALUES (12, N'http://www.hackersden.com:86/webattacks', N'email', N'password')
INSERT [dbo].[BrowserDetails] ([Id], [Url], [Email], [Password]) VALUES (13, N'http://www.hackersden.com:86/webattacks', N'email', N'password')
SET IDENTITY_INSERT [dbo].[BrowserDetails] OFF
SET IDENTITY_INSERT [dbo].[HackedLogin] ON 

INSERT [dbo].[HackedLogin] ([Id], [Email], [Password]) VALUES (1, N'jayanth@test.com', N'Password@123')
INSERT [dbo].[HackedLogin] ([Id], [Email], [Password]) VALUES (2, N'test1@test.com', N'India@123')
INSERT [dbo].[HackedLogin] ([Id], [Email], [Password]) VALUES (3, N'admin@test.com', N'Test@123')
INSERT [dbo].[HackedLogin] ([Id], [Email], [Password]) VALUES (4, N'unsecured@yahoo.com', N'Welcome@123')
INSERT [dbo].[HackedLogin] ([Id], [Email], [Password]) VALUES (5, N'test@test.com', N'Welcome@123')
INSERT [dbo].[HackedLogin] ([Id], [Email], [Password]) VALUES (6, N'john@g2tsolutions.com', N'Welcmon@12345')
SET IDENTITY_INSERT [dbo].[HackedLogin] OFF
