#ifndef EXTENDEDSTRING_H
#define EXTENDEDSTRING_H

#include <iostream>
#include <string>
#include <algorithm>
#include <cctype>

class ExtendedString
{
private:
    std::string data;

    static bool isNumeric(const std::string& str);
    static std::string getValidNumericInput();

public:
    ExtendedString(const std::string& str);

    std::string getString() const;
    size_t getLength() const;
    void removeChar5();
};

bool ExtendedString::isNumeric(const std::string& str)
{
    return !str.empty() && std::all_of(str.begin(), str.end(), ::isdigit);
}

std::string ExtendedString::getValidNumericInput()
{
    std::string input;
    bool isValid;

    do
    {
        std::cout << "Введіть цифровий рядок: ";
        std::cin >> input;
        isValid = isNumeric(input);

        if (!isValid)
        {
            std::cout << "Помилка: Введений рядок містить нецифрові символи. Спробуйте ще раз.\n";
        }

    } while (!isValid);

    return input;
}

ExtendedString::ExtendedString(const std::string& str)
{
    if (isNumeric(str))
    {
        data = str;
    }
    else
    {
        std::cout << "Ïîìèëêà: Ââåäåíèé ðÿäîê ì³ñòèòü íåöèôðîâ³ ñèìâîëè.\n";
        data = getValidNumericInput();
    }
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
    data.erase(std::remove(data.begin(), data.end(), '5'), data.end());
}

#endif // EXTENDEDSTRING_H

