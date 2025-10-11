#include "Detail.hpp"

Detail::Detail() : _d_name("Unnamed detail")
{
    std::cout << "Detail::Detail() called\n";
}

Detail::Detail(const std::string& name) : _d_name(name)
{
    std::cout << "Detail::Detail(name) called\n";
}

std::string Detail::getName() const { return _d_name; }

void Detail::setName(const std::string& newName) { _d_name = newName; }

void Detail::Show() const
{
    std::cout << "Detail: " << _d_name << std::endl;;
}
