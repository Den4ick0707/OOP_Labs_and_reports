#include <string>
#include <iostream>
#include "Vehicle.hpp"

// ---------------------- Constructor and Destructor -----------------------------
Vehicle::Vehicle(const std::string& marks, unsigned int number, unsigned int speed, unsigned int capacity)
{
	setMarks(marks);
	setNumber(number);
	setSpeed(speed);
	setCapacity(capacity);

	std::cout << "Vehicle::Vehicle(string,uint,uint,uint) called" << std::endl;
}

Vehicle::Vehicle(const Vehicle& other)
{
	setMarks(other._marks);
	setNumber(other._number);
	setSpeed(other._speed);
	setCapacity(other._capacity);
	std::cout << "Vehicle::Vehicle(const Vehicle&) called" << std::endl;
}

Vehicle::Vehicle(Vehicle&& other)noexcept
{
	setMarks(other._marks);
	setNumber(other._number);
	setSpeed(other._speed);
	setCapacity(other._capacity);
	other._marks = "NoName";
	other._number = 0;
	other._speed = 0;
	other._capacity = 0;
	std::cout << "Vehicle::Vehicle(Vehicle&&) called" << std::endl;
}

Vehicle::~Vehicle()
{
	std::cout << "Vehicle::~Vehicle() called" << std::endl;
}

// -------------------------- Getters and Setters -----------------------------
std::string Vehicle::getMarks() const
{
	return _marks;
}

unsigned int Vehicle::getNumber() const
{
	return _number;
}

unsigned int Vehicle::getSpeed() const
{
	return _speed;
}

unsigned int Vehicle::getCapacity() const
{
	return _capacity;
}

void Vehicle::setMarks(const std::string& marks)
{

	if (marks != " " && !marks.empty()) {
		_marks = marks;
	}
	else _marks = "NoName";
}

void Vehicle::setNumber(unsigned int number)
{
	if (number > 0) {
		_number = number;
	}
	else _number = 0;
}

void Vehicle::setSpeed(unsigned int speed)
{
	if (speed > 0) {
		_speed = speed;
	}
	else _speed = 0;
}

void Vehicle::setCapacity(unsigned int capacity)
{
	if (capacity > 0) {
		_capacity = capacity;
	}
	else _capacity = 0;
}
