#include "Framework.hpp"
#include "Product.hpp"

Product::Product(std::string name, Materials material, unsigned int height, unsigned int width,
				 unsigned int weight, unsigned int detailsCount, unsigned int serialNumber, unsigned int productPrice)
	: Mechanism(name, material, height, width, weight, detailsCount, serialNumber), _productPrice(productPrice)
{ }

Product::Product(const Product& other)
	: Mechanism(other), _productPrice(other._productPrice)
{ }

Product::Product(Product&& other) noexcept
	: Mechanism(std::move(other)), _productPrice(other._productPrice)
{ }

Product::~Product()
{ }

unsigned int Product::getProductPrice() const
{
	return _productPrice;
}

void Product::setProductPrice(unsigned int productPrice)
{
	if (productPrice < 0)
		return;
	_productPrice = productPrice;
}

void Product::ShowinTab() const
{
	Detail::ShowinTab();
	std::cout  << std::setw(10) << _productPrice<< "| ";
}
