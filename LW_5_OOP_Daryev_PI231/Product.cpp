#include "Product.hpp"
#include <iostream>

Product::Product() {
    std::cout << "Product::Product() called\n";
}

void Product::AddMechanism(const Mechanism& mech) {
    mechanisms_.push_back(mech);
}

void Product::Show() const {
    std::cout << "Product has " << mechanisms_.size() << " mechanisms:\n";
    for (const auto& m : mechanisms_)
        m.Show();
}
