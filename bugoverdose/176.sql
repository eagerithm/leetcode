-- 168 ms, 0B
SELECT Max(Salary) AS SecondHighestSalary 
FROM Employee 
WHERE Salary < (SELECT Max(Salary) FROM Employee)
;

-- 374 ms, 0B
SELECT                       -- 한번 SELECT로 묶어주면 데이터를 못 찾았을 때 null이 담기게 됨.
  (SELECT DISTINCT Salary    -- 중복된 값은 제거. (ex [100, 100] => [100]으로)
   FROM Employee
   ORDER BY Salary DESC
   LIMIT 1,1                 -- LIMIT 1,1 == LIMIT 1 OFFSET 1 (index=1번째 데이터 1개)
   ) AS SecondHighestSalary
;             

-- IFNULL(not null일 때의 반환값, null일 때의 반환값)
SELECT
    IFNULL(
      (SELECT DISTINCT Salary
       FROM Employee
       ORDER BY Salary DESC
        LIMIT 1, 1),
    NULL) AS SecondHighestSalary

/*
176. Second Highest Salary

Write a SQL query to get the second highest salary from the Employee table.
+----+--------+
| Id | Salary |
+----+--------+
| 1  | 100    |
| 2  | 200    |
| 3  | 300    |
+----+--------+

For example, given the above Employee table, the query should return 200 as the second highest salary. If there is no second highest salary, then the query should return null.
+---------------------+
| SecondHighestSalary |
+---------------------+
| 200                 |
+---------------------+

<SQL Schema>
Create table If Not Exists Employee (Id int, Salary int)
Truncate table Employee
insert into Employee (Id, Salary) values ('1', '100')
insert into Employee (Id, Salary) values ('2', '200')
insert into Employee (Id, Salary) values ('3', '300')
*/