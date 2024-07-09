
--1 Select all the rows from the "Customers" table. 
SELECT * 
FROM Customers;

--2 Get distinct countries from the Customers table. (Hint: research the DISTINCT keyword.)
SELECT DISTINCT(Country)
FROM Customers
ORDER BY Country;
--3 Get all the rows from the table Customers where the Customer’s ID starts with “BL” (% is basically the 'wildcard' aka we don'tcare what comes after what we're searching for)
SELECT * 
FROM Customers
WHERE CustomerID LIKE 'BL%';

--4 Get the first 100 records of the orders table. 
--DISCUSS: Why would you do this? What else would you likely need to include in this query? 
--DISCUSSION ANSWER: Useful if you want to know to query something like 'top 5 most expensive orders'
SELECT TOP 100 *
FROM Orders;

--5 Get all customers that live in the postal codes 1010, 3012, 12209, and 05023. 
SELECT *
FROM Orders
WHERE ShipPostalCode IN ('1010', '3012', '12209', '05023');

--6 Get all orders where the ShipRegion is not equal to NULL.
SELECT * 
FROM Orders
Where ShipRegion IS NOT NULL;

--7 Get all customers ordered by the country, then by the city.
SELECT * 
FROM Customers
ORDER BY Country, City DESC;

--8 Add a new customer to the customers table. You can use whatever values.
--(:D ?8 AND ?9 ARE VERY USEFUL FOR TABLE MANGEMENT, COME BACK TO THIS OFTEN!)
SELECT  * 
FROM Customers
WHERE CustomerID = 'SWAGS';

INSERT INTO Customers(CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax)
VALUES ('SWAGS', 'Swaggin Donunts', 'Soulja Boi','Logistics Guy','123 Gucci St.', 'Potato', NULL, '12345', 'USA', '(165)222-7924', NULL);

--9 Update all ShipRegion to the value ‘EuroZone’ in the Orders table, where the ShipCountry is equal to France.  

SELECT *
FROM Orders
WHERE ShipCountry = 'France';

UPDATE Orders
SET ShipRegion = 'EuroZone'
WHERE ShipCountry = 'France';

--10 Delete all orders from OrderDetails that have quantity of 1.

SELECT * FROM [Order Details]
ORDER BY Quantity ASC;

DELETE FROM [Order Details]
WHERE Quantity = 1;

--11 Find the CustomerID that placed order 10290 (orders table).
SELECT TOP 3 * FROM Orders;

SELECT CustomerID
FROM Orders
WHERE OrderID = 10290;

--12 Join the orders table to the customers table.
SELECT TOP 3 * FROM Orders
SELECT TOP 3 * FROM Customers;

SELECT Orders.OrderID, Customers.CompanyName
FROM Orders
FULL OUTER JOIN Customers ON Customers.CustomerID=Orders.CustomerID
ORDER BY Orders.CustomerID;

--13 Get employees’ firstname for all employees who report to no one.
SELECT FirstName
FROM Employees
WHERE ReportsTo IS NULL;

--14 Get employees’ firstname for all employees who report to Andrew.
SELECT FirstName
FROM Employees
WHERE ReportsTo = 2;

--15 Write an SQL command to create an index on the CustomerID column in the Customers table.
--(Also useful, come back to 15 for when creating indexes)
SELECT TOP 3 * FROM Customers;

CREATE INDEX TestName
ON Customers (CustomerID);