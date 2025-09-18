#include <iostream>
#include "Money.h"


int main()
{
    std::cout << "----------------------- Constructors ------------------------" << std::endl;
    Money walletOne(10, 5);
    Money walletTwo(50, 200);
    Money walletThree = walletTwo;         
    Money walletFour = std::move(walletThree); 

    std::cout << std::endl;

    std::cout << "----------------------- Overloaded operators ------------------------" << std::endl;

    Money walletFive(100, 20);
    Money walletSix(100, 50);

    Money sum = walletSix + walletFive;
    std::cout << "walletSix + walletFive:" << std::endl;
    std::cout << sum << std::endl;

    Money diff = walletSix - walletFive;
    std::cout << "walletSix - walletFive:" << std::endl;
    std::cout << diff << std::endl;

    walletThree = walletTwo;
    std::cout << "walletThree after assigmetn walletTwo:" << std::endl;
    std::cout << walletThree << std::endl;

    std::cout << std::boolalpha;
    std::cout << "walletFive == walletSix ? " << (walletFive == walletSix) << std::endl;
    std::cout << "walletFive != walletSix ? " << (walletFive != walletSix) << std::endl;

    ++walletFive;
    std::cout << "walletFive after ++ : " << walletFive << std::endl;
    walletFive--;
    std::cout << "walletFive after -- : " << walletFive << std::endl;

    std::string str = static_cast<std::string>(walletSix);
    std::cout << "walletSix as a string: " << str << std::endl;
}

