#include "Product.hpp"
#include <iostream>
#include <iomanip>



//------------------------------------------------------------------------------
Product::Product()
	:name_("NoName"), chiper_("000000"), count_(0)
{
	std::cout << "Non parametrs constructor called!" << std::endl;
}

Product::Product(std::string name, std::string chiper, unsigned int count)
{
	std::cout << "Parametr constructor called!" << std::endl;
	count_ = count;
	if (name.empty() || name.size() == 0)
		name_ = "NoName";
	else name_ = name;
	if (chiper.empty() || chiper.size() == 0)
		chiper_ = "NonCode";
	else chiper_ = chiper;
}

Product::Product(const Product& other)
	:name_(other.name_), chiper_(other.chiper_), count_(other.count_)
{
	std::cout << "Copy constructor called!" << std::endl;
}

Product::Product(Product&& other) noexcept
	:name_(other.name_), chiper_(other.chiper_), count_(other.count_)
{
	other.name_ = "";
	other.chiper_ = "";
	other.count_ = 0;
	std::cout << "Move constructor called!" << std::endl;
}

Product::~Product()
{
	std::cout << "Destructor called!" << std::endl;
}

//------------------------------------------------------------------------------
std::string Product::getName() const
{
	return name_;
}

std::string Product::getChiper() const
{
	return chiper_;
}

unsigned int Product::getCount() const
{
	return count_;
}

void Product::setName(const std::string name)
{
	if (name.empty() || name.size() == 0) name_ = "NoName";
	else name_ = name;
}

void Product::setChiper(const std::string chiper)
{
	if (chiper.empty() || chiper.size() == 0) chiper_ = "NonCode";
	else chiper_ = chiper;
}

void Product::setCount(unsigned const int count)
{
	if (count >= 0) count_ = count;
	else count_ = 0;
}
//---------------------------------------------------------------------
void Product::Show()
{
	std::cout << "Name: " << name_ << std::endl;
	std::cout << "Chiper: " << chiper_ << std::endl;
	std::cout << "Count: " << count_ << std::endl;
}

void Product::ShowTab()
{
	std::cout << std::setw(-16) << name_ << std::setw(16) << chiper_ << std::setw(16) << count_ << std::endl;
}

void Product::ShowCap()
{
	std::cout << std::setw(-16) << "Name" << std::setw(16) << "Chiper" << std::setw(16) << "Count" << std::endl;
}


