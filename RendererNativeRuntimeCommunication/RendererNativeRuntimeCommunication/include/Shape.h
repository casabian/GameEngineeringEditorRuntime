#ifndef SHAPE_H
#define SHAPE_H

#include "cinder/Xml.h"

class Shape
{
public:
	Shape(std::string _name) : 
	  name(_name)
	{
	}

	static Shape* Create(std::string type);

	virtual void Draw() = 0;
	virtual void FromXml(const cinder::XmlTree& xml) = 0;


	std::string name;
};

#endif // SHAPE_H