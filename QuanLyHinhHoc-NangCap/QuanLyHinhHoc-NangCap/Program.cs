﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc_NangCap
{
	
	class Program
	{
		static void Main(string[] args)
		{
			DanhSachHinhHoc ds = new DanhSachHinhHoc();
			Menu menu;
			do
			{
				menu = MenuClass.ChonMenu();
				MenuClass.XuLyMenu(ds, menu);
			} while (menu != Menu.Thoat);
		}
	}
}