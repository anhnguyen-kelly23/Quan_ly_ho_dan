using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Hiển thị toàn bộ danh sách đa hình trong hienthi
            hienthi.DataSource = danhsach.Instance.ListThongTinBase;

            // Lọc danh sách để hiển thị riêng các đối tượng thongtin1 trong hienthi1
            hienthi1.DataSource = danhsach.Instance.ListThongTinBase
                .OfType<thongtin1>()
                .ToList();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hienthi1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
