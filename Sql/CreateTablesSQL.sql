CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](max) NOT NULL,
	[Type] [int] NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbo.Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


CREATE TABLE [dbo].[Recipes] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Category] INT            NOT NULL,
    [Name]     NVARCHAR (MAX) NOT NULL,
    [UserId]   INT            NOT NULL,
    CONSTRAINT [PK_dbo.Recipes] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Recipes_dbo.Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_UserId]
    ON [dbo].[Recipes]([UserId] ASC);


CREATE TABLE [dbo].[Ingredients] (
    [Id]   INT            IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_dbo.Ingredients] PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[Compositions] (
    [Id]           INT NOT NULL,
    [RecipeId]     INT NOT NULL,
    [IngredientId] INT NOT NULL,
    [Quantity]     INT NOT NULL,
    CONSTRAINT [PK_dbo.Compositions] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Compositions_dbo.Ingredients_IngredientId] FOREIGN KEY ([IngredientId]) REFERENCES [dbo].[Ingredients] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.Compositions_dbo.Recipes_Id] FOREIGN KEY ([Id]) REFERENCES [dbo].[Recipes] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Id]
    ON [dbo].[Compositions]([Id] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_IngredientId]
    ON [dbo].[Compositions]([IngredientId] ASC);


CREATE TABLE [dbo].[Reviews] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [UserId]       INT            NOT NULL,
    [RecipeId]     INT            NOT NULL,
    [Description]  NVARCHAR (MAX) NOT NULL,
    [CreationDate] DATETIME       NOT NULL,
    CONSTRAINT [PK_dbo.Reviews] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Reviews_dbo.Recipes_RecipeId] FOREIGN KEY ([RecipeId]) REFERENCES [dbo].[Recipes] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.Reviews_dbo.Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_UserId]
    ON [dbo].[Reviews]([UserId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_RecipeId]
    ON [dbo].[Reviews]([RecipeId] ASC);

