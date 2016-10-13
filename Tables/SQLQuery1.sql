CREATE TABLE [dbo].[Football1]
(
	[TeamName1] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [TeamScore1] INT NULL, 
    [Spectators1] INT NULL
)



CREATE TABLE [dbo].[Football2]
(
	[TeamName2] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [TeamScore2] INT NULL, 
    [Spectators2] INT NULL
)


INSERT INTO Football1 (TeamName1, TeamScore1, Spectators1)
VALUES ('Toronto FC', 3, 3)
