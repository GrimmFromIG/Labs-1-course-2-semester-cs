#ifndef EXTENDEDSTRING_H
#define EXTENDEDSTRING_H

#include <string>

class ExtendedString
{
private:
    std::string data;
public:
    ExtendedString(const std::string& str);

    std::string getString() const;

    size_t getLength() const;

    void removeChar5();
};

ExtendedString::ExtendedString(const std::string& str)
{
    data = str;
}

std::string ExtendedString::getString() const
{
    return data;
}

size_t ExtendedString::getLength() const
{
    return data.length();
}

void ExtendedString::removeChar5()
{
    data.erase(remove(data.begin(), data.end(), '5'), data.end());
}

#endif // EXTENDEDSTRING_H
