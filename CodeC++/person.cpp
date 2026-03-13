#include "person.h"
#include "helpers.h"
#include "street_manager.h"
#include <iostream>

using namespace std;

set<string> Person::usedIds;// Khai báo biến tĩnh để lưu trữ ID đã sử dụng

Person::Person(const string &n, const Date &d, const string &id, Gender g)// Khởi tạo đối tượng Person với tên, ngày sinh, ID và giới tính
    : name(n), dob(d), id(id), gender(g)
{
  if (!id.empty())
    usedIds.insert(id);
}

void Person::input() // Nhap thong tin ca nhan
{
  this->name = getValidStringInput("Nhap ten: ", 50, false);
  string dobStr;
  string errorMsg;
  do
  {
    dobStr = getValidStringInput("Nhap ngay sinh (dd/mm/yyyy, vi du: 01/01/1980): ", 10, false);
    this->dob = Date::fromString(dobStr, errorMsg);
    if (!this->dob.isValid())
    {
      cout << "Loi: " << errorMsg << " Vui long nhap lai.\n";
    }
    else if (this->dob.isFuture())
    {
      cout << "Loi: Ngay sinh khong duoc la ngay tuong lai. Vui long nhap lai.\n";
    }
  } while (!this->dob.isValid() || this->dob.isFuture());
  string id;
  do
  {
    id = getValidStringInput("Nhap ID (9 hoac 12 chu so): ", 12, false);
    if (!id.empty() && !isValidIdNumber(id, usedIds, errorMsg))
    {
      cout << "Loi: " << errorMsg << " Vui long nhap lai.\n";
    }
    else
    {
      break;
    }
  } while (true);
  if (!id.empty())
  {
    usedIds.erase(this->id); // Xoa ID cu neu co
    this->id = id;
    usedIds.insert(this->id); // Them ID moi vao danh sach da su dung
  }
  this->gender = Gender::Other;
  auto genderChoice = getValidIntegerInput("Nhap gioi tinh (1: Nam, 2: Nu, 3: Khac): ", 1, 3); // Nhap gioi tinh
  if (genderChoice)
  {
    if (*genderChoice == 1)
      this->gender = Gender::Male;
    else if (*genderChoice == 2)
      this->gender = Gender::Female;
  }
}

void Person::inputWithoutId() // Nhap thong tin ca nhan khong co ID
{
  name = getValidStringInput("Nhap ten: ", 50, false);
  string dobStr;
  string errorMsg;
  do
  {
    dobStr = getValidStringInput("Nhap ngay sinh (dd/mm/yyyy, vi du: 01/01/1980): ", 10, false);
    this->dob = Date::fromString(dobStr, errorMsg);
    if (!this->dob.isValid())
    {
      cout << "Loi: " << errorMsg << " Vui long nhap lai.\n";
    }
  } while (!this->dob.isValid());
  this->gender = Gender::Other;
  auto genderChoice = getValidIntegerInput("Nhap gioi tinh (1: Nam, 2: Nu, 3: Khac): ", 1, 3);
  if (genderChoice)
  {
    if (*genderChoice == 1)
      this->gender = Gender::Male;
    else if (*genderChoice == 2)
      this->gender = Gender::Female;
  }
}

void Person::display() const // Hien thi thong tin ca nhan
{
  cout << "Ten: " << name << endl;
  cout << "Ngay sinh: " << this->dob.toString() << endl;
  if (!id.empty())
    cout << "ID: " << id << endl;
  cout << "Gioi tinh: ";
  switch (this->gender)
  {
  case Gender::Male:
    cout << "Nam" << endl;
    break;
  case Gender::Female:
    cout << "Nu" << endl;
    break;
  case Gender::Other:
    cout << "Khac" << endl;
    break;
  }
}

void Person::edit() // Chinh sua thong tin ca nhan
{
  cout << "Chinh sua thong tin (ID khong the thay doi):\n";
  inputWithoutId();
}

string Person::getId() const { return id; }// Lay ID

const Date &Person::getDob() const // Lay ngay sinh
{
  return this->dob;
}

const std::string &Person::getName() const // Lay ten
{
  return name;
}

Gender Person::getGender() const { return this->gender; }// Lay gioi tinh

HouseholdHead::HouseholdHead(const string &n, const Date &d, const string &id, Gender g) // Khởi tạo đối tượng HouseholdHead với tên, ngày sinh, ID và
    : Person(n, d, id, g) {}

void HouseholdHead::input() // Nhap thong tin chu ho
{
  Person::input(); // Nhập thông tin cá nhân
}

void HouseholdHead::display() const
{
  Person::display();
}

FamilyMember::FamilyMember(const string &n, const Date &d, const string &id, Gender g, Relationship rel, const string &headId)
    : Person(n, d, id, g), relationship(rel), headId(headId) {} // Khởi tạo đối tượng FamilyMember với tên, ngày sinh, ID, giới tính, mối quan hệ và ID chủ hộ

void FamilyMember::input() // Nhap thong tin thanh vien
{
  Person::input(); // Nhập thông tin cá nhân
}

void FamilyMember::inputHeadIdAndRelationship(string headId) // Nhập ID chủ hộ và mối quan hệ với chủ hộ
{
  this->headId = headId;
  cout << "Nhap quan he voi chu ho:\n";
  cout << "1. Vo/Chong\n2. Con\n3. Cha/Me\n4. Anh/Chi/Em\n5. Khac\n";
  auto relChoice = getValidIntegerInput("Nhap lua chon: ", 1, 5);
  if (!relChoice)
    return;
  switch (*relChoice)
  {
  case 1:
    this->relationship = Relationship::Spouse; // Quan he vo chong
    break;
  case 2:
    this->relationship = Relationship::Child; // Quan he con
    break;
  case 3:
    this->relationship = Relationship::Parent; // Quan he cha me
    break;
  case 4:
    this->relationship = Relationship::Sibling; // Quan he anh chi em
    break;
  default:
    this->relationship = Relationship::None; // Khac
    break;
  }
}

void FamilyMember::inputWithoutId(string id, string headId) // Nhap thong tin thanh vien khong co ID
{
  Person::inputWithoutId();
  this->id = id;
  this->headId = headId;
  cout << "Nhap quan he voi chu ho:\n";
  cout << "1. Vo/Chong\n2. Con\n3. Cha/Me\n4. Anh/Chi/Em\n5. Khac\n";
  auto relChoice = getValidIntegerInput("Nhap lua chon: ", 1, 5);
  if (!relChoice)
    return;
  switch (*relChoice)
  {
  case 1:
    this->relationship = Relationship::Spouse;
    break;
  case 2:
    this->relationship = Relationship::Child;
    break;
  case 3:
    this->relationship = Relationship::Parent;
    break;
  case 4:
    this->relationship = Relationship::Sibling;
    break;
  default:
    this->relationship = Relationship::None;
    break;
  }
}

void FamilyMember::edit() // Chinh sua thong tin thanh vien
{
  cout << "Chinh sua thong tin (ID va ID chu ho khong the thay doi):\n";
  Person::inputWithoutId();
  if (this->relationship != Relationship::None)
  {
    cout << "Nhap quan he voi chu ho:\n";
    cout << "1. Vo/Chong\n2. Con\n3. Cha/Me\n4. Anh/Chi/Em\n5. Khac\n";
    auto relChoice = getValidIntegerInput("Nhap lua chon: ", 1, 5);
    if (!relChoice)
      return;
    switch (*relChoice)
    {
    case 1:
      this->relationship = Relationship::Spouse;
      break;
    case 2:
      this->relationship = Relationship::Child;
      break;
    case 3:
      this->relationship = Relationship::Parent;
      break;
    case 4:
      this->relationship = Relationship::Sibling;
      break;
    default:
      this->relationship = Relationship::None;
      break;
    }
  }
}

void FamilyMember::display() const // Hien thi thong tin thanh vien  
{
  Person::display();
  cout << "Quan he voi chu ho: ";
  switch (this->relationship)
  {
  case Relationship::Spouse:
    cout << "Vo/Chong";
    break;
  case Relationship::Child:
    cout << "Con";
    break;
  case Relationship::Parent:
    cout << "Cha/Me";
    break;
  case Relationship::Sibling:
    cout << "Anh/Chi/Em";
    break;
  case Relationship::None:
    cout << "Khong";
    break;
  }
  cout << endl;
}

Relationship FamilyMember::getRelationship() const { return this->relationship; } // Lấy mối quan hệ với chủ hộ

string FamilyMember::getHeadId() const { return this->headId; } // Lấy ID chủ hộ
