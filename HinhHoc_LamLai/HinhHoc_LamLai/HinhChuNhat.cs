using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhHoc_LamLai
{
	class HinhChuNhat : HinhHoc
	{
		private double chieuDai;
		private double chieuRong;
		public double length
		{
			get { return chieuDai; }
			set { chieuDai = value; }
		}
		public double width
		{
			get { return chieuRong; }
			set { chieuRong = value; }
		}
		public HinhChuNhat() { }
		public HinhChuNhat(double a, double b)
		{
			if (a > b)
			{
				chieuDai = a;
				chieuRong = b;
			}
			else
			{
				chieuDai = b;
				chieuRong = a;
			}
		}
		public override double tinhDT()
		{
			return chieuDai * chieuRong;
		}
		public override double tinhCV()
		{
			return (chieuDai + chieuRong) * 2;
		}
		public override string ToString()
		{
			return "Hinh chu nhat chieu dai " + chieuDai + ", chieu rong " + chieuRong + " co chu vi " + tinhCV() + " va dien tich " + tinhDT();
		}
	}
}
