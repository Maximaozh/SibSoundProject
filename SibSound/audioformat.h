#ifndef AUDIOFORMAT_H
#define AUDIOFORMAT_H

#include <QByteArray>
#include <QString>
#include <string>
#include <QFile>
#include <math.h>

class AudioFormat
{
private:

    // Чтение данных из QByteArray
    virtual int readData(QFile& file);

protected:
    AudioFormat();
    unsigned char* data; // Данные

public:
    virtual int writeData(QString fileName);
    virtual  ~AudioFormat();

    // Вывод информации по формату
    virtual std::string info();
};

#endif // AUDIOFORMAT_H
