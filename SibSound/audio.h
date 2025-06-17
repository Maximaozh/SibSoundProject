#ifndef AUDIO_H
#define AUDIO_H

#include "wav.h"

#include <QtCore>
#include <QtDebug>
#include <QFileDialog>
#include <QFile>

class Audio : QObject
{
    Q_OBJECT


public:
    Audio() = default;
    ~Audio() = default;


    // Получает полный путь до аудиофайла
    QString open(QWidget*);

};

#endif // AUDIO_H
