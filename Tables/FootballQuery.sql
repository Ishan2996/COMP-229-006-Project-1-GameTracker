CREATE TABLE [dbo].[Football1]
(
    [TeamName1] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [TeamScore1] INT NULL, 
    [Spectators1] INT NULL
)

INSERT INTO Football1 (TeamName1, TeamScore1, Spectators1)
VALUES ('Toronto FC', 3, 300)

INSERT INTO Football1 (TeamName1, TeamScore1, Spectators1)
VALUES ('DC United', 1, 500)