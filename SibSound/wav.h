#ifndef WAV_H
#define WAV_H

#include "audioformat.h"

// Структура Wav аудиофайла, содержащая лишь основные секции.
class WAV : protected AudioFormat
{
private:
    WAV();

    // Чтение данных
    int     readData(QFile& file) override;
public:
    // Заголовок RIFF
    char    chunkId[4];         // Символы "RIFF"
    int     chunkSize;          // Оставшейся размер цепочки (начиная с этой позиции)
    char    format[4];          // Символы "WAVE"

    // Заголовок формата
    char    subschunk1Id[4];    // Содержит сисмволы "fmt "
    int     subchunk1Size;      // 16 для формата PCM.
    short   audioFormat;        // Аудио формат, список допустимых форматов.
    short   numChannels;        // Количество каналов
    int     sampleRate;         // Частота дискретизации.
    int     byteRate;           // Количество байт, переданных за секунду воспроизведения
    short   blockAlign;         // Количество байт для одного сэмпла, включая все каналы.
    short   bitsPerSample;      // Количество бит в сэмпле, т.е. "Глубина"

    // Данные
    char    subschunk2Id[4];    // Символы data
    int     subchunk2Size;      // Количесвто байт в области данных;

    int writeData(QString fileName) override;

    std::string info() override;

    WAV(QFile& file);
};


#endif // WAV_H
