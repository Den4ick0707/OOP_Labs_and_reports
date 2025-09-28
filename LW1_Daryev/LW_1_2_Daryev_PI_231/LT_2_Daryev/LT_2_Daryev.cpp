#include <iostream>
#include "Money.hpp"

/*
4.	Створити клас Money, розробивши наступні елементи класу :
	- Поля :
		int faceValue_;//номинал купюри
		int count_; //кількість купюр
	- Конструктор, що дозволяє створити екземпляр класу із заданими значенням полів.
	- Методи, що дозволяють :
		вивести номінал і кількість купюр;
		визначити, чи вистачить грошових коштів на покупку товару на суму N гривнів.
		визначити, скільки шт товару вартості n гривнів можна купити на наявні грошові кошти.
	- Властивості :
		які надають можливість  одержати - встановити значення полів(доступне для читання і запису);
		які надають можливість  расчитатать суму грошей(доступне тільки для читання).

*/

int main()
{
	Money wallet = Money();
	int fv, c, var;

	for (int i = 0;; i++) {
		std::cout << "Enter a wallet contents(face value , counts) - ";
		std::cin >> fv >> c;

		if (Money::isValid(fv, c)) {
			wallet.setFaceValue(fv);
			wallet.setCount(c);
			break;
		}
		std::cout << "Invalid price!" << std::endl;
	}
	std::cout << "-------------------------------------------------------------------------" << std::endl;
	wallet.Show();
	while (true) {
		std::cout << "----------------------------- MENU -----------------------------" << std::endl;
		std::cout << "Choose your variant work:" << std::endl;
		std::cout << "1 - Determine whether there are sufficient funds to purchase goods worth N hryvnia." << std::endl;
		std::cout << "2 - Determine how many items costing n hryvnia can be purchased with the available funds." << std::endl;
		std::cout << "0 - Exit" << std::endl;
		std::cin >> var;

		switch (var) {
		case 1:
			wallet.beEnough();
			break;
		case 2:
			wallet.howManyYouCanBuy();
			break;
		case 0:
			return 0;
			break;
		}
	}
	return 0;
}
