--create database CoffeeShopR;


create table customers(
Id int identity(1,1) PRIMARY KEY,
CustomerName varchar(50), 
Contact varchar(50),
Adrs varchar(50)
)

INSERT INTO customers VALUES ('Ali', 'Dhaka' ,'01311369369')
INSERT INTO customers VALUES ('Hasan', 'Sylhet' ,'01711369369')
INSERT INTO customers VALUES ('Rafi', 'BNorisal' ,'01811369369')



create table items(
Id int identity(1,1) PRIMARY KEY,
ItemName varchar(50),
Price float
)

INSERT INTO items (ItemName, Price) Values ('Black', 120)
INSERT INTO items (ItemName, Price) Values ('Regular', 80)
INSERT INTO items (ItemName, Price) Values ('Cold', 100)
INSERT INTO items (ItemName, Price) Values ('Hot', 90)

SELECT * FROM Items
SELECT * FROM Customers

create table orders(
Id int identity(1,1) PRIMARY KEY,
CustomerId int FOREIGN KEY REFERENCES customers(Id),
ItemId int  FOREIGN KEY REFERENCES items(Id),
Quantity int,
TotalPrice float
)

INSERT INTO orders VALUES (1, 1 , 5, 600)
INSERT INTO orders VALUES (1, 2 , 3, 240)
INSERT INTO orders VALUES (1, 3 , 2, 200)

--INSERT INTO orders VALUES (2, 2 , 2, 160)
--INSERT INTO orders VALUES (2, 3 , 3, 300)
--INSERT INTO orders VALUES (2, 4 , 4, 400)

Select o.Id,c.CustomerName,i.ItemName,Quantity,i.Price,TotalPrice from orders as o
Left Join customers As c On c.CustomerName = o.Customer
Left Join items As i On i.ItemName = o.Item


--drop table customers
--drop table items
--drop table orders