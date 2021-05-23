# #175 Combine Two Tables

Category: DataBase
CreatedDate: May 16, 2021 12:39 PM
Difficulty: Easy
language: oracle
url: https://leetcode.com/problems/combine-two-tables/

## #175. Combine Two Tables

Table: `Person`

```
+-------------+---------+
| Column Name | Type    |
+-------------+---------+
| PersonId    | int     |
| FirstName   | varchar |
| LastName    | varchar |
+-------------+---------+
PersonId is the primary key column for this table.

```

Table: `Address`

```
+-------------+---------+
| Column Name | Type    |
+-------------+---------+
| AddressId   | int     |
| PersonId    | int     |
| City        | varchar |
| State       | varchar |
+-------------+---------+
AddressId is the primary key column for this table.

```

Write a SQL query for a report that provides the following information for each person in the Person table, regardless if there is an address for each of those people:

```
FirstName, LastName, City, State
```

### Answer

```sql
/* Write your PL/SQL query statement below */

select FirstName, LastName, City, State 
from Person P  LEFT OUTER JOIN Address A
on P.PersonId  = A.PersonId ;
```

### Submissions

Runtime: 550 ms, faster than 90.09% of Oracle online submissions for Combine Two Tables.

Memory Usage: 0B, less than 100.00% of Oracle online submissions for Combine Two Tables.