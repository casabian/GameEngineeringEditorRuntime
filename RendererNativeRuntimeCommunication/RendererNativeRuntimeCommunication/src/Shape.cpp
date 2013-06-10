#include "Shape.h"

#include "RectangleShape.h"
#include "CircleShape.h"

Shape* Shape::Create(std::string type)
{
	if (type == "Box")
		return new RectangleShape();
	else if (type == "Circle")
		return new CircleShape();
}