using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj
{
      
        public class thongtin : thongtinBase
        {
            public string loainhao { get; set; }
            public int sothanhvien { get; set; }

            public thongtin(string hoten, string chucvu, DateTime ngaysinh, string diachi, string gioitinh, string loainhao, int sothanhvien)
                : base(hoten, chucvu, ngaysinh, diachi, gioitinh)
            {
                this.loainhao = loainhao;
                this.sothanhvien = sothanhvien;
            }

            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine($"Loại nhà ở: {loainhao}, Số thành viên: {sothanhvien}");
            }
        }

        public class thongtin1 : thongtinBase
        {
            public string tenchuho { get; set; }
            public string quanhechuho { get; set; }

            public thongtin1(string hoten, string chucvu, DateTime ngaysinh, string diachi, string gioitinh, string tenchuho, string quanhechuho)
                : base(hoten, chucvu, ngaysinh, diachi, gioitinh)
            {
                this.tenchuho = tenchuho;
                this.quanhechuho = quanhechuho;
            }

            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine($"Tên chủ hộ: {tenchuho}, Quan hệ chủ hộ: {quanhechuho}");
            }
        }
    }
