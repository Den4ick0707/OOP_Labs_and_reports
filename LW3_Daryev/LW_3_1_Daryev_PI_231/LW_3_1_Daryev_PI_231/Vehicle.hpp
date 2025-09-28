#pragma once
#ifndef VEHICLE_HPP	
#define VEHICLE_HPP


class Vehicle
{
protected:
	std::string _marks;
	unsigned int _number;
	unsigned int _speed;
	unsigned int _capacity;

public:

	// ---------------------- Constructor and Destructor -----------------------------
	Vehicle(const std::string& marks, unsigned int number, unsigned int speed, unsigned int capacity);
	Vehicle(const Vehicle& other);
	Vehicle(Vehicle&& other)noexcept;
	virtual ~Vehicle();

	// -------------------------- Getters and Setters -----------------------------
	std::string getMarks() const;	
	unsigned int getNumber() const;
	unsigned int getSpeed() const;
	unsigned int getCapacity() const;

	void setMarks(const std::string& marks);
	void setNumber(unsigned int number);
	virtual void setSpeed(unsigned int speed);
	virtual void setCapacity(unsigned int capacity);

	// -------------------------- Other Methods -----------------------------

	virtual void ShowInfo() const = 0;	
	virtual void ShowInfoInTable() const = 0;

};

#endif // VEHICLE_HPP