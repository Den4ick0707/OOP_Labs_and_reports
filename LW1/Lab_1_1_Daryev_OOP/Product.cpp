#include "Product.h"
#include <iostream>

Product::Product() : _name("NoName"), _chiper("NoChiper"), _count(0)
{
	std::cout << "Default constructor worked!" << std::endl;
}

Product::Product(std::string name, std::string chiper, int count) : _name(name), _chiper(chiper), _count(count)
{
	std::cout << "Parametrized constructor worked!" << std::endl;
}
Product::~Product()
{
	std::cout << "Destructor worked!" << std::endl;
}
void Product::Show(){
	std::cout << "Name: " << _name << std::endl;
	std::cout << "Chiper: " << _chiper << std::endl;
	std::cout << "Count: " << _count << std::endl;
}