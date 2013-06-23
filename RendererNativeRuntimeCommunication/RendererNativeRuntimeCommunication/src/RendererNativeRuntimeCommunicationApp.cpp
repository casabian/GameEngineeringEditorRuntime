#include <vector>

#include "cinder/app/AppNative.h"
#include "cinder/gl/gl.h"

#include "boost/interprocess/sync/scoped_lock.hpp"
#include "boost/thread/mutex.hpp"

#include "Shape.h"
#include "Parser.h"
#include "TcpClient.h"

using namespace ci;
using namespace ci::app;
using namespace std;

class RendererNativeRuntimeCommunicationApp : public AppNative 
{
public:
	void setup();
	void keyDown(KeyEvent event);
	void update();
	void draw();
	void shutdown();

	void OnClientConnect(const boost::asio::ip::tcp::endpoint& endpoint);
	void OnClientDisconnect(const boost::asio::ip::tcp::endpoint& endpoint);
	void OnClientMessage(const std::string& message);

private:
	typedef std::vector<Shape*> ShapesList;
	ShapesList shapeList;
	TcpClient client;

	boost::mutex receivedXmlMutex;
	std::string receivedXml;
};

void RendererNativeRuntimeCommunicationApp::setup()
{
	client.onConnectSignal.connect(
		boost::bind(&RendererNativeRuntimeCommunicationApp::OnClientConnect, this, boost::arg<1>::arg()));
	client.onDisconnectSignal.connect(
		boost::bind(&RendererNativeRuntimeCommunicationApp::OnClientDisconnect, this, boost::arg<1>::arg()));
	client.onMessageSignal.connect(
		boost::bind(&RendererNativeRuntimeCommunicationApp::OnClientMessage, this, boost::arg<1>::arg()));
	client.connect("127.0.0.1", 50000);
}

void RendererNativeRuntimeCommunicationApp::keyDown(KeyEvent event)
{
	if(event.getCode() == event.KEY_F5)
	{
		boost::mutex::scoped_lock lock(receivedXmlMutex);
		receivedXml = loadString(loadFile(getAppPath().string() + "/data/shapes.xml")); 
	}
}

void RendererNativeRuntimeCommunicationApp::update()
{
	client.update();

	if (receivedXml != "")
	{
		boost::mutex::scoped_lock lock(receivedXmlMutex);
		try 
		{
			Parser::Parse(receivedXml, shapeList);
		}
		catch (const std::exception& e)
		{
			ci::app::console() << "Renderer::update: " << e.what() << std::endl;
		}
	}

}

void RendererNativeRuntimeCommunicationApp::draw()
{
	gl::clear();
	for (ShapesList::iterator it = shapeList.begin(); it != shapeList.end(); ++it)
		(*it)->Draw();
}

void RendererNativeRuntimeCommunicationApp::shutdown()
{
	for (ShapesList::iterator it = shapeList.begin(); it != shapeList.end(); ++it)
		delete (*it);
	shapeList.clear();
}


void RendererNativeRuntimeCommunicationApp::OnClientConnect(const boost::asio::ip::tcp::endpoint& endpoint)
{
	console() << "Client Connected: " << endpoint.address() << std::endl;
}

void RendererNativeRuntimeCommunicationApp::OnClientDisconnect(const boost::asio::ip::tcp::endpoint& endpoint)
{
	console() << "Client Disconnected: " << endpoint.address() << std::endl;
}

void RendererNativeRuntimeCommunicationApp::OnClientMessage(const std::string& message)
{
	boost::mutex::scoped_lock lock(receivedXmlMutex);
	receivedXml = message;
}


CINDER_APP_NATIVE( RendererNativeRuntimeCommunicationApp, RendererGl )
