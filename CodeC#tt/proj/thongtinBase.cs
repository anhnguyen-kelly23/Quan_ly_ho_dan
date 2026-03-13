using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj
{
    public class thongtinBase
    {
        public string hoten { get; set; }
        public string chucvu { get; set; }
        public DateTime ngaysinh { get; set; }
        public string diachi { get; set; }
        public string gioitinh { get; set; }

        public thongtinBase(string hoten, string chucvu, DateTime ngaysinh, string diachi, string gioitinh)
        {
            this.hoten = hoten;
            this.chucvu = chucvu;
            this.ngaysinh = ngaysinh;
            this.diachi = diachi;
            this.gioitinh = gioitinh;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Họ tên: {hoten}, Chức vụ: {chucvu}, Ngày sinh: {ngaysinh.ToShortDateString()}, Địa chỉ: {diachi}, Giới tính: {gioitinh}");
        }
    }

}
