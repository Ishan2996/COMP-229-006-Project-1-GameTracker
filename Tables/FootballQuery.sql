CREATE TABLE [dbo].[Football15]
(
    [TeamName1] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [TeamScore1] INT NULL, 
    [Spectators1] INT NULL
)

INSERT INTO Football15 (TeamName1, TeamScore1, Spectators1)
VALUES ('Toronto FC', 2, 1000)

INSERT INTO Football15 (TeamName1, TeamScore1, Spectators1)
VALUES ('DC United', 1, 1100)