create table Categories(
Id int primary key identity(1,1),
name varchar(50)
)


create table Items(
Id int primary key identity(1,1),
name varchar(50),
categories_id int foreign key references categories,
pic varchar(200),
exps date,
Discription varchar
)

create table Variance (
id int primary key identity(1,1),
Item_id int references Items,
name varchar(50),
price decimal,
stock decimal)


create table Customers(
Id int primary key identity(1,1),
name varchar(50),
adres varchar(50),
phone varchar(15),
email varchar(50),
lastvisit decimal,
due decimal
)

create table vendors (
ID int primary key identity(1,1),
name varchar(50),
adress varchar(50),
phoneno varchar(15),
email varchar(50),
due decimal,
advance decimal,
panno varchar(20),
vatno varchar(20)
)

create table billing (
id int primary key identity(1,1),
bill_no int,
dates date,
customer_id int foreign key references customers,
total decimal,
paid decimal,
due decimal
)

 
 create table BillItems(
 id int primary key,
 item_id int foreign key references  items,
 rate decimal,
 amount decimal,
 bill_id int foreign key references billing,
 )

 create table supplies (
 id int primary key identity(1,1),
 vendors_id int foreign key references vendors,
 transport_cost decimal,
 dates date,
 total decimal,
 paid decimal,
 due decimal
)

create table supplyItems(
id int primary key identity(1,1),
supply_id int foreign key references supplyitems,
item_id int foreign key references items,
amount decimal,
rate decimal,
)

  create table employees(
  id int primary key identity(1,1),
  name varchar(50),
  adress varchar(50),
  phone varchar(15),
  photo varchar(200),
  docs varchar(1000),
  startdate datetime,
  salary decimal,
  email varchar(50),
  )
  
   
   create table salaries (
   id int primary key identity(1,1),
   employee_id int foreign key references employees,
   amount decimal,
   form date,
   toto date,
   dates date
   )


   create table advance (
   id int primary key identity(1,1),
   emplyee_id int foreign key references employees,
   amount decimal,
   dates date
   )


   create table expencesCategories (
   id int primary key identity(1,1),
   name varchar(50),
   )


   create table expences(
   id int primary key identity(1,1),
   expences_id int foreign key references expencesCategories,
   dates date,
   amount decimal,
   descriptions varchar(1000)
   )

