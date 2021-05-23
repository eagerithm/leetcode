# #176 Second Highest Salary

Category: DataBase
CreatedDate: May 16, 2021 12:56 PM
Difficulty: Easy
language: oracle
url: https://leetcode.com/problems/second-highest-salary/

## #176. Second Highest Salary

### Question

Write a SQL query to get the second highest salary from the `Employee` table.

```
+----+--------+
| Id | Salary |
+----+--------+
| 1  | 100    |
| 2  | 200    |
| 3  | 300    |
+----+--------+

```

For example, given the above Employee table, the query should return `200` as the second highest salary. If there is no second highest salary, then the query should return `null`.

```
+---------------------+
| SecondHighestSalary |
+---------------------+
| 200                 |
+---------------------+
```

- Schema

```sql
Create table If Not Exists Employee (Id int, Salary int)
Truncate table Employee
insert into Employee (Id, Salary) values ('1', '100')
insert into Employee (Id, Salary) values ('2', '200')
insert into Employee (Id, Salary) values ('3', '300')
```

### Answer

/* Write your PL/SQL query statement below */

select Max(salary) as SecondHighestSalary
from Employee where Salary  <(select Max(salary) from Employee )

### Submissions

Runtime: 467 ms, faster than 53.29% of Oracle online submissions for Second Highest Salary.

Memory Usage: 0B, less than 100.00% of Oracle online submissions for Second Highest Salary.