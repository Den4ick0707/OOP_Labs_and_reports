#ifndef PRODUCT_HPP
#define PRODUCT_HPP

#include <vector>
#include "Mechanism.hpp"

class Product
{
private:
    std::vector<Mechanism> mechanisms_;

public:
    Product();

    void AddMechanism(const Mechanism& mech);
    void Show() const;
};

#endif // PRODUCT_HPP
