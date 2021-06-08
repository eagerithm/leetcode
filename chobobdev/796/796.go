// We are given two strings, s and goal.

// A shift on s consists of taking string s and moving the leftmost character to the rightmost position. For example, if s = 'abcde', then it will be 'bcdea' after one shift on s. Return true if and only if s can become goal after some number of shifts on s.

// Example 1:
// Input: s = 'abcde', goal = 'cdeab'
// Output: true

// Example 2:
// Input: s = 'abcde', goal = 'abced'
// Output: false

func rotateString(s string, goal string) bool {
	return strings.Contains(s+s, goal) && len(s) == len(goal)
}

// Runtime: 0 ms, faster than 100.00% of Go online submissions for Rotate String.
// Memory Usage: 2.1 MB, less than 38.30% of Go online submissions for Rotate String.
