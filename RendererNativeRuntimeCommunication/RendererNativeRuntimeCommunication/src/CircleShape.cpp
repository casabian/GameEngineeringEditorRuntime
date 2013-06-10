#include "CircleShape.h"

#include "cinder/gl/gl.h"
#include "cinder/Xml.h"

void CircleShape::Draw()
{
	cinder::gl::color(255,0,0);
	cinder::gl::drawSolidCircle(center, radius);
}

void CircleShape::FromXml(const cinder::XmlTree& xml)
{
	center = ci::Vec2i(
		xml.getAttributeValue<int>("CenterX"),
		xml.getAttributeValue<int>("CenterY")
		);
	radius = xml.getAttributeValue<float>("Radius");
}