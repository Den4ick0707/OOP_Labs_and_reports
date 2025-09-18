#include "Money.h"
#include <iostream>

void wheterYouHaveEnoughMoneyToBuy(Money wallet)
{
	int sum;
	std::cout << "Enter sum to check: ";
	std::cin >> sum;

	if (wallet.whetherThereeMoney(sum)) {
		std::cout << "There is enough money in the wallet." << std::endl;
	}
	else {
		std::cout << "There is not enough money in the wallet." << std::endl;
	}
}

void howMuchYouCanBuy(Money wallet)
{
	int price;
	std::cout << "Enter product price: ";
	std::cin >> price;
	int canBuy = wallet.howManyBuy(price);
	std::cout << "You can buy " << canBuy << " items with the price of " << price << "." << std::endl;
}

int main()
{
	{
		int n;
		std::cout << "Enter number of different money types in wallet: ";
		std::cin >> n;
		Money *wallet=new Money[n];

		for (int i = 0; i < n; i++)
		{
			int somenumber;
			std::cout << "Enter face value money from wallet " << i + 1 << ": ";
			std::cin >> somenumber;
			wallet[i].setFaceValue(somenumber) ;
			std::cout << "Enter count money from wallet " << i + 1 << ": ";
			std::cin >> somenumber;
			wallet[i].setCount(somenumber);
		}
		delete[] wallet;
	}

}