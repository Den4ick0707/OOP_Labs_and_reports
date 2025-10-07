#include <iostream>
#include "DTwo.hpp"

DTwo::DTwo()
	:DOne()
{
	std::cout << "DTwo::DTwo() called" << std::endl;
}
DTwo::~DTwo() {
	std::cout << "DTwo::~DTwo() called" << std::endl;
}
bool DTwo::getBool()
{
	return _bool;
}

void DTwo::setBool(bool other)
{
	_bool = other;
}
void DTwo::InputInitialise()
{
	DOne::InputInitialise();
	std::cout << "Enter DTwo (bool(0,1 or True,False)) - ";
	std::cin >> _bool;
}
void DTwo::Show() {
	DOne::Show();
	std::cout << "DTwo:  " << (getBool() ? "True" : "False") << std::endl;
}