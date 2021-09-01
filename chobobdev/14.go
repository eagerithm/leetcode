// 14. Longest Common Prefix
// Write a function to find the longest common prefix string amongst an array of strings.

// If there is no common prefix, return an empty string "".

// Example 1:

// Input: strs = ["flower","flow","flight"]
// Output: "fl"
// Example 2:

// Input: strs = ["dog","racecar","car"]
// Output: ""
// Explanation: There is no common prefix among the input strings.

// Constraints:

// 1 <= strs.length <= 200
// 0 <= strs[i].length <= 200
// strs[i] consists of only lower-case English letters.

func longestCommonPrefix(strs []string) string {
	if len(strs) == 0 {
		return ""
	}
	if len(strs) == 1 {
		return strs[0]
	}
	var CommonPrefix string = ""
	for i := 0; ; i++ {
		for j := 0; j <= len(strs)-2; j++ {
			if len(strs[j]) < i || len(strs[j+1]) < i || strs[j][:i] != strs[j+1][:i] {
				return CommonPrefix
			}
		}
		CommonPrefix = strs[0][:i]
	}
	return CommonPrefix

}

// Runtime: 4 ms, faster than 16.53% of Go online submissions for Longest Common Prefix.
// Memory Usage: 2.7 MB, less than 11.79% of Go online submissions for Longest Common Prefix.
