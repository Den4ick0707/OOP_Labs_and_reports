#include "Product.h"

int main()
{
	{
		Product prodOne = Product("Bread", "12345", 10);
		prodOne.Show();
	}
	{
		Product* prodTwo = new Product("Milk", "67890", 20);
		prodTwo->Show();
	}
	return 0;
}

