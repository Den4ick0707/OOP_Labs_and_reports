#include "Mechanism.hpp"
#include <iostream>

Mechanism::Mechanism(std::vector<Node> nodes) {
	std::cout << "Mechanism::Mechanism() called\n";
	nodes_ = nodes;
}

void Mechanism::AddNode(Node node) {
	nodes_.push_back(node);
}

const std::vector<Node>& Mechanism::getNodes() const {
	return nodes_;
}

void Mechanism::Show() const {
	std::cout << "Mechanism contains " << nodes_.size() << " nodes." << std::endl;
	for (const auto node : nodes_)
		node.Show();
}
