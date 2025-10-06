#include <string>
#include <iostream>
#include <iomanip>
#include "Vehicle.hpp"
#include "Truck.hpp"

// ---------------------- Constructor and Destructor -----------------------------
Truck::Truck(const std::string& marks, unsigned int number, unsigned int speed, unsigned int capacity, bool hasTrailer)
	: Vehicle(marks, number, speed, capacity), _hasTrailer(hasTrailer)
{
	std::cout << "Truck::Truck(string,uint,uint,uint,bool) called" << std::endl;
}

Truck::Truck(const Truck& other)
	: Vehicle(other), _hasTrailer(other._hasTrailer)
{
	std::cout << "Truck::Truck(const Truck&) called" << std::endl;
}

Truck::Truck(Truck&& other) noexcept
	: Vehicle(std::move(other)), _hasTrailer(other._hasTrailer)
{
	std::cout << "Truck::Truck(Truck&&) called" << std::endl;
}

Truck::~Truck()
{
	std::cout << "Truck::~Truck() called" << std::endl;
}
// -------------------------- Getters and Setters -----------------------------
bool Truck::getHasTrailer() const
{
	return _hasTrailer;
}

void Truck::setHasTrailer(bool hasTrailer)
{
	_hasTrailer = hasTrailer;
}

void Truck::setSpeed(unsigned int speed)
{
	if (speed > 0) {
		_speed = speed;
	}
	_speed = 80;
}

void Truck::setCapacity(unsigned int capacity)
{
	if (capacity < 0) { _capacity = 0; }
	else if (getHasTrailer()) { _capacity = capacity * 2; }
	else _capacity = capacity;

}
//	-------------------------- Other Methods -----------------------------
void Truck::ShowInfo() const
{
	std::cout << "Truck Info: " << std::endl;
	Vehicle::ShowInfo();
	std::cout << "Has Trailer: " << (_hasTrailer ? "Yes" : "No") << std::endl;
}

void Truck::ShowInfoInTable() const
{
	std::cout << std::left;
	std::cout << std::setw(15) << _marks
		<< std::setw(15) << _number
		<< std::setw(15) << _speed
		<< std::setw(15) << _capacity
		<< std::setw(15) << (_hasTrailer ? "Trailer" : "none") << std::endl;
	std::cout << std::right;
}
