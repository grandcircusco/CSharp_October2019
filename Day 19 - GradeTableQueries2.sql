--SELECT COUNT(*) FROM Student;
--SELECT COUNT(*) FROM Student WHERE GPA IS NULL;
--SELECT * FROM Student
--SELECT SUM(GPA) FROM Student;
--SELECT AVG(GPA) FROM Student;
--SELECT SUM(StudentId) AS 'Total Ids', AVG(GPA) AS 'Average GPA'FROM Student

--INSERT INTO Grade(LabName, DueDate, LabGrade, StudentId)
--VALUES('Destroy Evil', '2776-07-04 13:13:13', 'A', '6'),
--('Game of Life', '4200-10-30 23:23:23', 'C', '2'),
--('Who shot 2pac', '2020-12-23 09:00:00', 'B', '5'),
--('Epstn was mrdrd','2020-11-05 08:00:00','A', 5),
--('Eat Everything','2019-11-07 14:00:00','E', '1'),
--('Cat Dissection', '2001-12-05 10:20:30', 'D', '2'),
--('Turn Super Saiyan', '2019-08-08', 'A', '2'),
--('Watch the Matrix', '2019-11-8 12:00:00', 'A', 4)


--SELECT * FROM Grade
--JOIN Student ON Grade.StudentId = Student.StudentId;

--SELECT * FROM Grade
--INNER JOIN Student ON Grade.StudentId = Student.StudentId;

--SELECT * FROM Grade
--LEFT JOIN Student ON Grade.StudentId = Student.StudentId;

SELECT * FROM Grade
RIGHT JOIN Student ON Grade.StudentId = Student.StudentId;

--SELECT * FROM Grade
--CROSS JOIN Student

