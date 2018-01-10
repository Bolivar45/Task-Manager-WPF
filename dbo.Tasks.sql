CREATE TABLE [dbo].[Tasks]
(
	[TaskId] INT NOT NULL PRIMARY KEY Identity(1,1), 
    [Name] NVARCHAR(50) NULL, 
    [Task] NVARCHAR(50) NULL, 
    [StartDate] NVARCHAR(50) NULL, 
    [EndDate] NVARCHAR(50) NULL, 
    [Status] NVARCHAR(50) NULL, 
    [Person] INT NULL, 
    CONSTRAINT [FK_Tasks_ToTable] FOREIGN KEY ([Person]) REFERENCES Persons(PersonId)
)
