-- Create the function for mapping destination codes to airline companies
IF OBJECT_ID('dbo.GetAirlineCompany', 'FN') IS NOT NULL
    DROP FUNCTION dbo.GetAirlineCompany;
GO

CREATE FUNCTION dbo.GetAirlineCompany (@CountryName VARCHAR(50))
RETURNS VARCHAR(50)
AS
BEGIN
    RETURN
    CASE @CountryName
        WHEN 'Italy' THEN 'Alitalia'
        WHEN 'United States' THEN 'Delta'
        WHEN 'United Kingdom' THEN 'British Airways'
        WHEN 'France' THEN 'Air France'
        WHEN 'Japan' THEN 'Japan Airlines'
        WHEN 'Australia' THEN 'Qantas'
        WHEN 'Spain' THEN 'Iberia'
        WHEN 'Germany' THEN 'Lufthansa'
        WHEN 'Canada' THEN 'Air Canada'
        WHEN 'Netherlands' THEN 'KLM'
        WHEN 'China' THEN 'Air China'
        WHEN 'Brazil' THEN 'LATAM'
        WHEN 'Russia' THEN 'Aeroflot'
        WHEN 'India' THEN 'Air India'
        WHEN 'Mexico' THEN 'Aeromexico'
        WHEN 'Turkey' THEN 'Turkish Airlines'
        WHEN 'United Arab Emirates' THEN 'Emirates'
        WHEN 'South Africa' THEN 'South African Airways'
        WHEN 'Thailand' THEN 'Thai Airways'
        WHEN 'Greece' THEN 'Aegean Airlines'
        WHEN 'Singapore' THEN 'Singapore Airlines'
        WHEN 'Malaysia' THEN 'Malaysia Airlines'
        WHEN 'Argentina' THEN 'Aerolineas Argentinas'
        WHEN 'South Korea' THEN 'Korean Air'
        WHEN 'Sweden' THEN 'SAS'
        WHEN 'Switzerland' THEN 'Swiss International Air Lines'
        WHEN 'Austria' THEN 'Austrian Airlines'
        WHEN 'Belgium' THEN 'Brussels Airlines'
        WHEN 'Portugal' THEN 'TAP Air Portugal'
        WHEN 'Egypt' THEN 'EgyptAir'
        WHEN 'Norway' THEN 'Norwegian Air Shuttle'
        WHEN 'Denmark' THEN 'SAS'
        WHEN 'Finland' THEN 'Finnair'
        WHEN 'Poland' THEN 'LOT Polish Airlines'
        WHEN 'Ireland' THEN 'Aer Lingus'
        WHEN 'Czech Republic' THEN 'Czech Airlines'
        WHEN 'Hungary' THEN 'Wizz Air'
        WHEN 'New Zealand' THEN 'Air New Zealand'
        WHEN 'Chile' THEN 'LATAM'
        WHEN 'Colombia' THEN 'Avianca'
        WHEN 'Saudi Arabia' THEN 'Saudia'
        WHEN 'Israel' THEN 'El Al'
        WHEN 'Indonesia' THEN 'Garuda Indonesia'
        WHEN 'Vietnam' THEN 'Vietnam Airlines'
        WHEN 'Philippines' THEN 'Philippine Airlines'
        WHEN 'Hong Kong' THEN 'Cathay Pacific'
        WHEN 'Peru' THEN 'LATAM'
        WHEN 'Pakistan' THEN 'PIA'
        WHEN 'Bangladesh' THEN 'Biman Bangladesh Airlines'
        ELSE 'Generic Airline'
    END
END;
GO

-- Declare variables for flight data
DECLARE @FlightID INT = (SELECT ISNULL(MAX(FlightID), 0) + 1 FROM [dbo].[Flights]);
DECLARE @TelAvivID INT = 100;
DECLARE @DepartureCode INT;
DECLARE @DestinationCode INT;
DECLARE @Date DATETIME;
DECLARE @LeavingTime TIME(7);
DECLARE @ArrivalTime TIME(7);
DECLARE @Company VARCHAR(50);
DECLARE @Price FLOAT;
DECLARE @AmountOfSeats INT;
DECLARE @BookedSeats INT;

-- Insert flights from Tel-Aviv to other destinations
DECLARE destination_cursor CURSOR FOR
SELECT [DestinationID], [CountryName]
FROM [dbo].[Destinations]
WHERE [DestinationID] != @TelAvivID;

OPEN destination_cursor;
FETCH NEXT FROM destination_cursor INTO @DestinationCode, @Company;

WHILE @@FETCH_STATUS = 0
BEGIN
    SET @Date = GETDATE() + ABS(CHECKSUM(NEWID()) % 30); -- Random future date within 30 days
    SET @LeavingTime = CAST(ABS(CHECKSUM(NEWID()) % 24) AS VARCHAR) + ':00:00'; -- Random hour of the day
    SET @ArrivalTime = DATEADD(HOUR, 4, @LeavingTime); -- Assuming average flight duration of 4 hours
    SET @Company = dbo.GetAirlineCompany(@Company);
    SET @Price = CAST(200 + ABS(CHECKSUM(NEWID()) % 300) AS FLOAT); -- Random price between 200 and 500
    SET @AmountOfSeats = 200;
    SET @BookedSeats = ABS(CHECKSUM(NEWID()) % 200); -- Random number of booked seats

    -- Insert flight from Tel-Aviv to destination
    INSERT INTO [dbo].[Flights] ([FlightID], [DepartureCode], [DestinationCode], [Date], [Leaving time], [Arrival time], [Company], [Price], [AmountOfSeats], [BookedSeats])
    VALUES (@FlightID, @TelAvivID, @DestinationCode, @Date, @LeavingTime, @ArrivalTime, @Company, @Price, @AmountOfSeats, @BookedSeats);

    SET @FlightID = @FlightID + 1;

    -- Insert return flight from destination to Tel-Aviv
    SET @Date = GETDATE() + ABS(CHECKSUM(NEWID()) % 30); -- Random future date within 30 days
    SET @LeavingTime = CAST(ABS(CHECKSUM(NEWID()) % 24) AS VARCHAR) + ':00:00'; -- Random hour of the day
    SET @ArrivalTime = DATEADD(HOUR, 4, @LeavingTime); -- Assuming average flight duration of 4 hours
    SET @BookedSeats = ABS(CHECKSUM(NEWID()) % 200); -- Random number of booked seats

    INSERT INTO [dbo].[Flights] ([FlightID], [DepartureCode], [DestinationCode], [Date], [Leaving time], [Arrival time], [Company], [Price], [AmountOfSeats], [BookedSeats])
    VALUES (@FlightID, @DestinationCode, @TelAvivID, @Date, @LeavingTime, @ArrivalTime, @Company, @Price, @AmountOfSeats, @BookedSeats);

    SET @FlightID = @FlightID + 1;

    FETCH NEXT FROM destination_cursor INTO @DestinationCode, @Company;
END;

CLOSE destination_cursor;
DEALLOCATE destination_cursor;
GO


-- Declare variables for additional random flights
DECLARE @SourceCode INT;
DECLARE @TargetCode INT;

-- Insert 30 additional random flights between other destinations
WHILE @FlightID <= 230
BEGIN
    SELECT TOP 1 @SourceCode = [DestinationID] FROM [dbo].[Destinations] ORDER BY NEWID();
    SELECT TOP 1 @TargetCode = [DestinationID] FROM [dbo].[Destinations] WHERE [DestinationID] != @SourceCode ORDER BY NEWID();

    SET @Date = GETDATE() + ABS(CHECKSUM(NEWID()) % 30); -- Random future date within 30 days
    SET @LeavingTime = CAST(ABS(CHECKSUM(NEWID()) % 24) AS VARCHAR) + ':00:00'; -- Random hour of the day
    SET @ArrivalTime = DATEADD(HOUR, 4, @LeavingTime); -- Assuming average flight duration of 4 hours
    SET @Company = dbo.GetAirlineCompany((SELECT [CountryName] FROM [dbo].[Destinations] WHERE [DestinationID] = @SourceCode));
    SET @Price = CAST(200 + ABS(CHECKSUM(NEWID()) % 300) AS FLOAT); -- Random price between 200 and 500
    SET @AmountOfSeats = 200;
    SET @BookedSeats = ABS(CHECKSUM(NEWID()) % 200); -- Random number of booked seats

    INSERT INTO [dbo].[Flights] ([FlightID], [DepartureCode], [DestinationCode], [Date], [Leaving time], [Arrival time], [Company], [Price], [AmountOfSeats], [BookedSeats])
    VALUES (@FlightID, @SourceCode, @TargetCode, @Date, @LeavingTime, @ArrivalTime, @Company, @Price, @AmountOfSeats, @BookedSeats);

    SET @FlightID = @FlightID + 1;
END;
GO

-- Declare variables for flight data
DECLARE @FlightID INT = (SELECT ISNULL(MAX(FlightID), 0) + 1 FROM [dbo].[Flights]);
DECLARE @TelAvivID INT = 100;
DECLARE @DepartureCode INT;
DECLARE @DestinationCode INT;
DECLARE @Date DATETIME;
DECLARE @LeavingTime TIME(7);
DECLARE @ArrivalTime TIME(7);
DECLARE @Company VARCHAR(50);
DECLARE @Price FLOAT;
DECLARE @AmountOfSeats INT;
DECLARE @BookedSeats INT;

-- Insert flights from Tel-Aviv to other destinations
DECLARE destination_cursor CURSOR FOR
SELECT [DestinationID], [CountryName]
FROM [dbo].[Destinations]
WHERE [DestinationID] != @TelAvivID;

OPEN destination_cursor;
FETCH NEXT FROM destination_cursor INTO @DestinationCode, @Company;

WHILE @@FETCH_STATUS = 0
BEGIN
    SET @Date = GETDATE() + ABS(CHECKSUM(NEWID()) % 30); -- Random future date within 30 days
    SET @LeavingTime = CAST(ABS(CHECKSUM(NEWID()) % 24) AS VARCHAR) + ':00:00'; -- Random hour of the day
    SET @ArrivalTime = DATEADD(HOUR, 4, @LeavingTime); -- Assuming average flight duration of 4 hours
    SET @Company = dbo.GetAirlineCompany(@Company);
    SET @Price = CAST(200 + ABS(CHECKSUM(NEWID()) % 300) AS FLOAT); -- Random price between 200 and 500
    SET @AmountOfSeats = 200;
    SET @BookedSeats = ABS(CHECKSUM(NEWID()) % 200); -- Random number of booked seats

    -- Insert flight from Tel-Aviv to destination
    INSERT INTO [dbo].[Flights] ([FlightID], [DepartureCode], [DestinationCode], [Date], [Leaving time], [Arrival time], [Company], [Price], [AmountOfSeats], [BookedSeats])
    VALUES (@FlightID, @TelAvivID, @DestinationCode, @Date, @LeavingTime, @ArrivalTime, @Company, @Price, @AmountOfSeats, @BookedSeats);

    SET @FlightID = @FlightID + 1;

    -- Insert return flight from destination to Tel-Aviv
    SET @Date = GETDATE() + ABS(CHECKSUM(NEWID()) % 30); -- Random future date within 30 days
    SET @LeavingTime = CAST(ABS(CHECKSUM(NEWID()) % 24) AS VARCHAR) + ':00:00'; -- Random hour of the day
    SET @ArrivalTime = DATEADD(HOUR, 4, @LeavingTime); -- Assuming average flight duration of 4 hours
    SET @BookedSeats = ABS(CHECKSUM(NEWID()) % 200); -- Random number of booked seats

    INSERT INTO [dbo].[Flights] ([FlightID], [DepartureCode], [DestinationCode], [Date], [Leaving time], [Arrival time], [Company], [Price], [AmountOfSeats], [BookedSeats])
    VALUES (@FlightID, @DestinationCode, @TelAvivID, @Date, @LeavingTime, @ArrivalTime, @Company, @Price, @AmountOfSeats, @BookedSeats);

    SET @FlightID = @FlightID + 1;

    FETCH NEXT FROM destination_cursor INTO @DestinationCode, @Company;
END;

CLOSE destination_cursor;
DEALLOCATE destination_cursor;

-- Declare variables for additional random flights
DECLARE @SourceCode INT;
DECLARE @TargetCode INT;

-- Insert 30 additional random flights between other destinations
WHILE @FlightID <= 230
BEGIN
    SELECT TOP 1 @SourceCode = [DestinationID] FROM [dbo].[Destinations] ORDER BY NEWID();
    SELECT TOP 1 @TargetCode = [DestinationID] FROM [dbo].[Destinations] WHERE [DestinationID] != @SourceCode ORDER BY NEWID();

    SET @Date = GETDATE() + ABS(CHECKSUM(NEWID()) % 30); -- Random future date within 30 days
    SET @LeavingTime = CAST(ABS(CHECKSUM(NEWID()) % 24) AS VARCHAR) + ':00:00'; -- Random hour of the day
    SET @ArrivalTime = DATEADD(HOUR, 4, @LeavingTime); -- Assuming average flight duration of 4 hours
    SET @Company = dbo.GetAirlineCompany((SELECT [CountryName] FROM [dbo].[Destinations] WHERE [DestinationID] = @SourceCode));
    SET @Price = CAST(200 + ABS(CHECKSUM(NEWID()) % 300) AS FLOAT); -- Random price between 200 and 500
    SET @AmountOfSeats = 200;
    SET @BookedSeats = ABS(CHECKSUM(NEWID()) % 200); -- Random number of booked seats

    INSERT INTO [dbo].[Flights] ([FlightID], [DepartureCode], [DestinationCode], [Date], [Leaving time], [Arrival time], [Company], [Price], [AmountOfSeats], [BookedSeats])
    VALUES (@FlightID, @SourceCode, @TargetCode, @Date, @LeavingTime, @ArrivalTime, @Company, @Price, @AmountOfSeats, @BookedSeats);

    SET @FlightID = @FlightID + 1;
END;
GO

select * from[Flights]