#pragma once

#include <iostream>
#include <string.h>


namespace Time {

	// Time point
	class TimePoint {
	private:
		double ticks = 0;	// Time is ticks

	public:
		// Initializition
		TimePoint() {
			Reset();
		}

		// Get Ticks
		double Ticks() {
			return ticks;
		}

		// Reset
		void Reset() {
			ticks = clock();
		}


		// DeltaTime(bool reset - return and reset ticks)
		double DeltaTime(bool reset = false) {

			// Save delta
			double delta = clock() - ticks;

			// Reset
			if (reset) {
				Reset();
			}

			// Return
			return delta;
		}

		// Timer(float currentTime - time for timer, bool reset - return and reset ticks)
		bool Timer(float currentTime, bool reset = false) {

			// Save delta
			float delta = DeltaTime();

			// Reset
			if (reset && delta > currentTime) {
				Reset();
			}

			// Return 
			return delta > currentTime;
		}
	};





	// Wait (time - waiting time)
	int Wait(int time) {
		TimePoint timePoint = TimePoint();

		while (true)
		{
			if (timePoint.Timer(time)) {
				return 1;
			}
		}
	}





	// Get ticks
	int GetProgramTicks() {
		return clock();
	}
};