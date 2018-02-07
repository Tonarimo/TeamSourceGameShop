CREATE TABLE Games
(
	GameID				int PRIMARY KEY IDENTITY,
	GameName			varchar(50) NOT NULL,
	Price				float NOT NULL,
	NumberOfCopies		int NOT NULL,
	AvailabilityOfGame	varchar(10) NOT NULL
)