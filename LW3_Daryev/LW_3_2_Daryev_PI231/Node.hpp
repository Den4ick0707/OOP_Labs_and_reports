#pragma once
#ifndef NODE_HPP
#define NODE_HPP


class Node : public Detail
{
	unsigned int _detailsCount;

	public:
		// ---------------------------- Constructors and Destructors -------------------------------
		Node(std::string name = "NoName", Materials material = WOOD, unsigned int height = 0, unsigned int width = 0, unsigned int weight = 0, unsigned int detailsCount = 0);	
		Node(const Node& other);
		Node(Node&& other)noexcept;
		~Node() override;
	
		// ---------------------------- Geters and Seters -------------------------------
		unsigned int getDetailsCount() const;
		void setDetailsCount(unsigned int detailsCount);

		void ShowinTab() const override;




};

#endif // !NODE_HPP