#include <iostream>
#include "BTwo.hpp"

BTwo::BTwo() {
	std::cout << "BTwo::BTwo() called" << std::endl;
}
BTwo::~BTwo()
{
	std::cout << "BTwo::~BTwo() called" << std::endl;
}
void BTwo::setDouble(int number)
{
	_doubleNumber = number;
}

int BTwo::getDouble()
{
	return _doubleNumber;
}
void BTwo::InputInitialise() {
	std::cout << "Enter BTwo (double) - ";
	std::cin >> _doubleNumber;
}
void BTwo::Show() {
	std::cout << "BTwo:  " << getDouble() << std::endl;
}