#pragma once
#ifndef DETAIL_HPP
#define DETAIL_HPP


enum Materials {
	WOOD,
	PLASTIC,
	STEEL,
	TITAN,
	CARBON
};;


class Detail
{
protected:
	std::string _name;
	Materials _material;
	unsigned int _height;
	unsigned int _width;
	unsigned int _weight;

public:
	Detail(std::string name = "NoName", Materials material = WOOD, unsigned int height = 0, unsigned int width = 0, unsigned int weight = 0);
	Detail(const Detail& other);
	Detail(Detail&& other);

	virtual ~Detail() {}

	// ---------------------------- Geters and Seters -------------------------------
	virtual std::string getName() const;
	virtual Materials getMaterial() const;
	virtual unsigned int getHeight() const;
	virtual unsigned int getWidth() const;
	virtual unsigned int getWeight() const;

	virtual void setName(const std::string& name);
	virtual void setMaterial(Materials material);
	virtual void setHeight(unsigned int height);
	virtual void setWidth(unsigned int width);
	virtual void setWeight(unsigned int weight);


	virtual void ShowinTab() const;	

};
#endif // !DETAIL_HPP