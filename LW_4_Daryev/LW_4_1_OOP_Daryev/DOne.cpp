#include <iostream>

#include "DOne.hpp"

DOne::DOne()
	:BOne(), BTwo(), BThree()
{
	std::cout << "DOne::DOne() called" << std::endl;
}

DOne::~DOne()
{
	std::cout << "DOne::~DOne() called" << std::endl;
}

std::string DOne::getString()
{
	return std::string();
}

void DOne::setString(std::string other)
{
	_string = other;
}

void DOne::InputInitialise()
{
	BOne::InputInitialise();
	BTwo::InputInitialise();
	BThree::InputInitialise();
	std::cout << "Enter DOne (string) - ";
	std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
	std::getline(std::cin, _string);
}
void DOne::Show() {
	BOne::Show();
	BTwo::Show();
	BThree::Show();
	std::cout << "DOne:  " << _string << std::endl;
}