CREATE TABLE [dbo].[Prvky] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [Nazev]            NVARCHAR (100) NULL,
    [Obtiznost] NVARCHAR (50)  NULL,
    [Inverted]    BIT            NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

