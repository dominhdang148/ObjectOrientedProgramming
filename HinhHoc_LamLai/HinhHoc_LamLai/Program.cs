using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhHoc_LamLai
{
	class Program
	{
		static void Main(string[] args)
		{
			DanhSachHinhHoc hh = new DanhSachHinhHoc();
			Menu menu = new Menu();
			do
			{
				menu = MenuClass.ChonMenu();
				MenuClass.XuLyMenu(hh, menu);
			} while (menu != Menu.ThoatChuongTrinh);
		}
	}
}
