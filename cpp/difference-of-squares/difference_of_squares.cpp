#include "difference_of_squares.h"

namespace difference_of_squares {

	int square_of_sum(int input) {
		int sum{};
		for (int i = input; i > 0; i--) {
			sum += i;
		}
		return sum * sum;
	}

	int sum_of_squares(int input) {
		int sum{};
		for (int i = input; i > 0; i--) {
			sum += i * i;
		}
		return sum;
	}

	int difference(int input) {
		return square_of_sum(input) - sum_of_squares(input);
	}

}  // namespace difference_of_squares
