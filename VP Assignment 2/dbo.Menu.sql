CREATE TABLE [dbo].[Menu] (
    [ItemId]       VARCHAR (10) NOT NULL,
    [ItemName]     VARCHAR (50) NOT NULL,
    [ItemPrice]    INT NOT NULL,
    [ItemCategory] VARCHAR (50) NOT NULL,
    [Status]       VARCHAR (15) NOT NULL,
    PRIMARY KEY CLUSTERED ([ItemId] ASC)
);

