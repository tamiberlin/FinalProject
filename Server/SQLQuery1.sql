CREATE TABLE [dbo].[Flights] (
    [FlightID]        INT          NOT NULL,
    [DepartureCode]   INT          NOT NULL,
    [DestinationCode] INT          NOT NULL,
    [Date]            DATETIME     NOT NULL,
    [Leaving time]    TIME (7)     NOT NULL,
    [Arrival time]    TIME (7)     NOT NULL,
    [Company]         VARCHAR (50) NOT NULL,
    [Price]           FLOAT (53)   NOT NULL,
    [AmountOfSeats] INT NOT NULL, 
    [BookedSeats] INT NOT NULL, 
    PRIMARY KEY CLUSTERED ([FlightID] ASC),
    FOREIGN KEY ([DepartureCode]) REFERENCES [dbo].[Destinations] ([DestinationID]),
    FOREIGN KEY ([DestinationCode]) REFERENCES [dbo].[Destinations] ([DestinationID])
);

