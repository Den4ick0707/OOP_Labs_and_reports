#pragma once
#ifndef BTHREE_HPP
#define BTHREE_HPP

class BThree
{
private:
	int _charSymbol;

public:
	BThree();
	virtual ~BThree();
	void setChar(int number);
	int getChar();

	virtual void InputInitialise();
	virtual void Show();
};

#endif // BTHREE_HPP