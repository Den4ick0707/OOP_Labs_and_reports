#include "Money.hpp"
#include <iostream>

Money::Money()
	:faceValue_(0), count_(0)
{
	std::cout << "Default constructor called!" << std::endl;
}

Money::Money(unsigned int faceValue, unsigned long count)
{
	std::cout << "Parametr constructor called!" << std::endl;
	if (Money::isValid(faceValue, count)) {
		faceValue_ = faceValue;
		count_ = count;
	}
	else {
		return;
	}
}

Money::Money(const Money& other)
{
	std::cout << "Copy constructor called!" << std::endl;
	if (Money::isValid(other)) {
		faceValue_ = other.faceValue_;
		count_ = other.count_;
	}
	else {
		return;
	}
}

Money::Money(Money&& other) noexcept
{
	std::cout << "Move constructor called!" << std::endl;
	if (Money::isValid(other)) {
		faceValue_ = other.faceValue_;
		count_ = other.count_;
		other.faceValue_ = 0;
		other.count_ = 0;
	}
	else {
		return;
	}
}

Money::~Money()
{
	std::cout << "Destructor called!" << std::endl;
}

unsigned int Money::getFaceValue() const
{
	return faceValue_;
}

unsigned long Money::getCount() const
{
	return count_;
}

unsigned long Money::getSum() const
{
	return faceValue_ * count_;
}

void Money::setFaceValue(unsigned int faceValue)
{
	if (Money::isValid(faceValue, 0)) {
		faceValue_ = faceValue;
	}
}

void Money::setCount(unsigned long count)
{
	if (Money::isValid(1, count)) {
		count_ = count;
	}
}

 bool Money::isValid(Money other) 
{
	if (Money::isValid(other.faceValue_, other.count_)) {
		return true;
	}
	return false;
}

 bool Money::isValid(unsigned int faceValue, unsigned long count) 
{
	int array[] = { 1,2,5,10,20,50,100,200,500,1000 };
	if (count < 0)
		return false;

	for (int i = 0; i < 10; i++)
		if (faceValue == array[i])
			return true;

	return false;
}

void Money::Show() const
{
	std::cout << "Face value: " << faceValue_ << std::endl;;
	std::cout << "Coutnt: " << count_ << std::endl;
}

void Money::beEnough()
{
	unsigned int num;
	for (int i = 0;; i++) {
		std::cout << "Enter a item`s price - ";
		std::cin >> num;

		if (num > 0)
			break;

		std::cout << "Invalid price!" << std::endl;
	}

	if (getSum() >= num) {
		std::cout << "That's enough!" << std::endl;
	}
	else {
		std::cout << "Not enough!" << std::endl;
	}
}

void Money::howManyYouCanBuy()
{
	unsigned int num;
	for (int i = 0;; i++) {
		std::cout << "Enter a item price - ";
		std::cin >> num;

		if (num > 0)
			break;

		std::cout << "Invalid price!" << std::endl;
	}

	if (num > getSum()) {
		std::cout << "You can`t buy this item!" << std::endl;
	}
	else {
		std::cout << "You can buy " << (int)(getSum() / num) << std::endl;
	}
}
