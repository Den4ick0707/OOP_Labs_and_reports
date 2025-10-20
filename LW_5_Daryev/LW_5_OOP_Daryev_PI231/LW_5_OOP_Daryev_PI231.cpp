#include "Product.hpp"

int main() {
	Detail d1("Screw");
	Detail d2("Bolt");
	Detail d3("Gear");
	std::cout << "----------------------------------------------------------------------" << std::endl;
	Node n1;
	n1.AddDetail(d1);
	n1.AddDetail(d2);

	Node n2;
	n2.AddDetail(d3);
	std::cout << "----------------------------------------------------------------------" << std::endl;
	std::vector<Node> nl{ n1,n2 };
	Mechanism mech1(nl);

	Product product;
	product.AddMechanism(mech1);
	std::cout << "----------------------------------------------------------------------" << std::endl;
	product.Show();
}
