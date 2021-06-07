# #180 Consecutive Numbers

Category: DataBase
CreatedDate: May 16, 2021 11:23 PM
Difficulty: Medium
language: oracle
url: https://leetcode.com/problems/consecutive-numbers/

SQL Schema

```sql
Create table If Not Exists Logs (Id int, Num int)
Truncate table Logs
insert into Logs (Id, Num) values ('1', '1')
insert into Logs (Id, Num) values ('2', '1')
insert into Logs (Id, Num) values ('3', '1')
insert into Logs (Id, Num) values ('4', '2')
insert into Logs (Id, Num) values ('5', '1')
insert into Logs (Id, Num) values ('6', '2')
insert into Logs (Id, Num) values ('7', '2')
```

## Question

Table: `Logs`

```
+-------------+---------+
| Column Name | Type    |
+-------------+---------+
| id          | int     |
| num         | varchar |
+-------------+---------+
id is the primary key for this table.

```

Write an SQL query to find all numbers that appear at least three times consecutively.

Return the result table in **any order**.

The query result format is in the following example:

```
Logs table:
+----+-----+
| Id | Num |
+----+-----+
| 1  | 1   |
| 2  | 1   |
| 3  | 1   |
| 4  | 2   |
| 5  | 1   |
| 6  | 2   |
| 7  | 2   |
+----+-----+

Result table:
+-----------------+
| ConsecutiveNums |
+-----------------+
| 1               |
+-----------------+
1 is the only number that appears consecutively for at least three times.
```

## Answer

```sql
/* Write your PL/SQL query statement below */
select distinct(L1.Num) as ConsecutiveNums  from Logs L1, Logs L2, Logs L3 where L2.Id -1 = L1.Id and L2.Num = L1.Num 
and L3.Id -1 = L2.Id and L3.Num = L1.Num;
```

## Result

Runtime: 976 ms, faster than 18.04% of Oracle online submissions for Consecutive Numbers.

Memory Usage: 0B, less than 100.00% of Oracle online submissions for Consecutive Numbers.