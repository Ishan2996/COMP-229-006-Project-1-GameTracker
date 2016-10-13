CREATE TABLE [dbo].[FootballTeam01]
(
	[TeamName1] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [TeamScore1] INT NULL, 
    [Spectators1] INT NULL
)

CREATE TABLE [dbo].[FootballTeam02]
(
	[TeamName2] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [TeamScore2] INT NULL, 
    [Spectators2] INT NULL
)

INSERT INTO FootballTeam01(TeamName1, TeamScore1, Spectators1)
VALUES ('Toronto FC', 3, 5000)

INSERT INTO FootballTeam02(TeamName2, TeamScore2, Spectators2)
VALUES ('DC UNITED', 1, 5000)
