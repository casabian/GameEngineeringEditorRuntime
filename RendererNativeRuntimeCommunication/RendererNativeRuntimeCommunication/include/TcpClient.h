#ifndef TCP_CLIENT_H
#define TCP_CLIENT_H

#include <string>
#include "boost/signals2.hpp"
#include "boost/asio.hpp"

class TcpClient
{
public:
	typedef boost::asio::ip::tcp::endpoint tcp_endpoint;

	TcpClient();
	TcpClient(std::string messageDelimiter);

	~TcpClient();

	void connect(const std::string& ip, const unsigned short& port);
	void connect(const tcp_endpoint& endpoint);

	void update();

	void read();

	boost::signals2::signal<void(const std::string&)>	onMessageSignal;
	boost::signals2::signal<void(const tcp_endpoint&)>	onConnectSignal;
	boost::signals2::signal<void(const tcp_endpoint&)>	onDisconnectSignal;

private:
	void onConnect(const boost::system::error_code& error);
	void onRead(const boost::system::error_code& error);
	void waitUntilRefresh(const boost::system::error_code& error);

	void reconnect(const boost::system::error_code& error);

	boost::asio::ip::tcp::endpoint	m_Endpoint;
	boost::asio::io_service			m_IoService;
	boost::asio::ip::tcp::socket	m_Socket;
	boost::asio::streambuf			m_ResponseBuffer;

	boost::asio::deadline_timer		m_ReconnectTimer;
	boost::asio::deadline_timer		m_RefreshTimer;

	bool							m_Connected;

	std::string						m_Delimiter;
};

#endif // TCP_CLIENT_H