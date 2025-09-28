#pragma once
#ifndef TRUCK_HPP
#define TRUCK_HPP

class Truck : public Vehicle
{
private:
	bool _hasTrailer;
public:
	// ---------------------- Constructor and Destructor -----------------------------
	Truck(const std::string& marks, unsigned int number, unsigned int speed, unsigned int capacity, bool hasTrailer);
	Truck(const Truck& other);
	Truck(Truck&& other)noexcept;
	~Truck()override;
	// -------------------------- Getters and Setters -----------------------------
	bool getHasTrailer() const;
	void setHasTrailer(bool hasTrailer);
	void setSpeed(unsigned int speed) override;
	void setCapacity(unsigned int capacity) override;
	// -------------------------- Other Methods -----------------------------
	void ShowInfo() const override;
	void ShowInfoInTable() const override;
};

#endif // TRUCK_HPP