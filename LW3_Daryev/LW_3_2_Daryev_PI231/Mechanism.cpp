#include "Framework.hpp"
#include "Mechanism.hpp"

Mechanism::Mechanism(std::string name, Materials material, unsigned int height, unsigned int width, unsigned int weight, unsigned int detailsCount, unsigned int serialNumber)
	: Node(name, material, height, width, weight, detailsCount), _serialNumber(serialNumber)
{
}

Mechanism::Mechanism(const Mechanism& other)
	: Node(other), _serialNumber(other._serialNumber)
{
}

Mechanism::Mechanism(Mechanism&& other) noexcept
	: Node(std::move(other)), _serialNumber(other._serialNumber)
{
	other._serialNumber = 0;
}

Mechanism::~Mechanism()
{
}

unsigned int Mechanism::getSerialNumber() const
{
	return _serialNumber;
}

void Mechanism::setSerialNumber(unsigned int serialNumber)
{
	if (serialNumber < 0)
		return;
	_serialNumber = serialNumber;
}

void Mechanism::ShowinTab() const
{
	Detail::ShowinTab();
	std::cout  << std::setw(10) << _serialNumber<< "| ";
}
