func lengthOfLastWord(s string) int {
	str := strings.TrimSpace(s)
	substring := strings.Split(str, " ")

	return len(substring[len(substring)-1])

}