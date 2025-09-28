#include <string>
#include <iostream>
#include <iomanip>
#include "Vehicle.hpp"
#include "Car.hpp"

Car::Car(const std::string& marks, unsigned int number, unsigned int speed, unsigned int capacity)
	: Vehicle(marks, number, speed, capacity)
{
	std::cout << "Car::Car(string,uint,uint,uint) called" << std::endl;
}

Car::Car(const Car& other)
	: Vehicle(other)
{
	std::cout << "Car::Car(const Car&) called" << std::endl;
}

Car::Car(Car&& other)noexcept
	: Vehicle(std::move(other))
{
	std::cout << "Car::Car(Car&&) called" << std::endl;
}

Car::~Car()
{
	std::cout << "Car::~Car() called" << std::endl;
}

void Car::setSpeed(unsigned int speed)
{
	if (speed > 0) {
		_speed = speed;
	}
	_speed = 100;
}

void Car::ShowInfo() const
{
	std::cout << "Car Info: " << std::endl;
	std::cout << "Marks: " << _marks << std::endl;
	std::cout << "Number: " << _number << std::endl;
	std::cout << "Speed: " << _speed << std::endl;
	std::cout << "Capacity: " << _capacity << std::endl;
}

void Car::ShowInfoInTable() const
{
	std::cout << std::left;
	std::cout << std::setw(15) << _marks
		<< std::setw(15) << _number
		<< std::setw(15) << _speed
		<< std::setw(15) << _capacity << std::endl;
	std::cout << std::right;
}
