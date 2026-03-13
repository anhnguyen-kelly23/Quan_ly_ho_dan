#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include <QString>
#include <QVector>

QT_BEGIN_NAMESPACE
namespace Ui {
class MainWindow;
}
QT_END_NAMESPACE

class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    MainWindow(QWidget *parent = nullptr);
    ~MainWindow();

private slots:
    void on_saveToCSVBtn_clicked();

    void on_addHouseholdBtn_clicked();

private:
    Ui::MainWindow *ui;
    void getValidStringInput(const QString input, size_t maxLength, bool allowEmpty);
    void getValidIntegerInput(const int value, int min, int max);
    QVector<QString> stringToVector(const QString& input);
};
#endif // MAINWINDOW_H
