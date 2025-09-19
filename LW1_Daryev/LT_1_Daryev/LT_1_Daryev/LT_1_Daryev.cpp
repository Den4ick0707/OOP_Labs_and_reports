#include <iostream>
#include "Product.hpp"



int main()
{
	{
		std::cout << "--------------------- Constructors --------------------------" << std::endl;
		Product one;
		Product two = Product("Bread", "000001", 10);
		Product three = two;
		Product four = std::move(three);
	}
	{
		std::cout << "------------------------ Show object --------------------------" << std::endl;
		const int SIZE = 4;
		Product prodArr[SIZE] = {
			 Product(),
			 Product("Apple","000002",40),
			 Product("Pear","",5),
			 Product("","010101",200)
		};

		std::cout << "-------------------" << std::endl;
		void (Product:: * ptrShow)() = &Product::Show;

		for (int i = 0; i < SIZE; i++) {
			(prodArr[i].*ptrShow)();
			std::cout << "------------------" << std::endl;
		}
		std::cout << "----------------------------------------------------------------" << std::endl;

		Product* ptrProdArr = new Product[SIZE]{
			 Product(),
			 Product("Garlic","000002",40),
			 Product("Spear","",5),
			 Product("","010101",200)
		};
		std::cout << "----------------------------------------------------------------" << std::endl;
		Product::ShowCap();
		for (int i = 0; i < SIZE; i++) {
			ptrProdArr[i].ShowTab();

		}



	}

}

