CREATE TABLE [dbo].[Costumers] (
    [CostumerID]     NCHAR (10)   NOT NULL,
    [CostumerName]   VARCHAR (50) NOT NULL,
    [PhoneNumber]    NCHAR (10)   NOT NULL,
    [NumberOfPeople] INT          NOT NULL,
    [Email] NVARCHAR(50) NOT NULL, 
    PRIMARY KEY CLUSTERED ([CostumerID] ASC),
);