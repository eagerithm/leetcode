# #178 Rank Scores

Category: DataBase
CreatedDate: May 16, 2021 11:23 PM
Difficulty: Medium
language: oracle
url: https://leetcode.com/problems/rank-scores/

# 178. Rank Scores

## SQL Schema

```sql
Create table If Not Exists Scores (Id int, Score DECIMAL(3,2))
Truncate table Scores
insert into Scores (Id, Score) values ('1', '3.5')
insert into Scores (Id, Score) values ('2', '3.65')
insert into Scores (Id, Score) values ('3', '4.0')
insert into Scores (Id, Score) values ('4', '3.85')
insert into Scores (Id, Score) values ('5', '4.0')
insert into Scores (Id, Score) values ('6', '3.65')
```

## Question

Write a SQL query to rank scores. If there is a tie between two scores, both should have the same ranking. Note that after a tie, the next ranking number should be the next consecutive integer value. In other words, there should be no "holes" between ranks.

```
+----+-------+
| Id | Score |
+----+-------+
| 1  | 3.50  |
| 2  | 3.65  |
| 3  | 4.00  |
| 4  | 3.85  |
| 5  | 4.00  |
| 6  | 3.65  |
+----+-------+

```

For example, given the above `Scores` table, your query should generate the following report (order by highest score):

```
+-------+---------+
| score | Rank    |
+-------+---------+
| 4.00  | 1       |
| 4.00  | 1       |
| 3.85  | 2       |
| 3.65  | 3       |
| 3.65  | 3       |
| 3.50  | 4       |
+-------+---------+

```

**Important Note:** For MySQL solutions, to escape reserved words used as column names, you can use an apostrophe before and after the keyword. For example **`Rank`**.

## Answer

```sql
/* Write your PL/SQL query statement below */
select score, DENSE_RANK() over(order by score desc) Rank from  Scores order by score desc;
```

## Submissions

Runtime: 681 ms, faster than 14.69% of Oracle online submissions for Rank Scores.

Memory Usage: 0B, less than 100.00% of Oracle online submissions for Rank Scores.