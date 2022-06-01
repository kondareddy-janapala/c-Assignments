
create table Code_Employee (empno int primary key, 
empname varchar(50) not null, 
empsal numeric(10,2) check(empsal >= 25000),
emptype varchar(1) check(emptype in('C','P')))


select * from Code_Employee;

drop table Code_Employee;

go
 create procedure insertemp 
 (
 @empno int, 
 @empname varchar(50),
  @empsal numeric(10,2), 
  @emptype varchar(1)
  )
as
begin
	insert into Code_Employee(empno, empname, empsal, emptype) values (@empno, @empname, @empsal, @emptype);
end
exec 
