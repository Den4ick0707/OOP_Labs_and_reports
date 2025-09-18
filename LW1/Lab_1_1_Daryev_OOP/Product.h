#pragma once
#ifndef PRODUCT_H
#define PRODUCT_H

#include <string>
class Product
{
	std::string _name;
	std::string _chiper;
	int _count;
public:
	Product();
	Product(std::string name, std::string chiper, int count);
	void Show();

	~Product();
		
	
};


#endif // !PRODUCT_H