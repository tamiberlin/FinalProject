-- Start of the script to insert 200 new rooms into the Rooms table

-- Declare variables
DECLARE @HouseID INT
DECLARE @RoomNumber INT
DECLARE @NumOfBeds INT
DECLARE @Terrace BIT
DECLARE @Counter INT

-- Initialize the counter
SET @Counter = 1

-- Get the list of existing HouseIDs from the Housing table
DECLARE @HouseIDs TABLE (HouseID INT)
INSERT INTO @HouseIDs (HouseID)
SELECT HouseID FROM dbo.Housing

-- Get the total number of houses
DECLARE @TotalHouses INT
SELECT @TotalHouses = COUNT(*) FROM @HouseIDs

-- Loop through each HouseID to insert rooms
WHILE @Counter <= 200
BEGIN
    -- Randomly select a HouseID from the list of existing HouseIDs
    SELECT @HouseID = HouseID
    FROM (
        SELECT HouseID, ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS RowNum
        FROM @HouseIDs
    ) AS HouseList
    WHERE HouseList.RowNum = ((@Counter - 1) % @TotalHouses) + 1

    -- Ensure that at least two rooms are assigned to each HouseID
    IF @Counter % 2 = 1
    BEGIN
        SET @RoomNumber = 1
    END
    ELSE
    BEGIN
        SET @RoomNumber = 2
    END

    -- Randomly assign the number of beds between 1 and 4
    SET @NumOfBeds = (ABS(CHECKSUM(NEWID())) % 4) + 1

    -- Randomly assign terrace availability (0 or 1)
    SET @Terrace = ABS(CHECKSUM(NEWID())) % 2

    -- Insert the new room into the Rooms table
    INSERT INTO [dbo].[Rooms] ([HouseCode], [RoomNumber], [NumOfBeds], [Terrace])
    VALUES (@HouseID, @RoomNumber, @NumOfBeds, @Terrace)

    -- Increment the counter
    SET @Counter = @Counter + 1
END

-- End of the script
