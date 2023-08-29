/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 29.08.2023 20:59:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 29.08.2023 20:59:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[ParentID] [int] NULL,
	[ImgUrl] [nvarchar](max) NULL,
	[CreUser] [int] NULL,
	[Deleted] [bit] NOT NULL,
	[ModDate] [datetime2](7) NULL,
	[ModUser] [int] NULL,
	[DelDate] [datetime2](7) NULL,
	[DelUser] [int] NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 29.08.2023 20:59:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](max) NOT NULL,
	[CreUser] [int] NULL,
	[Deleted] [bit] NOT NULL,
	[ModDate] [datetime2](7) NULL,
	[ModUser] [int] NULL,
	[DelDate] [datetime2](7) NULL,
	[DelUser] [int] NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 29.08.2023 20:59:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceDate] [datetime2](7) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[CreUser] [int] NULL,
	[Deleted] [bit] NOT NULL,
	[ModDate] [datetime2](7) NULL,
	[ModUser] [int] NULL,
	[DelDate] [datetime2](7) NULL,
	[DelUser] [int] NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InvoiceDetail]    Script Date: 29.08.2023 20:59:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvoiceDetail](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceDate] [datetime2](7) NOT NULL,
	[ID_Product] [int] NOT NULL,
	[DiscountPercent] [decimal](18, 2) NOT NULL,
	[ID_Invoice] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[CreUser] [int] NULL,
	[Deleted] [bit] NOT NULL,
	[ModDate] [datetime2](7) NULL,
	[ModUser] [int] NULL,
	[DelDate] [datetime2](7) NULL,
	[DelUser] [int] NULL,
 CONSTRAINT [PK_InvoiceDetail] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Picture]    Script Date: 29.08.2023 20:59:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Picture](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ImageUrl] [nvarchar](max) NULL,
	[ID_Product] [int] NULL,
	[CreUser] [int] NULL,
	[Deleted] [bit] NOT NULL,
	[ModDate] [datetime2](7) NULL,
	[ModUser] [int] NULL,
	[DelDate] [datetime2](7) NULL,
	[DelUser] [int] NULL,
 CONSTRAINT [PK_Picture] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 29.08.2023 20:59:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[UnitPrice] [decimal](18, 2) NOT NULL,
	[ID_Category] [int] NULL,
	[SKU] [nvarchar](max) NULL,
	[Discount] [real] NOT NULL,
	[UnitPriceInStock] [int] NOT NULL,
	[CreUser] [int] NULL,
	[Deleted] [bit] NOT NULL,
	[ModDate] [datetime2](7) NULL,
	[ModUser] [int] NULL,
	[DelDate] [datetime2](7) NULL,
	[DelUser] [int] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 29.08.2023 20:59:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NULL,
	[CreUser] [int] NULL,
	[Deleted] [bit] NOT NULL,
	[ModDate] [datetime2](7) NULL,
	[ModUser] [int] NULL,
	[DelDate] [datetime2](7) NULL,
	[DelUser] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230716093646_PortoDb-Version1', N'7.0.9')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230729085037_PortoDb-Version-1.1', N'7.0.9')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230808175130_PortoDb-Version-1.2', N'7.0.9')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230819071924_Version-1.3', N'7.0.9')
GO
SET IDENTITY_INSERT [dbo].[Category] ON 
GO
INSERT [dbo].[Category] ([ID], [Name], [Description], [ParentID], [ImgUrl], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (1, N'Konut', N'Konut', NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Category] ([ID], [Name], [Description], [ParentID], [ImgUrl], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (2, N'Kiralýk', N'Kiralýk', 1, NULL, NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Category] ([ID], [Name], [Description], [ParentID], [ImgUrl], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (3, N'Satýlýk', N'Satýlýk', 1, NULL, NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Category] ([ID], [Name], [Description], [ParentID], [ImgUrl], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (4, N'Daire', N'Daire', 2, NULL, NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Category] ([ID], [Name], [Description], [ParentID], [ImgUrl], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (5, N'Rezidans', N'Rezidans', 2, NULL, NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Category] ([ID], [Name], [Description], [ParentID], [ImgUrl], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (6, N'Bungalov', N'Bungalov', 4, NULL, NULL, 0, CAST(N'2023-08-26T12:01:59.1095418' AS DateTime2), 1, NULL, NULL)
GO
INSERT [dbo].[Category] ([ID], [Name], [Description], [ParentID], [ImgUrl], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (8, N'Kategori', N'KAtegori', NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Category] ([ID], [Name], [Description], [ParentID], [ImgUrl], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (9, N'Alt Kategori 1', N'Alt Kategori 1', 8, NULL, NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Category] ([ID], [Name], [Description], [ParentID], [ImgUrl], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (10, N'KAtegori 1', N'Aciklama 1', NULL, NULL, NULL, 1, NULL, NULL, CAST(N'2023-08-26T10:17:58.9566012' AS DateTime2), NULL)
GO
INSERT [dbo].[Category] ([ID], [Name], [Description], [ParentID], [ImgUrl], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (11, N'Kategori 2', N'Aciklama 2', NULL, NULL, NULL, 1, NULL, NULL, CAST(N'2023-08-26T10:22:11.7533391' AS DateTime2), NULL)
GO
INSERT [dbo].[Category] ([ID], [Name], [Description], [ParentID], [ImgUrl], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (12, N'Alt Kategori 1', N'Alt Kategori 1', NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Category] ([ID], [Name], [Description], [ParentID], [ImgUrl], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (13, N'asdasd', N'asdasdasd', NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Category] ([ID], [Name], [Description], [ParentID], [ImgUrl], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (14, N'KAtegor 1', N'KAtegor 1', NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Category] ([ID], [Name], [Description], [ParentID], [ImgUrl], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (15, N'Kategori 5', N'Kategori 5', NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Category] ([ID], [Name], [Description], [ParentID], [ImgUrl], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (16, N'KAtegori 6', N'KAtegori 6', 6, NULL, NULL, 0, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 
GO
INSERT [dbo].[Customer] ([ID], [Name], [Email], [Address], [Phone], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (3, N'Cem', N'dos.cem@gmail.com', N'as dasd asd asd', N'5555554433', NULL, 0, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Invoice] ON 
GO
INSERT [dbo].[Invoice] ([ID], [InvoiceDate], [CustomerId], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (1, CAST(N'2023-08-08T23:07:59.3733333' AS DateTime2), 3, NULL, 0, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Invoice] OFF
GO
SET IDENTITY_INSERT [dbo].[Picture] ON 
GO
INSERT [dbo].[Picture] ([ID], [ImageUrl], [ID_Product], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (2, N'/images/products/product-1.jpg', 1, NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Picture] ([ID], [ImageUrl], [ID_Product], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (3, N'/images/products/product-1-2.jpg', 1, NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Picture] ([ID], [ImageUrl], [ID_Product], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (5, N'/images/products/product-2.jpg', 2, NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Picture] ([ID], [ImageUrl], [ID_Product], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (6, N'/images/products/product-2-2.jpg', 2, NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Picture] ([ID], [ImageUrl], [ID_Product], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (7, N'/images/products/product-3.jpg', 4, NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Picture] ([ID], [ImageUrl], [ID_Product], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (8, N'/images/products/product-3-2.jpg', 4, NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Picture] ([ID], [ImageUrl], [ID_Product], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (9, N'/images/products/product-4.jpg', 6, NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Picture] ([ID], [ImageUrl], [ID_Product], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (10, N'/images/products/product-4-2.jpg', 6, NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Picture] ([ID], [ImageUrl], [ID_Product], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (13, N'/images/products/zoom/product-1.jpg', 6, NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Picture] ([ID], [ImageUrl], [ID_Product], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (14, N'/images/products/zoom/product-1-big.jpg', 6, NULL, 0, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Picture] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 
GO
INSERT [dbo].[Product] ([ID], [Name], [Description], [UnitPrice], [ID_Category], [SKU], [Discount], [UnitPriceInStock], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (1, N'A ', N'A', CAST(15000.00 AS Decimal(18, 2)), 4, NULL, 0, 1, NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Product] ([ID], [Name], [Description], [UnitPrice], [ID_Category], [SKU], [Discount], [UnitPriceInStock], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (2, N'B', N'B', CAST(10000.00 AS Decimal(18, 2)), 5, NULL, 0, 1, NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Product] ([ID], [Name], [Description], [UnitPrice], [ID_Category], [SKU], [Discount], [UnitPriceInStock], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (4, N'C', N'C', CAST(8000.00 AS Decimal(18, 2)), 4, NULL, 0, 1, NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Product] ([ID], [Name], [Description], [UnitPrice], [ID_Category], [SKU], [Discount], [UnitPriceInStock], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (6, N'D', N'D', CAST(7000.00 AS Decimal(18, 2)), 3, NULL, 0.2, 1, NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Product] ([ID], [Name], [Description], [UnitPrice], [ID_Category], [SKU], [Discount], [UnitPriceInStock], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (7, N'E', N'E', CAST(6000.00 AS Decimal(18, 2)), 3, NULL, 0.1, 1, NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Product] ([ID], [Name], [Description], [UnitPrice], [ID_Category], [SKU], [Discount], [UnitPriceInStock], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (10, N'F', N'F', CAST(5000.00 AS Decimal(18, 2)), 3, NULL, 0.23, 1, NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Product] ([ID], [Name], [Description], [UnitPrice], [ID_Category], [SKU], [Discount], [UnitPriceInStock], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (11, N'G', N'Acýklama G', CAST(0.00 AS Decimal(18, 2)), 5, NULL, 0, 1, NULL, 0, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 
GO
INSERT [dbo].[User] ([ID], [UserName], [Password], [Email], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (1, N'cemdos', N'1234', N'dos.cem@gmail.com', NULL, 0, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[User] ([ID], [UserName], [Password], [Email], [CreUser], [Deleted], [ModDate], [ModUser], [DelDate], [DelUser]) VALUES (2, N'evren', N'1234', N'evren@asdasd.com', NULL, 0, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[User] OFF
GO
/****** Object:  Index [IX_Category_ParentID]    Script Date: 29.08.2023 20:59:38 ******/
CREATE NONCLUSTERED INDEX [IX_Category_ParentID] ON [dbo].[Category]
(
	[ParentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [NCI-ParentId]    Script Date: 29.08.2023 20:59:38 ******/
CREATE NONCLUSTERED INDEX [NCI-ParentId] ON [dbo].[Category]
(
	[ParentID] ASC
)
INCLUDE([Name],[Description]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Invoice_CustomerId]    Script Date: 29.08.2023 20:59:38 ******/
CREATE NONCLUSTERED INDEX [IX_Invoice_CustomerId] ON [dbo].[Invoice]
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_InvoiceDetail_ID_Invoice]    Script Date: 29.08.2023 20:59:38 ******/
CREATE NONCLUSTERED INDEX [IX_InvoiceDetail_ID_Invoice] ON [dbo].[InvoiceDetail]
(
	[ID_Invoice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_InvoiceDetail_ID_Product]    Script Date: 29.08.2023 20:59:38 ******/
CREATE NONCLUSTERED INDEX [IX_InvoiceDetail_ID_Product] ON [dbo].[InvoiceDetail]
(
	[ID_Product] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Picture_ID_Product]    Script Date: 29.08.2023 20:59:38 ******/
CREATE NONCLUSTERED INDEX [IX_Picture_ID_Product] ON [dbo].[Picture]
(
	[ID_Product] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Product_ID_Category]    Script Date: 29.08.2023 20:59:38 ******/
CREATE NONCLUSTERED INDEX [IX_Product_ID_Category] ON [dbo].[Product]
(
	[ID_Category] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Category]  WITH CHECK ADD  CONSTRAINT [FK_Category_Category_ParentID] FOREIGN KEY([ParentID])
REFERENCES [dbo].[Category] ([ID])
GO
ALTER TABLE [dbo].[Category] CHECK CONSTRAINT [FK_Category_Category_ParentID]
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Customer_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [FK_Invoice_Customer_CustomerId]
GO
ALTER TABLE [dbo].[InvoiceDetail]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceDetail_Invoice_ID_Invoice] FOREIGN KEY([ID_Invoice])
REFERENCES [dbo].[Invoice] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[InvoiceDetail] CHECK CONSTRAINT [FK_InvoiceDetail_Invoice_ID_Invoice]
GO
ALTER TABLE [dbo].[InvoiceDetail]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceDetail_Product_ID_Product] FOREIGN KEY([ID_Product])
REFERENCES [dbo].[Product] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[InvoiceDetail] CHECK CONSTRAINT [FK_InvoiceDetail_Product_ID_Product]
GO
ALTER TABLE [dbo].[Picture]  WITH CHECK ADD  CONSTRAINT [FK_Picture_Product_ID_Product] FOREIGN KEY([ID_Product])
REFERENCES [dbo].[Product] ([ID])
GO
ALTER TABLE [dbo].[Picture] CHECK CONSTRAINT [FK_Picture_Product_ID_Product]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category_ID_Category] FOREIGN KEY([ID_Category])
REFERENCES [dbo].[Category] ([ID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category_ID_Category]
GO
/****** Object:  StoredProcedure [dbo].[sp_AddInvoice]    Script Date: 29.08.2023 20:59:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_AddInvoice](
	@Name VARCHAR(1000),
	@Email VARCHAR(1000),
	@Address VARCHAR(2000),
	@Phone VARCHAR(20)
)
AS
BEGIN
	INSERT INTO Customer (Name,Email,Address,Phone,Deleted)
	VALUES(@Name,@Email,@Address,@Phone,0)

	DECLARE @CustomerId INT = SCOPE_IDENTITY()

	INSERT INTO Invoice (InvoiceDate,CustomerId,Deleted)
	VALUES(GETDATE(),@CustomerId,0)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_AddInvoiceDetail]    Script Date: 29.08.2023 20:59:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_AddInvoiceDetail](
	@ProductId INT,
	@InvoiceId INT,
	@Quantity VARCHAR(20)
)
AS
BEGIN
	INSERT INTO InvoiceDetail (InvoiceDate,ID_Product,DiscountPercent,ID_Invoice,Quantity,Deleted)
	VALUES(GETDATE(),@ProductId,0,@InvoiceId,@Quantity,0)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_CategoryCtrl_AddCategory]    Script Date: 29.08.2023 20:59:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[sp_CategoryCtrl_AddCategory](@Name VARCHAR(MAX), @Description VARCHAR(MAX),@ParentID INT)
AS
BEGIN
	insert into Category ([Name],[Description],[ParentID],Deleted)
	VALUES(@Name,@Description,@ParentID,0)
	select 0 AS ErrorCode
END
GO
/****** Object:  StoredProcedure [dbo].[sp_CategoryCtrl_GetCategory]    Script Date: 29.08.2023 20:59:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		cem doþ
-- Create date: 20.08.2023
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_CategoryCtrl_GetCategory]
AS
BEGIN
	select 
		ID,
		Name,
		Description,
		ParentID 
	from Category 
	where Deleted = 0
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetProductDetail]    Script Date: 29.08.2023 20:59:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GetProductDetail](@ProductId INT)
AS
BEGIN
	select 
		p.ID,
		p.Name,
		p.Description,
		p.UnitPrice,
		p.SKU,
		p.UnitPriceInStock,
		c.Name AS CategoryName
	from Product as p
	left join Category as c
		on p.ID_Category = c.ID
			and c.Deleted = 0
	where p.Deleted = 0 AND p.ID=@ProductId
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Login]    Script Date: 29.08.2023 20:59:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Login](@Username VARCHAR(50), @Password VARCHAR(50))
AS
BEGIN
	select 
		ID,
		UserName 
	from [User] 
	where 
		UserName = @Username 
		and [Password] = @Password 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ProductCtrl_GetProductList]    Script Date: 29.08.2023 20:59:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[sp_ProductCtrl_GetProductList]
AS
select 
	p.ID,
	p.Name,
	p.Description,
	p.UnitPrice,
	c.Name AS CategoryName,
	p.Discount,
	p.UnitPrice,
	p.UnitPriceInStock
from Product as p
left join Category as c
	on p.ID_Category = c.ID
GO
/****** Object:  StoredProcedure [dbo].[sp_ProductWithCategory]    Script Date: 29.08.2023 20:59:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ProductWithCategory](@CategoryId INT=NULL)
as
BEGIN
	--DECLARE @CategoryId INT = 4;
	IF @CategoryId IS NULL
	BEGIN
		select p.* from Product as p
			inner join Category as c
				on p.ID_Category = c.ID
	END
	ELSE
	BEGIN
		with temp_Table AS (
			select ID,Name,Description,ImgUrl,ParentID,0 as AltKategoriSeviyesi from Category 
				where ID = 1
			UNION ALL
			select c.ID,c.Name,c.Description,c.ImgUrl,c.ParentID,t.AltKategoriSeviyesi+1 from Category as c
			INNER JOIN temp_Table as t
				on c.ParentID = t.ID
		)

		,temp_pictures AS (
			select 
				ROW_NUMBER() over (partition by ID_Product order by ID) AS RowNumber,
				ID_Product,
				ImageUrl
			from Picture
		)

		select 
			p.ID,
			p.Name,
			p.Description,
			p.UnitPrice,
			p.Discount,
			p.UnitPriceInStock,
			(select ImageUrl from temp_pictures where ID_Product = p.ID AND RowNumber = 1) AS MasterPic,
			(select ImageUrl from temp_pictures where ID_Product = p.ID AND RowNumber = 2) AS SlavePic
		from Product as p
		inner join temp_Table as t
			on p.ID_Category = t.ID
		where p.Deleted=0
	END
END
GO