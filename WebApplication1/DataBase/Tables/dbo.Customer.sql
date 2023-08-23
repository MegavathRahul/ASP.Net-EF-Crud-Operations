create table Customer(
Id int Identity(1,1),
Name Varchar(100) not null,
Dob Datetime not null,
PanNumber varchar(100) not null,
City Varchar not null,
constraint PK_Customer Primary key(Id)
)