#ifndef MONEY_H
#define MONEY_H


class Money
{
	int _faceValue;
	int _count;
	int _sum;
public:
	Money();
	Money(int faceValue, int count);
	~Money();

	void Show();
	bool whetherThereeMoney(int sum);
	int howManyBuy(int price);

	int getSum() { return _sum; }
	int getFaceValue() { return _faceValue; }
	int getCount() { return _count; }

	void setCount(int count) {
		_count = count;
		_sum = _faceValue * _count;
	}
	void setFaceValue(int faceValue) {
		_faceValue = faceValue;
		_sum = _faceValue * _count;
	};
};
#endif // !MONEY_H