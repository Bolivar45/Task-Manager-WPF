CREATE TABLE [dbo].[Persons] (
    [PersonId]   INT           NOT NULL IDENTITY(2,1),
    [FirstName]  NVARCHAR (50) NULL,
    [LastName]   NVARCHAR (50) NULL,
    [MiddleName] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([PersonId] ASC)
);

