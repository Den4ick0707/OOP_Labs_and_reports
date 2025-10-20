#ifndef DETAIL_HPP
#define DETAIL_HPP

#include <string>
#include <iostream>

class Detail
{
private:
    std::string _d_name;

public:
    Detail();
    Detail(const std::string& name);

    std::string getName() const;
    void setName(const std::string& newName);

    void Show() const;
};

#endif // DETAIL_HPP
