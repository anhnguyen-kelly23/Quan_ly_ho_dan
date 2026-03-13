#include "mainwindow.h"
#include "./ui_mainwindow.h"
#include "QFile"
#include "QTextStream"
#include "QMessageBox"
#include "street_manager.h"
#include <string>
#include <QString>
#include <QStringList>
#include <QVector>


MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
    ui->setupUi(this);
}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::on_saveToCSVBtn_clicked()
{
    QFile file("household.csv");
    QTextStream textStream(&file);

    if (file.open(QIODevice::WriteOnly)) {

    }
    else {
        QMessageBox::critical(this, "Open File Error", "Can't not open file! Please check again!");
    }

}

void MainWindow::on


void MainWindow::on_addHouseholdBtn_clicked()
{

    QString address = ui->addressLineEdit->text();
    QString headId = ui->headIdLineEdit->text();
    QString memberIds = ui->memberIdsLineEdit->text();
    QString expDate;
    int specialStatus;
    if(ui->noneRdBtn->isChecked() == 1)
    {
        specialStatus = 0;
    } else if (ui->poorRdBtn->isChecked()== 1)
    {
        specialStatus = 1;
    } else if (ui->nearPoorRdBtn->isChecked() ==1 )
    {
        specialStatus = 2;
    }
    int type;
    if(ui->permanentRdBtn->isChecked() == 1){
        type = 0;
    } else if(ui->permanentRdBtn->isChecked()==1){
        type = 1;

    }

    getValidStringInput(address, 100, false);
    getValidStringInput(headId, 12, false);
    getValidStringInput(memberIds, 100, false);
    getValidIntegerInput(specialStatus, 0, 2);
    getValidIntegerInput(type, 0, 1);
    StreetManager *st = new StreetManager();
    bool isUnique = st->isAddressUnique(address);
    if(!isUnique) {
        QMessageBox::critical(this, "Loi", "Dia chi da ton tai");
    }

    st->addHousehold(address, headId, stringToVector(memberIds), specialStatus, type);
}

void MainWindow::getValidStringInput(const QString input, size_t maxLength, bool allowEmpty)
{

    if (input.isEmpty() && !allowEmpty)
    {
        QMessageBox::critical(this,"Loi", "Khong duoc de trong");

    }
    if (input.length() > maxLength)
    {
        QMessageBox::critical(this,"Loi", "Khong duoc de trong");

    }
}

void MainWindow::getValidIntegerInput(const int value, int min, int max)
{
        try
        {
            if (value < min || value > max)
            {
                QMessageBox::critical(this,"Loi", "Vui long chon vao o");
            }

        }
        catch (...)
        {
            QMessageBox::critical(this,"Loi", "Vui long chon vao o");
        }
    }

QVector<QString> MainWindow::stringToVector(const QString& input) {
    QString noSpace = input.split(' ').join("");
    return noSpace.split(',').toVector();
}

void MainWindow::on_temporaryRdBtn_clicked()
{
    ui->expDateEdit->setEnabled(!ui->expDateEdit->isEnabled());
}

