#include "Framework.hpp"
#include "Detail.hpp"

// ---------------------------- Constructors and Destructors -------------------------------
Detail::Detail(std::string name, Materials material, unsigned int height, unsigned int width, unsigned int weight)
	: _name(name), _material(material), _height(height), _width(width), _weight(weight)
{
}

Detail::Detail(const Detail& other)
	: _name(other._name), _material(other._material), _height(other._height), _width(other._width), _weight(other._weight)
{
}

Detail::Detail(Detail&& other)
	: _name(std::move(other._name)), _material(other._material), _height(other._height), _width(other._width), _weight(other._weight)
{
	other._height = 0;
	other._width = 0;
	other._weight = 0;
}

// ---------------------------- Geters and Seters -------------------------------
std::string Detail::getName() const
{
	return _name;
}

Materials Detail::getMaterial() const
{
	return _material;
}

unsigned int Detail::getHeight() const
{
	return _height;
}

unsigned int Detail::getWidth() const
{
	return _width;
}

unsigned int Detail::getWeight() const
{
	return _weight;
}

void Detail::setName(const std::string& name)
{
	if (name.empty() || name == " ")
		return;
	_name = name;
}

void Detail::setMaterial(Materials material)
{
	if (material<Materials::WOOD || material>Materials::CARBON)
		return;
	_material = material;
}

void Detail::setHeight(unsigned int height)
{
	if (height < 0)
		return;
	_height = height;
}

void Detail::setWidth(unsigned int width)
{
	if (width < 0)
		return;
	_width = width;
}

void Detail::setWeight(unsigned int weight)
{
	if (weight < 0)
		return;
	_weight = weight;
}

void Detail::ShowinTab() const
{
	std::cout << std::endl;
	std::cout << std::left;
	std::cout << std::setw(15) << _name << "| ";
	std::cout << std::right;
	std::cout << std::setw(10) << _material << "| ";
	std::cout << std::setw(10) << _height << "| ";
	std::cout << std::setw(10) << _width << "| ";
	std::cout << std::setw(10) << _weight << "| ";
}
