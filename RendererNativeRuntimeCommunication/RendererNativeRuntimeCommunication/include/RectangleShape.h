#ifndef RECTANGLE_SHAPE_H
#define RECTANGLE_SHAPE_H

#include "Shape.h"

#include "cinder/Vector.h"
#include "cinder/Rect.h"
#include "cinder/gl/gl.h"

class RectangleShape : public Shape
{
public:
	RectangleShape() : Shape("")
	{
		min = max = ci::Vec2i::zero();
	}

	RectangleShape(std::string _name, ci::Vec2i _min, ci::Vec2i _max) :
	Shape(_name),
		min(_min),
		max(_max)
	{
	}

	virtual void Draw();

	virtual void FromXml(const cinder::XmlTree& xml);

	ci::Vec2i min, max;
};

#endif // RECTANGLE_SHAPE_H