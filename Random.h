#pragma once

#include <iostream>
using namespace std;

namespace Random {
	
	// Random (return value (min-max))
	int Random(int min, int max) {
		return rand() % (max - min) + min;
	}

	// Choice random value from list
	int Choice(int values[], int len) {
		return values[Random(0, len)];
	}
	float Choice(float values[], int len) {
		return values[Random(0, len)];
	}
	double Choice(double values[], int len) {
		return values[Random(0, len)];
	}
	char Choice(char values[], int len) {
		return values[Random(0, len)];
	}
	string Choice(string values[], int len) {
		return values[Random(0, len)];
	}


	// Return true, if you get a change
	bool Chance(double chance) {

		if (chance < 0)
			return false;
		if (chance > 100)
			return true;

		return (Random(0, 10000000) + 1) / 100000.0 < chance;
	}
}
