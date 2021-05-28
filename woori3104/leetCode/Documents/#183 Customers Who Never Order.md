# #183 Customers Who Never Order

Category: DataBase
CreatedDate: May 18, 2021 12:48 AM
Difficulty: Easy
language: oracle
url: https://leetcode.com/problems/customers-who-never-order/

## 183. Customers Who Never Order

### Question

GetSchema

```sql
Create table If Not Exists Customers (Id int, Name varchar(255))
Create table If Not Exists Orders (Id int, CustomerId int)
Truncate table Customers
insert into Customers (Id, Name) values ('1', 'Joe')
insert into Customers (Id, Name) values ('2', 'Henry')
insert into Customers (Id, Name) values ('3', 'Sam')
insert into Customers (Id, Name) values ('4', 'Max')
Truncate table Orders
insert into Orders (Id, CustomerId) values ('1', '3')
insert into Orders (Id, CustomerId) values ('2', '1')
```

Suppose that a website contains two tables, the `Customers` table and the `Orders` table. Write a SQL query to find all customers who never order anything.

Table: `Customers`.

```
+----+-------+
| Id | Name  |
+----+-------+
| 1  | Joe   |
| 2  | Henry |
| 3  | Sam   |
| 4  | Max   |
+----+-------+

```

Table: `Orders`.

```
+----+------------+
| Id | CustomerId |
+----+------------+
| 1  | 3          |
| 2  | 1          |
+----+------------+

```

Using the above tables as example, return the following:

```
+-----------+
| Customers |
+-----------+
| Henry     |
| Max       |
+-----------+
```

### Answer

```sql
/* Write your PL/SQL query statement below */
select name as Customers from Customers 
where Id Not in (Select CustomerId from Orders)
```

### Submissions

Runtime: 707 ms, faster than 84.24% of Oracle online submissions for Customers Who Never Order.

Memory Usage: 0B, less than 100.00% of Oracle online submissions for Customers Who Never Order.