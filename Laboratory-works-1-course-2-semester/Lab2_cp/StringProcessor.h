#ifndef STRINGPROCESSOR_H
#define STRINGPROCESSOR_H

#include <string>

class StringProcessor 
{
    private:
        std::string str;

    public:
        StringProcessor();
        StringProcessor(const std::string& inputStr);
        StringProcessor(const StringProcessor& other);

        ~StringProcessor();

        size_t getLength() const;
        void removeFives();
        std::string getString() const;
};

#endif
