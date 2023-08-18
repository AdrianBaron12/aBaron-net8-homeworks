CREATE DATABASE LibrariesManagement;

USE LibrariesManagement;

CREATE TABLE Libraries
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    Name VARCHAR(50),
    StreetName VARCHAR(50),
    City VARCHAR(50)
);

CREATE TABLE Librarians
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    Name VARCHAR(30),
    HireDate Date,
    IsOnHoliday VARCHAR(3),
    LibraryId INT REFERENCES Libraries(Id)
);

CREATE TABLE Books
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    Title VARCHAR(50),
    AuthorFirstName VARCHAR(30),
    AuthorLastName VARCHAR(30),
    Type VARCHAR(10), -- crime, fantasy, horror, adventure
);

CREATE TABLE Books_Libraries
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    BookId INT REFERENCES Books(Id),
    LibraryId INT REFERENCES Libraries(Id)
);

CREATE TABLE Sales
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    NumberOfCopies INT,
    LibraryId INT REFERENCES Libraries(Id),
    LibrarianId INT REFERENCES Librarians(Id)
);

CREATE TABLE Books_Sales
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    BookId INT REFERENCES Books(Id),
    SalesId INT REFERENCES Sales(Id)
);

CREATE TABLE Authors
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    FirstName VARCHAR(30),
    LastName VARCHAR(30),
    Email VARCHAR(80)
);

ALTER TABLE Books
ADD AuthorId INT REFERENCES Authors(Id);

ALTER TABLE Librarians
ADD IsOnHoliday BIT;

CREATE TABLE BookGenres
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    GenreName VARCHAR(20)
);


ALTER TABLE Books
ADD GenreId INT REFERENCES BookGenres(Id);

CREATE TABLE SalesDetails
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    SalesId INT REFERENCES Sales(Id),
    BookId INT REFERENCES Books(Id),
    NumberOfCopiesSold INT
);

ALTER TABLE Books_Sales
DROP COLUMN BookId;


ALTER TABLE Sales
DROP COLUMN NumberOfCopies;

ALTER TABLE Books
DROP COLUMN AuthorFirstName;

ALTER TABLE Books
DROP COLUMN AuthorLastName;


--2
SELECT L.Name AS LibrarianName, L.HireDate, L.IsOnHoliday, Lib.Name AS LibraryName
FROM Librarians AS L
INNER JOIN Libraries AS Lib ON L.LibraryId = Lib.Id
ORDER BY L.Name, Lib.Name DESC;

--3
UPDATE Libraries
SET StreetName = 'STR.' + StreetName
WHERE StreetName NOT LIKE 'STR.%';

SELECT * FROM Libraries;

--4

SELECT A.Email
FROM Authors AS A
INNER JOIN Books AS B ON A.Id = B.AuthorId
GROUP BY A.Id, A.Email
HAVING COUNT(B.Id) > 3;

--5

SELECT TOP 1 Lib.Name AS LibraryName, B.Title AS BookTitle
FROM SalesDetails AS SD
INNER JOIN Books AS B ON SD.BookId = B.Id
INNER JOIN Libraries AS Lib ON SD.Id = Lib.Id
ORDER BY SD.NumberOfCopiesSold DESC;

--6

SELECT L.Name AS LibrarianName, L.HireDate, L.IsOnHoliday
FROM Librarians AS L
WHERE L.IsOnHoliday = 'No' AND L.HireDate < DATEADD(YEAR, -5, GETDATE());

--7 
GO
CREATE PROCEDURE GetBookLibraryCount
    @BookTitle VARCHAR(50)
AS
BEGIN
    SELECT B.Title AS BookTitle, COUNT(DISTINCT BL.LibraryId) AS LibraryCount
    FROM Books AS B
    LEFT JOIN Books_Libraries AS BL ON B.Id = BL.BookId
    WHERE B.Title = @BookTitle
    GROUP BY B.Title;
END;
GO

--8
GO
CREATE FUNCTION GetAuthorCopiesSold
(
    @AuthorEmail VARCHAR(50)
)
RETURNS TABLE
AS
RETURN (
    SELECT B.Title AS BookTitle, SUM(SD.NumberOfCopiesSold) AS TotalCopiesSold
    FROM Authors AS A
    INNER JOIN Books AS B ON A.Id = B.AuthorId
    LEFT JOIN SalesDetails AS SD ON B.Id = SD.BookId
    WHERE A.Email = @AuthorEmail
    GROUP BY B.Title
);
GO

--9
GO
CREATE TRIGGER AssignLibraryAfterInsert
ON Librarians
AFTER INSERT
AS
BEGIN
    DECLARE @NewLibraryId INT;

    SELECT @NewLibraryId = Id FROM Libraries WHERE Id NOT IN (SELECT LibraryId FROM inserted);

    UPDATE Librarians
    SET LibraryId = @NewLibraryId
    WHERE LibraryId IS NULL;
END;
GO

--10

BEGIN TRANSACTION;


INSERT INTO Libraries (Name, StreetName, City) VALUES ('Library A', 'Main St.', 'City A');

SAVE TRANSACTION FirstSave;

INSERT INTO Librarians (Name, HireDate, IsOnHoliday, LibraryId) VALUES ('Name Name', '2022-08-08', 'No', 1);

UPDATE Libraries SET City = 'City B' WHERE Id = 1;

ROLLBACK TRANSACTION FirstSave; 

INSERT INTO Libraries (Name, StreetName, City) VALUES ('Library B', 'Second St.', 'City C');

COMMIT TRANSACTION;

SELECT * FROM Libraries;
