-- Write a query to display your age in days

SELECT DATEDIFF(dd,'1997/05/23','2022/05/17') AS DateDiff;


--3 sql query
create table Emp8(Empid int NOT NULL, Name varchar(20) NOT NULL, Salary int, Deptno int,
CONSTRAINT check_person CHECK ((Salary>=5000 AND Salary <=50000) AND (Deptno=10 OR deptno=20 OR Deptno=30)))


Insert INTO EMP8 VALUES(1, 'konda', 30000, 10);
Insert INTO EMP8 VALUES(1, 'murthy', 30000, 40);
Insert INTO EMP8 VALUES(1, 'murthy', 70000, 20);
Insert INTO EMP8 VALUES(1, 'murthy', 40000, 20);


select * from Emp8;