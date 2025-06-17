#include "wav.h"

WAV::WAV() : audioFormat()
{

}

int WAV::readData(QFile& file)
{
    // RAFF
    memcpy(&chunkId,        file.read(4),4);
    memcpy(&chunkSize,      file.read(4),4);
    memcpy(&format,         file.read(4),4);

    // Формат
    memcpy(&subschunk1Id,   file.read(4),4);
    memcpy(&subchunk1Size,  file.read(4),4);
    memcpy(&audioFormat,    file.read(2),2);
    memcpy(&numChannels,    file.read(2),2);
    memcpy(&sampleRate,     file.read(4),4);
    memcpy(&byteRate,       file.read(4),4);
    memcpy(&blockAlign,     file.read(2),2);
    memcpy(&bitsPerSample,  file.read(2),2);

    // Данные
    memcpy(&subschunk2Id,   file.read(4),4);
    memcpy(&subchunk2Size,  file.read(4),4);

    // Если у нас не было прочтена секции data, то её надо найти.
    if(subschunk2Id != "data")
    {
        file.read(subchunk2Size);
        memcpy(&subschunk2Id, file.read(4),4);
        memcpy(&subchunk2Size,file.read(4),4);
    }

    data = new  unsigned char[subchunk2Size];
    memcpy(data,file.read(subchunk2Size),subchunk2Size);
}

int WAV::writeData(QString fileName)
{
    QFile file(fileName);
    file.open(QIODevice::WriteOnly);

    file.write((char*)&chunkId,4);
    file.write((char*)&chunkSize,4);
    file.write((char*)&format,4);


    file.write((char*)&subschunk1Id, 4);
    file.write((char*)&subchunk1Size, 4);
    file.write((char*)&audioFormat, 2);
    file.write((char*)&numChannels, 2);
    file.write((char*)&sampleRate,4);
    file.write((char*)&byteRate,4);
    file.write((char*)&blockAlign,2);
    file.write((char*)&bitsPerSample,2);

    file.write((char*)&subschunk2Id,4);
    file.write((char*)&subchunk2Size,4);
    for (int i = 0; i < subchunk2Size; i++)
    {
        data[i] = (unsigned char)(sin(cos(i)*cos(i))*i)%256;
    }

    int in = file.write((char*)data,subchunk2Size);

    file.close();
}

std::string WAV::info()
{
    std::string output =
            std::string("chunkId ") + std::string(chunkId)                 +  "; " +
            std::string("chunkSize ") + std::to_string(chunkSize)       +  "; " +
            std::string("format ") + std::string(format)                  +  "; " +

            std::string("subschunk1Id ") + std::string(subschunk1Id)           + "; " +
            std::string("subchunk1Size ") +std::to_string(subchunk1Size)   + "; " +
            std::string("audioFormat ") +std::to_string(audioFormat)     + "; " +
            std::string("numChannels ") +std::to_string(numChannels)     + "; " +
            std::string("sampleRate ") +std::to_string(sampleRate)      + "; " +
            std::string("byteRate ") +std::to_string(byteRate)        + "; " +
            std::string("blockAlign ") +std::to_string(blockAlign)      + "; " +
            std::string("bitsPerSample ") +std::to_string(bitsPerSample)   + "; " +

            std::string("subschunk2Id ") + std::string(subschunk2Id)        + "; " +
            std::string("subchunk2Size ") + std::to_string(subchunk2Size)   + "." ;

    return output;
}

WAV::WAV(QFile& file)
{
    readData(file);
}


