-- Runtime: 346 ms, faster than 39.87% of MySQL online submissions for Nth Highest Salary.
-- Memory Usage: 0B, less than 100.00% of MySQL online submissions for Nth Highest Salary.
CREATE FUNCTION getNthHighestSalary(N INT) RETURNS INT
BEGIN
  RETURN (
      # Write your MySQL query statement below.
      SELECT A.Salary                      
      FROM (SELECT DISTINCT Salary, DENSE_RANK() OVER (ORDER BY Salary DESC) AS SalaryRank   
            FROM Employee
            ) A
      WHERE A.SalaryRank = N
  );
END

/*
177. Nth Highest Salary

Write a SQL query to get the nth highest salary from the Employee table.
+----+--------+
| Id | Salary |
+----+--------+
| 1  | 100    |
| 2  | 200    |
| 3  | 300    |
+----+--------+

For example, given the above Employee table, the nth highest salary where n = 2 is 200. If there is no nth highest salary, then the query should return null.
+------------------------+
| getNthHighestSalary(2) |
+------------------------+
| 200                    |
+------------------------+
*/