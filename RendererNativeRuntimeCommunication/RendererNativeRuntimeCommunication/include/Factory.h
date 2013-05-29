#ifndef FACTORY_H
#define FACTORY_H

#include <map>

template
	<
		class AbstractProduct,
		typename IdentifierType,
		typename ProductCreator = AbstractProduct *(*)()
	>
class Factory {
public:
	bool Register(const IdentifierType &id, ProductCreator creator) {
		return callbacks.insert(CallbackMap::value_type(id, creator)).second;
	}
	bool Unregister(const IdentifierType &id) {
		return callbacks.erase(id) == 1;
	}
	AbstractProduct *CreateObject(const IdentifierType &id) {
		typename CallbackMap::const_iterator it = callbacks.find(id);
		if (it != callbacks.end()) 
			return (it->second)();
		else 
			throw std::runtime_error("Error Invalid ID");
	}
private:
	typedef std::map<IdentifierType, ProductCreator> CallbackMap;
	CallbackMap callbacks; 
};

#endif // FACTORY_H