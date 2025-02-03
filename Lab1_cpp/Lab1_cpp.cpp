#include <iostream>
#include "ExtendedString.h"
#include <locale>
#include <Windows.h>

int main() {
    setlocale(LC_CTYPE, "ukr"); SetConsoleOutputCP(1251);

    std::cout << "Введіть цифровий рядок:" << std::endl;

    std::string input;

    std::cin >> input;

    ExtendedString strObj(input);

    std::cout << "Початковий рядок: " << strObj.getString() << std::endl;

    std::cout << "Довжина рядка: " << strObj.getLength() << std::endl;

    strObj.removeChar5();

    std::cout << "Рядок після видалення '5': " << strObj.getString() << std::endl;

    std::cout << "Нова довжина рядка: " << strObj.getLength() << std::endl;

    return 0;
}