func isPalindrome(x int) bool {
	i := x
	if i >= 0 {
		reversed := 0
		for i > 0 {
			reversed *= 10
			n := i % 10
			reversed += n
			i = i / 10
		}
		if reversed == x {
			return true
		} else {
			return false
		}

	} else {
		return false
	}

}