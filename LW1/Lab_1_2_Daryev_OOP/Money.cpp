#include <iostream>
#include "Money.h"

Money::Money() : _faceValue(0), _count(0), _sum(0) 
{
	std::cout << "Default constructor called" << std::endl;
}
Money::Money(int faceValue, int count) : _faceValue(faceValue), _count(count), _sum(faceValue* count) 
{
	std::cout << "Parametrized constructor called" << std::endl;
}

Money::~Money()
{
	std::cout << "Destructor called" << std::endl;
}

void Money::Show()
{
	std::cout << "Face value: " << _faceValue << ", Count: " << _count << ", Sum: " << _sum << std::endl;
}
bool Money::whetherThereeMoney(int sum)
{
	return _sum >= sum;
}
int Money::howManyBuy(int price)
{
	return (int)(_sum / price);
}