#include "audio.h"

// Открытие файла. Пока что только формата .wav
QString Audio::open(QWidget* widget)
{
    QString fileName = QFileDialog::getOpenFileName(widget, tr("Открыть файл"), "/home",tr("Аудиофайл (*.wav)"));
    QFile file(fileName);

    if(!file.open(QIODevice::ReadOnly))
        return "FAILED TO READ";

    WAV audioFile(file);

    qDebug() << audioFile.info().c_str();

    file.close();

    audioFile.writeData(QFileDialog::getSaveFileName(widget, tr("Сохранить файл"), "/home", tr("Аудиофайл (*.wav)")));
    return "YES";
}
