CREATE TABLE [dbo].[Block] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [Name]    NVARCHAR (50) NULL,
    [Content] NTEXT         NULL,
    [Status]  INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

