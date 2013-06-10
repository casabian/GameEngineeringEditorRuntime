#ifndef CIRCLE_SHAPE_H
#define CIRCLE_SHAPE_H

#include <string>
#include "Shape.h"
#include "cinder/Vector.h"

class CircleShape : public Shape
{
public:
	CircleShape() : Shape("")
	{
		center = ci::Vec2i::zero();
		radius =  0.0f;
	}

	CircleShape(std::string _name, ci::Vec2i _center, float _radius) :
		Shape(_name),
		center(_center),
		radius(_radius)
	{
	}

	virtual void Draw();

	virtual void FromXml(const cinder::XmlTree& xml);

	ci::Vec2i center;
	float radius;
};

#endif // CIRCLE_SHAPE_H