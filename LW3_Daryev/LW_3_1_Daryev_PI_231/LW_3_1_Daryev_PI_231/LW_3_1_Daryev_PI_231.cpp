#include <iostream>
#include <vector>
#include "Vehicle.hpp"
#include "Car.hpp"
#include "Motorcycle.hpp"
#include "Truck.hpp"



int main() {

	std::vector<Vehicle*> base;

	base.push_back(new Car("Toyota", 53895, 180, 500));
	base.push_back(new Motorcycle("Honda", 85837, 160, 100, false));
	base.push_back(new Motorcycle("BMW", 46628, 170, 120, true));
	base.push_back(new Truck("Volvo", 11284, 120, 3000, true));
	base.push_back(new Truck("MAN", 34674, 110, 4000, false));

	std::cout << "========================================  Vehicle database ========================================\n\n";
	for (auto t : base) {
		t->ShowInfoInTable();
	}
	std::cout << "===================================================================================================\n\n";
	double required;
	std::cout << "\nEnter minimal capacity to search: ";
	std::cin >> required;

	std::cout << "\n=== Search result (min. " << required << " kg) ===\n\n";
	bool found = false;
	for (auto t : base) {
		if (t->getCapacity() >= required) {
			t->ShowInfoInTable();
			found = true;
		}
	}
	if (!found) {
		std::cout << "There are no vehicles with this load capacity..\n";
	}

	for (auto t : base) {
		delete t;
	}

	return 0;
}