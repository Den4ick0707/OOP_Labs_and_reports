#pragma once
#ifndef CAR_HPP
#define CAR_HPP


class Car : public Vehicle
{
public:
	// ---------------------- Constructor and Destructor -----------------------------
	Car(const std::string& marks, unsigned int number, unsigned int speed, unsigned int capacity);
	Car(const Car& other);
	Car(Car&& other)noexcept;
	~Car()override;
	// -------------------------- Getters and Setters -----------------------------
	void setSpeed(unsigned int speed) override;
	// -------------------------- Other Methods -----------------------------
	void ShowInfo() const override;
	void ShowInfoInTable() const override;

};

#endif // CAR_HPP