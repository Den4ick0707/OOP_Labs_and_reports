#ifndef MECHANISM_HPP
#define MECHANISM_HPP

#include <vector>
#include "Node.hpp"

class Mechanism
{
private:
    // Agregation 
    std::vector<Node> nodes_;

public:
    Mechanism(std::vector<Node> nodes);
    void AddNode(Node node);  
    const std::vector<Node>& getNodes() const;

    void Show() const;
};

#endif // MECHANISM_HPP
