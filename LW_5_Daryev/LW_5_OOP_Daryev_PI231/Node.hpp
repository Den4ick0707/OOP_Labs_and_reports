#ifndef NODE_HPP
#define NODE_HPP

#include <vector>
#include "Detail.hpp"

class Node
{
private:
    // Composition 
    std::vector<Detail>* details_;

public:
    Node();
    void AddDetail(const Detail& newEl);
    void RemoveDetails();
    const std::vector<Detail> getDetails() const;

    void Show() const;
};

#endif // NODE_HPP
