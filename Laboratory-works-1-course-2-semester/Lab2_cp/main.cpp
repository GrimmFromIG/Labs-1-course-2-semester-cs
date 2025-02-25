#include "StringProcessor.h"
#include <iostream>

int main() 
{
  input = 
    StringProcessor sp1(input)
    StringProcessor sp2(sp1);
    std::cout << "Начальная строка: " << sp1.getString() << std::endl;

    sp1.removeFives();
    std::cout << "Строка после удаления '5': " << sp1.getString() << std::endl;
    std::cout << "Длина измененной строки: " << sp1.getLength() << std::endl;

    return 0;
}
