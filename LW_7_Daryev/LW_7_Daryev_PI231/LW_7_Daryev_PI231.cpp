#include <iostream>
#include <set>
#include <vector>


//multiset	vector	int


int main()
{
	std::multiset<int> mySet = { 5, 3, 8, 1, 3, 7, 9, 5 };
	std::vector<int> myVector = { 5, 2, 7, 4, 6, 2, 4, 7, 9, 0, 4, 2 };

	std::cout << "------------------ Show containers ------------------------" << std::endl;
	std::cout << "Multiset elements: ";
	for (const auto& elem : mySet)
		std::cout << elem << " ";

	std::cout << std::endl;
	std::cout << "Vector elements: ";
	for (const auto& elem : myVector)
		std::cout << elem << " ";

	std::cout << std::endl;
	std::cout << "----------------------------------------------------------" << std::endl;

	std::cout << "------------------ Insert elements ------------------------" << std::endl;
	mySet.insert(4);
	myVector.push_back(6);

	std::cout << "Multiset elements: ";
	for (const auto& elem : mySet)
		std::cout << elem << " ";

	std::cout << std::endl;
	std::cout << "Vector elements: ";
	for (const auto& elem : myVector)
		std::cout << elem << " ";

	std::cout << std::endl;

	std::cout << "------------------ Delete elements ------------------------" << std::endl;

	mySet.erase(3); 
	myVector.erase(std::remove(myVector.begin(), myVector.end(), 2));	

	std::cout << "Multiset elements: ";
	for (auto it = mySet.cbegin(); it != mySet.cend(); ++it) 
		std::cout << *it << " ";
	
	std::cout << std::endl;
	std::cout << "Vector elements: ";
	for (auto it = myVector.cbegin(); it != myVector.cend(); ++it) 
		std::cout << *it << " ";
	
	std::cout << std::endl;

}

