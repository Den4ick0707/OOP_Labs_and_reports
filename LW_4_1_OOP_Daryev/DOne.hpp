#pragma once
#ifndef DONE_HPP
#define DONE_HPP

#include <string>

#include "BOne.hpp"
#include "BTwo.hpp"
#include "BThree.hpp"

class DOne : public BOne, public BTwo, private BThree
{
	std::string _string;

public:
	DOne();
	~DOne()override;
	std::string getString();
	void setString(std::string other);

	void InputInitialise() override;
	void Show()override;



};
#endif // DONE_HPP
