#include <iostream>
#include "BThree.hpp"

BThree::BThree() {
	std::cout << "BThree::BThree() called" << std::endl;
}
BThree::~BThree()
{
	std::cout << "BThree::~BThree() called" << std::endl;
}
void BThree::setChar(char symbol)
{
	_charSymbol = symbol;
}

char BThree::getChar()
{
	return _charSymbol;
}
void BThree::InputInitialise() {
	std::cout << "Enter BThree (char) - ";
	std::cin.ignore();
	_charSymbol = std::cin.get();
}
void BThree::Show() {
	std::cout << "BThree:  " << getChar() << std::endl;
}
