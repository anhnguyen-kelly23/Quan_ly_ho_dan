/********************************************************************************
** Form generated from reading UI file 'mainwindow.ui'
**
** Created by: Qt User Interface Compiler version 6.9.0
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_MAINWINDOW_H
#define UI_MAINWINDOW_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QFormLayout>
#include <QtWidgets/QFrame>
#include <QtWidgets/QGridLayout>
#include <QtWidgets/QLabel>
#include <QtWidgets/QLineEdit>
#include <QtWidgets/QMainWindow>
#include <QtWidgets/QMenuBar>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QRadioButton>
#include <QtWidgets/QStatusBar>
#include <QtWidgets/QTabWidget>
#include <QtWidgets/QTextEdit>
#include <QtWidgets/QVBoxLayout>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_MainWindow
{
public:
    QWidget *centralwidget;
    QTabWidget *tabWidget;
    QWidget *tab;
    QVBoxLayout *verticalLayout_6;
    QFormLayout *formLayout;
    QLabel *label;
    QLineEdit *lineEdit;
    QLabel *label_2;
    QLineEdit *lineEdit_2;
    QLabel *label_3;
    QLineEdit *lineEdit_3;
    QLabel *label_4;
    QFrame *frame;
    QVBoxLayout *verticalLayout_7;
    QRadioButton *poorRdBtn;
    QRadioButton *nearPoorRdBtn;
    QRadioButton *noneRdBtn;
    QGridLayout *gridLayout_3;
    QTextEdit *textEdit;
    QGridLayout *gridLayout;
    QPushButton *deleteHouseholdBtn;
    QPushButton *editHouseholdBtn;
    QPushButton *addHouseholdBtn;
    QPushButton *saveToCSVBtn;
    QPushButton *loadFromCSVBtn;
    QWidget *tab_2;
    QMenuBar *menubar;
    QStatusBar *statusbar;

    void setupUi(QMainWindow *MainWindow)
    {
        if (MainWindow->objectName().isEmpty())
            MainWindow->setObjectName("MainWindow");
        MainWindow->resize(2391, 1324);
        centralwidget = new QWidget(MainWindow);
        centralwidget->setObjectName("centralwidget");
        tabWidget = new QTabWidget(centralwidget);
        tabWidget->setObjectName("tabWidget");
        tabWidget->setGeometry(QRect(110, 50, 801, 751));
        tabWidget->setTabShape(QTabWidget::TabShape::Rounded);
        tab = new QWidget();
        tab->setObjectName("tab");
        verticalLayout_6 = new QVBoxLayout(tab);
        verticalLayout_6->setObjectName("verticalLayout_6");
        formLayout = new QFormLayout();
        formLayout->setObjectName("formLayout");
        label = new QLabel(tab);
        label->setObjectName("label");

        formLayout->setWidget(0, QFormLayout::ItemRole::LabelRole, label);

        lineEdit = new QLineEdit(tab);
        lineEdit->setObjectName("lineEdit");

        formLayout->setWidget(0, QFormLayout::ItemRole::FieldRole, lineEdit);

        label_2 = new QLabel(tab);
        label_2->setObjectName("label_2");

        formLayout->setWidget(1, QFormLayout::ItemRole::LabelRole, label_2);

        lineEdit_2 = new QLineEdit(tab);
        lineEdit_2->setObjectName("lineEdit_2");

        formLayout->setWidget(1, QFormLayout::ItemRole::FieldRole, lineEdit_2);

        label_3 = new QLabel(tab);
        label_3->setObjectName("label_3");

        formLayout->setWidget(2, QFormLayout::ItemRole::LabelRole, label_3);

        lineEdit_3 = new QLineEdit(tab);
        lineEdit_3->setObjectName("lineEdit_3");

        formLayout->setWidget(2, QFormLayout::ItemRole::FieldRole, lineEdit_3);

        label_4 = new QLabel(tab);
        label_4->setObjectName("label_4");

        formLayout->setWidget(3, QFormLayout::ItemRole::LabelRole, label_4);

        frame = new QFrame(tab);
        frame->setObjectName("frame");
        frame->setFrameShape(QFrame::Shape::StyledPanel);
        frame->setFrameShadow(QFrame::Shadow::Raised);
        verticalLayout_7 = new QVBoxLayout(frame);
        verticalLayout_7->setObjectName("verticalLayout_7");
        poorRdBtn = new QRadioButton(frame);
        poorRdBtn->setObjectName("poorRdBtn");

        verticalLayout_7->addWidget(poorRdBtn);

        nearPoorRdBtn = new QRadioButton(frame);
        nearPoorRdBtn->setObjectName("nearPoorRdBtn");

        verticalLayout_7->addWidget(nearPoorRdBtn);

        noneRdBtn = new QRadioButton(frame);
        noneRdBtn->setObjectName("noneRdBtn");

        verticalLayout_7->addWidget(noneRdBtn);


        formLayout->setWidget(3, QFormLayout::ItemRole::FieldRole, frame);


        verticalLayout_6->addLayout(formLayout);

        gridLayout_3 = new QGridLayout();
        gridLayout_3->setObjectName("gridLayout_3");
        textEdit = new QTextEdit(tab);
        textEdit->setObjectName("textEdit");

        gridLayout_3->addWidget(textEdit, 0, 1, 1, 1);

        gridLayout = new QGridLayout();
        gridLayout->setObjectName("gridLayout");
        deleteHouseholdBtn = new QPushButton(tab);
        deleteHouseholdBtn->setObjectName("deleteHouseholdBtn");

        gridLayout->addWidget(deleteHouseholdBtn, 2, 0, 1, 1);

        editHouseholdBtn = new QPushButton(tab);
        editHouseholdBtn->setObjectName("editHouseholdBtn");

        gridLayout->addWidget(editHouseholdBtn, 1, 0, 1, 1);

        addHouseholdBtn = new QPushButton(tab);
        addHouseholdBtn->setObjectName("addHouseholdBtn");

        gridLayout->addWidget(addHouseholdBtn, 0, 0, 1, 1);

        saveToCSVBtn = new QPushButton(tab);
        saveToCSVBtn->setObjectName("saveToCSVBtn");

        gridLayout->addWidget(saveToCSVBtn, 4, 0, 1, 1);

        loadFromCSVBtn = new QPushButton(tab);
        loadFromCSVBtn->setObjectName("loadFromCSVBtn");

        gridLayout->addWidget(loadFromCSVBtn, 3, 0, 1, 1);


        gridLayout_3->addLayout(gridLayout, 0, 0, 1, 1);


        verticalLayout_6->addLayout(gridLayout_3);

        tabWidget->addTab(tab, QString());
        tab_2 = new QWidget();
        tab_2->setObjectName("tab_2");
        tabWidget->addTab(tab_2, QString());
        MainWindow->setCentralWidget(centralwidget);
        menubar = new QMenuBar(MainWindow);
        menubar->setObjectName("menubar");
        menubar->setGeometry(QRect(0, 0, 2391, 24));
        MainWindow->setMenuBar(menubar);
        statusbar = new QStatusBar(MainWindow);
        statusbar->setObjectName("statusbar");
        MainWindow->setStatusBar(statusbar);

        retranslateUi(MainWindow);

        tabWidget->setCurrentIndex(0);


        QMetaObject::connectSlotsByName(MainWindow);
    } // setupUi

    void retranslateUi(QMainWindow *MainWindow)
    {
        MainWindow->setWindowTitle(QCoreApplication::translate("MainWindow", "MainWindow", nullptr));
        label->setText(QCoreApplication::translate("MainWindow", "Address", nullptr));
        label_2->setText(QCoreApplication::translate("MainWindow", "Head ID", nullptr));
        label_3->setText(QCoreApplication::translate("MainWindow", "Member IDs", nullptr));
        label_4->setText(QCoreApplication::translate("MainWindow", "Special status", nullptr));
        poorRdBtn->setText(QCoreApplication::translate("MainWindow", "Poor", nullptr));
        nearPoorRdBtn->setText(QCoreApplication::translate("MainWindow", "Near Poor", nullptr));
        noneRdBtn->setText(QCoreApplication::translate("MainWindow", "None", nullptr));
        deleteHouseholdBtn->setText(QCoreApplication::translate("MainWindow", "Delete", nullptr));
        editHouseholdBtn->setText(QCoreApplication::translate("MainWindow", "Edit", nullptr));
        addHouseholdBtn->setText(QCoreApplication::translate("MainWindow", "Add", nullptr));
        saveToCSVBtn->setText(QCoreApplication::translate("MainWindow", "Save to CSV", nullptr));
        loadFromCSVBtn->setText(QCoreApplication::translate("MainWindow", "Load from CSV", nullptr));
        tabWidget->setTabText(tabWidget->indexOf(tab), QCoreApplication::translate("MainWindow", "Household", nullptr));
        tabWidget->setTabText(tabWidget->indexOf(tab_2), QCoreApplication::translate("MainWindow", "Person", nullptr));
    } // retranslateUi

};

namespace Ui {
    class MainWindow: public Ui_MainWindow {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_MAINWINDOW_H
