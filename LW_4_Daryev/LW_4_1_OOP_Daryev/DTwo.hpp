#pragma once
#ifndef DTWO_HPP
#define DTWO_HPP

#include "DOne.hpp"

class DTwo : public DOne
{
	bool _bool;
public:
	DTwo();
	~DTwo()override;
	bool getBool();
	void setBool(bool other);

	void InputInitialise()override;
	void Show()override;

};

#endif //DTWO_HPP