#include <iostream>
#include "BOne.hpp"

BOne::BOne()
{
	std::cout << "BOne::Bone() called" << std::endl;
}

BOne::~BOne()
{
	std::cout << "BOne::~BOne() called" << std::endl;
}

void BOne::setInt(int number)
{
	_intNumber = number;
}

int BOne::getInt()
{
	return _intNumber;
}

void BOne::InputInitialise()
{
	std::cout << "Enter BOne (int) - ";
	std::cin >> _intNumber;
}

void BOne::Show()
{
	std::cout << "BOne:  " << getInt() << std::endl;
}
