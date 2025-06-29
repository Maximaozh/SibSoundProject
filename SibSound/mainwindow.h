#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include "audio.h"

#include <QMainWindow>
#include <QtCore>
#include <QtDebug>
#include <QFileDialog>

QT_BEGIN_NAMESPACE
namespace Ui { class MainWindow; }
QT_END_NAMESPACE

class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    MainWindow(QWidget *parent = nullptr);
    ~MainWindow();

private slots:
    void on_actionOpenFile_triggered();

private:
    Ui::MainWindow *ui;
};
#endif // MAINWINDOW_H
