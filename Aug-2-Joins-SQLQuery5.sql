select Employ.Empno, Name, Dept, Basic, 
LeaveHistory.LeaveId, LeaveStartDate, LeaveEndDate
from Employ INNER JOIN LeaveHistory 
ON Employ.Empno = LeaveHistory.EmpNo

select E.Empno, Name, Dept, Basic, 
LH.LeaveId, LeaveStartDate, LeaveEndDate
from Employ E INNER JOIN LeaveHistory LH 
ON E.Empno = Lh.EmpNo

select A.AgentId, FirstName, LastName, City, State,
P.PolicyId, AppNumber, ModalPremium, AnnualPremium, PaymentModeId
from Agent A INNER JOIN AgentPolicy AP ON 
A.AgentId = AP.AgentID 
INNER JOIN Policy P ON P.PolicyId = AP.PolicyID

-- Example for Left-Outer Join 


select E.Empno, Name, Dept, Basic, 
LH.LeaveId, LeaveStartDate, LeaveEndDate
from Employ E LEFT JOIN LeaveHistory LH 
ON E.Empno = Lh.EmpNo

select A.AgentId, FirstName, LastName, City, State,
P.PolicyId, AppNumber, ModalPremium, AnnualPremium, PaymentModeId
from Agent A LEFT JOIN AgentPolicy AP ON 
A.AgentId = AP.AgentID 
LEFT JOIN Policy P ON P.PolicyId = AP.PolicyID

-- Example for Right-Outer Join

select E.Empno, Name, Dept, Basic, 
LH.LeaveId, LeaveStartDate, LeaveEndDate
from Employ E RIGHT JOIN LeaveHistory LH 
ON E.Empno = Lh.EmpNo

select A.AgentId, FirstName, LastName, City, State,
P.PolicyId, AppNumber, ModalPremium, AnnualPremium, PaymentModeId
from Agent A RIGHT JOIN AgentPolicy AP ON 
A.AgentId = AP.AgentID 
RIGHT JOIN Policy P ON P.PolicyId = AP.PolicyID

-- Example for Full outer Join

select A.AgentId, FirstName, LastName, City, State,
P.PolicyId, AppNumber, ModalPremium, AnnualPremium, PaymentModeId
from Agent A FULL JOIN AgentPolicy AP ON 
A.AgentId = AP.AgentID 
FULL JOIN Policy P ON P.PolicyId = AP.PolicyID


-- Cross Join 

select * from Agent cross join AgentPolicy

select * from Policy Cross Join AgentPolicy

SELECT TOP (1000) [EmpId]
      ,[EmployName]
      ,[MgrId]
      ,[LeaveAvail]
      ,[DateOfBirth]
      ,[Email]
      ,[Mobile]
  FROM [wiprojuly].[dbo].[Employee]


select E1.EmpId 'Manager Id',E1.EmployName 'Manager Name',
E2.EmpId 'Employee Id',E2.EmployName 'Employee Name'
from Employee E1 INNER JOIN Employee E2 ON 
E1.EmpId = E2.MgrId
GO


select E1.EmpId 'Manager Id',E1.EmployName 'Manager Name',
E2.EmpId 'Employee Id',E2.EmployName 'Employee Name'
from Employee E1 RIGHT JOIN Employee E2 ON 
E1.EmpId = E2.MgrId
GO

SELECT TOP (1000) [Empno]
      ,[Name]
      ,[Gender]
      ,[Dept]
      ,[Desig]
      ,[Basic]
  FROM [wiprojuly].[dbo].[Employ]

  select max(basic) from Employ;

  select name from Employ where basic = (select max(basic) from Employ) 
  GO

  -- Dispaly second max. salary 

  select max(basic) from Employ where basic < 
  (select Max(basic) from Employ)

  -- Display Name of employ who is getting 2nd max. salary

  select Name from Employ where basic = (
    select max(basic) from Employ where basic < 
  (select Max(basic) from Employ))
  GO

  select * from Policy;


  select PolicyId, AppNumber, ModalPremium, AnnualPremium,
  ROW_NUMBER() OVER(Order By AnnualPremium desc) 'Rno'
  from Policy
  GO

  select PolicyId, AppNumber, ModalPremium, AnnualPremium,
  RANK() OVER(Order By AnnualPremium desc) 'Rno'
  from Policy
  GO

  select PolicyId, AppNumber, ModalPremium, AnnualPremium,
  DENSE_RANK() OVER(Order By AnnualPremium desc) 'Rno'
  from Policy
  GO

  select * from Policy
  GO

  select max(annualpremium) from Policy 
  GO

  -- Display PolicyID of max. annualpremium 

  select PolicyId from Policy WHERE AnnualPremium = 
  (select MAX(annualpremium) from  Policy)

  -- Display 2nd max AnnualPremium 

  select max(annualpremium) from Policy WHERE AnnualPremium < 
  (select max(annualpremium) from Policy)

  -- Display matching records from Employ and LeaveHistory table 

select * from Employ where Empno = ANY(select Empno from LeaveHistory)
GO

-- Display matching records from Agent and AgentPolicy Tables 

select * from Agent WHERE AgentId = ANY(select AgentId from AgentPolicy) 

-- Display Matching records from Policy and AgentPolicy Tables 

select * from Policy WHERE PolicyId = ANY (select PolicyId from AgentPolicy) 
GO

-- Display Employ Details who are not taken Leave (Means records which are in Employ table, but not in
-- LeaveHistory Table)

select * from Employ WHERE Empno <> ALL(select Empno from LeaveHistory) 
GO

-- Display Idle Agents (AgentId Exists in Agent Table, but not in AgentPolicy Table) 

select * from Agent where AgentId <> ALL(select AgentId from AgentPolicy) 
GO

-- Display Idle Policies (PolicyId exists in Policy Table, but not in AgentPolicy Table) 

select * from Policy WHERE PolicyId <> ALL(select PolicyId from AgentPolicy) 
GO


create table EmployDummy
(
   eno int,
   name int,
   basic int
)

-- Add primary key on Eno field 


alter table EmployDummy alter column eno int not null;

alter table EmployDummy add primary key(eno);

-- Change name field to varchar(30) 

alter table EmployDummy alter column name varchar(30) 

-- Change basic field to numeric(9,2) 

alter table EmployDummy Alter Column Basic Numeric(9,2);

sp_help EmployDummy
GO

alter table EmployDummy Add Gender varchar(10)


-- Drop Gender column from EmployDummy table 

alter table EmployDummy drop column Gender 
GO