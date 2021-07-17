using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnThi
{
	class NhanVienBanThoiGian : NhanVien
	{
		public int gioLV;
		public NhanVienBanThoiGian()
		{

		}
		public NhanVienBanThoiGian(string line)
		{
			string[] str = line.Split('*');
			hoTen = str[0];
			ngaySinh = DateTime.Parse(str[1]);
			gioLV = int.Parse(str[2]);
			thang = int.Parse(str[3]);
		}
		public override float TinhLuong()
		{
			float luong = gioLV * 25;
			return luong;
		}
		public override string ToString()
		{
			string str = "{0} {1} {2} {3} {4} {5}\r\n";
			return string.Format(str, hoTen.PadRight(20),
				ngaySinh.ToShortDateString().PadRight(15), "Lam Them".PadRight(15), thang.ToString().PadRight(10),
				(gioLV.ToString() + " gio").PadRight(10), TinhLuong());

		}
	}
}
