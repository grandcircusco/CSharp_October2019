--CREATE DATABASE ClassDb;
--USE ClassDb;

--CREATE TABLE Student(
--	StudentId int NOT NULL PRIMARY KEY IDENTITY(1,1),
--	FirstName nvarchar(30) NOT NULL,
--	LastName nvarchar(30) NOT NULL,
--	DOB DATE NOT NULL,
--	GPA FLOAT
--);

--INSERT INTO Student(FirstName, LastName, DOB)
--VALUES('Harry', 'Potter', '1980/07/31'),
--('Elliot', 'Mordecai', '2001/01/01'),
--('Herman', 'Munster', '1972/02/23'),
--('Nicolai', 'Tesla', '1854/07/10');

--SELECT * FROM Student;

--SELECT FirstName, LastName FROM Student;

--SELECT StudentId, FirstName, LastName FROM Student WHERE DOB < '2000/01/01';

--UPDATE Student SET GPA='4.2' WHERE FirstName='Nicolai';

--DELETE FROM Student WHERE DOB > '1970/01/01' AND DOB < '1980/01/01';

--SELECT * FROM Student;

--INSERT INTO Student(FirstName, LastName, DOB)
--VALUES('Bruce', 'Willis', '1955/03/19'),
--('Chuck', 'Norris', '1940/03/10');

--SELECT * FROM Student;

--SELECT * FROM Student ORDER BY FirstName;

