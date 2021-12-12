using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhSachPhanSo danhSachPhanSo = new DanhSachPhanSo();
            Menu menu = new Menu();
            do
            {
                menu = MenuClass.ChonMenu();
                MenuClass.XuLyMenu(menu, danhSachPhanSo);
            } while (menu!=Menu.ThoatChuongTrinh);
        }
    }
}
