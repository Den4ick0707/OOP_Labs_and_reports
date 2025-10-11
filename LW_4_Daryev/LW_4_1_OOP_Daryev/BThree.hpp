#pragma once
#ifndef BTHREE_HPP
#define BTHREE_HPP

class BThree
{
private:
	char _charSymbol;

public:
	BThree();
	virtual ~BThree();
	void setChar(char symbol);
	char getChar();

	virtual void InputInitialise();
	virtual void Show();
};

#endif // BTHREE_HPP