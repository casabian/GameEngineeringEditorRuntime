#ifndef PARSER_H
#define PARSER_H

#include <vector>

#include "cinder/Vector.h"
#include "cinder/Xml.h"
#include "boost/filesystem.hpp"
#include "Shape.h"

class Parser 
{
public:
	static void Parse(std::string fileName, std::vector<Shape*>& shapeList)
	{
		cinder::fs::path filePath(fileName);
		if (cinder::fs::exists(filePath))
		{
			cinder::XmlTree xmlDocument(cinder::loadFile(filePath.native()));

			if (xmlDocument.hasChild("Shapes"))
			{
				cinder::XmlTree shapes = xmlDocument.getChild("Shapes");
				Shape* shape;
				for (cinder::XmlTree::Container::iterator it = shapes.getChildren().begin();
					it != shapes.getChildren().end(); 
					++it)
				{
					if ((*it)->getTag() == "Circle")
					{
						shape = new Circle(
							(*it)->getAttribute("Name"), 
							ci::Vec2i(
								(*it)->getAttributeValue<int>("CenterX"),
								(*it)->getAttributeValue<int>("CenterY")
							),
							(*it)->getAttributeValue<float>("Radius")
						);
					}
					else if ((*it)->getTag() == "Box")
					{
						shape = new Box(
							(*it)->getAttribute("Name"),
							ci::Vec2i(
								(*it)->getAttributeValue<int>("MinX"),
								(*it)->getAttributeValue<int>("MinY")
							),
							ci::Vec2i(
								(*it)->getAttributeValue<int>("MaxX"),
								(*it)->getAttributeValue<int>("MaxY")
							)
						);
					}
					shapeList.push_back(shape);
				}
			}
		}
	}
};

#endif // PARSER_H