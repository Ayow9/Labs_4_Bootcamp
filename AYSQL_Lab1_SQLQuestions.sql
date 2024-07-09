--1
SELECT *
FROM Customers
WHERE Country = 'UK';

--2
SELECT ProductName, UnitPrice 
FROM Products
WHERE UnitPrice > 30.00;

--3
SELECT COUNT(*)
FROM Products
WHERE Discontinued IS NOT NULL;

--4 
SELECT avg(UnitPrice)
FROM Products;

SELECT MAX(UnitPrice)
FROM Products;

SELECT MIN(UnitPrice)
FROM Products;

--5
SELECT Categories.CategoryID, COUNT(Products.CategoryID) AS [Total Products]
FROM Categories
JOIN Products ON Categories.CategoryID = Products.CategoryID
GROUP BY Categories.CategoryID;

--6
SELECT SupplierID, CompanyName AS [Not USA, UK, Or Germany]
FROM Suppliers
WHERE Country <> 'USA' AND COUNTRY <> 'UK' AND Country <> 'Germany';

--7
SELECT DISTINCT (Country) 
FROM Customers;

--8
SELECT TOP 5  *
FROM Products;

--9 
SELECT SUM([Order Details].OrderID) AS [Revenue Q1], SUM(Orders.OrderID) AS [Revenue Q2]
FROM [Order Details]
JOIN Orders ON [Order Details].OrderID = Orders.OrderID
GROUP BY [Order Details].OrderID
ORDER BY [Revenue Q1], [Revenue Q2];

--10 
SELECT DISTINCT COUNT (Employees.EmployeeID) AS [Orders Made], Employees.FirstName, Employees.LastName
FROM Employees
JOIN Orders ON Employees.EmployeeID = Orders.EmployeeID
GROUP BY Employees.FirstName, Employees.LastName;

--11.
SELECT COUNT(Customers.CustomerID) AS [Orders > 10], Customers.CompanyName
FROM Customers
JOIN Orders ON Customers.CustomerID = Orders.CustomerID
GROUP BY Customers.CompanyName
HAVING COUNT(Customers.CustomerID) >= 10;

--12. 
SELECT DISTINCT ProductName AS [Discontinued Products]
FROM Products
WHERE UnitsInStock = 0;

--13. 
SELECT DISTINCT Products.CategoryID, Products.ProductName, Categories.CategoryName
FROM Products
JOIN Categories ON Products.CategoryID = Categories.CategoryID
WHERE Categories.CategoryName = 'Beverages' OR Categories.CategoryName = 'Confections';

--14. 
SELECT TOP 1 Suppliers.SupplierID, Suppliers.CompanyName, COUNT(Products.ProductID) AS ProductCount
FROM Suppliers
JOIN Products  ON Suppliers.SupplierID = Products.SupplierID
GROUP BY Suppliers.SupplierID, Suppliers.CompanyName
ORDER BY ProductCount DESC;

--15. 
SELECT DISTINCT COUNT(Products.ProductID) AS NullProductID, Products.ProductName, Products.UnitsOnOrder
FROM Products
JOIN [Order Details] ON Products.ProductID = [Order Details].ProductID
WHERE Products.UnitsOnOrder = 0
GROUP BY Products.ProductID, Products.ProductName, Products.UnitsOnOrder
ORDER BY NullProductID;

--16.
SELECT OrderDate AS December97Orders
FROM Orders
WHERE OrderDate BETWEEN  '1997-12-01' AND '1997-12-31'; 

--17. 
SELECT TOP 1 Employees.EmployeeID, Employees.FirstName, Employees.LastName, COUNT(Orders.ShippedDate) AS [Most OrdersIn98]
FROM Employees
JOIN Orders ON Employees.EmployeeID = Orders.EmployeeID
WHERE Orders.ShippedDate BETWEEN  '1998-01-01' AND '1998-12-31'
GROUP BY Employees.EmployeeID, Employees.FirstName, Employees.LastName;

--18. 
SELECT TOP 1 Customers.CustomerID, Customers.CompanyName, MAX([Order Details].Quantity) AS [Top Customer], [Order Details].Quantity, Orders.OrderID
FROM Orders
JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID
JOIN Customers ON Customers.CustomerID = Orders.CustomerID
GROUP BY Customers.CustomerID, Customers.CompanyName, [Order Details].Quantity, Orders.OrderID
ORDER BY [Top Customer] DESC;

--19. 
SELECT TOP 1 Shippers.ShipperID, Shippers.CompanyName, COUNT(Orders.ShipVia) AS MostOrdersPlaced
FROM Shippers
JOIN Orders ON Shippers.ShipperID = Orders.ShipVia
GROUP BY Shippers.ShipperID, Shippers.CompanyName, Orders.ShippedDate
ORDER BY MostOrdersPlaced DESC;

--20. 
SELECT TOP 3 COUNT(Products.CategoryID) AS Top3Categories, Categories.CategoryID, Categories.CategoryName
FROM Products
JOIN Categories ON Products.CategoryID = Categories.CategoryID
GROUP BY Categories.CategoryID, Categories.CategoryName, Products.CategoryID
ORDER BY Top3Categories DESC;

