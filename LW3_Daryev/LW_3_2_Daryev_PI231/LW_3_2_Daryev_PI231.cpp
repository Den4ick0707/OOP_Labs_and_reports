#include <iostream>
#include <vector>
#include "Framework.hpp"

int main()
{
	std::vector<Detail*> details;
	details.push_back(new Detail("Detail1", WOOD, 10, 20, 30));
	details.push_back(new Node("Node1", PLASTIC, 15, 25, 35, 5));
	details.push_back(new Mechanism("Mechanism1", STEEL, 20, 30, 40, 10, 12345));
	details.push_back(new Product("Product1", TITAN, 25, 35, 45, 15, 60, 1000));
	details.push_back(new Product("Product2", CARBON, 30, 40, 50, 20, 13, 2000));

	for (auto* d : details)
		d->ShowinTab();

}

