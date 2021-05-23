# #181 Employees Earning More Than Their Managers

Category: DataBase
CreatedDate: May 17, 2021 7:20 PM
Difficulty: Easy
language: oracle
url: https://leetcode.com/problems/employees-earning-more-than-their-managers/

### 181 Employees Earning More Than Their Managers

### SQL Schema

```sql
Create table If Not Exists Employee (Id int, Name varchar(255), Salary int, ManagerId int)
Truncate table Employee
insert into Employee (Id, Name, Salary, ManagerId) values ('1', 'Joe', '70000', '3')
insert into Employee (Id, Name, Salary, ManagerId) values ('2', 'Henry', '80000', '4')
insert into Employee (Id, Name, Salary, ManagerId) values ('3', 'Sam', '60000', 'None')
insert into Employee (Id, Name, Salary, ManagerId) values ('4', 'Max', '90000', 'None')
```

### Question

The `Employee` table holds all employees including their managers. Every employee has an Id, and there is also a column for the manager Id.

```
+----+-------+--------+-----------+
| Id | Name  | Salary | ManagerId |
+----+-------+--------+-----------+
| 1  | Joe   | 70000  | 3         |
| 2  | Henry | 80000  | 4         |
| 3  | Sam   | 60000  | NULL      |
| 4  | Max   | 90000  | NULL      |
+----+-------+--------+-----------+

```

Given the `Employee` table, write a SQL query that finds out employees who earn more than their managers. For the above table, Joe is the only employee who earns more than his manager.

```
+----------+
| Employee |
+----------+
| Joe      |
+----------+
```

### Answer

/* Write your PL/SQL query statement below */
select [emp.Name](http://emp.name/) as Employee from Employee emp
inner join Employee manager on emp.ManagerId = [manager.Id](http://manager.id/)
where manager.Salary < emp.Salary;

### Submissions

Runtime: 574 ms, faster than 69.68% of Oracle online submissions for Employees Earning More Than Their Managers.

Memory Usage: 0B, less than 100.00% of Oracle online submissions for Employees Earning More Than Their Managers.