using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace proj
{
    public class danhsach
    {
        private static danhsach instance;
        public static danhsach Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new danhsach();
                }
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        List<thongtinBase> listThongTinBase;

        public List<thongtinBase> ListThongTinBase { get => listThongTinBase; set => listThongTinBase = value; }

        private danhsach()
        {
            listThongTinBase = new List<thongtinBase>();

            // Thêm các đối tượng thongtin
            listThongTinBase.Add(new thongtin("Nguyen Van A", "Chu ho", new DateTime(1990, 1, 19), "21 Cach Mang Thang Tam", "Nam", "Can Ngheo", 2));
            listThongTinBase.Add(new thongtin("Tran Van B", "Chu ho", new DateTime(1989, 10, 17), "45 Doan Van Bo", "Nam", "Khong co", 2));
            listThongTinBase.Add(new thongtin("Le Thi D", "Chu ho", new DateTime(1985, 3, 15), "12 Le Loi", "Nu", "Ngheo", 3));
            listThongTinBase.Add(new thongtin("Pham Thi E", "Chu ho", new DateTime(1978, 7, 22), "34 Tran Phu", "Nu", "Can Ngheo", 4));

            // Thêm các đối tượng thongtin1
            listThongTinBase.Add(new thongtin1("Nguyen Van B", "Thanh vien", new DateTime(2004, 12, 1), "21 Cach Mang Thang Tam", "Nam", "Nguyen Van A", "Con"));
            listThongTinBase.Add(new thongtin1("Nguyen Van C", "Thanh vien", new DateTime(2009, 2, 1), "21 Cach Mang Thang Tam", "Nam", "Nguyen Van A", "Con"));
            listThongTinBase.Add(new thongtin1("Tran Van D", "Thanh vien", new DateTime(1990, 3, 1), "45 Doan Van Bo", "Nam", "Tran Van B", "Em"));
            listThongTinBase.Add(new thongtin1("Nguyen Thi E", "Thanh vien", new DateTime(1995, 4, 1), "45 Doan Van Bo", "Nu", "Tran Van B", "Vo"));
            listThongTinBase.Add(new thongtin1("Tran Hung K", "Thanh vien", new DateTime(1989, 6, 23), "12 Le Loi", "Nu", "Le Thi D", "Chong"));
            listThongTinBase.Add(new thongtin1("Le Van F", "Thanh vien", new DateTime(2010, 5, 10), "12 Le Loi", "Nam", "Le Thi D", "Con"));
            listThongTinBase.Add(new thongtin1("Le Thi G", "Thanh vien", new DateTime(2012, 6, 15), "12 Le Loi", "Nu", "Le Thi D", "Con"));
            listThongTinBase.Add(new thongtin1("Nguyen Minh H", "Thanh vien", new DateTime(1978, 7, 20), "34 Tran Phu", "Nam", "Pham Van E", "Chong"));
            listThongTinBase.Add(new thongtin1("Nguyen Thi G", "Thanh vien", new DateTime(2000, 11, 25), "34 Tran Phu", "Nu", "Pham Van E", "Con"));
            listThongTinBase.Add(new thongtin1("Nguyen Van L", "Thanh vien", new DateTime(1995, 6, 18), "34 Tran Phu", "Nam", "Pham Van E", "Em"));
            listThongTinBase.Add(new thongtin1("Nguyen Thi M", "Thanh vien", new DateTime(1998, 8, 30), "34 Tran Phu", "Nu", "Pham Van E", "Em"));

        }

        public void DisplayAll()
        {
            foreach (var item in listThongTinBase)
            {
                item.DisplayInfo();
                Console.WriteLine();
            }
        }
    }
}
