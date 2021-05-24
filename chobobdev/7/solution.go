func rev(i int) int {
	reversed := 0
	for i > 0 {
		reversed *= 10
		n := i % 10
		reversed += n
		i = i / 10
	}
	return reversed
}

func reverse(x int) int {
	if x < 0 {
		x = rev(x*-1) * -1
	} else {
		x = rev(x)
	}
	if x > 2147483647 || x < -2147483648 {
		return 0
	} else {
		return x
	}

}