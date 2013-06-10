#include "RectangleShape.h"

void RectangleShape::Draw()
{
	cinder::gl::color(255,0,0);
	cinder::gl::drawSolidRect(cinder::Rectf(min, max));
}

void RectangleShape::FromXml(const cinder::XmlTree& xml)
{
	min = ci::Vec2i(
		xml.getAttributeValue<int>("MinX"),
		xml.getAttributeValue<int>("MinY")
		);
	max = ci::Vec2i(
		xml.getAttributeValue<int>("MaxX"),
		xml.getAttributeValue<int>("MaxY")
		);
}
