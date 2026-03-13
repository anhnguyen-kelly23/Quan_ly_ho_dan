#ifndef STREET_MANAGER_H
#define STREET_MANAGER_H

#include "household.h"
#include "person.h"
#include "ui_mainwindow.h"
#include <memory>
#include <QString>
#include <QVector>
#include <QMap>
#include <QMainWindow>

class StreetManager :public QMainWindow
{
     Q_OBJECT
private:

    static QVector<std::unique_ptr<Household>> households;
    static QMap<QString, HouseholdHead> heads;
    static QMap<QString, FamilyMember> familyMembers;

public:
    StreetManager(QWidget *parent = nullptr);
    ~StreetManager();
    Ui::MainWindow *ui;
    bool isAddressUnique(const QString &addr);
    void addHousehold(QString& address, QString& headId, QVector<QString> memberIds, int type, int specialStatus);
    void editHousehold();
    void deleteHousehold();
    void manageHouseholdMembers();
    void managePersons();
    void findExpiredTemporaryHouseholds();
    void displayAll() const;
    void searchByAddress(const std::string &addr) const;
    void searchById(const std::string &id) const;
    void reportByType() const;
    bool saveToCsv() const;
    bool loadFromCsv();
    const HouseholdHead *getHead(const std::string &id) const;
    const FamilyMember *getMember(const std::string &id) const;
    void addPerson();
    void addMemberWithOutId(std::string id, std::string headId);
    void editPerson();
    void deletePerson();
};

#endif // STREET_MANAGER_H
