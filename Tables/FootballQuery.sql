CREATE TABLE [dbo].[Volleyball12]
(
    [TeamName1] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [TeamScore1] INT NULL, 
    [Spectators1] INT NULL
)

INSERT INTO Volleyball12 (TeamName1, TeamScore1, Spectators1)
VALUES ('Canada', 9, 100)

INSERT Volleyball12 (TeamName1, TeamScore1, Spectators1)
VALUES ('Russia', 7, 120)