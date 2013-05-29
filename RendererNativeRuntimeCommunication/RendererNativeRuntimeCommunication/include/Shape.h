#ifndef SHAPE_H
#define SHAPE_H

#include "cinder/Vector.h"
#include "cinder/Rect.h"
#include "cinder/gl/gl.h"

class Shape 
{
public:
	Shape(std::string _name) : 
	  name(_name)
	{
	}

	virtual void Draw() = 0;

	std::string name;
};

class Box : public Shape
{
public:
	Box(std::string _name, ci::Vec2i _min, ci::Vec2i _max) :
		Shape(_name),
		min(_min),
		max(_max)
	{
	}

	virtual void Draw()
	{
		cinder::gl::color(255,0,0);
		cinder::gl::drawSolidRect(cinder::Rectf(min, max));
	}

	ci::Vec2i min, max;
};

class Circle : public Shape
{
public:
	Circle(std::string _name, ci::Vec2i _center, float _radius) :
		Shape(_name),
		center(_center),
		radius(_radius)
	{
	}

	virtual void Draw()
	{
		cinder::gl::color(255,0,0);
		cinder::gl::drawSolidCircle(center, radius);
	}

	ci::Vec2i center;
	float radius;
};

#endif // SHAPE_H