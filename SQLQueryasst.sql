use sample3

create procedure getemp1(@name  NVARCHAR(50))

as

begin 

select empname from employee inner join department on department.deptname=employee.empname where deptname=@name


end 

exec dbo.getemp1 export

select * from employee

---------------------------------------------------

create procedure insertrecords(@no int,@name nvarchar(20), @sal int, @depno int)
as
     BEGIN
     insert into employee(empno, empname, salary, deptno) values (@no, @name,@sal, @depno)
     END
	 
	 drop procedure insertrecords

	 exec dbo.insertrecords 1,ssw,1200,102
	 
	

	 select * from employee

---------------------------------------------------------------------------------------------------

create procedure getmaxsalary (@depno int)
as
begin
select empname,MAX(salary) as highsal from employee where deptno=@depno group by empname
end 

drop procedure getmaxsalary

exec dbo.getmaxsalary 1
----------------------------------------------------------------------


create procedure calulatetax(@eno int)
as
begin
select * from employee where empno=@eno

declare @tax float,@sal int
select @sal = salary from employee where empno=@eno 

set @tax=(@sal*5)/100

update employee set tax=@tax where empno=@eno


end 

drop procedure calulatetax

exec dbo.calulatetax 2
 