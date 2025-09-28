#pragma once
#ifndef MOTORCYCLE_HPP
#define MOTORCYCLE_HPP

class Motorcycle : public Vehicle
{
	bool _hasSidecar;
public:
	// ---------------------- Constructor and Destructor -----------------------------
	Motorcycle(const std::string& marks, unsigned int number, unsigned int speed, unsigned int capacity, bool hasSidecar);
	Motorcycle(const Motorcycle& other);
	Motorcycle(Motorcycle&& other)noexcept;
	~Motorcycle()override;
	// -------------------------- Getters and Setters -----------------------------
	bool getHasSidecar() const;
	void setHasSidecar(bool hasSidecar);
	void setSpeed(unsigned int speed) override;
	void setCapacity(unsigned int capacity) override;
	// -------------------------- Other Methods -----------------------------
	void ShowInfo() const override;
	void ShowInfoInTable() const override;
};

#endif // MOTORCYCLE_HPP