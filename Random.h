#pragma once


namespace Random {
	
	// Random (return value (min-max))
	int Random(int min, int max) {
		return rand() % (max - min) + min;
	}
}