#include "menu.h"
#include "helpers.h"
#include <iostream>

using namespace std;

Menu::Menu(StreetManager &mgr) : manager(mgr) {}//Khởi tạo đối tượng Menu với tham chiếu đến đối tượng StreetManager. Điều này cho phép Menu truy cập và thao tác với các chức năng của StreetManager.

void Menu::displayMenu() const// Hiển thị menu chính cho người dùng
{
  cout << "\n=== QUAN LY HO DAN ===\n";
  cout << "1. Them ho dan\n";
  cout << "2. Chinh sua ho dan\n";
  cout << "3. Xoa ho dan\n";
  cout << "4. Quan ly thanh vien ho\n";
  cout << "5. Quan ly nguoi dan\n";
  cout << "6. Tim ho tam tru het han\n";
  cout << "7. Hien thi tat ca ho dan\n";
  cout << "8. Tim kiem theo dia chi\n";
  cout << "9. Tim kiem theo ID\n";
  cout << "10. Thong ke theo loai\n";
  cout << "11. Doc du lieu tu file CSV\n";
  cout << "12. Ghi du lieu ra file CSV\n";
  cout << "0. Thoat\n";
  cout << "======================\n";
}

void Menu::run()// Chạy menu chính
{
  while (true)
  {
    displayMenu();
    auto choice = getValidIntegerInput("Nhap lua chon: ", 0, 12);
    if (!choice)
      continue;
    switch (*choice)
    {
    case 0:
      cout << "Tam biet!\n";
      return;
    case 1:
      manager.addHousehold(); //Thêm hộ gia đình
      break;
    case 2:
      manager.editHousehold(); //Chỉnh sửa hộ gia đình
      break;
    case 3:
      manager.deleteHousehold(); //Xóa hộ gia đình
      break;
    case 4:
      manager.manageHouseholdMembers(); //Quản lý thành viên của hộ gia đình
      break;
    case 5:
      manager.managePersons(); //Quản lý thông tin của các thành viên trong hộ gia đình
      break;
    case 6:
      manager.findExpiredTemporaryHouseholds(); //Tìm kiếm và hiển thị danh sách các hộ tạm trú đã hết hạn
      break;
    case 7:
      manager.displayAll();
      break;
    case 8:
    {
      string addr = getValidStringInput("Nhap dia chi can tim: ", 100, false);
      manager.searchByAddress(addr);// Tìm kiếm và hiển thị thông tin của một hộ gia đình dựa trên địa chỉ được cung cấp
      break;
    }
    case 9:
    {
      string id = getValidStringInput("Nhap ID can tim: ", 12, false);
      manager.searchById(id);// Tìm kiếm và hiển thị thông tin của một hộ gia đình dựa trên ID được cung cấp
      break;
    }
    case 10:
      manager.reportByType(); // Thống kê số lượng hộ gia đình theo loại (thường trú, tạm trú)
      break;
    case 11:
      if (manager.loadFromCsv()) // Đọc dữ liệu từ file CSV
        cout << "Doc du lieu thanh cong!\n";
      else
        cout << "Doc du lieu that bai!\n";
      break;
    case 12:
      if (manager.saveToCsv())// Ghi dữ liệu ra file CSV
        cout << "Ghi du lieu thanh cong!\n";
      else
        cout << "Ghi du lieu that bai!\n";
      break;
    }
  }
}
