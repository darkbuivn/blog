CREATE TABLE [dbo].[Topic] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Title]       NVARCHAR (200) NOT NULL,
    [ShortDesc]   NTEXT          NULL,
    [Content]     NTEXT          NULL,
    [image]       VARCHAR (100)  NULL,
    [CategoryId]  INT            NOT NULL,
    [CreatedDate] DATETIME2 (7)  DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Category] ([Id])
);

