#include <vector>

#include "cinder/app/AppNative.h"
#include "cinder/gl/gl.h"

#include "Shape.h"
#include "Parser.h"
#include "Factory.h"

using namespace ci;
using namespace ci::app;
using namespace std;

class RendererNativeRuntimeCommunicationApp : public AppNative 
{
public:
	void setup();
	void keyDown(KeyEvent event);
	void draw();
	void shutdown();
private:
	void clearList();
	typedef std::vector<Shape*> ShapesList;
	ShapesList shapeList;
	Factory<Shape, std::string> shapeFactory;
};

void RendererNativeRuntimeCommunicationApp::setup()
{
	Parser::Parse(getAppPath().string() + "/data/shapes.xml", shapeList);
}

void RendererNativeRuntimeCommunicationApp::keyDown(KeyEvent event)
{
	if(event.getCode() == event.KEY_F5)
	{
		clearList();
		Parser::Parse(getAppPath().string() + "/data/shapes.xml", shapeList);
	}
}
void RendererNativeRuntimeCommunicationApp::draw()
{
	for (ShapesList::iterator it = shapeList.begin(); it != shapeList.end(); ++it)
		(*it)->Draw();
}

void RendererNativeRuntimeCommunicationApp::shutdown()
{
	clearList();
}

void RendererNativeRuntimeCommunicationApp::clearList()
{
	for (ShapesList::iterator it = shapeList.begin(); it != shapeList.end(); ++it)
		delete (*it);
}

CINDER_APP_NATIVE( RendererNativeRuntimeCommunicationApp, RendererGl )
