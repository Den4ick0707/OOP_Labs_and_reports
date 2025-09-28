#include <string>
#include <iostream>
#include <iomanip>
#include "Vehicle.hpp"
#include "Motorcycle.hpp"

// ---------------------- Constructor and Destructor -----------------------------
Motorcycle::Motorcycle(const std::string& marks, unsigned int number, unsigned int speed, unsigned int capacity, bool hasSidecar)
	: Vehicle(marks, number, speed, capacity), _hasSidecar(hasSidecar)
{
	std::cout << "Motorcycle::Motorcycle(string,uint,uint,uint,bool) called" << std::endl;
}

Motorcycle::Motorcycle(const Motorcycle& other)
	: Vehicle(other), _hasSidecar(other._hasSidecar)
{
	std::cout << "Motorcycle::Motorcycle(const Motorcycle&) called" << std::endl;
}

Motorcycle::Motorcycle(Motorcycle&& other) noexcept
	: Vehicle(std::move(other)), _hasSidecar(other._hasSidecar)
{
	std::cout << "Motorcycle::Motorcycle(Motorcycle&&) called" << std::endl;
}

Motorcycle::~Motorcycle()
{
	std::cout << "Motorcycle::~Motorcycle() called" << std::endl;
}
// -------------------------- Getters and Setters -----------------------------
bool Motorcycle::getHasSidecar() const
{
	return _hasSidecar;
}

void Motorcycle::setHasSidecar(bool hasSidecar)
{
	_hasSidecar = hasSidecar;
}

void Motorcycle::setSpeed(unsigned int speed)
{
	if (speed > 0) {
		_speed = speed;
	}
	_speed = 150;
}

void Motorcycle::setCapacity(unsigned int capacity)
{
	if (capacity < 0 && getHasSidecar()) {
		_capacity = 0;
	}
	else {
		_capacity = capacity;
	}
}
// -------------------------- Other Methods -----------------------------
void Motorcycle::ShowInfo() const
{
	std::cout << "Motorcycle Info: " << std::endl;
	std::cout << "Marks: " << _marks << std::endl;
	std::cout << "Number: " << _number << std::endl;
	std::cout << "Speed: " << _speed << std::endl;
	std::cout << "Capacity: " << _capacity << std::endl;
	std::cout << "Has Sidecar: " << (_hasSidecar ? "Yes" : "No") << std::endl;
}

void Motorcycle::ShowInfoInTable() const
{
	std::cout << std::left;
	std::cout << std::setw(15) << _marks
		<< std::setw(15) << _number
		<< std::setw(15) << _speed
		<< std::setw(15) << _capacity
		<< std::setw(15) << (_hasSidecar ? "Sidecar" : "NoSidecar") << std::endl;
	std::cout << std::right;
}
