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
	static void Parse(std::string xmlString, std::vector<Shape*>& shapeList)
	{
		for (auto it = shapeList.begin(); it != shapeList.end(); ++it)
			delete (*it);
		shapeList.clear();

		cinder::XmlTree xmlDocument(xmlString);

		if (xmlDocument.hasChild("Shapes"))
		{
			cinder::XmlTree shapes = xmlDocument.getChild("Shapes");
			Shape* shape;
			for (cinder::XmlTree::Container::iterator it = shapes.getChildren().begin();
				it != shapes.getChildren().end(); 
				++it)
			{

				shape = Shape::Create((*it)->getTag());
				shape->FromXml(*(*it));

				shapeList.push_back(shape);
			}
		}
	}
};

#endif // PARSER_H