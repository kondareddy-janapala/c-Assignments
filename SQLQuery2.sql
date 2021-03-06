use employee
select * from Emp1;

--1. Retrieve a list of MANAGERS.
select ename,job from Emp1  where job='MANAGER';


--2. Find out salary of both MILLER and SMITH.
select sal,ename from Emp1 where ename in('MILLER','SMITH');

--3. Find out the names and salaries of all employees earning more than 1000 per MONTH
select ename,sal from Emp1 where sal>1000;

--4. Display the names and salaries of all employees except JAMES.
select ename,sal from Emp1 where ename!='JAMES';

--5. Find out the details of employees whose names begin with ?S?.
select * from Emp1 where ename like 's%';

--6. Find out the names of all employees that have ?A? anywhere in their name.
select * from Emp1 where ename like 'A%';

--7. Find out the names of all employees that have ?L? as their third character in their name.
select ename from Emp1 where ename like '_L%';

--8. Find out the names of the employees whose name begin with ?A? or ?M?.
select ename from Emp1 where ename like 'A%' or ename like 'M%';


--9. Compute yearly salary of SMITH.
select sal*12 as "smith yearly salary" from Emp1 where ename='SMITH';


--10. Compute daily salary of JONES.
select sal/30 from Emp1 where ename='JONES';


--11. Calculate the total monthly salary of all employees.
select sum(sal) from Emp1;

--12. Print the average annual salary.
select avg(sal*12) from Emp1;


--13. Select the name, job, salary, department number of all employees except SALESMAN from department number 30.
select ename,job,sal,deptno from Emp1 where ename!='SALESMAN' and deptno=30;

--14. List unique departments of the EMP table.
select deptno from Emp1 group by deptno;

--15. List the name and salary of employees who earn more than 1500 and are in department 10 or 30.
-- Label the columns Employee and Monthly Salary respectively.
select ename,sal from Emp1 where sal>1500 and deptno in (10,30);