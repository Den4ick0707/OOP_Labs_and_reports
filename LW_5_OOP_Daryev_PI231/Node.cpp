#include "Node.hpp"
#include <iostream>

Node::Node() {
    std::cout << "Node::Node() called\n";
    details_ = new std::vector<Detail>();
}

void Node::AddDetail(const Detail& newEl) {
    details_->push_back(newEl);
}

void Node::RemoveDetails() {
    details_->clear();
}

const std::vector<Detail> Node::getDetails() const {
    return (*details_);
}

void Node::Show() const {
    std::cout << "Node has " << details_->size() << " details:" << std::endl;;
    std::cout << "Details: "<<std::endl;

    for (const auto& e : (*details_))
        e.Show();
}
