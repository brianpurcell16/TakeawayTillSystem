Drop table Sales;
Drop table Employees;

Create Table Sales(
SaleID int identity(1,1) Primary Key,
MadeOrder Varchar(300),
Amount decimal(7,2),
PaymentType varchar(40),
OrderType varchar(30)
);

Create Table Employees(
EmpID int identity(1,1) Primary Key,
Username Varchar(100),
Password Varchar(30),
EmpRank varchar(20),
ClockIn datetime2,
ClockOut datetime2
);
