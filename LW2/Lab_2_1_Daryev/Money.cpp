#include "Money.h"
#include <iostream>	


//---------------------- Constructors and Destructor ----------------------
#pragma region


Money::Money(unsigned int denominations, unsigned long counts)
	: _denominations(denominations), _counts(counts)
{
	std::cout << "Money::Money(int denominations, long counts) called" << std::endl;
}

Money::Money(const Money& other)
	: _denominations(other._denominations), _counts(other._counts)
{
	std::cout << "Money::Money(const Money& other) called" << std::endl;
}

Money::Money(Money&& other) noexcept
{
	_denominations = other._denominations;
	_counts = other._counts;
	other._denominations = 0;
	other._counts = 0;
	std::cout << "Money::Money(Money&& other) called" << std::endl;
}

Money::~Money()
{
	_denominations = 0;
	_counts = 0;
	std::cout << "Money::~Money called" << std::endl;
}
#pragma endregion
//--------------------------- Gets / Sets --------------------------------
#pragma region
int Money::getDenominations() const
{
	return _denominations;
}

long Money::getCounts() const
{
	return _counts;
}

bool Money::setDenominations(int denominations)
{
	if (denominations >= 0)
	{
		_denominations = denominations;
		return true;
	}
	else return false;
}

bool Money::setCounts(long counts)
{
	if (counts >= 0)
	{
		_counts = counts;
		return true;
	}
	else return false;
}
#pragma endregion

//------------------------ Overloaded Operators --------------------------
#pragma region
Money Money::operator+(const Money& other) const
{
	std::cout << "operator+ called" << std::endl;
	if (_denominations < 0)
		return Money(0, _counts + other._counts);

	if (_counts < 0)
		return Money(_denominations, 0);

	return Money(_denominations + other._denominations, _counts + other._counts);
}

Money Money::operator-(const Money& other) const
{
	std::cout << "operator- called" << std::endl;
	{
		if (_denominations < 0)
			return Money(0, _counts - other._counts);

		if (_counts < 0)
			return Money(_denominations - other._denominations, 0);

		return Money(_denominations - other._denominations, _counts - other._counts);
	}
}

Money& Money::operator=(const Money& other)
{
	std::cout << "operator= called" << std::endl;
	if (this != &other) { 
		_denominations = other._denominations;
		_counts = other._counts;
	}
	return *this;
}

Money& Money::operator=(Money&& other) noexcept
{
	std::cout << "operator=(move) called" << std::endl;
	if (this != &other) {
		_denominations = std::move(other._denominations);
		_counts = std::move(other._counts);
		other._denominations = 0;
		other._counts = 0;
	}
	return *this;
}

bool Money::operator==(const Money& other) const
{
	std::cout << "operator== called" << std::endl;
	if (_denominations == other._denominations && _counts == other._counts)
		return true;
	else
		return false;
}

bool Money::operator!=(const Money& other) const
{
	std::cout << "operator!= called" << std::endl;
	if (_denominations == other._denominations || _counts == other._counts)
		return false;
	else
		return true;
}

bool Money::operator<(const Money& other) const
{
	std::cout << "operator< called" << std::endl;
	if (_denominations < other._denominations && _counts < other._counts)
		return true;

	else if (_denominations == other._denominations && _counts < other._counts)
		return true;

	else if (_denominations < other._denominations && _counts == other._counts)
		return true;

	else return false;
}

bool Money::operator<=(const Money& other) const
{
	std::cout << "operator<= called" << std::endl;
	if (_denominations <= other._denominations && _counts <= other._counts)
		return true;

	else return false;
}

bool Money::operator>(const Money& other) const
{
	std::cout << "operator> called" << std::endl;
	if (_denominations > other._denominations && _counts > other._counts)
		return true;

	else if (_denominations == other._denominations && _counts > other._counts)
		return true;

	else if (_denominations > other._denominations && _counts == other._counts)
		return true;

	else return false;
}

bool Money::operator>=(const Money& other) const
{
	std::cout << "operator>= called" << std::endl;
	if (_denominations >= other._denominations && _counts >= other._counts)
		return true;

	else return false;
}

Money::operator std::string() const
{
	std::cout << "operator std::string() called" << std::endl;
	std::string a = "_denominations " + std::to_string(_denominations);
	a += "  _counts " + std::to_string(_counts);
	return a;
}

Money& Money::operator++() // Prefix increment
{
	std::cout << "operator++ called" << std::endl;
	++_counts;
	return *this;
}

Money Money::operator++(int) // Postfix increment
{
	std::cout << "operator++(int) called" << std::endl;
	Money temp = *this;
	++_counts;
	return temp;
}

Money& Money::operator--() // Prefix decrement
{
	std::cout << "operator-- called" << std::endl;
	if (_counts > 0)
		--_counts;
	return *this;
}

Money Money::operator--(int) // Postfix decrement
{
	std::cout << "operator--(int) called" << std::endl;
	Money temp = *this;
	if (_counts > 0)
		--_counts;
	return temp;
}

std::ostream& operator<<(std::ostream& os, const Money& money) {
	std::cout << "operator<<(ostream) called" << std::endl;
	return os << "Denomination: " << money._denominations << std::endl << "Counts: " << money._counts << std::endl;
}
std::istream& operator>>(std::istream& is, Money& money) {
	std::cout << "operator>>(istream) called" << std::endl;
	return is >> money._denominations >> money._counts;
}

#pragma endregion



