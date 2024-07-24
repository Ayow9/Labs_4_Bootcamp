--Exercise: Movie Database --all these tables and queries are in the CompanyDb database. 
--1. Create the Directors Table
--Create a table named Directors with the following columns:
--    DirectorID: An auto-incremented primary key.
--    DirectorName: A VARCHAR(50) that cannot be NULL.
--    BirthYear: An INT.
CREATE TABLE Directors(
DirectorID INT PRIMARY KEY IDENTITY(1,1),
DirectorName VARCHAR(50) NOT NULL,
BirthYear INT,
);

--2. Create the Movies Table
--Create a table named Movies with the following columns:
--    MovieID: An auto-incremented primary key.
--    Title: A VARCHAR(50) that cannot be NULL.
--    Genre: A VARCHAR(50).
--    ReleaseYear: An INT.
--    DirectorID: An INT that references the DirectorID in the Directors table.
CREATE TABLE Movies(
MovieID INT PRIMARY KEY IDENTITY(1,1),
Title VARCHAR(50) NOT NULL,
Genre VARCHAR(50),
ReleaseYear INT,
DirectorID INT,
FOREIGN KEY (DirectorID) REFERENCES Directors(DirectorID)
);

--3. Insert Data into Directors
--Insert the following data into the Directors table:
--    Steven Spielberg, 1946
--    Christopher Nolan, 1970
--    Quentin Tarantino, 1963
INSERT INTO Directors(DirectorName, BirthYear)
VALUES('Steven Spielberg', 1946),
('Christopher Nolan', 1970),
('Quentin Tarantino', 1963);

--4. Insert Data into Movies
--Insert the following data into the Movies table:

--    Jurassic Park, Sci-Fi, 1993, (Steven Spielberg's DirectorID)
--    Inception, Sci-Fi, 2010, (Christopher Nolan's DirectorID)
--    Pulp Fiction, Crime, 1994, (Quentin Tarantino's DirectorID)
INSERT INTO Movies(Title, Genre, ReleaseYear, DirectorID)
VALUES('Jurassic Park', 'Sci-Fi', 1993, 1),
('Inception', 'Sci-Fi', 2010, 2),
('Pulp Fiction', 'Crime', 1994, 3);

--5. Read Data from Movies
--Write a query to list all movies along with their director's name.
SELECT Movies.Title, Directors.DirectorName
FROM  Movies
JOIN Directors ON Movies.DirectorID = Directors.DirectorID;

--6. Update Data in Movies
--Write a query to update the genre of "Inception" to "Science Fiction".
UPDATE Movies
SET Genre = 'Science Fiction'
WHERE MovieID = 2;

--7. Delete Data from Movies
--Write a query to delete the movie named "Pulp Fiction".
DELETE FROM Movies
WHERE MovieID = 3;