#include <iostream>
#include <vector>
#include <set>
#include <algorithm>
#include <list>
#include <string>
#include <fstream>

class Product {
	std::string name;
	std::string code;
	int count;
public:
	Product(const std::string& name, const std::string& code, int count)
		: name(name), code(code), count(count) {
	}
	const std::string& getName() const { return name; }

	const std::string& getCode() const { return code; }

	int getCount() const { return count; }

	bool operator<(const Product& other) const {
		return code < other.code;
	}
};


int main()
{
	std::cout << "------------------------------------ Create multiset and show --------------------------------" << std::endl;
	std::multiset<Product> productsSet;
	productsSet.insert(Product{ "Yay", "Y232", 50 });
	productsSet.insert(Product{ "Banana", "B456", 30 });
	productsSet.insert(Product{ "Orange", "O789", 20 });
	productsSet.insert(Product{ "Cocos", "C555", 25 });
	productsSet.insert(Product{ "Apple", "A123", 15 });

	std::cout << "Products in multiset (sorted by code):" << std::endl;
	for (auto it : productsSet) {
		std::cout << "Name: " << it.getName() << ", Code: " << it.getCode() << ", Count: " << it.getCount() << std::endl;
	}

	std::cout << "------------------------------------ Sort product by descending --------------------------------" << std::endl;

	std::vector<Product> productsVector(productsSet.begin(), productsSet.end());

	std::sort(productsVector.begin(), productsVector.end(), [](const Product& a, const Product& b) { return a.getName() > b.getName(); });

	std::cout << "Sorted products in vector (descending by name) :" << std::endl;
	for (auto it : productsVector) {
		std::cout << "Name: " << it.getName() << ", Code: " << it.getCode() << ", Count: " << it.getCount() << std::endl;
	}

	std::cout << "------------------------------------ Find product and move to list --------------------------------" << std::endl;

	std::list<Product> productsList;


	auto found_it = std::find_first_of(productsVector.begin(), productsVector.end(), productsSet.begin(), productsSet.end(),
		[](const Product& a, const Product& b) { return a.getName() == b.getName(); });

	if (found_it != productsVector.end())
	{
		std::cout << "Found product to move: " << found_it->getName() << std::endl;

		productsList.insert(productsList.begin(), *found_it);

		productsVector.erase(found_it);
	}

	std::cout << "Products in list after move:" << std::endl;
	for (auto it : productsList) {
		std::cout << "Name: " << it.getName() << ", Code: " << it.getCode() << ", Count: " << it.getCount() << std::endl;
	}

	std::cout << "\nProducts left in vector after move:" << std::endl;
	for (auto it : productsVector) {
		std::cout << "Name: " << it.getName() << ", Code: " << it.getCode() << ", Count: " << it.getCount() << std::endl;
	}
	std::cout << "--------------------------------- Write and read from file ----------------------------------" << std::endl;

	std::string filename = "products.txt";
	std::ofstream outFile(filename);

	if (!outFile.is_open()) {
		std::cerr << "ERROR: Cannot open file" << std::endl;
		return 1;
	}
	std::cout << "Writing products to file: " << filename << std::endl;
	for (auto it : productsSet) {
		outFile << it.getName() << "," << it.getCode() << "," << it.getCount() << std::endl;
	}
	std::cout << "Writing completed." << std::endl;
	outFile.close();
	std::ifstream inFile(filename);
	if (!inFile.is_open()) {
		std::cerr << "ERROR: Cannot open file" << std::endl;
		return 1;
	}
	std::multiset<Product> productsFromFile;
	std::string line;

	std::cout << "Reading products from file: " << filename << std::endl;
	while (std::getline(inFile, line)) {
		size_t pos1 = line.find(',');
		size_t pos2 = line.find(',', pos1 + 1);
		std::string name = line.substr(0, pos1);
		std::string code = line.substr(pos1 + 1, pos2 - pos1 - 1);
		int count = std::stoi(line.substr(pos2 + 1));
		productsFromFile.insert(Product{ name, code, count });
	}
	std::for_each(productsFromFile.begin(), productsFromFile.end(), [](const Product& it) {
		std::cout << "Name: " << it.getName() << ", Code: " << it.getCode() << ", Count: " << it.getCount() << std::endl;
		});


	std::cout << "------------------------------------ End --------------------------------" << std::endl;




	return 0;
}

