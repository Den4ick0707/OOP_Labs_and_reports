#pragma once

#ifndef BTWO_HPP
#define BTWO_HPP

class BTwo
{
private:
	double _doubleNumber;

public:
	BTwo();
	virtual ~BTwo();
	void setDouble(int number);
	int getDouble();

	virtual void InputInitialise();
	virtual void Show();

};

#endif // BTWO_HPP