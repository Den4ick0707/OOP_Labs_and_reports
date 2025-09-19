#pragma once

#include <string>


class Product
{
private:
	std::string name_; // Product name
	std::string chiper_; // Product chiper
	unsigned int count_; // Product count

public:
	// ------------------ Constructor & Destructor ------------------
	Product(); // Non parametrs
	Product(std::string name,std::string chiper, unsigned int count); // All parametrs
	Product(const Product& other); // Copy 
	Product(Product&& other)noexcept; // Move
	~Product(); // Destructors

	// ------------------- Gets & Sets ---------------------------
	std::string getName() const;
	std::string getChiper() const;
	unsigned int getCount() const;

	void setName(const std::string name);
	void setChiper(const std::string chiper);
	void setCount(unsigned const int count);

	// ------------------------ Methods ---------------------------

	void Show(); // Show info from object
	void ShowTab(); // Show info from object in table
	static void ShowCap(); // Show cap in table
	



};

