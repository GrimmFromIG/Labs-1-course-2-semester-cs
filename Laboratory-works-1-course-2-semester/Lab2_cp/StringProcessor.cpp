#include "StringProcessor.h"
#include <iostream>

StringProcessor::StringProcessor() : str("") {}
StringProcessor::StringProcessor(const std::string& inputStr) : str(inputStr) {}
StringProcessor::StringProcessor(const StringProcessor& other) : str(other.str) {}

StringProcessor::~StringProcessor() 
{
    std::cout << "Объект уничтожен. Строка: " << str << std::endl;
}

size_t StringProcessor::getLength() const 
{
    return str.length();
}

void StringProcessor::removeFives() 
{
    str.erase(remove(str.begin(), str.end(), '5'), str.end());
}

std::string StringProcessor::getString() const 
{
    return str;
}
