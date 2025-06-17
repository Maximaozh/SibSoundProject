#include "audioformat.h"

AudioFormat::~AudioFormat()
{
    if(data != nullptr)
        delete[] data;
}

int AudioFormat::readData(QFile& file)
{
}

AudioFormat::AudioFormat()
{
    data = nullptr;
}

int AudioFormat::writeData(QString fileName)
{

}

std::string AudioFormat::info()
{

}
