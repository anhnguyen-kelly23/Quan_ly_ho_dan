#ifndef PERSON_H
#define PERSON_H

#include "helpers.h"
#include <QString>
#include <QSet>

enum class Gender
{
    Male,
    Female,
    Other
};

class Person
{

protected:
    QString name;
    Date dob;
    QString id;
    Gender gender;
    void inputWithoutId();
    static QSet<QString> usedIds;

public:
    Person(const QString &n = "", const Date &d = {1, 1, 1900},
           const QString &id = "", Gender g = Gender::Other);
    virtual void input();
    virtual void display() const;
    virtual void edit();
    QString getId() const;
    const Date &getDob() const;
    const QString &getName() const;
    Gender getGender() const;
    virtual ~Person() {}
};

class HouseholdHead : public Person
{
public:
    HouseholdHead(const QString &n = "", const Date &d = {1, 1, 1900},
                  const QString &id = "", Gender g = Gender::Other);
    void input() override;
    void display() const override;
};

enum class Relationship
{
    Spouse,
    Child,
    Parent,
    Sibling,
    None
};

class FamilyMember : public Person
{
private:
    Relationship relationship;
    QString headId;

public:
    FamilyMember(const QString &n = "", const Date &d = {1, 1, 1900},
                 const QString &id = "", Gender g = Gender::Other,
                 Relationship rel = Relationship::None,
                 const QString &headId = "");
    void input() override;
    void inputHeadIdAndRelationship(QString headId);
    void inputWithoutId(QString id, QString headId);
    void display() const override;
    void edit() override;
    Relationship getRelationship() const;
    QString getHeadId() const;
    void setHeadId(QString headId);
};

#endif // PERSON_H
