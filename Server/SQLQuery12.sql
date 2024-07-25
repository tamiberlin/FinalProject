-- Declare variables
DECLARE @TourCode INT
DECLARE @DestinationCode INT
DECLARE @AttractionCode1 INT
DECLARE @AttractionCode2 INT

-- Cursor to iterate through each tour
DECLARE TourCursor CURSOR FOR
SELECT TourCode, DestinationCode
FROM dbo.Tours
WHERE IsOrgenized = 1;

OPEN TourCursor

FETCH NEXT FROM TourCursor INTO @TourCode, @DestinationCode

WHILE @@FETCH_STATUS = 0
BEGIN
    -- Get two random attractions for the current DestinationCode
    SELECT TOP 2 @AttractionCode1 = AttractionID
    FROM dbo.Attractions
    WHERE AddressCode = @DestinationCode
    ORDER BY NEWID()

    INSERT INTO dbo.AtractionsToTours (AttractionCode, TourCode)
    VALUES (@AttractionCode1, @TourCode);

    FETCH NEXT FROM TourCursor INTO @TourCode, @DestinationCode
END

CLOSE TourCursor
DEALLOCATE TourCursor

-- Ensure each tour has at least 2 attractions
DECLARE @Count INT

DECLARE CheckCursor CURSOR FOR
SELECT TourCode
FROM dbo.Tours
WHERE IsOrgenized = 1;

OPEN CheckCursor

FETCH NEXT FROM CheckCursor INTO @TourCode

WHILE @@FETCH_STATUS = 0
BEGIN
    SELECT @Count = COUNT(*)
    FROM dbo.AtractionsToTours
    WHERE TourCode = @TourCode;

    IF @Count < 2
    BEGIN
        -- Get one more random attraction for the current TourCode
        SELECT TOP 1 @AttractionCode2 = AttractionID
        FROM dbo.Attractions
        WHERE AddressCode = @DestinationCode
        ORDER BY NEWID()

        INSERT INTO dbo.AtractionsToTours (AttractionCode, TourCode)
        VALUES (@AttractionCode2, @TourCode);
    END

    FETCH NEXT FROM CheckCursor INTO @TourCode
END

CLOSE CheckCursor
DEALLOCATE CheckCursor

-- End of the script
