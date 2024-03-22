CREATE TABLE books (
    id INT PRIMARY KEY,
    title VARCHAR(255) NOT NULL,
    author VARCHAR(255) NOT NULL,
    isbn VARCHAR(13) UNIQUE,
    published_date DATETIME
);

--inserting data into book table
INSERT INTO books (id, title, author, isbn, published_date)
VALUES
    (1, 'My First sql book', 'Marry parker', '981483029127', '2012-02-22 12:08:17'),
    (2, 'My Second sql book', 'John mayer', '857300923713', '1972-07-03 09:22:45'),
    (3, 'My Third sql book', 'Cary fint', '523120967812', '2015-10-18 14.05.44');


--Review Table

	CREATE TABLE reviews (
    review_id INT PRIMARY KEY,
    book_id INT,
    reviewer_name VARCHAR(255) NOT NULL,
    content TEXT,
    rating INT,
    published_date DATETIME
);

-- inserting the data into review table
INSERT INTO reviews (review_id, book_id, reviewer_name, content, rating, published_date)
VALUES
    (1, 1, 'John Smith', 'My first review', 4, '2017-12-10 05:50:11'),
    (2, 2, 'John Smith', 'My second review', 5, '2017-10-13 15:05:12'),
    (3, 3, 'Alice Walker', 'Another review', 1, '2017-10-22 23:47:10');

--query to fetch the details of the books written by author whose name ends with er.
	SELECT b.title, b.author
FROM books b
WHERE b.author LIKE '%er';

--Display the Title ,Author and ReviewerName for all the books from the above table
SELECT b.title, b.author, r.reviewer_name
FROM books b
JOIN reviews r ON b.id = r.book_id;


--Question2
--Display the reviewer name who reviewed more than one book.
SELECT reviewer_name
FROM reviews
GROUP BY reviewer_name
HAVING COUNT(DISTINCT book_id) > 1;


 
 --QUESTION 3
 --Customer Table
 CREATE TABLE customer (
    ID INT PRIMARY KEY,
    NAME VARCHAR(255) NOT NULL,
    AGE INT,
    ADDRESS VARCHAR(255),
    SALARY DECIMAL(10, 2)
);

-- inserting data into customer table
INSERT INTO customer (ID, NAME, AGE, ADDRESS, SALARY)
VALUES
    (1, 'Ramesh', 32, 'Ahmedabad', 2000.00),
    (2, 'Khilan', 25, 'Delhi', 1500.00),
    (3, 'Kaushik', 23, 'Kota', 2000.00),
    (4, 'Chaitali', 25, 'Mumbai', 6500.00),
    (5, 'Hardik', 27, 'Bhopal', 8500.00),
    (6, 'Komal', 22, 'Mp', 4500.00),
    (7, 'Muffy', 24, 'Indore', 10000.00);


--Display the Name for the customer from above customer table who live in same address which has character o anywhere in address

SELECT NAME
FROM customer
WHERE ADDRESS LIKE '%o%';

--Order Table
CREATE TABLE orders (
    OID INT PRIMARY KEY,
    DATE DATETIME,
    CUSTOMER_ID INT,
    AMOUNT DECIMAL(10, 2)
);

--Question 4
-- Insert data into the orders table
INSERT INTO orders (OID, DATE, CUSTOMER_ID, AMOUNT)
VALUES
    (102, '2009-10-08 00:00:00', 3, 3000.00),
    (100, '2009-10-08 00:00:00', 3, 1500.00),
    (101, '2009-11-20 00:00:00', 2, 1560.00),
    (103, '2008-05-20 00:00:00', 4, 2060.00);

--Write a query to display the Date,Total no of customer placed order on same Date

  SELECT DATE, COUNT(DISTINCT CUSTOMER_ID) AS Total_Customers
FROM orders
GROUP BY DATE;
  

--Question 5
--Display the Names of the Employee in lower case, whose salary is null

SELECT LOWER(NAME) AS Employee_Name
FROM customer
WHERE SALARY IS NULL;


--Student Table

CREATE TABLE StudentDetails (
    StudentID INT PRIMARY KEY,
    RegisterNo INT,
    Name NVARCHAR(50),
    Age INT,
    Qualification NVARCHAR(50),
    MobileNo BIGINT,
    Mail_id NVARCHAR(100),
    Location NVARCHAR(50),
    Gender CHAR(1)
);

--inserting data into student table
INSERT INTO StudentDetails (StudentID, RegisterNo, Name, Age, Qualification, MobileNo, Mail_id, Location, Gender)
VALUES
    (1, 2, 'Sai', 22, 'B.E', 9952836777, 'sai@gmail.com', 'Chennai', 'M'),
    (2, 3, 'Kumar', 20, 'BSC', 7890125648, 'kumar@gmail.com', 'Madurai', 'M'),
    (3, 4, 'Selvi', 22, 'B.Tech', 8904567342, 'selvi@gmail.com', 'Salem', 'F'),
    (4, 5, 'Nisha', 25, 'M.E', 7834672310, 'Nisha@gmail.com', 'Theni', 'F'),
    (5, 6, 'SaiSaran', 21, 'B.A', 7890345678, 'saran@gmail.com', 'Madurai', 'F'),
    (6, 7, 'Tom', 23, 'BCA', 8901234675, 'Tom@gmail.com', 'Pune', 'M');

----Write a sql server query to display the Gender,Total no of male and female from the above relation
	SELECT
    'Male' AS Label,
    COUNT(CASE WHEN Gender = 'M' THEN 1 END) AS Value
FROM StudentDetails
UNION ALL
SELECT
    'Female' AS Label,
    COUNT(CASE WHEN Gender = 'F' THEN 1 END) AS Value
FROM StudentDetails
UNION ALL
SELECT
    'Total' AS Label,
    COUNT(*) AS Value
FROM StudentDetails;


