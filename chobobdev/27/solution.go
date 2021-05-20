func removeElement(nums []int, val int) int {
	var temp []int
	for _, num := range nums {
		if num != val {
			temp = append(temp, num)
		}
	}
	//It doesn't matter what you leave beyond the returned length. For example if you return 2 with nums = [2,2,3,3] or nums = [2,2,0,0], your answer will be accepted.
	//위 전재조건을 만족시키기 위해 temp를 copy 해서 앞 원소들을 바꾸어 준다
	copy(nums, temp)

	return len(temp)

}