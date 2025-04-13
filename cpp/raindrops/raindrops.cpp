#include "raindrops.h"
#include <string>

namespace raindrops {
    std::string convert (int num) {
        std::string sound{};

        if (num % 3 == 0) {
            sound.append("Pling");
        }
        if (num % 5 == 0) {
            sound.append("Plang");
        }
        if (num % 7 == 0) {
            sound.append("Plong");
        }

        return sound.empty() ? std::to_string(num) : sound;
    }
}  // namespace raindrops
