#pragma once
class Product :
    public Mechanism
{
	unsigned int _productPrice;
	public:
		// ---------------------------- Constructors and Destructors -------------------------------
		Product(std::string name = "NoName",
			Materials material = WOOD,
			unsigned int height = 0,
			unsigned int width = 0,
			unsigned int weight = 0,
			unsigned int detailsCount = 0,
			unsigned int serialNumber = 0,
			unsigned int productPrice = 0);
		Product(const Product& other);
		Product(Product&& other) noexcept;
		~Product() override;
		// ---------------------------------- Geters and Seters -----------------------------------
		
		unsigned int getProductPrice() const;
		void setProductPrice(unsigned int productPrice);
		void ShowinTab() const override;


};

