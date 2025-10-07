#pragma once
#ifndef BONE_HPP
#define BONE_HPP

class BOne
{
private:
	int _intNumber;

public:
	BOne();
	virtual ~BOne();

	void setInt(int number);
	int getInt();

	virtual void InputInitialise();
	virtual void Show();
};

#endif	// BONE_HPP