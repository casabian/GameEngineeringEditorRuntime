#include "TcpClient.h"

#include "cinder/app/App.h"


TcpClient::TcpClient() : 
	m_Socket(m_IoService),
	m_ReconnectTimer(m_IoService),
	m_RefreshTimer(m_IoService),
	m_Connected(false),
	m_Delimiter("\r\n")
{
}

TcpClient::TcpClient( std::string messageDelimiter ) : 
	m_Socket(m_IoService),
	m_ReconnectTimer(m_IoService),
	m_RefreshTimer(m_IoService),
	m_Connected(false),
	m_Delimiter(messageDelimiter)
{
}

TcpClient::~TcpClient()
{
	m_Socket.close();
}

void TcpClient::connect( const std::string& ip, const unsigned short& port )
{
	try
	{
		tcp_endpoint endpoint(boost::asio::ip::address::from_string(ip), port);
		connect(endpoint);
	}
	catch(const std::exception& e)
	{
		ci::app::console() << "TcpClient::connect: " << e.what() << std::endl;
	}
}

void TcpClient::connect( const tcp_endpoint& endpoint )
{
	if (m_Connected) 
		return;
	m_Endpoint = endpoint;
	
	try
	{
		m_Socket.async_connect(m_Endpoint,
			boost::bind(&TcpClient::onConnect, this, boost::asio::placeholders::error)
			);
	}
	catch (const std::exception& e)
	{
		ci::app::console() << "TcpClient::connect: " << e.what() << std::endl;
	}
}

void TcpClient::update()
{
	try
	{
		m_IoService.poll();
	}
	catch (const std::exception& e)
	{
		ci::app::console() << "TcpClient::update: " << e.what() << std::endl;
	}
}

void TcpClient::read()
{
	try
	{
		boost::asio::async_read_until(m_Socket, m_ResponseBuffer, m_Delimiter,
			boost::bind(&TcpClient::onRead, this, boost::asio::placeholders::error));	
	}
	catch (const std::exception& e)
	{
		ci::app::console() << "TcpClient::read: " << e.what() << std::endl;
	}

}

void TcpClient::onConnect( const boost::system::error_code& error )
{
	if (!error)
	{
		m_Connected = true;
		// connection succeed
		onConnectSignal(m_Endpoint);
		
		read();
	}
	else
	{
		m_Connected = false;

		m_ReconnectTimer.expires_from_now(boost::posix_time::milliseconds(2500));
		m_ReconnectTimer.async_wait(
			boost::bind(&TcpClient::reconnect, this, boost::asio::placeholders::error));
		ci::app::console() << "ERROR: TcpClient::onConnect: " << error.message() << std::endl;
	}
}

void TcpClient::onRead( const boost::system::error_code& error )
{
	if (!error)
	{
		std::string msg;
		std::istream stream(&m_ResponseBuffer);
		std::getline(stream, msg);
	
		onMessageSignal(msg);

		m_RefreshTimer.expires_from_now(boost::posix_time::microseconds(2500));
		m_RefreshTimer.async_wait(boost::bind(
			&TcpClient::waitUntilRefresh, this, boost::asio::placeholders::error));

		read();
	}
	else
	{
		m_Connected = false;
		
		// host disconnects
		if (error.value() != 0)
		{
			onDisconnectSignal(m_Endpoint);
			ci::app::console() << "INFO: TcpClient::onRead: Host disconnected try reconnect" << std::endl;
			m_ReconnectTimer.expires_from_now(boost::posix_time::milliseconds(2500));
			m_ReconnectTimer.async_wait(
				boost::bind(&TcpClient::reconnect, this, boost::asio::placeholders::error));
		}
		else //other error while reading from socket
		{
			m_Socket.close();
		}
	}
}

void TcpClient::waitUntilRefresh( const boost::system::error_code& error )
{

}

void TcpClient::reconnect( const boost::system::error_code& error )
{
	if (m_Connected)
		return;

	m_Socket.close();
	m_Socket.async_connect(m_Endpoint,
		boost::bind(&TcpClient::onConnect, this, boost::asio::placeholders::error)
	);
}