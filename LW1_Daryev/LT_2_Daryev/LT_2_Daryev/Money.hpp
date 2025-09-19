#pragma once
#ifndef MONEY_HPP
#define MONEY_HPP


class Money
{
private:
	unsigned int faceValue_;
	unsigned long count_;

public:
	// ---------------------- Constructors ------------------------- 
	Money();
	Money(unsigned int faceValue, unsigned long count);
	Money(const Money& other);
	Money(Money&& other) noexcept;
	~Money();

	// -------------------- Gets & Sets ----------------------------

	unsigned int getFaceValue()const;
	unsigned long getCount()const;
	unsigned long getSum()const;

	void setFaceValue(unsigned int faceValue);
	void setCount(unsigned long count);

	// -------------------- Methods -------------------------------
	static bool isValid(Money other);										//  <= Validation = |
	static bool isValid(unsigned int faceValue, unsigned long count);		//  <== == == == == |

	void Show()const;

	void beEnough();
	void howManyYouCanBuy();

};

#endif // MONEY_HPP