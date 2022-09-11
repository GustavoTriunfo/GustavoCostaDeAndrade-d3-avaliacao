CREATE TABLE [dbo].[RealBancoBrasil](
	[Nome] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Senha] [nvarchar](50) NULL,
	[ID] [int] NULL,
	[Cargo] [nvarchar](50) NULL
) ON [PRIMARY]
GO


INSERT INTO [dbo].[RealBancoBrasil]
           ([Nome]
           ,[Email]
           ,[Senha]
           ,[ID]
           ,[Cargo])
     VALUES
           ('Archer', 'admin@email.com', 'admin123', 8, 'Superintendente')
GO

SELECT [Nome], [Email], [Senha], [ID], [Cargo] FROM [dbo].[RealBancoBrasil] (nolock)
