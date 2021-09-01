// Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.

// Assume the environment does not allow you to store 64-bit integers (signed or unsigned).

// Example 1:

// Input: x = 123
// Output: 321
// Example 2:

// Input: x = -123
// Output: -321
// Example 3:

// Input: x = 120
// Output: 21
// Example 4:

// Input: x = 0
// Output: 0

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