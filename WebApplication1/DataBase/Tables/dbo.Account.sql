create table Account(
Id int Identity(1,1),
Number varchar(100) not null,
Balance decimal(10,2) not null,
Type Bit not null,
CustomerId int not null,
constraint PK_Account Primary key(Id),
constraint Fk_Account_Customer_CustomerId foreign key (CustomerId) references dbo.Customer(Id)
)