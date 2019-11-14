--CREATE DATABASE SchoolDb;
--USE SchoolDb;

--CREATE TABLE Person(
--FirstName nvarchar(25) NOT NULL,
--LastName nvarchar(25) NOT NULL,
--DOB DATE NOT NULL,
--ID int IDENTITY(1,1) PRIMARY KEY);

--CREATE TABLE Student (
--GPA float,
--Tuition int NOT NULL,
--GradDate DATE,
--ID int PRIMARY KEY IDENTITY(1,1),
--PersonID int FOREIGN KEY REFERENCES Person(ID))

--ALTER TABLE Person
--ADD StudentID int FOREIGN KEY REFERENCES Student(ID)

--CREATE TABLE Instructor(
--PersonID int FOREIGN KEY REFERENCES Person(ID),
--HireDate DATE NOT NULL,
--Pay int NOT NULL,
--ID int PRIMARY KEY IDENTITY(1, 1));

--ALTER TABLE Person ADD InstructorID int FOREIGN KEY REFERENCES Instructor(ID);

--CREATE TABLE Courses(
--ID int PRIMARY KEY IDENTITY(1,1) NOT NULL,
--[Language] nvarchar(20) NOT NULL,
--StartDate Date NOT NULL,
--EndDate Date NOT NULL,
--

--ALTER TABLE Courses ADD InstructorID int FOREIGN KEY REFERENCES Instructor(ID);
--ALTER TABLE Courses ALTER COLUMN StartDate Date NOT NULL;
--ALTER TABLE Courses ALTER COLUMN EndDate Date NOT NULL;

--CREATE TABLE StudentCourses(
--ID INTEGER IDENTITY(1, 1) PRIMARY KEY,
--StudentID INTEGER FOREIGN KEY REFERENCES Student(ID),
--CourseID INTEGER FOREIGN KEY REFERENCES Courses(ID),
--FinalGrade INTEGER
--);

--CREATE TABLE Grades(
--DueDate Date NOT NULL,
--Grade INT,
--LabName nvarchar(20) NOT NULL,
--ID INT IDENTITY(1,1) PRIMARY KEY,
--StudentCourseID int FOREIGN KEY REFERENCES StudentCourses(ID)

--);

--INSERT INTO Person(FirstName, LastName, DOB)
--VALUES('Bob', 'Burger', '1987/04/03'),
--('Sterling','Archer','1984/12/09'),
--('Stone','Cold','1964/12/18');

--SELECT * FROM Person

--INSERT INTO Student(Tuition,PersonID)
--VALUES('4','3')

SELECT * FROM Person
SELECT * FROM Student

--UPDATE Person SET StudentID='1' WHERE FirstName='Stone'
