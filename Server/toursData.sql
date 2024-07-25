-- Declare variables
DECLARE @TourCode INT
DECLARE @TourName NVARCHAR(50)
DECLARE @FlightCode INT
DECLARE @HouseCode INT
DECLARE @IsOrganized BIT
DECLARE @Price MONEY
DECLARE @DestinationCode INT
DECLARE @StartDate DATE
DECLARE @EndDate DATE

-- Initialize the TourCode and IsOrganized
SET @TourCode = 1000
SET @IsOrganized = 1

-- Insert 50 organized tours, one for each destination
DECLARE TourCursor CURSOR FOR
SELECT 
    F.FlightID,
    F.DestinationCode,
    F.Date,
    H.HouseID
FROM 
    dbo.Flights F
JOIN 
    dbo.Housing H ON F.DestinationCode = H.AddressCode
ORDER BY 
    F.DestinationCode;

OPEN TourCursor

FETCH NEXT FROM TourCursor INTO @FlightCode, @DestinationCode, @StartDate, @HouseCode

WHILE @@FETCH_STATUS = 0
BEGIN
    -- Assign a TourName
    SET @TourName = 'Organized Tour ' + CAST(@TourCode AS NVARCHAR(50))

    -- Calculate EndDate by adding random days (between 1 to 10) to the StartDate
    SET @EndDate = DATEADD(DAY, (ABS(CHECKSUM(NEWID())) % 10) + 1, @StartDate)

    -- Randomly assign Price between 1000.00 and 5000.00
    SET @Price = (ABS(CHECKSUM(NEWID())) % 4000) + 1000.00

    -- Insert the new tour into the Tours table
    INSERT INTO [dbo].[Tours] (
        [TourCode], 
        [TourName], 
        [FlightCode], 
        [HouseCode], 
        [IsOrgenized], 
        [Price], 
        [DestinationCode], 
        [StartDate], 
        [EndDate]
    )
    VALUES (
        @TourCode, 
        @TourName, 
        @FlightCode, 
        @HouseCode, 
        @IsOrganized, 
        @Price, 
        @DestinationCode, 
        @StartDate, 
        @EndDate
    )

    -- Increment the TourCode
    SET @TourCode = @TourCode + 1

    FETCH NEXT FROM TourCursor INTO @FlightCode, @DestinationCode, @StartDate, @HouseCode
END

CLOSE TourCursor
DEALLOCATE TourCursor

-- End of the script
