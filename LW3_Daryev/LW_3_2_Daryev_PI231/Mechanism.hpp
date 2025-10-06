#pragma once



class Mechanism : public Node
{
	unsigned int _serialNumber;
public:
	// ---------------------------- Constructors and Destructors -------------------------------
	Mechanism(std::string name = "NoName",
		Materials material = WOOD,
		unsigned int height = 0,
		unsigned int width = 0,
		unsigned int weight = 0,
		unsigned int detailsCount = 0,
		unsigned int serialNumber = 0);

	Mechanism(const Mechanism& other);
	Mechanism(Mechanism&& other) noexcept;
	~Mechanism() override;

	// ---------------------------------- Geters and Seters -----------------------------------

	unsigned int getSerialNumber() const;
	void setSerialNumber(unsigned int serialNumber);

	void ShowinTab() const override;

};

