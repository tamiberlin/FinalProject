CREATE TABLE [dbo].[Tours] (
    [TourCode]        INT           NOT NULL,
    [TourName]        NVARCHAR (50) NOT NULL,
    [FlightCode]      INT           NOT NULL,
    [HouseCode]       INT           NOT NULL,
    [IsOrgenized]     BIT           NOT NULL,
    [Price]           MONEY         NOT NULL,
    [DestinationCode] INT           NOT NULL,
    [StartDate] DATE NOT NULL, 
    [EndDate] DATE NOT NULL, 
    PRIMARY KEY CLUSTERED ([TourCode] ASC),
    FOREIGN KEY ([DestinationCode]) REFERENCES [dbo].[Destinations] ([DestinationID]),
    FOREIGN KEY ([HouseCode]) REFERENCES [dbo].[Housing] ([HouseID])
);