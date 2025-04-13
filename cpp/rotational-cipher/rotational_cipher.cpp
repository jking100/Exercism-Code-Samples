#include "rotational_cipher.h"

#include <string>
#include <iostream>

namespace rotational_cipher {

	std::string alphabet = "abcdefghijklmnopqrstuvwxyz";

	char rotatedChar(char input, int rotateBy) {
		const int normalRotateBy{ rotateBy % 26 };
		const size_t inputIndex{ alphabet.find_first_of(std::tolower(input)) };
		const size_t newCharIndex{ (inputIndex + normalRotateBy) % 26 };

		return std::islower(input) ? alphabet[newCharIndex] : std::toupper(alphabet[newCharIndex]);

	}

	// TODO: add your solution here
	std::string rotate(std::string input, int rotateBy) {
		std::string mutatedMessage{};

		for (char var : input)
		{
			if (std::isalpha(var))
			{
				mutatedMessage.push_back(rotatedChar(var, rotateBy));
			}
			else {
				mutatedMessage.push_back(var);
			}
		}


		return mutatedMessage;
	}

}  // namespace rotational_cipher
