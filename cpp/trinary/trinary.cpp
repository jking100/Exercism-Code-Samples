#include "trinary.h"
#include <string>
#include <iostream>

namespace trinary {

	// TODO: add your solution here

	int to_decimal(std::string input)
	{
		int number{};
		try
		{
			number = std::stoi(input, nullptr, 3);
		}
		catch (const std::exception&)
		{
			return 0;
		}
		return number;
	}

}  // namespace trinaryq
