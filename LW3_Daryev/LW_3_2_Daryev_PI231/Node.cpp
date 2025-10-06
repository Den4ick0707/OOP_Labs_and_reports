#include "Framework.hpp"
#include "Node.hpp"


// ---------------------------- Constructors and Destructors -------------------------------
Node::Node(std::string name, Materials material, unsigned int height, unsigned int width, unsigned int weight, unsigned int detailsCount)
	: Detail(name, material, height, width, weight), _detailsCount(detailsCount)
{
}

Node::Node(const Node& other)
	: Detail(other), _detailsCount(other._detailsCount)
{
}

Node::Node(Node&& other) noexcept
	: Detail(std::move(other)), _detailsCount(other._detailsCount)
{
	other._detailsCount = 0;
}

Node::~Node()
{
}

// ---------------------------- Geters and Seters -------------------------------
unsigned int Node::getDetailsCount() const
{
	return _detailsCount;
}

void Node::setDetailsCount(unsigned int detailsCount)
{
	if (detailsCount < 0)
		return;
	_detailsCount = detailsCount;
}

void Node::ShowinTab() const
{
	Detail::ShowinTab();
	std::cout << std::setw(10) << _weight << "| ";
}

